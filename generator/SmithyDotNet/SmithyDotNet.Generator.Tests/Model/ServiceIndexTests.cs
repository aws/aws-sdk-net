using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceIndexTests(CloudTrailModelFixture fixture)
{
    private readonly ServiceIndex _index = fixture.Index;

    [Fact]
    public void Service_IsCloudTrailDataService()
    {
        Assert.Equal("2021-08-11", _index.Service.ApiVersion);
    }

    [Fact]
    public void Operations_ContainsPutAuditEvents()
    {
        Assert.Single(_index.Operations);
        Assert.Equal("operation", _index.Operations[0].Shape.Type);
    }

    [Fact]
    public void Shapes_ExcludesPreludeShapes()
    {
        foreach (var shapeId in _index.Shapes.Keys)
        {
            Assert.False(shapeId.IsPrelude);
        }
    }

    [Fact]
    public void Shapes_ContainsReachableStructures()
    {
        var keys = _index.Shapes.Keys.Select(k => k.Name).ToList();
        Assert.Contains("AuditEvent", keys);
        Assert.Contains("PutAuditEventsRequest", keys);
        Assert.Contains("PutAuditEventsResponse", keys);
    }

    [Fact]
    public void Shapes_ContainsReachableErrors()
    {
        var keys = _index.Shapes.Keys.Select(k => k.Name).ToList();
        Assert.Contains("ChannelNotFound", keys);
        Assert.Contains("InvalidChannelARN", keys);
    }

    [Fact]
    public void Shapes_ContainsTransitivelyReachableShapes()
    {
        var keys = _index.Shapes.Keys.Select(k => k.Name).ToList();
        Assert.Contains("Uuid", keys);
        Assert.Contains("AuditEvents", keys);
        Assert.Contains("ResultErrorEntry", keys);
    }

    [Fact]
    public void Shapes_DoesNotContainServiceOrOperation()
    {
        Assert.All(_index.Shapes.Values, s => Assert.False(s is ServiceShape or OperationShape));
    }

    [Fact]
    public void Shapes_ContainsServiceLevelErrors()
    {
        var index = new ServiceIndex(TestModels.Load("Model/service-index-model.json"));

        Assert.Contains("ServiceError", index.Shapes.Keys.Select(k => k.Name));
    }

    [Fact]
    public void ReachableMixinConsumer_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => new ServiceIndex(TestModels.Load("Model/mixin-reachable-model.json")));

        Assert.Contains("mixins", ex.Message);
        Assert.Contains("DoItInput", ex.Message);
    }

    [Fact]
    public void UnreachableMixinShapes_AreIgnored()
    {
        // Unflattened test models carry mixin definitions/consumers in trait-definition namespaces
        // (smithy.test, aws.protocols); they never enter the closure, so the index builds fine.
        var index = new ServiceIndex(TestModels.Load("Model/mixin-unreachable-model.json"));

        Assert.Single(index.Operations);
    }

    [Fact]
    public void AllEnums_ExcludesUnreachableEnumsOutsideServiceNamespace()
    {
        var index = new ServiceIndex(TestModels.Load("Model/mixin-unreachable-model.json"));
        var enumNames = index.AllEnums.Select(e => e.Id.ToString()).ToList();

        // Reachable enums and same-namespace orphans emit; trait-definition enums do not.
        Assert.Contains("com.example#Status", enumNames);
        Assert.Contains("com.example#OrphanReason", enumNames);
        Assert.DoesNotContain("smithy.test#AppliesTo", enumNames);
    }
}
