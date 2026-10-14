using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Resolves a <c>simpleMethods</c>/<c>simpleConstructors</c> form (a list of member names) to the
/// structure's resolved <see cref="Member"/>s and builds the C# parameter list for the convenience
/// overload or constructor. Shared by the client, interface, request, and structure writers so the
/// emitted overload, its generated unit test, and the owning constructor stay in lockstep.
/// </summary>
public static class ConvenienceMembers
{
    /// <summary>
    /// Maps each name in <paramref name="form"/> to the matching resolved member (by C# property name,
    /// case-insensitive, as C2J's <c>GetFormMembers</c>), preserving form order. A name with no member
    /// is a malformed customization and throws rather than silently dropping a parameter.
    /// </summary>
    public static List<Member> Resolve(IReadOnlyList<string> form, IReadOnlyList<Member> members)
    {
        var resolved = new List<Member>(form.Count);
        foreach (var name in form)
        {
            resolved.Add(members.FirstOrDefault(m => string.Equals(m.PropertyName, name, StringComparison.OrdinalIgnoreCase))
                ?? throw new GeneratorException($"Convenience form references member '{name}', which the structure does not expose."));
        }

        return resolved;
    }

    /// <summary>
    /// The C# type of a convenience parameter. In a client overload (<paramref name="remapStream"/>)
    /// a streaming blob's <c>Stream</c> is written fully qualified as <c>System.IO.Stream</c>, matching
    /// C2J's <c>SimpleMethodFormsModel</c>; a constructor parameter keeps the plain type.
    /// </summary>
    public static string ParameterType(Member member, bool remapStream) =>
        remapStream && member.Type.DotNetType == "Stream" ? "System.IO.Stream" : member.Type.DotNetType;

    /// <summary>The comma-separated <c>{type} {name}</c> parameter list for the resolved form members.</summary>
    public static string ParameterList(IReadOnlyList<Member> members, bool remapStream) =>
        string.Join(", ", members.Select(m => $"{ParameterType(m, remapStream)} {SdkNaming.ToParameterName(m.PropertyName)}"));
}
