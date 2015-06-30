using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo : IApplicationInfo
    {
        public string AppTitle
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleDisplayName").ToString();
            }
        }

        public string AppVersionName
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
            }
        }

        public string AppVersionCode
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
            }
        }

        public string PackageName
        {
            get
            {
                return NSBundle.MainBundle.BundleIdentifier;
            }
        }
    }
}