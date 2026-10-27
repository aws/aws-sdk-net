using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Manifests;

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

    /// <summary>Per-extension version entries (e.g. "Extensions.CborProtocol"), same shape as service entries.</summary>
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
    /// Returns the <c>Version</c> for <paramref name="serviceName"/>, or <see cref="DefaultAssemblyVersion"/>
    /// when the service has no entry. Throws when the entry carries no version.
    /// </summary>
    public string GetServiceVersion(string serviceName)
    {
        // Keyed by GenerationContext.ServiceName, which honors the metadata.json overrides.
        if (!ServiceVersions.TryGetValue(serviceName, out var entry))
        {
            // Test services and not-yet-resolved new services have no entry, as in C2J.
            return DefaultAssemblyVersion ?? throw new GeneratorException($"'{SourcePath}' has no version entry for service '{serviceName}' and no 'DefaultAssemblyVersion'.");
        }

        if (entry.Version is not string version)
        {
            throw new GeneratorException($"Service '{serviceName}' in '{SourcePath}' has no 'Version' field.");
        }

        return version;
    }

    /// <summary>The package version of <paramref name="serviceName"/>: <see cref="GetServiceVersion"/> plus the preview label while in preview.</summary>
    public string GetPackageVersion(string serviceName) =>
        GetServiceVersion(serviceName) + Label(ServiceVersions.TryGetValue(serviceName, out var entry) && entry.InPreview);

    /// <summary>
    /// The nuspec range for <paramref name="serviceName"/>'s dependency on <paramref name="dependency"/>, from the version its own
    /// entry pins (the release keeps it current; C2J uses it rather than the dependency's <c>Version</c>).
    /// </summary>
    public string GetServiceDependencyRange(string serviceName, string dependency)
    {
        if (!ServiceVersions.TryGetValue(serviceName, out var entry) || !entry.Dependencies.TryGetValue(dependency, out var version))
        {
            throw new GeneratorException($"'{SourcePath}' has no '{dependency}' dependency version for service '{serviceName}'.");
        }

        return Range(version, ServiceVersions.TryGetValue(dependency, out var dependencyEntry) && dependencyEntry.InPreview);
    }

    /// <summary>The nuspec range for the <c>Extensions.{extensionName}</c> entry under <c>ExtensionVersions</c>.</summary>
    public string GetExtensionRange(string extensionName)
    {
        var (version, entry) = GetExtension(extensionName);
        return Range(version, entry.InPreview);
    }

    /// <summary>The <c>Extensions.{extensionName}</c> entry under <c>ExtensionVersions</c> and its <c>Version</c>.</summary>
    public (string Version, ServiceVersion Entry) GetExtension(string extensionName)
    {
        var key = $"Extensions.{extensionName}";
        if (!ExtensionVersions.TryGetValue(key, out var entry))
        {
            throw new GeneratorException($"'{SourcePath}' has no version entry for extension '{key}'.");
        }

        if (entry.Version is not string version)
        {
            throw new GeneratorException($"Extension '{key}' in '{SourcePath}' has no 'Version' field.");
        }

        return (version, entry);
    }

    /// <summary>The assembly version of the <c>Extensions.{extensionName}</c> entry, as <see cref="GetServiceAssemblyVersion"/> resolves a service's.</summary>
    public string GetExtensionAssemblyVersion(string extensionName) => AssemblyVersion(GetExtension(extensionName).Entry, $"Extension 'Extensions.{extensionName}'");

    /// <summary>The AWSSDK.Core file version.</summary>
    public string GetCoreVersion() => CoreVersion ?? throw new GeneratorException($"'{SourcePath}' has no 'CoreVersion' field.");

    /// <summary>The AWSSDK.Core assembly version: <c>major.minor</c> of <see cref="OverrideCoreVersion"/>, or of the file version without one.</summary>
    public string GetCoreAssemblyVersion() => MajorMinor(OverrideCoreVersion ?? GetCoreVersion());

    /// <summary>The AWSSDK.Core package version: the file version plus the preview label under <see cref="DefaultToPreview"/>.</summary>
    public string GetCorePackageVersion() => GetCoreVersion() + Label(inPreview: false);

    /// <summary>The nuspec range for AWSSDK.Core.</summary>
    public string GetCoreRange() => Range(GetCoreVersion(), inPreview: false);

    // A dependency in preview is pinned to preview builds: the label goes on both bounds, as in C2J.
    private string Range(string version, bool inPreview)
    {
        var label = Label(inPreview);
        return $"[{version}{label}, {ParseVersion(version).Major + 1}.0{label})";
    }

    // As in C2J, DefaultToPreview puts every package in preview, and the file stores the label without its '-'.
    private string Label(bool inPreview) =>
        (inPreview || DefaultToPreview) && !string.IsNullOrEmpty(PreviewLabel) ? $"-{PreviewLabel}" : "";

    /// <summary>
    /// Returns the assembly version for <paramref name="serviceName"/>: the entry's
    /// <c>AssemblyVersionOverride</c> when present, otherwise <c>major.minor</c> of the file version
    /// (matching the C2J generator's <c>Utils.GetVersion</c> fallback), or <see cref="DefaultAssemblyVersion"/>
    /// when the service has no entry.
    /// </summary>
    public string GetServiceAssemblyVersion(string serviceName)
    {
        if (!ServiceVersions.TryGetValue(serviceName, out var entry))
        {
            return DefaultAssemblyVersion ?? throw new GeneratorException($"'{SourcePath}' has no version entry for service '{serviceName}' and no 'DefaultAssemblyVersion'.");
        }

        return AssemblyVersion(entry, $"Service '{serviceName}'");
    }

    private string AssemblyVersion(ServiceVersion entry, string owner)
    {
        if (!string.IsNullOrEmpty(entry.AssemblyVersionOverride))
        {
            return entry.AssemblyVersionOverride;
        }

        if (string.IsNullOrEmpty(entry.Version))
        {
            throw new GeneratorException($"{owner} in '{SourcePath}' has no AssemblyVersionOverride and no Version to derive major.minor from.");
        }

        return MajorMinor(entry.Version);
    }

    // C2J's Utils.GetVersion.
    private string MajorMinor(string version)
    {
        var parsed = ParseVersion(version);
        return new Version(parsed.Major, parsed.Minor).ToString();
    }

    private Version ParseVersion(string version) =>
        Version.TryParse(version, out var parsed) ? parsed : throw new GeneratorException($"'{SourcePath}' has an unparseable version '{version}'.");
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
