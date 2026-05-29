using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

[Collection(nameof(CloudTrailModelCollection))]
public class GenerationContextTests
{
    private readonly GenerationContext _context;

    public GenerationContextTests(CloudTrailModelFixture fixture)
    {
        var index = new ServiceIndex(fixture.Model);
        _context = new GenerationContext(index);
    }

    [Fact]
    public void Namespace_DerivedFromSdkId()
    {
        Assert.Equal("Amazon.CloudTrailData", _context.Namespace);
    }

    [Fact]
    public void ClientName_DerivedFromSdkId()
    {
        Assert.Equal("AmazonCloudTrailData", _context.ClientName);
    }

    [Fact]
    public void Protocol_IsRestJson1()
    {
        Assert.Equal(AWSProtocol.RestJson1, _context.Protocol);
    }

    [Fact]
    public void Operations_ContainsPutAuditEvents()
    {
        var op = Assert.Single(_context.Operations);
        Assert.Equal("PutAuditEvents", op.Name);
    }

    [Fact]
    public void Structures_ExcludesInputOutputAndErrors()
    {
        Assert.Equal(5, _context.Structures.Count);
        Assert.DoesNotContain(_context.Structures, s => s.IsInput());
        Assert.DoesNotContain(_context.Structures, s => s.IsOutput());
        Assert.DoesNotContain(_context.Structures, s => s.IsError());
    }

    [Fact]
    public void Errors_ContainsSixExceptions()
    {
        Assert.Equal(6, _context.Errors.Count);
    }

    [Fact]
    public void Resolve_ReturnsCorrectShape()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent");
        var shape = _context.Resolve(id);
        Assert.NotNull(shape);
    }

    [Fact]
    public void ToDotNetName_ReturnsShapeName()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.Equal("AuditEvent", _context.ToDotNetName(id));
    }
}
