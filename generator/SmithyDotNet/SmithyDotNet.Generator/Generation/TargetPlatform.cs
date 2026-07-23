using System.Globalization;
using System.Xml;
using System.Xml.Linq;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// A single target framework the SDK ships for, with its preprocessor symbol and human-readable
/// label for the <c>AssemblyDescription</c> attribute.
/// </summary>
public sealed record TargetPlatform(string Tfm, string Symbol, string Label);

/// <summary>
/// Provides the ordered set of target platforms the SDK currently builds. The assembly info,
/// nuspec, and project file writers all consume this so the TFM list is defined once.
/// <para/>
/// The TFMs are read from the <c>SdkNetFrameworkTargets</c> and <c>SdkNetTargets</c> properties in
/// <c>sdk/Directory.Build.props</c> (the single source of truth added by
/// <see href="https://github.com/aws/aws-sdk-net/pull/4465"/>), so adding or removing a target only
/// requires editing that file. <see cref="Initialize"/> must be called once at generator startup
/// before any accessor is used; the tests do this from their shared fixture. The loader mirrors the
/// C2J generator's <c>AssemblyInfoPlatforms</c>.
/// </summary>
public static class TargetPlatforms
{
    private static IReadOnlyList<TargetPlatform>? _frameworkPlatforms;
    private static IReadOnlyList<TargetPlatform>? _netPlatforms;

    /// <summary>
    /// Reads the target frameworks from <c>sdk/Directory.Build.props</c> (once). Framework targets
    /// (<c>SdkNetFrameworkTargets</c>) are listed first, then the netstandard targets
    /// (<c>SdkNetTargets</c>), matching the order of the AssemblyInfo <c>#if</c> chain.
    /// </summary>
    public static void Initialize(string sdkRootFolder)
    {
        var propsPath = Utils.PathCombineAlt(sdkRootFolder, "Directory.Build.props");

        XDocument doc;
        try
        {
            doc = XDocument.Load(propsPath);
        }
        catch (XmlException ex)
        {
            // Surface malformed props as a generator config error so it reports cleanly like every
            // other failure rather than crashing with an unhandled XmlException.
            throw new GeneratorException($"Failed to parse '{propsPath}': {ex.Message}", ex);
        }

        var frameworkTfms = ReadTargets(doc, "SdkNetFrameworkTargets");
        var netTfms = ReadTargets(doc, "SdkNetTargets");

        if (frameworkTfms.Count == 0 && netTfms.Count == 0)
        {
            throw new GeneratorException(
                $"No target frameworks found in '{propsPath}' (SdkNetFrameworkTargets/SdkNetTargets). " +
                "Target platform generation requires at least one target framework.");
        }

        _frameworkPlatforms = ToPlatforms(frameworkTfms);
        _netPlatforms = ToPlatforms(netTfms);
    }

    /// <summary>The .NET Framework targets (<c>SdkNetFrameworkTargets</c>), always shipped.</summary>
    public static IReadOnlyList<TargetPlatform> FrameworkPlatforms => _frameworkPlatforms ?? throw NotInitialized();

    /// <summary>
    /// The netstandard-family targets (<c>SdkNetTargets</c>), skipped for services without .NET Standard support.
    /// </summary>
    public static IReadOnlyList<TargetPlatform> NetPlatforms => _netPlatforms ?? throw NotInitialized();

    /// <summary>All targets, framework first — the order of the AssemblyInfo <c>#if</c> chain.</summary>
    public static IReadOnlyList<TargetPlatform> Platforms => [.. FrameworkPlatforms, .. NetPlatforms];

    private static GeneratorException NotInitialized() =>
        new("TargetPlatforms.Initialize(sdkRootFolder) must be called before accessing target platforms.");

    // Reads a semicolon-separated TFM list from a Directory.Build.props property, ignoring XML
    // namespaces (the file has none, but be defensive). Absent property → empty list.
    private static IReadOnlyList<string> ReadTargets(XDocument doc, string propertyName)
    {
        var element = doc.Descendants().FirstOrDefault(e => e.Name.LocalName == propertyName);
        if (element is null)
        {
            return [];
        }

        return element.Value.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    }

    private static TargetPlatform[] ToPlatforms(IReadOnlyList<string> tfms) =>
        tfms.Select(tfm => new TargetPlatform(tfm, ToPreprocessorSymbol(tfm), FriendlyName(tfm))).ToArray();

    /// <summary>net472 → NET472, netstandard2.0 → NETSTANDARD2_0, net8.0 → NET8_0.</summary>
    private static string ToPreprocessorSymbol(string tfm) => tfm.ToUpperInvariant().Replace('.', '_');

    /// <summary>
    /// Human-readable label for the AssemblyDescription, derived mechanically from the TFM.
    /// Matches the logic in the C2J generator's <c>AssemblyInfoPlatforms.FriendlyName</c>.
    /// </summary>
    public static string FriendlyName(string tfm)
    {
        if (tfm.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase))
        {
            return string.Concat("NetStandard ", tfm.AsSpan("netstandard".Length));
        }

        if (tfm.StartsWith("netcoreapp", StringComparison.OrdinalIgnoreCase))
        {
            return string.Concat(".NET Core ", tfm.AsSpan("netcoreapp".Length));
        }

        if (tfm.StartsWith("net", StringComparison.OrdinalIgnoreCase))
        {
            var version = tfm.Substring("net".Length);

            // .NET Framework monikers have no dot in the version (net45, net472); modern .NET does (net8.0).
            if (!version.Contains('.'))
            {
                var dotted = string.Join(".", version.Select(c => c.ToString(CultureInfo.InvariantCulture)));
                return ".NET Framework " + dotted;
            }

            return ".NET " + version;
        }

        return tfm;
    }
}
