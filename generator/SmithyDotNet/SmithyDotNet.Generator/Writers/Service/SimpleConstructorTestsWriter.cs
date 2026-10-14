using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the <c>simpleConstructors</c> unit tests (<c>{BaseName}ConstructorTests.cs</c>): one
/// <c>[TestMethod]</c> per operation whose <c>{Op}Request</c> has simple constructors, asserting via
/// reflection that each form's constructor exists. Ports C2J's <c>SimpleConstructorTests.tt</c>; the
/// caller gates emission on the service having at least one <c>simpleConstructors</c> entry.
/// </summary>
public sealed class SimpleConstructorTestsWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, [.. FileHeader.SimpleConstructorTestsUsings, context.Namespace, $"{context.Namespace}.Model"]);

        writer.OpenNamespace("AWSSDK_DotNet.UnitTests.TestTools", () =>
        {
            writer.WriteLine("[TestClass]");
            writer.OpenBlock($"public class {context.BaseName}ConstructorCustomizationsTests", () =>
            {
                foreach (var operation in context.Operations)
                {
                    var requestClass = $"{operation.Name}Request";
                    if (context.Customizations.ConstructorFormsFor(requestClass) is not { } forms)
                    {
                        continue;
                    }

                    var members = TypeMapper.ResolveMembers(operation.Input, context);

                    writer.WriteLine("[TestMethod]");
                    writer.WriteLine("""[TestCategory("UnitTest")]""");
                    writer.WriteLine($"""[TestCategory("Constructors"), TestCategory("{context.ServiceName}")]""");
                    writer.OpenBlock($"public void {operation.Name}RequestConstructorTests()", () =>
                    {
                        foreach (var form in forms)
                        {
                            var formMembers = ConvenienceMembers.Resolve(form, members);
                            writer.WriteLine($"EnsureConstructorExists(typeof({context.Namespace}.Model.{requestClass}), new System.Type[] {{ {TypeArguments(formMembers)}}});");
                        }
                    });
                    writer.WriteLine();
                }

                writer.OpenBlock("void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)", () =>
                {
                    writer.WriteLine("Assert.IsNotNull(type.GetConstructor(constructorParams));");
                });
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    // Each parameter type as "typeof(T), " (trailing comma and space), matching C2J's reflection test.
    private static string TypeArguments(IEnumerable<Member> members) =>
        string.Concat(members.Select(m => $"typeof({m.Type.DotNetType}), "));
}
