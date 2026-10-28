using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the <c>request.Parameters.Add(name, value)</c> calls that serialize a structure's members into an
/// awsQuery URL-encoded form body. Everything is written inline and recursively — awsQuery has no
/// per-structure marshaller class, so a nested structure/list/map is expanded here rather than delegated.
/// <para/>
/// Parameter names follow the aws-query spec (which reuses the XML naming traits, shared with the restXml
/// writers via <see cref="XmlNames"/>): a member's name is its <c>@xmlName</c> or modeled name; a nested
/// structure dot-joins its prefix (<c>Outer.Inner</c>); a list is <c>{name}.member.{i}</c> (or
/// <c>{name}.{i}</c> when <c>@xmlFlattened</c>), its item element named by the list value's <c>@xmlName</c>;
/// a map is <c>{name}.entry.{i}.key</c>/<c>.value</c> (or <c>{name}.{i}.*</c> when flattened). Indices are
/// 1-based, matching C2J (<c>AWSQueryRequestMarshaller.tt</c>).
/// </summary>
internal sealed class QueryBodyMemberMarshaller(GenerationContext context)
{
    // awsQuery body timestamps default to date-time (ISO8601) when @timestampFormat is unset.
    // https://smithy.io/2.0/aws/protocols/aws-query-protocol.html
    private const string BodyTimestampDefault = "date-time";

    /// <summary>
    /// Writes every member of <paramref name="owner"/> accessed through <paramref name="objectVar"/> under
    /// the parameter-name expression <paramref name="prefix"/> (a C# expression, null at the top level).
    /// <paramref name="depth"/> disambiguates generated loop locals so nested collections never collide.
    /// </summary>
    public void WriteStructureBody(CodeWriter writer, StructureShape owner, List<Member> members, string objectVar, string? prefix, int depth)
    {
        foreach (var member in members)
        {
            var memberShape = owner.Members[member.ModeledName];
            var name = XmlNames.ElementName(memberShape, member.ModeledName);
            var paramName = Join(prefix, name);
            var access = $"{objectVar}.{member.PropertyName}";

            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                WriteMember(writer, memberShape, member, access, paramName, depth);
            });

            // An unset idempotency token is auto-filled with a GUID (always a string scalar). C2J.
            if (member.IsIdempotencyToken)
            {
                writer.OpenBlock("else", () =>
                {
                    writer.WriteLine($"request.Parameters.Add({paramName}, StringUtils.FromString(Guid.NewGuid().ToString()));");
                });
            }
        }
    }

    private void WriteMember(CodeWriter writer, MemberShape memberShape, Member member, string access, string paramName, int depth)
    {
        if (member.Type.IsStructure)
        {
            var structure = (StructureShape)member.Type.Target;
            WriteStructureBody(writer, structure, TypeMapper.ResolveMembers(structure, context), access, paramName, depth + 1);
            return;
        }

        if (member.Type.ListElement is { } element)
        {
            WriteList(writer, memberShape, member.Type, element, access, paramName, depth);
            return;
        }

        if (member.Type.MapValue is { } mapValue)
        {
            WriteMap(writer, memberShape, member.Type, mapValue, access, paramName, depth);
            return;
        }

        var conversion = ScalarConversion(member.Type, access, nullable: true)
            ?? throw new GeneratorException($"Unsupported awsQuery body member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
        writer.WriteLine($"request.Parameters.Add({paramName}, {conversion});");
    }

    // A list: an empty list emits the bare member name with an empty value (C2J), otherwise one 1-based
    // indexed param per item. A non-flattened list inserts the item element name ("member" or the list
    // value's @xmlName); a flattened list drops it. Structure items recurse; scalar items convert inline.
    private void WriteList(CodeWriter writer, MemberShape memberShape, TypeDescriptor collection, TypeDescriptor element, string access, string paramName, int depth)
    {
        var list = (ListShape)collection.Target;
        var flattened = XmlNames.IsFlattened(memberShape, list);
        var itemPrefix = flattened ? paramName : Join(paramName, XmlNames.ListItemName(list));
        var indexVar = $"index{depth}";
        var itemVar = $"item{depth}";

        writer.OpenBlock($"if ({access}.Count == 0)", () =>
        {
            writer.WriteLine($"""request.Parameters.Add({paramName}, "");""");
        });
        writer.OpenBlock("else", () =>
        {
            writer.WriteLine($"int {indexVar} = 1;");
            writer.OpenBlock($"foreach (var {itemVar} in {access})", () =>
            {
                var itemParam = JoinIndex(itemPrefix, indexVar);
                if (element.IsStructure)
                {
                    var structure = (StructureShape)element.Target;
                    WriteStructureBody(writer, structure, TypeMapper.ResolveMembers(structure, context), itemVar, itemParam, depth + 1);
                }
                else
                {
                    var conversion = ScalarConversion(element, itemVar, nullable: false)
                        ?? throw new GeneratorException($"Unsupported awsQuery list element type '{element.DotNetType}'.");
                    writer.WriteLine($"request.Parameters.Add({itemParam}, {conversion});");
                }
                writer.WriteLine($"{indexVar}++;");
            });
        });
    }

    // A map: one 1-based indexed entry per kvp. A non-flattened map wraps each entry under "entry"
    // (Map.entry.1.key / .value); a flattened map drops it (Map.1.key / .value). Key and value element
    // names come from @xmlName (defaulting to key/value). Structure values recurse; a list value expands
    // under a "member"-indexed sub-key (C2J); scalar values convert inline. Keys are always strings.
    private void WriteMap(CodeWriter writer, MemberShape memberShape, TypeDescriptor collection, TypeDescriptor mapValue, string access, string paramName, int depth)
    {
        var map = (MapShape)collection.Target;
        var flattened = XmlNames.IsFlattened(memberShape, map);
        var keyName = XmlNames.MapKeyName(map);
        var valueName = XmlNames.MapValueName(map);
        var indexVar = $"index{depth}";
        var kvpVar = $"kvp{depth}";

        writer.WriteLine($"int {indexVar} = 1;");
        writer.OpenBlock($"foreach (var {kvpVar} in {access})", () =>
        {
            var entryPrefix = JoinIndex(flattened ? paramName : Join(paramName, "entry"), indexVar);
            writer.WriteLine($"request.Parameters.Add({Join(entryPrefix, keyName)}, StringUtils.FromString({kvpVar}.Key));");

            var valueParam = Join(entryPrefix, valueName);
            if (mapValue.IsStructure)
            {
                var structure = (StructureShape)mapValue.Target;
                WriteStructureBody(writer, structure, TypeMapper.ResolveMembers(structure, context), $"{kvpVar}.Value", valueParam, depth + 1);
            }
            else if (mapValue.ListElement is { } valueElement)
            {
                var valueIndexVar = $"vindex{depth}";
                var valueItemVar = $"vitem{depth}";
                var conversion = ScalarConversion(valueElement, valueItemVar, nullable: false)
                    ?? throw new GeneratorException($"Unsupported awsQuery map list-value element type '{valueElement.DotNetType}'.");
                writer.WriteLine($"int {valueIndexVar} = 1;");
                writer.OpenBlock($"foreach (var {valueItemVar} in {kvpVar}.Value)", () =>
                {
                    writer.WriteLine($"request.Parameters.Add({JoinIndex(Join(valueParam, "member"), valueIndexVar)}, {conversion});");
                    writer.WriteLine($"{valueIndexVar}++;");
                });
            }
            else
            {
                var conversion = ScalarConversion(mapValue, $"{kvpVar}.Value", nullable: false)
                    ?? throw new GeneratorException($"Unsupported awsQuery map value type '{mapValue.DotNetType}'.");
                writer.WriteLine($"request.Parameters.Add({valueParam}, {conversion});");
            }
            writer.WriteLine($"{indexVar}++;");
        });
    }

    // The StringUtils conversion for an awsQuery scalar, or null when the type has no scalar form. A
    // nullable value type (a top-level member) unwraps with .Value; a non-sparse collection element does
    // not. A dataTypeSwap marshaller replaces the modeled conversion (mirrors the restXml body path).
    private static string? ScalarConversion(TypeDescriptor type, string access, bool nullable)
    {
        if (type.MarshallerOverride is { } marshaller)
        {
            return $"{marshaller}({MarshallerCommon.SwapArgument(type, access)})";
        }

        var value = nullable && type.IsNullableValueType ? $"{access}.Value" : access;
        return type.Target switch
        {
            StringShape or EnumShape => $"StringUtils.FromString({access})",
            BooleanShape => $"StringUtils.FromBool({value})",
            IntegerShape or IntEnumShape => $"StringUtils.FromInt({value})",
            LongShape => $"StringUtils.FromLong({value})",
            FloatShape => $"StringUtils.FromFloat({value})",
            DoubleShape => $"StringUtils.FromDouble({value})",
            TimestampShape => HttpBindingConversions.TimestampStringConversion(type.TimestampFormat ?? BodyTimestampDefault, value),
            BlobShape => $"StringUtils.FromMemoryStream({access})",
            _ => null,
        };
    }

    // Append a literal name segment to a parameter-name expression: emits  "Outer" + ".Inner"  as C# source.
    private static string Join(string? prefix, string name) =>
        prefix is null ? $"\"{name}\"" : $"{prefix} + \".{name}\"";

    // Append a runtime 1-based index: emits  "Outer.member" + "." + index1  as C# source.
    private static string JoinIndex(string prefix, string indexVar) => $"{prefix} + \".\" + {indexVar}";
}
