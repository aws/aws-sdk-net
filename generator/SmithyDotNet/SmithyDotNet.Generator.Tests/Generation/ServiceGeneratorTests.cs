using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceGeneratorTests : IDisposable
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string ServiceFileVersion = "4.0.2.8";

    private readonly CloudTrailModelFixture _fixture;
    private readonly string _outputDir;
    private readonly string _testsOutputDir;
    private readonly IReadOnlyList<string> _written;

    public ServiceGeneratorTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _testsOutputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(fixture.Context, ModelFileName, ServiceFileVersion, fixture.DefaultConfigurationModes);
        _written = generator.Generate(_outputDir, _testsOutputDir, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        if (Directory.Exists(_outputDir))
        {
            Directory.Delete(_outputDir, recursive: true);
        }

        if (Directory.Exists(_testsOutputDir))
        {
            Directory.Delete(_testsOutputDir, recursive: true);
        }
    }

    [Fact]
    public void WritesAssemblyInfo()
    {
        AssertFileExists("Properties", "AssemblyInfo.cs");
    }

    [Fact]
    public void WritesClientLevelFiles()
    {
        AssertFileExists("Generated", "IAmazonCloudTrailData.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataClient.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataConfig.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataDefaultConfiguration.g.cs");
        AssertFileExists("Generated", "ServiceEnumerations.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataException.g.cs");
    }

    [Fact]
    public void WritesMetadataUnderInternal()
    {
        AssertFileExists("Generated", "Internal", "AmazonCloudTrailDataMetadata.g.cs");
    }

    [Fact]
    public void WritesAuthResolverUnderInternal()
    {
        AssertFileExists("Generated", "Internal", "AmazonCloudTrailDataAuthResolver.g.cs");
    }

    [Fact]
    public void WritesOperationModelFiles()
    {
        AssertFileExists("Generated", "Model", "AmazonCloudTrailDataRequest.g.cs");
        AssertFileExists("Generated", "Model", "PutAuditEventsRequest.g.cs");
        AssertFileExists("Generated", "Model", "PutAuditEventsResponse.g.cs");
    }

    [Fact]
    public void WritesStructureFiles()
    {
        AssertFileExists("Generated", "Model", "AuditEvent.g.cs");
        AssertFileExists("Generated", "Model", "AuditEventResultEntry.g.cs");
        AssertFileExists("Generated", "Model", "ResultErrorEntry.g.cs");
    }

    [Fact]
    public void WritesExceptionFiles()
    {
        AssertFileExists("Generated", "Model", "ChannelNotFoundException.g.cs");
        AssertFileExists("Generated", "Model", "UnsupportedOperationException.g.cs");
    }

    [Fact]
    public void WritesMarshallerFilesSplitByDirection()
    {
        // Input-reachable structures get a marshaller, output-reachable ones an unmarshaller,
        // matching the existing SDK. The operation request marshaller is always emitted.
        var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
        AssertFileExists(marshalling, "PutAuditEventsRequestMarshaller.g.cs");
        AssertFileExists(marshalling, "AuditEventMarshaller.g.cs");
        AssertFileExists(marshalling, "AuditEventResultEntryUnmarshaller.g.cs");
        AssertFileExists(marshalling, "ResultErrorEntryUnmarshaller.g.cs");
    }

    [Fact]
    public void WritesResponseUnmarshallerFiles()
    {
        var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
        AssertFileExists(marshalling, "PutAuditEventsResponseUnmarshaller.g.cs");
    }

    [Fact]
    public void WritesExceptionUnmarshallerFiles()
    {
        var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
        AssertFileExists(marshalling, "ChannelNotFoundExceptionUnmarshaller.g.cs");
        AssertFileExists(marshalling, "UnsupportedOperationExceptionUnmarshaller.g.cs");
    }

    [Fact]
    public void WritesEndpointFiles()
    {
        // CloudTrailData carries an endpoint rule set, so all three endpoint files are emitted:
        // the parameters class under Generated/, the provider and resolver under Generated/Internal/.
        AssertFileExists("Generated", "AmazonCloudTrailDataEndpointParameters.g.cs");
        AssertFileExists("Generated", "Internal", "AmazonCloudTrailDataEndpointProvider.g.cs");
        AssertFileExists("Generated", "Internal", "AmazonCloudTrailDataEndpointResolver.g.cs");
    }

    [Fact]
    public void WrittenPathsMatchFilesOnDisk()
    {
        foreach (var relativePath in _written)
        {
            Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file on disk: {relativePath}");
        }
    }

    [Fact]
    public void GeneratedClientContainsExpectedDeclaration()
    {
        var clientSource = File.ReadAllText(Path.Combine(_outputDir, "Generated", "AmazonCloudTrailDataClient.g.cs"));
        Assert.Contains("public partial class AmazonCloudTrailDataClient", clientSource);
    }

    [Fact]
    public void OperationInputShapeIsRequestClassNotPlainStructure()
    {
        // The model omits @input/@output traits, so PutAuditEventsRequest also appears in
        // context.Structures. It must be emitted as the request class (extending the request base),
        // not overwritten by a plain structure.
        var requestSource = File.ReadAllText(Path.Combine(_outputDir, "Generated", "Model", "PutAuditEventsRequest.g.cs"));
        Assert.Contains("public partial class PutAuditEventsRequest : AmazonCloudTrailDataRequest", requestSource);
    }

    [Fact]
    public void WritesEndpointProviderTestsUnderTestsOutputPath()
    {
        var path = Path.Combine(_testsOutputDir, "UnitTests", "Generated", "Endpoints", "CloudTrailDataEndpointProviderTests.g.cs");
        Assert.True(File.Exists(path));
    }

    [Fact]
    public void EndpointProviderTestsPathIsNotInWrittenList()
    {
        // It lives under a different root (testsOutputDir) than everything else (outputDir), so it
        // isn't tracked in the returned relative-path list, which is outputDir-relative.
        Assert.DoesNotContain(_written, path => path.Contains("EndpointProviderTests"));
    }

    private void AssertFileExists(params string[] segments)
    {
        var relativePath = Path.Combine(segments);
        Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file: {relativePath}");
        Assert.Contains(relativePath, _written);
    }
}
