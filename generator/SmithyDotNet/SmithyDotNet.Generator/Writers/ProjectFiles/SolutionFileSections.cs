namespace SmithyDotNet.Generator.Writers.ProjectFiles;

/// <summary>
/// Entries and sections shared by the <c>.sln</c> writers (<see cref="SdkSolutionFileWriter"/> and
/// <see cref="CodeAnalysis.CodeAnalysisSolutionFileWriter"/>).
/// </summary>
internal static class SolutionFileSections
{
    private const string FolderType = "{2150E333-8FDC-42A3-9474-1A3956D46DE8}";
    private const string ProjectType = "{9A19103F-16F7-4668-BE54-9A1E7A4F7556}";
    private static readonly string[] Configurations = ["Debug", "Release"];

    /// <summary>Creates a writer for a solution file, which indents with tabs.</summary>
    internal static CodeWriter NewWriter() => new("\t");

    /// <summary>
    /// Orders like C2J's <c>OrderBy</c>, which compares by the current culture: <c>AccessAnalyzer</c> precedes
    /// <c>ACMPCA</c>. The invariant culture keeps the output the same on every machine; it matches C2J under en-US.
    /// </summary>
    internal static IEnumerable<string> Sorted(IEnumerable<string> paths) => paths.Order(StringComparer.InvariantCulture);

    internal static void WriteFolder(CodeWriter writer, string name, string guid) => WriteEntry(writer, FolderType, name, name, guid);

    internal static void WriteProject(CodeWriter writer, string name, string path, string guid) => WriteEntry(writer, ProjectType, name, path, guid);

    private static void WriteEntry(CodeWriter writer, string type, string name, string path, string guid)
    {
        writer.WriteLine($"""
            Project("{type}") = "{name}", "{path}", "{guid}"
            """);
        writer.WriteLine("EndProject");
    }

    /// <summary>Writes a <c>GlobalSection</c> named <paramref name="name"/> around <paramref name="body"/>.</summary>
    internal static void WriteGlobalSection(CodeWriter writer, string name, string timing, Action body)
    {
        writer.Indent(() =>
        {
            writer.WriteLine($"GlobalSection({name}) = {timing}");
            writer.Indent(body);
            writer.WriteLine("EndGlobalSection");
        });
    }

    internal static void WriteSolutionConfigurationPlatforms(CodeWriter writer)
    {
        WriteGlobalSection(writer, "SolutionConfigurationPlatforms", "preSolution", () =>
        {
            foreach (var configuration in Configurations)
            {
                writer.WriteLine($"{configuration}|Any CPU = {configuration}|Any CPU");
            }
        });
    }

    /// <summary>Writes the Debug and Release build entries of the project with <paramref name="guid"/>.</summary>
    internal static void WriteProjectConfigurationPlatforms(CodeWriter writer, string guid)
    {
        foreach (var configuration in Configurations)
        {
            writer.WriteLine($"{guid}.{configuration}|Any CPU.ActiveCfg = {configuration}|Any CPU");
            writer.WriteLine($"{guid}.{configuration}|Any CPU.Build.0 = {configuration}|Any CPU");
        }
    }

    internal static void WriteSolutionProperties(CodeWriter writer)
    {
        WriteGlobalSection(writer, "SolutionProperties", "preSolution", () => writer.WriteLine("HideSolutionNode = FALSE"));
    }
}
