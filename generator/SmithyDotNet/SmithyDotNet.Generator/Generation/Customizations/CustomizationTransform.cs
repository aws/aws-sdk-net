using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// Applies model-shaped customization hooks to the Smithy model in place, before the
/// <see cref="ServiceIndex"/> is built. Only a hook with a Smithy trait equivalent (<c>deprecatedMessage</c>;
/// <c>renameShape</c> adds a service <c>rename</c> entry; <c>locationName</c> sets <c>@ec2QueryName</c>) or a
/// structural edit (a member-keyed <c>renameShape</c> copies the member's target; <c>exclude</c> unbinds an operation
/// or drops members; <c>useWrappingResult</c> wraps an output; <c>emitAsShape</c> retargets members; <c>inject</c> adds
/// one; <c>flattenShapes</c> replaces a payload with its members; <c>mergedEnums</c> copies enum values; <c>suppressResultGeneration</c> drops an output) is applied to the model; the rest, member renames included,
/// are checked by <see cref="CustomizationValidator"/> and read from <see cref="GenerationContext.Customizations"/> by shape and member name where the
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
        // TODO: change S3's customizations files when S3 moves off C2J (C2J still reads the current format):
        // - rekey its renamed structures' entries by modeled name (BucketLifecycleConfiguration, keyed today as
        //   LifecycleConfiguration);
        // - C2J's injectXmlPropertyGetter/Setter, renamed injectPropertyGetter/Setter here. On a renamed member C2J reads
        //   them by the new name, so S3 puts them in a second entry (CopyObjectRequest's ModifiedSinceDate beside
        //   CopySourceIfModifiedSince's emitPropertyName). They belong in the modeled member's entry; the new-name entry
        //   otherwise fails as an unknown member.
        // - C2J's injectXmlMarshallCode(InPayload), renamed injectMarshallCode(InPayload) here; RestoreRequest's lines
        //   move to RestoreObjectRequest, which takes the flattened member.
        // - C2J's injectXmlUnmarshallCode, injectXmlUnmarshallResultCode and injectXmlPrivateMemberAssignment lose the "Xml";
        //   skipContextTestExpressionUnmarshallingLogic goes, and predicateListUnmarshallers become injectUnmarshallCode lines.
        //   A response's lines name the response "unmarshalledObject", not "response".
        // - a shape modified from two files (C2J merges the entries, the loader throws): keep each shape in one file.
        // - inheritAlternateBaseClass: "PutObjectRequest": { "alternateBaseClass": "PutWithACLRequest" } becomes
        //   "PutObjectRequest": "PutWithACLRequest".
        // - mergedEnums: "ObjectStorageClass": { "mergeInto": "StorageClass" } becomes "ObjectStorageClass": "StorageClass".
        //   MFADelete and MFADeleteStatus merge into VersionStatus, which is only BucketVersioningStatus's renameShape
        //   name: a no-op in C2J, a throw here. Move both to excludeShapes; rekeying them would add a
        //   VersionStatus.Disabled the shipped SDK doesn't have.
        ShapeSubstitutions.Apply(model, customizations);

        // Before shapeModifiers, which address a flattened member on its new parent, as C2J does (S3's RestoreObjectRequest.Tier).
        FlattenShapes.Apply(model, customizations);

        // Before shapeModifiers, so a merged value is a member of the target like any other.
        MergedEnums.Apply(model, customizations);

        ShapeModifiers.Apply(model, customizations);
        OperationModifiers.Apply(model, customizations);
    }

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
}
