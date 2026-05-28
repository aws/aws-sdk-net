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

        var mixinShapes = model.Shapes
            .Where(kvp => kvp.Value is not null && kvp.Value.Traits.ContainsKey("smithy.api#mixin"))
            .Select(kvp => kvp.Key)
            .ToList();

        if (mixinShapes.Count > 0)
        {
            throw new GeneratorException(
                $"Model contains mixin shapes which are not supported:\n" +
                string.Join("\n", mixinShapes.Select(id => $"  - {id}"))
            );
        }
    }
}
