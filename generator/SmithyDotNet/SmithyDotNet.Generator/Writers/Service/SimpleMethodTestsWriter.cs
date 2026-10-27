using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the <c>simpleMethods</c> unit tests (<c>{BaseName}MethodTests.cs</c>): a single
/// <c>[TestMethod]</c> asserting via reflection that every simple method overload exists. The whole
/// file is <c>#if NETFRAMEWORK</c>-guarded, matching the simple methods' own target framework. Ports
/// C2J's <c>SimpleMethodTests.tt</c>; the caller gates emission on the service having at least one
/// <c>simpleMethods</c> entry.
/// </summary>
public sealed class SimpleMethodTestsWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.SimpleMethodTestsUsings);
        FileHeader.WriteUsings(writer, [$"{context.Namespace}.Model", context.Namespace]);

        var clientType = $"{context.Namespace}.{context.ClientName}Client";

        writer.WriteLine("#if NETFRAMEWORK");
        writer.OpenNamespace("AWSSDK_DotNet.UnitTests.TestTools", () =>
        {
            writer.WriteLine("[TestClass]");
            writer.OpenBlock($"public class {context.BaseName}MethodCustomizationsTests", () =>
            {
                writer.WriteLine("[TestMethod]");
                writer.WriteLine("""[TestCategory("UnitTest")]""");
                writer.WriteLine($"""[TestCategory("SimpleMethods"), TestCategory("{context.ServiceName}")]""");
                writer.OpenBlock($"public void {context.BaseName}SimpleMethodTests()", () =>
                {
                    foreach (var operation in context.Operations)
                    {
                        if (context.Customizations.MethodFormsFor(operation.Name) is not { } forms)
                        {
                            continue;
                        }

                        var members = TypeMapper.ResolveMembers(operation.Input, context);
                        foreach (var form in forms)
                        {
                            var formMembers = ConvenienceMembers.Resolve(form, members);
                            writer.WriteLine($"EnsureSimpleMethodExists(typeof({clientType}), \"{operation.Name}\", new Type[] {{ {TypeArguments(formMembers)}}});");
                        }
                    }
                });
                writer.WriteLine();
                writer.OpenBlock("void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)", () =>
                {
                    writer.WriteLine("""Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);""");
                });
            });
        });
        writer.WriteLine("#endif");

        return writer.ToFormattedString(cancellationToken);
    }

    // Each parameter type as "typeof(T), ", matching C2J's reflection test (DetermineType, no Stream remap).
    private static string TypeArguments(IEnumerable<Member> members) =>
        string.Concat(members.Select(m => $"typeof({m.Type.DotNetType}), "));
}
