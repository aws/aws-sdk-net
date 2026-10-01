namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Inputs for generating one service from a single Smithy AST file into a self-contained project
/// referencing <c>AWSSDK.Core</c> from NuGet: no metadata.json, _sdk-versions.json, or
/// Directory.Build.props involved. Parsed from the command line by <c>Program</c>.
/// </summary>
public sealed record StandaloneOptions
{
    // TODO: the generated code needs a minimum Core version (e.g. for PooledContentStream), which a floating version only meets by resolving to the latest.
    // When the generator is packaged as a tool, snapshot CoreVersion from _sdk-versions.json at pack time and use that as the default.
    public const string DefaultCoreVersion = "4.*";
    public const string DefaultVersion = "1.0.0.0";

    /// <summary>The Smithy AST JSON file: one service, all shapes included.</summary>
    public required string ModelPath { get; init; }

    /// <summary>The TFMs the generated csproj targets, in the order given.</summary>
    public required IReadOnlyList<string> TargetFrameworks { get; init; }

    /// <summary>The directory the project lands in; its <c>Generated/</c> subtree is wiped first.</summary>
    public required string OutputDirectory { get; init; }

    /// <summary>The <c>AWSSDK.Core</c> PackageReference version; a floating version is accepted.</summary>
    public string CoreVersion { get; init; } = DefaultCoreVersion;

    /// <summary>The client's version, stamped into its user agent and the csproj.</summary>
    public string Version { get; init; } = DefaultVersion;
}
