using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the per-member <c>if (context.TestExpression(...)) { ... }</c> blocks of a restXml/awsQuery
/// <c>while (context.Read())</c> body loop, into the in-scope <c>unmarshalledObject</c> local. Shared by
/// the response, structure and exception unmarshaller writers.
/// <para/>
/// A scalar/structure/blob member reads whole; a non-flattened list matches <c>member/item</c> and adds
/// one element per hit; a flattened list matches the member name and adds; a restXml wrapped map reads
/// whole through <c>XmlDictionaryUnmarshaller</c>, while a flattened map (and every awsQuery map, matching
/// <c>member/entry</c> when wrapped) adds one kvp per hit; an <c>@xmlAttribute</c> member matches
/// <c>@name</c> one depth up.
/// </summary>
internal static class XmlBodyMemberUnmarshaller
{
    /// <summary>
    /// Writes a <c>TestExpression</c> block per member. <paramref name="depthExpr"/> is the depth local
    /// (e.g. <c>targetDepth</c>) for the response/structure loops, which also emit <c>continue;</c>; the
    /// exception loop passes null — it matches on the suffix alone and falls through.
    /// </summary>
    public static void WriteMemberBlocks(CodeWriter writer, StructureShape owner, List<Member> members, string? depthExpr, AWSProtocol protocol)
    {
        for (var i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var memberShape = owner.Members[member.ModeledName];
            var name = XmlNames.ElementName(memberShape, member.ModeledName);
            var isAttribute = memberShape.IsXmlAttribute();
            var flattened = XmlNames.IsFlattened(memberShape, member.Type.Target);
            // C2J's awsQuery templates build every map one entry at a time, so an empty <map/> leaves the
            // property unset; restXml reads a wrapped map whole, yielding an empty map.
            var incrementalMap = member.Type.MapValue is not null && (flattened || protocol == AWSProtocol.AwsQuery);

            string expression;
            string? depth = depthExpr;
            if (isAttribute)
            {
                // An attribute is one element shallower than a child element, so its depth is one less. The
                // context surfaces attributes by local name, so a prefixed @xmlName ("xsi:someName") matches
                // on its local part ("someName").
                expression = $"@{XmlNames.SplitPrefix(name).Local}";
                depth = depthExpr is null ? null : $"{depthExpr} - 1";
            }
            else if (member.Type.ListElement is { } element && !flattened)
            {
                expression = $"{name}/{XmlNames.ListItemName((ListShape)member.Type.Target)}";
            }
            else if (incrementalMap && !flattened)
            {
                expression = $"{name}/entry";
            }
            else
            {
                expression = name;
            }

            var testArg = depth is null ? $"\"{expression}\"" : $"\"{expression}\", {depth}";
            writer.OpenBlock($"if (context.TestExpression({testArg}))", () =>
            {
                WriteMemberBody(writer, member, incrementalMap);
                if (depthExpr is not null)
                {
                    writer.WriteLine("continue;");
                }
            });

            if (i < members.Count - 1)
            {
                writer.WriteLine();
            }
        }
    }

    private static void WriteMemberBody(CodeWriter writer, Member member, bool incrementalMap)
    {
        var target = $"unmarshalledObject.{member.PropertyName}";

        if (member.Type.ListElement is { } element)
        {
            // A top-level list is built one element per matching node (both flattened and wrapped), created
            // lazily on the first hit, matching C2J. The element unmarshaller recurses for nested collections.
            writer.OpenBlock($"if ({target} == null)", () =>
            {
                writer.WriteLine($"{target} = new {member.Type.DotNetType}();");
            });
            writer.WriteLine($"var unmarshaller = {CollectionUnmarshaller(element).Instance};");
            writer.WriteLine($"{target}.Add(unmarshaller.Unmarshall(context));");
            return;
        }

        // Built one kvp per matched element (the repeated member element when flattened, else each <entry>)
        // via XmlKeyValueUnmarshaller; the runtime XmlDictionaryUnmarshaller only reads the whole wrapped form.
        if (incrementalMap && member.Type.MapValue is { } flatValue)
        {
            var map = (MapShape)member.Type.Target;
            var inner = CollectionUnmarshaller(flatValue);
            writer.OpenBlock($"if ({target} == null)", () =>
            {
                writer.WriteLine($"{target} = new {member.Type.DotNetType}();");
            });
            writer.WriteLine($"""var unmarshaller = new XmlKeyValueUnmarshaller<string, {flatValue.DotNetType}, StringUnmarshaller, {inner.Type}>(StringUnmarshaller.Instance, {inner.Instance}, "{XmlNames.MapKeyName(map)}", "{XmlNames.MapValueName(map)}");""");
            writer.WriteLine("var item = unmarshaller.Unmarshall(context);");
            writer.WriteLine($"{target}.Add(item.Key, item.Value);");
            return;
        }

        // A map (and any scalar/blob/structure) reads whole; the instance recurses for a nested collection value.
        writer.WriteLine($"var unmarshaller = {CollectionUnmarshaller(member.Type).Instance};");
        writer.WriteLine($"{target} = unmarshaller.Unmarshall(context);");
    }

    // The runtime unmarshaller type name and instance for a scalar, blob, structure, list or map — recursing
    // for nested collections (an XmlListUnmarshaller / XmlDictionaryUnmarshaller is built, not a singleton).
    // Scalars reuse the JSON scalar map (the Nullable* variants and enum/timestamp handling are identical —
    // the runtime unmarshallers implement both IJson and IXml); a blob reads base64 text into a MemoryStream;
    // map keys are always strings. Mirrors JsonBodyMemberUnmarshaller.CollectionUnmarshaller.
    private static (string Type, string Instance) CollectionUnmarshaller(TypeDescriptor type)
    {
        if (type.IsStructure)
        {
            var name = type.UnmarshallerName ?? throw new GeneratorException($"Structure '{type.DotNetType}' has no unmarshaller name.");
            return (name, $"{name}.Instance");
        }
        if (type.IsBlob)
        {
            return ("MemoryStreamUnmarshaller", "MemoryStreamUnmarshaller.Instance");
        }
        if (JsonBodyMemberUnmarshaller.ScalarUnmarshaller(type) is { } scalar)
        {
            return (scalar, $"{scalar}.Instance");
        }
        if (type.ListElement is { } element)
        {
            var inner = CollectionUnmarshaller(element);
            var unmarshaller = $"XmlListUnmarshaller<{element.DotNetType}, {inner.Type}>";
            return (unmarshaller, $"new {unmarshaller}({inner.Instance})");
        }
        if (type.MapValue is { } mapValue)
        {
            var map = (MapShape)type.Target;
            var inner = CollectionUnmarshaller(mapValue);
            var unmarshaller = $"XmlDictionaryUnmarshaller<string, {mapValue.DotNetType}, StringUnmarshaller, {inner.Type}>";
            return (unmarshaller, $"""new {unmarshaller}(StringUnmarshaller.Instance, {inner.Instance}, "{XmlNames.MapKeyName(map)}", "{XmlNames.MapValueName(map)}")""");
        }
        throw new GeneratorException($"Unsupported restXml member type '{type.DotNetType}'.");
    }
}
