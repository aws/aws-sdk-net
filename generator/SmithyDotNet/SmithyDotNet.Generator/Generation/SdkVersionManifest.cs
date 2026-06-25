using System.Text.Json;
using SmithyDotNet.Generator.Model;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Reads a service's package build version from the C2J <c>_sdk-versions.json</c> manifest. The
/// version is not part of the Smithy model but is needed for the generated config's user-agent
/// string, so it is looked up here and supplied to <see cref="ServiceGenerator"/>.
/// </summary>
public static class SdkVersionManifest
{
    /// <summary>
    /// Returns the <c>Version</c> for <paramref name="serviceName"/> from the manifest at
    /// <paramref name="manifestPath"/> (navigates <c>ServiceVersions.{serviceName}.Version</c>).
    /// </summary>
    public static string Lookup(string manifestPath, string serviceName)
    {
        using var stream = File.OpenRead(manifestPath);
        using var document = JsonDocument.Parse(stream);

        if (!document.RootElement.TryGetProperty("ServiceVersions", out var serviceVersions))
        {
            throw new GeneratorException($"'{manifestPath}' has no 'ServiceVersions' object.");
        }

        if (!serviceVersions.TryGetProperty(serviceName, out var serviceEntry))
        {
            throw new GeneratorException($"'{manifestPath}' has no version entry for service '{serviceName}'.");
        }

        if (!serviceEntry.TryGetProperty("Version", out var version) || version.GetString() is not string value)
        {
            throw new GeneratorException($"Service '{serviceName}' in '{manifestPath}' has no 'Version' field.");
        }

        return value;
    }
}
