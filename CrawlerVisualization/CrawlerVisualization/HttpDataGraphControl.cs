using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerVisualization
{
    public partial class HttpDataGraphControl : UserControl
    {
        public HttpDataGraphControl()
        {
            InitializeComponent();
        }

        public void PlotGraph(List<long> points, string chartName)
        {
            displayChart.Series.Clear();
            displayChart.Series.Add(chartName);
            long xValue = 1;
            displayChart.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach(long point in points)
            {
                displayChart.Series[chartName].Points.AddXY(xValue, point);
                xValue++;
            }
            this.Refresh();
        }

    }
}
