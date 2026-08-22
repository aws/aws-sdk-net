using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

// Covers list-of-string and list-of-structure body members for both writers off one small model:
// TagList (string elements, request and response) and WidgetList (structure elements, response
// only) - CloudTrail's PutAuditEvents model doesn't have a string list, so that gap had no coverage
// before the TypeDescriptor introduction.
public class CollectionElementCodegenTests
{
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;

    public CollectionElementCodegenTests()
    {
        var context = TestModels.Context("Codegen/collection-model.json");
        var operation = context.Operations.Single(o => o.Name == "PutThings");

        _requestMarshaller = new JsonRequestMarshallerWriter(context, "collection-model.json").Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, "collection-model.json").Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_WritesStringListElements()
    {
        Assert.Contains("context.Writer.WriteStartArray();", _requestMarshaller);
        Assert.Contains("foreach (var publicRequestTagsListValue in publicRequest.Tags)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestTagsListValue);", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsStringList()
    {
        Assert.Contains("""if (context.TestExpression("tags", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsStructureList()
    {
        Assert.Contains("""if (context.TestExpression("widgets", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<Widget, WidgetUnmarshaller>(WidgetUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Widgets = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }
}
