using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Service;

[Collection(nameof(CloudTrailModelCollection))]
public class SimpleMethodTestsWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public SimpleMethodTestsWriterTests(CloudTrailModelFixture fixture)
    {
        var customizations = new CustomizationsModel
        {
            SimpleMethods = new SimpleMethodsCustomization { Operations = { ["PutAuditEvents"] = new SimpleMethodForms { Forms = [["ChannelArn"]] } } },
        };
        var context = new GenerationContext(fixture.Index, fixture.Context.Manifest, customizations: customizations);
        _output = new SimpleMethodTestsWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void GuardsTheWholeFileWithNetFramework()
    {
        var ifIndex = _output.IndexOf("#if NETFRAMEWORK", StringComparison.Ordinal);
        var namespaceIndex = _output.IndexOf("namespace AWSSDK_DotNet.UnitTests.TestTools", StringComparison.Ordinal);
        var endifIndex = _output.LastIndexOf("#endif", StringComparison.Ordinal);
        Assert.InRange(namespaceIndex, ifIndex, endifIndex);
    }

    [Fact]
    public void EmitsTestClassAndSingleMethodAssertingEachSimpleMethod()
    {
        Assert.Contains("public class CloudTrailDataMethodCustomizationsTests", _output);
        Assert.Contains("[TestCategory(\"SimpleMethods\"), TestCategory(\"CloudTrailData\")]", _output);
        Assert.Contains("public void CloudTrailDataSimpleMethodTests()", _output);
        Assert.Contains("EnsureSimpleMethodExists(typeof(Amazon.CloudTrailData.AmazonCloudTrailDataClient), \"PutAuditEvents\", new Type[] { typeof(string), });", _output);
    }

    [Fact]
    public void EmitsTheReflectionHelper()
    {
        Assert.Contains("void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)", _output);
        Assert.Contains("Assert.IsNotNull(type.GetMethod(methodName, simpleParams), \"Failed to find simple method \" + methodName);", _output);
    }
}
