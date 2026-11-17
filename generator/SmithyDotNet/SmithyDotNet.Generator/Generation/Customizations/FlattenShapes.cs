using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>flattenShapes</c> hook: an operation input/output's structure <c>@httpPayload</c> member is replaced by its target's
/// members, so they are properties of the request/response class (S3's <c>DeleteObjectsRequest.Objects</c>). Without a
/// payload those members are the body, written under the input's root element, which takes the payload's name. As in C2J,
/// the root is written even when no member is set. The target keeps its class (<see cref="CustomizationsModel.FlattenedTargets"/>).
/// </summary>
internal static class FlattenShapes
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (shapeName, memberNames) in customizations.FlattenShapes)
        {
            if (FindSingleShape(model, shapeName, $"flattenShapes['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"flattenShapes['{shapeName}'] targets a shape that is not a structure.");
            }

            foreach (var memberName in memberNames)
            {
                customizations.FlattenedTargets.Add(Flatten(model, structure, shapeName, memberName));
            }
        }
    }

    private static StructureShape Flatten(SmithyModel model, StructureShape structure, string shapeName, string memberName)
    {
        var context = $"flattenShapes['{shapeName}'] flattens '{memberName}'";
        if (!structure.Members.TryGetValue(memberName, out var payload))
        {
            throw new GeneratorException($"{context}, which the shape does not have.");
        }

        // TODO: C2J flattens any structure member; S3 flattens only structure payloads, the case whose wire is unchanged.
        if (!payload.IsHttpPayload() || model.Shapes.GetValueOrDefault(payload.Target.AbsoluteName) is not StructureShape target || target is UnionShape)
        {
            throw new GeneratorException($"{context}, which is not a structure @httpPayload.");
        }

        // Only the request marshaller writes the root; the response unmarshaller matches the members by depth.
        if (model.Shapes.Values.OfType<OperationShape>().Any(operation => operation.Input == structure.Id))
        {
            // TODO: no S3 payload sets these; the root would need them carried over.
            if (payload.GetXmlNamespace() is not null || target.GetXmlNamespace() is not null || target.GetXmlName() is not null)
            {
                throw new GeneratorException($"{context}, whose @xmlNamespace or target @xmlName is not supported yet.");
            }

            structure.SetXmlName(payload.GetXmlName() ?? target.Id.Name);
        }

        // The members take the payload's place, keeping declaration order for retainOriginalMemberOrdering.
        var members = structure.Members.ToList();
        structure.Members.Clear();
        foreach (var (name, member) in members)
        {
            if (name != memberName)
            {
                structure.Members[name] = member;
                continue;
            }

            foreach (var (flattenedName, flattened) in target.Members)
            {
                if (members.Any(entry => entry.Key == flattenedName))
                {
                    throw new GeneratorException($"{context}, whose member '{flattenedName}' the shape already has.");
                }

                // C2J checks @required against the parent, which never lists a flattened member.
                var copy = flattened with { Traits = new(flattened.Traits) };
                copy.Traits.Remove("smithy.api#required");
                structure.Members[flattenedName] = copy;
            }
        }

        return target;
    }
}
