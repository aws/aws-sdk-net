using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Validates a Smithy model before generation begins.
/// </summary>
public static class ModelValidator
{
    public static void Validate(SmithyModel model)
    {
        if (model.Version != "2.0")
        {
            throw new GeneratorException($"Unsupported Smithy version '{model.Version}'. This generator requires Smithy 2.0.");
        }

        var serviceCount = model.Shapes.Values.OfType<ServiceShape>().Count();
        if (serviceCount != 1)
        {
            throw new GeneratorException($"Model must contain exactly one service shape, but found {serviceCount}.");
        }

        // Mixins are not rejected here; ServiceIndex rejects them only when reachable from the
        // service. The raw test models carry mixins in their trait-definition namespaces.
    }
}
