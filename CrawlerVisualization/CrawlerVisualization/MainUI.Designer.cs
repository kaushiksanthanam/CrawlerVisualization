namespace CrawlerVisualizationUI
{
    partial class MainUI
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
            this.openPeerCrawlButton = new System.Windows.Forms.Button();
            this.showVisualizationButton = new System.Windows.Forms.Button();
            this.showCrawlStatisticsButton = new System.Windows.Forms.Button();
            this.showURLStatsButton = new System.Windows.Forms.Button();
            this.visualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.visualizationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openPeerCrawlButton
            // 
            this.openPeerCrawlButton.BackColor = System.Drawing.Color.SkyBlue;
            this.openPeerCrawlButton.Location = new System.Drawing.Point(19, 12);
            this.openPeerCrawlButton.Name = "openPeerCrawlButton";
            this.openPeerCrawlButton.Size = new System.Drawing.Size(258, 51);
            this.openPeerCrawlButton.TabIndex = 0;
            this.openPeerCrawlButton.Text = "Run a new Crawl using Peer Crawl";
            this.openPeerCrawlButton.UseVisualStyleBackColor = false;
            this.openPeerCrawlButton.Click += new System.EventHandler(this.openPeerCrawlButton_Click);
            // 
            // showVisualizationButton
            // 
            this.showVisualizationButton.Location = new System.Drawing.Point(7, 39);
            this.showVisualizationButton.Name = "showVisualizationButton";
            this.showVisualizationButton.Size = new System.Drawing.Size(258, 52);
            this.showVisualizationButton.TabIndex = 1;
            this.showVisualizationButton.Text = "Show Crawl Visualization";
            this.showVisualizationButton.UseVisualStyleBackColor = true;
            this.showVisualizationButton.Click += new System.EventHandler(this.showVisualizationButton_Click);
            // 
            // showCrawlStatisticsButton
            // 
            this.showCrawlStatisticsButton.Location = new System.Drawing.Point(6, 180);
            this.showCrawlStatisticsButton.Name = "showCrawlStatisticsButton";
            this.showCrawlStatisticsButton.Size = new System.Drawing.Size(258, 52);
            this.showCrawlStatisticsButton.TabIndex = 2;
            this.showCrawlStatisticsButton.Text = "Show Crawl HTTP Statistics";
            this.showCrawlStatisticsButton.UseVisualStyleBackColor = true;
            this.showCrawlStatisticsButton.Click += new System.EventHandler(this.showCrawlStatisticsButton_Click);
            // 
            // showURLStatsButton
            // 
            this.showURLStatsButton.Location = new System.Drawing.Point(7, 110);
            this.showURLStatsButton.Name = "showURLStatsButton";
            this.showURLStatsButton.Size = new System.Drawing.Size(258, 52);
            this.showURLStatsButton.TabIndex = 3;
            this.showURLStatsButton.Text = "Show Crawl URL Statistics";
            this.showURLStatsButton.UseVisualStyleBackColor = true;
            this.showURLStatsButton.Click += new System.EventHandler(this.showURLStatsButton_Click);
            // 
            // visualizationGroupBox
            // 
            this.visualizationGroupBox.Controls.Add(this.showCrawlStatisticsButton);
            this.visualizationGroupBox.Controls.Add(this.showURLStatsButton);
            this.visualizationGroupBox.Controls.Add(this.showVisualizationButton);
            this.visualizationGroupBox.Location = new System.Drawing.Point(12, 81);
            this.visualizationGroupBox.Name = "visualizationGroupBox";
            this.visualizationGroupBox.Size = new System.Drawing.Size(270, 268);
            this.visualizationGroupBox.TabIndex = 4;
            this.visualizationGroupBox.TabStop = false;
            this.visualizationGroupBox.Text = "Visualization Options";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 359);
            this.Controls.Add(this.visualizationGroupBox);
            this.Controls.Add(this.openPeerCrawlButton);
            this.Name = "MainUI";
            this.Text = "Crawler Visualization";
            this.visualizationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openPeerCrawlButton;
        private System.Windows.Forms.Button showVisualizationButton;
        private System.Windows.Forms.Button showCrawlStatisticsButton;
        private System.Windows.Forms.Button showURLStatsButton;
        private System.Windows.Forms.GroupBox visualizationGroupBox;
    }
}

