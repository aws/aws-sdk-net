using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// restXml element/attribute naming and <c>@xmlFlattened</c>/<c>@xmlNamespace</c> resolution, shared by
/// the XML marshaller and unmarshaller writers. The rules follow the Smithy restXml spec: a member's
/// element name is its <c>@xmlName</c> or the member name; a list's items are <c>member</c> (or the list
/// value's <c>@xmlName</c>); a map's entries are <c>entry</c>/<c>key</c>/<c>value</c> (or the key/value
/// member's <c>@xmlName</c>); a flattened collection drops the wrapper and names each item after the member.
/// </summary>
internal static class XmlNames
{
    /// <summary>The element (or attribute) name for a member: its <c>@xmlName</c>, else the modeled name.</summary>
    public static string ElementName(MemberShape member, string modeledName) => member.GetXmlName() ?? modeledName;

    /// <summary>The element name for a list's items: the list value member's <c>@xmlName</c>, else <c>member</c>.</summary>
    public static string ListItemName(ListShape list) => list.Member.GetXmlName() ?? "member";

    /// <summary>A map entry's key element name: the map key member's <c>@xmlName</c>, else <c>key</c>.</summary>
    public static string MapKeyName(MapShape map) => map.Key.GetXmlName() ?? "key";

    /// <summary>A map entry's value element name: the map value member's <c>@xmlName</c>, else <c>value</c>.</summary>
    public static string MapValueName(MapShape map) => map.Value.GetXmlName() ?? "value";

    /// <summary>Whether a collection member is flattened (<c>@xmlFlattened</c> on the member or its target).</summary>
    public static bool IsFlattened(MemberShape member, Shape target) => member.IsXmlFlattened() || target.IsXmlFlattened();

    /// <summary>The <c>@xmlNamespace</c> for an element: the member reference's, else its target shape's, else null.</summary>
    public static XmlNamespaceTrait? Namespace(MemberShape member, Shape? target) => member.GetXmlNamespace() ?? target?.GetXmlNamespace();

    /// <summary>
    /// Splits a <c>prefix:local</c> name into its parts (e.g. <c>@xmlName</c> <c>"xsi:someName"</c> →
    /// <c>("xsi", "someName")</c>); a name with no colon yields a null prefix. XmlWriter forbids a colon in
    /// a local name, so an attribute/element whose name carries a prefix must be written with the prefixed
    /// overload.
    /// </summary>
    public static (string? Prefix, string Local) SplitPrefix(string name)
    {
        var colon = name.IndexOf(':');
        return colon < 0 ? (null, name) : (name[..colon], name[(colon + 1)..]);
    }
}
