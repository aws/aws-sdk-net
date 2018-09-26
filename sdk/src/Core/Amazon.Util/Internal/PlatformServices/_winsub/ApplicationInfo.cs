using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo : IApplicationInfo
    {
        public string AppTitle
        {
            get
            {
                return "Windows";
            }
        }

        public string AppVersionName
        {
            get
            {
 

                return string.Format("0.0.0.0");
            }
        }

        public string AppVersionCode
        {
            get
            {
 

                return string.Format("0");
            }
        }

        public string PackageName
        {
            get
            {
                return "Windows";
            }
        }

    }
}