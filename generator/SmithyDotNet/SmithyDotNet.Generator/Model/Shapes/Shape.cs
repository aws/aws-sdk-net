using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator.Model.Shapes;

/// <summary>
/// Base type for all shapes in the Smithy model. Each shape has a type discriminator
/// and an optional set of traits.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/model.html#shapes" /></remarks>
public abstract record Shape
{
    /// <summary>
    /// The Smithy shape type (e.g. <c>structure</c>, <c>string</c>, <c>operation</c>).
    /// Each subclass returns a constant — not deserialized from JSON.
    /// <see cref="Converters.ShapeConverter"/> reads the <c>type</c> field to pick the subclass. It is
    /// registered through <c>JsonSerializerOptions.Converters</c>, never as a <c>[JsonConverter]</c> on
    /// this record: it deserializes the chosen subclass with the same options, so an attribute here
    /// would re-enter the converter and recurse until the stack overflows.
    /// </summary>
    public abstract string Type { get; }

    /// <summary>
    /// Trait ID (e.g. <c>smithy.api#required</c>) to raw JSON value.
    /// Values are deserialized on demand via typed accessors.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/spec/model.html#applying-traits" /></remarks>
    [JsonPropertyName("traits")]
    public Dictionary<string, JsonElement> Traits { get; init; } = [];

    /// <summary>
    /// The mixin shapes this shape consumes. The generator does not resolve mixins (production
    /// models arrive pre-flattened), so <see cref="ServiceIndex"/> rejects mixin consumers
    /// reachable from the service.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/spec/mixins.html" /></remarks>
    [JsonPropertyName("mixins")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Mixins { get; init; } = [];
}

/// <summary>
/// A member of an aggregate shape (structure, union, list, map, enum).
/// Members reference a target shape via <see cref="Target"/> and carry their own traits.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/model.html#member" /></remarks>
public record MemberShape : Shape
{
    public override string Type => "member";

    /// <summary>
    /// The shape ID of the target shape this member references.
    /// </summary>
    [JsonPropertyName("target")]
    [JsonConverter(typeof(ShapeIdConverter))]
    public required ShapeId Target { get; init; }

    /// <summary>
    /// Set by <see cref="Generation.Customizations.CustomizationTransform"/> when the C2J
    /// <c>emitIsSetProperties</c> customization lists this member; not part of the Smithy AST.
    /// </summary>
    [JsonIgnore]
    public bool EmitIsSet { get; set; }
    /// <summary>Set by CustomizationTransform from the C2J dataTypeSwap customization; not part of the Smithy AST.</summary>
    [JsonIgnore]
    public DataTypeOverride? DataTypeSwap { get; set; }
}

/// <summary>
/// A member's <c>dataTypeSwap</c>: its emitted .NET type and, optionally, the marshaller method and unmarshaller
/// that replace the modeled conversion.
/// </summary>
public record DataTypeOverride(string Type, string? Marshaller, string? Unmarshaller);
