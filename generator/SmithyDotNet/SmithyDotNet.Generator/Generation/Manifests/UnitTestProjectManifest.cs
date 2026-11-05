using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator.Generation.Manifests;

/// <summary>A framework assembly reference, limited to <see cref="Targets"/> when it lists any.</summary>
[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public sealed record FrameworkReference
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("targets")]
    public IReadOnlyList<string> Targets { get; init; } = [];
}

/// <summary>
/// The <c>unittestprojects</c> entry of <c>generator/ServiceModels/_manifest.json</c>: the settings every generated
/// unit-test project shares. C2J reads the same entry, so both generators pick up an edit to it. As in C2J, a missing
/// list is empty. A setting the writers don't support (C2J's <c>outputPathOverride</c>, a package's
/// <c>privateAssets</c>, a framework reference's <c>hintPath</c>, ...) fails the load rather than being dropped from
/// the output.
/// </summary>
[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public sealed record UnitTestProjectManifest
{
    [JsonPropertyName("defineConstants")]
    public IReadOnlyList<string> DefineConstants { get; init; } = [];

    [JsonPropertyName("excludeFolders")]
    public IReadOnlyList<string> ExcludeFolders { get; init; } = [];

    [JsonPropertyName("embeddedResources")]
    public IReadOnlyList<string> EmbeddedResources { get; init; } = [];

    [JsonPropertyName("packageReferences")]
    public IReadOnlyList<PackageRef> PackageReferences { get; init; } = [];

    [JsonPropertyName("frameworkReferences")]
    public IReadOnlyList<FrameworkReference> FrameworkReferences { get; init; } = [];

    [JsonPropertyName("noWarn")]
    public string NoWarn { get; init; } = "";

    // In the file, but neither generator reads it.
    [JsonInclude]
    [JsonPropertyName("visualStudioServices")]
    private JsonElement VisualStudioServices { get; init; }

    private sealed record Document([property: JsonPropertyName("unittestprojects")] IReadOnlyList<UnitTestProjectManifest>? UnitTestProjects);

    public static UnitTestProjectManifest Load(string manifestPath)
    {
        using var stream = File.OpenRead(manifestPath);
        IReadOnlyList<UnitTestProjectManifest>? projects;
        try
        {
            projects = JsonSerializer.Deserialize<Document>(stream)?.UnitTestProjects;
        }
        catch (JsonException ex)
        {
            throw new GeneratorException($"'{manifestPath}': {ex.Message}");
        }

        return projects is [var project]
            ? project
            : throw new GeneratorException($"'{manifestPath}' must list exactly one 'unittestprojects' entry.");
    }
}
