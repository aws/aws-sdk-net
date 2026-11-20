using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>A <c>shapeSubstitutions</c> entry: either <c>renameShape</c> or <c>emitAsShape</c>.</summary>
public sealed record ShapeSubstitution
{
    [JsonPropertyName("renameShape")]
    public string? RenamedShapeName { get; init; }

    /// <summary>
    /// ec2Query-only: members targeting this shape target the named shape instead; with <see cref="EmitFromMember"/>,
    /// the named shape is the type of that member of this wrapper, which the wire keeps.
    /// </summary>
    [JsonPropertyName("emitAsShape")]
    public string? EmitAsShape { get; init; }

    [JsonPropertyName("emitFromMember")]
    public string? EmitFromMember { get; init; }

    /// <summary>Operations whose requests send a list of this wrapper without the member suffix on each item.</summary>
    [JsonPropertyName("listMemberSuffixExclusions")]
    public List<string> ListMemberSuffixExclusions { get; init; } = [];
}
