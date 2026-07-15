using System.Globalization;

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
/// Today this derives from a hardcoded list matching the values in <c>sdk/Directory.Build.props</c>
/// (<c>SdkNetFrameworkTargets</c> + <c>SdkNetTargets</c>). Once
/// <see href="https://github.com/aws/aws-sdk-net/pull/4465"/> lands, replace with a loader that
/// reads the props file directly (same approach as <c>AssemblyInfoPlatforms</c> in that PR).
/// </summary>
public static class TargetPlatforms
{
    // TODO: Read from sdk/Directory.Build.props (SdkNetFrameworkTargets + SdkNetTargets) instead of
    // hardcoding. Blocked on https://github.com/aws/aws-sdk-net/pull/4465 merging.
    private static readonly string[] FrameworkTfms = ["net472"];
    private static readonly string[] NetTfms = ["netstandard2.0", "netcoreapp3.1", "net8.0"];

    /// <summary>The .NET Framework targets (<c>SdkNetFrameworkTargets</c>), always shipped.</summary>
    public static IReadOnlyList<TargetPlatform> FrameworkPlatforms { get; } = ToPlatforms(FrameworkTfms);

    /// <summary>
    /// The netstandard-family targets (<c>SdkNetTargets</c>), skipped for services without .NET Standard support.
    /// </summary>
    public static IReadOnlyList<TargetPlatform> NetPlatforms { get; } = ToPlatforms(NetTfms);

    /// <summary>All targets, framework first — the order of the AssemblyInfo <c>#if</c> chain.</summary>
    public static IReadOnlyList<TargetPlatform> Platforms { get; } = [.. FrameworkPlatforms, .. NetPlatforms];

    private static TargetPlatform[] ToPlatforms(string[] tfms) =>
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
