using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using ServiceClientGenerator.Generators.ProjectFiles;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Class used to emit the set of per-platform project files for a service. 
    /// Existing project files are retained, only missing files are generated.
    /// </summary>
    public class ProjectFileCreator
    {
        /// <summary>
        /// On conclusion, the set of project files that were generated for the service.
        /// </summary>
        public Dictionary<string, ProjectConfigurationData> CreatedProjectFiles { get; set; }

        private GeneratorOptions Options;

        public ProjectFileCreator(GeneratorOptions options)
        {
            Options = options;
        }

        public void ExecuteCore(string coreFilesRoot, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            CreatedProjectFiles = new Dictionary<string, ProjectConfigurationData>();

            foreach (var projectFileConfiguration in projectFileConfigurations)
            {
                var projectType = projectFileConfiguration.Name;

                var assemblyName = "AWSSDK.Core";
                var projectFilename = string.Concat(assemblyName, ".", projectType, ".csproj");
                bool newProject = false;
                string projectGuid;
                if (File.Exists(Path.Combine(coreFilesRoot, projectFilename)))
                {
                    Console.WriteLine("...updating existing project file {0}", projectFilename);
                    var projectPath = Path.Combine(coreFilesRoot, projectFilename);
                    projectGuid = Utils.GetProjectGuid(projectPath);
                }
                else
                {
                    newProject = true;
                    projectGuid = Utils.NewProjectGuid;
                    Console.WriteLine("...creating project file {0}", projectFilename);
                }


                var templateSession = new Dictionary<string, object>();

                templateSession["Name"] = projectFileConfiguration.Name;
                templateSession["ProjectGuid"] = projectGuid;
                templateSession["RootNamespace"] = "Amazon";
                templateSession["AssemblyName"] = assemblyName;
                templateSession["SourceDirectories"] = GetCoreProjectSourceFolders(projectFileConfiguration, coreFilesRoot);
                templateSession["IndividualFileIncludes"] = new List<string>
                {
                    "endpoints.json",
                    "endpoints.customizations.json"
                };
                templateSession["KeyFilePath"] = @"..\..\awssdk.dll.snk";
                templateSession["SupressWarnings"] = "419,1570,1591";
                templateSession["NugetPackagesLocation"] = @"..\..\packages\";
                templateSession["TargetFrameworkVersion"] = projectFileConfiguration.TargetFrameworkVersion;
                templateSession["DefineConstants"] = projectFileConfiguration.CompilationConstants;
                templateSession["BinSubfolder"] = projectFileConfiguration.BinSubFolder;

                var projectConfigurationData = new ProjectConfigurationData { ProjectGuid = projectGuid };
                var projectName = Path.GetFileNameWithoutExtension(projectFilename);

                if (newProject)
                    CreatedProjectFiles[projectName] = projectConfigurationData;

                var projectReferences = new List<ProjectReference>();
                templateSession["ProjectReferences"] = projectReferences.OrderBy(x => x.Name).ToList();

                templateSession["UnityPath"] = Options.UnityPath;

                GenerateProjectFile(projectFileConfiguration, projectConfigurationData, templateSession, coreFilesRoot, projectFilename);
            }
        }

        /// <summary>
        /// Creates the platform-specific project files for the given service configuration
        /// </summary>
        /// <param name="serviceFilesRoot">The folder under which all of the source files for the service will exist</param>
        /// <param name="serviceConfiguration"></param>
        /// <param name="projectFileConfigurations"></param>
        public void Execute(string serviceFilesRoot, ServiceConfiguration serviceConfiguration, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            CreatedProjectFiles = new Dictionary<string, ProjectConfigurationData>();

            foreach (var projectFileConfiguration in projectFileConfigurations)
            {
                if (projectFileConfiguration.IsSubProfile &&
                    !(serviceConfiguration.PclVariants != null && serviceConfiguration.PclVariants.Any(p => p.Equals(projectFileConfiguration.Name))))
                {
                    // Skip sub profiles for service projects.
                    continue;
                }

                var projectType = projectFileConfiguration.Name;
                if (projectType.Equals("Unity", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!serviceConfiguration.SupportedInUnity)
                        continue;
                }


                var assemblyName = "AWSSDK." + serviceConfiguration.Namespace.Split('.')[1];
                var projectFilename = string.Concat(assemblyName, ".", projectType, ".csproj");
                bool newProject = false;
                string projectGuid;
                if (File.Exists(Path.Combine(serviceFilesRoot, projectFilename)))
                {
                    Console.WriteLine("...updating existing project file {0}", projectFilename);
                    var projectPath = Path.Combine(serviceFilesRoot, projectFilename);
                    projectGuid = Utils.GetProjectGuid(projectPath);
                }
                else
                {
                    newProject = true;
                    projectGuid = Utils.NewProjectGuid;
                    Console.WriteLine("...creating project file {0}", projectFilename);
                }


                var templateSession = new Dictionary<string, object>();

                templateSession["Name"] = projectFileConfiguration.Name;
                templateSession["ProjectGuid"] = projectGuid;
                templateSession["RootNamespace"] = serviceConfiguration.Namespace;
                templateSession["AssemblyName"] = assemblyName;
                templateSession["SourceDirectories"] = GetProjectSourceFolders(projectFileConfiguration, serviceFilesRoot);
                templateSession["NugetPackagesLocation"] = @"..\..\..\packages\";
                templateSession["TargetFrameworkVersion"] = projectFileConfiguration.TargetFrameworkVersion;
                templateSession["DefineConstants"] = projectFileConfiguration.CompilationConstants;
                templateSession["BinSubfolder"] = projectFileConfiguration.BinSubFolder;

                var projectConfigurationData = new ProjectConfigurationData { ProjectGuid = projectGuid };
                var projectName = Path.GetFileNameWithoutExtension(projectFilename);

                if (newProject)
                    CreatedProjectFiles[projectName] = projectConfigurationData;

                var coreRuntimeProject = string.Concat(@"..\..\Core\AWSSDK.Core.", projectType, ".csproj");
                var projectReferences = new List<ProjectReference>();


                if (serviceConfiguration.ServiceDependencies != null)
                {
                    foreach (var dependency in serviceConfiguration.ServiceDependencies)
                    {
                        var pt = projectType;
                        if (!(pt.StartsWith(@"Net") || pt.StartsWith(@"Unity")) && serviceConfiguration.UsePclProjectDependencies)
                            pt = @"PCL";

                        var dependencyProjectName = "AWSSDK." + dependency.Key + "." + pt;
                        string dependencyProject;
                        if (string.Equals(dependency.Key, "Core", StringComparison.InvariantCultureIgnoreCase))
                        {
                            dependencyProject = string.Concat(@"..\..\", dependency.Key, "\\", dependencyProjectName, ".csproj");
                        }
                        else
                        {
                            dependencyProject = string.Concat(@"..\", dependency.Key, "\\", dependencyProjectName, ".csproj");
                        }

                        projectReferences.Add(new ProjectReference
                        {
                            IncludePath = dependencyProject,
                            ProjectGuid = Utils.GetProjectGuid(Path.Combine(serviceFilesRoot, dependencyProject)),
                            Name = dependencyProjectName
                        });
                    }
                }


                templateSession["ProjectReferences"] = projectReferences.OrderBy(x => x.Name).ToList();

                templateSession["UnityPath"] = Options.UnityPath;

                if (serviceConfiguration.ModelName.Equals("s3", StringComparison.OrdinalIgnoreCase) && projectType == "Net45")
                {
                    templateSession["SystemReferences"] = new List<string> { "System.Net.Http" };
                }

                if (serviceConfiguration.ReferenceDependencies != null &&
                    serviceConfiguration.ReferenceDependencies.ContainsKey(projectFileConfiguration.Name))
                {
                    templateSession["ReferenceDependencies"] = serviceConfiguration.ReferenceDependencies[projectFileConfiguration.Name];
                    templateSession["NuGetTargetFramework"] = projectFileConfiguration.NuGetTargetPlatform;
                }

                

                GenerateProjectFile(projectFileConfiguration, projectConfigurationData, templateSession, serviceFilesRoot, projectFilename);
            }
        }

        /// <summary>
        /// Invokes the T4 generator to emit a platform-specific project file.
        /// </summary>
        /// <param name="projectFileConfiguration"></param>
        /// <param name="session"></param>
        /// <param name="serviceFilesRoot"></param>
        /// <param name="projectFilename"></param>
        private void GenerateProjectFile(ProjectFileConfiguration projectFileConfiguration,
                                         ProjectConfigurationData projectConfiguration,
                                         IDictionary<string, object> session,
                                         string serviceFilesRoot,
                                         string projectFilename)
        {
            var projectName = Path.GetFileNameWithoutExtension(projectFilename);
            string generatedContent = null;
            try
            {
                var projectTemplateType = Type.GetType(
                    "ServiceClientGenerator.Generators.ProjectFiles." +
                    projectFileConfiguration.Template);
                dynamic generator = Activator.CreateInstance(projectTemplateType);
                generator.Session = session;
                generatedContent = generator.TransformText();
            }
            catch (Exception)
            {
                throw new ArgumentException("Project template name "
                    + projectFileConfiguration.Template + " is not recognized");
            }

            GeneratorDriver.WriteFile(serviceFilesRoot, string.Empty, projectFilename, generatedContent);
            projectConfiguration.ConfigurationPlatforms = projectFileConfiguration.Configurations;
        }

        /// <summary>
        /// Returns the collection of subfolders containing source code that need to be 
        /// included in the project file. This is comprised the standard platform folders
        /// under Generated, plus any custom folders we find that are not otherwise handled
        /// (eg Properties).
        /// </summary>
        /// <param name="projectFileConfiguration">
        /// The .Net project type we are generating. This governs the platform-specific
        /// subfolders that get included in the project.
        /// </param>
        /// <param name="serviceRootFolder">The root output folder for the service code</param>
        /// <returns></returns>
        private IList<string> GetCoreProjectSourceFolders(ProjectFileConfiguration projectFileConfiguration, string coreRootFolder)
        {
            var exclusionList = new List<string>
            {
                "Properties",
                "bin",
                "obj"
            };

            // Start with the standard folders for core
            var sourceCodeFolders = new List<string>
            {
                "."
            };

            var childDirectories = Directory.GetDirectories(coreRootFolder, "*", SearchOption.AllDirectories);
            foreach (var childDirectory in childDirectories)
            {
                var folder = childDirectory.Substring(coreRootFolder.Length).TrimStart('\\');

                if (exclusionList.Any(e => folder.Equals(e, StringComparison.InvariantCulture) ||
                    folder.StartsWith(e + "\\", StringComparison.InvariantCulture)))
                    continue;

                if (projectFileConfiguration.IsPlatformCodeFolder(folder))
                {
                    if (projectFileConfiguration.IsValidPlatformCodeFolderForProject(folder))
                        sourceCodeFolders.Add(folder);
                }
                else
                {
                    sourceCodeFolders.Add(folder);
                }


            }



            //var platformSubFolders = projectFileConfiguration.PlatformCodeFolders;
            //sourceCodeFolders.AddRange(platformSubFolders.Select(folder => Path.Combine(@"Generated", folder)));

            //// Augment the returned folders with any custom subfolders already in existence. If the custom folder 
            //// ends with a recognised platform, only add it to the set if it matches the platform being generated
            ////if (Directory.Exists(serviceRootFolder))
            //{
            //    var subFolders = Directory.GetDirectories(coreRootFolder, "*", SearchOption.AllDirectories);
            //    subFolders = subFolders.Except(exclusionList).ToArray();
            //    if (subFolders.Any())
            //    {
            //        foreach (var folder in subFolders)
            //        {
            //            var serviceRelativeFolder = folder.Substring(coreRootFolder.Length);

            //            if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
            //                continue;

            //            if (projectFileConfiguration.IsPlatformCodeFolder(serviceRelativeFolder))
            //            {
            //                if (projectFileConfiguration.IsValidPlatformCodeFolderForProject(serviceRelativeFolder))
            //                    sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
            //            }
            //            else
            //                sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
            //        }
            //    }
            //}

            var foldersThatExist = new List<string>();
            foreach (var folder in sourceCodeFolders)
            {
                if (Directory.Exists(Path.Combine(coreRootFolder, folder)))
                    foldersThatExist.Add(folder);
            }

            // sort so we get a predictable layout
            foldersThatExist.Sort(StringComparer.OrdinalIgnoreCase);
            return foldersThatExist;
        }

        /// <summary>
        /// Returns the collection of subfolders containing source code that need to be 
        /// included in the project file. This is comprised the standard platform folders
        /// under Generated, plus any custom folders we find that are not otherwise handled
        /// (eg Properties).
        /// </summary>
        /// <param name="projectFileConfiguration">
        /// The .Net project type we are generating. This governs the platform-specific
        /// subfolders that get included in the project.
        /// </param>
        /// <param name="serviceRootFolder">The root output folder for the service code</param>
        /// <returns></returns>
        private IList<string> GetProjectSourceFolders(ProjectFileConfiguration projectFileConfiguration, string serviceRootFolder)
        {
            // Start with the standard generated code folders for the platform
            var sourceCodeFolders = new List<string>
            {
                "Generated", 
                @"Generated\Model", 
                @"Generated\Model\Internal", 
                @"Generated\Model\Internal\MarshallTransformations"
            };

            var platformSubFolders = projectFileConfiguration.PlatformCodeFolders;
            sourceCodeFolders.AddRange(platformSubFolders.Select(folder => Path.Combine(@"Generated", folder)));

            // Augment the returned folders with any custom subfolders already in existence. If the custom folder 
            // ends with a recognised platform, only add it to the set if it matches the platform being generated
            if (Directory.Exists(serviceRootFolder))
            {
                var subFolders = Directory.GetDirectories(serviceRootFolder, "*", SearchOption.AllDirectories);
                if (subFolders.Any())
                {
                    foreach (var folder in subFolders)
                    {
                        var serviceRelativeFolder = folder.Substring(serviceRootFolder.Length);

                        if (!serviceRelativeFolder.StartsWith(@"\Custom", StringComparison.OrdinalIgnoreCase))
                            continue;

                        if (projectFileConfiguration.IsPlatformCodeFolder(serviceRelativeFolder))
                        {
                            if (projectFileConfiguration.IsValidPlatformCodeFolderForProject(serviceRelativeFolder))
                                sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
                        }
                        else
                            sourceCodeFolders.Add(serviceRelativeFolder.TrimStart('\\'));
                    }
                }
            }

            var foldersThatExist = new List<string>();
            foreach (var folder in sourceCodeFolders)
            {
                if (Directory.Exists(Path.Combine(serviceRootFolder, folder)))
                    foldersThatExist.Add(folder);
            }

            // sort so we get a predictable layout
            foldersThatExist.Sort(StringComparer.OrdinalIgnoreCase);
            return foldersThatExist;
        }

        public class ProjectReference
        {
            public string IncludePath { get; set; }
            public string ProjectGuid { get; set; }
            public string Name { get; set; }
        }

        public class ProjectConfigurationData
        {
            public string ProjectGuid { get; set; }
            public IEnumerable<string> ConfigurationPlatforms { get; set; }
        }

    }
}
