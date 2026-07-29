using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

[Collection(nameof(CloudTrailModelCollection))]
public class EndpointParametersWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public EndpointParametersWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new EndpointParametersWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ClassNameHasNoAmazonPrefix()
    {
        // The file is AmazonCloudTrailDataEndpointParameters but the class name drops the Amazon
        // prefix, matching the existing SDK.
        Assert.Contains("public class CloudTrailDataEndpointParameters : EndpointParameters", _output);
    }

    [Fact]
    public void ConstructorDefaultsBooleanParametersOnly()
    {
        // Only UseDualStack/UseFIPS carry a default; Region/Endpoint have none and are not assigned.
        Assert.Contains("UseDualStack = false;", _output);
        Assert.Contains("UseFIPS = false;", _output);
        Assert.DoesNotContain("Region =", _output);
        Assert.DoesNotContain("Endpoint =", _output);
    }

    [Fact]
    public void StringParametersEmitStringProperty()
    {
        Assert.Contains("public string Region", _output);
        Assert.Contains("get => (string)this[\"Region\"];", _output);
        Assert.Contains("set => this[\"Region\"] = value;", _output);
    }

    [Fact]
    public void BooleanParametersEmitNullableBoolProperty()
    {
        Assert.Contains("public bool? UseFIPS", _output);
        Assert.Contains("get => (bool?)this[\"UseFIPS\"];", _output);
    }

    [Fact]
    public void PropertyDocsComeFromModelDocumentation()
    {
        Assert.Contains("/// The AWS region used to dispatch the request.", _output);
    }
}
