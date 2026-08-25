using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

// Covers a structure member nested inside another structure - previously JsonStructureMarshallerWriter
// and JsonStructureUnmarshallerWriter only handled scalar members, so any structure containing a
// structure, or a list, member had no working {Shape}Marshaller/{Shape}Unmarshaller. Config exercises
// all four kinds a structure member can resolve to: scalar (name), nested structure (detail),
// list<string> (tags), and list<structure> (widgets). PutWidget's request/response also cover the same
// structure type (Config) as a plain (non-@httpPayload, non-list) top-level body member, which the
// request marshaller didn't handle either.
public class StructureMemberCodegenTests
{
    private const string ModelFileName = "nested-structure-model.json";

    private readonly GenerationContext _context;
    private readonly Operation _putWidget;

    public StructureMemberCodegenTests()
    {
        _context = TestModels.Context("Codegen/nested-structure-model.json");
        _putWidget = _context.Operations.Single(o => o.Name == "PutWidget");
    }

    private string ConfigMarshaller => new JsonStructureMarshallerWriter(_context, ModelFileName)
        .Write(_context.Structures[ShapeId.Parse("com.amazonaws.testnested#Config")], ShapeId.Parse("com.amazonaws.testnested#Config"), TestContext.Current.CancellationToken);

    private string ConfigUnmarshaller => new JsonStructureUnmarshallerWriter(_context, ModelFileName)
        .Write(_context.Structures[ShapeId.Parse("com.amazonaws.testnested#Config")], ShapeId.Parse("com.amazonaws.testnested#Config"), TestContext.Current.CancellationToken);

    private string RequestMarshaller => new JsonRequestMarshallerWriter(_context, ModelFileName)
        .Write(_putWidget, TestContext.Current.CancellationToken);

    private string ResponseUnmarshaller => new JsonResponseUnmarshallerWriter(_context, ModelFileName)
        .Write(_putWidget, TestContext.Current.CancellationToken);

    [Fact]
    public void StructureMarshaller_StillMarshalsScalarMembers()
    {
        var marshaller = ConfigMarshaller;
        Assert.Contains("if (requestObject.IsSetName())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("name");""", marshaller);
        Assert.Contains("context.Writer.WriteStringValue(requestObject.Name);", marshaller);
    }

    [Fact]
    public void StructureMarshaller_MarshalsNestedStructureMember()
    {
        var marshaller = ConfigMarshaller;
        Assert.Contains("if (requestObject.IsSetDetail())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("detail");""", marshaller);
        Assert.Contains("var marshaller = DetailMarshaller.Instance;", marshaller);
        Assert.Contains("marshaller.Marshall(requestObject.Detail, context);", marshaller);
    }

    [Fact]
    public void StructureMarshaller_MarshalsStringListMember()
    {
        var marshaller = ConfigMarshaller;
        Assert.Contains("if (requestObject.IsSetTags())", marshaller);
        Assert.Contains("foreach (var requestObjectTagsListValue in requestObject.Tags)", marshaller);
        Assert.Contains("context.Writer.WriteStringValue(requestObjectTagsListValue);", marshaller);
    }

    [Fact]
    public void StructureMarshaller_MarshalsStructureListMember()
    {
        var marshaller = ConfigMarshaller;
        Assert.Contains("if (requestObject.IsSetWidgets())", marshaller);
        Assert.Contains("foreach (var requestObjectWidgetsListValue in requestObject.Widgets)", marshaller);
        Assert.Contains("var marshaller = WidgetMarshaller.Instance;", marshaller);
        Assert.Contains("marshaller.Marshall(requestObjectWidgetsListValue, context);", marshaller);
    }

    [Fact]
    public void StructureUnmarshaller_StillUnmarshalsScalarMembers()
    {
        var unmarshaller = ConfigUnmarshaller;
        Assert.Contains("""if (context.TestExpression("name", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", unmarshaller);
        Assert.Contains("unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);", unmarshaller);
    }

    [Fact]
    public void StructureUnmarshaller_UnmarshalsNestedStructureMember()
    {
        var unmarshaller = ConfigUnmarshaller;
        Assert.Contains("""if (context.TestExpression("detail", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("var unmarshaller = DetailUnmarshaller.Instance;", unmarshaller);
        Assert.Contains("unmarshalledObject.Detail = unmarshaller.Unmarshall(context, ref reader);", unmarshaller);
    }

    [Fact]
    public void StructureUnmarshaller_UnmarshalsStringListMember()
    {
        var unmarshaller = ConfigUnmarshaller;
        Assert.Contains("""if (context.TestExpression("tags", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);", unmarshaller);
        Assert.Contains("unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);", unmarshaller);
    }

    [Fact]
    public void StructureUnmarshaller_UnmarshalsStructureListMember()
    {
        var unmarshaller = ConfigUnmarshaller;
        Assert.Contains("""if (context.TestExpression("widgets", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("var unmarshaller = new JsonListUnmarshaller<Widget, WidgetUnmarshaller>(WidgetUnmarshaller.Instance);", unmarshaller);
        Assert.Contains("unmarshalledObject.Widgets = unmarshaller.Unmarshall(context, ref reader);", unmarshaller);
    }

    [Fact]
    public void RequestMarshaller_MarshalsTopLevelStructureBodyMember()
    {
        // Previously WriteBodyMember had no branch for a plain (non-list, non-@httpPayload)
        // structure-typed body member and threw "Unsupported body member type".
        var marshaller = RequestMarshaller;
        Assert.Contains("if (publicRequest.IsSetConfig())", marshaller);
        Assert.Contains("""context.Writer.WritePropertyName("config");""", marshaller);
        Assert.Contains("var marshaller = ConfigMarshaller.Instance;", marshaller);
        Assert.Contains("marshaller.Marshall(publicRequest.Config, context);", marshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_UnmarshalsTopLevelStructureBodyMember()
    {
        var unmarshaller = ResponseUnmarshaller;
        Assert.Contains("""if (context.TestExpression("config", targetDepth, ref reader))""", unmarshaller);
        Assert.Contains("var unmarshaller = ConfigUnmarshaller.Instance;", unmarshaller);
        Assert.Contains("unmarshalledObject.Config = unmarshaller.Unmarshall(context, ref reader);", unmarshaller);
    }
}
