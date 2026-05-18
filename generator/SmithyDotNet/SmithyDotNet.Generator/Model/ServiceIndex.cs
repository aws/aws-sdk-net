using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Pre-computes the set of operations and shapes the generator needs to emit code for.
/// <para />
/// Combines operation discovery (similar to Java smithy-model's <c>TopDownIndex</c>) with
/// recursive shape reachability (similar to the C2J generator's shape traversal).
/// <para />
/// Does not yet traverse resources or service-level errors and also assumes the model has been 
/// validated by <see cref="ModelValidator"/>.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/service-types.html" /></remarks>
public class ServiceIndex
{
    /// <summary>The single service shape in the model.</summary>
    public ServiceShape Service { get; }

    /// <summary>All operations reachable from the service.</summary>
    public IReadOnlyList<OperationShape> Operations { get; }

    /// <summary>
    /// All non-prelude shapes reachable from operations (structures, lists, maps, scalars).
    /// Excludes service and operation shapes — those are tracked via <see cref="Service"/> and <see cref="Operations"/>.
    /// Keyed by <see cref="ShapeId"/> for direct lookup from member targets.
    /// </summary>
    public IReadOnlyDictionary<ShapeId, Shape> Shapes { get; }

    public ServiceIndex(SmithyModel model)
    {
        Service = model.Shapes.Values.OfType<ServiceShape>().Single();
        Operations = CollectOperations(model, Service);
        Shapes = CollectReachableShapes(model, Operations);
    }

    private static List<OperationShape> CollectOperations(SmithyModel model, ServiceShape service)
    {
        // TODO: walk service.Resources recursively to collect lifecycle operations
        var operations = new List<OperationShape>();
        foreach (var operationId in service.Operations)
        {
            if (model.Shapes.TryGetValue(operationId.AbsoluteName, out var shape) && shape is OperationShape operation)
            {
                operations.Add(operation);
            }
        }

        return operations;
    }

    private static Dictionary<ShapeId, Shape> CollectReachableShapes(SmithyModel model, IReadOnlyList<OperationShape> operations)
    {
        // TODO: walk service.Errors for service-level error shapes
        var reachable = new Dictionary<ShapeId, Shape>();
        var visited = new HashSet<string>();

        foreach (var operation in operations)
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
