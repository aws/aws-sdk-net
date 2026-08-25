using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Drives the request marshaller and response unmarshaller against a model whose operations bind a
/// member with <c>@httpPayload</c> (string / structure / blob), verifying the payload replaces normal
/// body serialization/unmarshalling and matches the legacy C2J output. An <c>@httpPayload</c> error
/// member has no payload path and fails loud in the exception unmarshaller (see the negative case).
/// </summary>
public class PayloadMemberCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static string Marshaller(string operationName)
    {
        var context = TestModels.Context("Codegen/payload-model.json");
        var operation = context.Operations.Single(o => o.Name == operationName);
        return new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    private static string ResponseUnmarshaller(string operationName)
    {
        var context = TestModels.Context("Codegen/payload-model.json");
        var operation = context.Operations.Single(o => o.Name == operationName);
        return new JsonResponseUnmarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    // Builds a context from an inline model and marshals its single "Op" operation, so a negative
    // test can drive a payload shape the shared payload-model.json intentionally does not contain.
    private static string MarshallOp(string requestMembersJson, string extraShapesJson = "")
    {
        var json = $$"""
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Op" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Op": {
              "type": "operation",
              "input": { "target": "com.example#OpRequest" },
              "output": { "target": "smithy.api#Unit" },
              "traits": { "smithy.api#http": { "uri": "/op", "method": "POST" } }
            },
            "com.example#OpRequest": { "type": "structure", "members": { {{requestMembersJson}} } }{{extraShapesJson}}
          }
        }
        """;
        var model = JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = TestModels.Context(model);
        var operation = context.Operations.Single(o => o.Name == "Op");
        return new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void StructurePayload_SerializesTargetAsEntireBody()
    {
        var m = Marshaller("DoStructurePayload");

        // Structure payload keeps application/json and streams the target's marshaller as the body.
        Assert.Contains("""request.Headers["Content-Type"] = "application/json";""", m);
        Assert.Contains("request.ContentStream = new PooledContentStream();", m);
        Assert.Contains("var context = new JsonMarshallerContext(request, writer);", m);
        Assert.Contains("context.Writer.WriteStartObject();", m);
        Assert.Contains("var marshaller = PayloadDetailsMarshaller.Instance;", m);
        Assert.Contains("marshaller.Marshall(publicRequest.Details, context);", m);
        Assert.Contains("context.Writer.WriteEndObject();", m);
    }

    [Fact]
    public void StructurePayload_HasNoWrappingPropertyOrBodyMemberLoop()
    {
        var m = Marshaller("DoStructurePayload");

        // The payload IS the body: no outer property name, and none of the normal body-member
        // scaffolding (which opens the object via `writer.WriteStartObject()`, not `context.Writer`).
        Assert.DoesNotContain("""WritePropertyName("details")""", m);
        Assert.DoesNotContain("writer.WriteStartObject();", m);
    }

    [Fact]
    public void StructurePayload_StillEmitsHeaderSibling()
    {
        var m = Marshaller("DoStructurePayload");
        Assert.Contains("""request.Headers["x-trace"] = publicRequest.Trace;""", m);
    }

    [Fact]
    public void StringPayload_WritesRawUtf8BodyWithTextPlain()
    {
        var m = Marshaller("DoStringPayload");

        Assert.Contains("""request.Headers["Content-Type"] = "text/plain";""", m);
        Assert.Contains("request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.Body);", m);
    }

    [Fact]
    public void StringPayload_EmitsNoJsonWriterScaffold()
    {
        var m = Marshaller("DoStringPayload");

        // A raw string body uses none of the JSON writer scaffolding.
        Assert.DoesNotContain("new PooledContentStream()", m);
        Assert.DoesNotContain("Utf8JsonWriter", m);
        Assert.DoesNotContain("WriteStartObject", m);
    }

    [Fact]
    public void StringPayload_StillEmitsQuerySibling()
    {
        var m = Marshaller("DoStringPayload");
        Assert.Contains("""request.Parameters.Add("filter", StringUtils.FromString(publicRequest.Filter));""", m);
        Assert.Contains("request.UseQueryString = true;", m);
    }

    [Fact]
    public void StructureResponsePayload_UnmarshalsWholeBodyAsStructure()
    {
        var m = ResponseUnmarshaller("GetStructurePayload");

        Assert.Contains("var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);", m);
        Assert.Contains("if (reader.Reader.IsFinalBlock) return unmarshalledObject;", m);
        Assert.Contains("var unmarshaller = PayloadDetailsUnmarshaller.Instance;", m);
        Assert.Contains("unmarshalledObject.Details = unmarshaller.Unmarshall(context, ref reader);", m);

        // The payload IS the body: no named-field reader loop, and the header sibling still reads.
        Assert.DoesNotContain("context.TestExpression(", m);
        Assert.DoesNotContain("while (context.ReadAtDepth", m);
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-trace"))""", m);
    }

    [Fact]
    public void StringResponsePayload_ReadsRawBodyViaStreamReader()
    {
        var m = ResponseUnmarshaller("GetStringPayload");

        Assert.Contains("using (var sr = new StreamReader(context.Stream))", m);
        Assert.Contains("unmarshalledObject.Body = sr.ReadToEnd();", m);

        // Not the structure path (no IsFinalBlock guard) and not the named-field body loop.
        Assert.DoesNotContain("if (reader.Reader.IsFinalBlock)", m);
        Assert.DoesNotContain("context.TestExpression(", m);
    }

    [Fact]
    public void BlobPayload_WritesRawContentStreamWithOctetStream()
    {
        var m = Marshaller("DoBlobPayload");

        // Content-Type is application/json at the top, then overridden to octet-stream (matches C2J).
        Assert.Contains("request.ContentStream = publicRequest.Body ?? new MemoryStream();", m);
        Assert.Contains("if (request.ContentStream.CanSeek)", m);
        Assert.Contains("request.ContentStream.Seek(0, SeekOrigin.Begin);", m);
        Assert.Contains("request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);", m);
        Assert.Contains("""request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";""", m);
        Assert.Contains("using System.Globalization;", m);

        // A raw blob body uses no JSON writer scaffold; the query sibling still marshals.
        Assert.DoesNotContain("Utf8JsonWriter", m);
        Assert.Contains("""request.Parameters.Add("filter", StringUtils.FromString(publicRequest.Filter));""", m);
    }

    [Fact]
    public void BlobResponsePayload_CopiesBodyToMemoryStream()
    {
        var m = ResponseUnmarshaller("GetBlobPayload");

        Assert.Contains("var ms = new MemoryStream();", m);
        Assert.Contains("Amazon.Util.AWSSDKUtils.CopyStream(context.Stream, ms);", m);
        Assert.Contains("ms.Seek(0, SeekOrigin.Begin);", m);
        Assert.Contains("if (ms.Length > 0)", m);
        Assert.Contains("unmarshalledObject.Body = ms;", m);

        // Not the structure path, not the named-field body loop; the header sibling still reads.
        Assert.DoesNotContain("if (reader.Reader.IsFinalBlock)", m);
        Assert.DoesNotContain("context.TestExpression(", m);
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-trace"))""", m);
    }

    [Fact]
    public void EnumPayload_RequestUsesTextPlainAndRawBytes()
    {
        // An enum is a string shape in C2J: the payload marshals byte-identically to a string one —
        // text/plain + raw GetBytes (the ConstantClass converts implicitly to string).
        var m = Marshaller("DoEnumPayload");

        Assert.Contains("""request.Headers["Content-Type"] = "text/plain";""", m);
        Assert.Contains("request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.Body);", m);
        Assert.DoesNotContain("Utf8JsonWriter", m);
    }

    [Fact]
    public void EnumResponsePayload_ReadsRawBodyViaStreamReader()
    {
        var m = ResponseUnmarshaller("GetEnumPayload");

        Assert.Contains("using (var sr = new StreamReader(context.Stream))", m);
        Assert.Contains("unmarshalledObject.Body = sr.ReadToEnd();", m);
        Assert.DoesNotContain("if (reader.Reader.IsFinalBlock)", m);
    }

    [Fact]
    public void GetOperation_OmitsContentType()
    {
        // C2J omits Content-Type for GET/DELETE. GetStructurePayload is a GET with no request body.
        var m = Marshaller("GetStructurePayload");

        Assert.DoesNotContain("Content-Type", m);
        Assert.Contains("""request.HttpMethod = "GET";""", m);
    }

    [Fact]
    public void BodylessPostOperation_OmitsContentType()
    {
        // C2J omits Content-Type when there are no body/payload members, even for POST.
        var m = Marshaller("DoNoBody");

        Assert.DoesNotContain("Content-Type", m);
        Assert.Contains("""request.HttpMethod = "POST";""", m);
    }

    // Each case is one inline model fragment (request members + optional extra shapes) that MarshallOp
    // rejects: more than one @httpPayload and a payload alongside an unbound body member are caught in
    // PartitionMembers; a list payload resolves to a type but isn't a handled payload target (blob/
    // document/union throw even earlier, in TypeMapper).
    [Theory]
    [InlineData(
        """
        "a": { "target": "smithy.api#String", "traits": { "smithy.api#httpPayload": {} } },
        "b": { "target": "smithy.api#String", "traits": { "smithy.api#httpPayload": {} } }
        """,
        "",
        "more than one @httpPayload")]
    [InlineData(
        """
        "body":  { "target": "smithy.api#String", "traits": { "smithy.api#httpPayload": {} } },
        "extra": { "target": "smithy.api#String" }
        """,
        "",
        "cannot coexist with unbound body members")]
    [InlineData(
        """
        "items": { "target": "com.example#StringList", "traits": { "smithy.api#httpPayload": {} } }
        """,
        """
        ,
        "com.example#StringList": { "type": "list", "member": { "target": "smithy.api#String" } }
        """,
        "only string, structure, and blob payloads are handled")]
    public void PayloadMisuse_FailsLoud(string requestMembersJson, string extraShapesJson, string expectedMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => MarshallOp(requestMembersJson, extraShapesJson));
        Assert.Contains(expectedMessage, ex.Message);
    }

    [Fact]
    public void ErrorPayload_FailsLoud()
    {
        var json = """
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [{ "target": "com.example#Op" }],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {}
              }
            },
            "com.example#Op": {
              "type": "operation",
              "input": { "target": "smithy.api#Unit" },
              "output": { "target": "smithy.api#Unit" },
              "errors": [{ "target": "com.example#BadRequest" }],
              "traits": { "smithy.api#http": { "uri": "/op", "method": "POST" } }
            },
            "com.example#BadRequest": {
              "type": "structure",
              "members": { "body": { "target": "smithy.api#String", "traits": { "smithy.api#httpPayload": {} } } },
              "traits": { "smithy.api#error": "client" }
            }
          }
        }
        """;
        var model = JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = TestModels.Context(model);
        var error = context.Errors.Single(e => e.Key.Name == "BadRequest");

        var ex = Assert.Throws<GeneratorException>(() =>
            new JsonExceptionUnmarshallerWriter(context, ModelFileName)
                .Write(error.Value, error.Key, TestContext.Current.CancellationToken));
        Assert.Contains("@httpPayload on error member", ex.Message);
    }
}
