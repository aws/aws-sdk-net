using System;

namespace SDKDocGenerator
{
    /// <summary>
    /// Abstracts the .Net version from the platform folder.
    /// </summary>
    public class FrameworkVersion : MarshalByRefObject
    {
        public readonly static FrameworkVersion DotNet472 = new FrameworkVersion(".NET Framework 4.7.2", "NET4_7_2");

        public FrameworkVersion(string displayName, string shortName)
        {
            this.DisplayName = displayName;
            this.ShortName = shortName;
        }

        public string DisplayName
        {
            get;
            private set;
        }

        public string ShortName
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return this.DisplayName;
        }

        public static FrameworkVersion FromPlatformFolder(string platformFolder)
        {
            return DotNet472;
        }
    }
}
