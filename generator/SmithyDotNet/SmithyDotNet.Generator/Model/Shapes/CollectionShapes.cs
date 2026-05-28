using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Shapes;

/// <summary>
/// Ordered collection of values sharing a single element type.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#list" /></remarks>
public record ListShape : Shape
{
    public override string Type => "list";

    /// <summary>
    /// The single member describing the element type.
    /// </summary>
    [JsonPropertyName("member")]
    public required MemberShape Member { get; init; }
}

/// <summary>
/// Map of string keys to values sharing a single value type.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#map" /></remarks>
public record MapShape : Shape
{
    public override string Type => "map";

    [JsonPropertyName("key")]
    public required MemberShape Key { get; init; }

    [JsonPropertyName("value")]
    public required MemberShape Value { get; init; }
}
