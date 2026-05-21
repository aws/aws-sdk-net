using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Shapes;

/// <summary>
/// Named collection of members, each referencing a target shape.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#structure" /></remarks>
public record StructureShape : Shape
{
    public override string Type => "structure";

    [JsonPropertyName("members")]
    public Dictionary<string, MemberShape> Members { get; init; } = [];
}
