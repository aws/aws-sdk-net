using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Rejects models that use traits the C2J generator handles but this generator does not yet.
/// Unknown/future traits pass through (same as C2J).
/// </summary>
public static class UnsupportedTraitValidator
{
    private static readonly Dictionary<string, string> DeniedTraits = new()
    {
        ["smithy.api#httpChecksumRequired"] = "@httpChecksumRequired",
        ["smithy.api#requestCompression"] = "@requestCompression",
        ["aws.protocols#awsQueryCompatible"] = "awsQueryCompatible",
        ["aws.protocols#httpChecksum"] = "httpChecksum",
    };

    // Live on a member's resolved *target* shape, not the member reference.
    // Kept empty because future protocols may deny target-level traits again.
    private static readonly Dictionary<string, string> DeniedTargetTraits = new();

    /// <summary>
    /// Checks service, operation, top-level input/output/error member, and reachable-shape traits
    /// and throws a single aggregated <see cref="GeneratorException"/> listing every denied trait
    /// found. Call before generation begins.
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
            }

            if (index.Shapes.TryGetValue(op.Output, out var outputShape) && outputShape is StructureShape output)
            {
                CollectDeniedOnMembers(output, found);
            }

            foreach (var errorId in op.Errors)
            {
                if (index.Shapes.TryGetValue(errorId, out var errorShape) && errorShape is StructureShape error)
                {
                    CollectDeniedOnMembers(error, found);
                }
            }
        }

        //do one more sweep of errors that are potentially only listed on the service and not the operation
        foreach (var errorId in index.Service.Errors)
        {
            if (index.Shapes.TryGetValue(errorId, out var errorShape) && errorShape is StructureShape error)
            {
                CollectDeniedOnMembers(error, found);
            }
        }

        // index.Shapes is every shape reachable from an operation/error at any depth, so this one
        // pass covers DeniedTargetTraits regardless of nesting.
        foreach (var shape in index.Shapes.Values)
        {
            CollectDenied(shape.Traits, DeniedTargetTraits, found);

            // @streaming is supported only on a blob (an @httpPayload Stream); on a union it marks an
            // event stream, which nothing handles yet, so fail loud there.
            if (shape is not BlobShape && shape.IsStreaming())
            {
                found.Add("@streaming");
            }

            // @sparse on a list of lists/maps would generate a foreach over a possibly-null element
            // (the same latent NRE C2J emits); no AWS model has this shape today, so fail loud instead.
            // A sparse *map* of collections is fine - its value null-guard covers every kind.
            if (shape is ListShape list && list.IsSparse())
            {
                var element = index.Shapes.GetValueOrDefault(list.Member.Target);
                if (element is ListShape or MapShape)
                {
                    found.Add("@sparse (list of collections)");
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
}
