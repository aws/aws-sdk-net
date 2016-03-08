using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public EnvironmentInfo()
        {
            this.Platform = AmazonHookedPlatformInfo.Instance.Platform;
            this.PlatformVersion = AmazonHookedPlatformInfo.Instance.PlatformVersion;
            this.Model = AmazonHookedPlatformInfo.Instance.Model;
            this.Make = AmazonHookedPlatformInfo.Instance.Make;
            this.Locale = AmazonHookedPlatformInfo.Instance.Locale;
            this.FrameworkUserAgent =
                string.Format(CultureInfo.InvariantCulture,
                ".NET_Runtime/{0}.{1} UnityVersion/{2}",
                 Environment.Version.Major,
                 Environment.Version.MajorRevision,
                 AmazonHookedPlatformInfo.Instance.UnityVersion);
            this.PclPlatform = "Unity";
            this.PlatformUserAgent = string.Format(@"unity_{0}_{1}", this.Platform, this.PlatformVersion);
        }

        public string Platform { get; private set; }

        public string Model { get; private set; }

        public string Make { get; private set; }

        public string PlatformVersion { get; private set; }

        public string Locale { get; private set; }

        public string FrameworkUserAgent { get; private set; }

        public string PclPlatform { get; private set; }

        public string PlatformUserAgent { get; private set; }
    }
}
