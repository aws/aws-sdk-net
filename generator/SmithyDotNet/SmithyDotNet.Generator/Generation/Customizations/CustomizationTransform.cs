using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// Applies model-shaped customization hooks to the Smithy model in place, before the
/// <see cref="ServiceIndex"/> is built, so writers stay ignorant of customizations.
/// A stale shape/member reference throws — it must fail the build, not silently stop applying.
/// </summary>
public static class CustomizationTransform
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (shapeName, modifier) in customizations.ShapeModifiers)
        {
            var shape = FindSingleShape(model, shapeName, $"shapeModifiers['{shapeName}']");

            if (modifier.DeprecatedMessage is { } shapeMessage)
            {
                shape.SetDeprecatedMessage(shapeMessage);
            }

            // The structure/enum restriction only bites member modifications - a shape-level hook (e.g.
            // deprecatedMessage on a string shape) applies to any shape.
            if (modifier.Modify.Count == 0)
            {
                continue;
            }

            switch (shape)
            {
                case StructureShape structure:
                    foreach (var (memberName, property) in modifier.Modify.SelectMany(entry => entry))
                    {
                        ApplyMember(structure, memberName, property, shapeName);
                    }
                    break;
                case EnumShape:
                    // Enum entries are keyed by wire value and applied (with the stale-reference
                    // check) by TypeMapper.ResolveEnumMembers, where the constant names are derived.
                    break;
                default:
                    throw new GeneratorException($"shapeModifiers['{shapeName}'] modifies members of a '{shape.Type}' shape; only structures and enums are supported.");
            }
        }

        foreach (var (operationName, modifier) in customizations.OperationModifiers)
        {
            var shape = FindSingleShape(model, operationName, $"operationModifiers['{operationName}']");
            if (shape is not OperationShape)
            {
                throw new GeneratorException($"operationModifiers['{operationName}'] targets a '{shape.Type}' shape, not an operation.");
            }

            if (modifier.DeprecatedMessage is { } message)
            {
                shape.SetDeprecatedMessage(message);
            }
        }
    }

    // Customizations key shapes by bare name (C2J has no namespaces).
    private static Shape FindSingleShape(SmithyModel model, string bareName, string context)
    {
        var matches = model.Shapes.Keys.Where(k => ShapeId.Parse(k).Name == bareName).ToList();
        if (matches.Count != 1)
        {
            throw new GeneratorException(matches.Count == 0
                ? $"{context} does not match any shape in the model."
                : $"{context} matches more than one shape: {string.Join(", ", matches)}.");
        }

        return model.Shapes[matches[0]] ?? throw new GeneratorException($"{context} matched a null shape entry '{matches[0]}'.");
    }

    private static void ApplyMember(StructureShape structure, string memberName, PropertyModifier property, string shapeName)
    {
        if (!structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"shapeModifiers['{shapeName}'] modifies member '{memberName}', which the shape does not have.");
        }

        if (property.DeprecatedMessage is { } message)
        {
            member.SetDeprecatedMessage(message);
        }

        if (property.EmitPropertyName is { } newName && newName != memberName)
        {
            // C2J uses emitPropertyName verbatim, but the property name derives from the member key
            // via ToUpperFirstCharacter — a name that call would alter can't be honored.
            if (SdkNaming.ToUpperFirstCharacter(newName) != newName)
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames '{memberName}' to '{newName}', which would not be emitted verbatim.");
            }

            // Compare property names, not keys: 'expiry' and a rename to 'Expiry' both emit 'Expiry'.
            if (structure.Members.Keys.Any(k => k != memberName && SdkNaming.ToUpperFirstCharacter(k) == newName))
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames '{memberName}' to '{newName}', which the shape already has.");
            }

            structure.Members[newName] = member;

            // The JSON body wire name falls back to the member name; pin the original before the rename changes it.
            if (member.GetJsonName() is null)
            {
                member.SetJsonName(memberName);
            }

            structure.Members.Remove(memberName);
        }
    }
}
