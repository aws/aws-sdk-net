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
        ["smithy.api#endpoint"] = "@endpoint (host prefix)",
        ["smithy.api#jsonValue"] = "@jsonValue",
        ["smithy.api#httpPrefixHeaders"] = "@httpPrefixHeaders",
        ["smithy.api#httpPayload"] = "@httpPayload",
        ["smithy.api#httpResponseCode"] = "@httpResponseCode",
        ["smithy.api#streaming"] = "@streaming",
        ["smithy.api#paginated"] = "@paginated",
        ["aws.protocols#awsQueryCompatible"] = "awsQueryCompatible",
    };

    private static readonly Dictionary<string, string> DeniedResponseMemberTraits = new()
    {
        ["smithy.api#httpHeader"] = "@httpHeader (response)",
    };

    // Shape-level (not member-level): C2J emits a RetryableDetails property for error shapes
    // carrying this trait, which the Smithy generator's ExceptionWriter does not yet do.
    private static readonly Dictionary<string, string> DeniedErrorTraits = new()
    {
        ["smithy.api#retryable"] = "@retryable",
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
                CollectDeniedOnMembers(input, DeniedTraits, found);
            }

            if (index.Shapes.TryGetValue(op.Output, out var outputShape) && outputShape is StructureShape output)
            {
                CollectDeniedOnResponseMembers(output, found);
            }

            foreach (var errorId in op.Errors)
            {
                if (index.Shapes.TryGetValue(errorId, out var errorShape) && errorShape is StructureShape error)
                {
                    CollectDenied(error.Traits, DeniedErrorTraits, found);
                    CollectDeniedOnResponseMembers(error, found);
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

    private static void CollectDeniedOnMembers(StructureShape structure, Dictionary<string, string> denied, HashSet<string> found)
    {
        foreach (var (_, member) in structure.Members)
        {
            CollectDenied(member.Traits, denied, found);
        }
    }

    // Output and error structures get the same member-level treatment: both are part of the response.
    private static void CollectDeniedOnResponseMembers(StructureShape structure, HashSet<string> found)
    {
        CollectDeniedOnMembers(structure, DeniedTraits, found);
        CollectDeniedOnMembers(structure, DeniedResponseMemberTraits, found);
    }
}
