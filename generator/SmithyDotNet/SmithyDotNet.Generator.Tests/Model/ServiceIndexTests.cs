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
        Assert.Equal("operation", _index.Operations[0].Type);
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
        var modelJson = """
        {
          "smithy": "2.0",
          "shapes": {
            "test#TestService": {
              "type": "service",
              "version": "1.0",
              "operations": [],
              "errors": [
                { "target": "test#ServiceError" }
              ]
            },
            "test#ServiceError": {
              "type": "structure",
              "members": {
                "message": { "target": "smithy.api#String" }
              },
              "traits": {
                "smithy.api#error": "server"
              }
            }
          }
        }
        """;

        var model = System.Text.Json.JsonSerializer.Deserialize<SmithyModel>(
            modelJson, CloudTrailModelFixture.Options)!;
        var index = new ServiceIndex(model);

        Assert.Contains("ServiceError", index.Shapes.Keys.Select(k => k.Name));
    }
}
