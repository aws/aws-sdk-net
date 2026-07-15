using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// A deserialized view of the <c>_sdk-versions.json</c> manifest. Package build versions are not
/// part of the Smithy model but are needed for the generated config's user-agent string, so they are
/// read from here. This also contains additional information such as additional dependencies and preview flags.
/// Load once via <see cref="Load"/>, then resolve per-service versions with
/// <see cref="GetServiceVersion"/>.
/// </summary>
public sealed class SdkVersionManifest
{
    /// <summary>The version stamped on newly onboarded services.</summary>
    [JsonPropertyName("NewServiceVersion")]
    public string? NewServiceVersion { get; init; }

    /// <summary>The overall SDK product version.</summary>
    [JsonPropertyName("ProductVersion")]
    public string? ProductVersion { get; init; }

    /// <summary>The AWSSDK.Core package version every service depends on.</summary>
    [JsonPropertyName("CoreVersion")]
    public string? CoreVersion { get; init; }

    /// <summary>The assembly version override applied to Core (e.g. "4.0").</summary>
    [JsonPropertyName("OverrideCoreVersion")]
    public string? OverrideCoreVersion { get; init; }

    /// <summary>Whether services default to a preview release.</summary>
    [JsonPropertyName("DefaultToPreview")]
    public bool DefaultToPreview { get; init; }

    /// <summary>The NuGet prerelease label applied when in preview (empty when not).</summary>
    [JsonPropertyName("PreviewLabel")]
    public string? PreviewLabel { get; init; }

    /// <summary>The assembly version used when an entry carries no <c>AssemblyVersionOverride</c> (e.g. "4.0").</summary>
    [JsonPropertyName("DefaultAssemblyVersion")]
    public string? DefaultAssemblyVersion { get; init; }

    /// <summary>Per-service version entries, keyed by legacy .NET service name.</summary>
    [JsonPropertyName("ServiceVersions")]
    public IReadOnlyDictionary<string, ServiceVersion> ServiceVersions { get; init; } = new Dictionary<string, ServiceVersion>();

    /// <summary>Per-extension version entries (e.g. "Extensions.Bedrock.MEAI"), same shape as service entries.</summary>
    [JsonPropertyName("ExtensionVersions")]
    public IReadOnlyDictionary<string, ServiceVersion> ExtensionVersions { get; init; } = new Dictionary<string, ServiceVersion>();

    /// <summary>The path the manifest was loaded from, retained for diagnostics.</summary>
    [JsonIgnore]
    public string SourcePath { get; private set; } = "";

    /// <summary>Reads and deserializes the manifest at <paramref name="manifestPath"/>.</summary>
    public static SdkVersionManifest Load(string manifestPath)
    {
        using var stream = File.OpenRead(manifestPath);
        var manifest = JsonSerializer.Deserialize<SdkVersionManifest>(stream)
            ?? throw new GeneratorException($"'{manifestPath}' deserialized to null.");
        manifest.SourcePath = manifestPath;
        return manifest;
    }

    /// <summary>
    /// Returns the <c>Version</c> for <paramref name="serviceName"/>. Throws when the service has no
    /// entry or the entry carries no version.
    /// </summary>
    public string GetServiceVersion(string serviceName)
    {
        // TODO: serviceName is the normalized sdkId, but _sdk-versions.json is keyed by legacy .NET
        // service names. Most match, but some don't (sdkId DynamoDB → manifest DynamoDBv2, EFS →
        // ElasticFileSystem, EMR → ElasticMapReduce); those will throw below until a mapping is added.
        if (!ServiceVersions.TryGetValue(serviceName, out var entry))
        {
            throw new GeneratorException($"'{SourcePath}' has no version entry for service '{serviceName}'.");
        }

        if (entry.Version is not string version)
        {
            throw new GeneratorException($"Service '{serviceName}' in '{SourcePath}' has no 'Version' field.");
        }

        return version;
    }

    /// <summary>
    /// Returns the assembly version for <paramref name="serviceName"/>: the entry's
    /// <c>AssemblyVersionOverride</c> when present, otherwise <c>major.minor</c> of the file version
    /// (matching the C2J generator's <c>Utils.GetVersion</c> fallback).
    /// </summary>
    public string GetServiceAssemblyVersion(string serviceName)
    {
        if (!ServiceVersions.TryGetValue(serviceName, out var entry))
        {
            throw new GeneratorException($"'{SourcePath}' has no version entry for service '{serviceName}'.");
        }

        if (!string.IsNullOrEmpty(entry.AssemblyVersionOverride))
        {
            return entry.AssemblyVersionOverride;
        }

        if (string.IsNullOrEmpty(entry.Version))
        {
            throw new GeneratorException($"Service '{serviceName}' in '{SourcePath}' has no AssemblyVersionOverride and no Version to derive major.minor from.");
        }

        if (!Version.TryParse(entry.Version, out var parsed))
        {
            throw new GeneratorException($"Service '{serviceName}' in '{SourcePath}' has an unparseable Version '{entry.Version}'.");
        }

        return new Version(parsed.Major, parsed.Minor).ToString();
    }
}

/// <summary>A single service or extension entry under <c>ServiceVersions</c>/<c>ExtensionVersions</c>.</summary>
public sealed record ServiceVersion
{
    /// <summary>The package build version (e.g. "4.0.101.3").</summary>
    [JsonPropertyName("Version")]
    public string? Version { get; init; }

    /// <summary>The assembly version override (e.g. "4.0"), pinned across patch releases.</summary>
    [JsonPropertyName("AssemblyVersionOverride")]
    public string? AssemblyVersionOverride { get; init; }

    /// <summary>Package dependency versions keyed by package name (always includes "Core").</summary>
    [JsonPropertyName("Dependencies")]
    public IReadOnlyDictionary<string, string> Dependencies { get; init; } = new Dictionary<string, string>();

    /// <summary>Whether this service/extension is in preview.</summary>
    [JsonPropertyName("InPreview")]
    public bool InPreview { get; init; }
}
