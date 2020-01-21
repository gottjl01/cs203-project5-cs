using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace PFW.CSIST203.Project5.Config
{

    public class Urls : System.Configuration.ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            throw new NotImplementedException();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            throw new NotImplementedException();
        }
    }

}
