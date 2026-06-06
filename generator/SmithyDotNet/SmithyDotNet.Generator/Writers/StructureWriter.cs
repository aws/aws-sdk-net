using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a plain Smithy structure shape (a model class with no base type),
/// matching the public API surface of the existing AWS SDK for .NET.
/// <para />
/// Phase 1 scope: structures whose members all resolve to <c>string</c>. Any other member
/// type throws a <see cref="GeneratorException"/>. Request, response, exception, and
/// collection handling are deferred to later writers.
/// </summary>
public sealed class StructureWriter(GenerationContext context, string modelFileName)
{
    private static readonly string[] Usings =
    [
        "System",
        "System.Collections.Generic",
        "System.Xml.Serialization",
        "System.Text",
        "System.IO",
        "System.Net",
        "Amazon.Runtime",
        "Amazon.Runtime.Internal",
    ];

    private static readonly string[] SuppressedWarnings = ["CS0612", "CS0618", "CS1570"];

    /// <summary>
    /// Emits the complete formatted source file for one structure. The <paramref name="shapeId"/>
    /// supplies the class name (via <see cref="GenerationContext.ToDotNetName"/>) because a
    /// <see cref="StructureShape"/> does not carry its own ID.
    /// </summary>
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var members = ResolveMembers(structure);

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, Usings);
        FileHeader.WritePragma(writer, SuppressedWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            WriteClassDocumentation(writer, structure);
            writer.OpenBlock($"public partial class {className}", () => WriteMembers(writer, members));
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteClassDocumentation(CodeWriter writer, StructureShape structure)
    {
        var cleaned = DocumentationFormatter.Cleanup(structure.GetDocumentation());
        if (cleaned.Length == 0)
        {
            return;
        }

        writer.WriteLine("/// <summary>");
        DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        writer.WriteLine("/// </summary>");
    }

    private static void WriteMembers(CodeWriter writer, IReadOnlyList<Member> members)
    {
        for (var i = 0; i < members.Count; i++)
        {
            // Blank line between properties, but not before the first or after the last.
            if (i > 0)
            {
                writer.WriteLine();
            }

            WriteProperty(writer, members[i]);
        }
    }

    private static void WriteProperty(CodeWriter writer, Member member)
    {
        writer.WriteLine("/// <summary>");
        var cleanedDoc = DocumentationFormatter.Cleanup($"Gets and sets the property {member.PropertyName}. {member.Documentation}");
        DocumentationFormatter.WriteCommentBlock(writer, cleanedDoc);
        writer.WriteLine("/// </summary>");

        if (member.AwsProperty is string awsProperty)
        {
            writer.WriteLine(awsProperty);
        }

        writer.WriteLine($"public {member.DotNetType} {member.PropertyName} {{ get; set; }}");
    }

    private List<Member> ResolveMembers(StructureShape structure)
    {
        var resolved = new List<Member>(structure.Members.Count);
        foreach (var (memberName, member) in structure.Members)
        {
            var target = context.Resolve(member.Target);
            resolved.Add(new Member(
                PropertyName: SdkNaming.ToUpperFirstCharacter(memberName),
                DotNetType: MapMemberType(target),
                AwsProperty: BuildAwsProperty(member, target),
                Documentation: member.GetDocumentation() ?? string.Empty)
            );
        }

        return resolved.OrderBy(m => m.PropertyName, StringComparer.Ordinal).ToList();
    }

    private static string MapMemberType(Shape target)
    {
        if (target is StringShape)
        {
            return "string";
        }

        throw new GeneratorException($"Unsupported member type '{target.Type}'.");
    }

    private static string? BuildAwsProperty(MemberShape member, Shape target)
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

    private sealed record Member(string PropertyName, string DotNetType, string? AwsProperty, string Documentation);
}
