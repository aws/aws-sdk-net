using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// Applies model-shaped customization hooks to the Smithy model in place, before the
/// <see cref="ServiceIndex"/> is built. Only a hook with a Smithy trait equivalent (a rename pins <c>@jsonName</c>,
/// <c>renameShape</c> adds a service <c>rename</c> entry) or a structural edit (a member-keyed
/// <c>renameShape</c> copies the member's target) is applied to the model; the rest are checked by
/// <see cref="Validate"/> and read from <see cref="GenerationContext.Customizations"/> by shape and member name
/// where the member is resolved.
/// A stale shape/member reference throws — it must fail the build, not silently stop applying.
/// </summary>
public static class CustomizationTransform
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        // First, so a member-keyed copy exists for the hooks below. Every hook keys a shape by its modeled name,
        // unlike C2J, which keys a renamed structure by its new name (S3's customizations need rekeying).
        foreach (var (key, substitution) in customizations.ShapeSubstitutions)
        {
            if (string.IsNullOrWhiteSpace(substitution.RenamedShapeName))
            {
                throw new GeneratorException($"shapeSubstitutions['{key}'] must specify a non-empty 'renameShape'.");
            }
            if (key.Split('$') is [var structureName, var memberName])
            {
                RenameMemberTarget(model, structureName, memberName, substitution.RenamedShapeName);
            }
            else
            {
                ApplyRename(model, key, substitution.RenamedShapeName);
            }
        }

        foreach (var (shapeName, modifier) in customizations.ShapeModifiers)
        {
            var shape = FindSingleShape(model, shapeName, $"shapeModifiers['{shapeName}']");

            if (modifier.DeprecatedMessage is { } shapeMessage)
            {
                shape.SetDeprecatedMessage(shapeMessage);
            }

            // The structure/enum restriction only bites member modifications - a shape-level hook (e.g.
            // deprecatedMessage on a string shape) applies to any shape.
            if (modifier.Modify.Count == 0)
            {
                continue;
            }

            switch (shape)
            {
                case StructureShape structure:
                    foreach (var (memberName, property) in modifier.Modify.SelectMany(entry => entry))
                    {
                        ApplyMember(structure, memberName, property, shapeName);
                    }
                    break;
                case EnumShape:
                    // Enum entries are keyed by wire value and applied (with the stale-reference
                    // check) by TypeMapper.ResolveEnumMembers, where the constant names are derived.
                    break;
                default:
                    throw new GeneratorException($"shapeModifiers['{shapeName}'] modifies members of a '{shape.Type}' shape; only structures and enums are supported.");
            }
        }

        foreach (var (operationName, modifier) in customizations.OperationModifiers)
        {
            var shape = FindSingleShape(model, operationName, $"operationModifiers['{operationName}']");
            if (shape is not OperationShape)
            {
                throw new GeneratorException($"operationModifiers['{operationName}'] targets a '{shape.Type}' shape, not an operation.");
            }

            if (modifier.DeprecatedMessage is { } message)
            {
                shape.SetDeprecatedMessage(message);
            }
        }
    }

    /// <summary>
    /// Checks the hooks TypeMapper.ResolveMembers looks up by name against the model. Runs after
    /// <see cref="Apply"/>: C2J keys these by the emitted property name, so renames must have landed.
    /// </summary>
    public static void Validate(SmithyModel model, CustomizationsModel customizations)
    {
        // C2J's Member name is already the emitPropertyName, so a renamed member is listed under its new name.
        foreach (var (shapeName, memberNames) in customizations.EmitIsSetProperties)
        {
            if (FindSingleShape(model, shapeName, $"emitIsSetProperties['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"emitIsSetProperties['{shapeName}'] targets a shape without members; only structures and unions are supported.");
            }

            foreach (var memberName in memberNames)
            {
                if (!structure.Members.ContainsKey(memberName))
                {
                    throw new GeneratorException($"emitIsSetProperties['{shapeName}'] lists member '{memberName}', which the shape does not have.");
                }
            }
        }

        // Likewise keyed by the emitted property name.
        foreach (var (shapeName, swaps) in customizations.DataTypeSwaps)
        {
            if (FindSingleShape(model, shapeName, $"dataTypeSwap['{shapeName}']") is not StructureShape structure)
            {
                throw new GeneratorException($"dataTypeSwap['{shapeName}'] targets a shape that is not a structure.");
            }

            foreach (var (memberName, swap) in swaps)
            {
                ValidateDataTypeSwap(model, structure, memberName, swap, shapeName);
            }
        }
    }

    // A C# rename is exactly what Smithy's service `rename` expresses, and ServiceIndex.ToDotNetName already
    // applies it to every emitted symbol; the shape ID stays put, so member targets still resolve.
    private static void ApplyRename(SmithyModel model, string shapeName, string newName)
    {
        var context = $"shapeSubstitutions['{shapeName}']";
        var service = model.Shapes.Values.OfType<ServiceShape>().SingleOrDefault()
            ?? throw new GeneratorException($"{context} needs a single service shape to record the rename on.");
        var id = FindSingleShapeId(model, shapeName, context);
        var shape = model.Shapes[id.AbsoluteName];

        // Even an identical rename means the customization is stale and should be removed.
        if (service.Rename.TryGetValue(id.AbsoluteName, out var existing))
        {
            throw new GeneratorException($"{context} renames '{id}' to '{newName}', but the model already renames it to '{existing}'.");
        }

        ThrowIfEmitted(model, service.Rename, shape, newName, $"{context} renames '{id}' to '{newName}'");
        service.Rename[id.AbsoluteName] = newName;
    }

    // Smithy-only form, keyed "Structure$member": one Smithy shape can stand for several C2J shapes (QApps'
    // Action is C2J's PermissionInputActionEnum and PermissionOutputActionEnum), so the member gets its own
    // copy under the C2J name. The original is dropped once nothing targets it, or it would still be emitted.
    private static void RenameMemberTarget(SmithyModel model, string structureName, string memberName, string newName)
    {
        var context = $"shapeSubstitutions['{structureName}${memberName}']";
        var structureId = FindSingleShapeId(model, structureName, context);
        if (model.Shapes[structureId.AbsoluteName] is not StructureShape structure || !structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"{context} does not name a structure member in the model.");
        }

        var original = model.Shapes.GetValueOrDefault(member.Target.AbsoluteName)
            ?? throw new GeneratorException($"{context} targets '{member.Target}', which is not a shape in the model.");

        // TODO: a structure copy would share its Members with the original, so a member rename would hit both.
        if (original is StructureShape)
        {
            throw new GeneratorException($"{context} targets structure '{member.Target}'; duplicating a structure is not supported yet.");
        }

        var renames = model.Shapes.Values.OfType<ServiceShape>().SingleOrDefault()?.Rename ?? [];
        ThrowIfEmitted(model, renames, original, newName, $"{context} copies '{member.Target}' as '{newName}'");

        // ThrowIfEmitted compares emitted names, so it misses a shape at this ID that the service renames away.
        var id = new ShapeId(member.Target.Namespace, newName);
        if (model.Shapes.ContainsKey(id.AbsoluteName))
        {
            throw new GeneratorException($"{context} copies '{member.Target}' as '{newName}', but '{id}' is already a shape in the model.");
        }

        model.Shapes[id.AbsoluteName] = original with { Id = id, Traits = new(original.Traits) };
        structure.Members[memberName] = member with { Target = id };

        if (!IsTargeted(model, member.Target))
        {
            model.Shapes.Remove(member.Target.AbsoluteName);
        }
    }

    // TODO: C2J merges shapes renamed to one name (S3's Grant and TargetGrant both become S3Grant). This also
    // scans unreachable shapes: S3 renames Rule, used only by operations it excludes, to its existing LifecycleRule.
    // Exceptions share the model namespace, so compare the generated type names (error Foo emits FooException).
    private static void ThrowIfEmitted(SmithyModel model, Dictionary<string, string> renames, Shape? renamed, string newName, string context)
    {
        var typeName = TypeName(renamed, newName);
        var clash = model.Shapes.FirstOrDefault(kvp => TypeName(kvp.Value, EmittedName(renames, ShapeId.Parse(kvp.Key))) == typeName).Key;
        if (clash is not null)
        {
            throw new GeneratorException($"{context}, which '{clash}' is already emitted as.");
        }
    }

    private static string TypeName(Shape? shape, string name) => shape?.IsError() == true ? ExceptionWriter.ToExceptionName(name) : name;

    private static bool IsTargeted(SmithyModel model, ShapeId id) => model.Shapes.Values.Any(shape => shape switch
    {
        StructureShape structure => structure.Members.Values.Any(member => member.Target == id),
        ListShape list => list.Member.Target == id,
        MapShape map => map.Key.Target == id || map.Value.Target == id,
        _ => false,
    });

    private static string EmittedName(Dictionary<string, string> renames, ShapeId id) => renames.GetValueOrDefault(id.AbsoluteName, id.Name);

    // Customizations key shapes by bare name (C2J has no namespaces).
    private static Shape FindSingleShape(SmithyModel model, string bareName, string context)
    {
        var id = FindSingleShapeId(model, bareName, context);
        return model.Shapes[id.AbsoluteName] ?? throw new GeneratorException($"{context} matched a null shape entry '{id}'.");
    }

    private static ShapeId FindSingleShapeId(SmithyModel model, string bareName, string context)
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

    private static void ValidateDataTypeSwap(SmithyModel model, StructureShape structure, string memberName, DataTypeSwap swap, string shapeName)
    {
        if (!structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"dataTypeSwap['{shapeName}'] swaps member '{memberName}', which the shape does not have.");
        }

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

    private static void ApplyMember(StructureShape structure, string memberName, PropertyModifier property, string shapeName)
    {
        if (!structure.Members.TryGetValue(memberName, out var member))
        {
            throw new GeneratorException($"shapeModifiers['{shapeName}'] modifies member '{memberName}', which the shape does not have.");
        }

        if (property.DeprecatedMessage is { } message)
        {
            member.SetDeprecatedMessage(message);
        }

        if (property.EmitPropertyName is { } newName && newName != memberName)
        {
            // C2J uses emitPropertyName verbatim, but the property name derives from the member key
            // via ToUpperFirstCharacter — a name that call would alter can't be honored.
            if (SdkNaming.ToUpperFirstCharacter(newName) != newName)
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames '{memberName}' to '{newName}', which would not be emitted verbatim.");
            }

            // Compare property names, not keys: 'expiry' and a rename to 'Expiry' both emit 'Expiry'.
            if (structure.Members.Keys.Any(k => k != memberName && SdkNaming.ToUpperFirstCharacter(k) == newName))
            {
                throw new GeneratorException($"shapeModifiers['{shapeName}'] renames '{memberName}' to '{newName}', which the shape already has.");
            }

            structure.Members[newName] = member;

            // The JSON body wire name falls back to the member name; pin the original before the rename changes it.
            if (member.GetJsonName() is null)
            {
                member.SetJsonName(memberName);
            }

            structure.Members.Remove(memberName);
        }
    }
}
