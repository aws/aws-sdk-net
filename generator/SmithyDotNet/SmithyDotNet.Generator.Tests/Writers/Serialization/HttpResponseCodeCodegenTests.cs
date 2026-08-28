using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives the response unmarshaller writer against a model whose responses carry an
/// <c>@httpResponseCode</c> member. That member is populated from the HTTP status code itself — not
/// read from the body or a header — using the property name the model gave the member.
/// </summary>
public class HttpResponseCodeCodegenTests
{
    private const string ModelFileName = "http-response-code-model.json";

    private readonly GenerationContext _context;

    public HttpResponseCodeCodegenTests()
    {
        _context = TestModels.Context("Codegen/http-response-code-model.json");
    }

    private string ResponseUnmarshaller(string operationName)
    {
        var operation = _context.Operations.Single(o => o.Name == operationName);
        return new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ResponseUnmarshaller_StatusCodeMember_SetFromHttpStatusCode()
    {
        // GetStatus mixes a body member (name), a header member (sessionId), and the statusCode member.
        var unmarshaller = ResponseUnmarshaller("GetStatus");

        Assert.Contains("unmarshalledObject.StatusCode = (int)context.ResponseData.StatusCode;", unmarshaller);

        // The status-code member rides neither the body reader nor a header lookup.
        Assert.DoesNotContain("""context.TestExpression("statusCode",""", unmarshaller);
        Assert.DoesNotContain("""IsHeaderPresent("statusCode")""", unmarshaller);

        // The other bindings are unaffected.
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-session-id"))""", unmarshaller);
        Assert.Contains("""if (context.TestExpression("name", targetDepth, ref reader))""", unmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_StatusCodePropertyName_DerivedFromMemberNotHardcoded()
    {
        // GetStatusWithPayload names its @httpResponseCode member "httpCode", so the assignment must
        // target HttpCode — proving the writer reads the member's property name rather than emitting a
        // literal "StatusCode". The member also coexists with an @httpPayload body member.
        var unmarshaller = ResponseUnmarshaller("GetStatusWithPayload");

        Assert.Contains("unmarshalledObject.HttpCode = (int)context.ResponseData.StatusCode;", unmarshaller);
        Assert.DoesNotContain("unmarshalledObject.StatusCode = (int)context.ResponseData.StatusCode;", unmarshaller);

        // @httpPayload string body is still read as the whole payload.
        Assert.Contains("unmarshalledObject.Body = sr.ReadToEnd();", unmarshaller);
    }

    [Fact]
    public void ResponseClass_StatusCodeMember_EmittedAsNullableIntProperty()
    {
        // The @httpResponseCode member is an ordinary property on the response class (integer → int?).
        var operation = _context.Operations.Single(o => o.Name == "GetStatus");
        var responseClass = new OperationWriter(_context, ModelFileName)
            .WriteResponse(operation, TestContext.Current.CancellationToken);

        Assert.Contains("public int? StatusCode", responseClass);
    }

    [Fact]
    public void ExceptionUnmarshaller_StatusCodeMember_IgnoredAndReadFromBody()
    {
        // On an error the trait "is simply ignored" (Smithy), so the member is unmarshalled from the
        // body like any ordinary member — no status-code assignment is emitted.
        var errorId = ShapeId.Parse("com.example#ConflictError");
        var unmarshaller = new JsonExceptionUnmarshallerWriter(_context, ModelFileName)
            .Write(_context.Errors[errorId], errorId, TestContext.Current.CancellationToken);

        Assert.DoesNotContain("(int)context.ResponseData.StatusCode", unmarshaller);
        Assert.Contains("""if (context.TestExpression("code", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("""if (context.TestExpression("reason", targetDepth, ref reader))""", unmarshaller);
    }
}
