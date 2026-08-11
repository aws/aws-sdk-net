using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// A resolved structure member ready for codegen: .NET type, attribute, doc, and modeledName (the name as it appears in the model)
/// </summary>
/// <param name="PropertyName">The name of the member as it appears in generated code.</param>
/// <param name="DotNetType">The .NET type</param>
/// <param name="IsCollection">True if member is a collection type.</param>
/// <param name="IsStructure">True if the member is a structure. IsElementStructure should be used for members that are structure and the target of a list.</param>
/// <param name="IsRequired">True if the member is required.</param>
/// <param name="IsElementStructure">True if the member is a structure and the target of a list. i.e. List of structure.</param>
/// <param name="AwsProperty">The attributes that are part of [AwsProperty(...)]</param>
/// <param name="Obsolete">The <c>[Obsolete(...)]</c> attribute for a @deprecated member, or null.</param>
/// <param name="Documentation">The documentation for the member.</param>
/// <param name="ModeledName">The name of the member as it appears in the model</param>
/// <param name="JsonName">For JSON protocols, represents the value that should be used over the wire for the member (specified via JsonName trait). </param>
/// <param name="ElementType">The type of the list element.</param>
public sealed record Member(
    string PropertyName,
    string DotNetType,
    bool IsCollection,
    bool IsStructure,
    bool IsRequired,
    bool IsElementStructure,
    string? AwsProperty,
    string? Obsolete,
    string Documentation,
    string ModeledName,
    string? JsonName = null,
    string? ElementType = null
)
{
    /// <summary>
    /// Body expression for the internal <c>IsSet{Property}()</c> method. Collections honor
    /// <c>AWSConfigs.InitializeCollections</c>: an empty list is "set" only when the
    /// V4-default null mode is active. Nullable value types (<c>int?</c>, and later
    /// <c>bool?</c>/<c>long?</c>/<c>DateTime?</c>) test <c>.HasValue</c>; everything else is a
    /// reference type tested against null. A trailing <c>?</c> in the .NET type is the discriminator:
    /// only nullable value types carry one.
    /// </summary>
    public string IsSetExpression
    {
        get
        {
            if (IsCollection)
            {
                return $"this.{PropertyName} != null && (this.{PropertyName}.Count > 0 || !AWSConfigs.InitializeCollections)";
            }
            else if (DotNetType.EndsWith('?'))
            {
                return $"this.{PropertyName}.HasValue";
            }
            else
            {
                return $"this.{PropertyName} != null";
            }
        }
    }
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
            string? elementType = null;
            bool isStructure = target is StructureShape;
            bool isElementStructure = false;
            if (target is ListShape list)
            {
                var elementTarget = context.Resolve(list.Member.Target);
                elementType = MapType(list.Member.Target, elementTarget, context);
                isElementStructure = elementTarget is StructureShape;
            }

            resolved.Add(new Member(
                PropertyName: SdkNaming.ToUpperFirstCharacter(memberName),
                DotNetType: MapType(member.Target, target, context),
                IsCollection: IsCollection(target),
                IsStructure: isStructure,
                IsRequired: member.IsRequired(),
                IsElementStructure: isElementStructure,
                AwsProperty: BuildAwsProperty(member, target),
                Obsolete: BuildObsolete(memberName, member, target),
                Documentation: member.GetDocumentation() ?? string.Empty,
                ModeledName: memberName,
                JsonName: member.GetJsonName(),
                ElementType: elementType)
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

        if (target is IntegerShape)
        {
            return "int?";
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
    /// Whether the resolved target is a simple (scalar) type — the Smithy equivalent of the legacy
    /// generator's <c>IsPrimitiveType</c>. Excludes aggregates (structure, list, map, union, enum),
    /// documents, and service-level shapes.
    /// </summary>
    public static bool IsScalar(Shape target) => target is
        BlobShape or BooleanShape or StringShape or ByteShape or ShortShape or IntegerShape or
        LongShape or FloatShape or DoubleShape or BigIntegerShape or BigDecimalShape or TimestampShape;

    /// <summary>
    /// Builds the <c>[AWSProperty(...)]</c> attribute string, or null if no attribute is needed.
    /// </summary>
    public static string? BuildAwsProperty(MemberShape member, Shape target)
    {
        var parts = new List<string>();

        // An idempotency-token member is auto-populated by the SDK, so it is never surfaced as
        // Required even when the model marks it @required.
        if (member.IsRequired() && !member.IsIdempotencyToken())
        {
            parts.Add("Required=true");
        }

        if (target.IsSensitive())
        {
            parts.Add("Sensitive=true");
        }

        var (min, max) = ResolveBounds(member, target);
        if (min is not null)
        {
            parts.Add($"Min={min}");
        }

        if (max is not null)
        {
            parts.Add($"Max={max}");
        }

        if (parts.Count == 0)
        {
            return null;
        }

        return $"[AWSProperty({string.Join(", ", parts)})]";
    }

    /// <summary>
    /// Builds the <c>[Obsolete(...)]</c> attribute string for a @deprecated member, or null when the
    /// member is not deprecated.
    /// </summary>
    /// <remarks>
    /// A message is mandatory: <c>[Obsolete]</c> without one trips analyzer CA1041, so we throw rather
    /// than emit a message-less attribute.
    /// </remarks>
    public static string? BuildObsolete(string memberName, MemberShape member, Shape target)
    {
        var deprecated = member.GetDeprecated() ?? target.GetDeprecated();
        if (deprecated is null)
        {
            return null;
        }

        // TODO: fall back to the customization file's deprecation message (c2j's PropertyModifier.DeprecationMessage)
        // once the customization layer is implemented.
        var message = deprecated.Message
            ?? throw new GeneratorException(
                $"The 'message' property of the @deprecated trait is missing for member '{memberName}'. " +
                "[Obsolete] requires a message (CA1041); provide one in the model or via a customization.");

        return $"[Obsolete({CodeWriter.Literal(message)})]";
    }

    // Min/Max flatten two distinct Smithy traits: @length (string/collection size) and @range
    // (numeric bounds). A shape carries at most one of them; the member reference can also carry
    // its own, which takes precedence over the target shape's.
    private static (long? Min, long? Max) ResolveBounds(MemberShape member, Shape target)
    {
        if ((member.GetLength() ?? target.GetLength()) is { } length)
        {
            return (length.Min, length.Max);
        }

        if ((member.GetRange() ?? target.GetRange()) is { } range)
        {
            return (range.Min, range.Max);
        }

        return (null, null);
    }
}
