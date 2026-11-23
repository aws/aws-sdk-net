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
        // Scoped to the constructor body: the indexer setter legitimately assigns every parameter.
        var ctorStart = _output.IndexOf("public CloudTrailDataEndpointParameters()", StringComparison.Ordinal);
        var ctorBody = _output.Substring(ctorStart, _output.IndexOf('}', ctorStart) - ctorStart);
        Assert.Contains("UseDualStack = false;", ctorBody);
        Assert.Contains("UseFIPS = false;", ctorBody);
        Assert.DoesNotContain("Region =", ctorBody);
        Assert.DoesNotContain("Endpoint =", ctorBody);
    }

    [Fact]
    public void StringParametersEmitStringProperty()
    {
        Assert.Contains("public string Region { get; set; }", _output);
        Assert.Contains("\"Region\" => Region,", _output);
        Assert.Contains("case \"Region\": Region = (string)value; break;", _output);
    }

    [Fact]
    public void BooleanParametersEmitNullableBoolProperty()
    {
        Assert.Contains("public bool? UseFIPS { get; set; }", _output);
        Assert.Contains("\"UseFIPS\" => UseFIPS,", _output);
        Assert.Contains("case \"UseFIPS\": UseFIPS = (bool?)value; break;", _output);
    }

    [Fact]
    public void PropertyDocsComeFromModelDocumentation()
    {
        Assert.Contains("/// The AWS region used to dispatch the request.", _output);
    }

    [Fact]
    public void ParameterValuesEqualComparesEveryTypedPropertyThenBase()
    {
        // Core's endpoint cache compares parameters through this override; without it, typed
        // properties are invisible to the comparison and a stale endpoint can be reused.
        Assert.Contains("protected override bool ParameterValuesEqual(EndpointParameters other)", _output);
        Assert.Contains("var o = (CloudTrailDataEndpointParameters)other;", _output);
        Assert.Contains("Region == o.Region", _output);
        Assert.Contains("UseFIPS == o.UseFIPS", _output);
        Assert.Contains("UseDualStack == o.UseDualStack", _output);
        Assert.Contains("Endpoint == o.Endpoint", _output);
        Assert.Contains("&& base.ParameterValuesEqual(other);", _output);
    }
}
