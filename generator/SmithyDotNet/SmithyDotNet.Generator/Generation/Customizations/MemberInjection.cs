using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>shapeModifiers</c> <c>inject</c> hook. An injected member is a real model member, so every writer handles it.
/// Without a <c>location</c>, its <c>locationName</c> is its XML name, from which ec2Query's request and response names
/// derive (upper- and lower-cased, as C2J does).
/// </summary>
internal static class MemberInjection
{
    public static void Apply(SmithyModel model, StructureShape structure, IReadOnlyDictionary<string, MemberShape> modeledMembers, string memberName, PropertyInjector injector, string shapeName, CustomizationsModel customizations)
    {
        var context = $"shapeModifiers['{shapeName}'] injects '{memberName}'";
        var injected = NewMember(model, modeledMembers, injector, context);
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

        if (injector.Documentation is { } documentation)
        {
            injected.SetDocumentation(documentation);
        }
        if (injector.Location is { } location)
        {
            if (location != "header")
            {
                throw new GeneratorException($"{context} with location '{location}'; only 'header' is supported.");
            }
            // A map can't be one @httpHeader; S3's CopyObjectRequest.Headers sends each entry as its own header.
            if (model.Shapes.GetValueOrDefault(injected.Target.AbsoluteName) is MapShape)
            {
                injected.SetHttpPrefixHeaders(injector.LocationName ?? "");
            }
            else
            {
                injected.SetHttpHeader(injector.LocationName ?? memberName);
            }
        }
        else if (injector.LocationName is { } locationName)
        {
            injected.SetXmlName(locationName);
        }
        structure.Members[memberName] = injected;
    }

    private static MemberShape NewMember(SmithyModel model, IReadOnlyDictionary<string, MemberShape> modeledMembers, PropertyInjector injector, string context)
    {
        if (injector.OriginalMemberIsOutsideContainingShape != (injector.OutsideOriginalMember is not null))
        {
            throw new GeneratorException($"{context} sets only one of originalMemberIsOutsideContainingShape and outsideOriginalMember.");
        }

        if (injector.OutsideOriginalMember is { } path)
        {
            if (injector.OriginalMember is not null)
            {
                throw new GeneratorException($"{context} sets both originalMember and outsideOriginalMember.");
            }
            var parts = path.Split(',');
            if (parts.Length != 2
                || FindSingleShape(model, parts[0], $"{context} outsideOriginalMember '{path}'") is not StructureShape outside
                || !outside.Members.TryGetValue(parts[1], out var outsideMember))
            {
                throw new GeneratorException($"{context} copies outsideOriginalMember '{path}', which is not a 'ShapeName,MemberName' of a structure.");
            }
            // C2J copies the member's own JSON, never reading `shape`; checking it against the copy's target catches a
            // stale entry.
            if (FindSingleShapeId(model, injector.Shape, context) != outsideMember.Target)
            {
                throw new GeneratorException($"{context} names shape '{injector.Shape}', but outsideOriginalMember '{path}' targets '{outsideMember.Target.Name}'.");
            }

            // The payload belongs to the containing shape in C2J.
            var copy = outsideMember with { Traits = new(outsideMember.Traits) };
            copy.Traits.Remove("smithy.api#httpPayload");
            return copy;
        }

        var injected = new MemberShape { Target = FindSingleShapeId(model, injector.Shape, context) };
        if (injector.OriginalMember is { } originalName)
        {
            if (!modeledMembers.TryGetValue(originalName, out var original))
            {
                throw new GeneratorException($"{context} with originalMember '{originalName}', which the shape does not exclude.");
            }
            if (original.GetXmlName() is { } xmlName)
            {
                injected.SetXmlName(xmlName);
            }
            if (original.Traits.TryGetValue("smithy.rules#contextParam", out var contextParam))
            {
                injected.Traits["smithy.rules#contextParam"] = contextParam;
            }
        }
        return injected;
    }
}
