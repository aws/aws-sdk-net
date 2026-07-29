using SmithyDotNet.Generator.Writers.CodeAnalysis;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class NullCollectionInitializerAnalyzerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private readonly string _nullCollectionInitializerAnalyzer;
    public NullCollectionInitializerAnalyzerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new NullCollectionInitializerAnalyzerWriter(fixture.Context, ModelFileName);
        _nullCollectionInitializerAnalyzer = writer.Write();
    }
    [Fact]
    public void NullCollectionInitializerHasCorrectUsingsAndNamespace()
    {
        AssertHelper("using Microsoft.CodeAnalysis;");
        AssertHelper("using Microsoft.CodeAnalysis.Diagnostics;");
        AssertHelper("using Amazon.CodeAnalysis.Shared;");
        AssertHelper("namespace Amazon.CloudTrailData.CodeAnalysis");
    }

    [Fact]
    public void NullCollectionInitializerHasCorrectClassSignatureAndContents()
    {
        AssertHelper("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
        AssertHelper("public class NullCollectionInitializerAnalyzer : AbstractNullCollectionInitializerAnalyzer");
        AssertHelper("""protected override string GetModelNamespace() => "Amazon.CloudTrailData.Model";""");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _nullCollectionInitializerAnalyzer);
    }
}
