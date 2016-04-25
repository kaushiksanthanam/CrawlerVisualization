namespace CrawlerVisualization
{
    partial class SecondStatsForm
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
            this.secondDataList = new System.Windows.Forms.ListBox();
            this.httpDataGraphControl1 = new CrawlerVisualization.HttpDataGraphControl();
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
            this.splitContainer1.Panel1.Controls.Add(this.secondDataList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.httpDataGraphControl1);
            this.splitContainer1.Size = new System.Drawing.Size(687, 480);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // secondDataList
            // 
            this.secondDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondDataList.FormattingEnabled = true;
            this.secondDataList.Items.AddRange(new object[] {
            "URLs Crawled vs URLs Added",
            "URLs Seen vs URLs Added"});
            this.secondDataList.Location = new System.Drawing.Point(0, 0);
            this.secondDataList.Name = "secondDataList";
            this.secondDataList.Size = new System.Drawing.Size(154, 480);
            this.secondDataList.TabIndex = 0;
            this.secondDataList.SelectedIndexChanged += new System.EventHandler(this.secondDataList_SelectedIndexChanged);
            // 
            // httpDataGraphControl1
            // 
            this.httpDataGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpDataGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.httpDataGraphControl1.Name = "httpDataGraphControl1";
            this.httpDataGraphControl1.Size = new System.Drawing.Size(529, 480);
            this.httpDataGraphControl1.TabIndex = 0;
            // 
            // SecondStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SecondStatsForm";
            this.Text = "Second Data VIEW";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox secondDataList;
        private HttpDataGraphControl httpDataGraphControl1;
    }
}