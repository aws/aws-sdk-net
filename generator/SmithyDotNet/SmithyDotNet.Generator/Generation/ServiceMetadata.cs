using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// The service's <c>metadata.json</c> (e.g.
/// <c>generator/ServiceModels/cloudtrail-data/metadata.json</c>). These values are not part of the
/// Smithy model but drive generator decisions the model can't express - package naming, the NuGet
/// synopsis, whether to emit client constructors - so they are loaded here and threaded through the
/// <see cref="GenerationContext"/> to the writers that need them.
/// </summary>
public record ServiceMetadata
{
    /// <summary>Whether the service is active for generation.</summary>
    [JsonPropertyName("active")]
    public bool Active { get; init; }

    /// <summary>The NuGet package synopsis/description.</summary>
    [JsonPropertyName("synopsis")]
    public string? Synopsis { get; init; }

    /// <summary>Whether to emit public client constructors.</summary>
    [JsonPropertyName("generate-client-constructors")]
    public bool GenerateClientConstructors { get; init; }

    /// <summary>The legacy C2J service id, when the .NET name diverges from the Smithy <c>sdkId</c>.</summary>
    [JsonPropertyName("legacy-service-id")]
    public string? LegacyServiceId { get; init; }

    /// <summary>The service base name override used for the assembly/package name (e.g. "DynamoDBv2").</summary>
    [JsonPropertyName("base-name")]
    public string? BaseName { get; init; }

    /// <summary>The .NET namespace override, when the service diverges from the default.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>Free-form tags declared for the service.</summary>
    [JsonPropertyName("tags")]
    public IReadOnlyList<string> Tags { get; init; } = [];

    /// <summary>The Url to the license for the service</summary>
    [JsonPropertyName("license-url")]
    public string? LicenseUrl { get; init; }

    /// <summary>A list of dependencies for this service</summary>
    [JsonPropertyName("dependencies")]
    public IReadOnlyList<string> Dependencies { get; init; } = [];

    /// <summary>
    /// Platform-specific NuGet package dependencies (e.g. signin's BouncyCastle.Cryptography),
    /// or <c>null</c> when the service declares none.
    /// </summary>
    [JsonPropertyName("nuget-dependencies")]
    public NugetDependencies? NugetDependencies { get; init; }

    /// <summary>
    /// Whether or not the service supports netstandard. Currently only false for MobilAnalytics Service.
    /// </summary>
    [JsonPropertyName("netstandard-support")]
    public bool NetStandardSupport { get; init; } = true;
    /// <summary>
    /// Loads and deserializes the <c>metadata.json</c> at <paramref name="metadataPath"/>.
    /// </summary>
    public static ServiceMetadata Load(string metadataPath)
    {
        using var stream = File.OpenRead(metadataPath);
        return JsonSerializer.Deserialize<ServiceMetadata>(stream)
            ?? throw new GeneratorException($"'{metadataPath}' deserialized to null.");
    }
}

/// <summary>
/// NuGet dependencies grouped by target framework family, as declared under a service's
/// <c>nuget-dependencies</c> key.
/// </summary>
public record NugetDependencies
{
    /// <summary>Dependencies applied to .NET Standard / .NET (Core) targets.</summary>
    [JsonPropertyName("NetStandard")]
    public IReadOnlyList<NugetDependency> NetStandard { get; init; } = [];

    /// <summary>Dependencies applied to .NET Framework targets.</summary>
    [JsonPropertyName("NetFramework")]
    public IReadOnlyList<NugetDependency> NetFramework { get; init; } = [];
}

/// <summary>A single NuGet package dependency and the target frameworks it applies to.</summary>
public record NugetDependency
{
    /// <summary>The NuGet package id (e.g. "BouncyCastle.Cryptography").</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The package version (e.g. "2.6.2").</summary>
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    /// <summary>
    /// The specific target frameworks this dependency applies to (e.g. "netstandard2.0"), or empty
    /// when it applies to every target in its family.
    /// </summary>
    [JsonPropertyName("targets")]
    public IReadOnlyList<string> Targets { get; init; } = [];
}
