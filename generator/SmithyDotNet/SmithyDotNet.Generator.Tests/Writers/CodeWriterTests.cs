using System.Text.Json;
using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator;
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

    [Fact]
    public void NativeValue_RendersStringArrayAsListInitializer()
    {
        var value = JsonDocument.Parse("[\"a\", \"b\"]").RootElement;
        Assert.Equal("new List<string> { \"a\", \"b\" }", CodeWriter.NativeValue(value));
    }

    [Fact]
    public void NativeValue_RendersEmptyStringArrayAsEmptyListInitializer()
    {
        var value = JsonDocument.Parse("[]").RootElement;
        Assert.Equal("new List<string> {  }", CodeWriter.NativeValue(value));
    }

    [Fact]
    public void NativeValue_ThrowsOnNonStringArrayElement()
    {
        var value = JsonDocument.Parse("[1, 2]").RootElement;
        Assert.Throws<GeneratorException>(() => CodeWriter.NativeValue(value));
    }
}
