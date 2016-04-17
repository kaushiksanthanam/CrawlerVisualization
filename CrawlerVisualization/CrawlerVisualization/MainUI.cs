using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using System;
using System.IO;
using CrawlerVisualizationBusinessLogic;

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

        }
    }
}
