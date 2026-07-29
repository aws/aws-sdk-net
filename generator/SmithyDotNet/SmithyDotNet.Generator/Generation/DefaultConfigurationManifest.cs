using System.Text.Json;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// A default-configuration mode with its option values fully resolved (base values plus the
/// mode's overrides). <see cref="Name"/> is the PascalCase .NET member name (e.g. <c>InRegion</c>).
/// </summary>
public sealed record ResolvedDefaultConfigurationMode(
    string Name,
    string Documentation,
    string RetryMode,
    string S3UsEast1RegionalEndpoint,
    int? ConnectTimeoutInMillis,
    int? TlsNegotiationTimeoutInMillis,
    int? TimeToFirstByteTimeoutInMillis,
    int? HttpRequestTimeoutInMillis);

/// <summary>
/// Reads the default-configuration modes from the repo-wide <c>sdk-default-configuration.json</c>.
/// The modes are not part of the Smithy model but are needed for the generated
/// <c>Amazon{Service}DefaultConfiguration</c> class, so they are loaded here and supplied to
/// <see cref="ServiceGenerator"/>.
/// </summary>
public static class DefaultConfigurationManifest
{
    /// <summary>
    /// Returns the resolved modes in the file's declared order. The <c>legacy</c> mode is
    /// excluded: the runtime's <c>DefaultConfigurationMode</c> enum has no member for it.
    /// </summary>
    public static IReadOnlyList<ResolvedDefaultConfigurationMode> Load(string manifestPath)
    {
        using var stream = File.OpenRead(manifestPath);
        using var document = JsonDocument.Parse(stream);
        var root = document.RootElement;

        if (!root.TryGetProperty("base", out var baseConfig))
        {
            throw new GeneratorException($"'{manifestPath}' is missing 'base'.");
        }

        if (!root.TryGetProperty("modes", out var modes))
        {
            throw new GeneratorException($"'{manifestPath}' is missing 'modes'.");
        }

        if (!root.TryGetProperty("documentation", out var documentation) ||
            !documentation.TryGetProperty("modes", out var modeDocumentation))
        {
            throw new GeneratorException($"'{manifestPath}' is missing 'documentation.modes'.");
        }

        var result = new List<ResolvedDefaultConfigurationMode>();

        // The documentation object lists every mode; the modes object may omit a mode entirely
        // (auto) or carry an empty entry (in-region), so documentation drives the iteration and
        // the emitted order.
        foreach (var mode in modeDocumentation.EnumerateObject())
        {
            if (mode.Name == "legacy")
            {
                continue;
            }

            JsonElement? overrides = modes.TryGetProperty(mode.Name, out var modeOverrides) ? modeOverrides : null;
            result.Add(new ResolvedDefaultConfigurationMode(
                Name: ToPascalCase(mode.Name),
                Documentation: mode.Value.GetString() ?? throw new GeneratorException($"Mode '{mode.Name}' in '{manifestPath}' has no documentation text."),
                RetryMode: ResolveEnumName(baseConfig, overrides, "retryMode"),
                S3UsEast1RegionalEndpoint: ResolveEnumName(baseConfig, overrides, "s3UsEast1RegionalEndpoints"),
                ConnectTimeoutInMillis: ResolveMillis(baseConfig, overrides, "connectTimeoutInMillis"),
                TlsNegotiationTimeoutInMillis: ResolveMillis(baseConfig, overrides, "tlsNegotiationTimeoutInMillis"),
                TimeToFirstByteTimeoutInMillis: ResolveMillis(baseConfig, overrides, "timeToFirstByteTimeoutInMillis"),
                HttpRequestTimeoutInMillis: ResolveMillis(baseConfig, overrides, "httpRequestTimeoutInMillis")));
        }

        return result;
    }

    private static string ResolveEnumName(JsonElement baseConfig, JsonElement? overrides, string optionName)
    {
        var value = Resolve(baseConfig, overrides, optionName)
            ?? throw new GeneratorException($"Default-configuration option '{optionName}' has no base value.");
        return ToPascalCase(value.GetString() ?? throw new GeneratorException($"Default-configuration option '{optionName}' is not a string."));
    }

    private static int? ResolveMillis(JsonElement baseConfig, JsonElement? overrides, string optionName)
    {
        return Resolve(baseConfig, overrides, optionName)?.GetInt32();
    }

    // Applies the mode's modifiers for one option on top of the base value. Only the 'override'
    // operation is supported; 'add' and 'multiply' exist in the file format but are unused, so
    // they fail loud here rather than shipping an untested code path.
    private static JsonElement? Resolve(JsonElement baseConfig, JsonElement? overrides, string optionName)
    {
        JsonElement? value = baseConfig.TryGetProperty(optionName, out var baseValue) ? baseValue : null;

        if (overrides is { } modeOverrides && modeOverrides.TryGetProperty(optionName, out var modifiers))
        {
            // Keys are unique and anything but 'override' throws, so this runs at most once.
            foreach (var modifier in modifiers.EnumerateObject())
            {
                if (modifier.Name != "override")
                {
                    throw new GeneratorException($"Modifier '{modifier.Name}' on '{optionName}' is not supported; only 'override' is.");
                }

                value = modifier.Value;
            }
        }

        return value;
    }

    // Mode names ("in-region") and enum values ("standard", "regional") are lowercase,
    // dash-separated where multi-word.
    private static string ToPascalCase(string name)
    {
        var parts = name.Split('-', StringSplitOptions.RemoveEmptyEntries);
        return string.Concat(parts.Select(SdkNaming.ToUpperFirstCharacter));
    }
}
