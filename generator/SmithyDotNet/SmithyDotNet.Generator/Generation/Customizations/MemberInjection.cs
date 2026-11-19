using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>shapeModifiers</c> <c>inject</c> hook. An injected member is a real model member, so every writer handles it. Its
/// <c>locationName</c> is its XML name, from which ec2Query's request and response names derive (upper- and lower-cased,
/// as C2J does).
/// </summary>
internal static class MemberInjection
{
    public static void Apply(SmithyModel model, StructureShape structure, string memberName, PropertyInjector injector, string shapeName, CustomizationsModel customizations)
    {
        var context = $"shapeModifiers['{shapeName}'] injects '{memberName}'";
        if (structure.Members.Remove(memberName, out var modeled))
        {
            // C2J allows the name when the modeled member is renamed away (ec2's LaunchSpecification.SecurityGroups is
            // emitted as AllSecurityGroups). Members are keyed by name here, so the modeled one moves to its emitted name,
            // taking its wire name and its modify entry along.
            var emittedName = customizations.EmittedName(shapeName, memberName);
            if (emittedName == memberName || structure.Members.ContainsKey(emittedName))
            {
                throw new GeneratorException($"{context}, which the shape already has.");
            }
            var moved = modeled with { Traits = new(modeled.Traits) };
            if (moved.GetXmlName() is null)
            {
                moved.SetXmlName(memberName);
            }
            structure.Members[emittedName] = moved;

            var entry = ShapeModifiers.ModifyEntry(customizations.ShapeModifiers[shapeName], memberName, new PropertyModifier());
            entry[emittedName] = entry[memberName] with { EmitPropertyName = null };
            entry.Remove(memberName);
        }

        var injected = new MemberShape { Target = FindSingleShapeId(model, injector.Shape, context) };
        if (injector.Documentation is { } documentation)
        {
            injected.SetDocumentation(documentation);
        }
        if (injector.LocationName is { } locationName)
        {
            injected.SetXmlName(locationName);
        }
        structure.Members[memberName] = injected;
    }
}
