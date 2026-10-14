using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;

namespace SmithyDotNet.Generator.Generation.Paginators;

/// <summary>
/// A list member flattened into an <c>IPaginatedEnumerable&lt;T&gt;</c>: <see cref="Property"/> is the leaf member name
/// (the enumerable's name), <see cref="Path"/> the full accessor off the response, dotted when nested.
/// </summary>
public record PaginatedResultKey(string Property, string Path, string ElementType);

/// <summary>
/// A paginated operation with its token/pageSize/items members mapped to .NET property names. Token properties are
/// full accessor paths (dotted for a nested member such as "DistributionList.NextMarker"), one per token; most operations
/// have one, Route 53 ListResourceRecordSets pages on three. <see cref="TokensAreMaps"/> marks map-typed tokens
/// (DynamoDB BatchGetItem resends <c>UnprocessedKeys</c>), which paginate while the map has entries.
/// </summary>
public record PaginatedOperation(
    Operation Operation,
    IReadOnlyList<string> InputTokenProperties,
    IReadOnlyList<string> OutputTokenProperties,
    bool TokensAreMaps,
    bool StopOnSameToken,
    string? PageSizeProperty,
    IReadOnlyList<PaginatedResultKey> ResultKeys
);

/// <summary>
/// Resolves paginated operations into <see cref="PaginatedOperation"/> records, applying service-level trait defaults
/// and the <c>paginators</c> customization, and validating token/items members against the model.
/// </summary>
public static class PaginationResolver
{
    public static List<PaginatedOperation> Resolve(IReadOnlyList<Operation> operations, ServiceIndex index, CustomizationsModel customizations)
    {
        var result = new List<PaginatedOperation>();
        var serviceDefaults = index.Service.GetPaginated();

        foreach (var operation in operations)
        {
            var trait = operation.Shape.GetPaginated();
            customizations.Paginators.TryGetValue(operation.Name, out var customization);
            if (trait is null && customization is null)
            {
                continue;
            }

            // TODO: give the paginator its operation's net8 guard if a service ever paginates an h2-only operation;
            // none does, and C2J's paginators have no guard, so today it would generate code that fails below net8.
            if (operation.RequiresHttp2)
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}' requires HTTP/2, which paginators don't support yet.");
            }

            // An operation without the trait is not paginated, so the service defaults don't reach it.
            trait = trait is null ? new PaginatedTrait() : MergeServiceDefaults(trait, serviceDefaults);
            var items = trait.Items is null ? new List<string>() : [trait.Items];
            if (customization is not null)
            {
                ThrowIfCustomizationConflicts(operation, trait, customization);
                items.AddRange(customization.Items ?? []);
            }

            List<string>? inputTokens = trait.InputToken is null ? customization?.InputToken : [trait.InputToken];
            List<string>? outputTokens = trait.OutputToken is null ? customization?.OutputToken : [trait.OutputToken];
            var pageSize = trait.PageSize ?? customization?.PageSize;
            if (inputTokens is null || outputTokens is null)
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}': inputToken and outputToken are required.");
            }
            if (inputTokens.Count != outputTokens.Count)
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}': inputToken and outputToken must have the same number of entries.");
            }

            var inputTokenProperties = new List<string>();
            var outputTokenProperties = new List<string>();
            var tokensAreMaps = false;

            for (var i = 0; i < inputTokens.Count; i++)
            {
                var inputToken = ResolveMemberPath(operation, operation.Input, inputTokens[i], "inputToken", index, customizations);
                var outputToken = ResolveMemberPath(operation, operation.Output, outputTokens[i], "outputToken", index, customizations);

                tokensAreMaps = inputToken.Target is MapShape && outputToken.Target is MapShape;
                var tokensAreStrings = IsStringToken(inputToken.Target) && IsStringToken(outputToken.Target);
                if (!tokensAreMaps && !tokensAreStrings)
                {
                    throw new GeneratorException($"Paginated operation '{operation.Name}': inputToken and outputToken must both be strings or both be maps.");
                }

                inputTokenProperties.Add(inputToken.Path);
                outputTokenProperties.Add(outputToken.Path);
            }

            string? pageSizeProperty = null;
            if (pageSize is not null)
            {
                pageSizeProperty = ResolveMemberPath(operation, operation.Input, pageSize, "pageSize", index, customizations).Path;
            }

            var resultKeys = new List<PaginatedResultKey>();
            foreach (var item in items)
            {
                var (path, leaf, itemsTarget) = ResolveMemberPath(operation, operation.Output, item, "items", index, customizations);
                if (itemsTarget is ListShape list)
                {
                    // Derive the element type exactly the way TypeMapper types the List<T> property
                    // (CollectionElementTarget, then MapScalarElement), so the enumerable always agrees
                    // with the property: enum collapses to string, scalars non-nullable unless @sparse.
                    // When the element is a map, nested list, or document, elementType is null and the
                    // paginator gets no flattened enumerable - same as C2J, which drops those result keys.
                    var elementTarget = TypeMapper.CollectionElementTarget(ResolveShape(index, list.Member.Target));
                    var elementType = elementTarget is StructureShape // includes UnionShape
                        ? index.ToDotNetName(list.Member.Target)
                        : TypeMapper.MapScalarElement(elementTarget, list.IsSparse());
                    if (elementType is not null)
                    {
                        // The enumerable is named after the leaf member ("DistributionList.Items" -> "Items").
                        resultKeys.Add(new PaginatedResultKey(leaf, path, elementType));
                    }
                }
                else if (itemsTarget is MapShape)
                {
                    // A map items member is legal Smithy, but the SDK has no flattened enumerable for
                    // maps (PaginatedResultKeyResponse enumerates list elements), so the paginator is
                    // emitted with only Responses — the same output C2J produces by filtering non-list
                    // result keys (e.g. API Gateway GetUsage).
                }
                else
                {
                    throw new GeneratorException($"Paginated operation '{operation.Name}': items member '{item}' targets '{itemsTarget.Type}', expected list or map.");
                }
            }

            var stopOnSameToken = customizations.OperationModifiers.TryGetValue(operation.Name, out var modifier) && modifier.StopPaginationOnSameToken;
            result.Add(new PaginatedOperation(operation, inputTokenProperties, outputTokenProperties, tokensAreMaps, stopOnSameToken, pageSizeProperty, resultKeys));
        }

        return result;
    }

    // Route 53 ListResourceRecordSets pages on an enum (RRType) alongside its string tokens.
    private static bool IsStringToken(Shape shape) => shape is StringShape or EnumShape;

    // A @paginated trait on the service shape supplies defaults for every paginated operation;
    // operation-level values win (https://smithy.io/2.0/spec/behavior-traits.html#paginated-trait).
    private static PaginatedTrait MergeServiceDefaults(PaginatedTrait trait, PaginatedTrait? serviceDefaults)
    {
        if (serviceDefaults is null)
        {
            return trait;
        }

        return trait with
        {
            InputToken = trait.InputToken ?? serviceDefaults.InputToken,
            OutputToken = trait.OutputToken ?? serviceDefaults.OutputToken,
            Items = trait.Items ?? serviceDefaults.Items,
            PageSize = trait.PageSize ?? serviceDefaults.PageSize,
        };
    }

    // The customization exists because the model lacks the field; once the model has it the entry is stale or
    // conflicting either way, so it fails rather than silently winning.
    private static void ThrowIfCustomizationConflicts(Operation operation, PaginatedTrait trait, PaginatorCustomization customization)
    {
        var inputTokenModeled = trait.InputToken is not null && customization.InputToken is not null;
        var outputTokenModeled = trait.OutputToken is not null && customization.OutputToken is not null;
        var pageSizeModeled = trait.PageSize is not null && customization.PageSize is not null;
        var itemsModeled = trait.Items is not null && customization.Items is not null && customization.Items.Contains(trait.Items);

        if (inputTokenModeled || outputTokenModeled || pageSizeModeled || itemsModeled)
        {
            throw new GeneratorException($"paginators['{operation.Name}'] sets a field that @paginated now models; remove it.");
        }
    }

    private static (string Path, string Leaf, Shape Target) ResolveMemberPath(Operation operation, StructureShape structure, string path, string traitField, ServiceIndex index, CustomizationsModel customizations)
    {
        // outputToken and items may be dotted paths (e.g. CloudFront's "DistributionList.NextMarker").
        var segments = path.Split('.');
        var properties = new string[segments.Length];
        Shape target = structure;

        for (var i = 0; i < segments.Length; i++)
        {
            if (target is not StructureShape current || !current.Members.TryGetValue(segments[i], out var member))
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}': {traitField} member '{segments[i]}' not found on structure.");
            }

            // The trait names the modeled member; the accessor needs its C# name, which a rename changes.
            properties[i] = customizations.PropertyName(current.Id.Name, segments[i]);
            target = ResolveShape(index, member.Target);
        }

        return (string.Join(".", properties), properties[^1], target);
    }

    private static Shape ResolveShape(ServiceIndex index, ShapeId shapeId)
    {
        if (index.Shapes.TryGetValue(shapeId, out var shape))
        {
            return shape;
        }

        return PreludeShapes.Resolve(shapeId) ?? throw new GeneratorException($"Shape '{shapeId}' not found.");
    }
}
