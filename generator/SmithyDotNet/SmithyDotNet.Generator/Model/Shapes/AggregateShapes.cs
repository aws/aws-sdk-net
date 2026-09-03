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
/// Tagged union of members, each referencing a distinct alternative shape. Derives from
/// <see cref="StructureShape"/> so the whole structure codepath — reachability, context
/// partitioning, type mapping, and (un)marshaller emission — treats a union as a plain structure
/// (all members optional), matching the current SDK. The distinct <see cref="Type"/> is retained
/// for any future protocol-specific handling.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/aggregate-types.html#union" /></remarks>
public record UnionShape : StructureShape
{
    public override string Type => "union";
}
