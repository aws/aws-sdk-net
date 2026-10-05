using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// Covers the <c>dataTypeSwap</c> customization: a member's emitted .NET type, <c>IsSet</c> check,
/// marshaller call and unmarshaller instance come from the customization, in the JSON body and in
/// query/header positions. Swaps the writers can't honor fail loud.
/// </summary>
public class DataTypeSwapCodegenTests
{
    private const string ModelFileName = "datatypeswap-2024-01-01.normal.json";
    private const string IsoMarshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromDateTimeToISO8601WithOptionalMs";
    private const string IsoUnmarshaller = "Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller";
    private static readonly ShapeId WidgetId = ShapeId.Parse("com.amazonaws.datatypeswap#Widget");
    private static readonly DataTypeSwap Unused = new() { Type = "int?", Marshaller = "M", Unmarshaller = "U" };

    private static readonly DataTypeSwap IsoSwap = new() { Type = "DateTime?", Marshaller = IsoMarshaller, Unmarshaller = IsoUnmarshaller };

    private readonly GenerationContext _context;
    private readonly string _structure;
    private readonly string _marshaller;
    private readonly string _unmarshaller;

    public DataTypeSwapCodegenTests()
    {
        // createdAt/stamp/issuedAt: modeled string → DateTime? via the ISO string converter.
        // sizeMillis: modeled long → DateTime? via the epoch-millis converter.
        // retries: modeled integer through a string-returning converter (a JSON string); no Unmarshaller, so reading keeps the modeled one.
        // version: modeled long swapped to a reference type, so no .Value.
        _context = Context(new CustomizationsModel
        {
            DataTypeSwaps =
            {
                ["Widget"] = new()
                {
                    ["createdAt"] = IsoSwap,
                    ["sizeMillis"] = new DataTypeSwap
                    {
                        Type = "DateTime?",
                        Marshaller = "Amazon.Util.AWSSDKUtils.ConvertToUnixEpochMilliseconds",
                        Unmarshaller = "NullableDateTimeEpochLongMillisecondsUnmarshaller",
                    },
                    ["retries"] = new DataTypeSwap { Type = "int?", Marshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromInt" },
                    ["version"] = new DataTypeSwap
                    {
                        Type = "string",
                        Marshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromString",
                        Unmarshaller = "Amazon.Runtime.Internal.Transform.StringUnmarshaller",
                    },
                },
                ["PutRequest"] = new()
                {
                    ["stamp"] = IsoSwap,
                    ["limit"] = new DataTypeSwap
                    {
                        Type = "int?",
                        Marshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromInt",
                        Unmarshaller = "Amazon.Runtime.Internal.Transform.NullableIntUnmarshaller",
                    },
                    ["partSize"] = new DataTypeSwap
                    {
                        Type = "long?",
                        Marshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromLong",
                        Unmarshaller = "Amazon.Runtime.Internal.Transform.NullableLongUnmarshaller",
                    },
                    ["marker"] = new DataTypeSwap { Type = "int?", Marshaller = "Amazon.Runtime.Internal.Util.StringUtils.FromInt" },
                },
                ["PutResponse"] = new() { ["issuedAt"] = IsoSwap },
            },
        });

        var ct = TestContext.Current.CancellationToken;
        var widget = _context.Structures[WidgetId];
        _structure = new StructureWriter(_context, ModelFileName).Write(widget, ct);
        _marshaller = new JsonStructureMarshallerWriter(_context, ModelFileName).Write(widget, ct);
        _unmarshaller = new JsonStructureUnmarshallerWriter(_context, ModelFileName).Write(widget, ct);
    }

    [Fact]
    public void Structure_EmitsSwappedType()
    {
        Assert.Contains("public DateTime? CreatedAt { get; set; }", _structure);
        Assert.Contains("internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;", _structure);
        Assert.Contains("public DateTime? SizeMillis { get; set; }", _structure);
        Assert.Contains("internal bool IsSetSizeMillis() => this.SizeMillis.HasValue;", _structure);
    }

    [Fact]
    public void Marshaller_WrapsValueInConverter_NumberOnlyForEpochMilliseconds()
    {
        Assert.Contains("if (requestObject.IsSetCreatedAt())", _marshaller);
        Assert.Contains($"context.Writer.WriteStringValue({IsoMarshaller}(requestObject.CreatedAt));", _marshaller);
        Assert.Contains("context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochMilliseconds(requestObject.SizeMillis.Value));", _marshaller);
        Assert.Contains("context.Writer.WriteStringValue(Amazon.Runtime.Internal.Util.StringUtils.FromInt(requestObject.Retries.Value));", _marshaller);
        Assert.Contains("context.Writer.WriteStringValue(Amazon.Runtime.Internal.Util.StringUtils.FromString(requestObject.Version));", _marshaller);
    }

    [Fact]
    public void Unmarshaller_UsesSwapUnmarshaller_OrModeledOneWhenOmitted()
    {
        Assert.Contains($"var unmarshaller = {IsoUnmarshaller}.Instance;", _unmarshaller);
        Assert.Contains("unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);", _unmarshaller);
        Assert.Contains("var unmarshaller = NullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;", _unmarshaller);
        Assert.Contains("var unmarshaller = NullableIntUnmarshaller.Instance;", _unmarshaller);
    }

    [Fact]
    public void OperationMembers_ApplySwapInRequestClassMarshallerAndResponseUnmarshaller()
    {
        var ct = TestContext.Current.CancellationToken;
        var operation = _context.Operations.Single();

        var request = new OperationWriter(_context, ModelFileName).WriteRequest(operation, ct);
        var requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName).Write(operation, ct);
        var responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName).Write(operation, ct);

        Assert.Contains("public DateTime? Stamp { get; set; }", request);
        Assert.Contains($"context.Writer.WriteStringValue({IsoMarshaller}(publicRequest.Stamp));", requestMarshaller);
        Assert.Contains($"var unmarshaller = {IsoUnmarshaller}.Instance;", responseUnmarshaller);
        Assert.Contains(".IssuedAt = unmarshaller.Unmarshall(context, ref reader);", responseUnmarshaller);
    }

    // Glacier-style: C2J passes the swapped value straight to the converter, with no .Value.
    [Fact]
    public void QueryAndHeaderMembers_ConvertThroughSwapMarshaller()
    {
        var requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName).Write(_context.Operations.Single(), TestContext.Current.CancellationToken);

        Assert.Contains("""request.Parameters.Add("limit", Amazon.Runtime.Internal.Util.StringUtils.FromInt(publicRequest.Limit));""", requestMarshaller);
        Assert.Contains("""request.Headers["x-amz-part-size"] = Amazon.Runtime.Internal.Util.StringUtils.FromLong(publicRequest.PartSize);""", requestMarshaller);
    }

    // A required modeled string gets string.IsNullOrEmpty, which can't take the swapped int?.
    [Fact]
    public void RequiredQueryMember_Swap_ChecksForNull()
    {
        var requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName).Write(_context.Operations.Single(), TestContext.Current.CancellationToken);

        Assert.Contains("if (publicRequest.Marker == null)", requestMarshaller);
        Assert.DoesNotContain("string.IsNullOrEmpty(publicRequest.Marker)", requestMarshaller);
    }

    // Positions whose writers would ignore the swapped type: a structure, a path label, a host label,
    // an idempotency token (GUID fallback), and a swap to a collection type.
    [Theory]
    [InlineData("widget", "Widget")]
    [InlineData("id", "int?")]
    [InlineData("accountId", "int?")]
    [InlineData("clientToken", "int?")]
    [InlineData("stamp", "List<string>")]
    public void UnsupportedSwap_FailsLoud(string member, string type)
    {
        var customizations = new CustomizationsModel { DataTypeSwaps = { ["PutRequest"] = new() { [member] = Unused with { Type = type } } } };

        var ex = Assert.Throws<GeneratorException>(() => Context(customizations));
        Assert.Contains(member, ex.Message);
    }

    [Fact]
    public void ResponseHeaderMember_Swap_FailsLoud()
    {
        var context = Context(new CustomizationsModel { DataTypeSwaps = { ["PutResponse"] = new() { ["requestId"] = Unused } } });

        var ex = Assert.Throws<GeneratorException>(() => new JsonResponseUnmarshallerWriter(context, ModelFileName).Write(context.Operations.Single(), TestContext.Current.CancellationToken));
        Assert.Contains("RequestId", ex.Message);
    }

    // Member hooks key a renamed structure by its modeled name.
    [Fact]
    public void RenamedStructure_HooksKeyedByModeledName_Apply()
    {
        var context = Context(new CustomizationsModel
        {
            ShapeSubstitutions = { ["Widget"] = new ShapeSubstitution { RenamedShapeName = "Gadget" } },
            DataTypeSwaps = { ["Widget"] = new() { ["createdAt"] = IsoSwap } },
            EmitIsSetProperties = { ["Widget"] = ["retries"] },
        });

        var structure = new StructureWriter(context, ModelFileName).Write(context.Structures[WidgetId], TestContext.Current.CancellationToken);
        Assert.Contains("public partial class Gadget", structure);
        Assert.Contains("public DateTime? CreatedAt { get; set; }", structure);
        Assert.Contains("public bool IsRetriesSet", structure);
    }

    private static GenerationContext Context(CustomizationsModel customizations)
    {
        var model = TestModels.Load("Codegen/datatypeswap-model.json");
        CustomizationTransform.Apply(model, customizations);
        CustomizationTransform.Validate(model, customizations);
        return new GenerationContext(new ServiceIndex(model), TestManifests.Example(), customizations: customizations);
    }
}
