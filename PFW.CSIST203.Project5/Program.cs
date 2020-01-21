using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFW.CSIST203.Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a downloader and retrieve the html from the internet
            using (var downloader = new Downloader())
            {
                downloader.Download();
            }
        }
    }
}
