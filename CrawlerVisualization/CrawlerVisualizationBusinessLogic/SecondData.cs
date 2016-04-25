using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerVisualizationBusinessLogic
{
    public class SecondData
    {
        public List<long> UrlsCrawledPerSec = new List<long>();
        public List<long> UrlsAdddedPerSec = new List<long>();
        public List<long> UrlsSeenPerSec = new List<long>();
        public SecondData()
        {
        }
    }
}
