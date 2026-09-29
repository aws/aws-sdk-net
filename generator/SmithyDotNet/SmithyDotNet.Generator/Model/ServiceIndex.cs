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
    /// All operations reachable from the service, resource-attached ones included. Ordered
    /// alphabetically by operation name (ordinal), matching the order C2J emits so review diffs on
    /// large services stay stable.
    /// </summary>
    public IReadOnlyList<OperationShape> Operations { get; }

    /// <summary>
    /// All non-prelude shapes reachable from the service's errors and its operations (structures,
    /// lists, maps, scalars).
    /// Excludes service and operation shapes — those are tracked via <see cref="Service"/> and <see cref="Operations"/>.
    /// Keyed by <see cref="ShapeId"/> for direct lookup from member targets.
    /// </summary>
    public IReadOnlyDictionary<ShapeId, Shape> Shapes { get; }

    /// <summary>
    /// Every <c>enum</c> shape that is reachable from an operation or declared in the service's own
    /// namespace. Unreachable same-namespace enums are kept
    /// because C2J ships orphan <c>*ExceptionReason</c> enums that no operation references; enums in
    /// other namespaces (trait definitions like <c>smithy.test#AppliesTo</c> in the raw test models)
    /// are dropped.
    /// </summary>
    public IReadOnlyList<EnumShape> AllEnums { get; }

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
        AllEnums = CollectAllEnums(model, Shapes, ServiceId.Namespace);

        RequireNoMixins();
    }

    /// <summary>
    /// The generated type name for a shape: the service's <c>rename</c> entry when it has one, otherwise
    /// the shape name. Every emitted symbol goes through here; only wire error codes use <see cref="ShapeId.Name"/>,
    /// because a rename does not change the shape ID.
    /// </summary>
    public string ToDotNetName(ShapeId shapeId) => Service.Rename.GetValueOrDefault(shapeId.AbsoluteName, shapeId.Name);

    // The generator does not resolve mixins (production models arrive pre-flattened), so
    // generating from a consumer would silently drop its inherited members. Consumers outside
    // the closure (trait definitions in the raw test models) are ignored.
    private void RequireNoMixins()
    {
        RequireNoMixins(Service);

        foreach (var operation in Operations)
        {
            RequireNoMixins(operation);
        }

        foreach (var shape in Shapes.Values)
        {
            RequireNoMixins(shape);
        }
    }

    private static void RequireNoMixins(Shape shape)
    {
        if (shape.Mixins.Count > 0)
        {
            throw new GeneratorException($"Shape '{shape.Id}' is reachable from the service and uses mixins, which are not supported.");
        }
    }

    private static List<EnumShape> CollectAllEnums(SmithyModel model, IReadOnlyDictionary<ShapeId, Shape> reachable, string serviceNamespace)
    {
        var enums = new List<EnumShape>();
        foreach (var shape in model.Shapes.Values)
        {
            if (shape is not EnumShape enumShape)
            {
                continue;
            }

            // An unreachable enum emits only from the service's own namespace: C2J ships orphan
            // *ExceptionReason enums, but trait-definition enums (smithy.test#AppliesTo) must not emit.
            if (reachable.ContainsKey(enumShape.Id) || enumShape.Id.Namespace == serviceNamespace)
            {
                enums.Add(enumShape);
            }
        }

        return enums;
    }

    private static List<OperationShape> CollectOperations(SmithyModel model, ServiceShape service)
    {
        var operations = new List<OperationShape>(service.Operations.Count);
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

            RequireNoMixins(operation);
            operations.Add(operation);
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

    private static Dictionary<ShapeId, Shape> CollectReachableShapes(SmithyModel model, ServiceShape service, IReadOnlyList<OperationShape> operations)
    {
        var reachable = new Dictionary<ShapeId, Shape>();
        var visited = new HashSet<string>();

        foreach (var errorId in service.Errors)
        {
            WalkShapeId(model, errorId, reachable, visited);
        }

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

        RequireNoMixins(shape);
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
