using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;

namespace SmithyDotNet.Generator.Generation.Paginators;

/// <summary>
/// A paginated operation with its trait resolved and token/items members mapped to .NET property names.
/// <see cref="ItemsProperty"/> is the leaf member name (the generated enumerable's name), while
/// <see cref="ItemsPath"/> and <see cref="OutputTokenProperty"/> are full accessor paths off the
/// response — they contain dots when the trait uses a dotted path (e.g. "DistributionList.NextMarker").
/// </summary>
public record PaginatedOperation(
    Operation Operation,
    PaginatedTrait Trait,
    string InputTokenProperty,
    string OutputTokenProperty,
    string? PageSizeProperty,
    string? ItemsProperty,
    string? ItemsPath,
    string? ItemsElementType
);

/// <summary>
/// Resolves <c>@paginated</c> operations into <see cref="PaginatedOperation"/> records,
/// applying service-level trait defaults and validating token/items members against the model.
/// </summary>
// TODO: C2J paginators also support MoreResults, multi-token result keys, and
// stopPaginationOnSameToken; none exist in Smithy — they'll land as customizations.
public static class PaginationResolver
{
    public static List<PaginatedOperation> Resolve(IReadOnlyList<Operation> operations, ServiceIndex index, CustomizationsModel customizations)
    {
        var result = new List<PaginatedOperation>();
        var serviceDefaults = index.Service.GetPaginated();

        foreach (var operation in operations)
        {
            var trait = operation.Shape.GetPaginated();
            if (trait is null)
            {
                continue;
            }

            // TODO: give the paginator its operation's net8 guard if a service ever paginates an h2-only operation;
            // none does, and C2J's paginators have no guard, so today it would generate code that fails below net8.
            if (operation.RequiresHttp2)
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}' requires HTTP/2, which paginators don't support yet.");
            }

            trait = MergeServiceDefaults(trait, serviceDefaults);
            if (trait.InputToken is null || trait.OutputToken is null)
            {
                throw new GeneratorException($"Paginated operation '{operation.Name}': inputToken and outputToken are required.");
            }

            var inputTokenProperty = ResolveStringToken(operation, operation.Input, trait.InputToken, "inputToken", index, customizations);
            var outputTokenProperty = ResolveStringToken(operation, operation.Output, trait.OutputToken, "outputToken", index, customizations);
            string? pageSizeProperty = null;
            if (trait.PageSize is not null)
            {
                pageSizeProperty = ResolveMemberPath(operation, operation.Input, trait.PageSize, "pageSize", index, customizations).Path;
            }

            string? itemsProperty = null;
            string? itemsPath = null;
            string? itemsElementType = null;
            if (trait.Items is not null)
            {
                var (path, leaf, itemsTarget) = ResolveMemberPath(operation, operation.Output, trait.Items, "items", index, customizations);
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
                        itemsProperty = leaf;
                        itemsPath = path;
                        itemsElementType = elementType;
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
                    throw new GeneratorException($"Paginated operation '{operation.Name}': items member '{trait.Items}' targets '{itemsTarget.Type}', expected list or map.");
                }
            }

            result.Add(new PaginatedOperation(operation, trait, inputTokenProperty, outputTokenProperty, pageSizeProperty, itemsProperty, itemsPath, itemsElementType));
        }

        return result;
    }

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

    private static string ResolveStringToken(Operation operation, StructureShape structure, string memberName, string traitField, ServiceIndex index, CustomizationsModel customizations)
    {
        var (path, _, target) = ResolveMemberPath(operation, structure, memberName, traitField, index, customizations);
        if (target is not StringShape)
        {
            throw new GeneratorException($"Paginated operation '{operation.Name}': {traitField} '{memberName}' targets '{target.Type}', only string is supported.");
        }

        return path;
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
