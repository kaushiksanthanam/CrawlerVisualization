using CrawlerVisualizationBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerVisualization
{
    public partial class HttpStatsForm : Form
    {
        private HttpData _httpData;
        public HttpStatsForm(HttpData httpData)
        {
            _httpData = httpData;
            InitializeComponent();
        }

        private void httpDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(httpDataList.SelectedIndex)
            {
                case 0: plotGraph(_httpData.totalContentSize, "Total Content Size"); break;
                case 1: plotGraph(_httpData.totalURLDropped, "Total URLs Dropped"); break;
                case 2: plotGraph(_httpData.totalURLDuplicated, "Total URLs Duplicated"); break;
                case 3: plotGraph(_httpData.numberofRobots, "Number Of Robots"); break;
                case 4: plotGraph(_httpData.textHTML, "Text HTML Elements"); break;
                case 5: plotGraph(_httpData.exception200, "Succesful HTTP Requests"); break;
                case 6: plotGraph(_httpData.exception404, "404 Page Not Found Exception"); break;
            }
        }

        private void plotGraph(List<long> points, string chartName)
        {
            httpDataGraphControl1.PlotGraph(points, chartName);
        }
    }
}
