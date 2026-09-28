using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

/// <summary>
/// Covers every member kind DynamoDB's <c>emitIsSetProperties</c> lists, against a model mirroring its
/// shapes: a union's nullable bool, lists of string/blob/structure, and a map (AttributeValue), a
/// response map (GetItemOutput), and request integers (QueryInput, ScanInput).
/// </summary>
public class EmitIsSetPropertiesTests
{
    private const string ModelPath = "Codegen/emit-isset-model.json";
    private const string ModelFileName = "dynamodb-2012-08-10.normal.json";

    // The existing DynamoDB customization, verbatim.
    private static Dictionary<string, List<string>> DynamoDbEmitIsSet() => new()
    {
        ["AttributeValue"] = ["BOOL", "M", "L", "SS", "BS", "NS"],
        ["GetItemOutput"] = ["Item"],
        ["QueryInput"] = ["Limit"],
        ["ScanInput"] = ["Limit", "Segment", "TotalSegments"],
    };

    // Same order as BatchGenerator: the transform marks the members before the index is built.
    private static GenerationContext Context(Dictionary<string, List<string>> emitIsSet)
    {
        var model = TestModels.Load(ModelPath);
        var customizations = new CustomizationsModel { EmitIsSetProperties = emitIsSet };
        CustomizationTransform.Apply(model, customizations);
        return new(new ServiceIndex(model), TestManifests.Example(), customizations: customizations);
    }

    private static string WriteAttributeValue(GenerationContext context)
    {
        var shapeId = ShapeId.Parse("com.amazonaws.dynamodb#AttributeValue");
        return new StructureWriter(context, ModelFileName).Write(context.Structures[shapeId], shapeId, TestContext.Current.CancellationToken);
    }

    private static string WriteRequest(GenerationContext context, string operation) =>
        new OperationWriter(context, ModelFileName).WriteRequest(context.Operations.Single(o => o.Name == operation), TestContext.Current.CancellationToken);

    private static string WriteResponse(GenerationContext context, string operation) =>
        new OperationWriter(context, ModelFileName).WriteResponse(context.Operations.Single(o => o.Name == operation), TestContext.Current.CancellationToken);

    private static void AssertEmitsIsSetFlag(string code, string property, string type)
    {
        // SetIsSet needs the value by ref, so the property is backed by a field instead of an auto-property.
        Assert.Contains($"private {type} _{property}", code);
        Assert.Contains($"public {type} {property} {{ get => this._{property}; set => this._{property} = value; }}", code);

        Assert.Contains($"public bool Is{property}Set", code);
        Assert.Contains($"get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._{property});", code);
        Assert.Contains($"set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._{property});", code);
        Assert.Contains($"""/// This property is set to true if the property <seealso cref="{property}"/>""", code);
        Assert.Contains($"""/// If this property is set to false the property <seealso cref="{property}"/> will be reset to null.""", code);
        Assert.Contains($"internal bool IsSet{property}() => this.Is{property}Set;", code);
    }

    private static void AssertNoPublicIsSetFlag(string code, string property)
    {
        Assert.DoesNotContain($"Is{property}Set", code);
        Assert.Contains($"internal bool IsSet{property}() =>", code);
    }

    [Theory]
    [InlineData("BOOL", "bool?")]
    [InlineData("M", "Dictionary<string, AttributeValue>")]
    [InlineData("L", "List<AttributeValue>")]
    [InlineData("SS", "List<string>")]
    [InlineData("NS", "List<string>")]
    [InlineData("BS", "List<MemoryStream>")]
    public void UnionMember_Listed_EmitsIsSetFlag(string property, string type)
    {
        AssertEmitsIsSetFlag(WriteAttributeValue(Context(DynamoDbEmitIsSet())), property, type);
    }

    [Fact]
    public void UnionCollectionMember_Listed_KeepsInitializeCollectionsInitializer()
    {
        var code = WriteAttributeValue(Context(DynamoDbEmitIsSet()));

        Assert.Contains("private List<string> _SS = AWSConfigs.InitializeCollections ? new List<string>() : null;", code);
        Assert.Contains("private Dictionary<string, AttributeValue> _M = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;", code);
    }

    [Theory]
    [InlineData("S")]
    [InlineData("N")]
    [InlineData("B")]
    [InlineData("NULL")]
    public void UnionMember_Unlisted_KeepsDefaultIsSet(string property)
    {
        AssertNoPublicIsSetFlag(WriteAttributeValue(Context(DynamoDbEmitIsSet())), property);
    }

    [Fact]
    public void ResponseMapMember_Listed_EmitsIsSetFlag()
    {
        AssertEmitsIsSetFlag(WriteResponse(Context(DynamoDbEmitIsSet()), "GetItem"), "Item", "Dictionary<string, AttributeValue>");
    }

    [Fact]
    public void RequestIntegerMember_Listed_EmitsIsSetFlag_SiblingsUntouched()
    {
        var code = WriteRequest(Context(DynamoDbEmitIsSet()), "Query");

        AssertEmitsIsSetFlag(code, "Limit", "int?");
        AssertNoPublicIsSetFlag(code, "TableName");
    }

    [Theory]
    [InlineData("Limit")]
    [InlineData("Segment")]
    [InlineData("TotalSegments")]
    public void RequestIntegerMembers_AllListed_EachEmitsIsSetFlag(string property)
    {
        AssertEmitsIsSetFlag(WriteRequest(Context(DynamoDbEmitIsSet()), "Scan"), property, "int?");
    }

    [Fact]
    public void RequestMarshaller_StillGatesOnIsSetMethod()
    {
        // The marshaller calls IsSet{Property}(), which now reads the flag, so an explicitly set flag is
        // honored on the wire without a marshaller change.
        var context = Context(DynamoDbEmitIsSet());
        var operation = context.Operations.Single(o => o.Name == "Query");
        var code = new JsonRequestMarshallerWriter(context, ModelFileName).Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("IsSetLimit()", code);
    }

    [Fact]
    public void CustomizationKey_IsModeledShapeName_NotDotNetClassName()
    {
        // Keys are the model's shape name (QueryInput), not the generated class name (QueryRequest);
        // a key that matches nothing is stale and fails rather than silently not applying.
        var ex = Assert.Throws<GeneratorException>(() => Context(new() { ["QueryRequest"] = ["Limit"] }));
        Assert.Contains("emitIsSetProperties['QueryRequest'] does not match any shape", ex.Message);
    }

    [Fact]
    public void MemberName_IsModeledName_CaseSensitive()
    {
        var ex = Assert.Throws<GeneratorException>(() => Context(new() { ["QueryInput"] = ["limit"] }));
        Assert.Contains("lists member 'limit', which the shape does not have", ex.Message);
    }

    [Fact]
    public void ListedMemberWithoutSetIsSetOverload_Throws()
    {
        // A string has no InternalSDKUtils.SetIsSet overload; emitting the flag would not compile.
        var context = Context(new() { ["AttributeValue"] = ["S"] });

        var ex = Assert.Throws<GeneratorException>(() => WriteAttributeValue(context));
        Assert.Contains("emitIsSetProperties lists member 'S'", ex.Message);
    }
}
