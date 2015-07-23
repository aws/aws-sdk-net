using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.Win32;

namespace Amazon.Util.Internal.PlatformServices
{
    public class EnvironmentInfo : IEnvironmentInfo
    {
        public EnvironmentInfo()
        {
            this.Platform = Environment.OSVersion.Platform.ToString();
            this.PlatformVersion = Environment.OSVersion.Version.ToString();
            this.PlatformUserAgent = Environment.OSVersion.VersionString.Replace(" ", "_");
            this.Model = "Unknown";
            this.Make = "Unknown";
            this.Locale = CultureInfo.CurrentCulture.DisplayName;
            this.FrameworkUserAgent =
                string.Format(CultureInfo.InvariantCulture,
                ".NET_Runtime/{0}.{1} .NET_Framework/{2}",
                 Environment.Version.Major,
                 Environment.Version.MajorRevision,
                 InternalSDKUtils.DetermineFramework());
            this.PclPlatform = string.Empty;
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
