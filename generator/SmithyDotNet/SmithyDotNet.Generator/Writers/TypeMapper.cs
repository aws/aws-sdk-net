using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// A member's resolved type, or (recursively via <see cref="ListElement"/> / <see cref="MapValue"/>)
/// the type nested inside a collection. One definition shared by all of them instead of independent
/// copies of the same flags.
/// </summary>
/// <param name="DotNetType">The .NET type name.</param>
/// <param name="IsStructure">True if this targets a structure shape.</param>
/// <param name="IsString">True if this targets a string shape.</param>
/// <param name="IsCollection">True if this is itself a list or map.</param>
/// <param name="IsEnum">True if this targets an enum shape; marshals as a string (see <see cref="MarshalType"/>).</param>
/// <param name="IsBlob">True if this targets a blob shape (maps to <c>MemoryStream</c>). Only supported as an <c>@httpPayload</c> body.</param>
/// <param name="ListElement">The list element's type; set only for a list, null otherwise.</param>
/// <param name="MapValue">The map value's type; set only for a map, null otherwise. A map's key always
/// targets a string shape (Smithy requires it), so no key descriptor is carried.</param>
public sealed record TypeDescriptor(
    string DotNetType,
    bool IsStructure,
    bool IsString,
    bool IsCollection,
    bool IsEnum = false,
    bool IsBlob = false,
    TypeDescriptor? ListElement = null,
    TypeDescriptor? MapValue = null)
{
    /// <summary>
    /// True for a scalar — <c>string</c>, an enum (its ConstantClass marshals as a string), or a
    /// nullable value type. Aggregates (list, map, structure) and blobs are excluded; unsupported
    /// shapes never reach here (they throw in <see cref="TypeMapper.MapType"/>).
    /// </summary>
    public bool IsScalar => !IsCollection && !IsStructure && !IsBlob;

    /// <summary>
    /// The type (un)marshaller writers dispatch on. An enum marshals as a string (ConstantClass
    /// converts implicitly to/from <c>string</c>, matching C2J), the only case this diverges from
    /// <see cref="DotNetType"/>. A future divergent kind gets its own flag here, not a call-site
    /// comparison.
    /// </summary>
    public string MarshalType => IsEnum ? "string" : DotNetType;

    /// <summary>
    /// True when the value is a string on the wire (a real string, or an enum). Equivalent to
    /// <c>MarshalType == "string"</c> as a named flag, not a call-site comparison.
    /// </summary>
    public bool MarshalsAsString => IsString || IsEnum;
}

/// <summary>
/// A resolved structure member ready for codegen: .NET type, attribute, doc, and modeledName (the name as it appears in the model)
/// </summary>
/// <param name="PropertyName">The name of the member as it appears in generated code.</param>
/// <param name="Type">The member's type - .NET type, structure/collection/enum-ness, and (for a list) its element's type.</param>
/// <param name="IsRequired">True if the member is required.</param>
/// <param name="IsNullableValueType">True if the member maps to a nullable .NET value type (e.g. <c>int?</c>, <c>DateTime?</c>); drives <c>.HasValue</c> vs <c>!= null</c> in <see cref="Member.IsSetExpression"/>.</param>
/// <param name="IsIdempotencyToken">True if the member carries <c>@idempotencyToken</c>; the marshaller auto-fills with a GUID when unset.</param>
/// <param name="AwsProperty">The attributes that are part of [AwsProperty(...)]</param>
/// <param name="Obsolete">The <c>[Obsolete(...)]</c> attribute for a @deprecated member, or null.</param>
/// <param name="Documentation">The documentation for the member.</param>
/// <param name="ModeledName">The name of the member as it appears in the model</param>
/// <param name="JsonName">For JSON protocols, represents the value that should be used over the wire for the member (specified via JsonName trait). </param>
/// <param name="TimestampFormat">The explicit <c>@timestampFormat</c> (<c>date-time</c>/<c>http-date</c>/<c>epoch-seconds</c>) from the member or its target, or null when unset (the binding's protocol default applies).</param>
/// <param name="HidesBaseMember">True when the member shadows a base-class member and must be emitted with the <c>new</c> modifier. Set for any structure's <c>Equals</c> (hides <c>object.Equals</c>) and, on exceptions, for <c>Retryable</c> (hides <c>AmazonServiceException.Retryable</c>).</param>
public sealed record Member(
    string PropertyName,
    TypeDescriptor Type,
    bool IsRequired,
    bool IsNullableValueType,
    bool IsIdempotencyToken,
    string? AwsProperty,
    string? Obsolete,
    string Documentation,
    string ModeledName,
    string? JsonName = null,
    string? TimestampFormat = null,
    bool HidesBaseMember = false
)
{
    /// <summary>
    /// Body expression for the internal <c>IsSet{Property}()</c> method. Collections honor
    /// <c>AWSConfigs.InitializeCollections</c>: an empty list is "set" only when the V4-default null
    /// mode is active. Nullable value types (<c>int?</c>, <c>bool?</c>, <c>DateTime?</c>, …) use
    /// <c>.HasValue</c>; reference types (<c>string</c>, generated classes) use <c>!= null</c>.
    /// </summary>
    public string IsSetExpression => Type.IsCollection
        ? $"this.{PropertyName} != null && (this.{PropertyName}.Count > 0 || !AWSConfigs.InitializeCollections)"
        : IsNullableValueType
            ? $"this.{PropertyName}.HasValue"
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

            // MapScalar doubles as the IsNullableValueType signal - Member-only, since TypeDescriptor
            // has no equivalent for list/map elements.
            var scalarType = MapScalar(target);
            var propertyName = SdkNaming.ToUpperFirstCharacter(memberName);

            resolved.Add(new Member(
                PropertyName: propertyName,
                Type: ResolveType(member.Target, context),
                IsRequired: member.IsRequired(),
                IsNullableValueType: scalarType is not null,
                IsIdempotencyToken: member.IsIdempotencyToken(),
                AwsProperty: BuildAwsProperty(member, target),
                Obsolete: BuildObsolete(memberName, member, target),
                Documentation: member.GetDocumentation() ?? string.Empty,
                ModeledName: memberName,
                JsonName: member.GetJsonName(),
                TimestampFormat: member.GetTimestampFormat() ?? target.GetTimestampFormat(),
                // Any structure can model a member named "Equals" — it hides object.Equals(object).
                HidesBaseMember: propertyName == "Equals")
            );
        }

        return [.. resolved.OrderBy(m => m.PropertyName, StringComparer.Ordinal)];
    }

    /// <summary>
    /// Resolves the shape at <paramref name="id"/> into a <see cref="TypeDescriptor"/>, recursing for a
    /// list element or map value. Used for a member's own type and for its nested collection type.
    /// </summary>
    private static TypeDescriptor ResolveType(ShapeId id, GenerationContext context)
    {
        var target = context.Resolve(id);
        return new TypeDescriptor(
            DotNetType: MapType(id, target, context),
            IsStructure: target is StructureShape,
            IsString: target is StringShape,
            IsCollection: IsCollection(target),
            IsEnum: target is EnumShape,
            IsBlob: target is BlobShape,
            ListElement: target is ListShape list ? ResolveType(list.Member.Target, context) : null,
            MapValue: target is MapShape map ? ResolveType(map.Value.Target, context) : null);
    }

    /// <summary>
    /// Returns the .NET type name for a member whose target resolves to <paramref name="target"/>.
    /// </summary>
    public static string MapType(ShapeId targetId, Shape target, GenerationContext context)
    {
        if (target is ListShape list)
        {
            var elementTarget = context.Resolve(list.Member.Target);
            RejectUnsupportedCollectionElement(elementTarget, "list");
            return $"List<{MapType(list.Member.Target, elementTarget, context)}>";
        }

        if (target is MapShape map)
        {
            var valueTarget = context.Resolve(map.Value.Target);
            RejectUnsupportedCollectionElement(valueTarget, "map");

            // Smithy guarantees the key targets a string shape; C2J emits `string` even for an enum key,
            // so the .NET key type is always string (never the enum's ConstantClass).
            return $"Dictionary<string, {MapType(map.Value.Target, valueTarget, context)}>";
        }

        if (target is StructureShape)
        {
            return context.ToDotNetName(targetId);
        }

        if (target is EnumShape)
        {
            // An enum-typed member's .NET type is the ConstantClass the ServiceEnumerationsWriter emits,
            // matching C2J. The name derivation (ToUpperFirstCharacter over the shape name) is shared with
            // that writer so the member type and the class declaration always agree.
            return EnumTypeName(targetId, context);
        }

        if (target is IntEnumShape)
        {
            // C2J has no intEnum: an integer-valued enum maps to a plain integer with no ConstantClass.
            // The V4 Smithy convention makes value types nullable, exactly as IntegerShape is mapped above.
            return "int?";
        }

        if (target is BlobShape)
        {
            // A blob maps to MemoryStream, matching C2J. Only supported as an @httpPayload body (the
            // marshaller/unmarshaller payload paths); a blob in any other position (JSON body member,
            // header, ...) maps here but then fails loud in the writer (it is not a JSON scalar).
            return "MemoryStream";
        }

        // Scalars are checked last so the aggregate branches above return without a MapScalar call.
        // Value-type scalars follow the V4 nullable convention; the rest (byte/short/bigInteger/
        // bigDecimal/document/union) have no settled mapping yet and fall through to the
        // throw — the wider-numeric types are earmarked for a dedicated numerics extension.
        return MapPrimitive(target) ?? throw new GeneratorException($"Unsupported member type '{target.Type}'.");
    }

    /// <summary>
    /// The emitted <c>ConstantClass</c> name for an <c>enum</c> shape. Shared by <see cref="MapType"/>
    /// (the member's .NET type) and <see cref="Shapes.ServiceEnumerationsWriter"/> (the class declaration), so a
    /// member typed as an enum always names the class that gets emitted. C2J upper-cases the first
    /// character of the shape name; a no-op for the PascalCase shape names AWS models use.
    /// </summary>
    public static string EnumTypeName(ShapeId shapeId, GenerationContext context) =>
        SdkNaming.ToUpperFirstCharacter(context.ToDotNetName(shapeId));

    /// <summary>
    /// The .NET type for a string or value-type scalar, or null when the shape is not a primitive.
    /// Unlike <see cref="MapScalar"/>, includes <c>string</c>.
    /// </summary>
    public static string? MapPrimitive(Shape target) => target switch
    {
        StringShape => "string",
        _ => MapScalar(target),
    };

    /// <summary>
    /// The nullable .NET type for a primitive scalar or timestamp shape, or null when the shape is
    /// not one of the supported scalars.
    /// </summary>
    public static string? MapScalar(Shape target) => target switch
    {
        BooleanShape => "bool?",
        IntegerShape => "int?",
        LongShape => "long?",
        FloatShape => "float?",
        DoubleShape => "double?",
        TimestampShape => "DateTime?",
        _ => null,
    };

    // The writers handle string, structure, and nested-collection (list/map) collection elements. A
    // value-type scalar needs a first-class Member with its own @timestampFormat; an enum element would
    // map to its ConstantClass, which the collection writers don't route through the string path. Fail
    // here so a model like list<Integer> or list<SomeEnum> doesn't silently map the type then blow up in
    // the writer with a confusing error. (A list/map element that is itself a list/map is fine - it
    // recurses; only value-type/enum *leaves* are rejected.)
    private static void RejectUnsupportedCollectionElement(Shape elementTarget, string collectionKind)
    {
        if (MapScalar(elementTarget) is not null || elementTarget is EnumShape or IntEnumShape)
        {
            throw new GeneratorException($"Elements of type '{elementTarget.Type}' in a {collectionKind} are not supported yet.");
        }
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
