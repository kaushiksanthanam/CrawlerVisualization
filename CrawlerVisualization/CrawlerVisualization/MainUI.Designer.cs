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
            this.SuspendLayout();
            // 
            // openPeerCrawlButton
            // 
            this.openPeerCrawlButton.Location = new System.Drawing.Point(13, 13);
            this.openPeerCrawlButton.Name = "openPeerCrawlButton";
            this.openPeerCrawlButton.Size = new System.Drawing.Size(258, 51);
            this.openPeerCrawlButton.TabIndex = 0;
            this.openPeerCrawlButton.Text = "Run a new Crawl using Peer Crawl";
            this.openPeerCrawlButton.UseVisualStyleBackColor = true;
            this.openPeerCrawlButton.Click += new System.EventHandler(this.openPeerCrawlButton_Click);
            // 
            // showVisualizationButton
            // 
            this.showVisualizationButton.Location = new System.Drawing.Point(13, 87);
            this.showVisualizationButton.Name = "showVisualizationButton";
            this.showVisualizationButton.Size = new System.Drawing.Size(258, 52);
            this.showVisualizationButton.TabIndex = 1;
            this.showVisualizationButton.Text = "Show Visualization";
            this.showVisualizationButton.UseVisualStyleBackColor = true;
            this.showVisualizationButton.Click += new System.EventHandler(this.showVisualizationButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 151);
            this.Controls.Add(this.showVisualizationButton);
            this.Controls.Add(this.openPeerCrawlButton);
            this.Name = "MainUI";
            this.Text = "Crawler Visualization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openPeerCrawlButton;
        private System.Windows.Forms.Button showVisualizationButton;
    }
}

