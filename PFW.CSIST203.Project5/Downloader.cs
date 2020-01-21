using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFW.CSIST203.Project5
{
    /// <summary>
    /// Downloader class that retrieves a configured list of URLs and saves them into the specified flat file(s)
    /// </summary>
    public class Downloader : IDisposable
    {

        /// <summary>
        /// Configuration data from the config file
        /// </summary>
        internal PFW.CSIST203.Project5.Config.DownloadConfiguration config;

        /// <summary>
        /// Default constructor that uses the standard PFW.CSIST203.Project5.Config.DownloadConfiguration section from the application configuration file
        /// </summary>
        public Downloader() : this("PFW.CSIST203.Project5.Config.DownloadConfiguration")
        {
        }

        public Downloader(string configSectionName)
        {
            // TODO: Implement
        }

        public void Download()
        {
            // TODO: Implement
        }

        private bool disposedValue; // To detect redundant calls

        /// <summary>
        /// Perform disposal of resources in this method
        /// </summary>
        /// <param name="disposing">Redundant call?</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    config = null;
            }
            disposedValue = true;
        }

        /// <summary>
        /// This code added by IDE to correctly implement the disposable pattern.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(true);
        }
    }

}
