using CefSharp;
using KeywordsParseCollector.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordsParseCollector
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;// = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStart.Enabled = false;
            toolStripMenuItemClear.Enabled = false;
            toolStripMenuItemExport.Enabled = false;
            toolStripMenuItemStop.Enabled = true;
            richTextBox1.Enabled = false;
            
            _cts = new CancellationTokenSource();
            Start(_cts.Token);
        }
        private void toolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStart.Enabled = true;
            toolStripMenuItemClear.Enabled = true;
            toolStripMenuItemExport.Enabled = true;
            toolStripMenuItemStop.Enabled = false;
            richTextBox1.Enabled = true;

            _cts.Cancel();
            _cts.Dispose();
        }

        private async Task Start(CancellationToken ct)
        {
            int rtbLinesCount = richTextBox1.Lines.Count();

            List<string> sites = SitesList.GetList();

            if (rtbLinesCount == 0)
                MessageBox.Show("Keywords list is empty!");
            else
            {
                for (int i1 = 0; i1 < rtbLinesCount; i1++)
                {
                    ct.ThrowIfCancellationRequested();
                    await Task.Delay(100, ct);

                    string keyword = richTextBox1.Lines[i1].Replace(" ", "+");

                    int id = dataGridView1.RowCount + 1;

                    // !!! Need Add Sites Sorting

                    string url = sites[i1] + keyword;

                    chromiumWebBrowser1.LoadUrl(url);

                    await GetBlocks(id, keyword, url);

                }
                MessageBox.Show("Process Finished!");
            }
            toolStripMenuItemStop.PerformClick();
        }

        private async Task GetBlocks(int id, string keyword, string url)
        {
            List<string> neededBlocks = await GetNeededHtmlBlocks();

            if (neededBlocks == null)
                return;

            DataTableRepository dataTableRepository = new DataTableRepository();

            Parser parser = new Parser();
            dataTableRepository = await parser.Start(neededBlocks);
            dataTableRepository.Keyword = keyword;
            dataTableRepository.Date = System.DateTime.Now;

            /*
            richTextBox1.AppendText(
                $"AllAdsInPageCount: {dataTableRepository.AllAdsInPageCount}\n" +
                $"NormalAdsInPageCount: {dataTableRepository.NormalAdsInPageCount}\n" +
                $"FakeAdsInPageCount: {dataTableRepository.FakeAdsInPageCount}\n" +
                $"TopAdsInPageCount: {dataTableRepository.TopAdsInPageCount}\n" +
                $"TopNormalAdsInPageCount: {dataTableRepository.TopNormalAdsInPageCount}\n" +
                $"TopFakeAdsInPageCount: {dataTableRepository.TopFakeAdsInPageCount}\n");
            */

            string[] row = new string[]
            {
                id.ToString(),
                dataTableRepository.Keyword,
                dataTableRepository.Date.ToString(),
                dataTableRepository.AllAdsInPageCount.ToString(),
                dataTableRepository.NormalAdsInPageCount.ToString(),
                dataTableRepository.FakeAdsInPageCount.ToString(),
                dataTableRepository.TopAdsInPageCount.ToString(),
                dataTableRepository.TopNormalAdsInPageCount.ToString(),
                dataTableRepository.TopFakeAdsInPageCount.ToString(),
                dataTableRepository.Url = url
            };

            dataGridView1.Rows.Add(row);
        }

        private async Task WaitLoadingPage()
        {
            //chromeBrowser.RenderProcessMessageHandler = new RenderProcessMessageHandler();

            bool pageLoad = false;
            bool isLoading = false;
            bool frameLoad = false;
            while (pageLoad == false)
            {
                await Task.Delay(500);

                chromiumWebBrowser1.LoadingStateChanged += (sender, args) =>
                {
                    //Wait for the Page to finish loading
                    if (args.IsLoading == false)
                    {
                        //chromeBrowser.ExecuteScriptAsync("alert('All Resources Have Loaded');");
                        isLoading = true;
                    }
                };

                //Wait for the MainFrame to finish loading
                chromiumWebBrowser1.FrameLoadEnd += (sender, args) =>
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

        public async Task<List<string>> GetNeededHtmlBlocks()
        {
            await WaitLoadingPage();

            List<string> neededBlocks = new List<string>();

            try
            {
                string html = await chromiumWebBrowser1.GetSourceAsync();
                chromiumWebBrowser1.GetMainFrame();
                //chromeBrowser.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;

                var frameIdent = chromiumWebBrowser1.GetBrowser().GetFrameIdentifiers();
                frameIdent = frameIdent.OrderByDescending(f => f).ToList();

                int allFramesCount = frameIdent.Count();
                int frameHtmlCount = 0;
                string framesStr = string.Empty;
                for (int i = 0; i != frameIdent.Count(); i++)
                {
                    var result = chromiumWebBrowser1.GetBrowser().GetFrame(frameIdent[i]).GetSourceAsync().Result;

                    // Needed content here // <style id=\"ssr-boilerplate\">
                    if (result.Contains("<style id=\"ssr-boilerplate\">") && !result.Contains("aria-label=\"\""))
                    {
                        frameHtmlCount++;
                        framesStr += $"Frame #{i + 1} code:\n{result}\n\n";
                        neededBlocks.Add(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return neededBlocks;
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripMenuItemExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
