using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the <c>context.Writer</c> (<c>XmlWriter</c>) calls that serialize a structure's members into a
/// restXml body. Shared by the operation request marshaller (<see cref="XmlRequestMarshallerWriter"/>) and
/// each generated structure marshaller (<see cref="XmlStructureMarshallerWriter"/>); the object variable
/// name is the only thing that differs (<c>publicRequest</c> vs. <c>requestObject</c>), mirroring the JSON
/// writers.
/// <para/>
/// A nested structure member dispatches to its own <c>{Shape}Marshaller.Instance</c> (restXml generates a
/// marshaller class per structure, like JSON); lists and maps loop inline, delegating any structure element.
/// A member's placement follows its traits: <c>@xmlAttribute</c> members are written as attributes first
/// (XML requires attributes before child elements), then element members; <c>@xmlFlattened</c> collections
/// drop their wrapper element; <c>@xmlNamespace</c> adds an xmlns to the element (a prefixed namespace is
/// declared via an <c>xmlns:prefix</c> attribute and does not namespace the element; an unprefixed one
/// places the element in that default namespace).
/// </summary>
public static class XmlBodyMemberMarshaller
{
    // restXml body timestamps default to date-time (ISO8601) when @timestampFormat is unset.
    // https://smithy.io/2.0/aws/protocols/aws-restxml-protocol.html
    private const string BodyTimestampDefault = "date-time";

    /// <summary>
    /// Writes every member of <paramref name="owner"/> accessed through <paramref name="objectVar"/>
    /// (<c>publicRequest</c> or <c>requestObject</c>): attribute members first, then elements.
    /// </summary>
    public static void WriteStructureBody(CodeWriter writer, StructureShape owner, List<Member> members, string objectVar)
    {
        // XML attributes must precede child elements, so emit them first regardless of declaration order.
        foreach (var member in members.Where(m => owner.Members[m.ModeledName].IsXmlAttribute()))
        {
            WriteAttributeMember(writer, owner, member, objectVar);
        }
        foreach (var member in members.Where(m => !owner.Members[m.ModeledName].IsXmlAttribute()))
        {
            WriteElementMember(writer, owner, member, objectVar);
        }
    }

    private static void WriteAttributeMember(CodeWriter writer, StructureShape owner, Member member, string objectVar)
    {
        var memberShape = owner.Members[member.ModeledName];
        var name = XmlNames.ElementName(memberShape, member.ModeledName);
        var access = $"{objectVar}.{member.PropertyName}";
        var conversion = BodyScalarConversion(member, access)
            ?? throw new GeneratorException($"@xmlAttribute member '{member.PropertyName}' must be a scalar; got '{member.Type.DotNetType}'.");

        // A prefixed name ("xsi:someName") or a member @xmlNamespace needs the prefixed WriteAttributeString
        // overload; XmlWriter rejects a ':' in a plain local name. The prefix comes from the member's own
        // namespace when it has one, else from the name itself (the prefix is declared on an ancestor element).
        var (namePrefix, localName) = XmlNames.SplitPrefix(name);
        var ns = memberShape.GetXmlNamespace();
        writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
        {
            if (ns is not null)
            {
                writer.WriteLine($"""context.Writer.WriteAttributeString("{ns.Prefix}", "{localName}", "{ns.Uri}", {conversion});""");
            }
            else if (namePrefix is not null)
            {
                writer.WriteLine($"""context.Writer.WriteAttributeString("{namePrefix}", "{localName}", null, {conversion});""");
            }
            else
            {
                writer.WriteLine($"""context.Writer.WriteAttributeString("{localName}", {conversion});""");
            }
        });
    }

    private static void WriteElementMember(CodeWriter writer, StructureShape owner, Member member, string objectVar)
    {
        var memberShape = owner.Members[member.ModeledName];
        var name = XmlNames.ElementName(memberShape, member.ModeledName);
        var ns = XmlNames.Namespace(memberShape, member.Type.Target);
        var access = $"{objectVar}.{member.PropertyName}";
        var isSet = $"{objectVar}.IsSet{member.PropertyName}()";

        if (member.Type.IsStructure)
        {
            writer.OpenBlock($"if ({isSet})", () =>
            {
                OpenElement(writer, name, ns);
                WriteStructureDelegate(writer, member.Type, access);
                writer.WriteLine("context.Writer.WriteEndElement();");
            });
            return;
        }

        if (member.Type.ListElement is { } element)
        {
            WriteListMember(writer, memberShape, member, element, objectVar);
            return;
        }

        if (member.Type.MapValue is { } mapValue)
        {
            writer.OpenBlock($"if ({isSet})", () =>
            {
                WriteMapMember(writer, memberShape, member, mapValue, access);
            });
            return;
        }

        // A blob body member is base64 text content (a body blob is never @streaming — that is @httpPayload-only).
        if (member.Type.IsBlob)
        {
            writer.OpenBlock($"if ({isSet})", () =>
            {
                WriteLeafElement(writer, name, ns, $"StringUtils.FromMemoryStream({access})");
            });
            return;
        }

        var conversion = BodyScalarConversion(member, access)
            ?? throw new GeneratorException($"Unsupported body member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
        writer.OpenBlock($"if ({isSet})", () =>
        {
            WriteLeafElement(writer, name, ns, conversion);
        });
        if (member.IsIdempotencyToken)
        {
            writer.OpenBlock("else", () =>
            {
                writer.WriteLine($"""context.Writer.WriteElementString("{name}", Guid.NewGuid().ToString());""");
            });
        }
    }

    // A list: a wrapper element named after the member (unless @xmlFlattened), then one element per item
    // named after the list value (or the member, when flattened). The collection local matches C2J's name
    // so the emitted code lines up when cross-referencing.
    private static void WriteListMember(CodeWriter writer, MemberShape memberShape, Member member, TypeDescriptor element, string objectVar)
    {
        var list = (ListShape)member.Type.Target;
        var flattened = XmlNames.IsFlattened(memberShape, list);
        var wrapperName = XmlNames.ElementName(memberShape, member.ModeledName);
        var access = $"{objectVar}.{member.PropertyName}";
        var local = objectVar.Replace(".", "") + member.PropertyName;
        var itemVar = $"{local}Value";
        // A flattened list names each item after the member (and carries the member's namespace on the
        // repeated item element); otherwise the wrapper carries the member namespace and items the list
        // value's own namespace.
        var itemName = flattened ? wrapperName : XmlNames.ListItemName(list);
        var itemNs = flattened ? XmlNames.Namespace(memberShape, element.Target) : XmlNames.Namespace(list.Member, element.Target);

        writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
        {
            writer.WriteLine($"var {local} = {access};");
            if (!flattened)
            {
                OpenElement(writer, wrapperName, XmlNames.Namespace(memberShape, list));
            }
            writer.OpenBlock($"foreach (var {itemVar} in {local})", () =>
            {
                WriteListItem(writer, itemName, itemNs, element, itemVar, depth: 1);
            });
            if (!flattened)
            {
                writer.WriteLine("context.Writer.WriteEndElement();");
            }
        });
    }

    // Emits one <itemName> element for a list item. A nested list/map recurses; depth disambiguates the
    // generated loop variables so nested foreach/kvp names never collide.
    private static void WriteListItem(CodeWriter writer, string itemName, XmlNamespaceTrait? itemNs, TypeDescriptor element, string itemVar, int depth)
    {
        if (element.IsStructure)
        {
            writer.OpenBlock($"if ({itemVar} != null)", () =>
            {
                OpenElement(writer, itemName, itemNs);
                WriteStructureDelegate(writer, element, itemVar);
                writer.WriteLine("context.Writer.WriteEndElement();");
            });
            return;
        }
        if (element.ListElement is { } innerElement)
        {
            OpenElement(writer, itemName, itemNs);
            WriteNestedList(writer, (ListShape)element.Target, innerElement, itemVar, depth);
            writer.WriteLine("context.Writer.WriteEndElement();");
            return;
        }
        if (element.MapValue is { } innerValue)
        {
            OpenElement(writer, itemName, itemNs);
            WriteMapEntries(writer, (MapShape)element.Target, innerValue, itemVar, depth);
            writer.WriteLine("context.Writer.WriteEndElement();");
            return;
        }

        // A string/enum writes directly; a blob is base64; every other scalar routes through StringUtils
        // like a structure member does, so special floats serialize as Infinity/-Infinity/NaN (per the
        // restXml spec) rather than XmlWriter.WriteValue(double)'s INF/-INF. Elements are non-nullable
        // (List<int>), so there is no .Value unwrap.
        OpenElement(writer, itemName, itemNs);
        if (element.IsBlob)
        {
            writer.WriteLine($"context.Writer.WriteValue(StringUtils.FromMemoryStream({itemVar}));");
        }
        else if (element.MarshalsAsString)
        {
            writer.WriteLine($"context.Writer.WriteValue({itemVar});");
        }
        else
        {
            var conv = ScalarConversion(element, itemVar, element.TimestampFormat, nullable: false)
                ?? throw new GeneratorException($"Unsupported restXml list element type '{element.DotNetType}'.");
            writer.WriteLine($"context.Writer.WriteValue({conv});");
        }
        writer.WriteLine("context.Writer.WriteEndElement();");
    }

    private static void WriteNestedList(CodeWriter writer, ListShape list, TypeDescriptor element, string access, int depth)
    {
        var itemVar = $"item{depth}";
        var itemNs = XmlNames.Namespace(list.Member, element.Target);
        writer.OpenBlock($"foreach (var {itemVar} in {access})", () =>
        {
            WriteListItem(writer, XmlNames.ListItemName(list), itemNs, element, itemVar, depth + 1);
        });
    }

    // A map member: a wrapper named after the member (unless @xmlFlattened), then one <entry> (or, when
    // flattened, one wrapper-named element) per kvp holding a <key> and a <value>.
    private static void WriteMapMember(CodeWriter writer, MemberShape memberShape, Member member, TypeDescriptor mapValue, string access)
    {
        var map = (MapShape)member.Type.Target;
        var flattened = XmlNames.IsFlattened(memberShape, map);
        var wrapperName = XmlNames.ElementName(memberShape, member.ModeledName);

        if (!flattened)
        {
            OpenElement(writer, wrapperName, XmlNames.Namespace(memberShape, map));
        }
        // A flattened map has no wrapper and names each entry element after the member; a non-flattened
        // map wraps its entries in <entry>. Nested maps are never flattened (the trait is on the member).
        WriteMapEntryLoop(writer, map, mapValue, access, "kvp", flattened ? wrapperName : "entry", valueDepth: 1);
        if (!flattened)
        {
            writer.WriteLine("context.Writer.WriteEndElement();");
        }
    }

    // The entries of a non-flattened map accessed via access (used for a nested map value/item): the
    // standard <entry><key/><value/></entry> per kvp, with a depth-disambiguated loop variable.
    private static void WriteMapEntries(CodeWriter writer, MapShape map, TypeDescriptor mapValue, string access, int depth)
    {
        WriteMapEntryLoop(writer, map, mapValue, access, $"kvp{depth}", "entry", depth + 1);
    }

    private static void WriteMapEntryLoop(CodeWriter writer, MapShape map, TypeDescriptor mapValue, string access, string kvpVar, string entryName, int valueDepth)
    {
        var keyName = XmlNames.MapKeyName(map);
        var valueName = XmlNames.MapValueName(map);
        var keyNs = XmlNames.Namespace(map.Key, null);
        writer.OpenBlock($"foreach (var {kvpVar} in {access})", () =>
        {
            writer.WriteLine($"""context.Writer.WriteStartElement("{entryName}");""");
            WriteLeafElement(writer, keyName, keyNs, $"{kvpVar}.Key");
            WriteMapValue(writer, valueName, map.Value, mapValue, $"{kvpVar}.Value", valueDepth);
            writer.WriteLine("context.Writer.WriteEndElement();");
        });
    }

    // Emits the <valueName> element holding a map entry's value. A nested map/list recurses; depth
    // disambiguates the generated loop variables.
    private static void WriteMapValue(CodeWriter writer, string valueName, MemberShape valueMember, TypeDescriptor value, string valueAccess, int depth)
    {
        var ns = XmlNames.Namespace(valueMember, value.Target);
        if (value.IsStructure)
        {
            OpenElement(writer, valueName, ns);
            WriteStructureDelegate(writer, value, valueAccess);
            writer.WriteLine("context.Writer.WriteEndElement();");
            return;
        }
        if (value.MapValue is { } innerValue)
        {
            OpenElement(writer, valueName, ns);
            WriteMapEntries(writer, (MapShape)value.Target, innerValue, valueAccess, depth);
            writer.WriteLine("context.Writer.WriteEndElement();");
            return;
        }
        if (value.ListElement is { } innerElement)
        {
            OpenElement(writer, valueName, ns);
            WriteNestedList(writer, (ListShape)value.Target, innerElement, valueAccess, depth);
            writer.WriteLine("context.Writer.WriteEndElement();");
            return;
        }
        if (value.IsBlob)
        {
            WriteLeafElement(writer, valueName, ns, $"StringUtils.FromMemoryStream({valueAccess})");
            return;
        }
        if (value.MarshalsAsString)
        {
            WriteLeafElement(writer, valueName, ns, valueAccess);
            return;
        }
        // Every other scalar routes through StringUtils, not kvp.Value.ToString(): ToString() gives
        // True/False for bool and culture-dependent text for double/timestamp.
        var conv = ScalarConversion(value, valueAccess, value.TimestampFormat, nullable: false)
            ?? throw new GeneratorException($"Unsupported restXml map value type '{value.DotNetType}'.");
        WriteLeafElement(writer, valueName, ns, conv);
    }

    // A structure value is serialized by its own generated marshaller, which writes the structure's members
    // into the element the caller has already opened (mirrors the JSON structure dispatch).
    private static void WriteStructureDelegate(CodeWriter writer, TypeDescriptor type, string access)
    {
        var marshaller = type.MarshallerName ?? throw new GeneratorException($"Structure '{type.DotNetType}' has no marshaller name.");
        writer.WriteLine($"{marshaller}.Instance.Marshall({access}, context);");
    }

    /// <summary>
    /// Opens a container element (structure/list/map wrapper, or a scalar element that needs an xmlns).
    /// A prefixed <c>@xmlNamespace</c> leaves the element unnamespaced and declares the prefix via an
    /// <c>xmlns:prefix</c> attribute; an unprefixed one places the element in that default namespace.
    /// </summary>
    internal static void OpenElement(CodeWriter writer, string name, XmlNamespaceTrait? ns)
    {
        if (ns is null)
        {
            writer.WriteLine($"""context.Writer.WriteStartElement("{name}");""");
            return;
        }
        if (string.IsNullOrEmpty(ns.Prefix))
        {
            writer.WriteLine($"""context.Writer.WriteStartElement("{name}", "{ns.Uri}");""");
            return;
        }
        writer.WriteLine($"""context.Writer.WriteStartElement("{name}");""");
        writer.WriteLine($"""context.Writer.WriteAttributeString("xmlns", "{ns.Prefix}", null, "{ns.Uri}");""");
    }

    // A scalar/text leaf element. Without a namespace it is a single WriteElementString; with one it opens
    // the element (applying the namespace rule) and writes the text between the tags.
    private static void WriteLeafElement(CodeWriter writer, string name, XmlNamespaceTrait? ns, string conversion)
    {
        if (ns is null)
        {
            writer.WriteLine($"""context.Writer.WriteElementString("{name}", {conversion});""");
            return;
        }
        OpenElement(writer, name, ns);
        writer.WriteLine($"context.Writer.WriteString({conversion});");
        writer.WriteLine("context.Writer.WriteEndElement();");
    }

    // The StringUtils conversion for a restXml body scalar member, or null when the type has no scalar
    // form. A dataTypeSwap marshaller replaces the modeled conversion.
    private static string? BodyScalarConversion(Member member, string access)
    {
        if (member.Type.MarshallerOverride is { } marshaller)
        {
            return $"{marshaller}({MarshallerCommon.SwapArgument(member.Type, access)})";
        }

        return ScalarConversion(member.Type, access, member.TimestampFormat, nullable: true);
    }

    // The StringUtils conversion for a restXml body scalar, or null when the type has no scalar form.
    // A nullable value type (a structure member) unwraps with .Value (C2J's XML body marshaller); a
    // non-nullable one (a collection element) does not. A timestamp uses its @timestampFormat, else date-time.
    private static string? ScalarConversion(TypeDescriptor type, string access, string? timestampFormat, bool nullable)
    {
        var value = nullable ? $"{access}.Value" : access;
        return type.Target switch
        {
            StringShape or EnumShape => $"StringUtils.FromString({access})",
            BooleanShape => $"StringUtils.FromBool({value})",
            IntegerShape or IntEnumShape => $"StringUtils.FromInt({value})",
            LongShape => $"StringUtils.FromLong({value})",
            FloatShape => $"StringUtils.FromFloat({value})",
            DoubleShape => $"StringUtils.FromDouble({value})",
            ByteShape => $"StringUtils.FromSByte({value})",
            ShortShape => $"StringUtils.FromShort({value})",
            BigIntegerShape => $"StringUtils.FromBigInteger({value})",
            BigDecimalShape => $"StringUtils.FromBigDecimal({value})",
            TimestampShape => HttpBindingConversions.TimestampStringConversion(timestampFormat ?? BodyTimestampDefault, value),
            _ => null,
        };
    }
}
