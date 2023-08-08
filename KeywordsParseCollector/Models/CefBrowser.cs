using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordsParseCollector.Models
{
    internal class CefBrowser
    {
        public ChromiumWebBrowser chromeBrowser;

        public CefBrowser()
        {
            InitializeChromeBrowser();
        }
        private void InitializeChromeBrowser()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            chromeBrowser = new ChromiumWebBrowser(@"https://trimwork.co/Search?query=battery");

            //this.Controls.Add(chromeBrowser);
            //chromeBrowser.Dock = DockStyle.Fill;
            //chromeBrowser.Visible = false;
        }

        public async Task<string> GetPage()
        {
            await Wait();

            return await chromeBrowser.GetSourceAsync();

            //richTextBox1.AppendText("Waiting End!");
            try
            {
                string html = await chromeBrowser.GetSourceAsync();
                chromeBrowser.GetMainFrame();
                //chromeBrowser.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;

                var frameIdent = chromeBrowser.GetBrowser().GetFrameIdentifiers();

                int allFramesCount = frameIdent.Count();
                int frameHtmlCount = 0;
                string framesStr = string.Empty;
                for (int i = 0; i != frameIdent.Count(); i++)
                {
                    var result = chromeBrowser.GetBrowser().GetFrame(frameIdent[i]).GetSourceAsync().Result;

                    // Needed content here (iframe 3 is кedundant)
                    if (result.Contains("<style id=\"ssr-boilerplate\">"))
                    {
                        frameHtmlCount++;
                        framesStr += $"Frame #{i + 1} code:\n{result}\n\n";
                    }
                }

                /*
                richTextBox1.AppendText(
                    $"All frames count: {allFramesCount}\n" +
                    $"HTML frames count:{frameHtmlCount}\n\n" +
                    $"{framesStr}");
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Wait()
        {
            chromeBrowser.RenderProcessMessageHandler = new RenderProcessMessageHandler();

            bool pageLoad = false;
            bool isLoading = false;
            bool frameLoad = false;
            while (pageLoad == false)
            {
                await Task.Delay(500);

                chromeBrowser.LoadingStateChanged += (sender, args) =>
                {
                    //Wait for the Page to finish loading
                    if (args.IsLoading == false)
                    {
                        //chromeBrowser.ExecuteScriptAsync("alert('All Resources Have Loaded');");
                        isLoading = true;
                    }
                };

                //Wait for the MainFrame to finish loading
                chromeBrowser.FrameLoadEnd += (sender, args) =>
                {
                    //Wait for the MainFrame to finish loading
                    if (args.Frame.IsMain)
                    {
                        //args.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");
                        frameLoad = true;
                    }
                };

                if (isLoading && frameLoad)
                    pageLoad = true;
            }
        }

        public class RenderProcessMessageHandler : IRenderProcessMessageHandler
        {
            public void OnContextReleased(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
            {
                //throw new NotImplementedException();
            }

            public void OnFocusedNodeChanged(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IDomNode node)
            {
                //throw new NotImplementedException();
            }

            public void OnUncaughtException(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, JavascriptException exception)
            {
                //throw new NotImplementedException();
            }

            // Wait for the underlying `Javascript Context` to be created, this is only called for the main frame.
            // If the page has no javascript, no context will be created.
            void IRenderProcessMessageHandler.OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
            {
                //const string script = "document.addEventListener('DOMContentLoaded', function(){ alert('DomLoaded'); });";

                //frame.ExecuteJavaScriptAsync(script);
            }
        }
    }
}
