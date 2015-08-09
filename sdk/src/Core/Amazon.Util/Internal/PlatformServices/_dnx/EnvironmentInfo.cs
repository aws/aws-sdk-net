using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public EnvironmentInfo()
        {
            this.Platform = "Unknown";
            this.PlatformVersion = "Unknown";
            this.PlatformUserAgent = "Unknown";
            this.Model = "Unknown";
            this.Make = "Unknown";
            this.Locale = CultureInfo.CurrentCulture.DisplayName;
            this.FrameworkUserAgent =
                string.Format(CultureInfo.InvariantCulture,
                "CoreCLR");
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
