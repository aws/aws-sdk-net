using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceGeneratorTests : IDisposable
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string ServiceFileVersion = "4.0.2.8";

    private readonly string _outputDir;
    private readonly IReadOnlyList<string> _written;

    public ServiceGeneratorTests(CloudTrailModelFixture fixture)
    {
        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        var generator = new ServiceGenerator(fixture.Context, ModelFileName, ServiceFileVersion);
        _written = generator.Generate(_outputDir, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        if (Directory.Exists(_outputDir))
        {
            Directory.Delete(_outputDir, recursive: true);
        }
    }

    [Fact]
    public void WritesClientLevelFiles()
    {
        AssertFileExists("Generated", "IAmazonCloudTrailData.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataClient.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataConfig.g.cs");
        AssertFileExists("Generated", "AmazonCloudTrailDataException.g.cs");
    }

    [Fact]
    public void WritesMetadataUnderInternal()
    {
        AssertFileExists("Generated", "Internal", "AmazonCloudTrailDataMetadata.g.cs");
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

    private void AssertFileExists(params string[] segments)
    {
        var relativePath = Path.Combine(segments);
        Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file: {relativePath}");
        Assert.Contains(relativePath, _written);
    }
}
