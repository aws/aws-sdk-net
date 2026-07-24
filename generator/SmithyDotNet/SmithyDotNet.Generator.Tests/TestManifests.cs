using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Tests;

/// <summary>
/// Shared test fixtures for the version manifest. Mirrors the CloudTrailData entry in
/// generator/ServiceModels/_sdk-versions.json so tests carry the same version data the generator
/// resolves at runtime.
/// </summary>
internal static class TestManifests
{
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
