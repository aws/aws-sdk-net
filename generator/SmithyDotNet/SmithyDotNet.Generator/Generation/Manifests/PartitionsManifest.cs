using System.Text.Json;

namespace SmithyDotNet.Generator.Generation.Manifests;

/// <summary>An AWS region of a partition, e.g. <c>us-east-1</c> "US East (N. Virginia)".</summary>
public sealed record AwsRegion(string Code, string Description);

/// <summary>An AWS partition (<c>aws</c>, <c>aws-cn</c>, ...) with its regions in the file's order.</summary>
public sealed record AwsPartition(
    string Id,
    string Name,
    string DnsSuffix,
    string DualStackDnsSuffix,
    bool SupportsFips,
    bool SupportsDualStack,
    string ImplicitGlobalRegion,
    string RegionRegex,
    IReadOnlyList<AwsRegion> Regions);

/// <summary>
/// Reads Core's <c>partitions.json</c>, which Core's <c>RegionEndpoint</c> constants and <c>Partition</c> lookup
/// tables are generated from.
/// </summary>
public static class PartitionsManifest
{
    /// <summary>Returns the partitions, and each partition's regions, in the file's order.</summary>
    public static IReadOnlyList<AwsPartition> Load(string path)
    {
        using var stream = File.OpenRead(path);
        using var document = JsonDocument.Parse(stream);
        if (!document.RootElement.TryGetProperty("partitions", out var partitions))
        {
            throw new GeneratorException($"'{path}' is missing 'partitions'.");
        }

        return partitions.EnumerateArray().Select(partition =>
        {
            var id = Text(partition, "id", path, "a partition");
            var outputs = Property(partition, "outputs", path, id);
            return new AwsPartition(
                id,
                Text(outputs, "name", path, id),
                Text(outputs, "dnsSuffix", path, id),
                Text(outputs, "dualStackDnsSuffix", path, id),
                Property(outputs, "supportsFIPS", path, id).GetBoolean(),
                Property(outputs, "supportsDualStack", path, id).GetBoolean(),
                Text(outputs, "implicitGlobalRegion", path, id),
                Text(partition, "regionRegex", path, id),
                Property(partition, "regions", path, id).EnumerateObject()
                    .Select(region => new AwsRegion(region.Name, Text(region.Value, "description", path, region.Name)))
                    .ToList());
        }).ToList();
    }

    private static JsonElement Property(JsonElement element, string name, string path, string owner) =>
        element.TryGetProperty(name, out var value)
            ? value
            : throw new GeneratorException($"'{path}': {owner} is missing '{name}'.");

    private static string Text(JsonElement element, string name, string path, string owner) =>
        Property(element, name, path, owner).GetString() ?? throw new GeneratorException($"'{path}': '{name}' of {owner} is null.");
}
