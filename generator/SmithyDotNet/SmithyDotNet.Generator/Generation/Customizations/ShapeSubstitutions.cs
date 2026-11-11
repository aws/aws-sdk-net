using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>shapeSubstitutions</c> hooks: <c>renameShape</c> adds a service <c>rename</c> entry (or, keyed
/// <c>Structure$member</c>, copies the member's target), and <c>emitAsShape</c> retargets members, unwrapping a value
/// with <c>emitFromMember</c>.
/// </summary>
internal static class ShapeSubstitutions
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (key, substitution) in customizations.ShapeSubstitutions)
        {
            if (substitution.EmitAsShape is { } emittedShape && substitution.RenamedShapeName is null)
            {
                if (substitution.EmitFromMember is { } valueMember)
                {
                    UnwrapShape(model, key, emittedShape, valueMember, substitution.ListMemberSuffixExclusions, customizations);
                }
                else if (substitution.ListMemberSuffixExclusions.Count > 0)
                {
                    throw new GeneratorException($"shapeSubstitutions['{key}'] lists listMemberSuffixExclusions without an emitFromMember.");
                }
                else
                {
                    SubstituteShape(model, key, emittedShape, customizations);
                }
                continue;
            }
            if (substitution.EmitAsShape is not null)
            {
                throw new GeneratorException($"shapeSubstitutions['{key}'] mixes renameShape with emitAsShape.");
            }
            if (substitution.EmitFromMember is not null || substitution.ListMemberSuffixExclusions.Count > 0)
            {
                throw new GeneratorException($"shapeSubstitutions['{key}'] sets emitFromMember or listMemberSuffixExclusions, which need emitAsShape.");
            }
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
    }

    // C2J's emitAsShape + emitFromMember (ec2's AttributeValue): only checked here. TypeMapper types a member that targets
    // the wrapper as the value, the query writers keep the wrapper on the wire, and the wrapper itself is not emitted.
    private static void UnwrapShape(SmithyModel model, string wrapperName, string emittedShape, string valueMember, List<string> suffixExclusions, CustomizationsModel customizations)
    {
        var context = $"shapeSubstitutions['{wrapperName}']";
        var id = FindSingleShapeId(model, wrapperName, context);
        if (model.Shapes[id.AbsoluteName] is not StructureShape wrapper || !wrapper.Members.TryGetValue(valueMember, out var value))
        {
            throw new GeneratorException($"{context} emits from member '{valueMember}', which the shape does not have.");
        }
        // The value's type may be substituted too (ec2's Blob becomes String), whichever entry comes first.
        var valueType = customizations.ShapeSubstitutions.GetValueOrDefault(value.Target.Name) is { RenamedShapeName: null, EmitFromMember: null, EmitAsShape: { } substitute }
            ? substitute
            : value.Target.Name;
        if (valueType != emittedShape)
        {
            throw new GeneratorException($"{context} emits '{emittedShape}', but member '{valueMember}' targets '{value.Target}'.");
        }
        RejectUnsupportedTargets(model, id, context);

        foreach (var operationName in suffixExclusions)
        {
            FindOperation(model, operationName, $"{context} listMemberSuffixExclusions['{operationName}']");
        }
    }

    // C2J's emitAsShape alone: members target another modeled shape (ec2's RequestSpotLaunchSpecification becomes
    // LaunchSpecification, Blob becomes String).
    private static void SubstituteShape(SmithyModel model, string oldName, string newName, CustomizationsModel customizations)
    {
        var context = $"shapeSubstitutions['{oldName}']";
        var from = FindSingleShapeId(model, oldName, context);
        var to = FindSingleShapeId(model, newName, context);
        customizations.ShapeModifiers.Remove(oldName, out var oldModifier);

        // C2J marshals a substituted member with the old name's modifiers alone, so every request-only key the new shape
        // sets must be matched by the old name, or made moot by its customMarshall.
        if (customizations.ShapeModifiers.TryGetValue(newName, out var newModifier) && UnmirroredMember(newModifier, oldModifier) is { } unmirrored)
        {
            throw new GeneratorException($"{context}: shapeModifiers['{newName}'] sets an inject, locationName or customMarshall on '{unmirrored}' that shapeModifiers['{oldName}'] does not mirror.");
        }
        if (oldModifier is not null)
        {
            MergeSubstitutedModifier(model, oldName, to, oldModifier, customizations);
        }
        RetargetMembers(model, from, to, context);
    }

    private static string? UnmirroredMember(ShapeModifier newModifier, ShapeModifier? oldModifier)
    {
        foreach (var (memberName, property) in newModifier.Modify.SelectMany(entry => entry))
        {
            var old = oldModifier?.PropertyFor(memberName);
            if ((property.LocationName is not null || property.CustomMarshall) && !Mirrors(old?.LocationName, old?.CustomMarshall, property.LocationName, property.CustomMarshall))
            {
                return memberName;
            }
        }
        foreach (var (memberName, injector) in newModifier.Inject.SelectMany(entry => entry))
        {
            var old = oldModifier?.InjectorFor(memberName);
            if (!Mirrors(old?.LocationName, old?.CustomMarshall, injector.LocationName, injector.CustomMarshall))
            {
                return memberName;
            }
        }
        return null;

        // A null customMarshall means the old name has no entry for the member.
        static bool Mirrors(string? oldLocationName, bool? oldCustomMarshall, string? locationName, bool customMarshall) =>
            oldCustomMarshall == true || (oldLocationName == locationName && oldCustomMarshall == customMarshall);
    }

    // C2J applies the old name's modifiers only while it marshals a substituted member (ec2's RequestSpotInstances skips
    // LaunchSpecification.SecurityGroups), never to the emitted class. Folding them into the new shape's entry matches
    // that while no request sends the new shape itself and the keys leave the class alone.
    private static void MergeSubstitutedModifier(SmithyModel model, string oldName, ShapeId to, ShapeModifier modifier, CustomizationsModel customizations)
    {
        var context = $"shapeModifiers['{oldName}']";
        if (ServiceIndex.ReachableFrom(model, model.Shapes.Values.OfType<OperationShape>().Select(operation => operation.Input)).ContainsKey(to))
        {
            throw new GeneratorException($"{context} modifies a shape substituted by '{to}', which a request already sends; the modifiers can't apply to the substituted members alone.");
        }
        if (modifier.Exclude.Count > 0 || modifier.DeprecatedMessage is not null)
        {
            throw new GeneratorException($"{context} modifies a substituted shape, which only supports modify and inject.");
        }

        var newName = to.Name;
        var target = ShapeModifiers.ModifierFor(customizations, newName);

        foreach (var (memberName, property) in modifier.Modify.SelectMany(entry => entry))
        {
            if (property.DeprecatedMessage is not null || property.AccessModifier is not null || property.OverridesBaseMember
                || (property.EmitPropertyName ?? memberName) != customizations.EmittedName(newName, memberName))
            {
                throw new GeneratorException($"{context} modifies '{memberName}' in a way that changes the emitted '{newName}' class; only locationName and customMarshall are supported.");
            }

            // The old name's values are the ones C2J marshals with; a new-shape value they differ from is mooted by customMarshall.
            var entry = ShapeModifiers.ModifyEntry(target, memberName, new PropertyModifier());
            var existing = entry[memberName];
            entry[memberName] = existing with { LocationName = property.LocationName ?? existing.LocationName, CustomMarshall = existing.CustomMarshall || property.CustomMarshall };
        }

        foreach (var (memberName, injector) in modifier.Inject.SelectMany(entry => entry))
        {
            var entry = target.Inject.FirstOrDefault(entry => entry.ContainsKey(memberName));
            // SubstituteShape has already checked the locationName matches, or is moot under customMarshall.
            if (entry is null || entry[memberName].Shape != injector.Shape)
            {
                throw new GeneratorException($"{context} injects '{memberName}', which shapeModifiers['{newName}'] does not inject as '{injector.Shape}'.");
            }
            entry[memberName] = entry[memberName] with { CustomMarshall = entry[memberName].CustomMarshall || injector.CustomMarshall };
        }
    }

    // Points every structure and list member that targets `from` at `to`, and drops `from` so a stale reference to it fails.
    private static void RetargetMembers(SmithyModel model, ShapeId from, ShapeId to, string context)
    {
        RejectUnsupportedTargets(model, from, context);
        foreach (var (key, shape) in model.Shapes.ToList())
        {
            switch (shape)
            {
                case StructureShape structure:
                    foreach (var (memberName, member) in structure.Members.ToList())
                    {
                        if (member.Target == from)
                        {
                            structure.Members[memberName] = member with { Target = to };
                        }
                    }
                    break;
                case ListShape list when list.Member.Target == from:
                    model.Shapes[key] = list with { Member = list.Member with { Target = to } };
                    break;
            }
        }
        model.Shapes.Remove(from.AbsoluteName);
    }

    // The writers only resolve a substituted shape as a structure member or a list element.
    private static void RejectUnsupportedTargets(SmithyModel model, ShapeId id, string context)
    {
        foreach (var shape in model.Shapes.Values)
        {
            switch (shape)
            {
                case MapShape map when map.Key.Target == id || map.Value.Target == id:
                    throw new GeneratorException($"{context} substitutes a key or value of map '{map.Id}', which is not supported.");
                case OperationShape operation when operation.Input == id || operation.Output == id:
                    throw new GeneratorException($"{context} substitutes the input or output of '{operation.Id}', which is not supported.");
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
    // Service, resource and operation shapes emit no type of their own (an operation emits FooRequest and
    // FooResponse), so a rename may take their name, as C2J's models do (Pinpoint's CreateRecommenderConfiguration).
    private static void ThrowIfEmitted(SmithyModel model, Dictionary<string, string> renames, Shape? renamed, string newName, string context)
    {
        var typeName = TypeName(renamed, newName);
        foreach (var (id, shape) in model.Shapes)
        {
            if (shape is ServiceShape or ResourceShape or OperationShape)
            {
                continue;
            }

            var emittedName = EmittedName(renames, ShapeId.Parse(id));
            if (TypeName(shape, emittedName) == typeName)
            {
                throw new GeneratorException($"{context}, which '{id}' is already emitted as.");
            }
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
}
