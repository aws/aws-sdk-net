using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class MetadataWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public MetadataWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new MetadataWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsLicenseAndGenerationNotice()
    {
        Assert.Contains("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.", _output);
        Assert.Contains($"This file is generated from the {ModelFileName} service model.", _output);
    }

    [Fact]
    public void EmitsInternalNamespace()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Internal", _output);
    }

    [Fact]
    public void EmitsPartialClassImplementingIServiceMetadata()
    {
        Assert.Contains("public partial class AmazonCloudTrailDataMetadata : IServiceMetadata", _output);
    }

    [Fact]
    public void ClassSummary_UsesSingleSpace()
    {
        // The shipping C2J output has a double space after "for" (a quirk of the legacy
        // ServiceMetadata.tt template). That spacing is a doc defect, not API, so the writer
        // emits a single space and does not reproduce the double-space artifact.
        Assert.Contains("/// Service metadata for Amazon CloudTrailData service", _output);
        Assert.DoesNotContain("/// Service metadata for  Amazon CloudTrailData service", _output);
    }

    [Fact]
    public void ServiceId_ReturnsRawSdkId_NotNormalizedServiceName()
    {
        // The metadata ServiceId is the verbatim sdkId ("CloudTrail Data"), NOT the normalized
        // class-name component ("CloudTrailData"). Emitted as an expression-bodied member with the
        // value escaped through Roslyn.
        Assert.Contains("public string ServiceId => \"CloudTrail Data\";", _output);
        Assert.DoesNotContain("\"CloudTrailData\"", _output);
    }

    [Fact]
    public void EmitsEmptyOperationNameMapping()
    {
        // Phase 1 has no rename map, so the mapping is empty. Emitted as an expression-bodied member
        // using the short type name (System.Collections.Generic is in the file's usings).
        Assert.Contains("public IDictionary<string, string> OperationNameMapping => new Dictionary<string, string>(0);", _output);
    }
}
