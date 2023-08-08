using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using mshtml;

namespace KeywordsParseCollector.Models
{
    internal class HtmlDownload
    {
        public async Task<string> Download(string url)
        {
            return null;
        }

        internal string LoadHtmlWithBrowser(String url)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate(url);

            WaitTillLoad(webBrowser);

            //HTMLFrameBase frame = webBrowser.Document.GetElementById("yourFrameId").DomElement as HTMLFrameBase;

            string html = string.Empty;

            // webBrowser1.Document.Window.Frames gets a collection of iframes contained in the current document...
            // HTMLWindow is the iterator for the Collection...
            foreach (HtmlWindow frame in webBrowser.Document.Window.Frames)
            {
                html += frame.Document.Body.OuterHtml + "\n\n";
            }

            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(webBrowser.DocumentText);
            return html;

            /*
            var documentAsIHtmlDocument3 = webBrowser.Document.DomDocument;
            StringReader sr = new StringReader(documentAsIHtmlDocument3.documentElement.outerHTML);
            doc.Load(sr);
            */
        }

        private void WaitTillLoad(WebBrowser webBrControl)
        {
            WebBrowserReadyState loadStatus;
            int waittime = 100000;
            int counter = 0;
            while (true)
            {
                loadStatus = webBrControl.ReadyState;
                Application.DoEvents();
                if ((counter > waittime) || (loadStatus == WebBrowserReadyState.Uninitialized) || (loadStatus == WebBrowserReadyState.Loading) || (loadStatus == WebBrowserReadyState.Interactive))
                {
                    break;
                }
                counter++;
            }

            counter = 0;
            while (true)
            {
                loadStatus = webBrControl.ReadyState;
                Application.DoEvents();
                if (loadStatus == WebBrowserReadyState.Complete && webBrControl.IsBusy != true)
                {
                    break;
                }
                counter++;
            }
        }


        private Task WaitForPageLoad(WebBrowser webBrowser)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            webBrowser.DocumentCompleted += (sender, e) =>
            {
                if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
                {
                    tcs.TrySetResult(true);
                }
            };

            return tcs.Task;
        }
    }
}
