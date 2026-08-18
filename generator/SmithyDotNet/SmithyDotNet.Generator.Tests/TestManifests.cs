using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Tests;

/// <summary>
/// Shared test fixtures for the version manifest. <see cref="CloudTrailData"/> mirrors the entry in
/// generator/ServiceModels/_sdk-versions.json so tests carry the same version data the generator
/// resolves at runtime; <see cref="Example"/> covers the synthetic "Example" models.
/// </summary>
internal static class TestManifests
{
    public static SdkVersionManifest Example() => new()
    {
        CoreVersion = "4.0.0.0",
        ServiceVersions = new Dictionary<string, ServiceVersion>
        {
            ["Example"] = new() { Version = "4.0.0.0" },
        },
    };

    public static SdkVersionManifest CloudTrailData() => new()
    {
        CoreVersion = "4.0.100.3",
        ServiceVersions = new Dictionary<string, ServiceVersion>
        {
            ["CloudTrailData"] = new()
            {
                Version = "4.0.100.3",
                AssemblyVersionOverride = "4.0",
                Dependencies = new Dictionary<string, string> { ["Core"] = "4.0.100.3" },
            },
        },
    };
}
