using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation.ProjectFiles;

namespace SmithyDotNet.Generator.Writers.ProjectFiles;

/// <summary>
/// Emits <c>sdk/AWSSDK.{NetFramework|NetStandard}.sln</c>, the solutions that build Core, every service and the shared
/// tests, as C2J's <c>SolutionFileCreator</c> does through its <c>SolutionFileBclAndNetStandard.tt</c>. Project and
/// folder GUIDs are read back from the existing solution by name, so only a new project gets a new GUID; C2J reads the
/// same file, so the two generators agree on it.
/// </summary>
public sealed partial class SdkSolutionFileWriter(string sdkRoot)
{
    private const string CoreFolderGuid = "{9863FCB3-BFA4-4B9C-B8F6-302BA5F660B8}";
    private const string ServicesFolderGuid = "{939EC5C2-8345-43E2-8F97-72EEEBEEA0AB}";
    private const string TestFolderGuid = "{12EC4E4B-7E2C-4B63-8EF9-7B959F82A89B}";
    private const string TestDependenciesFolderGuid = "{939EC5C2-8345-43E2-8F97-72EEEBEEA0AC}";

    private sealed record Project(string Name, string Path, string Guid);

    private sealed record ServiceFolder(string Name, string Guid, IReadOnlyList<Project> Projects);

    public static string FileName(string variant) => $"AWSSDK.{variant}.sln";

    public string Write(string variant)
    {
        var existingPath = Path.Combine(sdkRoot, FileName(variant));
        var existing = File.Exists(existingPath) ? File.ReadAllText(existingPath) : "";
        // As in C2J, a name listed twice keeps its last GUID.
        var guids = new Dictionary<string, string>();
        foreach (Match project in ProjectLine().Matches(existing))
        {
            guids[project.Groups["name"].Value] = project.Groups["guid"].Value;
        }
        var solutionGuid = SolutionGuidLine().Match(existing) is { Success: true } match ? match.Groups["guid"].Value : Guid.NewGuid().ToString("D").ToUpperInvariant();
        Project ProjectOf(string name, string path) => new(name, path, guids.TryGetValue(name, out var guid) ? guid : Utils.NewProjectGuid);

        var core = SortedFiles(Path.Combine(sdkRoot, "src", "Core"), variant, SearchOption.TopDirectoryOnly)
            .Select(file => ProjectOf(Path.GetFileNameWithoutExtension(file), $"src/Core/{Path.GetFileName(file)}"))
            // Some services need the CBOR extension, so it builds with Core.
            .Append(ProjectOf($"AWSSDK.Extensions.CborProtocol.{variant}", $"../extensions/src/AWSSDK.Extensions.CborProtocol/AWSSDK.Extensions.CborProtocol.{variant}.csproj"))
            .ToList();
        var services = new[] { "src", "test" }
            .SelectMany(tree => SolutionFileSections.Sorted(Directory.GetDirectories(Path.Combine(sdkRoot, tree, "Services"))).Select(directory => (tree, directory)))
            .Select(service =>
            {
                var name = Path.GetFileName(service.directory);
                var projects = SortedFiles(service.directory, variant, SearchOption.TopDirectoryOnly)
                    .Select(file => ProjectOf(Path.GetFileNameWithoutExtension(file), $"{service.tree}/Services/{name}/{Path.GetFileName(file)}"))
                    .ToList();
                return new ServiceFolder(name, guids.TryGetValue(name, out var guid) ? guid : Utils.NewProjectGuid, projects);
            })
            .Where(folder => folder.Projects.Count > 0)
            .ToList();
        var testRoot = Path.Combine(sdkRoot, "test");
        // C2J's fixed GUIDs for the shared projects, whatever the existing solution holds.
        List<Project> tests =
        [
            new("AWSSDK.CommonTest", $"test/Common/{ProjectFileNames.CommonTest}", "{66F78F86-68D7-4538-8EA5-A669A08E1C19}"),
            new("AWSSDK.UnitTestUtilities", $"test/UnitTests/Custom/{ProjectFileNames.UnitTestUtility}", "{002B183F-E568-49CD-9D06-CBCFF2C2921F}"),
            .. SortedFiles(testRoot, variant, SearchOption.AllDirectories)
                .Select(file => (name: Path.GetFileNameWithoutExtension(file), relative: Utils.ConvertPathAlt(Path.GetRelativePath(testRoot, file))))
                .Where(project => IsListedTest(project.name, project.relative))
                .Select(project => ProjectOf(project.name, $"test/{project.relative}")),
            new("ServiceClientGeneratorLib", $"../generator/ServiceClientGeneratorLib/{ProjectFileNames.GeneratorLib}", "{7BEE7C44-BE12-43CC-AFB9-B5852A1F43C8}"),
        ];
        Project[] testDependencies = [ProjectOf($"AWSSDK.Extensions.CrtIntegration.{variant}", $"../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.{variant}.csproj")];

        var writer = SolutionFileSections.NewWriter();
        writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
        writer.WriteLine("# Visual Studio 15");
        writer.WriteLine("VisualStudioVersion = 15.0.26730.12");
        writer.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1");
        SolutionFileSections.WriteFolder(writer, "Core", CoreFolderGuid);
        WriteProjects(writer, core);
        SolutionFileSections.WriteFolder(writer, "Services", ServicesFolderGuid);
        foreach (var folder in services)
        {
            SolutionFileSections.WriteFolder(writer, folder.Name, folder.Guid);
            WriteProjects(writer, folder.Projects);
        }
        SolutionFileSections.WriteFolder(writer, "Test", TestFolderGuid);
        WriteProjects(writer, tests);
        SolutionFileSections.WriteFolder(writer, "TestDependencies", TestDependenciesFolderGuid);
        WriteProjects(writer, testDependencies);
        writer.WriteLine("Global");
        SolutionFileSections.WriteSolutionConfigurationPlatforms(writer);
        SolutionFileSections.WriteGlobalSection(writer, "ProjectConfigurationPlatforms", "postSolution", () =>
        {
            foreach (var project in core.Concat(services.SelectMany(folder => folder.Projects)).Concat(tests).Concat(testDependencies))
            {
                SolutionFileSections.WriteProjectConfigurationPlatforms(writer, project.Guid);
            }
        });
        SolutionFileSections.WriteSolutionProperties(writer);
        SolutionFileSections.WriteGlobalSection(writer, "NestedProjects", "preSolution", () =>
        {
            WriteNesting(writer, core, CoreFolderGuid);
            foreach (var folder in services)
            {
                writer.WriteLine($"{folder.Guid} = {ServicesFolderGuid}");
                WriteNesting(writer, folder.Projects, folder.Guid);
            }
            WriteNesting(writer, tests, TestFolderGuid);
            WriteNesting(writer, testDependencies, TestDependenciesFolderGuid);
        });
        SolutionFileSections.WriteGlobalSection(writer, "ExtensibilityGlobals", "postSolution", () =>
            writer.WriteLine($"SolutionGuid = {{{solutionGuid}}}"));
        writer.WriteLine("EndGlobal");
        return writer.ToRawString().TrimEnd();
    }

    // C2J's filter. C2J tests these names against the full path, which drops every project when the clone's path
    // contains one.
    private static bool IsListedTest(string name, string relativePath)
    {
        if (relativePath.Contains("Services") || relativePath.Contains("CSM"))
        {
            return false;
        }

        return name.Contains("UnitTestUtilities") || !name.Contains("Utilities");
    }

    private static IEnumerable<string> SortedFiles(string directory, string variant, SearchOption option) =>
        SolutionFileSections.Sorted(Directory.GetFiles(directory, $"*.{variant}.csproj", option));

    private static void WriteProjects(CodeWriter writer, IEnumerable<Project> projects)
    {
        foreach (var project in projects)
        {
            SolutionFileSections.WriteProject(writer, project.Name, project.Path, project.Guid);
        }
    }

    private static void WriteNesting(CodeWriter writer, IEnumerable<Project> projects, string folderGuid)
    {
        foreach (var project in projects)
        {
            writer.WriteLine($"{project.Guid} = {folderGuid}");
        }
    }

    [GeneratedRegex("""Project\("\{[^"]*\}"\)\s*=\s*"(?<name>[^"]*)",\s*"[^"]*",\s*"(?<guid>[^"]*)""")]
    private static partial Regex ProjectLine();

    [GeneratedRegex("""SolutionGuid\s*=\s*\{(?<guid>[^}]*)\}""")]
    private static partial Regex SolutionGuidLine();
}
