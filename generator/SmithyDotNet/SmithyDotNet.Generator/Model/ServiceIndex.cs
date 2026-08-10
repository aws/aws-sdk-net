using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Pre-computes the set of operations and shapes the generator needs to emit code for.
/// <para />
/// Combines operation discovery (similar to Java smithy-model's <c>TopDownIndex</c>) with
/// recursive shape reachability (similar to the C2J generator's shape traversal).
/// <para />
/// Resources are flattened: their lifecycle/instance/collection operations join the service
/// operation list, and the resource shapes themselves are not emitted. Assumes the model has
/// been validated by <see cref="ModelValidator"/>.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/service-types.html" /></remarks>
public class ServiceIndex
{
    /// <summary>The single service shape in the model.</summary>
    public ServiceShape Service { get; }

    /// <summary>The service shape's ID. Its <see cref="ShapeId.Name"/> is the last-resort signing-name fallback.</summary>
    public ShapeId ServiceId { get; }

    /// <summary>
    /// All operations reachable from the service, resource-attached ones included, each paired
    /// with its shape id. Ordered alphabetically by operation name (ordinal), matching the order
    /// C2J emits so review diffs on large services stay stable.
    /// </summary>
    public IReadOnlyList<(ShapeId Id, OperationShape Shape)> Operations { get; }

    /// <summary>
    /// All non-prelude shapes reachable from the service's errors and its operations (structures,
    /// lists, maps, scalars).
    /// Excludes service and operation shapes — those are tracked via <see cref="Service"/> and <see cref="Operations"/>.
    /// Keyed by <see cref="ShapeId"/> for direct lookup from member targets.
    /// </summary>
    public IReadOnlyDictionary<ShapeId, Shape> Shapes { get; }

    public ServiceIndex(SmithyModel model)
    {
        var serviceEntry = model.Shapes.Single(kvp => kvp.Value is ServiceShape);
        if (serviceEntry.Value is not ServiceShape service)
        {
            throw new GeneratorException("Model has no service shape.");
        }

        Service = service;
        ServiceId = ShapeId.Parse(serviceEntry.Key);
        Operations = CollectOperations(model, Service);
        Shapes = CollectReachableShapes(model, Service, Operations);
    }

    private static List<(ShapeId Id, OperationShape Shape)> CollectOperations(SmithyModel model, ServiceShape service)
    {
        var operations = new List<(ShapeId Id, OperationShape Shape)>(service.Operations.Count);
        var seen = new HashSet<string>();

        void AddOperation(ShapeId operationId)
        {
            if (!seen.Add(operationId.AbsoluteName))
            {
                return;
            }

            if (!model.Shapes.TryGetValue(operationId.AbsoluteName, out var shape) || shape is not OperationShape operation)
            {
                throw new GeneratorException($"Service references operation '{operationId}' which is missing or not an operation shape.");
            }

            operations.Add((operationId, operation));
        }

        // Resources are flattened: lifecycle + instance + collection operations all become
        // plain service operations, recursively through nested resources (Java TopDownIndex).
        void WalkResource(ShapeId resourceId, HashSet<string> visited)
        {
            if (!visited.Add(resourceId.AbsoluteName))
            {
                return;
            }

            if (!model.Shapes.TryGetValue(resourceId.AbsoluteName, out var shape) || shape is not ResourceShape resource)
            {
                throw new GeneratorException($"Service references resource '{resourceId}' which is missing or not a resource shape.");
            }

            foreach (var operationId in resource.AllOperations())
            {
                AddOperation(operationId);
            }

            foreach (var nested in resource.Resources)
            {
                WalkResource(nested, visited);
            }
        }

        foreach (var operationId in service.Operations)
        {
            AddOperation(operationId);
        }

        var visitedResources = new HashSet<string>();
        foreach (var resourceId in service.Resources)
        {
            WalkResource(resourceId, visitedResources);
        }

        // C2J emits operations alphabetically, so review diffs on large services stay stable
        // across generator changes.
        operations.Sort((a, b) => StringComparer.Ordinal.Compare(a.Id.Name, b.Id.Name));
        return operations;
    }

    private static Dictionary<ShapeId, Shape> CollectReachableShapes(SmithyModel model, ServiceShape service, IReadOnlyList<(ShapeId Id, OperationShape Shape)> operations)
    {
        var reachable = new Dictionary<ShapeId, Shape>();
        var visited = new HashSet<string>();

        foreach (var errorId in service.Errors)
        {
            WalkShapeId(model, errorId, reachable, visited);
        }

        foreach (var (_, operation) in operations)
        {
            WalkShapeId(model, operation.Input, reachable, visited);
            WalkShapeId(model, operation.Output, reachable, visited);

            foreach (var errorId in operation.Errors)
            {
                WalkShapeId(model, errorId, reachable, visited);
            }
        }

        return reachable;
    }

    private static void WalkShapeId(SmithyModel model, ShapeId shapeId, Dictionary<ShapeId, Shape> reachable, HashSet<string> visited)
    {
        if (shapeId.IsPrelude)
        {
            return;
        }

        var key = shapeId.AbsoluteName;
        if (!visited.Add(key))
        {
            return;
        }

        if (!model.Shapes.TryGetValue(key, out var shape) || shape is null)
        {
            return;
        }

        reachable[shapeId] = shape;

        switch (shape)
        {
            case StructureShape structure:
                foreach (var member in structure.Members.Values)
                {
                    WalkShapeId(model, member.Target, reachable, visited);
                }
                break;

            case ListShape list:
                WalkShapeId(model, list.Member.Target, reachable, visited);
                break;

            case MapShape map:
                WalkShapeId(model, map.Key.Target, reachable, visited);
                WalkShapeId(model, map.Value.Target, reachable, visited);
                break;
        }
    }
}
