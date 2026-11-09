using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>operationModifiers</c> hooks (<c>deprecatedMessage</c>, <c>exclude</c>, <c>useWrappingResult</c>,
/// <c>marshallNameOverrides</c>) and <c>suppressResultGeneration</c>.
/// </summary>
internal static class OperationModifiers
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (operationName, modifier) in customizations.OperationModifiers)
        {
            var shape = FindSingleShape(model, operationName, $"operationModifiers['{operationName}']");
            if (shape is not OperationShape operation)
            {
                throw new GeneratorException($"operationModifiers['{operationName}'] targets a '{shape.Type}' shape, not an operation.");
            }

            if (modifier.DeprecatedMessage is { } message)
            {
                operation.SetDeprecatedMessage(message);
            }

            if (modifier.Exclude)
            {
                ExcludeOperation(model, operation, operationName);
            }

            if (modifier.UseWrappingResult || modifier.WrappedResultShape is not null || modifier.WrappedResultMember is not null)
            {
                WrapOutput(model, operation, operationName, modifier);
            }

            foreach (var (shapeName, properties) in modifier.MarshallNameOverrides.SelectMany(entry => entry))
            {
                if (FindSingleShape(model, shapeName, $"operationModifiers['{operationName}'] marshallNameOverrides") is not StructureShape structure)
                {
                    throw new GeneratorException($"operationModifiers['{operationName}'] overrides marshall names of '{shapeName}', which is not a structure.");
                }
                foreach (var propertyName in properties.Keys)
                {
                    if (!structure.Members.Keys.Any(memberName => customizations.PropertyName(shapeName, memberName) == propertyName))
                    {
                        throw new GeneratorException($"operationModifiers['{operationName}'] overrides the marshall name of '{shapeName}.{propertyName}', which is not a property of the shape.");
                    }
                }
            }
        }

        // The response class is emitted empty, so the output becomes Unit.
        foreach (var operationName in customizations.SuppressResultGeneration)
        {
            var operation = FindOperation(model, operationName, $"suppressResultGeneration['{operationName}']");
            if (customizations.WrapsOutput(operationName))
            {
                throw new GeneratorException($"suppressResultGeneration['{operationName}'] suppresses an output that operationModifiers wraps.");
            }
            model.Shapes[operation.Id.AbsoluteName] = operation with { Output = ShapeId.Unit };
        }
    }

    // Structures are emitted only when reachable from the service's operations, so the ones only this operation used go too.
    private static void ExcludeOperation(SmithyModel model, OperationShape operation, string operationName)
    {
        var unbound = model.Shapes.Values.Sum(shape => shape switch
        {
            ServiceShape service => service.Operations.RemoveAll(id => id == operation.Id),
            ResourceShape resource => resource.Operations.RemoveAll(id => id == operation.Id) + resource.CollectionOperations.RemoveAll(id => id == operation.Id),
            _ => 0,
        });
        if (unbound == 0)
        {
            throw new GeneratorException($"operationModifiers['{operationName}'] excludes an operation that no service or resource lists in its operations; resource lifecycle bindings are not supported.");
        }
    }

    // The response keeps one property, wrappedResultMember, typed as the modeled output: a new structure with that
    // single member becomes the operation's output, and the modeled output turns into an ordinary class.
    // The JSON and CBOR response unmarshallers read that member from the whole body, and PaginationResolver resolves output
    // paths through it.
    private static void WrapOutput(SmithyModel model, OperationShape operation, string operationName, OperationModifier modifier)
    {
        var memberName = modifier.WrappedResultMember;
        if (!modifier.UseWrappingResult || string.IsNullOrWhiteSpace(memberName))
        {
            throw new GeneratorException($"operationModifiers['{operationName}'] needs both useWrappingResult and a wrappedResultMember.");
        }

        if (modifier.WrappedResultShape != operation.Output.Name || model.Shapes.GetValueOrDefault(operation.Output.AbsoluteName) is not { } output)
        {
            throw new GeneratorException($"operationModifiers['{operationName}'] wrappedResultShape must name the output, '{operation.Output.Name}'.");
        }

        var wrapperId = new ShapeId(operation.Id.Namespace, $"{operation.Id.Name}WrappedOutput");
        if (model.Shapes.ContainsKey(wrapperId.AbsoluteName))
        {
            throw new GeneratorException($"operationModifiers['{operationName}'] wraps the output as '{wrapperId}', which is already a shape in the model.");
        }

        var wrapper = new StructureShape { Id = wrapperId };
        wrapper.Members[memberName] = new MemberShape { Target = output.Id };
        model.Shapes[wrapperId.AbsoluteName] = wrapper;

        output.Traits.Remove("smithy.api#output");
        model.Shapes[operation.Id.AbsoluteName] = operation with { Output = wrapperId };
    }
}
