using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// A service's merged <c>*.customizations*.json</c> files. Model-shaped hooks are folded into the
/// Smithy model by <see cref="CustomizationTransform"/>; behavior hooks (the runtime pipeline
/// overrides, and later code injection) are read via <see cref="GenerationContext.Customizations"/>.
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

    /// <summary>Handlers the client adds to its runtime pipeline in <c>CustomizeRuntimePipeline</c>.</summary>
    [JsonPropertyName("runtimePipelineOverride")]
    public RuntimePipelineOverride? RuntimePipelineOverride { get; init; }

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

    /// <summary>Type overrides keyed by modeled shape name, then <see cref="EmittedName"/> (C2J's <c>dataTypeSwap</c>).</summary>
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
    /// The <c>emitPropertyName</c> of modeled member <paramref name="memberName"/>, or the modeled name when it isn't
    /// renamed. C2J keys <c>emitIsSetProperties</c> and <c>dataTypeSwap</c> by this name.
    /// </summary>
    public string EmittedName(string shapeName, string memberName) =>
        ShapeModifiers.TryGetValue(shapeName, out var modifier)
        && modifier.Modify.SelectMany(entry => entry).FirstOrDefault(entry => entry.Key == memberName).Value?.EmitPropertyName is { } name
            ? name
            : memberName;

    /// <summary>
    /// The C# property name of modeled member <paramref name="memberName"/>: its <see cref="EmittedName"/> with the
    /// first character upper-cased, as C2J emits it (iot's <c>"emitPropertyName": "marker"</c> is <c>Marker</c>).
    /// The rename never reaches the model, so the member's wire name stays the modeled one on every protocol.
    /// </summary>
    public string PropertyName(string shapeName, string memberName) => SdkNaming.ToUpperFirstCharacter(EmittedName(shapeName, memberName));

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
        RuntimePipelineOverride? runtimePipelineOverride = null;
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

                // The lookups read one entry per member, and C2J fails on a repeat too (ParseModifiers' ToDictionary).
                if (modifier.Modify.SelectMany(entry => entry.Keys).GroupBy(name => name).FirstOrDefault(group => group.Count() > 1) is { } repeated)
                {
                    throw new GeneratorException($"'{path}': shapeModifiers['{shapeName}'] modifies '{repeated.Key}' more than once.");
                }
            }

            if (file.RuntimePipelineOverride is { } pipelineOverride)
            {
                if (runtimePipelineOverride is not null)
                {
                    throw new GeneratorException($"'{path}': runtimePipelineOverride appears in more than one customizations file; merging is not supported yet.");
                }

                // System.Text.Json lets null through a non-nullable member, and a typo'd operation would fall through
                // to AddHandlerAfter (C2J's switch throws), so a malformed entry fails here, not in the generated code.
                var overrides = pipelineOverride.Overrides ?? throw new GeneratorException($"'{path}': runtimePipelineOverride needs an 'overrides' list.");
                for (var i = 0; i < overrides.Count; i++)
                {
                    if (overrides[i] is not { Operation: PipelineOverride.AddBefore or PipelineOverride.AddAfter or PipelineOverride.Replace } entry
                        || string.IsNullOrWhiteSpace(entry.TargetType)
                        || string.IsNullOrWhiteSpace(entry.NewType))
                    {
                        throw new GeneratorException($"'{path}': runtimePipelineOverride overrides[{i}] needs operation '{PipelineOverride.AddBefore}', '{PipelineOverride.AddAfter}' or '{PipelineOverride.Replace}' and a non-empty targetType and newType.");
                    }
                }

                runtimePipelineOverride = pipelineOverride;
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

        return new CustomizationsModel { ShapeModifiers = shapeModifiers, OperationModifiers = operationModifiers, DataTypeSwaps = dataTypeSwaps, EmitIsSetProperties = emitIsSetProperties, ShapeSubstitutions = shapeSubstitutions, RuntimePipelineOverride = runtimePipelineOverride };
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

/// <summary>A <c>runtimePipelineOverride</c> entry: its <c>overrides</c> are applied in order.</summary>
public sealed record RuntimePipelineOverride
{
    // Nullable because "overrides": null deserializes fine; the loader rejects it.
    [JsonPropertyName("overrides")]
    public List<PipelineOverride>? Overrides { get; init; }
}

/// <summary>Adds a <see cref="NewType"/> handler before or after the pipeline's <see cref="TargetType"/> handler, or replaces it.</summary>
public sealed record PipelineOverride
{
    public const string AddBefore = "addBefore";
    public const string AddAfter = "addAfter";
    public const string Replace = "replace";

    /// <summary><see cref="AddBefore"/>, <see cref="AddAfter"/> or <see cref="Replace"/>; the loader rejects anything else.</summary>
    // TODO: C2J also has add and remove; no service uses them, so the loader rejects them.
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonPropertyName("targetType")]
    public required string TargetType { get; init; }

    [JsonPropertyName("newType")]
    public required string NewType { get; init; }

    /// <summary>C# arguments for the <see cref="NewType"/> constructor, emitted verbatim (e.g. <c>this.Config</c>).</summary>
    [JsonPropertyName("constructorInput")]
    public string? ConstructorInput { get; init; }

    /// <summary>A C# condition the override runs under, emitted verbatim (e.g. <c>this.Config.RetryMode == RequestRetryMode.Standard</c>).</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; init; }
}
