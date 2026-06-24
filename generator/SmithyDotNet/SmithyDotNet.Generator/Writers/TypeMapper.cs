using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// A resolved structure member ready for codegen: .NET type, attribute, doc, and modeledName (the name as it appears in the model)
/// </summary>
public sealed record Member(
    string PropertyName,
    string DotNetType,
    bool IsCollection,
    string? AwsProperty,
    string Documentation,
    string ModeledName
)
{
    /// <summary>
    /// Body expression for the internal <c>IsSet{Property}()</c> method. Collections honor
    /// <c>AWSConfigs.InitializeCollections</c>: an empty list is "set" only when the
    /// V4-default null mode is active.
    /// </summary>
    // TODO: when nullable value types land (int?, bool?, DateTime?) IsSet should use .HasValue;
    // Document has its own .IsSet().
    public string IsSetExpression => IsCollection
        ? $"this.{PropertyName} != null && (this.{PropertyName}.Count > 0 || !AWSConfigs.InitializeCollections)"
        : $"this.{PropertyName} != null";
}

/// <summary>
/// Maps Smithy shapes to .NET type names and resolves <c>[AWSProperty]</c> attributes.
/// Shared by all writers that emit members.
/// </summary>
public static class TypeMapper
{
    /// <summary>
    /// Resolves every member of <paramref name="structure"/> into a <see cref="Member"/>,
    /// sorted by property name for stable output.
    /// </summary>
    public static List<Member> ResolveMembers(StructureShape structure, GenerationContext context)
    {
        var resolved = new List<Member>(structure.Members.Count);
        foreach (var (memberName, member) in structure.Members)
        {
            var target = context.Resolve(member.Target);
            resolved.Add(new Member(
                PropertyName: SdkNaming.ToUpperFirstCharacter(memberName),
                DotNetType: MapType(member.Target, target, context),
                IsCollection: IsCollection(target),
                AwsProperty: BuildAwsProperty(member, target),
                Documentation: member.GetDocumentation() ?? string.Empty,
                ModeledName: memberName)
            );
        }

        return [.. resolved.OrderBy(m => m.PropertyName, StringComparer.Ordinal)];
    }

    /// <summary>
    /// Returns the .NET type name for a member whose target resolves to <paramref name="target"/>.
    /// </summary>
    public static string MapType(ShapeId targetId, Shape target, GenerationContext context)
    {
        if (target is StringShape)
        {
            return "string";
        }

        if (target is ListShape list)
        {
            var elementTarget = context.Resolve(list.Member.Target);
            return $"List<{MapType(list.Member.Target, elementTarget, context)}>";
        }

        if (target is MapShape map)
        {
            var keyTarget = context.Resolve(map.Key.Target);
            var valueTarget = context.Resolve(map.Value.Target);
            return $"Dictionary<{MapType(map.Key.Target, keyTarget, context)}, {MapType(map.Value.Target, valueTarget, context)}>";
        }

        if (target is StructureShape)
        {
            return context.ToDotNetName(targetId);
        }

        throw new GeneratorException($"Unsupported member type '{target.Type}'.");
    }

    /// <summary>
    /// Whether the resolved target is a collection type.
    /// </summary>
    public static bool IsCollection(Shape target) => target is ListShape or MapShape;

    /// <summary>
    /// Builds the <c>[AWSProperty(...)]</c> attribute string, or null if no attribute is needed.
    /// </summary>
    public static string? BuildAwsProperty(MemberShape member, Shape target)
    {
        var parts = new List<string>();
        if (member.IsRequired())
        {
            parts.Add("Required=true");
        }

        var length = member.GetLength() ?? target.GetLength();
        if (length?.Min is not null)
        {
            parts.Add($"Min={length.Min}");
        }

        if (length?.Max is not null)
        {
            parts.Add($"Max={length.Max}");
        }

        if (parts.Count == 0)
        {
            return null;
        }

        return $"[AWSProperty({string.Join(", ", parts)})]";
    }
}
