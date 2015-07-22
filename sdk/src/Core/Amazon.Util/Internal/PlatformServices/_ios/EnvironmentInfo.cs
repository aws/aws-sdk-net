using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.Reflection;
using System.Globalization;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public EnvironmentInfo()
        {
            this.Platform = UIDevice.CurrentDevice.SystemName;
            this.Model = UIDevice.CurrentDevice.Model;
            this.Make = "apple";
            this.PlatformVersion = UIDevice.CurrentDevice.SystemVersion;
            this.Locale = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            this.FrameworkUserAgent = InternalSDKUtils.GetMonoRuntimeVersion();
            this.PclPlatform = "PCL/Xamarin.iOS";
            this.PlatformUserAgent = string.Format(CultureInfo.InstalledUICulture,"{0}_{1}", 
                this.Platform.Replace(" ",string.Empty), this.PlatformVersion);
        }

        public string Platform { get; private set; }

        public string PlatformUserAgent { get; private set; }

        public string Model { get; private set; }

        public string Make { get; private set; }

        public string PlatformVersion { get; private set; }

        public string Locale { get; private set; }

        public string FrameworkUserAgent { get; private set; }

        public string PclPlatform { get; private set; }
    }
}