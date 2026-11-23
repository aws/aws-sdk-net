using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

public sealed partial record CustomizationsModel
{
    private static readonly JsonSerializerOptions Options = new()
    {
        // logs.customizations.json has a trailing comma (C2J reads with lenient Json.NET).
        AllowTrailingCommas = true,

        // An unknown key at any depth is a hook not implemented yet; generating while ignoring
        // one would silently diverge from C2J output, so deserialization fails instead.
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,

        // A null list or section would otherwise surface later as a NullReferenceException.
        RespectNullableAnnotations = true,
    };

    /// <summary>
    /// Loads a service's customizations files into one model, as C2J's CustomizationCompiler combines them, except
    /// that a shape repeated across files throws instead of merging.
    /// </summary>
    public static CustomizationsModel Load(IEnumerable<string> paths)
    {
        var shapeModifiers = new Dictionary<string, ShapeModifier>();
        var operationModifiers = new Dictionary<string, OperationModifier>();
        var emitIsSetProperties = new Dictionary<string, List<string>>();
        var dataTypeSwaps = new Dictionary<string, Dictionary<string, DataTypeSwap>>();
        var shapeSubstitutions = new Dictionary<string, ShapeSubstitution>();
        RuntimePipelineOverride? runtimePipelineOverride = null;
        ServiceCustomizations? service = null;
        var paginators = new Dictionary<string, PaginatorCustomization>();
        var noArgOverloads = new List<string>();
        var simpleMethods = new Dictionary<string, SimpleMethodForms>();
        var simpleConstructors = new Dictionary<string, SimpleConstructorForms>();
        string? overrideContentType = null;
        var skipUriPropertyValidation = new List<string>();
        var generateUnmarshaller = new List<string>();
        var retainOriginalMemberOrdering = false;
        var suppressResultGeneration = new List<string>();
        var excludeShapes = new List<string>();
        var excludeMembers = new Dictionary<string, List<string>>();
        var flattenShapes = new Dictionary<string, List<string>>();
        var inheritAlternateBaseClass = new Dictionary<string, string>();
        var mergedEnums = new Dictionary<string, string>();
        var overrideTreatEnumsAsString = new Dictionary<string, bool>();

        foreach (var path in paths)
        {
            CustomizationsModel file;
            try
            {
                file = JsonSerializer.Deserialize<CustomizationsModel>(File.ReadAllText(path), Options) ?? throw new GeneratorException($"'{path}' deserialized to null.");
            }
            catch (JsonException e)
            {
                throw new GeneratorException($"'{path}': {e.Message}");
            }

            foreach (var (shapeName, modifier) in file.ShapeModifiers)
            {
                // C2J merges the two entries instead; see the TODO in CustomizationTransform.Apply.
                if (!shapeModifiers.TryAdd(shapeName, modifier))
                {
                    throw new GeneratorException($"'{path}': shapeModifiers['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }

                // The lookups read one entry per member, and C2J fails on a repeat too (ParseModifiers' ToDictionary).
                if (modifier.Modify.SelectMany(entry => entry.Keys).GroupBy(name => name).FirstOrDefault(group => group.Count() > 1) is { } repeated)
                {
                    throw new GeneratorException($"'{path}': shapeModifiers['{shapeName}'] modifies '{repeated.Key}' more than once.");
                }
            }

            if (file.RuntimePipelineOverride is { } pipelineOverride)
            {
                if (runtimePipelineOverride is not null)
                {
                    throw new GeneratorException($"'{path}': runtimePipelineOverride appears in more than one customizations file; merging is not supported yet.");
                }

                // System.Text.Json lets null through a non-nullable member, and a typo'd operation would fall through
                // to AddHandlerAfter (C2J's switch throws), so a malformed entry fails here, not in the generated code.
                var overrides = pipelineOverride.Overrides ?? throw new GeneratorException($"'{path}': runtimePipelineOverride needs an 'overrides' list.");
                for (var i = 0; i < overrides.Count; i++)
                {
                    if (overrides[i] is not { Operation: PipelineOverride.AddBefore or PipelineOverride.AddAfter or PipelineOverride.Replace } entry
                        || string.IsNullOrWhiteSpace(entry.TargetType)
                        || string.IsNullOrWhiteSpace(entry.NewType))
                    {
                        throw new GeneratorException($"'{path}': runtimePipelineOverride overrides[{i}] needs operation '{PipelineOverride.AddBefore}', '{PipelineOverride.AddAfter}' or '{PipelineOverride.Replace}' and a non-empty targetType and newType.");
                    }
                }

                runtimePipelineOverride = pipelineOverride;
            }

            if (file.Service is { } serviceSection)
            {
                if (service is not null)
                {
                    throw new GeneratorException($"'{path}': service appears in more than one customizations file; merging is not supported yet.");
                }

                service = serviceSection;
            }

            foreach (var (operationName, modifier) in file.OperationModifiers)
            {
                if (!operationModifiers.TryAdd(operationName, modifier))
                {
                    throw new GeneratorException($"'{path}': operationModifiers['{operationName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, modifier) in file.ShapeSubstitutions)
            {
                if (!shapeSubstitutions.TryAdd(shapeName, modifier))
                {
                    throw new GeneratorException($"'{path}': shapeSubstitutions['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (operationName, paginator) in file.Paginators)
            {
                if (!paginators.TryAdd(operationName, paginator))
                {
                    throw new GeneratorException($"'{path}': paginators['{operationName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, members) in file.EmitIsSetProperties)
            {
                if (!emitIsSetProperties.TryAdd(shapeName, members))
                {
                    throw new GeneratorException($"'{path}': emitIsSetProperties['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, swaps) in file.DataTypeSwaps)
            {
                if (!dataTypeSwaps.TryAdd(shapeName, swaps))
                {
                    throw new GeneratorException($"'{path}': dataTypeSwap['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            if (file.OverrideContentType != null)
            {
                if (overrideContentType != null)
                {
                    throw new GeneratorException($"'{path}': overrideContentType appears in more than one customizations file.");
                }

                overrideContentType = file.OverrideContentType;
            }

            retainOriginalMemberOrdering |= file.RetainOriginalMemberOrdering;

            // A service often splits these across files (acm keeps simpleMethods and simpleConstructors in
            // their own siblings); concatenate the lists and merge the per-operation/per-class dictionaries,
            // failing on a repeated key the way the other hooks do.
            noArgOverloads.AddRange(file.NoArgOverloads);

            foreach (var (operationName, forms) in file.SimpleMethods?.Operations ?? [])
            {
                if (!simpleMethods.TryAdd(operationName, forms))
                {
                    throw new GeneratorException($"'{path}': simpleMethods['{operationName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (className, forms) in file.SimpleConstructors?.Constructors ?? [])
            {
                if (!simpleConstructors.TryAdd(className, forms))
                {
                    throw new GeneratorException($"'{path}': simpleConstructors['{className}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            skipUriPropertyValidation.AddRange(file.SkipUriPropertyValidation);
            generateUnmarshaller.AddRange(file.GenerateUnmarshaller);
            suppressResultGeneration.AddRange(file.SuppressResultGeneration);

            // S3 splits excludeShapes between its main and enums files.
            foreach (var shapeName in file.ExcludeShapes)
            {
                if (excludeShapes.Contains(shapeName))
                {
                    throw new GeneratorException($"'{path}': excludeShapes lists '{shapeName}' more than once.");
                }

                excludeShapes.Add(shapeName);
            }

            foreach (var (shapeName, members) in file.ExcludeMembers)
            {
                if (!excludeMembers.TryAdd(shapeName, members))
                {
                    throw new GeneratorException($"'{path}': excludeMembers['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, members) in file.FlattenShapes)
            {
                if (!flattenShapes.TryAdd(shapeName, members))
                {
                    throw new GeneratorException($"'{path}': flattenShapes['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, baseClass) in file.InheritAlternateBaseClass)
            {
                if (!inheritAlternateBaseClass.TryAdd(shapeName, baseClass))
                {
                    throw new GeneratorException($"'{path}': inheritAlternateBaseClass['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, merge) in file.MergedEnums)
            {
                if (!mergedEnums.TryAdd(shapeName, merge))
                {
                    throw new GeneratorException($"'{path}': mergedEnums['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }

            foreach (var (shapeName, treatAsString) in file.OverrideTreatEnumsAsString)
            {
                if (!overrideTreatEnumsAsString.TryAdd(shapeName, treatAsString))
                {
                    throw new GeneratorException($"'{path}': overrideTreatEnumsAsString['{shapeName}'] appears in more than one customizations file; merging is not supported yet.");
                }
            }
        }

        return new CustomizationsModel
        {
            ShapeModifiers = shapeModifiers,
            OperationModifiers = operationModifiers,
            DataTypeSwaps = dataTypeSwaps,
            EmitIsSetProperties = emitIsSetProperties,
            ShapeSubstitutions = shapeSubstitutions,
            RuntimePipelineOverride = runtimePipelineOverride,
            Service = service,
            Paginators = paginators,
            NoArgOverloads = noArgOverloads,
            SimpleMethods = simpleMethods.Count > 0 ? new SimpleMethodsCustomization { Operations = simpleMethods } : null,
            SimpleConstructors = simpleConstructors.Count > 0 ? new SimpleConstructorsCustomization { Constructors = simpleConstructors } : null,
            OverrideContentType = overrideContentType,
            SkipUriPropertyValidation = skipUriPropertyValidation,
            GenerateUnmarshaller = generateUnmarshaller,
            RetainOriginalMemberOrdering = retainOriginalMemberOrdering,
            SuppressResultGeneration = suppressResultGeneration,
            ExcludeShapes = excludeShapes,
            ExcludeMembers = excludeMembers,
            FlattenShapes = flattenShapes,
            InheritAlternateBaseClass = inheritAlternateBaseClass,
            MergedEnums = mergedEnums,
            OverrideTreatEnumsAsString = overrideTreatEnumsAsString,
        };
    }
}
