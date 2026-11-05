using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// awsQuery: a POST / request whose body is URL-encoded form parameters (Action/Version plus the input
// members, serialized inline into request.Parameters), and an XML response wrapped in {Op}Response/{Op}Result
// with ResponseMetadata. The response/structure/exception unmarshallers reuse the restXml XML machinery.
public class QueryCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Context = TestModels.Context("Codegen/query-model.json");
    private static readonly ShapeId Thing = ShapeId.Parse("com.example#Thing");
    private static readonly ShapeId BadThing = ShapeId.Parse("com.example#BadThing");

    private static string RequestMarshaller(string operationName) =>
        new QueryRequestMarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    private static string ResponseUnmarshaller(string operationName) =>
        new QueryResponseUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    [Fact]
    public void Protocol_ResolvesAwsQuery()
    {
        Assert.Equal(AWSProtocol.AwsQuery, Context.Protocol);
        Assert.False(Context.UsesHttpBindings);
    }

    [Fact]
    public void Request_ActionVersionAndContentPrecompute()
    {
        var source = RequestMarshaller("DoThing");

        Assert.Contains("public partial class DoThingRequestMarshaller : IMarshaller<IRequest, DoThingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>", source);
        Assert.Contains("""request.HttpMethod = "POST";""", source);
        Assert.Contains("""request.Parameters.Add("Action", "DoThing");""", source);
        Assert.Contains("""request.Parameters.Add("Version", "2023-01-01");""", source);
        Assert.Contains("request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);", source);
        Assert.Contains("request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);", source);
        // No XML body machinery and no per-operation Content-Type (the runtime sets the form encoding).
        Assert.DoesNotContain("XmlWriter", source);
        Assert.DoesNotContain("Content-Type", source);
    }

    [Fact]
    public void Request_Scalars_UseStringUtilsWithValueUnwrapAndXmlName()
    {
        var source = RequestMarshaller("DoThing");

        Assert.Contains("""request.Parameters.Add("ThingName", StringUtils.FromString(publicRequest.Name));""", source);
        Assert.Contains("""request.Parameters.Add("count", StringUtils.FromInt(publicRequest.Count.Value));""", source);
        Assert.Contains("""request.Parameters.Add("big", StringUtils.FromLong(publicRequest.Big.Value));""", source);
        Assert.Contains("""request.Parameters.Add("flag", StringUtils.FromBool(publicRequest.Flag.Value));""", source);
        Assert.Contains("""request.Parameters.Add("ratio", StringUtils.FromDouble(publicRequest.Ratio.Value));""", source);
        // awsQuery body timestamps default to date-time (ISO8601).
        Assert.Contains("""request.Parameters.Add("when", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.When.Value));""", source);
        Assert.Contains("""request.Parameters.Add("data", StringUtils.FromMemoryStream(publicRequest.Data));""", source);
        // An enum marshals as its string value.
        Assert.Contains("""request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));""", source);
    }

    [Fact]
    public void Request_NestedStructure_InlinedWithDottedPrefix()
    {
        var source = RequestMarshaller("DoThing");

        // No per-structure marshaller class exists for awsQuery; the nested structure's members are
        // written inline under a dot-joined parameter name.
        Assert.Contains("if (publicRequest.IsSetNested())", source);
        Assert.Contains("""request.Parameters.Add("nested" + ".note", StringUtils.FromString(publicRequest.Nested.Note));""", source);
        Assert.Contains("""request.Parameters.Add("nested" + ".level", StringUtils.FromInt(publicRequest.Nested.Level.Value));""", source);
        Assert.DoesNotContain("NestedThingMarshaller", source);
    }

    [Fact]
    public void Request_Lists_WrappedFlattenedAndStructItems()
    {
        var source = RequestMarshaller("DoThing");

        // Wrapped scalar list: an empty list emits the bare member name; otherwise {name}.member.{i}.
        Assert.Contains("""request.Parameters.Add("items", "");""", source);
        Assert.Contains("foreach (var item0 in publicRequest.Items)", source);
        Assert.Contains("""request.Parameters.Add("items" + ".member" + "." + index0, StringUtils.FromString(item0));""", source);

        // Flattened list drops the "member" segment and names items by the member @xmlName (Alias).
        Assert.Contains("""request.Parameters.Add("Alias" + "." + index0, StringUtils.FromString(item0));""", source);

        // List of structures: items named by the list value @xmlName (Item), members inlined under the index.
        Assert.Contains("""request.Parameters.Add("structs" + ".Item" + "." + index0 + ".key", StringUtils.FromString(item0.Key));""", source);

        // A list inside a struct item recurses one depth deeper, so its loop locals don't collide with the outer item0/index0.
        Assert.Contains("foreach (var item1 in item0.Names)", source);
        Assert.Contains("""request.Parameters.Add("structs" + ".Item" + "." + index0 + ".names" + ".member" + "." + index1, StringUtils.FromString(item1));""", source);
    }

    [Fact]
    public void Request_Maps_WrappedFlattenedAndMapOfList()
    {
        var source = RequestMarshaller("DoThing");

        // Non-flattened map: {name}.entry.{i}.key / .value, keys always via StringUtils.FromString.
        Assert.Contains("foreach (var kvp0 in publicRequest.Tags)", source);
        Assert.Contains("""request.Parameters.Add("tags" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));""", source);
        Assert.Contains("""request.Parameters.Add("tags" + ".entry" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));""", source);

        // Flattened map drops the "entry" segment: {name}.{i}.key / .value.
        Assert.Contains("""request.Parameters.Add("flatTags" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));""", source);

        // Map whose value is a list: the value expands under a "member"-indexed sub-key.
        Assert.Contains("foreach (var vitem0 in kvp0.Value)", source);
        Assert.Contains("""request.Parameters.Add("scores" + ".entry" + "." + index0 + ".value" + ".member" + "." + vindex0, StringUtils.FromString(vitem0));""", source);
    }

    [Fact]
    public void Request_IdempotencyToken_FillsGuidWhenUnset()
    {
        var source = RequestMarshaller("DoThing");

        Assert.Contains("if (publicRequest.IsSetToken())", source);
        Assert.Contains("""request.Parameters.Add("token", StringUtils.FromString(publicRequest.Token));""", source);
        Assert.Contains("""request.Parameters.Add("token", StringUtils.FromString(Guid.NewGuid().ToString()));""", source);
    }

    [Fact]
    public void Response_WrapperResultAndResponseMetadata()
    {
        var source = ResponseUnmarshaller("DoThing");

        Assert.Contains("public partial class DoThingResponseUnmarshaller : XmlResponseUnmarshaller", source);
        // The outer loop is bounded to the response element's subtree (C2J AWSQueryResponseUnmarshaller.tt).
        Assert.Contains("int targetDepth = context.CurrentDepth;", source);
        Assert.Contains("while (context.ReadAtDepth(targetDepth))", source);
        Assert.Contains("""if (context.TestExpression("DoThingResult", 2))""", source);
        Assert.Contains("UnmarshallResult(context, response);", source);
        Assert.Contains("""if (context.TestExpression("ResponseMetadata", 2))""", source);
        Assert.Contains("response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);", source);
    }

    [Fact]
    public void Response_ResultBodyLoop_ReadsMembers()
    {
        var source = ResponseUnmarshaller("DoThing");

        Assert.Contains("private static void UnmarshallResult(XmlUnmarshallerContext context, DoThingResponse unmarshalledObject)", source);
        Assert.Contains("int originalDepth = context.CurrentDepth;", source);
        Assert.Contains("int targetDepth = originalDepth + 1;", source);
        Assert.Contains("targetDepth += 2;", source);
        // Bounded to the Result subtree so the sibling <ResponseMetadata> is left to the outer loop.
        Assert.Contains("while (context.ReadAtDepth(originalDepth))", source);

        Assert.Contains("""if (context.TestExpression("result", targetDepth))""", source);
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", source);

        // A non-flattened list is matched per item (things/member) and built up incrementally.
        Assert.Contains("""if (context.TestExpression("things/member", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.Things = new List<Thing>();", source);

        // A non-flattened map is matched per entry (props/entry) and built up incrementally (C2J parity), so
        // an empty <props/> leaves it unset rather than reading whole through XmlDictionaryUnmarshaller.
        Assert.Contains("""if (context.TestExpression("props/entry", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.Props = new Dictionary<string, string>();", source);
        Assert.Contains("""new XmlKeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");""", source);
        Assert.DoesNotContain("XmlDictionaryUnmarshaller", source);
    }

    [Fact]
    public void Response_NoOutputMembers_StillEmitsResultDispatchAndMethod()
    {
        var source = ResponseUnmarshaller("NoOutput");

        // C2J emits the Result dispatch and an (empty) UnmarshallResult regardless of member count, so the
        // Result element is always consumed by that loop rather than the outer one.
        Assert.Contains("""if (context.TestExpression("NoOutputResult", 2))""", source);
        Assert.Contains("UnmarshallResult(context, response);", source);
        Assert.Contains("private static void UnmarshallResult(XmlUnmarshallerContext context, NoOutputResponse unmarshalledObject)", source);
        Assert.Contains("while (context.ReadAtDepth(originalDepth))", source);
        // The object parameter is unused with no members, so the analyzer is suppressed (as C2J does).
        Assert.Contains("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "unmarshalledObject")]""", source);
        Assert.Contains("""if (context.TestExpression("ResponseMetadata", 2))""", source);
    }

    [Fact]
    public void Response_WithOutputMembers_OmitsUnusedParameterSuppression()
    {
        var source = ResponseUnmarshaller("DoThing");

        Assert.DoesNotContain("CA1801:ReviewUnusedParameters", source);
    }

    [Fact]
    public void Response_ErrorDispatch()
    {
        var source = ResponseUnmarshaller("DoThing");

        Assert.Contains("ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);", source);
        Assert.Contains("using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))", source);
        Assert.Contains("""if (errorResponse.Code != null && errorResponse.Code.Equals("BadThing"))""", source);
        Assert.Contains("return BadThingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);", source);
        Assert.Contains("return new AmazonExampleException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);", source);
    }

    [Fact]
    public void Response_ErrorDispatch_UsesAwsQueryErrorCustomCode()
    {
        var source = ResponseUnmarshaller("DoThing");

        // @awsQueryError sets the wire Code the client dispatches on, overriding the shape name.
        Assert.Contains("""if (errorResponse.Code != null && errorResponse.Code.Equals("Customized"))""", source);
        Assert.Contains("return CustomCodeErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);", source);
        Assert.DoesNotContain("""errorResponse.Code.Equals("CustomCodeError")""", source);
    }

    [Fact]
    public void StructureUnmarshaller_ReusesXmlWriter()
    {
        var source = new XmlStructureUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[Thing], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class ThingUnmarshaller : IXmlUnmarshaller<Thing, XmlUnmarshallerContext>", source);
        Assert.Contains("""if (context.TestExpression("arn", targetDepth))""", source);
    }

    [Fact]
    public void ExceptionUnmarshaller_ReusesXmlWriter()
    {
        var source = new XmlExceptionUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Errors[BadThing], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class BadThingExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<BadThingException, XmlUnmarshallerContext>", source);

        // awsQuery pins each member match to its depth and bounds the loop to the subtree
        // (AWSQueryExceptionUnmarshaller.tt), so an envelope element sharing a member's name but sitting at
        // another depth is not read into it. restXml keeps its template's depth-less suffix match.
        Assert.Contains("int originalDepth = context.CurrentDepth;", source);
        Assert.Contains("int targetDepth = originalDepth + 1;", source);
        Assert.Contains("targetDepth += 2;", source);
        Assert.Contains("while (context.ReadAtDepth(originalDepth))", source);
        Assert.Contains("""if (context.TestExpression("reason", targetDepth))""", source);
        Assert.DoesNotContain("""if (context.TestExpression("reason"))""", source);

        // The single-arg overload is public API: awsQuery delegates with an empty envelope (returning a
        // non-null exception), where restXml throws. Matches each protocol's C2J template.
        Assert.Contains("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());", source);
        Assert.DoesNotContain("throw new NotImplementedException();", source);
    }
}
