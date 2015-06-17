using Android.App;
using System;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo
    {
        public static string Platform
        {
            get
            {
                return "ANDROID";
            }
        }

        public static string Model
        {
            get
            {
                return Android.OS.Build.Model;
            }
        }

        public static string Make
        {
            get
            {
                return Android.OS.Build.Manufacturer;
            }
        }

        public static string PlatformVersion
        {
            get
            {
                return Android.OS.Build.VERSION.Release;
            }
        }

        public static string Locale
        {
            get
            {
                return Application.Context.Resources.Configuration.Locale.ToString();
            }
        }
    }
}