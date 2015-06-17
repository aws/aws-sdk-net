using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Amazon.Util.Internal.PlatformServices
{
    public class ApplicationInfo
    {
        public static string AppTitle
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleDisplayName").ToString();
            }
        }

        public static string AppVersionName
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
            }
        }

        public static string AppVersionCode
        {
            get
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
            }
        }

        public static string PackageName
        {
            get
            {

                return NSBundle.MainBundle.BundleIdentifier;
            }
        }

    }
}