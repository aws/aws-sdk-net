using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class JsonRequestMarshallerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _putAuditEventsRequestMarshaller;

    public JsonRequestMarshallerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new JsonRequestMarshallerWriter(fixture.Context, ModelFileName);
        var operation = fixture.Context.Operations.Single(o => o.Name == "PutAuditEvents");
        _putAuditEventsRequestMarshaller = writer.Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsExpectedNamespaceAndUsings()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations", _putAuditEventsRequestMarshaller);
        Assert.Contains("using Amazon.CloudTrailData.Model;", _putAuditEventsRequestMarshaller);
        Assert.Contains("using Amazon.Runtime.Internal.Transform;", _putAuditEventsRequestMarshaller);
        Assert.Contains("using System.Text.Json;", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsExpectedClassSignature()
    {
        Assert.Contains("public partial class PutAuditEventsRequestMarshaller : IMarshaller<IRequest, PutAuditEventsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsBaseMarshallMethod()
    {
        Assert.Contains("public IRequest Marshall(AmazonWebServiceRequest input)", _putAuditEventsRequestMarshaller);
        Assert.Contains("return this.Marshall((PutAuditEventsRequest)input);", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsTypedMarshallMethod()
    {
        Assert.Contains("public IRequest Marshall(PutAuditEventsRequest publicRequest)", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsRequestSetup()
    {
        Assert.Contains("IRequest request = new DefaultRequest(publicRequest, \"Amazon.CloudTrailData\");", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.Headers[\"Content-Type\"] = \"application/json\";", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = \"2021-08-11\";", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.HttpMethod = \"POST\";", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.ResourcePath = \"/PutAuditEvents\";", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsQueryStringParameters()
    {
        Assert.Contains("request.Parameters.Add(\"channelArn\", StringUtils.FromString(publicRequest.ChannelArn));", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.Parameters.Add(\"externalId\", StringUtils.FromString(publicRequest.ExternalId));", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.UseQueryString = true;", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsBodySerialization()
    {
        Assert.Contains("writer.WriteStartObject();", _putAuditEventsRequestMarshaller);
        Assert.Contains("var context = new JsonMarshallerContext(request, writer);", _putAuditEventsRequestMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(\"auditEvents\");", _putAuditEventsRequestMarshaller);
        Assert.Contains("context.Writer.WriteStartArray();", _putAuditEventsRequestMarshaller);
        Assert.Contains("var marshaller = AuditEventMarshaller.Instance;", _putAuditEventsRequestMarshaller);
        Assert.Contains("context.Writer.WriteEndArray();", _putAuditEventsRequestMarshaller);
        Assert.Contains("writer.WriteEndObject();", _putAuditEventsRequestMarshaller);
        Assert.Contains("writer.Flush();", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsPooledContentStream()
    {
        Assert.Contains("request.ContentStream = new PooledContentStream();", _putAuditEventsRequestMarshaller);
        Assert.Contains("using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsNetFrameworkFallback()
    {
        Assert.Contains("using var memoryStream = new MemoryStream();", _putAuditEventsRequestMarshaller);
        Assert.Contains("request.Content = memoryStream.ToArray();", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsSingleton()
    {
        Assert.Contains("private static readonly PutAuditEventsRequestMarshaller _instance = new();", _putAuditEventsRequestMarshaller);
        Assert.Contains("public static PutAuditEventsRequestMarshaller Instance => _instance;", _putAuditEventsRequestMarshaller);
        Assert.Contains("internal static PutAuditEventsRequestMarshaller GetInstance() => _instance;", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsDocumentation()
    {
        Assert.Contains("/// PutAuditEvents Request Marshaller", _putAuditEventsRequestMarshaller);
        Assert.Contains("/// Marshall the request object to the HTTP request.", _putAuditEventsRequestMarshaller);
        Assert.Contains("/// Gets the singleton.", _putAuditEventsRequestMarshaller);
    }

    [Fact]
    public void EmitsIsRequiredCheck()
    {
        Assert.Contains("if (string.IsNullOrEmpty(publicRequest.ChannelArn))", _putAuditEventsRequestMarshaller);
        Assert.Contains(" throw new AmazonCloudTrailDataException(\"Request object does not have required field ChannelArn set\");", _putAuditEventsRequestMarshaller);
    }
}
