using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

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

    [JsonPropertyName("operationModifiers")]
    public Dictionary<string, OperationModifier> OperationModifiers { get; init; } = [];

    [JsonPropertyName("overrideContentType")]
    public string? OverrideContentType { get; init; }

    /// <summary>
    /// Usage:
    /// emitIsSetProperties: {
    ///   "OwningShapeName" :["memberName", "memberName2"]
    /// }
    /// </summary>
    [JsonPropertyName("emitIsSetProperties")]
    public Dictionary<string, List<string>> EmitIsSetProperties { get; init; } = [];

    /// <summary>True when <c>emitIsSetProperties</c> lists <paramref name="memberName"/> under <paramref name="shapeName"/>.</summary>
    public bool EmitIsSet(string shapeName, string memberName) => EmitIsSetProperties.TryGetValue(shapeName, out var members) && members.Contains(memberName);

    /// <summary>Type overrides keyed by modeled shape name, then emitted member name (C2J's <c>dataTypeSwap</c>).</summary>
    [JsonPropertyName("dataTypeSwap")]
    public Dictionary<string, Dictionary<string, DataTypeSwap>> DataTypeSwaps { get; init; } = [];

    /// <summary>The <c>dataTypeSwap</c> entry for <paramref name="memberName"/> of <paramref name="shapeName"/>, or null.</summary>
    public DataTypeSwap? DataTypeSwapFor(string shapeName, string memberName) => DataTypeSwaps.TryGetValue(shapeName, out var members) && members.TryGetValue(memberName, out var swap) ? swap : null;

    /// <summary>
    /// Emitted-name overrides keyed by modeled shape name, e.g.
    /// <c>"shapeSubstitutions": { "VpcConfigResponse": { "renameShape": "VpcConfigDetail" } }</c>.
    /// A Smithy-only <c>"Structure$member"</c> key gives that member's target its own copy under the new name.
    /// </summary>
    [JsonPropertyName("shapeSubstitutions")]
    public Dictionary<string, ShapeSubstitution> ShapeSubstitutions { get; init; } = [];

    /// <summary>
    /// Loads a service's customizations files into one model, as C2J's CustomizationCompiler combines them, except
    /// that a shape repeated across files throws instead of merging.
    /// </summary>
    public static CustomizationsModel Load(IEnumerable<string> paths)
    {
        var shapeModifiers = new Dictionary<string, ShapeModifier>();
        var operationModifiers = new Dictionary<string, OperationModifier>();
        var emitIsSetProperties = new Dictionary<string, List<string>>();
        var dataTypeSwaps = new Dictionary<string, Dictionary<string, DataTypeSwap>>();
        var shapeSubstitutions = new Dictionary<string, ShapeSubstitution>();
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

            foreach (var (operationName, modifier) in file.OperationModifiers)
            {
                if (!operationModifiers.TryAdd(operationName, modifier))
                {
                    throw new GeneratorException($"'{path}': operationModifiers['{operationName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, modifier) in file.ShapeSubstitutions)
            {
                if (!shapeSubstitutions.TryAdd(shapeName, modifier))
                {
                    throw new GeneratorException($"'{path}': shapeSubstitutions['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, members) in file.EmitIsSetProperties)
            {
                if (!emitIsSetProperties.TryAdd(shapeName, members))
                {
                    throw new GeneratorException($"'{path}': emitIsSetProperties['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }
        
            foreach (var (shapeName, swaps) in file.DataTypeSwaps)
            {
                if (!dataTypeSwaps.TryAdd(shapeName, swaps))
                {
                    throw new GeneratorException($"'{path}': dataTypeSwap['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }
        }

        return new CustomizationsModel { ShapeModifiers = shapeModifiers, OperationModifiers = operationModifiers, DataTypeSwaps = dataTypeSwaps, EmitIsSetProperties = emitIsSetProperties, ShapeSubstitutions = shapeSubstitutions };
    }
}

/// <summary>A <c>shapeModifiers</c> entry: <c>modify</c> is a list of single-key objects mapping a member name to its modifier.</summary>
public sealed record ShapeModifier
{
    [JsonPropertyName("modify")]
    public List<Dictionary<string, PropertyModifier>> Modify { get; init; } = [];

    /// <summary>The <c>[Obsolete]</c> message for the shape (e.g. a request/response class); applied only when the shape is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }
}

/// <summary>A single member's modifications inside a <c>modify</c> entry.</summary>
public sealed record PropertyModifier
{
    /// <summary>The .NET property name to emit instead of the modeled member name; the wire name is unaffected.</summary>
    [JsonPropertyName("emitPropertyName")]
    public string? EmitPropertyName { get; init; }

    /// <summary>The <c>[Obsolete]</c> message for the member; applied only when the member is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }
}

/// <summary>An <c>operationModifiers</c> entry, keyed by operation name.</summary>
public sealed record OperationModifier
{
    /// <summary>The <c>[Obsolete]</c> message for the operation's client methods; applied only when the operation is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }
}

/// <summary>
/// A <c>dataTypeSwap</c> entry: overrides a member's generated .NET type and optionally names the marshaller
/// method and unmarshaller instance the generated code calls for it; an omitted one keeps the modeled conversion.
/// </summary>
public sealed record DataTypeSwap
{
    [JsonPropertyName("Type")]
    public required string Type { get; init; }

    [JsonPropertyName("Marshaller")]
    public string? Marshaller { get; init; }

    [JsonPropertyName("Unmarshaller")]
    public string? Unmarshaller { get; init; }

    /// <summary>XML-only: marks a swapped collection as flattened. Rejected until an XML protocol is supported.</summary>
    [JsonPropertyName("isFlattened")]
    public bool? IsFlattened { get; init; }

    /// <summary>XML-only: overrides the member's XML element name. Rejected until an XML protocol is supported.</summary>
    [JsonPropertyName("alternateLocationName")]
    public string? AlternateLocationName { get; init; }
}

public sealed record ShapeSubstitution
{
    // TODO: C2J also has emitAsShape and emitFromMember; the loader rejects them as unknown keys.
    [JsonPropertyName("renameShape")]
    public required string RenamedShapeName { get; init; }
}
