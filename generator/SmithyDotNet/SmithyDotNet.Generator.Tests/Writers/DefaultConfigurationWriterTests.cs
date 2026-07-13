using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class DefaultConfigurationWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public DefaultConfigurationWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new DefaultConfigurationWriter(fixture.Context, ModelFileName, fixture.DefaultConfigurationModes);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsLicenseAndGenerationNotice()
    {
        Assert.Contains("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.", _output);
        Assert.Contains($"This file is generated from the {ModelFileName} service model.", _output);
    }

    [Fact]
    public void EmitsStaticClassInServiceNamespace()
    {
        Assert.Contains("namespace Amazon.CloudTrailData", _output);
        Assert.Contains("public static class AmazonCloudTrailDataDefaultConfiguration", _output);
    }

    [Fact]
    public void GetAllConfigurations_ListsEveryMode()
    {
        Assert.Contains("public static ReadOnlyCollection<IDefaultConfiguration> GetAllConfigurations()", _output);
        Assert.Contains("Standard,", _output);
        Assert.Contains("InRegion,", _output);
        Assert.Contains("CrossRegion,", _output);
        Assert.Contains("Mobile,", _output);
        Assert.Contains("Auto", _output);
    }

    [Fact]
    public void EmitsModeProperty_WithResolvedOptionValues()
    {
        Assert.Contains("public static IDefaultConfiguration Standard { get; } = new DefaultConfiguration", _output);
        Assert.Contains("Name = DefaultConfigurationMode.Standard,", _output);
        Assert.Contains("RetryMode = RequestRetryMode.Standard,", _output);
        Assert.Contains("S3UsEast1RegionalEndpoint = S3UsEast1RegionalEndpointValue.Regional,", _output);
        Assert.Contains("ConnectTimeout = TimeSpan.FromMilliseconds(3100),", _output);
    }

    [Fact]
    public void OptionsWithoutAValueAreAssignedNull()
    {
        Assert.Contains("TimeToFirstByteTimeout = null,", _output);
        Assert.Contains("HttpRequestTimeout = null", _output);
    }

    [Fact]
    public void ModeDocumentation_UsesParaBlocksNotRawHtml()
    {
        // The mode documentation is HTML (<p> blocks); it goes through the shared doc cleanup so
        // the XML doc uses <para> like every other generated doc comment, instead of the raw <p>
        // tags the C2J output carries.
        Assert.Contains("/// The STANDARD mode provides the latest recommended default values", _output);
        Assert.Contains("/// <para>", _output);
        Assert.DoesNotContain("<p>", _output);
        // Back-to-back source paragraphs produce a single blank comment line, not two.
        Assert.DoesNotContain("/// \n        /// \n", _output.Replace("\r\n", "\n"));
    }

}
