using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>shapeModifiers</c> hooks: <c>deprecatedMessage</c>, <c>exclude</c>, <c>inject</c> (see
/// <see cref="MemberInjection"/>) and the member <c>modify</c> entries, including the <c>*</c> entry for every structure.
/// </summary>
internal static class ShapeModifiers
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        if (customizations.ShapeModifiers.Remove("*", out var global))
        {
            ExpandGlobal(model, global, customizations);
        }

        foreach (var (shapeName, modifier) in customizations.ShapeModifiers)
        {
            var shape = FindSingleShape(model, shapeName, $"shapeModifiers['{shapeName}']");

            if (modifier.DeprecatedMessage is { } shapeMessage)
            {
                shape.SetDeprecatedMessage(shapeMessage);
            }

            // TODO: S3's excludeFromMarshalling and excludeFromUnmarshalling keep the member on the class but off the
            // wire, so they need a marshalling-level flag rather than this removal.
            foreach (var memberName in modifier.Exclude)
            {
                if (shape is not StructureShape excluded || !excluded.Members.Remove(memberName))
                {
                    throw new GeneratorException($"shapeModifiers['{shapeName}'] excludes member '{memberName}', which the shape does not have.");
                }
            }

            foreach (var (memberName, injector) in modifier.Inject.SelectMany(entry => entry))
            {
                if (shape is not StructureShape target)
                {
                    throw new GeneratorException($"shapeModifiers['{shapeName}'] injects '{memberName}' into a '{shape.Type}' shape; only structures are supported.");
                }
                MemberInjection.Apply(model, target, memberName, injector, shapeName, customizations);
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
                        ApplyMember(structure, memberName, property, shapeName, customizations);
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
    }

    // "*" modifies a member of that name in every structure, unless the structure's own entry modifies it, so it
    // becomes one entry per structure.
    private static void ExpandGlobal(SmithyModel model, ShapeModifier global, CustomizationsModel customizations)
    {
        if (global.Exclude.Count > 0 || global.DeprecatedMessage is not null)
        {
            throw new GeneratorException("shapeModifiers['*'] only supports modify.");
        }

        foreach (var (memberName, property) in global.Modify.SelectMany(entry => entry))
        {
            var found = false;
            foreach (var structure in model.Shapes.Values.OfType<StructureShape>())
            {
                if (!structure.Members.ContainsKey(memberName))
                {
                    continue;
                }

                found = true;
                ModifyEntry(ModifierFor(customizations, structure.Id.Name), memberName, property);
            }

            if (!found)
            {
                throw new GeneratorException($"shapeModifiers['*'] modifies member '{memberName}', which no structure has.");
            }
        }
    }

    internal static ShapeModifier ModifierFor(CustomizationsModel customizations, string shapeName)
    {
        if (!customizations.ShapeModifiers.TryGetValue(shapeName, out var modifier))
        {
            modifier = new ShapeModifier();
            customizations.ShapeModifiers[shapeName] = modifier;
        }
        return modifier;
    }

    // The modify entry for memberName, added with `property` when the shape has none.
    internal static Dictionary<string, PropertyModifier> ModifyEntry(ShapeModifier modifier, string memberName, PropertyModifier property)
    {
        var entry = modifier.Modify.FirstOrDefault(entry => entry.ContainsKey(memberName));
        if (entry is null)
        {
            entry = new Dictionary<string, PropertyModifier>();
            entry[memberName] = property;
            modifier.Modify.Add(entry);
        }
        return entry;
    }

    private static void ApplyMember(StructureShape structure, string memberName, PropertyModifier property, string shapeName, CustomizationsModel customizations)
    {
        if (!structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"shapeModifiers['{shapeName}'] modifies member '{memberName}', which the shape does not have.");
        }

        if (property.DeprecatedMessage is { } message)
        {
            member.SetDeprecatedMessage(message);
        }

        // C2J upper-cases the name and ranks it above the modeled query name, which is exactly what ec2QueryName is.
        if (property.LocationName is { } locationName)
        {
            member.SetEc2QueryName(SdkNaming.ToUpperFirstCharacter(locationName));
        }

        if (property.AccessModifier is not (null or "internal"))
        {
            throw new GeneratorException($"shapeModifiers['{shapeName}'] gives member '{memberName}' access modifier '{property.AccessModifier}'; only 'internal' is supported.");
        }

        // The rename stays out of the model (CustomizationsModel.PropertyName applies it), so these only check it.
        if (property.EmitPropertyName is { } newName && newName != memberName)
        {
            // TODO: C2J sends a renamed event under its new name, which the service wouldn't recognize; no
            // service renames one, so neither behavior is picked until one does.
            if (structure is UnionShape && structure.IsStreaming())
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames event '{memberName}' of an event stream, which is not supported.");
            }

            // Compare property names, not keys: 'expiry' and a rename to 'Expiry' both emit 'Expiry'.
            var propertyName = customizations.PropertyName(shapeName, memberName);
            if (structure.Members.Keys.Any(k => k != memberName && customizations.PropertyName(shapeName, k) == propertyName))
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames '{memberName}' to '{newName}', which the shape already has.");
            }
        }
    }
}
