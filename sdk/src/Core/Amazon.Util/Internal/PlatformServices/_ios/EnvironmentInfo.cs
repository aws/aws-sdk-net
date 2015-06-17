using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo
    {
        public static string Platform
        {
            get
            {
                return UIDevice.CurrentDevice.SystemName;
            }
        }

        public static string Model
        {
            get
            {
                return UIDevice.CurrentDevice.Model;
            }
        }

        public static string Make
        {
            get
            {
                return @"apple";
            }
        }

        public static string PlatformVersion
        {
            get
            {
                return UIDevice.CurrentDevice.SystemVersion;
            }
        }

        public static string Locale
        {
            get
            {
                return NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            }
        }
    }
}