
using System.Globalization;
using System.Runtime.InteropServices;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo 
    {
        public EnvironmentInfo()
        {
            this.Platform = InternalSDKUtils.DetermineOS();
            this.PlatformVersion = InternalSDKUtils.DetermineOSVersion();
            this.PlatformUserAgent = InternalSDKUtils.PlatformUserAgent();
            this.Model = "Unknown";
            this.Make = "Unknown";
            this.Locale = CultureInfo.CurrentCulture.DisplayName;
            this.FrameworkUserAgent =
                string.Format(CultureInfo.InvariantCulture,
                ".NET_Core/{0}",
                InternalSDKUtils.DetermineFramework());
            this.PclPlatform = string.Empty;
        }

        public string Platform { get; private set; }

        public string Model { get; private set; }

        public string Make { get; private set; }

        public string PlatformVersion { get; private set; }

        public string Locale { get; private set; }

        public string PclPlatform { get; private set; }

        public string PlatformUserAgent { get; private set; }

        public string FrameworkUserAgent { get; private set; }
    }
}
