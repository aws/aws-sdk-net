using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

/// <summary>
/// Pins the prelude additions for Smithy 1.0 <c>Primitive*</c> shapes and <c>smithy.api#Unit</c>.
/// Models converted from Smithy 1.0 still reference the primitive shapes (bedrock-agent:
/// <c>PrimitiveLong</c>; iotsitewise, omics: <c>PrimitiveBoolean</c>), and a union member
/// targeting <c>Unit</c> (lambda-microvms, bedrock-agentcore, supportauthz, workspaces-web)
/// must produce the per-service empty <c>Unit</c> model class C2J ships — while an operation
/// whose input/output targets <c>Unit</c> must NOT produce one.
/// </summary>
public class UnitAndPrimitiveShapesTests
{
    private const string ModelFileName = "unit-and-primitives-model.json";

    private readonly GenerationContext _context = TestModels.Context("Codegen/unit-and-primitives-model.json");

    [Theory]
    [InlineData("PrimitiveBoolean", typeof(BooleanShape))]
    [InlineData("PrimitiveByte", typeof(ByteShape))]
    [InlineData("PrimitiveShort", typeof(ShortShape))]
    [InlineData("PrimitiveInteger", typeof(IntegerShape))]
    [InlineData("PrimitiveLong", typeof(LongShape))]
    [InlineData("PrimitiveFloat", typeof(FloatShape))]
    [InlineData("PrimitiveDouble", typeof(DoubleShape))]
    public void PreludeShapes_Primitive10Shapes_ResolveToPlainCounterparts(string name, Type shapeType)
    {
        var resolved = PreludeShapes.Resolve(new ShapeId("smithy.api", name));

        Assert.NotNull(resolved);
        Assert.IsType(shapeType, resolved);
    }

    [Fact]
    public void PreludeShapes_Unit_ResolvesAsStructure()
    {
        Assert.IsType<StructureShape>(PreludeShapes.Resolve(ShapeId.Unit));
    }

    [Fact]
    public void StructureWriter_PrimitiveMembers_EmitSamePropertyTypesAsPlainCounterparts()
    {
        var flagsId = ShapeId.Parse("com.example#Flags");
        var structure = new StructureWriter(_context, ModelFileName)
            .Write(_context.Structures[flagsId], flagsId, TestContext.Current.CancellationToken);

        // PrimitiveBoolean/PrimitiveLong map exactly like Boolean/Long — the Smithy 1.0
        // "primitive" distinction was about default values, which don't affect nullability here.
        Assert.Contains("public bool? LegacyBool", structure);
        Assert.Contains("public long? LegacyLong", structure);
        Assert.Contains("public bool? ModernBool", structure);
        Assert.Contains("public long? ModernLong", structure);
    }

    [Fact]
    public void Structures_UnionWithUnitMember_ContainsUnitForModelClassEmission()
    {
        // The union member property (Choice.AllPorts) is typed Unit, so the model-class walk must
        // emit Unit.g.cs — C2J ships the same per-service empty class.
        Assert.True(_context.Structures.ContainsKey(ShapeId.Unit));

        var unit = new StructureWriter(_context, ModelFileName)
            .Write(_context.Structures[ShapeId.Unit], ShapeId.Unit, TestContext.Current.CancellationToken);

        Assert.Contains("public partial class Unit", unit);

        // Empty body: no properties, no IsSet methods.
        Assert.DoesNotContain("{ get; set; }", unit);
        Assert.DoesNotContain("IsSet", unit);
    }

    [Fact]
    public void Structures_UnitReferencedOnlyByOperations_NotCollected()
    {
        // service-with-docid-model.json has one operation with Unit input/output and no union.
        // Unit-as-operation-input/output emits empty Request/Response wrappers via
        // ResolveStructure — never a standalone Unit model class.
        var context = TestModels.Context("Codegen/service-with-docid-model.json");

        Assert.False(context.Structures.ContainsKey(ShapeId.Unit));
    }
}
