using SmithyDotNet.Generator.Writers.CodeAnalysis;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class DeprecatedTargetFrameworkAnalyzerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private readonly string _deprecatedTargetFrameworkAnalyzer;
    public DeprecatedTargetFrameworkAnalyzerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new DeprecatedTargetFrameworkAnalyzerWriter(fixture.Context, ModelFileName);
        _deprecatedTargetFrameworkAnalyzer = writer.Write();
    }

    [Fact]
    public void DeprecatedTargetFrameworkHasCorrectUsingsAndNamespace()
    {
        AssertHelper("using Microsoft.CodeAnalysis;");
        AssertHelper("using Microsoft.CodeAnalysis.Diagnostics;");
        AssertHelper("using Amazon.CodeAnalysis.Shared;");
        AssertHelper("namespace Amazon.CloudTrailData.CodeAnalysis");
    }

    [Fact]
    public void DeprecatedTargetFrameworkHasCorrectClassSignature()
    {
        AssertHelper("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
        AssertHelper("public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _deprecatedTargetFrameworkAnalyzer);
    }
}
