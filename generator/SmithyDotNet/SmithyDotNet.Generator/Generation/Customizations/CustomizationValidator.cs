using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>Checks the hooks that are not applied to the model by <see cref="CustomizationTransform"/> against it.</summary>
public static class CustomizationValidator
{
    /// <summary>
    /// Checks the hooks TypeMapper.ResolveMembers looks up by name against the model. C2J keys these by
    /// <see cref="CustomizationsModel.EmittedName"/>, so a renamed member is listed under its new name.
    /// </summary>
    public static void Validate(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (shapeName, memberNames) in customizations.EmitIsSetProperties)
        {
            if (CustomizationTransform.FindSingleShape(model, shapeName, $"emitIsSetProperties['{shapeName}']") is not StructureShape structure)
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
            var shape = CustomizationTransform.FindSingleShape(model, operationName, $"paginators['{operationName}']");
            if (shape is not OperationShape)
            {
                throw new GeneratorException($"paginators['{operationName}'] targets a '{shape.Type}' shape, not an operation.");
            }
        }

        foreach (var (shapeName, swaps) in customizations.DataTypeSwaps)
        {
            if (CustomizationTransform.FindSingleShape(model, shapeName, $"dataTypeSwap['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"dataTypeSwap['{shapeName}'] targets a shape that is not a structure.");
            }

            foreach (var (memberName, swap) in swaps)
            {
                var member = FindByEmittedName(structure, shapeName, memberName, customizations) ?? throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}', which the shape does not have.");
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
                if (className.EndsWith("Request", StringComparison.Ordinal) && ModelHasShape<OperationShape>(model, ModeledOperationName(customizations, className[..^"Request".Length])))
                {
                    continue;
                }

                // Otherwise the key must name a shape in the model; a stale (absent) one throws. Unlike the
                // other hooks, a present-but-non-structure key is tolerated (the writers only emit a
                // constructor for an emitted class, skipping it as C2J does): one shared customizations file
                // serves every API version, and a shape that is a structure in one can be a map/list in
                // another (DynamoDB's Key/KeySchema are structures in 2011-12-05, a map/list in 2012-08-10).
                CustomizationTransform.FindSingleShape(model, className, $"simpleConstructors['{className}']");
            }
        }

        foreach (var name in customizations.GenerateUnmarshaller)
        {
            if (CustomizationTransform.FindSingleShape(model, name, $"generateUnmarshaller['{name}']") is not StructureShape)
            {
                throw new GeneratorException($"generateUnmarshaller['{name}'] targets a shape that is not a structure.");
            }
        }

        foreach (var shapeName in customizations.ExcludeShapes)
        {
            var shape = CustomizationTransform.FindSingleShape(model, shapeName, $"excludeShapes['{shapeName}']");
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
            if (CustomizationTransform.FindSingleShape(model, shapeName, $"excludeMembers['{shapeName}']") is not StructureShape structure)
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
            var shape = CustomizationTransform.FindSingleShape(model, shapeName, $"shapeModifiers['{shapeName}']");
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

        ValidateInjectedMarshallCode(model, customizations);

        // ExceptionWriter always derives from the service exception, so an error's entry would do nothing.
        foreach (var (shapeName, baseClass) in customizations.InheritAlternateBaseClass)
        {
            if (CustomizationTransform.FindSingleShape(model, shapeName, $"inheritAlternateBaseClass['{shapeName}']") is not StructureShape structure || structure.IsError())
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
            if (CustomizationTransform.FindSingleShape(model, shapeName, $"overrideTreatEnumsAsString['{shapeName}']") is not ListShape list || model.Shapes.GetValueOrDefault(list.Member.Target.AbsoluteName) is not EnumShape)
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

    // The request marshaller writes the lines in place of a header, a body element or a structure payload only.
    private static void ValidateInjectedMarshallCode(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (shapeName, modifier) in customizations.ShapeModifiers)
        {
            var context = $"shapeModifiers['{shapeName}']";

            if (modifier.InjectMarshallCodeInPayload is { } payloadCode)
            {
                var shape = CustomizationTransform.FindSingleShape(model, shapeName, context);
                var isInput = model.Shapes.Values.OfType<OperationShape>().Any(operation => operation.Input == shape.Id);
                if (payloadCode.Count == 0 || !isInput)
                {
                    throw new GeneratorException($"{context} needs injectMarshallCodeInPayload lines and to be an operation's input.");
                }
            }

            foreach (var (memberName, property) in modifier.Modify.SelectMany(entry => entry))
            {
                if (property.InjectMarshallCode is not { } code)
                {
                    continue;
                }

                if (code.Count == 0)
                {
                    throw new GeneratorException($"{context} sets injectMarshallCode on '{memberName}' without lines.");
                }

                if (CustomizationTransform.FindSingleShape(model, shapeName, context) is not StructureShape structure)
                {
                    throw new GeneratorException($"{context} targets a shape that is not a structure.");
                }

                var member = structure.Members[memberName];
                var isRawPayload = member.IsHttpPayload() && model.Shapes.GetValueOrDefault(member.Target.AbsoluteName) is not StructureShape;

                if (member.GetHttpQuery() is not null || member.IsHttpQueryParams() || member.IsHttpLabel() || member.IsXmlAttribute() || isRawPayload)
                {
                    throw new GeneratorException($"{context} sets injectMarshallCode on '{memberName}', which is a query, label, attribute or non-structure payload member.");
                }

                if (modifier.ExcludeFromMarshalling.Contains(customizations.EmittedName(shapeName, memberName)))
                {
                    throw new GeneratorException($"{context} sets injectMarshallCode on '{memberName}', which excludeFromMarshalling drops.");
                }
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

        if (CustomizationTransform.FindSingleShape(model, ModeledOperationName(customizations, operationName), context) is not OperationShape)
        {
            throw new GeneratorException($"{context} targets a shape that is not an operation.");
        }
    }

    private static string ModeledOperationName(CustomizationsModel customizations, string csharpName) =>
        customizations.OperationModifiers.FirstOrDefault(entry => entry.Value.Name == csharpName).Key ?? csharpName;

    private static bool ModelHasShape<T>(SmithyModel model, string bareName) where T : Shape =>
        model.Shapes.Any(entry => ShapeId.Parse(entry.Key).Name == bareName && entry.Value is T);

    private static void ValidateDataTypeSwap(SmithyModel model, MemberShape member, string memberName, DataTypeSwap swap, string shapeName)
    {
        if (string.IsNullOrWhiteSpace(swap.Type))
        {
            throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}' without a 'Type'.");
        }

        // TODO: not honored yet.
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
