namespace KeywordsParseCollector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FakeAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopNormalAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopFakeAdsInPageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1623, 85);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop,
            this.toolStripMenuItemClear,
            this.toolStripMenuItemExport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1623, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(64, 29);
            this.toolStripMenuItemStart.Text = "Start";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.toolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Enabled = false;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItemStop.Text = "Stop";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.toolStripMenuItemStop_Click);
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(67, 29);
            this.toolStripMenuItemClear.Text = "Clear";
            this.toolStripMenuItemClear.Click += new System.EventHandler(this.toolStripMenuItemClear_Click);
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(79, 29);
            this.toolStripMenuItemExport.Text = "Export";
            this.toolStripMenuItemExport.Click += new System.EventHandler(this.toolStripMenuItemExport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1199, 921);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1199, 418);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Keyword,
            this.CheckDateTime,
            this.AllAdsInPageCount,
            this.NormalAdsInPageCount,
            this.FakeAdsInPageCount,
            this.TopAdsInPageCount,
            this.TopNormalAdsInPageCount,
            this.TopFakeAdsInPageCount,
            this.Url});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 497);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 85);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chromiumWebBrowser1);
            this.splitContainer2.Size = new System.Drawing.Size(1623, 921);
            this.splitContainer2.SplitterDistance = 1199;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 2;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Enabled = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(418, 921);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 59;
            // 
            // Keyword
            // 
            this.Keyword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Keyword.HeaderText = "Keyword";
            this.Keyword.MinimumWidth = 8;
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            this.Keyword.Width = 105;
            // 
            // CheckDateTime
            // 
            this.CheckDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CheckDateTime.HeaderText = "Date Time";
            this.CheckDateTime.MinimumWidth = 8;
            this.CheckDateTime.Name = "CheckDateTime";
            this.CheckDateTime.ReadOnly = true;
            this.CheckDateTime.Width = 118;
            // 
            // AllAdsInPageCount
            // 
            this.AllAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AllAdsInPageCount.HeaderText = "All Ads In Page";
            this.AllAdsInPageCount.MinimumWidth = 8;
            this.AllAdsInPageCount.Name = "AllAdsInPageCount";
            this.AllAdsInPageCount.ReadOnly = true;
            this.AllAdsInPageCount.Width = 153;
            // 
            // NormalAdsInPageCount
            // 
            this.NormalAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NormalAdsInPageCount.HeaderText = "Normal Ads In Page";
            this.NormalAdsInPageCount.MinimumWidth = 8;
            this.NormalAdsInPageCount.Name = "NormalAdsInPageCount";
            this.NormalAdsInPageCount.ReadOnly = true;
            this.NormalAdsInPageCount.Width = 137;
            // 
            // FakeAdsInPageCount
            // 
            this.FakeAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FakeAdsInPageCount.HeaderText = "Fake Ads In Page";
            this.FakeAdsInPageCount.MinimumWidth = 8;
            this.FakeAdsInPageCount.Name = "FakeAdsInPageCount";
            this.FakeAdsInPageCount.ReadOnly = true;
            this.FakeAdsInPageCount.Width = 125;
            // 
            // TopAdsInPageCount
            // 
            this.TopAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TopAdsInPageCount.HeaderText = "Top Ads In Page";
            this.TopAdsInPageCount.MinimumWidth = 8;
            this.TopAdsInPageCount.Name = "TopAdsInPageCount";
            this.TopAdsInPageCount.ReadOnly = true;
            this.TopAdsInPageCount.Width = 117;
            // 
            // TopNormalAdsInPageCount
            // 
            this.TopNormalAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TopNormalAdsInPageCount.HeaderText = "Top Normal Ads In Page";
            this.TopNormalAdsInPageCount.MinimumWidth = 8;
            this.TopNormalAdsInPageCount.Name = "TopNormalAdsInPageCount";
            this.TopNormalAdsInPageCount.ReadOnly = true;
            this.TopNormalAdsInPageCount.Width = 149;
            // 
            // TopFakeAdsInPageCount
            // 
            this.TopFakeAdsInPageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TopFakeAdsInPageCount.HeaderText = "Top Fake Ads In Page";
            this.TopFakeAdsInPageCount.MinimumWidth = 8;
            this.TopFakeAdsInPageCount.Name = "TopFakeAdsInPageCount";
            this.TopFakeAdsInPageCount.ReadOnly = true;
            this.TopFakeAdsInPageCount.Width = 136;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Url.HeaderText = "Url";
            this.Url.MinimumWidth = 8;
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1006);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FakeAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopNormalAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopFakeAdsInPageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
    }
}

