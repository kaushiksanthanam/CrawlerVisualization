using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using System;
using System.IO;
using CrawlerVisualizationBusinessLogic;
using System.Collections.Generic;
using CrawlerVisualization;

namespace CrawlerVisualizationUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            //Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //Graph g = new Graph();
            //g.AddNode(new Node("www.google.com"));
            //g.AddNode(new Node("www.gatech.edu"));
            //g.AddNode(new Node("www.cc.gatech.edu"));
            //g.AddEdge("www.google.com", "www.gatech.edu");
            //g.AddEdge("www.google.com", "www.cc.gatech.edu");
            //viewer.Graph = g;
            //this.Controls.Add(viewer);

        }

        /// <summary>
        /// Method to launch the PeerCrawl Process from inside our application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openPeerCrawlButton_Click(object sender, System.EventArgs e)
        {
            //Delete earlier peer crawled folders
            int returnCode = FolderOperations.DeletePreviousCrawledFiles(Application.StartupPath);

            // This is the command you have to run.
            // java - Xmx1024m - jar PeerCrawl_v5.1.jar
            var commandLineArgs = "-Xmx1024m -jar \"" + Application.StartupPath + "\\PeerCrawl\\PeerCrawl_v5.1.jar\"";

            Process proc = new Process();
            proc.StartInfo.FileName = "java.exe";
            proc.StartInfo.Arguments = commandLineArgs;
            proc.Start();
        }

        private void showVisualizationButton_Click(object sender, EventArgs e)
        {
            HostGraphForm newHost = new HostGraphForm(Application.StartupPath);
            newHost.ShowDialog();
        }

        private void showCrawlStatisticsButton_Click(object sender, EventArgs e)
        {

            HttpData newHttpData = new HttpData();
            int lineNo = -1;
            string[] linesInFile = File.ReadAllLines(Application.StartupPath + "\\stats\\http_data.csv");
            foreach(string line in linesInFile)
            {
                var columns = line.Split(',');
                lineNo++;
                if (lineNo == 0) continue;

                newHttpData.totalContentSize.Add(long.Parse(columns[1]));
                newHttpData.totalURLDropped.Add(long.Parse(columns[2]));
                newHttpData.totalURLDuplicated.Add(long.Parse(columns[3]));
                newHttpData.numberofRobots.Add(long.Parse(columns[4]));
                newHttpData.exception200.Add(long.Parse(columns[5]));
                newHttpData.exception404.Add(long.Parse(columns[6]));
                newHttpData.exception302.Add(long.Parse(columns[7]));
                newHttpData.exception301.Add(long.Parse(columns[8]));
                newHttpData.exception403.Add(long.Parse(columns[9]));
                newHttpData.exception401.Add(long.Parse(columns[10]));
                newHttpData.exception500.Add(long.Parse(columns[11]));
                newHttpData.exception406.Add(long.Parse(columns[12]));
                newHttpData.exception400.Add(long.Parse(columns[13]));
                newHttpData.exceptionOther.Add(long.Parse(columns[14]));
                newHttpData.textHTML.Add(long.Parse(columns[15]));
                newHttpData.imageGIF.Add(long.Parse(columns[16]));
                newHttpData.imageJpeg.Add(long.Parse(columns[17]));
                newHttpData.textPlain.Add(long.Parse(columns[18]));
                newHttpData.applicationsPDF.Add(long.Parse(columns[19]));
                newHttpData.audio.Add(long.Parse(columns[20]));
                newHttpData.zip.Add(long.Parse(columns[21]));
                newHttpData.postScript.Add(long.Parse(columns[22]));
                newHttpData.otherM.Add(long.Parse(columns[23]));

            }

            HttpStatsForm newForm = new HttpStatsForm(newHttpData);
            newForm.Show();

        }

        private void showURLStatsButton_Click(object sender, EventArgs e)
        {
            SecondData secondData = new SecondData();

            int lineNo = -1;
            string[] linesInFile = File.ReadAllLines(Application.StartupPath + "\\stats\\second_data.csv");
            foreach (string line in linesInFile)
            {
                var columns = line.Split(',');
                lineNo++;
                if (lineNo == 0) continue;

                secondData.UrlsCrawledPerSec.Add(long.Parse(columns[1]));
                secondData.UrlsAdddedPerSec.Add(long.Parse(columns[2]));
                secondData.UrlsSeenPerSec.Add(long.Parse(columns[3]));
            }
            SecondStatsForm newForm = new SecondStatsForm(secondData);
            newForm.Show();
        }

    }
}
