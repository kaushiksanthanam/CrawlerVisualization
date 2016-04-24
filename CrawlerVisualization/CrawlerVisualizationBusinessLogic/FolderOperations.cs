using System;
using System.IO;

namespace CrawlerVisualizationBusinessLogic
{
    public static class FolderOperations
    {

        #region Public Helper Methods

        public static int DeletePreviousCrawledFiles(string applicationStartupPath)
        {
            try
            {
                var applicationStartup = applicationStartupPath;
                if (Directory.Exists(applicationStartup + "\\saved"))
                {
                    Directory.Delete(applicationStartup + "\\saved", true);
                }
                if (Directory.Exists(applicationStartup + "\\cached"))
                {
                    Directory.Delete(applicationStartup + "\\cached", true);
                }
                if (Directory.Exists(applicationStartup + "\\stats"))
                {
                    Directory.Delete(applicationStartup + "\\stats", true);
                }
            }
            catch(Exception)
            {
                return 1;
            }
            return 0;
        }


        #endregion

    }
}
