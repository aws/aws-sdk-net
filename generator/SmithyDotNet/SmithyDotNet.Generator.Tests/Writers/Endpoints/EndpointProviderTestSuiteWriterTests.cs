using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

[Collection(nameof(CloudTrailModelCollection))]
public class EndpointProviderTestSuiteWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public EndpointProviderTestSuiteWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new EndpointProviderTestSuiteWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsNamespaceAndClassMatchingThePinnedFile()
    {
        // The class is *Endpoints*Tests (no "Provider") despite the file being
        // *EndpointProvider*Tests.g.cs, and the namespace is fixed, not service-scoped.
        Assert.Contains("namespace AWSSDK_DotNet.UnitTests.Endpoints", _output);
        Assert.Contains("[TestClass]", _output);
        Assert.Contains("public partial class CloudTrailDataEndpointsTests", _output);
    }

    [Fact]
    public void EmitsTestCategoriesOnceAtClassLevel()
    {
        // Every test case shares the same categories, so they're hoisted to the class instead of
        // repeated per [TestMethod].
        Assert.Contains("[TestCategory(\"UnitTest\")]", _output);
        Assert.Contains("[TestCategory(\"Endpoints\")]", _output);
        Assert.Contains("[TestCategory(\"CloudTrailData\")]", _output);
        Assert.Equal(1, Regex.Count(_output, Regex.Escape("[TestCategory(\"UnitTest\")]")));
    }

    [Fact]
    public void EmitsUsingsForParametersAndProviderNamespaces()
    {
        Assert.Contains("using Microsoft.VisualStudio.TestTools.UnitTesting;", _output);
        Assert.Contains("using Amazon.Runtime;", _output);
        Assert.Contains("using Amazon.CloudTrailData.Endpoints;", _output);
        Assert.Contains("using Amazon.CloudTrailData.Internal;", _output);
    }

    [Fact]
    public void EmitsOneTestMethodPerTestCase()
    {
        Assert.Equal(21, Regex.Count(_output, Regex.Escape("[TestMethod]")));
    }

    [Fact]
    public void EmitsDescriptionPerTestMethod()
    {
        Assert.Contains("[Description(\"For region us-east-1 with FIPS enabled and DualStack enabled\")]", _output);
    }

    [Fact]
    public void EmitsSuccessCaseConstructingParametersAndAssertingUrl()
    {
        Assert.Contains("public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()", _output);
        Assert.Contains("var parameters = new CloudTrailDataEndpointParameters();", _output);
        Assert.Contains("parameters[\"Region\"] = \"us-east-1\";", _output);
        Assert.Contains("parameters[\"UseFIPS\"] = true;", _output);
        Assert.Contains("var endpoint = new AmazonCloudTrailDataEndpointProvider().ResolveEndpoint(parameters);", _output);
        Assert.Contains("Assert.AreEqual(\"https://cloudtrail-data-fips.us-east-1.api.aws\", endpoint.URL);", _output);
    }

    [Fact]
    public void EmitsErrorCaseAssertingThrownExceptionMessage()
    {
        Assert.Contains("public void Missing_region_Test()", _output);
        Assert.Contains("var exception = Assert.ThrowsExactly<AmazonClientException>(() =>", _output);
        Assert.Contains("new AmazonCloudTrailDataEndpointProvider().ResolveEndpoint(parameters);", _output);
        Assert.Contains("Assert.AreEqual(@\"Invalid Configuration: Missing Region\", exception.Message);", _output);
    }

    [Fact]
    public void OmitsPropertyAndHeaderAssertions()
    {
        // No pinned {Service}EndpointProviderTests file anywhere in the SDK asserts resolved
        // endpoint properties or headers; only endpoint.URL is ever checked.
        Assert.DoesNotContain("endpoint.Properties", _output);
        Assert.DoesNotContain("endpoint.Headers", _output);
    }
}
