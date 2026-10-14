namespace SmithyDotNet.Generator.Generation.ProjectFiles;

/// <summary>
/// An <c>AWSSDK.Extensions.*</c> package a service depends on, and the csproj files it ships.
/// A project with a <see cref="ExtensionProject.Variant"/> is referenced only by that service project
/// variant; a project without one (a single multi-targeted csproj) is referenced by both.
/// </summary>
public sealed record SdkExtension(string Name, IReadOnlyList<ExtensionProject> Projects)
{
    public string PackageId => $"AWSSDK.Extensions.{Name}";

    public static readonly SdkExtension CborProtocol = new("CborProtocol",
    [
        new(Project("CborProtocol", "AWSSDK.Extensions.CborProtocol.NetFramework.csproj"), "NetFramework"),
        new(Project("CborProtocol", "AWSSDK.Extensions.CborProtocol.NetStandard.csproj"), "NetStandard"),
    ]);

    private static string Project(string name, string fileName) =>
        Utils.PathCombineAlt(SdkTreeLayout.ExtensionsRootFromServiceSource, $"AWSSDK.Extensions.{name}", fileName);
}

/// <summary>A csproj shipped by an extension, relative to a service source folder.</summary>
public sealed record ExtensionProject(string Path, string? Variant);
