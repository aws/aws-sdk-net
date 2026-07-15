using SmithyDotNet.Generator.Writers.CodeAnalysis;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class PropertyValueAssignmentAnalyzerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private readonly string _propertyValueAssignmentAnalyzerWriter;

    public PropertyValueAssignmentAnalyzerWriterTests(CloudTrailModelFixture fixture)
    {
        _propertyValueAssignmentAnalyzerWriter = new PropertyValueAssignmentAnalyzerWriter(fixture.Context, ModelFileName).Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void PropertyValueAssignmentAnalyzerWriterIsCorrect()
    {
        AssertHelper("namespace Amazon.CloudTrailData.CodeAnalysis");
        AssertHelper("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
        AssertHelper("public class PropertyValueAssignmentAnalyzer : AbstractPropertyValueAssignmentAnalyzer");
        AssertHelper("""public override string GetServiceName() => "CloudTrailData";""");
        AssertHelper("using Amazon.CodeAnalysis.Shared;");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _propertyValueAssignmentAnalyzerWriter);
    }
}
