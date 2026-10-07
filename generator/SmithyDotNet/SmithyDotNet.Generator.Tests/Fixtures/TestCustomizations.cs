using SmithyDotNet.Generator.Generation.Customizations;

namespace SmithyDotNet.Generator.Tests;

/// <summary>Builds the one-hook <see cref="CustomizationsModel"/>s the writer tests need.</summary>
internal static class TestCustomizations
{
    public static CustomizationsModel Rename(string shape, string member, string newName)
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeModifiers[shape] = RenameMember(member, newName);
        return customizations;
    }

    public static ShapeModifier RenameMember(string member, string newName) =>
        Modify(member, new PropertyModifier { EmitPropertyName = newName });

    public static ShapeModifier Modify(string member, PropertyModifier property)
    {
        var modifier = new ShapeModifier();
        modifier.Modify.Add(new Dictionary<string, PropertyModifier> { [member] = property });
        return modifier;
    }
}
