using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using static SmithyDotNet.Generator.Generation.Customizations.CustomizationTransform;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The <c>mergedEnums</c> hook: an enum's values are added to the enum it maps to, and the merged enum gets no
/// class (S3's <c>ObjectStorageClass</c> into <c>StorageClass</c>). As in C2J, a member targeting the merged enum is still
/// typed by its name, so S3 swaps those members to the target with <c>dataTypeSwap</c>.
/// </summary>
internal static class MergedEnums
{
    public static void Apply(SmithyModel model, CustomizationsModel customizations)
    {
        foreach (var (sourceName, mergeInto) in customizations.MergedEnums)
        {
            var context = $"mergedEnums['{sourceName}']";
            if (FindSingleShape(model, sourceName, context) is not EnumShape source
                || FindSingleShape(model, mergeInto, $"{context} mergeInto '{mergeInto}'") is not EnumShape target)
            {
                throw new GeneratorException($"{context} merges a shape that is not an enum, or into one.");
            }

            // A chain would depend on the order the entries are applied in.
            if (customizations.MergedEnums.ContainsKey(mergeInto))
            {
                throw new GeneratorException($"{context} merges into '{mergeInto}', which is itself merged.");
            }

            foreach (var (memberName, member) in source.Members)
            {
                var value = member.GetEnumValue();
                if (target.Members.Values.Any(existing => existing.GetEnumValue() == value))
                {
                    continue;
                }

                if (!target.Members.TryAdd(memberName, member))
                {
                    throw new GeneratorException($"{context} adds member '{memberName}', which '{mergeInto}' has with a different value.");
                }
            }
        }
    }
}
