using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

/// <summary>
/// A Smithy <c>union</c> is generated as a plain structure (all members optional), matching the
/// current SDK. These tests drive an inline model whose operation input references a union and
/// verify it flows through the structure codepath: partitioned into <c>Structures</c>, emitted as a
/// class, and mapped as its class name when referenced by a member.
/// </summary>
public class UnionCodegenTests
{
    private const string ModelFileName = "unions.json";
    private readonly GenerationContext _context;
    private readonly string _union;
    private readonly string _request;
    private readonly ShapeId _unionId;

    public UnionCodegenTests()
    {
        _context = TestModels.Context("Codegen/unions.json");
        _unionId = ShapeId.Parse("com.example#MyUnion");
        var requestId = ShapeId.Parse("com.example#OpRequest");
        var requestShape = _context.Operations.Single(o => o.Name == "Op").Input;
        _union = new StructureWriter(_context, ModelFileName).Write(_context.Structures[_unionId],_unionId,TestContext.Current.CancellationToken);
        _request = new StructureWriter(_context, ModelFileName).Write(requestShape, requestId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void Union_IsPartitionedAsStructure()
    {
        Assert.Contains(_unionId, _context.Structures.Keys);
    }

    [Fact]
    public void Union_EmitsStructureClassWithOptionalMembers()
    {
        Assert.Contains("public partial class MyUnion", _union);
        Assert.Contains("public string StringValue", _union);
        Assert.Contains("public int? IntValue", _union);

        // Union members are mutually exclusive alternatives, so none is required: no [AWSProperty(Required = true)].
        Assert.DoesNotContain("Required = true", _union);
    }

    [Fact]
    public void MemberTargetingUnion_MapsToUnionClassName()
    {
        Assert.Contains("public MyUnion Choice", _request);
    }
}
