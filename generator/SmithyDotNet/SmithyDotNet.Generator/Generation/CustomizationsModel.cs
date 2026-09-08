using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// A service's merged <c>*.customizations*.json</c> files. Model-shaped hooks are folded into the
/// Smithy model by <see cref="CustomizationTransform"/>; behavior hooks (code injection, pipeline
/// overrides) will be read via <see cref="GenerationContext.Customizations"/>.
/// </summary>
public sealed record CustomizationsModel
{
    private static readonly JsonSerializerOptions Options = new()
    {
        // logs.customizations.json has a trailing comma (C2J reads with lenient Json.NET).
        AllowTrailingCommas = true,
        // An unknown key at any depth is a hook not implemented yet; generating while ignoring
        // one would silently diverge from C2J output, so deserialization fails instead.
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
    };

    [JsonPropertyName("shapeModifiers")]
    public Dictionary<string, ShapeModifier> ShapeModifiers { get; init; } = [];

    /// <summary>Loads a service's customizations files into one model (C2J's CustomizationCompiler combines them the same way).</summary>
    public static CustomizationsModel Load(IEnumerable<string> paths)
    {
        var shapeModifiers = new Dictionary<string, ShapeModifier>();
        foreach (var path in paths)
        {
            CustomizationsModel file;
            try
            {
                file = JsonSerializer.Deserialize<CustomizationsModel>(File.ReadAllText(path), Options) ?? throw new GeneratorException($"'{path}' deserialized to null.");
            }
            catch (JsonException e)
            {
                throw new GeneratorException($"'{path}': {e.Message}");
            }

            foreach (var (shapeName, modifier) in file.ShapeModifiers)
            {
                // TODO: C2J merges the two entries when a shape is modified from two files; only
                // S3 does that today, so this throws instead.
                if (!shapeModifiers.TryAdd(shapeName, modifier))
                {
                    throw new GeneratorException($"'{path}': shapeModifiers['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }
        }

        return new CustomizationsModel { ShapeModifiers = shapeModifiers };
    }
}

/// <summary>A <c>shapeModifiers</c> entry: <c>modify</c> is a list of single-key objects mapping a member name to its modifier.</summary>
public sealed record ShapeModifier
{
    [JsonPropertyName("modify")]
    public List<Dictionary<string, PropertyModifier>> Modify { get; init; } = [];
}

/// <summary>A single member's modifications inside a <c>modify</c> entry.</summary>
public sealed record PropertyModifier
{
    /// <summary>The .NET property name to emit instead of the modeled member name; the wire name is unaffected.</summary>
    [JsonPropertyName("emitPropertyName")]
    public string? EmitPropertyName { get; init; }
}
