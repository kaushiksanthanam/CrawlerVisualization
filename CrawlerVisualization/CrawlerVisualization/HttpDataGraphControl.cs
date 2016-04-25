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
            Refresh();
        }

        public void Plot2Series(List<long> series1Points, List<long> series2Points, string series1Name, string series2Name)
        {
            displayChart.Series.Clear();
            displayChart.Series.Add(series1Name);
            long xValue = 1;
            displayChart.Series[series1Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (long point in series1Points)
            {
                displayChart.Series[series1Name].Points.AddXY(xValue, point);
                xValue++;
            }
            xValue = 1;
            displayChart.Series.Add(series2Name);
            displayChart.Series[series2Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach(long point in series2Points)
            {
                displayChart.Series[series2Name].Points.AddXY(xValue, point);
                xValue++;
            }
            Refresh();
        }

    }
}
