using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

public class CodeWriterTests
{
    [Fact]
    public void OpenBlock_EmitsBracesAndIndents()
    {
        var writer = new CodeWriter();
        writer.OpenBlock("public class Foo", () =>
        {
            writer.WriteLine("public int Bar { get; set; }");
        });

        var result = writer.ToFormattedString(TestContext.Current.CancellationToken);
        Assert.Contains("public class Foo", result);
        Assert.Contains("public int Bar { get; set; }", result);
    }

    [Fact]
    public void OpenBlock_WithCustomClose()
    {
        var writer = new CodeWriter();
        writer.OpenBlock("public class Foo", () =>
        {
            writer.OpenBlock("handler.OnComplete(() =>", "});", () =>
            {
                writer.WriteLine("Console.WriteLine(\"done\");");
            });
        });

        var result = writer.ToFormattedString(TestContext.Current.CancellationToken);
        Assert.Contains("handler.OnComplete(() =>", result);
        Assert.Contains("});", result);
    }

    [Fact]
    public void OpenNamespace_EmitsNamespaceBlock()
    {
        var writer = new CodeWriter();
        writer.OpenNamespace("Amazon.CloudTrailData", () =>
        {
            writer.WriteLine("public class Placeholder { }");
        });

        var result = writer.ToFormattedString(TestContext.Current.CancellationToken);
        Assert.Contains("namespace Amazon.CloudTrailData", result);
    }

    [Fact]
    public void ToFormattedString_ProducesCompilableCSharp()
    {
        var writer = new CodeWriter();
        writer.OpenNamespace("TestNamespace", () =>
        {
            writer.OpenBlock("public partial class MyService", () =>
            {
                writer.WriteLine("public string Name { get; set; }");
                writer.WriteLine();
                writer.WriteLine("public int Count { get; set; }");
            });
        });

        var result = writer.ToFormattedString(TestContext.Current.CancellationToken);
        var tree = CSharpSyntaxTree.ParseText(result, cancellationToken: TestContext.Current.CancellationToken);
        Assert.Empty(tree.GetDiagnostics(cancellationToken: TestContext.Current.CancellationToken));
    }
}
