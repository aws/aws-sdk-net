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

    // Adds the entry to `into` when given, so one modifier can carry several.
    public static ShapeModifier Modify(string member, PropertyModifier property, ShapeModifier? into = null)
    {
        var modifier = into ?? new ShapeModifier();
        var entry = new Dictionary<string, PropertyModifier>();
        entry[member] = property;
        modifier.Modify.Add(entry);
        return modifier;
    }

    public static ShapeModifier Inject(string member, PropertyInjector injector, ShapeModifier? into = null)
    {
        var modifier = into ?? new ShapeModifier();
        var entry = new Dictionary<string, PropertyInjector>();
        entry[member] = injector;
        modifier.Inject.Add(entry);
        return modifier;
    }
}
