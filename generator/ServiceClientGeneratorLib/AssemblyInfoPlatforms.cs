using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ServiceClientGenerator
{
    /// <summary>
    /// A single target framework the shared Properties/AssemblyInfo.cs is compiled for, together with
    /// the preprocessor symbol used to select it and the human-readable label emitted into the
    /// AssemblyDescription attribute.
    /// </summary>
    public class AssemblyInfoPlatform
    {
        /// <summary>The target framework moniker, e.g. "net472", "netstandard2.0", "net8.0".</summary>
        public string Tfm { get; }

        /// <summary>
        /// The built-in preprocessor symbol for the TFM (uppercase, dots replaced with underscores),
        /// e.g. "NET472", "NETSTANDARD2_0", "NET8_0".
        /// </summary>
        public string Symbol { get; }

        /// <summary>Human-readable label used in the AssemblyDescription, e.g. ".NET 8.0".</summary>
        public string Label { get; }

        public AssemblyInfoPlatform(string tfm, string symbol, string label)
        {
            Tfm = tfm;
            Symbol = symbol;
            Label = label;
        }
    }

    /// <summary>
    /// Derives the set of target frameworks that the shared Properties/AssemblyInfo.cs is compiled for
    /// directly from the Sdk*Targets MSBuild properties in sdk/Directory.Build.props. AssemblyInfo.cs is
    /// referenced by both the .NetFramework and .NetStandard project variants, so the set is the union of
    /// SdkNetFrameworkTargets and SdkNetTargets. Reading the props here means the generated
    /// AssemblyDescription #if/#elif chain adapts automatically when a target is added or removed - the
    /// only edit needed is to Directory.Build.props.
    /// </summary>
    public static class AssemblyInfoPlatforms
    {
        private static IReadOnlyList<AssemblyInfoPlatform> _platforms;

        /// <summary>
        /// Reads the target frameworks from sdk/Directory.Build.props (once). Framework targets are listed
        /// first, then the netstandard targets, matching the historical ordering of the AssemblyInfo chain.
        /// </summary>
        public static void Initialize(string sdkRootFolder)
        {
            var propsPath = Utils.PathCombineAlt(sdkRootFolder, "Directory.Build.props");
            var doc = XDocument.Load(propsPath);

            var frameworkTargets = ReadTargets(doc, "SdkNetFrameworkTargets");
            var netTargets = ReadTargets(doc, "SdkNetTargets");

            var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var platforms = new List<AssemblyInfoPlatform>();
            foreach (var tfm in frameworkTargets.Concat(netTargets))
            {
                if (!seen.Add(tfm))
                    continue;
                platforms.Add(new AssemblyInfoPlatform(tfm, ToPreprocessorSymbol(tfm), FriendlyName(tfm)));
            }

            if (platforms.Count == 0)
                throw new InvalidOperationException(
                    $"No target frameworks found in {propsPath} (SdkNetFrameworkTargets/SdkNetTargets). " +
                    "AssemblyInfo generation requires at least one target framework.");

            _platforms = platforms;
        }

        /// <summary>
        /// The ordered set of platforms the AssemblyInfo.cs files are compiled for. <see cref="Initialize"/>
        /// must have been called first (done during generator startup).
        /// </summary>
        public static IReadOnlyList<AssemblyInfoPlatform> Platforms
        {
            get
            {
                if (_platforms == null)
                    throw new InvalidOperationException(
                        "AssemblyInfoPlatforms.Initialize(sdkRootFolder) must be called before accessing Platforms.");
                return _platforms;
            }
        }

        private static IEnumerable<string> ReadTargets(XDocument doc, string propertyName)
        {
            // Match the element ignoring XML namespace (Directory.Build.props has none, but be defensive).
            var element = doc.Descendants().FirstOrDefault(e => e.Name.LocalName == propertyName);
            if (element == null)
                return Enumerable.Empty<string>();

            return element.Value
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .Where(t => t.Length > 0);
        }

        /// <summary>net472 -> NET472, netstandard2.0 -> NETSTANDARD2_0, net8.0 -> NET8_0.</summary>
        private static string ToPreprocessorSymbol(string tfm)
        {
            return tfm.ToUpperInvariant().Replace('.', '_');
        }

        /// <summary>
        /// Human-readable label for the AssemblyDescription, derived mechanically from the TFM:
        ///   netstandardX.Y -> "NetStandard X.Y"
        ///   netcoreappX.Y  -> ".NET Core X.Y"
        ///   net4xy         -> ".NET Framework 4.x.y"   (a .NET Framework TFM has no '.' in its version)
        ///   netX.Y (X>=5)  -> ".NET X.Y"
        /// </summary>
        public static string FriendlyName(string tfm)
        {
            if (tfm.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase))
                return "NetStandard " + tfm.Substring("netstandard".Length);

            if (tfm.StartsWith("netcoreapp", StringComparison.OrdinalIgnoreCase))
                return ".NET Core " + tfm.Substring("netcoreapp".Length);

            if (tfm.StartsWith("net", StringComparison.OrdinalIgnoreCase))
            {
                var version = tfm.Substring("net".Length);

                // .NET Framework monikers have no dot in the version (net45, net472); modern .NET does (net8.0).
                if (!version.Contains("."))
                {
                    var dotted = string.Join(".", version.Select(c => c.ToString(CultureInfo.InvariantCulture)));
                    return ".NET Framework " + dotted;
                }

                return ".NET " + version;
            }

            // Unknown shape - fall back to the raw TFM so nothing is silently wrong.
            return tfm;
        }
    }
}
