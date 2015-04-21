using System;

namespace SDKDocGenerator
{
    /// <summary>
    /// Abstracts the .Net version from the platform folder.
    /// </summary>
    public class FrameworkVersion : MarshalByRefObject
    {
        public readonly static FrameworkVersion DotNet35 = new FrameworkVersion(".NET Framework 3.5", "NET3_5");
        public readonly static FrameworkVersion DotNet45 = new FrameworkVersion(".NET Framework 4.5", "NET4_5");

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
            if (platformFolder.Equals("net35", StringComparison.OrdinalIgnoreCase))
                return DotNet35;

            return DotNet45;
        }
    }
}
