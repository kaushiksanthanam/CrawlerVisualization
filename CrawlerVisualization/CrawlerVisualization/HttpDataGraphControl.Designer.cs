namespace CrawlerVisualization
{
    partial class HttpDataGraphControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.displayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.displayChart)).BeginInit();
            this.SuspendLayout();
            // 
            // displayChart
            // 
            chartArea1.Name = "ChartArea1";
            this.displayChart.ChartAreas.Add(chartArea1);
            this.displayChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.displayChart.Legends.Add(legend1);
            this.displayChart.Location = new System.Drawing.Point(0, 0);
            this.displayChart.Name = "displayChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.displayChart.Series.Add(series1);
            this.displayChart.Size = new System.Drawing.Size(150, 150);
            this.displayChart.TabIndex = 0;
            this.displayChart.Text = "chart1";
            // 
            // HttpDataGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayChart);
            this.Name = "HttpDataGraphControl";
            ((System.ComponentModel.ISupportInitialize)(this.displayChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart displayChart;
    }
}
