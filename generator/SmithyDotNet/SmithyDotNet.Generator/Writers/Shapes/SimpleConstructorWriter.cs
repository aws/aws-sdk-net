using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Shapes;

/// <summary>
/// Emits the <c>simpleConstructors</c> convenience constructors for a request or structure class:
/// an explicit empty constructor (the parameterized ones remove the implicit default) followed by one
/// constructor per form, each setting the listed properties. Shared by the request and structure
/// writers. A class with no <c>simpleConstructors</c> entry emits nothing and keeps its implicit
/// default constructor.
/// <para />
/// C2J assigns the member backing field; this generator's properties are auto-implemented, so each
/// parameter is assigned through the property. The constructor signature — and therefore the public
/// API and the generated reflection test — is identical.
/// </summary>
public static class SimpleConstructorWriter
{
    public static void Write(CodeWriter writer, GenerationContext context, string className, IReadOnlyList<Member> members)
    {
        if (context.Customizations.ConstructorFormsFor(className) is not { } forms)
        {
            return;
        }

        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Empty constructor used to set properties independently even when a simple constructor is available");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}() {{ }}");

        foreach (var form in forms)
        {
            var formMembers = ConvenienceMembers.Resolve(form, members);
            var parameters = ConvenienceMembers.ParameterList(formMembers, remapStream: false);
            var paramTags = formMembers
                .Select(m => (SdkNaming.ToParameterName(m.PropertyName), DocumentationFormatter.ParamDocForConstructor(m.Documentation, className, m.PropertyName)))
                .ToArray();

            writer.WriteLine();
            DocumentationFormatter.WriteConstructorDocumentation(writer, [$"Instantiates {className} with the parameterized properties"], paramTags);
            writer.OpenBlock($"public {className}({parameters})", () =>
            {
                foreach (var member in formMembers)
                {
                    writer.WriteLine($"this.{member.PropertyName} = {SdkNaming.ToParameterName(member.PropertyName)};");
                }
            });
        }

        // Separate the constructors from the first member the caller writes next.
        writer.WriteLine();
    }
}
