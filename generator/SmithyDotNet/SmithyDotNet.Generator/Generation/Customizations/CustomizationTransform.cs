using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// Applies model-shaped customization hooks to the Smithy model in place, before the
/// <see cref="ServiceIndex"/> is built. Only a hook with a Smithy trait equivalent (<c>deprecatedMessage</c>;
/// <c>renameShape</c> adds a service <c>rename</c> entry; <c>locationName</c> sets <c>@ec2QueryName</c>) or a
/// structural edit (a member-keyed <c>renameShape</c> copies the member's target; <c>exclude</c> unbinds an operation
/// or drops members; <c>useWrappingResult</c> wraps an output; <c>emitAsShape</c> retargets members; <c>inject</c> adds
/// one; <c>suppressResultGeneration</c> drops an output) is applied to the model; the rest, member renames included,
/// are checked here and read from <see cref="GenerationContext.Customizations"/> by shape and member name where the
/// member is resolved.
/// Each hook family is applied by its own class (<see cref="ShapeSubstitutions"/>, <see cref="ShapeModifiers"/>,
/// <see cref="OperationModifiers"/>). A stale shape/member reference throws — it must fail the build, not silently stop applying.
/// </summary>
public static class CustomizationTransform
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        // First, so a member-keyed copy exists for the hooks below. Every hook keys a shape by its modeled name,
        // unlike C2J, which keys a renamed structure by its new name (S3's customizations need rekeying).
        ShapeSubstitutions.Apply(model, customizations);
        ShapeModifiers.Apply(model, customizations);
        OperationModifiers.Apply(model, customizations);
    }

    /// <summary>
    /// Checks the hooks TypeMapper.ResolveMembers looks up by name against the model. C2J keys these by
    /// <see cref="CustomizationsModel.EmittedName"/>, so a renamed member is listed under its new name.
    /// </summary>
    public static void Validate(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (shapeName, memberNames) in customizations.EmitIsSetProperties)
        {
            if (FindSingleShape(model, shapeName, $"emitIsSetProperties['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"emitIsSetProperties['{shapeName}'] targets a shape without members; only structures and unions are supported.");
            }

            foreach (var memberName in memberNames)
            {
                if (FindByEmittedName(structure, shapeName, memberName, customizations) is null)
                {
                    throw new GeneratorException($"emitIsSetProperties['{shapeName}'] lists member '{memberName}', which the shape does not have.");
                }
            }
        }

        // Members are checked by PaginationResolver, which knows the effective trait.
        foreach (var operationName in customizations.Paginators.Keys)
        {
            var shape = FindSingleShape(model, operationName, $"paginators['{operationName}']");
            if (shape is not OperationShape)
            {
                throw new GeneratorException($"paginators['{operationName}'] targets a '{shape.Type}' shape, not an operation.");
            }
        }

        foreach (var (shapeName, swaps) in customizations.DataTypeSwaps)
        {
            if (FindSingleShape(model, shapeName, $"dataTypeSwap['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"dataTypeSwap['{shapeName}'] targets a shape that is not a structure.");
            }

            foreach (var (memberName, swap) in swaps)
            {
                var member = FindByEmittedName(structure, shapeName, memberName, customizations)
                    ?? throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}', which the shape does not have.");
                ValidateDataTypeSwap(model, member, memberName, swap, shapeName);
            }
        }

        // The convenience hooks name an operation (noArgOverloads, simpleMethods) or a request/structure
        // class (simpleConstructors). The writers only consult them for shapes the model actually has, so a
        // stale key would otherwise be silently skipped (as in C2J). Fail loudly instead, like every hook
        // above — the stale entry must be removed from the customizations file.
        foreach (var operationName in customizations.NoArgOverloads)
        {
            if (FindSingleShape(model, operationName, $"noArgOverloads['{operationName}']") is not OperationShape)
            {
                throw new GeneratorException($"noArgOverloads['{operationName}'] targets a shape that is not an operation.");
            }
        }

        if (customizations.SimpleMethods is { } simpleMethods)
        {
            foreach (var operationName in simpleMethods.Operations.Keys)
            {
                if (FindSingleShape(model, operationName, $"simpleMethods['{operationName}']") is not OperationShape)
                {
                    throw new GeneratorException($"simpleMethods['{operationName}'] targets a shape that is not an operation.");
                }
            }
        }

        if (customizations.SimpleConstructors is { } simpleConstructors)
        {
            foreach (var className in simpleConstructors.Constructors.Keys)
            {
                // A request class is always emitted as {Op}Request; its Smithy input shape is often named
                // differently (e.g. PutItemInput), so accept the key when the operation exists.
                if (className.EndsWith("Request", StringComparison.Ordinal)
                    && ModelHasShape<OperationShape>(model, className[..^"Request".Length]))
                {
                    continue;
                }

                // Otherwise the key must name a shape in the model; a stale (absent) one throws. Unlike the
                // other hooks, a present-but-non-structure key is tolerated (the writers only emit a
                // constructor for an emitted class, skipping it as C2J does): one shared customizations file
                // serves every API version, and a shape that is a structure in one can be a map/list in
                // another (DynamoDB's Key/KeySchema are structures in 2011-12-05, a map/list in 2012-08-10).
                FindSingleShape(model, className, $"simpleConstructors['{className}']");
            }
        }

        foreach (var name in customizations.GenerateUnmarshaller)
        {
            if (FindSingleShape(model, name, $"generateUnmarshaller['{name}']") is not StructureShape)
            {
                throw new GeneratorException($"generateUnmarshaller['{name}'] targets a shape that is not a structure.");
            }
        }

        foreach (var propertyName in customizations.SkipUriPropertyValidation)
        {
            var found = false;
            foreach (var structure in model.Shapes.Values.OfType<StructureShape>())
            {
                foreach (var (memberName, member) in structure.Members)
                {
                    if (member.IsHttpLabel() && customizations.PropertyName(structure.Id.Name, memberName) == propertyName)
                    {
                        found = true;
                    }
                }
            }

            if (!found)
            {
                throw new GeneratorException($"skipUriPropertyValidation['{propertyName}'] is not the property of any @httpLabel member.");
            }
        }
    }

    private static bool ModelHasShape<T>(SmithyModel model, string bareName) where T : Shape =>
        model.Shapes.Any(entry => ShapeId.Parse(entry.Key).Name == bareName && entry.Value is T);

    // Customizations key shapes by bare name (C2J has no namespaces).
    internal static Shape FindSingleShape(SmithyModel model, string bareName, string context)
    {
        var id = FindSingleShapeId(model, bareName, context);
        return model.Shapes[id.AbsoluteName] ?? throw new GeneratorException($"{context} matched a null shape entry '{id}'.");
    }

    internal static OperationShape FindOperation(SmithyModel model, string bareName, string context)
    {
        var shape = FindSingleShape(model, bareName, context);
        return shape as OperationShape ?? throw new GeneratorException($"{context} targets a '{shape.Type}' shape, not an operation.");
    }

    internal static ShapeId FindSingleShapeId(SmithyModel model, string bareName, string context)
    {
        var matches = model.Shapes.Keys.Where(k => ShapeId.Parse(k).Name == bareName).ToList();
        if (matches.Count != 1)
        {
            throw new GeneratorException(matches.Count == 0
                ? $"{context} does not match any shape in the model."
                : $"{context} matches more than one shape: {string.Join(", ", matches)}.");
        }

        return ShapeId.Parse(matches[0]);
    }

    private static void ValidateDataTypeSwap(SmithyModel model, MemberShape member, string memberName, DataTypeSwap swap, string shapeName)
    {
        if (string.IsNullOrWhiteSpace(swap.Type))
        {
            throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}' without a 'Type'.");
        }

        // TODO: honor these when an XML protocol is supported; JSON has no flattening or element names.
        if (swap.IsFlattened is not null || swap.AlternateLocationName is not null)
        {
            throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}' with the XML-only 'isFlattened'/'alternateLocationName', which are not supported yet.");
        }

        var target = model.Shapes.GetValueOrDefault(member.Target.AbsoluteName) ?? PreludeShapes.Resolve(member.Target)
            ?? throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}', whose target '{member.Target}' is not in the model.");
        if (!IsSwappable(member, target, swap.Type))
        {
            throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}', which is not supported yet: only scalar body, query, and header members swapped to a non-collection type are handled so far.");
        }
    }

    // TODO: C2J swaps any member (S3 swaps structures, lists and enums); these are the positions the writers
    // honor so far. Elsewhere they would ignore the swapped type (a label's TrimStart or host-prefix substitution,
    // an idempotency token's GUID fallback), and a List<>/Dictionary<> swap needs C2J's collection handling
    // (Member.IsCollection: the InitializeCollections default and the IsSet count check).
    private static bool IsSwappable(MemberShape member, Shape target, string swappedType) =>
        target is (StringShape or EnumShape or BooleanShape or IntegerShape or IntEnumShape or LongShape or FloatShape or DoubleShape or TimestampShape)
        && !member.IsHttpPayload() && !member.IsHttpResponseCode() && !member.IsHttpQueryParams() && member.GetHttpPrefixHeaders() is null
        && !member.IsHttpLabel() && !member.IsHostLabel() && !member.IsIdempotencyToken()
        && !member.IsEventHeader() && !member.IsEventPayload()
        && !swappedType.StartsWith("List<", StringComparison.Ordinal) && !swappedType.StartsWith("Dictionary<", StringComparison.Ordinal);

    private static MemberShape? FindByEmittedName(StructureShape structure, string shapeName, string emittedName, CustomizationsModel customizations) =>
        structure.Members.FirstOrDefault(entry => customizations.EmittedName(shapeName, entry.Key) == emittedName).Value;
}
