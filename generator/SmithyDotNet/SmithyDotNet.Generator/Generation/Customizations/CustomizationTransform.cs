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
/// one; <c>flattenShapes</c> replaces a payload with its members; <c>mergedEnums</c> copies enum values; <c>suppressResultGeneration</c> drops an output) is applied to the model; the rest, member renames included,
/// are checked here and read from <see cref="GenerationContext.Customizations"/> by shape and member name where the
/// member is resolved.
/// Each hook family is applied by its own class (<see cref="ShapeSubstitutions"/>, <see cref="FlattenShapes"/>, <see cref="MergedEnums"/>, <see cref="ShapeModifiers"/>,
/// <see cref="OperationModifiers"/>). A stale shape/member reference throws — it must fail the build, not silently stop applying.
/// </summary>
public static class CustomizationTransform
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        // First, so a member-keyed copy exists for the hooks below. Every hook keys a shape by its modeled name,
        // unlike C2J, which keys a renamed structure by its new name.
        // TODO: rekey s3.customizations.json by modeled name when S3 moves off C2J (C2J still reads the current keys):
        // - its renamed structures' entries (BucketLifecycleConfiguration, keyed today as LifecycleConfiguration);
        // - C2J's injectXmlPropertyGetter/Setter, renamed injectPropertyGetter/Setter here. On a renamed member C2J reads
        //   them by the new name, so S3 puts them in a second entry (CopyObjectRequest's ModifiedSinceDate beside
        //   CopySourceIfModifiedSince's emitPropertyName). They belong in the modeled member's entry; the new-name entry
        //   otherwise fails as an unknown member.
        ShapeSubstitutions.Apply(model, customizations);
        // Before shapeModifiers, which address a flattened member on its new parent, as C2J does (S3's RestoreObjectRequest.Tier).
        FlattenShapes.Apply(model, customizations);
        // Before shapeModifiers, so a merged value is a member of the target like any other.
        MergedEnums.Apply(model, customizations);
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
            ValidateOperationKey(model, customizations, operationName, $"noArgOverloads['{operationName}']");
        }

        if (customizations.SimpleMethods is { } simpleMethods)
        {
            foreach (var operationName in simpleMethods.Operations.Keys)
            {
                ValidateOperationKey(model, customizations, operationName, $"simpleMethods['{operationName}']");
            }
        }

        if (customizations.SimpleConstructors is { } simpleConstructors)
        {
            foreach (var className in simpleConstructors.Constructors.Keys)
            {
                // A request class is always emitted as {Op}Request; its Smithy input shape is often named
                // differently (e.g. PutItemInput), so accept the key when the operation exists.
                if (className.EndsWith("Request", StringComparison.Ordinal)
                    && ModelHasShape<OperationShape>(model, ModeledOperationName(customizations, className[..^"Request".Length])))
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

        foreach (var shapeName in customizations.ExcludeShapes)
        {
            var shape = FindSingleShape(model, shapeName, $"excludeShapes['{shapeName}']");
            // An @input/@output structure is only ever its {Op}Request/{Op}Response, so excluding it would do nothing. An
            // input/output without the trait is also a class when a member targets it (S3's NotificationConfiguration), and
            // only that class is excluded; its {Op}Response is still emitted, as in C2J.
            // TODO: C2J also skips an {Op}Request/{Op}Response by that name; no service excludes one or an error today.
            if (shape is not (StructureShape or EnumShape) || shape.IsError() || shape.IsInput() || shape.IsOutput())
            {
                throw new GeneratorException($"excludeShapes['{shapeName}'] targets a shape that is not a structure or enum, or is an error or an @input/@output structure.");
            }
        }

        foreach (var (shapeName, memberNames) in customizations.ExcludeMembers)
        {
            if (FindSingleShape(model, shapeName, $"excludeMembers['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"excludeMembers['{shapeName}'] targets a shape that is not a structure.");
            }

            foreach (var memberName in memberNames)
            {
                if (FindByEmittedName(structure, shapeName, memberName, customizations) is null)
                {
                    throw new GeneratorException($"excludeMembers['{shapeName}'] lists member '{memberName}', which the shape does not have.");
                }
            }
        }

        foreach (var (shapeName, modifier) in customizations.ShapeModifiers)
        {
            if (modifier.ExcludeFromMarshalling.Count == 0 && modifier.ExcludeFromUnmarshalling.Count == 0)
            {
                continue;
            }

            // Only the request marshaller reads the first list, and only the response and structure unmarshallers the second.
            var shape = FindSingleShape(model, shapeName, $"shapeModifiers['{shapeName}']");
            var isInput = model.Shapes.Values.OfType<OperationShape>().Any(operation => operation.Input == shape.Id);
            if (modifier.ExcludeFromMarshalling.Count > 0 && !isInput)
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] sets excludeFromMarshalling, but is not an operation's input.");
            }
            if (modifier.ExcludeFromUnmarshalling.Count > 0 && isInput)
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] sets excludeFromUnmarshalling, but is an operation's input.");
            }

            foreach (var memberName in modifier.ExcludeFromMarshalling.Concat(modifier.ExcludeFromUnmarshalling))
            {
                if (shape is not StructureShape structure || FindByEmittedName(structure, shapeName, memberName, customizations) is null)
                {
                    throw new GeneratorException($"shapeModifiers['{shapeName}'] excludes member '{memberName}' from (un)marshalling, which the shape does not have.");
                }
            }
        }

        // ExceptionWriter always derives from the service exception, so an error's entry would do nothing.
        foreach (var (shapeName, baseClass) in customizations.InheritAlternateBaseClass)
        {
            if (FindSingleShape(model, shapeName, $"inheritAlternateBaseClass['{shapeName}']") is not StructureShape structure || structure.IsError())
            {
                throw new GeneratorException($"inheritAlternateBaseClass['{shapeName}'] targets a shape that is not a structure, or is an error.");
            }

            // No service gives a response an alternate base; OperationWriter would need to apply it.
            if (model.Shapes.Values.OfType<OperationShape>().Any(operation => operation.Output == structure.Id))
            {
                throw new GeneratorException($"inheritAlternateBaseClass['{shapeName}'] targets an operation output, which is not supported.");
            }

            if (string.IsNullOrWhiteSpace(baseClass))
            {
                throw new GeneratorException($"inheritAlternateBaseClass['{shapeName}'] needs a non-empty base class.");
            }
        }

        foreach (var shapeName in customizations.OverrideTreatEnumsAsString.Keys)
        {
            // S3 only lists lists; a map would also need its whole-map reads and writes changed.
            if (FindSingleShape(model, shapeName, $"overrideTreatEnumsAsString['{shapeName}']") is not ListShape list
                || model.Shapes.GetValueOrDefault(list.Member.Target.AbsoluteName) is not EnumShape)
            {
                throw new GeneratorException($"overrideTreatEnumsAsString['{shapeName}'] targets a shape that is not a list of enums.");
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

    // These hooks name an operation by its C# name, as C2J does, unlike operationModifiers; a modeled name would never match.
    private static void ValidateOperationKey(SmithyModel model, CustomizationsModel customizations, string operationName, string context)
    {
        if (customizations.OperationName(operationName) is var csharpName && csharpName != operationName)
        {
            throw new GeneratorException($"{context} names a renamed operation by its modeled name; use '{csharpName}'.");
        }

        if (FindSingleShape(model, ModeledOperationName(customizations, operationName), context) is not OperationShape)
        {
            throw new GeneratorException($"{context} targets a shape that is not an operation.");
        }
    }

    private static string ModeledOperationName(CustomizationsModel customizations, string csharpName) =>
        customizations.OperationModifiers.FirstOrDefault(entry => entry.Value.Name == csharpName).Key ?? csharpName;

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
