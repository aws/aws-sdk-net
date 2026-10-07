using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

public class RpcV2CborCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Context = TestModels.Context("Codegen/rpcv2cbor-model.json");
    private static readonly ShapeId Item = ShapeId.Parse("com.example#Item");
    private static readonly ShapeId Broken = ShapeId.Parse("com.example#Broken");

    private static string RequestMarshaller(string operationName) =>
        new CborRequestMarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    private static string ResponseUnmarshaller(string operationName) =>
        new CborResponseUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    [Fact]
    public void Request()
    {
        var source = RequestMarshaller("Put");

        Assert.Contains("""request.Headers["smithy-protocol"] = "rpc-v2-cbor";""", source);
        Assert.Contains("""request.ResourcePath = "service/Example_20230101/operation/Put";""", source);
        Assert.Contains("""request.Headers["Content-Type"] = "application/cbor";""", source);
        Assert.Contains("""request.Headers["Accept"] = "application/cbor";""", source);
        Assert.Contains("""request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";""", source);

        Assert.Contains("var writer = CborWriterPool.Rent();", source);
        Assert.Contains("""context.Writer.WriteTextString("name");""", source);
        Assert.Contains("context.Writer.WriteInt32(publicRequest.Count.Value);", source);
        Assert.Contains("context.Writer.WriteInt64(publicRequest.Big.Value);", source);
        Assert.Contains("context.Writer.WriteBoolean(publicRequest.Flag.Value);", source);
        Assert.Contains("context.Writer.WriteTextString(publicRequest.Color);", source);
        Assert.Contains("context.Writer.WriteDateTime(publicRequest.When.Value);", source);
        Assert.Contains("context.Writer.WriteByteString(publicRequest.Data);", source);
        Assert.Contains("context.Writer.WriteTextString(Guid.NewGuid().ToString());", source);
        Assert.Contains("var marshaller = ItemMarshaller.Instance;", source);
        Assert.Contains("context.Writer.WriteStartArray(publicRequest.Items.Count);", source);
        Assert.Contains("context.Writer.WriteTextString(publicRequestTagsKvp.Key);", source);
        Assert.Contains("context.Writer.WriteNull();", source);

        var unit = RequestMarshaller("Ping");
        Assert.DoesNotContain("Content-Type", unit);
        Assert.DoesNotContain("CborWriterPool", unit);
    }

    [Fact]
    public void StructureMarshaller()
    {
        var source = new CborStructureMarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[Item], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class ItemMarshaller : IRequestMarshaller<Item, CborMarshallerContext>", source);
        Assert.Contains("context.Writer.WriteOptimizedNumber(requestObject.Score.Value);", source);
    }

    [Fact]
    public void Response()
    {
        var source = ResponseUnmarshaller("Put");

        Assert.Contains("public partial class PutResponseUnmarshaller : CborResponseUnmarshaller", source);
        Assert.Contains("reader.ReadStartMap();", source);
        Assert.Contains("""case "count":""", source);
        Assert.Contains("unmarshalledObject.Count = CborNullableIntUnmarshaller.Instance.Unmarshall(context);", source);
        Assert.Contains("unmarshalledObject.When = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);", source);
        Assert.Contains("new CborListUnmarshaller<Item, ItemUnmarshaller>(ItemUnmarshaller.Instance).Unmarshall(context);", source);
        Assert.Contains("new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);", source);
        Assert.Contains("reader.SkipValue();", source);
        Assert.Contains("AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, context.ResponseData);", source);
        Assert.Contains("""if (errorTypeName != null && errorTypeName.Equals("Broken"))""", source);
        Assert.Contains("return BrokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);", source);

        Assert.DoesNotContain("ReadStartMap", ResponseUnmarshaller("Ping"));
    }

    [Fact]
    public void StructureUnmarshaller()
    {
        var source = new CborStructureUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[Item], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class ItemUnmarshaller : ICborUnmarshaller<Item, CborUnmarshallerContext>", source);
        Assert.Contains("if (reader.PeekState() == CborReaderState.Null)", source);
        Assert.Contains("unmarshalledObject.Score = CborNullableFloatUnmarshaller.Instance.Unmarshall(context);", source);
    }

    [Fact]
    public void ExceptionUnmarshaller()
    {
        var source = new CborExceptionUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Errors[Broken], TestContext.Current.CancellationToken);

        Assert.Contains("public partial class BrokenExceptionUnmarshaller : ICborErrorResponseUnmarshaller<BrokenException, CborUnmarshallerContext>", source);
        Assert.Contains("""case "reason":""", source);
        Assert.DoesNotContain("""case "message":""", source);
    }

    [Fact]
    public void RenamedMember_KeepsModeledWireName()
    {
        var customizations = TestCustomizations.Rename("PutRequest", "name", "Label");
        customizations.ShapeModifiers["PutResponse"] = TestCustomizations.RenameMember("count", "Total");
        var context = TestModels.Context(TestModels.Load("Codegen/rpcv2cbor-model.json"), customizations);
        var operation = context.Operations.Single(o => o.Name == "Put");

        var marshaller = new CborRequestMarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);
        Assert.Contains("if (publicRequest.IsSetLabel())", marshaller);
        Assert.Contains("""context.Writer.WriteTextString("name");""", marshaller);

        var unmarshaller = new CborResponseUnmarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);
        Assert.Contains("""case "count":""", unmarshaller);
        Assert.Contains("unmarshalledObject.Total = CborNullableIntUnmarshaller.Instance.Unmarshall(context);", unmarshaller);
    }
}
