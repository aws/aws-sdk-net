using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Service;

[Collection(nameof(CloudTrailModelCollection))]
public class SimpleConstructorTestsWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public SimpleConstructorTestsWriterTests(CloudTrailModelFixture fixture)
    {
        var customizations = new CustomizationsModel
        {
            SimpleConstructors = new SimpleConstructorsCustomization { Constructors = { ["PutAuditEventsRequest"] = new SimpleConstructorForms { Forms = [["ChannelArn"]] } } },
        };
        var context = new GenerationContext(fixture.Index, fixture.Context.Manifest, customizations: customizations);
        _output = new SimpleConstructorTestsWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsTestClassInTestToolsNamespace()
    {
        Assert.Contains("namespace AWSSDK_DotNet.UnitTests.TestTools", _output);
        Assert.Contains("[TestClass]", _output);
        Assert.Contains("public class CloudTrailDataConstructorCustomizationsTests", _output);
    }

    [Fact]
    public void EmitsOneTestMethodPerOperationWithSimpleConstructors()
    {
        Assert.Contains("[TestCategory(\"Constructors\"), TestCategory(\"CloudTrailData\")]", _output);
        Assert.Contains("public void PutAuditEventsRequestConstructorTests()", _output);
        Assert.Contains("EnsureConstructorExists(typeof(Amazon.CloudTrailData.Model.PutAuditEventsRequest), new System.Type[] { typeof(string), });", _output);
    }

    [Fact]
    public void EmitsTheReflectionHelper()
    {
        Assert.Contains("void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)", _output);
        Assert.Contains("Assert.IsNotNull(type.GetConstructor(constructorParams));", _output);
    }
}
