using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers document body members - standalone, as a list element, and as a map value - for both
// writers off one small model. The emitted code delegates wholesale to the runtime document
// transforms (Amazon.Runtime.Documents.Internal.Transform), fully qualified, with no per-element
// object wrapping: a document element is written bare, unlike a structure element.
public class DocumentCodegenTests
{
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;

    public DocumentCodegenTests()
    {
        var context = TestModels.Context("Codegen/document-model.json");
        var operation = context.Operations.Single(o => o.Name == "PutDocs");

        _requestMarshaller = new JsonRequestMarshallerWriter(context, "document-model.json").Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, "document-model.json").Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_WritesDocumentMember()
    {
        Assert.Contains("""context.Writer.WritePropertyName("config");""", _requestMarshaller);
        Assert.Contains("Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.Config);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesDocumentListElementsBare()
    {
        Assert.Contains("""context.Writer.WritePropertyName("attachments");""", _requestMarshaller);
        Assert.Contains("foreach (var publicRequestAttachmentsListValue in publicRequest.Attachments)", _requestMarshaller);
        Assert.Contains("Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequestAttachmentsListValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesDocumentMapValues()
    {
        Assert.Contains("foreach (var publicRequestMetadataKvp in publicRequest.Metadata)", _requestMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);", _requestMarshaller);
        Assert.Contains("var publicRequestMetadataValue = publicRequestMetadataKvp.Value;", _requestMarshaller);
        Assert.Contains("Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequestMetadataValue);", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsDocumentMember()
    {
        Assert.Contains("""if (context.TestExpression("config", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Config = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsDocumentList()
    {
        Assert.Contains("""if (context.TestExpression("attachments", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<Amazon.Runtime.Documents.Document, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Attachments = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsDocumentMap()
    {
        Assert.Contains("""if (context.TestExpression("metadata", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonDictionaryUnmarshaller<string, Amazon.Runtime.Documents.Document, StringUnmarshaller, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(StringUnmarshaller.Instance, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Metadata = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }
}
