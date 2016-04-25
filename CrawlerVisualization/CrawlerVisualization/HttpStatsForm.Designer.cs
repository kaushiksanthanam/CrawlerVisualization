namespace CrawlerVisualization
{
    partial class HttpStatsForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.httpDataGraphControl1 = new CrawlerVisualization.HttpDataGraphControl();
            this.httpDataList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.httpDataList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.httpDataGraphControl1);
            this.splitContainer1.Size = new System.Drawing.Size(778, 481);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // httpDataGraphControl1
            // 
            this.httpDataGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpDataGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.httpDataGraphControl1.Name = "httpDataGraphControl1";
            this.httpDataGraphControl1.Size = new System.Drawing.Size(634, 481);
            this.httpDataGraphControl1.TabIndex = 0;
            // 
            // httpDataList
            // 
            this.httpDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpDataList.FormattingEnabled = true;
            this.httpDataList.Items.AddRange(new object[] {
            "Total Content",
            "Total URLs Dropped",
            "Total URLs Duplicated",
            "Number of Robots",
            "Text/HTML",
            "RC 200(Successful)",
            "RC 404(Page Not Found)",
            "",
            ""});
            this.httpDataList.Location = new System.Drawing.Point(0, 0);
            this.httpDataList.Name = "httpDataList";
            this.httpDataList.Size = new System.Drawing.Size(140, 481);
            this.httpDataList.TabIndex = 0;
            this.httpDataList.SelectedIndexChanged += new System.EventHandler(this.httpDataList_SelectedIndexChanged);
            // 
            // HttpStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 481);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HttpStatsForm";
            this.Text = "HTTP DATA View";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox httpDataList;
        private HttpDataGraphControl httpDataGraphControl1;
    }
}