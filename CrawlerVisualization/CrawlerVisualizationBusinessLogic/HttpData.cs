using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerVisualizationBusinessLogic
{
    public class HttpData
    {
        public List<long> totalContentSize = new List<long>();
        public List<long> totalURLDropped = new List<long>();
        public List<long> totalURLDuplicated = new List<long>();
        public List<long> numberofRobots = new List<long>();
        public List<long> exception200 = new List<long>();
        public List<long> exception404 = new List<long>();
        public List<long> exception302 = new List<long>();
        public List<long> exception301 = new List<long>();
        public List<long> exception403 = new List<long>();
        public List<long> exception401 = new List<long>();
        public List<long> exception500 = new List<long>();
        public List<long> exception406 = new List<long>();
        public List<long> exception400 = new List<long>();
        public List<long> exceptionOther = new List<long>();
        public List<long> textHTML = new List<long>();
        public List<long> imageGIF = new List<long>();
        public List<long> imageJpeg = new List<long>();
        public List<long> textPlain = new List<long>();
        public List<long> applicationsPDF = new List<long>();
        public List<long> audio = new List<long>();
        public List<long> zip = new List<long>();
        public List<long> postScript = new List<long>();
        public List<long> otherM = new List<long>();

        public HttpData()
        { }

    }
}
