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
    public partial class HostGraphForm : Form
    {
        public string StartupPath;
        public HostGraphForm(string startUpPath)
        {
            StartupPath = startUpPath;
            InitializeComponent();
        }
    }
}
