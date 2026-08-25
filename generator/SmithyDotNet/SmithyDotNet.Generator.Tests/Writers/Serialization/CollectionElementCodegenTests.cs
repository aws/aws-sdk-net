using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

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

    [Fact]
    public void RequestMarshaller_WritesStringMapEntries()
    {
        Assert.Contains("""context.Writer.WritePropertyName("labels");""", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStartObject();", _requestMarshaller);
        Assert.Contains("foreach (var publicRequestLabelsKvp in publicRequest.Labels)", _requestMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(publicRequestLabelsKvp.Key);", _requestMarshaller);
        Assert.Contains("var publicRequestLabelsValue = publicRequestLabelsKvp.Value;", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestLabelsValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesStructureMapEntries()
    {
        Assert.Contains("foreach (var publicRequestWidgetsByIdKvp in publicRequest.WidgetsById)", _requestMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(publicRequestWidgetsByIdKvp.Key);", _requestMarshaller);
        Assert.Contains("var publicRequestWidgetsByIdValue = publicRequestWidgetsByIdKvp.Value;", _requestMarshaller);
        Assert.Contains("var marshaller = WidgetMarshaller.Instance;", _requestMarshaller);
        Assert.Contains("marshaller.Marshall(publicRequestWidgetsByIdValue, context);", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsStringMap()
    {
        Assert.Contains("""if (context.TestExpression("labels", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Labels = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsStructureMap()
    {
        Assert.Contains("""if (context.TestExpression("widgetsById", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonDictionaryUnmarshaller<string, Widget, StringUnmarshaller, WidgetUnmarshaller>(StringUnmarshaller.Instance, WidgetUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.WidgetsById = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesMapOfListEntries()
    {
        // map<string, list<string>>: the map value recurses into a nested array. The inner loop variable
        // is seeded off the map value's variable so it never collides with the outer loop.
        Assert.Contains("foreach (var publicRequestTagsByGroupKvp in publicRequest.TagsByGroup)", _requestMarshaller);
        Assert.Contains("var publicRequestTagsByGroupValue = publicRequestTagsByGroupKvp.Value;", _requestMarshaller);
        Assert.Contains("foreach (var publicRequestTagsByGroupValueListValue in publicRequestTagsByGroupValue)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestTagsByGroupValueListValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesListOfListElements()
    {
        // list<list<string>>: the element recurses into a nested array with a distinct inner loop variable.
        Assert.Contains("foreach (var publicRequestGroupedTagsListValue in publicRequest.GroupedTags)", _requestMarshaller);
        Assert.Contains("foreach (var publicRequestGroupedTagsListValueListValue in publicRequestGroupedTagsListValue)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestGroupedTagsListValueListValue);", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsMapOfList()
    {
        Assert.Contains("""if (context.TestExpression("tagsByGroup", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonDictionaryUnmarshaller<string, List<string>, StringUnmarshaller, JsonListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.TagsByGroup = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsListOfList()
    {
        Assert.Contains("""if (context.TestExpression("groupedTags", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<List<string>, JsonListUnmarshaller<string, StringUnmarshaller>>(new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.GroupedTags = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }
}
