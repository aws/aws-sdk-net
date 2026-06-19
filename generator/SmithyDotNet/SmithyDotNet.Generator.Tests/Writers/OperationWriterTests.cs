using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class OperationWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _serviceRequest;
    private readonly string _request;
    private readonly string _response;

    public OperationWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new OperationWriter(fixture.Context, ModelFileName);
        var operation = fixture.Context.Operations.Single(o => o.Name == "PutAuditEvents");
        _serviceRequest = writer.WriteServiceRequest(TestContext.Current.CancellationToken);
        _request = writer.WriteRequest(operation, TestContext.Current.CancellationToken);
        _response = writer.WriteResponse(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ServiceRequest_EmitsBaseClassInServiceNamespace()
    {
        Assert.Contains("namespace Amazon.CloudTrailData", _serviceRequest);
        Assert.DoesNotContain("namespace Amazon.CloudTrailData.Model", _serviceRequest);
        Assert.Contains("public partial class AmazonCloudTrailDataRequest : AmazonWebServiceRequest", _serviceRequest);
    }

    [Fact]
    public void Request_EmitsClassWithCorrectBaseType()
    {
        Assert.Contains("public partial class PutAuditEventsRequest : AmazonCloudTrailDataRequest", _request);
    }

    [Fact]
    public void Request_EmitsClassDocumentation()
    {
        Assert.Contains("Container for the parameters to the PutAuditEvents operation.", _request);
    }

    [Fact]
    public void Request_EmitsCollectionPropertyWithInitializer()
    {
        Assert.Contains("public List<AuditEvent> AuditEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEvent>() : null;", _request);
    }

    [Fact]
    public void Request_EmitsCollectionDocParagraph()
    {
        Assert.Contains("Starting with version 4 of the SDK this property will default to null.", _request);
    }

    [Fact]
    public void Request_EmitsAwsPropertyOnCollection()
    {
        // AuditEvents: @required, @length min 1 max 100
        Assert.Contains("[AWSProperty(Required = true, Min = 1, Max = 100)]", _request);
    }

    [Fact]
    public void Response_EmitsClassWithCorrectBaseType()
    {
        Assert.Contains("public partial class PutAuditEventsResponse : AmazonWebServiceResponse", _response);
    }

    [Fact]
    public void Response_EmitsClassDocumentation()
    {
        Assert.Contains("This is the response object from the PutAuditEvents operation.", _response);
    }

    [Fact]
    public void Response_EmitsCollectionProperties()
    {
        Assert.Contains("public List<ResultErrorEntry> Failed { get; set; } = AWSConfigs.InitializeCollections ? new List<ResultErrorEntry>() : null;", _response);
        Assert.Contains("public List<AuditEventResultEntry> Successful { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEventResultEntry>() : null;", _response);
    }

    [Fact]
    public void Response_EmitsAwsPropertyOnCollections()
    {
        // Both: @required, @length min 0 max 100
        Assert.Equal(2, Regex.Count(_response, @"\[AWSProperty\(Required = true, Min = 0, Max = 100\)\]"));
    }

    [Fact]
    public void Request_EmitsIsSetOnCollectionWithInitializeCollectionsRule()
    {
        Assert.Contains("internal bool IsSetAuditEvents() => this.AuditEvents != null && (this.AuditEvents.Count > 0 || !AWSConfigs.InitializeCollections);", _request);
    }

    [Fact]
    public void Response_EmitsIsSetOnCollections()
    {
        Assert.Contains("internal bool IsSetFailed() => this.Failed != null && (this.Failed.Count > 0 || !AWSConfigs.InitializeCollections);", _response);
        Assert.Contains("internal bool IsSetSuccessful() => this.Successful != null && (this.Successful.Count > 0 || !AWSConfigs.InitializeCollections);", _response);
    }
}
