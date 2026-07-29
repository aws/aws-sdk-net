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
        _context = fixture.Context;
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
    public void ApiVersion_DerivedFromServiceShape()
    {
        Assert.Equal("2021-08-11", _context.ApiVersion);
    }

    [Fact]
    public void EndpointPrefix_DerivedFromAwsServiceTrait()
    {
        Assert.Equal("cloudtrail-data", _context.EndpointPrefix);
    }

    [Fact]
    public void HasEndpointContextParams_IsFalseForCloudTrailData()
    {
        // CloudTrailData uses no context params. If detection over-fires, the resolver writer throws
        // and no real service can be generated, so guard the common case explicitly.
        Assert.False(_context.HasEndpointContextParams);
    }

    [Fact]
    public void HasEndpointTests_IsTrueForCloudTrailData()
    {
        Assert.True(_context.HasEndpointTests);
        Assert.NotNull(_context.EndpointTests);
        Assert.Equal(21, _context.EndpointTests.TestCases.Count);
    }

    [Fact]
    public void ServiceDocumentation_IsPopulatedFromServiceShape()
    {
        Assert.NotNull(_context.ServiceDocumentation);
        Assert.Contains("CloudTrail Data Service", _context.ServiceDocumentation);
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
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsInput());
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsOutput());
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsError());
    }

    [Fact]
    public void Errors_ContainsSixExceptions()
    {
        Assert.Equal(6, _context.Errors.Count);
    }

    [Fact]
    public void Structures_AreOrderedByShapeId()
    {
        var keys = _context.Structures.Keys.Select(id => id.AbsoluteName).ToList();
        Assert.Equal(keys.OrderBy(k => k, StringComparer.Ordinal), keys);
    }

    [Fact]
    public void Errors_AreOrderedByShapeId()
    {
        var keys = _context.Errors.Keys.Select(id => id.AbsoluteName).ToList();
        Assert.Equal(keys.OrderBy(k => k, StringComparer.Ordinal), keys);
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
