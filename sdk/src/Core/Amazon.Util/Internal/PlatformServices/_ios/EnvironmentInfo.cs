using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public string Platform
        {
            get
            {
                return UIDevice.CurrentDevice.SystemName;
            }
        }

        public string Model
        {
            get
            {
                return UIDevice.CurrentDevice.Model;
            }
        }

        public string Make
        {
            get
            {
                return @"apple";
            }
        }

        public string PlatformVersion
        {
            get
            {
                return UIDevice.CurrentDevice.SystemVersion;
            }
        }

        public string Locale
        {
            get
            {
                return NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            }
        }
    }
}