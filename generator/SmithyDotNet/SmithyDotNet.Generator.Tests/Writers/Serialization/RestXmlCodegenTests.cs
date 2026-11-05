using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// restXml: HTTP bindings shared with restJson1, an XML body written through XmlMarshallerContext with a
// generated marshaller per structure, XML response/structure/exception unmarshallers over XmlUnmarshallerContext.
public class RestXmlCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Context = TestModels.Context("Codegen/restxml-model.json");
    private static readonly ShapeId Thing = ShapeId.Parse("com.example#Thing");
    private static readonly ShapeId NestedThing = ShapeId.Parse("com.example#NestedThing");
    private static readonly ShapeId Tag = ShapeId.Parse("com.example#Tag");
    private static readonly ShapeId ReorderMe = ShapeId.Parse("com.example#ReorderMe");
    private static readonly ShapeId ThingConflict = ShapeId.Parse("com.example#ThingConflict");

    private static string RequestMarshaller(GenerationContext context, string operationName) =>
        new XmlRequestMarshallerWriter(context, ModelFileName)
            .Write(context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    private static string StructureMarshaller(GenerationContext context, ShapeId shape) =>
        new XmlStructureMarshallerWriter(context, ModelFileName)
            .Write(context.Structures[shape], TestContext.Current.CancellationToken);

    private static string ResponseUnmarshaller(string operationName) =>
        new XmlResponseUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    [Fact]
    public void Protocol_ResolvesRestXml()
    {
        Assert.Equal(AWSProtocol.RestXml, Context.Protocol);
        Assert.True(Context.UsesHttpBindings);
    }

    [Fact]
    public void Request_Bindings()
    {
        var source = RequestMarshaller(Context, "PutThing");

        Assert.Contains("""request.HttpMethod = "POST";""", source);
        Assert.Contains("""request.Headers["x-trace"] = publicRequest.Trace;""", source);
        Assert.Contains("""request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));""", source);
        Assert.Contains("""request.ResourcePath = "/things/{id}";""", source);
        Assert.Contains("""request.Parameters.Add("filter", StringUtils.FromString(publicRequest.Filter));""", source);
        Assert.Contains("request.UseQueryString = true;", source);
    }

    [Fact]
    public void Request_XmlBodyScaffoldAndRoot()
    {
        var source = RequestMarshaller(Context, "PutThing");

        Assert.Contains("request.ContentStream = new PooledContentStream();", source);
        Assert.Contains("var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);", source);
        Assert.Contains("var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);", source);
        Assert.Contains("var context = new XmlMarshallerContext(request, xmlWriter);", source);
        Assert.Contains("""context.Writer.WriteStartElement("PutThingRequest", "http://example.com/doc/2023-01-01/");""", source);
        Assert.Contains("""request.Headers["Content-Type"] = "application/xml";""", source);
        Assert.Contains("""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-01";""", source);
        Assert.Contains("catch (EncoderFallbackException e)", source);
        Assert.Contains("""throw new AmazonServiceException("Unable to marshall request to XML", e);""", source);
    }

    [Fact]
    public void Request_Scalars_UseStringUtilsWithValueUnwrap()
    {
        var source = RequestMarshaller(Context, "PutThing");

        Assert.Contains("""context.Writer.WriteElementString("ThingName", StringUtils.FromString(publicRequest.Name));""", source);
        Assert.Contains("""context.Writer.WriteElementString("count", StringUtils.FromInt(publicRequest.Count.Value));""", source);
        Assert.Contains("""context.Writer.WriteElementString("big", StringUtils.FromLong(publicRequest.Big.Value));""", source);
        Assert.Contains("""context.Writer.WriteElementString("flag", StringUtils.FromBool(publicRequest.Flag.Value));""", source);
        Assert.Contains("""context.Writer.WriteElementString("ratio", StringUtils.FromDouble(publicRequest.Ratio.Value));""", source);
        Assert.Contains("""context.Writer.WriteElementString("when", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.When.Value));""", source);
    }

    [Fact]
    public void Request_Attribute_And_NestedStructureDelegates()
    {
        var source = RequestMarshaller(Context, "PutThing");

        Assert.Contains("""context.Writer.WriteAttributeString("region", StringUtils.FromString(publicRequest.Region));""", source);
        // The nested structure's element carries its @xmlNamespace and delegates to the structure marshaller.
        Assert.Contains("""context.Writer.WriteStartElement("nested", "http://example.com/nested");""", source);
        Assert.Contains("NestedThingMarshaller.Instance.Marshall(publicRequest.Nested, context);", source);
        Assert.DoesNotContain("publicRequest.Nested.Note", source);
    }

    [Fact]
    public void Request_Lists_WrappedAndFlattened()
    {
        var source = RequestMarshaller(Context, "PutThing");

        // Wrapped list of structures: a <tags> wrapper, items named by the list value's @xmlName (Tag),
        // each struct item null-guarded and delegated to its marshaller.
        Assert.Contains("""context.Writer.WriteStartElement("tags");""", source);
        Assert.Contains("foreach (var publicRequestTagsValue in publicRequestTags)", source);
        Assert.Contains("if (publicRequestTagsValue != null)", source);
        Assert.Contains("""context.Writer.WriteStartElement("Tag");""", source);
        Assert.Contains("TagMarshaller.Instance.Marshall(publicRequestTagsValue, context);", source);

        // Flattened scalar list: no wrapper element, each item named by the member @xmlName (Alias), via WriteValue.
        Assert.Contains("foreach (var publicRequestAliasesValue in publicRequestAliases)", source);
        Assert.Contains("""context.Writer.WriteStartElement("Alias");""", source);
        Assert.Contains("context.Writer.WriteValue(publicRequestAliasesValue);", source);
        Assert.DoesNotContain("""context.Writer.WriteStartElement("aliases");""", source);

        // A value-type scalar list element routes through StringUtils (not bare WriteValue), so special
        // floats serialize as Infinity/-Infinity/NaN per the restXml spec.
        Assert.Contains("context.Writer.WriteValue(StringUtils.FromDouble(publicRequestRatiosValue));", source);
    }

    [Fact]
    public void Request_Map_And_IdempotencyToken()
    {
        var source = RequestMarshaller(Context, "PutThing");

        Assert.Contains("""context.Writer.WriteStartElement("labels");""", source);
        Assert.Contains("foreach (var kvp in publicRequest.Labels)", source);
        Assert.Contains("""context.Writer.WriteStartElement("entry");""", source);
        Assert.Contains("""context.Writer.WriteElementString("key", kvp.Key);""", source);
        Assert.Contains("""context.Writer.WriteElementString("value", kvp.Value);""", source);

        // A value-type scalar map value routes through StringUtils (not kvp.Value.ToString(), which gives
        // True/False for bool and culture-dependent text for double/timestamp).
        Assert.Contains("""context.Writer.WriteElementString("value", StringUtils.FromDouble(kvp.Value));""", source);

        Assert.Contains("""context.Writer.WriteElementString("token", Guid.NewGuid().ToString());""", source);
    }

    [Fact]
    public void Request_NestedMap_RecursesWithDepthDisambiguatedLoops()
    {
        var source = RequestMarshaller(Context, "PutThing");

        // map<string, map<string,string>>: an outer <entry> whose <value> wraps the inner map's <entry>s,
        // the inner loop variable disambiguated by depth so it doesn't collide with the outer kvp.
        Assert.Contains("""context.Writer.WriteStartElement("nestedLabels");""", source);
        Assert.Contains("foreach (var kvp in publicRequest.NestedLabels)", source);
        Assert.Contains("foreach (var kvp1 in kvp.Value)", source);
        Assert.Contains("""context.Writer.WriteElementString("value", kvp1.Value);""", source);
    }

    [Fact]
    public void BlobBodyMember_Base64OnMarshall_MemoryStreamOnUnmarshall()
    {
        var request = RequestMarshaller(Context, "PutThing");
        Assert.Contains("""context.Writer.WriteElementString("data", StringUtils.FromMemoryStream(publicRequest.Data));""", request);

        var response = ResponseUnmarshaller("PutThing");
        Assert.Contains("""if (context.TestExpression("data", targetDepth))""", response);
        Assert.Contains("var unmarshaller = MemoryStreamUnmarshaller.Instance;", response);
    }

    [Fact]
    public void Request_StructurePayload_RootIsPayloadShapeAndDelegates()
    {
        var source = RequestMarshaller(Context, "PutPayload");

        // An unset structure/union payload sends an empty body, so the whole XML body is IsSet-guarded.
        Assert.Contains("if (publicRequest.IsSetDetails())", source);
        Assert.Contains("""context.Writer.WriteStartElement("NestedThing", "http://example.com/doc/2023-01-01/");""", source);
        Assert.Contains("NestedThingMarshaller.Instance.Marshall(publicRequest.Details, context);", source);
    }

    [Fact]
    public void Request_HostPrefix_SkippedWhenHostLabelIsContextParam()
    {
        // S3 Control shape: the @hostLabel is also a @contextParam, so the endpoint ruleset already puts
        // the value in the host. Emitting request.HostPrefix here would duplicate it, so it is skipped.
        var skipped = RequestMarshaller(Context, "AccountOp");
        Assert.DoesNotContain("request.HostPrefix", skipped);

        // A plain @hostLabel (no @contextParam) still emits the prefix.
        var emitted = RequestMarshaller(Context, "RegionOp");
        Assert.Contains("""request.HostPrefix = $"{hostPrefixLabels.region}.";""", emitted);
    }

    [Fact]
    public void Request_Get_NoBody()
    {
        var source = RequestMarshaller(Context, "GetThing");

        Assert.Contains("""request.HttpMethod = "GET";""", source);
        Assert.Contains("""request.ResourcePath = "/things/{id}";""", source);
        Assert.DoesNotContain("Content-Type", source);
        Assert.DoesNotContain("XmlWriter.Create", source);
        Assert.DoesNotContain("XAmzApiVersion", source);
    }

    [Fact]
    public void StructureMarshaller_WritesMembersAndDelegatesNested()
    {
        var tag = StructureMarshaller(Context, Tag);
        Assert.Contains("public partial class TagMarshaller : IRequestMarshaller<Tag, XmlMarshallerContext>", tag);
        Assert.Contains("public void Marshall(Tag requestObject, XmlMarshallerContext context)", tag);
        Assert.Contains("if (requestObject == null) return;", tag);
        Assert.Contains("""context.Writer.WriteElementString("key", StringUtils.FromString(requestObject.Key));""", tag);
        Assert.Contains("""context.Writer.WriteElementString("value", StringUtils.FromString(requestObject.Value));""", tag);
        Assert.Contains("public readonly static TagMarshaller Instance = new TagMarshaller();", tag);

        var nested = StructureMarshaller(Context, NestedThing);
        Assert.Contains("""context.Writer.WriteElementString("note", StringUtils.FromString(requestObject.Note));""", nested);
        // A prefixed @xmlName attribute ("xsi:nsAttr") splits into the prefixed WriteAttributeString overload
        // (XmlWriter rejects a ':' in a local name); the prefix is declared on an ancestor element.
        Assert.Contains("""context.Writer.WriteAttributeString("xsi", "nsAttr", null, StringUtils.FromString(requestObject.NsAttr));""", nested);

        var nestedUnmarshaller = new XmlStructureUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[NestedThing], TestContext.Current.CancellationToken);
        Assert.Contains("""if (context.TestExpression("@nsAttr", targetDepth - 1))""", nestedUnmarshaller);
    }

    [Fact]
    public void Response_BodyLoop_HeadersAndStatusCode()
    {
        var source = ResponseUnmarshaller("PutThing");

        Assert.Contains("public partial class PutThingResponseUnmarshaller : XmlResponseUnmarshaller", source);
        Assert.Contains("private static void UnmarshallResult(XmlUnmarshallerContext context, PutThingResponse unmarshalledObject)", source);
        Assert.Contains("int targetDepth = originalDepth + 1;", source);
        Assert.Contains("if (context.IsStartOfDocument)", source);

        Assert.Contains("""if (context.TestExpression("created", targetDepth))""", source);
        Assert.Contains("var unmarshaller = NullableDateTimeUnmarshaller.Instance;", source);
        Assert.Contains("""if (context.TestExpression("things/member", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.Things = new List<Thing>();", source);
        Assert.Contains("unmarshalledObject.Things.Add(unmarshaller.Unmarshall(context));", source);
        Assert.Contains("""if (context.TestExpression("props", targetDepth))""", source);
        Assert.Contains("""new XmlDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");""", source);

        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-thing-id"))""", source);
        Assert.Contains("""unmarshalledObject.ThingId = context.ResponseData.GetHeaderValue("x-thing-id");""", source);
        Assert.Contains("unmarshalledObject.Status = (int)context.ResponseData.StatusCode;", source);
    }

    [Fact]
    public void Response_NestedMap_UsesNestedDictionaryUnmarshaller()
    {
        var source = ResponseUnmarshaller("PutThing");

        Assert.Contains("""if (context.TestExpression("nestedProps", targetDepth))""", source);
        Assert.Contains(
            """new XmlDictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, XmlDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new XmlDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value"), "key", "value")""",
            source);
    }

    [Fact]
    public void Response_ErrorDispatch()
    {
        var source = ResponseUnmarshaller("PutThing");

        Assert.Contains("ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);", source);
        Assert.Contains("using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))", source);
        Assert.Contains("""if (errorResponse.Code != null && errorResponse.Code.Equals("ThingConflict"))""", source);
        Assert.Contains("return ThingConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);", source);
        Assert.Contains("return new AmazonExampleException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);", source);
    }

    [Fact]
    public void StructureUnmarshaller()
    {
        var source = new XmlStructureUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[Thing], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class ThingUnmarshaller : IXmlUnmarshaller<Thing, XmlUnmarshallerContext>", source);
        Assert.Contains("public Thing Unmarshall(XmlUnmarshallerContext context)", source);
        Assert.Contains("targetDepth += 2;", source);
        Assert.Contains("""if (context.TestExpression("arn", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.Arn = unmarshaller.Unmarshall(context);", source);
    }

    [Fact]
    public void ExceptionUnmarshaller()
    {
        var source = new XmlExceptionUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Errors[ThingConflict], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class ThingConflictExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<ThingConflictException, XmlUnmarshallerContext>", source);
        Assert.Contains("throw new NotImplementedException();", source);
        Assert.Contains("public ThingConflictException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)", source);
        Assert.Contains("ThingConflictException unmarshalledObject = new ThingConflictException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);", source);
        // restXml keeps its template's depth-less suffix match and unbounded read loop
        // (RestXmlExceptionUnmarshaller.tt); only awsQuery depth-qualifies them.
        Assert.Contains("while (context.Read())", source);
        Assert.Contains("""if (context.TestExpression("reason"))""", source);
        Assert.DoesNotContain("context.ReadAtDepth(originalDepth)", source);
        Assert.Contains("unmarshalledObject.Reason = unmarshaller.Unmarshall(context);", source);
    }

    [Fact]
    public void AllowEmptyResult_SkipsBodyParseOnEmptySuccess()
    {
        var customizations = new CustomizationsModel
        {
            OperationModifiers = { ["PutThing"] = new OperationModifier { AllowEmptyResult = true } },
        };
        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);
        var source = new XmlResponseUnmarshallerWriter(context, ModelFileName)
            .Write(context.Operations.Single(o => o.Name == "PutThing"), TestContext.Current.CancellationToken);

        Assert.Contains("if (context.ResponseData.IsSuccessStatusCode && context.ResponseData.ContentLength == 0)", source);
    }

    [Fact]
    public void RetainOriginalMemberOrdering_KeepsDeclarationOrder()
    {
        var retained = new CustomizationsModel { RetainOriginalMemberOrdering = true };
        var retainedContext = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), retained);
        var retainedSource = StructureMarshaller(retainedContext, ReorderMe);
        // Declaration order: zebra before apple.
        Assert.True(retainedSource.IndexOf("WriteElementString(\"zebra\"", StringComparison.Ordinal)
            < retainedSource.IndexOf("WriteElementString(\"apple\"", StringComparison.Ordinal));

        // Default: sorted by property name, so apple before zebra.
        var sortedSource = StructureMarshaller(Context, ReorderMe);
        Assert.True(sortedSource.IndexOf("WriteElementString(\"apple\"", StringComparison.Ordinal)
            < sortedSource.IndexOf("WriteElementString(\"zebra\"", StringComparison.Ordinal));
    }
}
