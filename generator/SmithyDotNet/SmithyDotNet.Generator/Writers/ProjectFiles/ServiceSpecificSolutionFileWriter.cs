using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.ProjectFiles;

/// <summary>
/// Emits slnx files for services
/// </summary>
public class ServiceSpecificSolutionFileWriter(GenerationContext context)
{
    // Captures the quoted value of a <ProjectReference Include="..."/> element.
    private static readonly Regex ProjectReferenceRegex = new("\"([^\"]*)\"");
    private static string SdkRoot = Utils.PathCombineAlt("..", "..", "..");
    /// <summary>
    /// Writes the service's slnx. <paramref name="serviceDirectory"/> is the on-disk folder that
    /// holds the service's csproj files (and where this slnx is written); it is read to discover the
    /// service's project dependencies for the <c>/Services/</c> folder.
    /// </summary>
    public string Write(string serviceDirectory)
    {
        var writer = new CodeWriter();
        writer.OpenXmlBlock("Solution", () =>
        {
            AddCoreProjects(writer);
            AddServiceDependencyProjects(writer, serviceDirectory);
            AddCurrentService(writer);
            AddTestProjects(writer);
            AddTestDependencyProjects(writer, serviceDirectory);
        });
        return writer.ToRawString();
    }

    // only covers those in cloudtraildata for now, although it does follow the current C2J generator in adding these references
    // for every service slnx.
    private void AddTestProjects(CodeWriter writer)
    {
        var serviceUnitTestProject = $"AWSSDK.UnitTests.{context.ServiceName}.csproj";
        writer.WriteXmlBlock("""<Folder Name="/Test/">""", "Folder", () =>
        {
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "..", "generator", "ServiceClientGeneratorLib", ProjectFileNames.GeneratorLib)}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "test", "Common", ProjectFileNames.CommonTest)}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "test", "IntegrationTests", ProjectFileNames.IntegrationTestUtility)}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "test", "Services", context.ServiceName, "UnitTests", serviceUnitTestProject)}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "test", "UnitTests", ProjectFileNames.UnitTestsCore)}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt(SdkRoot, "test", "UnitTests", "Custom", ProjectFileNames.UnitTestUtility)}" />""");
        });
    }

    // resolve test dependencies from the core unit-tests' csproj that lives in
    // sdk/test/UnitTests/AWSSDK.UnitTests.Core.csproj
    private void AddTestDependencyProjects(CodeWriter writer, string serviceDirectory)
    {
        var unitTestsCoreProjectPath = FindUnitTestsCoreProject(serviceDirectory);
        var dependencies = new List<string>();
        // No test tree on disk (e.g. generating into a bare output dir) means no dependencies to read.
        if (unitTestsCoreProjectPath is not null)
        {
            AddProjectDependencies(unitTestsCoreProjectPath, context.ServiceName, dependencies);
        }
        writer.WriteXmlBlock("""<Folder Name="/TestDependencies/">""", "Folder", () =>
        {
            foreach(var dependency in dependencies)
            {
                writer.WriteLine($"""<Project Path="{dependency}" />""");
            }
        });
    }

    // Walks up from the given folder until it finds an ancestor containing an "sdk" directory, then
    // returns the path to sdk/test/UnitTests/AWSSDK.UnitTests.Core.csproj. Discovering it this way
    // avoids hard-coding the number of levels between the output folder and the SDK root — and works
    // whether output lands inside the SDK tree (sdk/src/Services/{Service}/) or in a sibling dev
    // output folder. Returns null when no ancestor contains an "sdk" directory (e.g. a bare output
    // dir with no SDK tree).
    private static string? FindUnitTestsCoreProject(string serviceDirectory)
    {
        for (var directory = new DirectoryInfo(serviceDirectory); directory is not null; directory = directory.Parent)
        {
            var sdkDirectory = Path.Combine(directory.FullName, "sdk");
            if (Directory.Exists(sdkDirectory))
            {
                return Utils.PathCombineAlt(sdkDirectory, "test", "UnitTests", ProjectFileNames.UnitTestsCore);
            }
        }

        return null;
    }

    private void AddCurrentService(CodeWriter writer)
    {
        var serviceFolder = Utils.PathCombineAlt("/Services", context.ServiceName);
        writer.WriteXmlBlock($"""<Folder Name="{serviceFolder}/">""", "Folder", () =>
        {
            writer.WriteLine($"""<Project Path="{context.AssemblyName}.NetFramework.csproj" />""");
            if (context.Metadata?.NetStandardSupport == true)
            {
                writer.WriteLine($"""<Project Path="{context.AssemblyName}.NetStandard.csproj" />""");
            }
        });
    }

    // TODO: make this method smarter so that it handles services that depend on extensions
    // such as CloudWatch depending on Extensions.Cbor.
    private void AddCoreProjects(CodeWriter writer)
    {
        writer.WriteXmlBlock("""<Folder Name="/Core/">""", "Folder", () =>
        {
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt("..", "..", "Core", "AWSSDK.Core.NetFramework.csproj")}" />""");
            writer.WriteLine($"""<Project Path="{Utils.PathCombineAlt("..", "..", "Core", "AWSSDK.Core.NetStandard.csproj")}" />""");
        });
    }

    // Scans the service's NetFramework/NetStandard csproj files for project references that aren't
    // Core (or the service itself), and lists the resulting service dependencies under
    // <Folder Name="/Services/">. Extension dependencies belong in the Core folder, not here, so they
    // are excluded. CloudTrailData references only Core, so this emits the empty self-closing folder.
    // Ported from SolutionFileCreator.AddProjectDependencies in the C2J generator.
    private void AddServiceDependencyProjects(CodeWriter writer, string serviceDirectory)
    {
        var serviceName = new DirectoryInfo(serviceDirectory).Name;

        var dependencies = new List<string>();
        foreach (var projectFile in Directory.EnumerateFiles(serviceDirectory, "*.*", SearchOption.TopDirectoryOnly)
            .Where(s => s.Contains("NetStandard") || s.Contains("NetFramework"))
            .OrderBy(f => f))
        {
            AddProjectDependencies(Utils.ConvertPathAlt(projectFile), serviceName, dependencies);
        }

        var serviceDependencies = dependencies
            .Where(dep => !dep.Contains("AWSSDK.Extensions."))
            .Distinct()
            .OrderBy(dep => dep, StringComparer.Ordinal)
            .ToList();

        if (serviceDependencies.Count == 0)
        {
            writer.WriteLine("""<Folder Name="/Services/" />""");
            return;
        }

        writer.WriteXmlBlock("""<Folder Name="/Services/">""", "Folder", () =>
        {
            foreach (var dependency in serviceDependencies)
            {
                writer.WriteLine($"""<Project Path="{dependency}" />""");
            }
        });
    }

    /// <summary>
    /// Opens a csproj file and recursively collects its non-Core, non-test, non-generator project
    /// references into <paramref name="dependencies"/> as slnx-relative paths. Service references
    /// resolve to <c>../{Service}/{file}.csproj</c> and extension references to
    /// <c>../../../../extensions/src/{Extension}/{file}.csproj</c>. Ported from the C2J generator's
    /// <c>SolutionFileCreator.AddProjectDependencies</c>.
    /// </summary>
    private void AddProjectDependencies(string projectFile, string serviceName, List<string> dependencies)
    {
        // A referenced project may not be present on disk (e.g. a service dependency that hasn't been
        // generated). Its <ProjectReference> entries were already recorded by the caller, so there's
        // nothing more to collect from it; skip rather than throw on the missing file.
        if (!File.Exists(projectFile))
        {
            return;
        }

        foreach (var line in File.ReadAllLines(projectFile))
        {
            if (!line.Contains("ProjectReference"))
            {
                continue;
            }

            var match = ProjectReferenceRegex.Match(line);
            if (!match.Success)
            {
                // Line mentions "ProjectReference" but isn't an actual <ProjectReference Include="..."/>
                // element (e.g. an XML comment); skip to avoid an empty-fileName Split below.
                continue;
            }
            var fileName = match.ToString().Replace("\"", "");

            // Core and the service project itself are added elsewhere; tests aren't service deps.
            var alreadyAdded = fileName.Contains("/Core/") || fileName.Contains($".{serviceName}.")
                || fileName.Contains("Test") || dependencies.Contains(fileName);
            if (alreadyAdded)
            {
                continue;
            }

            var split = fileName.Split(Path.AltDirectorySeparatorChar);

            // Extensions live in a different folder than the usual service dependencies. Skip the
            // recursion since they currently have no project references beyond Core.
            if (fileName.Contains("AWSSDK.Extensions."))
            {
                // Build the relative path to /extensions/src/AWSSDK.Extensions.{Name}/AWSSDK.Extensions.{Name}.<tfm>.csproj
                dependencies.Add(Utils.PathCombineAlt("..", "..", "..", "..", split[^4], split[^3], split[^2], split[^1]));
            }
            // The test utilities and Core test projects also reference the generator, but that's added elsewhere.
            else if (fileName.Contains("ServiceClientGeneratorLib"))
            {
                continue;
            }
            else
            {
                // Build the relative path to /Services/{service}/AWSSDK.{service}.<tfm>.csproj
                dependencies.Add(Utils.PathCombineAlt("..", split[^2], split[^1]));
                AddProjectDependencies(ResolveReferencedProjectPath(projectFile, fileName), split[^2], dependencies);
            }
        }
    }

    // Resolves the on-disk path of a referenced csproj so the recursion can read its own references.
    // A <ProjectReference Include="..."> path is relative to the directory of the declaring project,
    // so combine the two and normalize.
    private static string ResolveReferencedProjectPath(string projectFile, string reference)
    {
        var projectDirectory = Path.GetDirectoryName(Path.GetFullPath(projectFile)) ?? ".";
        return Utils.ConvertPathAlt(Path.GetFullPath(Path.Combine(projectDirectory, reference)));
    }
}
