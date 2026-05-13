using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator.Model;

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
    /// <see cref="Converters.ShapeConverter"/> reads the <c>type</c> field to pick the subclass.
    /// </summary>
    public abstract string Type { get; }

    /// <summary>
    /// Trait ID (e.g. <c>smithy.api#required</c>) to raw JSON value.
    /// Values are deserialized on demand via typed accessors.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/spec/model.html#applying-traits" /></remarks>
    [JsonPropertyName("traits")]
    public Dictionary<string, JsonElement> Traits { get; init; } = [];
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
}
