using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

[Collection(nameof(CloudTrailModelCollection))]
public class EndpointProviderWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public EndpointProviderWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new EndpointProviderWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void GuardsNullParametersAndRequiredParameters()
    {
        Assert.Contains("if (parameters == null)", _output);
        Assert.Contains("throw new ArgumentNullException(\"parameters\");", _output);

        // Required parameters (UseDualStack, UseFIPS) are guarded; optional ones are not.
        Assert.Contains("if (parameters[\"UseDualStack\"] == null)", _output);
        Assert.Contains("if (parameters[\"UseFIPS\"] == null)", _output);
        Assert.DoesNotContain("if (parameters[\"Region\"] == null)", _output);
    }

    [Fact]
    public void SeedsRefsWithEveryParameter()
    {
        Assert.Contains("var refs = new Dictionary<string, object>()", _output);
        Assert.Contains("[\"Region\"] = parameters[\"Region\"],", _output);
        Assert.Contains("[\"Endpoint\"] = parameters[\"Endpoint\"],", _output);
    }

    [Fact]
    public void CompilesIsSetAndBooleanEqualsConditions()
    {
        Assert.Contains("if (IsSet(refs[\"Endpoint\"]))", _output);
        Assert.Contains("if (Equals(refs[\"UseFIPS\"], true))", _output);
    }

    [Fact]
    public void CompilesAssigningPartitionCondition()
    {
        // aws.partition assigns into refs and is truthy when non-null; its argument is cast to string.
        Assert.Contains("if ((refs[\"PartitionResult\"] = Partition((string)refs[\"Region\"])) != null)", _output);
    }

    [Fact]
    public void CompilesGetAttrPreservingArgumentOrder()
    {
        // The rule set has both argument orders for booleanEquals(getAttr(...)); both must be preserved.
        Assert.Contains("Equals(true, GetAttr(refs[\"PartitionResult\"], \"supportsFIPS\"))", _output);
        Assert.Contains("Equals(GetAttr(refs[\"PartitionResult\"], \"supportsFIPS\"), true)", _output);
    }

    [Fact]
    public void CompilesEndpointUrlsAsInterpolatedTemplates()
    {
        // These interpolation templates determine the URLs the endpoint-provider test asserts.
        Assert.Contains("return new Endpoint(Interpolate(@\"https://cloudtrail-data-fips.{Region}.{PartitionResult#dualStackDnsSuffix}\", refs), InterpolateJson(@\"\", refs), InterpolateJson(@\"\", refs));", _output);
        Assert.Contains("return new Endpoint(Interpolate(@\"https://cloudtrail-data-fips.{Region}.{PartitionResult#dnsSuffix}\", refs), InterpolateJson(@\"\", refs), InterpolateJson(@\"\", refs));", _output);
        Assert.Contains("return new Endpoint(Interpolate(@\"https://cloudtrail-data.{Region}.{PartitionResult#dnsSuffix}\", refs), InterpolateJson(@\"\", refs), InterpolateJson(@\"\", refs));", _output);
    }

    [Fact]
    public void CompilesRefUrlAsStringCast()
    {
        // The custom-endpoint branch returns the Endpoint ref directly, cast to string (not interpolated).
        Assert.Contains("return new Endpoint((string)refs[\"Endpoint\"], InterpolateJson(@\"\", refs), InterpolateJson(@\"\", refs));", _output);
    }

    [Fact]
    public void CompilesErrorRulesAsThrows()
    {
        Assert.Contains("throw new AmazonClientException(\"Invalid Configuration: FIPS and custom endpoint are not supported\");", _output);
        Assert.Contains("throw new AmazonClientException(\"Invalid Configuration: Missing Region\");", _output);
    }

    [Fact]
    public void OmitsDeadTrailingThrow()
    {
        // The C2J template emits an unreachable trailing throw after the last rule; we drop it (the
        // final rule is itself an error rule, so the method never falls through).
        Assert.DoesNotContain("Cannot resolve endpoint", _output);
    }
}
