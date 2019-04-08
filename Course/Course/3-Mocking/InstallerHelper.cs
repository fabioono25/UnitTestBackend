using System.Net;

namespace Course._3_Mocking
{
    /// <summary>
    /// 1 - Refactor this class to allow UnitTesting (use Moq)
    /// 2 - Implement the unit tests
    /// 3 - Go to OrderService
    /// </summary>
    public class InstallerHelper
    {
        private readonly string _setupDestinationFile;

        public bool DownloadInstaller(string customerName, string installerName)
        {
            var client = new WebClient();
            try
            {
                client.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
