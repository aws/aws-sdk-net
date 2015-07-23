using Android.App;
using System;
using System.Globalization;
using System.Reflection;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public EnvironmentInfo()
        {
            this.Platform = "ANDROID";
            this.Model = Android.OS.Build.Model;
            this.Make = Android.OS.Build.Manufacturer;
            this.PlatformVersion = Android.OS.Build.VERSION.Release;
            this.Locale = Application.Context.Resources.Configuration.Locale.ToString();
            this.FrameworkUserAgent = InternalSDKUtils.GetMonoRuntimeVersion();
            this.PclPlatform = "PCL/Xamarin.Android";
            this.PlatformUserAgent = string.Format(CultureInfo.InstalledUICulture,"{0}_{1}", this.Platform, this.PlatformVersion);
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