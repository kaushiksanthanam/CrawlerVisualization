using CrawlerVisualizationBusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrawlerVisualization
{
    public partial class SecondStatsForm : Form
    {
        private SecondData _secondData;
        public SecondStatsForm(SecondData secondData)
        {
            _secondData = secondData;
            InitializeComponent();
        }

        private void secondDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(secondDataList.SelectedIndex)
            {
                case 0: PlotGraph(_secondData.UrlsCrawledPerSec, _secondData.UrlsAdddedPerSec, "URLs Crawled Per Sec", "URLs Added Per Sec");
                    break;
                case 1: PlotGraph(_secondData.UrlsSeenPerSec, _secondData.UrlsAdddedPerSec, "URLs Seen Per Sec", "URLs Added Per Sec");
                    break;
            }
        }

        private void PlotGraph(List<long> points1, List<long> points2, string series1Name, string series2Name)
        {
            httpDataGraphControl1.Plot2Series(points1, points2, series1Name, series2Name);
        }
    }
}
