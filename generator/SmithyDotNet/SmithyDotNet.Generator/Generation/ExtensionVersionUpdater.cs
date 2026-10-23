using System.Text.RegularExpressions;
using System.Xml;
using SmithyDotNet.Generator.Generation.Manifests;

namespace SmithyDotNet.Generator.Generation;

// TODO: Remove once the extensions move to unified projects; their versions will then flow as the services' do.
/// <summary>
/// Stamps each extension's nuspec and <c>Properties/AssemblyInfo.cs</c> with its <c>_sdk-versions.json</c> entry. The
/// files are hand-written, so they're edited in place, as C2J's <c>GeneratorExtensionsDriver</c> does: the nuspec is
/// saved through <see cref="XmlDocument"/> only when its version changes, which keeps C2J's formatting.
/// </summary>
public static partial class ExtensionVersionUpdater
{
    private const string PackagePrefix = "AWSSDK.";
    private const string ExtensionPrefix = $"{PackagePrefix}Extensions.";

    public static void Update(string extensionsRoot, SdkVersionManifest manifest)
    {
        foreach (var directory in Directory.GetDirectories(extensionsRoot).Order(StringComparer.Ordinal))
        {
            var packageId = Path.GetFileName(directory);
            var nuspecPath = Path.Combine(directory, $"{packageId}.nuspec");
            // An extension without a nuspec isn't shipped.
            if (!File.Exists(nuspecPath))
            {
                continue;
            }

            if (!packageId.StartsWith(ExtensionPrefix, StringComparison.Ordinal))
            {
                throw new GeneratorException($"{packageId} has a nuspec but isn't named {ExtensionPrefix}*.");
            }

            var extensionName = packageId[ExtensionPrefix.Length..];
            var (version, entry) = manifest.GetExtension(extensionName);
            UpdateNuspec(nuspecPath, packageId, version, entry.Dependencies);
            UpdateAssemblyInfo(Path.Combine(directory, "Properties", "AssemblyInfo.cs"), manifest.GetExtensionAssemblyVersion(extensionName), version);
        }
    }

    private static void UpdateNuspec(string path, string packageId, string version, IReadOnlyDictionary<string, string> dependencies)
    {
        var document = new XmlDocument();
        document.Load(path);
        var versionNode = document.SelectSingleNode("/package/metadata/version") ?? throw new GeneratorException($"'{path}' has no version.");
        var versionUpdated = versionNode.InnerText != version;
        versionNode.InnerText = version;

        var dependenciesUpdated = false;
        var nuspecDependencies = new HashSet<string>(StringComparer.Ordinal);
        foreach (XmlElement node in document.GetElementsByTagName("dependency"))
        {
            var id = node.GetAttribute("id");
            if (!id.StartsWith(PackagePrefix, StringComparison.Ordinal))
            {
                continue;
            }

            var dependency = id[PackagePrefix.Length..];
            nuspecDependencies.Add(dependency);
            if (!dependencies.TryGetValue(dependency, out var dependencyVersion))
            {
                throw new GeneratorException($"{packageId}'s nuspec depends on {id}, which its _sdk-versions.json entry doesn't list.");
            }

            if (node.GetAttribute("version") != dependencyVersion)
            {
                node.SetAttribute("version", dependencyVersion);
                dependenciesUpdated = true;
            }
        }

        // A dependency bump ships only in a new extension version.
        if (dependenciesUpdated && !versionUpdated)
        {
            throw new GeneratorException($"{packageId}'s dependencies changed but its version didn't.");
        }

        if (dependencies.Keys.FirstOrDefault(dependency => !nuspecDependencies.Contains(dependency)) is { } missing)
        {
            throw new GeneratorException($"{packageId}'s _sdk-versions.json entry lists {missing}, which its nuspec doesn't depend on.");
        }

        if (versionUpdated)
        {
            document.Save(path);
        }
    }

    private static void UpdateAssemblyInfo(string path, string assemblyVersion, string fileVersion)
    {
        if (!File.Exists(path))
        {
            return;
        }

        var contents = File.ReadAllText(path);
        var updated = AssemblyVersion().Replace(contents, $"""[assembly: AssemblyVersion("{assemblyVersion}")]""");
        updated = AssemblyFileVersion().Replace(updated, $"""[assembly: AssemblyFileVersion("{fileVersion}")]""");
        if (updated != contents)
        {
            File.WriteAllText(path, updated);
        }
    }

    [GeneratedRegex("""\[assembly:\s*AssemblyVersion\s*\(\s*"[^"]*"\s*\)\]""")]
    private static partial Regex AssemblyVersion();

    [GeneratedRegex("""\[assembly:\s*AssemblyFileVersion\s*\(\s*"[^"]*"\s*\)\]""")]
    private static partial Regex AssemblyFileVersion();
}
