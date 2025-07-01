using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.LitJson;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents the metadata needed to generate a platform-specific project file
    /// for a service (eg compile constants, build configuration and platform etc).
    /// </summary>
    public class ProjectFileConfiguration
    {
        /// <summary>
        /// Represents the configuration settings for a project file.
        /// </summary>
        public abstract class ProjectsSectionKeys
        {
            public const string ProjectsKey = "projects";
            public const string NameKey = "name";
            public const string ConfigurationsKey = "configurations";
            public const string TargetFrameworksKey = "targetFrameworks";
            public const string DefineConstantsKey = "defineConstants";
            public const string BinSubFolderKey = "binSubFolder";
            public const string TemplateKey = "template";
            public const string PlatformCodeFoldersKey = "platformCodeFolders";
            public const string ExtraTestProjects = "extraTestProjects";
            public const string NuGetTargetFrameworkKey = "nugetTargetPlatform";
            public const string PlatformExcludeFoldersKey = "excludeFolders";
            public const string FrameworkPathOverrideKey = "frameworkPathOverride";
            public const string FrameworkRefernecesKey = "frameworkReferences";
            public const string EmbeddedResourcesKey = "embeddedResources";
            public const string UnitTestProjectsKey = "unittestprojects";
            public const string NoWarn = "noWarn";
            public const string PackageReferences = "packageReferences";
            public const string OutputPathOverrideKey = "outputPathOverride";
        }

        /// <summary>
        /// Loads the project configuration from the specified project node.
        /// </summary>
        /// <param name="projectNode">The XML node representing the project configuration.</param>
        /// <param name="loadExtraTestProjects">Whether to load the extra test projects or not.</param>
        /// <returns>A ProjectFileConfiguration object containing the loaded project configuration.</returns>
        public static ProjectFileConfiguration Load(JsonData projectNode, bool loadExtraTestProjects)
        {
            List<string> extraTestProjectsList = null;
            if (loadExtraTestProjects)
            {
                var extraTestProjects = projectNode.SafeGet(ProjectsSectionKeys.ExtraTestProjects);
                if (extraTestProjects == null)
                {
                    extraTestProjectsList = new List<string>();
                }
                else
                {
                    extraTestProjectsList = (from object etp in extraTestProjects
                                             select etp.ToString()).ToList();
                }
            }

            return new ProjectFileConfiguration { 
                Name = projectNode.SafeGetString(ProjectsSectionKeys.NameKey),
                TargetFrameworkVersions = SafeGetStringList(projectNode, ProjectsSectionKeys.TargetFrameworksKey),
                CompilationConstants = SafeGetStringList(projectNode, ProjectsSectionKeys.DefineConstantsKey),
                BinSubFolder = projectNode.SafeGetString(ProjectsSectionKeys.BinSubFolderKey),
                Template = projectNode.SafeGetString(ProjectsSectionKeys.TemplateKey),
                NuGetTargetPlatform = projectNode.SafeGetString(ProjectsSectionKeys.NuGetTargetFrameworkKey),
                FrameworkPathOverride = projectNode.SafeGetString(ProjectsSectionKeys.FrameworkPathOverrideKey),
                NoWarn = projectNode.SafeGetString(ProjectsSectionKeys.NoWarn),
                OutputPathOverride = projectNode.SafeGetString(ProjectsSectionKeys.OutputPathOverrideKey),
                Configurations = SafeGetStringList(projectNode, ProjectsSectionKeys.ConfigurationsKey),
                EmbeddedResources = SafeGetStringList(projectNode, ProjectsSectionKeys.EmbeddedResourcesKey),
                PlatformCodeFolders = SafeGetStringList(projectNode, ProjectsSectionKeys.PlatformCodeFoldersKey),
                PlatformExcludeFolders = SafeGetStringList(projectNode, ProjectsSectionKeys.PlatformExcludeFoldersKey),
                DllReferences = SafeGetObjectList<Dependency>(projectNode, ProjectsSectionKeys.FrameworkRefernecesKey, Dependency.ParseJson),
                PackageReferences = SafeGetObjectList<ProjectFileCreator.PackageReference>(projectNode, ProjectsSectionKeys.PackageReferences, ProjectFileCreator.PackageReference.ParseJson),
                ExtraTestProjects = extraTestProjectsList
            };
        }

        /// <summary>
        /// The name of the platform configuration; this forms part of the project
        /// filename.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The set of solution build configuration and platforms (eg Debug|Any CPU)
        /// supported by the project kind.
        /// </summary>
        public IEnumerable<string> Configurations { get; private set; }

        /// <summary>
        /// The .Net Framework versions, in format vX.Y, that the project will compile 
        /// against.
        /// </summary>
        public IEnumerable<string> TargetFrameworkVersions { get; private set; }

        /// <summary>
        /// The #define constants to be set at compile time. These are used for all
        /// compilation types (debug, release etc).
        /// </summary>
        public IEnumerable<string> CompilationConstants { get; private set; }

        /// <summary>
        /// The name of the subfolder that the compile outputs should be placed into.
        /// By convention this is the same as the Name property, but lowercase.
        /// </summary>
        public string BinSubFolder { get; private set; }

        /// <summary>
        /// The name of the T4 generator file used to emit the project file. The
        /// type name should be relative to the code generator's Generators 
        /// namespace.
        /// </summary>
        public string Template { get; private set; }

        /// <summary>
        /// The set of subfolder names used to hold custom code for a platform
        /// </summary>
        public IEnumerable<string> PlatformCodeFolders { get; private set; }

        public IEnumerable<string> PlatformExcludeFolders { get; private set; }

        /// <summary>
        /// The platform name used by NuGet (e.g. wpa81)
        /// </summary>
        public string NuGetTargetPlatform { get; private set; }

        /// <summary>
        /// The set of projects that should be included in the solution test folder.
        /// </summary>
        public IEnumerable<string> ExtraTestProjects { get; private set; }

        /// <summary>
        /// Returns true if the last component of the specified folder 
        /// path begins with '_' character, our convention for representing
        /// platform-specific code.
        /// </summary>
        public bool IsPlatformCodeFolder(string sourceFolder)
        {
            return GetPlatformFolderName(sourceFolder) != null;
        }

        public IEnumerable<ProjectFileCreator.ProjectReference> ProjectReferences { get; private set; }
        
        public IEnumerable<string> EmbeddedResources { get; private set; }

        public IEnumerable<string> VisualStudioServices { get; private set; }

        public string NoWarn { get; private set; }

        public string OutputPathOverride { get; private set; }

        public IEnumerable<ProjectFileCreator.PackageReference> PackageReferences { get; private set; }

        /// <summary>
        /// Specify where the framework binaries are.  This was last needed for net35 in vs2017 project
        /// to work around https://github.com/Microsoft/msbuild/issues/1333 when the target was in use.
        /// </summary>
        public string FrameworkPathOverride { get; private set; }

        public IEnumerable<Dependency> DllReferences { get; private set; }

        /// <summary>
        /// Returns true if the specified folder ends with one of the custom code
        /// platform folder names declared for this configuration.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <returns></returns>

        private string GetPlatformFolderName(string folder)
        {
            var tokens = folder.Split('\\');
            string platformFolder = null;
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                if (tokens[i].StartsWith("_"))
                {
                    platformFolder = tokens[i];
                    break;
                }
            }

            return platformFolder;
        }

        /// <summary>
        /// Returns true if the specified path folder names conforms with the 
        /// platform folder names declared for this configuration.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <returns></returns>
        public bool IsValidPlatformPathForProject(string sourceFolder)
        {
            var tokens = sourceFolder.Split(new[] { Path.AltDirectorySeparatorChar });

            if (PlatformCodeFolders.Any())
            {
                foreach(var folder in tokens)
                {
                    if (folder.StartsWith("_"))
                    {
                        bool isValid = false;
                        foreach (var pcf in PlatformCodeFolders)
                        {
                            if (folder.Equals(pcf, StringComparison.OrdinalIgnoreCase))
                            {
                                isValid = true;
                                break;
                            }
                        }
                        if (!isValid)
                        {
                            return false;
                        }
                    }
                    
                }
                
            }

            return true;
        }

        private static List<string> SafeGetStringList(JsonData data, string key)
        {
            var t = data.SafeGet(key);
            if (t != null)
            {
                return (from object obj in t select obj.ToString()).ToList<string>();
            }
            else
            {
                return new List<string>();
            }
        }

        private static List<T> SafeGetObjectList<T>(JsonData data, string key, Func<JsonData, T> converter)
        {
            var t = data.SafeGet(key);
            if (t != null)
            {
                return (from JsonData obj in t select converter(obj)).ToList<T>();
            }
            else
            {
                return new List<T>();
            }
        }
    }
}
