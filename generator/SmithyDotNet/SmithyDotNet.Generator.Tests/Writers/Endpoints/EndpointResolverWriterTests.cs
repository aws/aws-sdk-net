using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

[Collection(nameof(CloudTrailModelCollection))]
public class EndpointResolverWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public EndpointResolverWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new EndpointResolverWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsInternalNamespaceAndResolverClass()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Internal", _output);
        Assert.Contains("public class AmazonCloudTrailDataEndpointResolver : BaseEndpointResolver", _output);
    }

    [Fact]
    public void SuppressesXmlDocPragma()
    {
        Assert.Contains("#pragma warning disable 1591", _output);
    }

    [Fact]
    public void ServiceSpecificHandlerInjectsHostPrefix()
    {
        Assert.Contains("protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)", _output);
        Assert.Contains("InjectHostPrefix(executionContext.RequestContext);", _output);
    }

    [Fact]
    public void MapsBuiltInParametersFromConfig()
    {
        Assert.Contains("var config = (AmazonCloudTrailDataConfig)requestContext.ClientConfig;", _output);
        Assert.Contains("var result = new CloudTrailDataEndpointParameters();", _output);
        Assert.Contains("result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;", _output);
        Assert.Contains("result.UseDualStack = config.UseDualstackEndpoint;", _output);
        Assert.Contains("result.UseFIPS = config.UseFIPSEndpoint;", _output);
        Assert.Contains("result.Endpoint = config.ServiceURL;", _output);
    }

    [Theory]
    [InlineData("ForcePathStyle", "config.ForcePathStyle")]
    [InlineData("Accelerate", "config.UseAccelerateEndpoint")]
    [InlineData("UseArnRegion", "config.UseArnRegion")]
    [InlineData("UseControlArnRegion", "config.UseArnRegion")]
    [InlineData("DisableMultiRegionAccessPoints", "config.DisableMultiregionAccessPoints")]
    [InlineData("UseS3GlobalEndpoint", "config.USEast1RegionalEndpointValue == S3UsEast1RegionalEndpointValue.Legacy")]
    [InlineData("UseGlobalEndpoint", "false")]
    [InlineData("AccountId", "requestContext.Identity is AWSCredentials credentials ? credentials.GetCredentials()?.AccountId : null")]
    [InlineData("AccountIdEndpointMode", "config.AccountIdEndpointMode.ToString().ToLower()")]
    public void MapsServiceSpecificBuiltInParameters(string parameter, string source)
    {
        var output = new EndpointResolverWriter(TestModels.Context("Codegen/endpoint-context-params-model.json"), "smithy.json").Write(CancellationToken.None);

        Assert.Contains($"result.{parameter} = {source};", output);
    }

    [Fact]
    public void EmitsRegionFromServiceUrlBlock()
    {
        // Present because the rule set has a Region parameter.
        Assert.Contains("var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);", _output);
        Assert.Contains("""if (result.Region == "us-east-1-regional")""", _output);
        Assert.Contains("if (requestContext.Request.AlternateEndpoint != null)", _output);
    }

    // The context-params fixture has a Region parameter and per-operation blocks, so every hook position exists.
    private static readonly string PartialOutput = new EndpointResolverWriter(
        TestModels.Context(TestModels.Load("Codegen/endpoint-context-params-model.json"), new CustomizationsModel { Service = new ServiceCustomizations { EndpointResolverPartial = true } }),
        "smithy.json").Write(CancellationToken.None);

    [Fact]
    public void EndpointResolverPartial_EmitsPartialClassAndHookDeclarations()
    {
        Assert.Contains("public partial class AmazonExampleEndpointResolver : BaseEndpointResolver", PartialOutput);
        Assert.Contains("private partial void BeforeInjectHostPrefix(IExecutionContext executionContext, EndpointParameters parameters);", PartialOutput);
        // The concrete parameters type lets the hand-written half set Bucket and the other S3 parameters.
        Assert.Contains("private partial bool TryMapNonGeneratedRequest(IRequestContext requestContext, ExampleEndpointParameters result);", PartialOutput);
    }

    [Fact]
    public void EndpointResolverPartial_CallsBeforeInjectHostPrefixFirst()
    {
        var hook = PartialOutput.IndexOf("BeforeInjectHostPrefix(executionContext, parameters);");
        Assert.True(hook >= 0 && hook < PartialOutput.IndexOf("InjectHostPrefix(executionContext.RequestContext);"));
    }

    // A mapped request returns early, so the hook must follow the region overrides and precede the
    // per-operation blocks, which also return early.
    [Fact]
    public void EndpointResolverPartial_MapHookReturnsBetweenRegionAndPerOperationBlocks()
    {
        var hook = PartialOutput.IndexOf("if (TryMapNonGeneratedRequest(requestContext, result))");
        Assert.True(hook > PartialOutput.IndexOf("if (requestContext.Request.AlternateEndpoint != null)"));
        Assert.True(PartialOutput.IndexOf("return result;", hook) < PartialOutput.IndexOf("}", hook));
        Assert.True(hook < PartialOutput.IndexOf("// Assign staticContextParams and contextParam per operation"));
    }

    [Fact]
    public void WithoutEndpointResolverPartial_EmitsNoHooks()
    {
        Assert.DoesNotContain("partial", _output);
        Assert.DoesNotContain("TryMapNonGeneratedRequest", _output);
    }
}
