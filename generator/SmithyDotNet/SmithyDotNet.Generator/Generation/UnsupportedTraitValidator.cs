using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Rejects models that use traits the C2J generator handles but this generator does not yet.
/// Unknown/future traits pass through (same as C2J).
/// </summary>
public static class UnsupportedTraitValidator
{
    private static readonly Dictionary<string, string> DeniedTraits = new()
    {
        ["smithy.api#httpPrefixHeaders"] = "@httpPrefixHeaders",
        ["smithy.api#httpResponseCode"] = "@httpResponseCode",
        ["smithy.api#httpChecksumRequired"] = "@httpChecksumRequired",
        ["smithy.api#requestCompression"] = "@requestCompression",
        ["aws.protocols#awsQueryCompatible"] = "awsQueryCompatible",
        ["aws.protocols#httpChecksum"] = "httpChecksum",
    };

    // These live on a member's resolved *target* shape (the list/blob/union/string declaration), not
    // on the member reference, so they need CollectDeniedOnMemberTargets instead of CollectDenied.
    // @mediaType marks a base64-encoded (C2J jsonvalue) string that nothing decodes yet, so a model
    // carrying it must fail loud rather than emit the raw header/body value.
    private static readonly Dictionary<string, string> DeniedTargetTraits = new()
    {
        ["smithy.api#sparse"] = "@sparse",
        ["smithy.api#streaming"] = "@streaming",
        ["smithy.api#mediaType"] = "@mediaType",
    };

    /// <summary>
    /// Checks service, operation, and top-level input/output/error member traits and throws a
    /// single aggregated <see cref="GeneratorException"/> listing every denied trait found.
    /// Nested members are not scanned because all denied traits are only spec-valid at the
    /// top level or above. Call before generation begins.
    /// </summary>
    public static void Validate(ServiceIndex index)
    {
        var found = new HashSet<string>();
        CollectDenied(index.Service.Traits, DeniedTraits, found);

        foreach (var (opId, op) in index.Operations)
        {
            CollectDenied(op.Traits, DeniedTraits, found);

            if (index.Shapes.TryGetValue(op.Input, out var inputShape) && inputShape is StructureShape input)
            {
                CollectDeniedOnMembers(input, found);
                CollectDeniedOnMemberTargets(input, index.Shapes, found);
            }

            if (index.Shapes.TryGetValue(op.Output, out var outputShape) && outputShape is StructureShape output)
            {
                CollectDeniedOnMembers(output, found);
                CollectDeniedOnMemberTargets(output, index.Shapes, found);
            }

            foreach (var errorId in op.Errors)
            {
                if (index.Shapes.TryGetValue(errorId, out var errorShape) && errorShape is StructureShape error)
                {
                    CollectDeniedOnMembers(error, found);
                    CollectDeniedOnMemberTargets(error, index.Shapes, found);
                }
            }
        }

        if (found.Count > 0)
        {
            throw new GeneratorException("Model uses trait(s) not supported yet: " + string.Join(", ", found));
        }
    }

    private static void CollectDenied(Dictionary<string, JsonElement> traits, Dictionary<string, string> denied, HashSet<string> found)
    {
        foreach (var (traitId, label) in denied)
        {
            if (traits.ContainsKey(traitId))
            {
                found.Add(label);
            }
        }
    }

    private static void CollectDeniedOnMembers(StructureShape structure, HashSet<string> found)
    {
        foreach (var (_, member) in structure.Members)
        {
            CollectDenied(member.Traits, DeniedTraits, found);
        }
    }

    private static void CollectDeniedOnMemberTargets(StructureShape structure, IReadOnlyDictionary<ShapeId, Shape> shapes, HashSet<string> found)
    {
        foreach (var (_, member) in structure.Members)
        {
            if (shapes.TryGetValue(member.Target, out var target))
            {
                CollectDenied(target.Traits, DeniedTargetTraits, found);
            }
        }
    }
}
