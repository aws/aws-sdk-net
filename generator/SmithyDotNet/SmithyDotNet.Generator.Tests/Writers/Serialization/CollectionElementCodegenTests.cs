using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers list-of-string, list-of-structure, and list/map-of-enum body members for both writers off one
// small model: TagList (string elements, request and response), WidgetList (structure elements, response
// only), and StatusList/StatusMap (enum elements) - CloudTrail's PutAuditEvents model doesn't have a
// string list, so that gap had no coverage before the TypeDescriptor introduction.
public class CollectionElementCodegenTests
{
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;
    private readonly string _requestStructure;

    public CollectionElementCodegenTests()
    {
        var context = TestModels.Context("Codegen/collection-model.json");
        var operation = context.Operations.Single(o => o.Name == "PutThings");

        _requestMarshaller = new JsonRequestMarshallerWriter(context, "collection-model.json").Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, "collection-model.json").Write(operation, TestContext.Current.CancellationToken);

        // context.Structures excludes @input/@output shapes, so the request structure comes off the operation.
        _requestStructure = new StructureWriter(context, "collection-model.json")
            .Write(operation.Input, operation.Shape.Input, TestContext.Current.CancellationToken);
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

    [Fact]
    public void RequestStructure_EnumCollections_SurfaceAsStringCollections()
    {
        Assert.Contains("public List<string> Statuses", _requestStructure);
        Assert.Contains("public Dictionary<string, string> StatusByName", _requestStructure);
        Assert.Contains("public List<List<string>> GroupedStatuses", _requestStructure);
        Assert.DoesNotContain("Status>", _requestStructure);
    }

    [Fact]
    public void RequestMarshaller_WritesEnumListAndMapElementsAsStrings()
    {
        Assert.Contains("foreach (var publicRequestStatusesListValue in publicRequest.Statuses)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestStatusesListValue);", _requestMarshaller);

        Assert.Contains("var publicRequestStatusByNameValue = publicRequestStatusByNameKvp.Value;", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestStatusByNameValue);", _requestMarshaller);

        // list<list<enum>> recurses like list<list<string>> - the enum collapses at the leaf, not the member.
        Assert.Contains("foreach (var publicRequestGroupedStatusesListValueListValue in publicRequestGroupedStatusesListValue)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequestGroupedStatusesListValueListValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_EnumListQueryAndHeader_UseStringListBindings()
    {
        // A list<enum> binds exactly like a list<string>: the typed ParameterCollection overload for
        // @httpQuery, StringUtils.FromList for @httpHeader.
        Assert.Contains("""request.ParameterCollection.Add("status", publicRequest.StatusFilter);""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-status"] = StringUtils.FromList(publicRequest.StatusTags);""", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsEnumCollectionsAsStrings()
    {
        Assert.Contains("""if (context.TestExpression("statuses", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Statuses = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.StatusByName = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.GroupedStatuses = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);

        // The enum element resolves to string, so no ConstantClass leaks into the generic args and no
        // per-enum unmarshaller is referenced (none is generated).
        Assert.DoesNotContain("StatusUnmarshaller", _responseUnmarshaller);
        Assert.DoesNotContain("Status>", _responseUnmarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesIntListElements()
    {
        // Non-sparse collection elements are non-nullable (List<int>), so no `.Value` unwrap - matches C2J.
        Assert.Contains("foreach (var publicRequestCountsListValue in publicRequest.Counts)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequestCountsListValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesLongMapEntries()
    {
        Assert.Contains("foreach (var publicRequestAmountsKvp in publicRequest.Amounts)", _requestMarshaller);
        Assert.Contains("var publicRequestAmountsValue = publicRequestAmountsKvp.Value;", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequestAmountsValue);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesDoubleListElements_WithoutSpecialValueGuard()
    {
        // C2J's non-sparse collection path writes doubles with a bare WriteNumberValue - the NaN/Infinity
        // guard is scalar-member-only. Match that (don't reuse the nullable-member scalar writer).
        Assert.Contains("foreach (var publicRequestRatiosListValue in publicRequest.Ratios)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequestRatiosListValue);", _requestMarshaller);
        Assert.DoesNotContain("IsSpecialDoubleValue(publicRequestRatiosListValue", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_WritesTimestampListElements_DefaultsToEpochSeconds()
    {
        Assert.Contains("foreach (var publicRequestEpochTimesListValue in publicRequest.EpochTimes)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequestEpochTimesListValue)));", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_TimestampListElement_HonorsMemberTimestampFormat()
    {
        // @timestampFormat on the list's member reference must thread through to the collection element.
        Assert.Contains("foreach (var publicRequestIsoTimesListValue in publicRequest.IsoTimes)", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestIsoTimesListValue));", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsIntList()
    {
        // Non-nullable element type + non-nullable IntUnmarshaller, matching the List<int> property type.
        Assert.Contains("""if (context.TestExpression("counts", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Counts = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsLongMap()
    {
        Assert.Contains("""if (context.TestExpression("amounts", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.Amounts = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshallsTimestampList_FormatAgnostic()
    {
        // The runtime DateTime unmarshaller auto-detects the wire format, so epoch and date-time lists
        // unmarshal identically - no @timestampFormat is threaded on the read side.
        Assert.Contains("""if (context.TestExpression("epochTimes", targetDepth, ref reader))""", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<DateTime, DateTimeUnmarshaller>(DateTimeUnmarshaller.Instance);", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.IsoTimes = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }
}
