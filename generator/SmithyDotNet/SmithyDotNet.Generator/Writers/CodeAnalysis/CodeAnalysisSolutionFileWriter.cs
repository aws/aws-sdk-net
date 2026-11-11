using SmithyDotNet.Generator.Writers.ProjectFiles;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

/// <summary>
/// Emits <c>sdk/AWSSDK.CodeAnalysis.sln</c>: every <c>AWSSDK.*.csproj</c> under <c>sdk/code-analysis</c> plus the shared
/// analyzer projects, as C2J's <c>CodeAnalysisSolutionCreator</c> does through its <c>CodeAnalysisSolutionFile.tt</c>.
/// Each project's GUID is its own <c>&lt;ProjectGuid&gt;</c>. C2J writes this file untrimmed, so it keeps its leading
/// and final newlines.
/// </summary>
public sealed class CodeAnalysisSolutionFileWriter(string sdkRoot)
{
    public const string FileName = "AWSSDK.CodeAnalysis.sln";

    private const string ServiceAnalysisFolderGuid = "{1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}";

    private static readonly (string Name, string Path, string Guid)[] SharedProjects =
    [
        ("SharedAnalysisCode", "code-analysis/SharedAnalysisCode/SharedAnalysisCode.csproj", "{16E2A13F-F4F6-4774-A2D8-AD8127E7EE4F}"),
        ("MockAnalyzer", "code-analysis/MockAnalyzer/MockAnalyzer.csproj", "{9BC3B08B-9F09-444E-AD15-67045FA3AF19}"),
        ("AnalyzerUnitTests", @"code-analysis\AnalyzerUnitTests\AnalyzerUnitTests.csproj", "{FB4B26D0-2E81-4673-9001-D0C859D8CEA1}"),
    ];

    public string Write()
    {
        var projects = SolutionFileSections.Sorted(Directory.GetFiles(Path.Combine(sdkRoot, "code-analysis"), "AWSSDK.*.csproj", SearchOption.AllDirectories))
            .Select(file => (Name: Path.GetFileNameWithoutExtension(file), Path: Utils.ConvertPathAlt(Path.GetRelativePath(sdkRoot, file)), Guid: Utils.GetProjectGuid(file)))
            .ToList();

        var writer = SolutionFileSections.NewWriter();
        writer.WriteLine();
        writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
        writer.WriteLine("# Visual Studio Version 17");
        writer.WriteLine("VisualStudioVersion = 17.6.33815.320");
        writer.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1");
        SolutionFileSections.WriteFolder(writer, "ServiceAnalysis", ServiceAnalysisFolderGuid);
        foreach (var project in projects.Concat(SharedProjects))
        {
            SolutionFileSections.WriteProject(writer, project.Name, project.Path, project.Guid);
        }
        writer.WriteLine();
        writer.WriteLine("Global");
        SolutionFileSections.WriteSolutionConfigurationPlatforms(writer);
        SolutionFileSections.WriteGlobalSection(writer, "ProjectConfigurationPlatforms", "postSolution", () =>
        {
            foreach (var project in projects.Concat(SharedProjects))
            {
                SolutionFileSections.WriteProjectConfigurationPlatforms(writer, project.Guid);
            }
        });
        SolutionFileSections.WriteSolutionProperties(writer);
        SolutionFileSections.WriteGlobalSection(writer, "NestedProjects", "preSolution", () =>
        {
            foreach (var project in projects)
            {
                writer.WriteLine($"{project.Guid} = {ServiceAnalysisFolderGuid}");
            }
        });
        writer.WriteLine("EndGlobal");
        return writer.ToRawString();
    }
}
