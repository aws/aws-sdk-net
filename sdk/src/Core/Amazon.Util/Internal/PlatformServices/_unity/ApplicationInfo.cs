using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo : IApplicationInfo
    {
        public string AppTitle
        {
            get
            {
                return AmazonHookedPlatformInfo.Instance.Title;
            }
        }

        public string AppVersionName
        {
            get
            {
                return AmazonHookedPlatformInfo.Instance.VersionName;
            }
        }

        public string AppVersionCode
        {
            get
            {
                return AmazonHookedPlatformInfo.Instance.VersionCode;
            }
        }

        public string PackageName
        {
            get
            {
                return AmazonHookedPlatformInfo.Instance.PackageName;
            }
        }

    }
}