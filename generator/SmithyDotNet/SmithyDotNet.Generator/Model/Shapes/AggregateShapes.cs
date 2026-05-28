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

/// <summary>
/// String type constrained to a fixed set of named values.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#enum" /></remarks>
public record EnumShape : Shape
{
    public override string Type => "enum";

    [JsonPropertyName("members")]
    public Dictionary<string, MemberShape> Members { get; init; } = [];
}

/// <summary>
/// Integer type constrained to a fixed set of named values.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#intenum" /></remarks>
public record IntEnumShape : Shape
{
    public override string Type => "intEnum";

    [JsonPropertyName("members")]
    public Dictionary<string, MemberShape> Members { get; init; } = [];
}

/// <summary>
/// Tagged union of members, each referencing a distinct alternative shape.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#union" /></remarks>
public record UnionShape : Shape
{
    public override string Type => "union";

    [JsonPropertyName("members")]
    public Dictionary<string, MemberShape> Members { get; init; } = [];
}
