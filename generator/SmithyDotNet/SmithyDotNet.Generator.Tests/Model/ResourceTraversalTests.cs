using System.Text.Json;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

public class ResourceTraversalTests
{
    // A service whose resource tree (Thing -> NestedThing) populates every operation slot a
    // resource has: service-direct, resource-instance (operations), resource-collection
    // (collectionOperations), and all six lifecycle slots (create/put/read/update/delete on
    // Thing, list on NestedThing) — so dropping any slot from the traversal fails a test.
    // SharedOp is listed on both the service and the resource, so de-duplication is exercised.
    private const string ModelJson = """
    {
      "smithy": "2.0",
      "shapes": {
        "com.example#MyService": {
          "type": "service",
          "version": "2023-01-01",
          "operations": [
            { "target": "com.example#DirectOp" },
            { "target": "com.example#SharedOp" }
          ],
          "resources": [{ "target": "com.example#Thing" }]
        },
        "com.example#Thing": {
          "type": "resource",
          "create": { "target": "com.example#CreateThing" },
          "put": { "target": "com.example#PutThing" },
          "read": { "target": "com.example#ReadThing" },
          "update": { "target": "com.example#UpdateThing" },
          "delete": { "target": "com.example#DeleteThing" },
          "operations": [
            { "target": "com.example#TagThing" },
            { "target": "com.example#SharedOp" }
          ],
          "collectionOperations": [{ "target": "com.example#SearchThings" }],
          "resources": [{ "target": "com.example#NestedThing" }]
        },
        "com.example#NestedThing": {
          "type": "resource",
          "list": { "target": "com.example#ListNestedThings" }
        },
        "com.example#DirectOp": { "type": "operation" },
        "com.example#SharedOp": { "type": "operation" },
        "com.example#CreateThing": { "type": "operation" },
        "com.example#PutThing": { "type": "operation" },
        "com.example#ReadThing": { "type": "operation" },
        "com.example#UpdateThing": { "type": "operation" },
        "com.example#DeleteThing": { "type": "operation" },
        "com.example#TagThing": { "type": "operation" },
        "com.example#SearchThings": { "type": "operation" },
        "com.example#ListNestedThings": { "type": "operation" }
      }
    }
    """;

    private static ServiceIndex BuildIndex()
    {
        var model = JsonSerializer.Deserialize<SmithyModel>(ModelJson, CloudTrailModelFixture.Options)!;
        return new ServiceIndex(model);
    }

    [Fact]
    public void CollectsOperationsFromResources_LifecycleInstanceCollectionAndNested()
    {
        var index = BuildIndex();

        Assert.Equal(10, index.Operations.Count);
        var names = index.Operations.Select(operation => operation.Id.Name).ToList();
        Assert.Contains("DirectOp", names);
        Assert.Contains("SharedOp", names);
        Assert.Contains("TagThing", names);
        Assert.Contains("SearchThings", names);
        Assert.Contains("CreateThing", names);
        Assert.Contains("PutThing", names);
        Assert.Contains("ReadThing", names);
        Assert.Contains("UpdateThing", names);
        Assert.Contains("DeleteThing", names);
        Assert.Contains("ListNestedThings", names);
    }

    [Fact]
    public void Operations_AreAlphabeticalByName()
    {
        // Traversal picks operations up in resource-walk order; ServiceIndex sorts before
        // returning to match C2J's alphabetical order. The fixture names are chosen so that walk
        // order differs from alphabetical — this assertion fails if the sort is removed.
        var index = BuildIndex();

        Assert.Equal(
            ["CreateThing", "DeleteThing", "DirectOp", "ListNestedThings", "PutThing", "ReadThing",
                "SearchThings", "SharedOp", "TagThing", "UpdateThing"],
            index.Operations.Select(operation => operation.Id.Name));
    }

    [Fact]
    public void SharedOperation_CollectedOnce()
    {
        // SharedOp is referenced from both the service and the resource; the traversal must not
        // emit it twice.
        var index = BuildIndex();

        Assert.Single(index.Operations, operation => operation.Id.Name == "SharedOp");
    }
}
