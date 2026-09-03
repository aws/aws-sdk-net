using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers non-streaming blob body members for both writers off one small model. On the wire a JSON
// body blob is a base64 string: the request side writes it via StringUtils.WriteBase64StringValue
// (the C2J pattern - see Textract's DocumentMarshaller) and the response side reads it via
// MemoryStreamUnmarshaller (see Kinesis's RecordUnmarshaller). Blobs never appear as list elements
// or map values in any staged model, so no collection coverage exists by design - those positions
// fail loud in the writers.
public class BlobCodegenTests
{
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;

    public BlobCodegenTests()
    {
        var context = TestModels.Context("Codegen/blob-model.json");
        var operation = context.Operations.Single(o => o.Name == "PutBlob");

        _requestMarshaller = new JsonRequestMarshallerWriter(context, "blob-model.json").Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, "blob-model.json").Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_WritesBlobMemberAsBase64String()
    {
        Assert.Contains("if (publicRequest.IsSetData())", _requestMarshaller);
        Assert.Contains("""context.Writer.WritePropertyName("data");""", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBase64StringValue(context.Writer, publicRequest.Data);", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsBlobMemberViaMemoryStreamUnmarshaller()
    {
        Assert.Contains("""if (context.TestExpression("data", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = MemoryStreamUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Data = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void QueryBoundBlobMember_FailsLoud()
    {
        // No staged model binds a blob to a header or query; keep those positions unsupported.
        // A blob has no string conversion, so the request marshaller throws instead of emitting
        // wrong code for the query (and, via the same conversion path, header) binding.
        var context = TestModels.Context("Codegen/blob-model.json");
        var operation = context.Operations.Single(o => o.Name == "GetBlob");
        var writer = new JsonRequestMarshallerWriter(context, "blob-model.json");

        var ex = Assert.Throws<GeneratorException>(() => writer.Write(operation, TestContext.Current.CancellationToken));
        Assert.Contains("Unsupported query member type 'MemoryStream'", ex.Message);
    }
}
