using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// awsJson1.x framing: POST / routed by X-Amz-Target, versioned Content-Type, bindings and @jsonName ignored, {} body when there are no input members.
public class AwsJsonCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Json11 = TestModels.Context("Codegen/awsjson11-model.json");
    private static readonly GenerationContext Json10 = TestModels.Context("Codegen/awsjson10-model.json");

    private static string RequestMarshaller(GenerationContext context, string operationName) =>
        new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    [Fact]
    public void Request_RoutesByTargetHeaderToRootPath()
    {
        var source = RequestMarshaller(Json11, "DoScalars");

        Assert.Equal(AWSProtocol.AwsJson1_1, Json11.Protocol);
        Assert.Contains("""string target = "Example_20230101.DoScalars";""", source);
        Assert.Contains("""request.Headers["X-Amz-Target"] = target;""", source);
        Assert.Contains("""request.Headers["Content-Type"] = "application/x-amz-json-1.1";""", source);
        Assert.Contains("""request.HttpMethod = "POST";""", source);
        Assert.Contains("""request.ResourcePath = "/";""", source);
    }

    [Fact]
    public void Request_IgnoresHttpBindingsAndJsonName()
    {
        var source = RequestMarshaller(Json11, "DoScalars");

        Assert.Contains("""context.Writer.WritePropertyName("name");""", source);
        Assert.Contains("""context.Writer.WritePropertyName("count");""", source);
        Assert.Contains("""context.Writer.WritePropertyName("limit");""", source);
        Assert.DoesNotContain("\"Name\"", source);
        Assert.DoesNotContain("AddPathResource", source);
        Assert.DoesNotContain("UseQueryString", source);
    }

    [Fact]
    public void Request_WithoutInputMembers_SendsEmptyJsonObject()
    {
        var source = RequestMarshaller(Json11, "DoNothing");

        Assert.Contains("""request.Headers["Content-Type"] = "application/x-amz-json-1.1";""", source);
        Assert.Contains("""var content = "{}";""", source);
        Assert.Contains("request.Content = System.Text.Encoding.UTF8.GetBytes(content);", source);
    }

    [Fact]
    public void Request_AwsJson10_EmitsVersion10ContentTypeAndHonorsH2()
    {
        var source = RequestMarshaller(Json10, "Send");

        Assert.Equal(AWSProtocol.AwsJson1_0, Json10.Protocol);
        Assert.Contains("""request.Headers["Content-Type"] = "application/x-amz-json-1.0";""", source);
        Assert.Contains("request.HttpProtocolVersion = System.Net.HttpVersion.Version20;", source);
    }

    [Fact]
    public void Response_ReadsHeaderBoundMemberFromBody()
    {
        var operation = Json11.Operations.Single(o => o.Name == "DoScalars");
        var source = new JsonResponseUnmarshallerWriter(Json11, ModelFileName).Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("""context.TestExpression("id", targetDepth, ref reader)""", source);
        Assert.Contains("""context.TestExpression("name", targetDepth, ref reader)""", source);
        Assert.DoesNotContain("IsHeaderPresent", source);
    }

    [Fact]
    public void Exception_ReadsHeaderBoundMemberFromBody()
    {
        var error = Json11.Errors.Single(e => e.Key.Name == "BadThing");
        var source = new JsonExceptionUnmarshallerWriter(Json11, ModelFileName).Write(error.Value, error.Key, TestContext.Current.CancellationToken);

        Assert.Contains("""context.TestExpression("reason", targetDepth, ref reader)""", source);
        Assert.DoesNotContain("IsHeaderPresent", source);
    }
}
