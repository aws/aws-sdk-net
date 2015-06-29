using Android.App;
using System;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public string Platform
        {
            get
            {
                return "ANDROID";
            }
        }

        public string Model
        {
            get
            {
                return Android.OS.Build.Model;
            }
        }

        public string Make
        {
            get
            {
                return Android.OS.Build.Manufacturer;
            }
        }

        public string PlatformVersion
        {
            get
            {
                return Android.OS.Build.VERSION.Release;
            }
        }

        public string Locale
        {
            get
            {
                return Application.Context.Resources.Configuration.Locale.ToString();
            }
        }
    }
}