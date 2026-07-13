using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class JsonResponseUnmarshallerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly string _putAuditResponseUnmarshaller;
    public JsonResponseUnmarshallerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new JsonResponseUnmarshallerWriter(fixture.Context, ModelFileName);
        var operation = fixture.Context.Operations.Single(o => o.Name == "PutAuditEvents");
        _putAuditResponseUnmarshaller = writer.Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ResponseUnmarshallerContainsProperClassSignatureAndNamespace()
    {
        AssertHelper("public partial class PutAuditEventsResponseUnmarshaller : JsonResponseUnmarshaller");
        AssertHelper("namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations");
    }

    [Fact]
    public void ResponseUnmarshallerContainsPragma()
    {
        AssertHelper("#pragma warning disable CS0612,CS0618");
    }

    [Fact]
    public void ResponseUnmarshalerClassContainsSummary()
    {
        AssertHelper("/// <summary>");
        AssertHelper("/// Response Unmarshaller for PutAuditEvents operation.");
        AssertHelper("/// </summary>");
    }

    [Fact]
    public void UnmarshallMethodContainsProperPrelude()
    {
        AssertHelper("PutAuditEventsResponse response = new PutAuditEventsResponse();");
        AssertHelper("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
        AssertHelper("context.Read(ref reader);");
        AssertHelper("int targetDepth = context.CurrentDepth;");
    }

    [Fact]
    public void UnmarshallMethodContainsCorrectWhileLoopLogic()
    {
        AssertHelper("while (context.ReadAtDepth(targetDepth, ref reader))");
        AssertHelper("if (context.TestExpression(\"failed\", targetDepth, ref reader))");
        AssertHelper("var unmarshaller = new JsonListUnmarshaller<ResultErrorEntry, ResultErrorEntryUnmarshaller>(ResultErrorEntryUnmarshaller.Instance);");
        AssertHelper("response.Failed = unmarshaller.Unmarshall(context, ref reader);");
        AssertHelper("continue;");
        AssertHelper("if (context.TestExpression(\"successful\", targetDepth, ref reader))");
        AssertHelper("var unmarshaller = new JsonListUnmarshaller<AuditEventResultEntry, AuditEventResultEntryUnmarshaller>(AuditEventResultEntryUnmarshaller.Instance);");
        AssertHelper("response.Successful = unmarshaller.Unmarshall(context, ref reader);");
        AssertHelper("continue;");
        AssertHelper("return response;");
    }

    [Fact]
    public void UnmarshallExceptionSignatureIsCorrect()
    {
        AssertHelper("/// <summary>");
        AssertHelper("/// Unmarshall error response to exception.");
        AssertHelper("/// </summary>");
        AssertHelper("public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)");
    }

    [Fact]
    public void UnmarshallExceptionMethodContainsCorrectPrelude()
    {
        AssertHelper("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
        AssertHelper("var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);");
        AssertHelper("errorResponse.InnerException = innerException;");
        AssertHelper("errorResponse.StatusCode = statusCode;");
        AssertHelper("var responseBodyBytes = context.GetResponseBodyBytes();");
    }

    [Fact]
    public void UnmarshallExceptionMethodBodyIsCorrect()
    {
        AssertHelper("using (var streamCopy = new MemoryStream(responseBodyBytes))");
        AssertHelper("using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))");
        AssertHelper("StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"ChannelInsufficientPermission\"))");
        AssertHelper("return ChannelInsufficientPermissionExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"ChannelNotFound\"))");
        AssertHelper("return ChannelNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"ChannelUnsupportedSchema\"))");
        AssertHelper("return ChannelUnsupportedSchemaExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"DuplicatedAuditEventId\"))");
        AssertHelper("return DuplicatedAuditEventIdExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"InvalidChannelARN\"))");
        AssertHelper("return InvalidChannelARNExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("if (errorResponse.Code != null && errorResponse.Code.Equals(\"UnsupportedOperationException\"))");
        AssertHelper("return UnsupportedOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
        AssertHelper("return new AmazonCloudTrailDataException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
    }

    [Fact]
    public void ResponseUnmarshallerContainsSingleton()
    {
        AssertHelper("private static PutAuditEventsResponseUnmarshaller _instance = new PutAuditEventsResponseUnmarshaller();");
        AssertHelper("internal static PutAuditEventsResponseUnmarshaller GetInstance() => _instance;");
        AssertHelper("public static PutAuditEventsResponseUnmarshaller Instance => _instance;");
    }

    private void AssertHelper(string expectedCode)
    {
        Assert.Contains(expectedCode, _putAuditResponseUnmarshaller);
    }
}
