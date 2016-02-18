using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using ServiceClientGenerator.Generators.ProjectFiles;
using System.Xml;

namespace ServiceClientGenerator
{
    public class SolutionFileCreator
    {
        public GeneratorOptions Options { get; set; }
        public IEnumerable<ProjectFileConfiguration> ProjectFileConfigurations { get; set; }

        /// <summary>
        /// The set of project 'types' (or platforms) that we generate the SDK against.
        /// These type names form part of the project filename.
        /// </summary>
        public abstract class ProjectTypes
        {
            public const string Net35 = "Net35";
            public const string Net45 = "Net45";
            public const string Win8 = "Win8";
            public const string WinPhone81 = "WinPhone81";
            public const string WinPhoneSilverlight8 = "WinPhoneSilverlight8";
            public const string PCL = "PCL";
            public const string Android = "Android";
            public const string IOS = "iOS";
            public const string Unity = "Unity";
        }

        // build configuration platforms used for net 3.5, 4.5 and portable project types
        static readonly List<string> StandardPlatformConfigurations = new List<string>
        {
            "Debug|Any CPU",
            "Release|Any CPU"
        };

        // build configuration platforms used for phone/RT project types
        static readonly List<string> PhoneRtPlatformConfigurations = new List<string>
        {
            "Debug|Any CPU",
            "Debug|ARM",
            "Debug|x64",
            "Debug|x86",
            "Release|Any CPU",
            "Release|ARM",
            "Release|x64",
            "Release|x86",
        };

        private const string GeneratorLibProjectGuid = "{7BEE7C44-BE12-43CC-AFB9-B5852A1F43C8}";
        private const string GeneratorLibProjectName = "ServiceClientGeneratorLib";

        private static readonly ProjectFileCreator.ProjectConfigurationData GeneratorLibProjectConfig
            = new ProjectFileCreator.ProjectConfigurationData
            {
                ProjectGuid = GeneratorLibProjectGuid,
                ConfigurationPlatforms = StandardPlatformConfigurations
            };

        private static readonly Project GeneratorLibProject = new Project
        {
            Name = GeneratorLibProjectName,
            ProjectGuid = GeneratorLibProjectGuid,
            ProjectPath = string.Format(@"..\generator\{0}\{0}.csproj", GeneratorLibProjectName)
        };

        private readonly Dictionary<string, ProjectFileCreator.ProjectConfigurationData> _allProjects 
            = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

        public void Execute(IDictionary<string, ProjectFileCreator.ProjectConfigurationData> newProjects)
        {
            Console.WriteLine("Updating solution files in {0}", Path.GetFullPath(Options.SdkRootFolder));

            // transfer the new projects into our set-to-process, then scan for and augment the
            // collection with existing projects.
            foreach (var projectKey in newProjects.Keys)
            {
                _allProjects.Add(projectKey, newProjects[projectKey]);    
            }

            AddSupportProjects();
            ScanForExistingProjects();

            // build one uber-solution for every project and platform
            GenerateAllPlatformsSolution("AWSSDK.All.sln", ProjectFileConfigurations);

            GenerateCombinedSolution("AWSSDK.Desktop.sln", true,
                new List<ProjectFileConfiguration> { 
                    GetProjectConfig(ProjectTypes.Net35),
                    GetProjectConfig(ProjectTypes.Net45)
            });

            GenerateCombinedSolution("AWSSDK.PCL.sln", true,
                new List<ProjectFileConfiguration> { 
                    GetProjectConfig(ProjectTypes.PCL),
                    GetProjectConfig(ProjectTypes.Android),
                    GetProjectConfig(ProjectTypes.IOS),
                    GetProjectConfig(ProjectTypes.Win8),
                    GetProjectConfig(ProjectTypes.WinPhone81),
                    GetProjectConfig(ProjectTypes.WinPhoneSilverlight8)
            });


            GenerateCombinedSolution("AWSSDK.Unity.sln", false,
                new List<ProjectFileConfiguration>{
                    GetProjectConfig(ProjectTypes.Unity)
                });

            // Include solutions that Travis CI can build
            GeneratePlatformSpecificSolution(GetProjectConfig(ProjectTypes.Net35), false, true, "AWSSDK.Net35.Travis.sln");
            GeneratePlatformSpecificSolution(GetProjectConfig(ProjectTypes.Net45), false, true, "AWSSDK.Net45.Travis.sln");
        }

        // adds any necessary projects to the collection prior to generating the solution file(s)
        private void AddSupportProjects()
        {
            _allProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
        }

        /// <summary>
        /// Scans the SDK source and test folder locations to detect existing projects that
        /// follow our naming convention, adding them to the set of all projects to be
        /// processed into the solution files.
        /// </summary>
        private void ScanForExistingProjects()
        {
            const string awssdkProjectNamePattern = "AWSSDK.*.csproj";

            var foldersToProcess = new[]
            {
                Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername),
                Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername)
            };

            foreach (var rootFolder in foldersToProcess)
            {
                foreach (var projectFile in Directory.GetFiles(rootFolder, awssdkProjectNamePattern, SearchOption.AllDirectories))
                {
                    var projectName = Path.GetFileNameWithoutExtension(projectFile);
                    if (_allProjects.ContainsKey(projectName))
                        continue;

                    var projectConfig = new ProjectFileCreator.ProjectConfigurationData
                    {
                        ProjectGuid = Utils.GetProjectGuid(projectFile),
                        ConfigurationPlatforms = GetProjectPlatforms(projectName)
                    };

                    _allProjects.Add(projectName, projectConfig);
                }
            }
        }

        private ProjectFileConfiguration GetProjectConfig(string configType)
        {
            var config = ProjectFileConfigurations
                .Single(pfc => string.Equals(pfc.Name, configType, StringComparison.Ordinal));
            return config;
        }

        static IEnumerable<string> GetProjectPlatformsFromFile(string projectFile)
        {
            var platforms = new List<string>();

            var content = File.ReadAllText(projectFile);
            var doc = new XmlDocument();
            doc.LoadXml(content);

            var searchPhrase = "$(Configuration)|$(Platform)";
            var propertyGroups = doc.GetElementsByTagName("PropertyGroup");
            foreach(XmlNode pg in propertyGroups)
            {
                var conditionAttrbiute = pg.Attributes["Condition"];
                if (conditionAttrbiute != null)
                {
                    var condition = conditionAttrbiute.Value;
                    if (condition.IndexOf(searchPhrase, StringComparison.Ordinal) >= 0)
                    {
                        var thirdQuote = condition.IndexOfNthOccurence('\'', 0, 3);
                        var fourthQuote = condition.IndexOf('\'', thirdQuote);
                        var platform = condition.Substring(thirdQuote, fourthQuote - thirdQuote);
                        // Project files use the string "AnyCPU", solution files use "Any CPU"
                        platform = platform.Replace("AnyCPU", "Any CPU");
                        platforms.Add(platform);
                    }
                }
            }

            return platforms;
        }
        static IEnumerable<string> GetProjectPlatforms(string projectName)
        {
            var projectTypeStart = projectName.LastIndexOf('.');
            var projectType = projectName.Substring(projectTypeStart + 1);

            switch (projectType)
            {
                case ProjectTypes.Win8:
                case ProjectTypes.WinPhone81:
                case ProjectTypes.WinPhoneSilverlight8:
                    return PhoneRtPlatformConfigurations;

                case ProjectTypes.Net35:
                case ProjectTypes.Net45:
                case ProjectTypes.PCL:
                case ProjectTypes.Android:
                case ProjectTypes.IOS:
                case ProjectTypes.Unity:
                    return StandardPlatformConfigurations;
            }

            throw new Exception(string.Format("Unrecognized platform type in project name - '{0}'", projectType));
        }

        private void GenerateAllPlatformsSolution(string solutionFileName, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            var session = new Dictionary<string, object>();

            Console.WriteLine("...generating all-platforms solution file solutionFileName", solutionFileName);

            // use an AWSSDK prefix on project names so as to not collect any user-created projects (unless they
            // chose to use our naming pattern)
            const string awssdkProjectFileNamePattern = "AWSSDK.*.csproj";

            var sdkSourceFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);

            var coreProjects = new List<Project>();
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);
            foreach (var projectFile in Directory.GetFiles(coreProjectsRoot, awssdkProjectFileNamePattern, SearchOption.TopDirectoryOnly))
            {
                coreProjects.Add(CoreProjectFromFile(projectFile));
            }

            var serviceSolutionFolders = new List<ServiceSolutionFolder>();
            var serviceProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot))
            {
                var di = new DirectoryInfo(servicePath);
                var folder = ServiceSolutionFolderFromPath(di.Name);

                foreach (var projectFile in Directory.GetFiles(servicePath, awssdkProjectFileNamePattern, SearchOption.TopDirectoryOnly))
                {
                    folder.Projects.Add(ServiceProjectFromFile(di.Name, projectFile));
                }

                serviceSolutionFolders.Add(folder);
            }

            var testProjects = new List<Project>
            {
                GeneratorLibProject    
            };

            var sdkTestsFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
            foreach (var testFoldername in new[] { GeneratorDriver.UnitTestsSubFoldername, GeneratorDriver.IntegrationTestsSubFolderName })
            {
                var testsFolder = Path.Combine(sdkTestsFolder, testFoldername);
                foreach (var projectFile in Directory.GetFiles(testsFolder, awssdkProjectFileNamePattern, SearchOption.TopDirectoryOnly))
                {
                    testProjects.Add(TestProjectFromFile(testFoldername, projectFile));
                }
            }

            foreach(var pfc in projectFileConfigurations)
            {
                AddExtraTestProjects(pfc, _allProjects, testProjects);
            }

            // as we are processing _allProjects, construct the set of distinct build configurations at the end
            var distinctConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var projectKey in _allProjects.Keys)
            {
                foreach (var cp in _allProjects[projectKey].ConfigurationPlatforms)
                {
                    distinctConfigurations.Add(cp);
                }
            }

            var configurationsList = distinctConfigurations.ToList();
            configurationsList.Sort();

            session["AllProjects"] = _allProjects;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = serviceSolutionFolders;
            session["TestProjects"] = testProjects;
            session["Configurations"] = configurationsList;

            var generator = new SolutionFileGenerator { Session = session };
            var content = generator.TransformText();
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, solutionFileName, content, true, false);
        }

        private void GenerateCombinedSolution(string solutionFileName, bool includeTests, IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {            
            Console.WriteLine("Generating solution file {0}", solutionFileName);

            var session = new Dictionary<string, object>();

            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var solutionProjects = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();            

            var sdkSourceFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);

            var coreProjects = new List<Project>();
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);

            foreach (var pfc in projectFileConfigurations)
            {
                var projectTypeWildCard = string.Format("AWSSDK.*.{0}.csproj", pfc.Name);
                foreach (var projectFile in Directory.GetFiles(coreProjectsRoot, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                {
                    coreProjects.Add(CoreProjectFromFile(projectFile));
                    SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
                }
            }

            var serviceSolutionFolders = new List<ServiceSolutionFolder>();
            var serviceProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot))
            {
                var di = new DirectoryInfo(servicePath);
                var folder = ServiceSolutionFolderFromPath(di.Name);
                foreach (var pfc in projectFileConfigurations)
                {
                    var projectTypeWildCard = string.Format("AWSSDK.*.{0}.csproj", pfc.Name);
                    foreach (var projectFile in Directory.GetFiles(servicePath, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                    {
                        folder.Projects.Add(ServiceProjectFromFile(di.Name, projectFile));
                        SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
                    }
                }

                if (folder.Projects.Count > 0)
                    serviceSolutionFolders.Add(folder);
            }

            var testProjects = new List<Project>();
            if (includeTests)
            {
                foreach (var pfc in projectFileConfigurations)
                {
                    var projectType = pfc.Name;
                    var projectTypeWildCard = string.Format("AWSSDK.*.{0}.csproj", pfc.Name);

                    var sdkTestsFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
                    foreach (var testFoldername in new[] { GeneratorDriver.UnitTestsSubFoldername, GeneratorDriver.IntegrationTestsSubFolderName })
                    {
                        var testFolder = Path.Combine(sdkTestsFolder, testFoldername);
                        foreach (var projectFile in Directory.GetFiles(testFolder, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                        {
                            testProjects.Add(TestProjectFromFile(testFoldername, projectFile));

                            var projectKey = Path.GetFileNameWithoutExtension(projectFile);
                            solutionProjects.Add(projectKey, _allProjects[projectKey]);
                            SelectBuildConfigurationsForProject(projectKey, buildConfigurations);
                        }
                    }

                    if (projectType.Equals(ProjectTypes.Net35, StringComparison.Ordinal) || projectType.Equals(ProjectTypes.Net45, StringComparison.Ordinal) &&
                        !solutionProjects.ContainsKey(GeneratorLibProjectName))
                    {
                        solutionProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
                        testProjects.Add(GeneratorLibProject);
                        SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);
                    }

                    AddExtraTestProjects(pfc, solutionProjects, testProjects);
                }
            }

            var configurationsList = buildConfigurations.ToList();
            configurationsList.Sort();

            session["AllProjects"] = solutionProjects;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = serviceSolutionFolders;
            session["TestProjects"] = testProjects;
            session["Configurations"] = configurationsList;

            var generator = new SolutionFileGenerator { Session = session };
            var content = generator.TransformText();            
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, solutionFileName, content, true, false);
        }

        private void GeneratePlatformSpecificSolution(ProjectFileConfiguration projectConfig, bool includeTests, bool travisSolution, string solutionFileName = null)
        {
            // Do not generate solutions for PCL sub profiles.
            if (projectConfig.IsSubProfile)
            {
                return;
            }

            var projectType = projectConfig.Name;
            Console.WriteLine("...generating platform-specific solution file AWSSDK.{0}.sln", projectType);

            var session = new Dictionary<string, object>();

            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var solutionProjects = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

            var projectTypeWildCard = string.Format("AWSSDK.*.{0}.csproj", projectType);

            var sdkSourceFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);

            var coreProjects = new List<Project>();
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);
            foreach (var projectFile in Directory.GetFiles(coreProjectsRoot, projectTypeWildCard, SearchOption.TopDirectoryOnly))
            {
                coreProjects.Add(CoreProjectFromFile(projectFile));
                SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
            }

            var serviceSolutionFolders = new List<ServiceSolutionFolder>();
            var serviceProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot))
            {
                var di = new DirectoryInfo(servicePath);
                var folder = ServiceSolutionFolderFromPath(di.Name);

                foreach (var projectFile in Directory.GetFiles(servicePath, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                {
                    if (travisSolution && projectFile.Contains("AWSSDK.MobileAnalytics"))
                        continue;

                    folder.Projects.Add(ServiceProjectFromFile(di.Name, projectFile));
                    SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
                }

                serviceSolutionFolders.Add(folder);
            }

            var testProjects = new List<Project>();
            if (includeTests)
            {
                var sdkTestsFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
                foreach (var testFoldername in new[] { GeneratorDriver.UnitTestsSubFoldername, GeneratorDriver.IntegrationTestsSubFolderName })
                {
                    var testFolder = Path.Combine(sdkTestsFolder, testFoldername);
                    foreach (var projectFile in Directory.GetFiles(testFolder, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                    {
                        testProjects.Add(TestProjectFromFile(testFoldername, projectFile));

                        var projectKey = Path.GetFileNameWithoutExtension(projectFile);
                        solutionProjects.Add(projectKey, _allProjects[projectKey]);
                        SelectBuildConfigurationsForProject(projectKey, buildConfigurations);
                    }
                }

                if (projectType.Equals(ProjectTypes.Net35, StringComparison.Ordinal) || projectType.Equals(ProjectTypes.Net45, StringComparison.Ordinal))
                {
                    solutionProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
                    testProjects.Add(GeneratorLibProject);
                    SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);
                }

                AddExtraTestProjects(projectConfig, solutionProjects, testProjects);
            }

            var configurationsList = buildConfigurations.ToList();
            configurationsList.Sort();

            session["AllProjects"] = solutionProjects;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = serviceSolutionFolders;
            session["TestProjects"] = testProjects;
            session["Configurations"] = configurationsList;

            var generator = new SolutionFileGenerator { Session = session };
            var content = generator.TransformText();
            if (string.IsNullOrEmpty(solutionFileName))
                solutionFileName = string.Format("AWSSDK.{0}.sln", projectType);
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, solutionFileName, content, true, false);
        }

        private void AddExtraTestProjects(ProjectFileConfiguration projectConfig, Dictionary<string, ProjectFileCreator.ProjectConfigurationData> solutionProjects, List<Project> testProjects)
        {
            foreach (var extraTestProject in projectConfig.ExtraTestProjects)
            {
                var projectPath = @"..\..\..\..\sdk\" + extraTestProject;

                var projectGuid = Utils.GetProjectGuid(projectPath);
                var testProject = ProjectFromFile(extraTestProject, projectGuid);

                var testProjectConfig = new ProjectFileCreator.ProjectConfigurationData
                {
                    ProjectGuid = projectGuid,
                    ConfigurationPlatforms = GetProjectPlatformsFromFile(projectPath).ToList()
                };

                solutionProjects.Add(testProject.Name, testProjectConfig);
                testProjects.Add(testProject);
            }
        }

        void SelectProjectAndConfigurationsForSolution(string projectFile, 
                                                       IDictionary<string, ProjectFileCreator.ProjectConfigurationData> solutionProjects, 
                                                       ISet<string> buildConfigurations)
        {
            var projectKey = Path.GetFileNameWithoutExtension(projectFile);
            solutionProjects.Add(projectKey, _allProjects[projectKey]);
            SelectBuildConfigurationsForProject(projectKey, buildConfigurations);
        }

        void SelectBuildConfigurationsForProject(string projectKey, ISet<string> buildConfigurations)
        {
            foreach (var cp in _allProjects[projectKey].ConfigurationPlatforms)
            {
                buildConfigurations.Add(cp);
            }
        }

        Project CoreProjectFromFile(string projectFile)
        {
            var fi = new FileInfo(projectFile);
            var projectName = Path.GetFileNameWithoutExtension(fi.Name);
            return new Project
            {
                Name = Path.GetFileNameWithoutExtension(projectFile),
                ProjectGuid = this._allProjects[projectName].ProjectGuid,
                ProjectPath = @"src\Core\" + fi.Name
            };
        }

        Project TestProjectFromFile(string folderName, string projectFile)
        {
            var fi = new FileInfo(projectFile);
            var projectName = Path.GetFileNameWithoutExtension(fi.Name);
            return new Project
            {
                Name = Path.GetFileNameWithoutExtension(projectFile),
                ProjectGuid = _allProjects[projectName].ProjectGuid,
                ProjectPath = string.Format(@"test\{0}\{1}", folderName, fi.Name)
            };
        }

        Project ServiceProjectFromFile(string folderName, string projectFile)
        {
            var fi = new FileInfo(projectFile);
            var projectName = Path.GetFileNameWithoutExtension(fi.Name);
            return new Project
            {
                Name = Path.GetFileNameWithoutExtension(projectFile),
                ProjectGuid = this._allProjects[projectName].ProjectGuid,
                ProjectPath = string.Format(@"src\Services\{0}\{1}", folderName, fi.Name)
            };
        }

        Project ProjectFromFile(string projectFile, string projectGuid)
        {
            var fi = new FileInfo(projectFile);
            var projectName = Path.GetFileNameWithoutExtension(fi.Name);
            return new Project
            {
                Name = Path.GetFileNameWithoutExtension(projectFile),
                ProjectGuid = projectGuid,
                ProjectPath = projectFile
            };
        }

        ServiceSolutionFolder ServiceSolutionFolderFromPath(string folderName)
        {
            return new ServiceSolutionFolder(folderName.Replace("Amazon.", ""));
        }

        public class Project
        {
            public string ProjectGuid { get; set; }
            public string ProjectPath { get; set; }
            public string Name { get; set; }
        }

        public class ServiceSolutionFolder
        {
            public string Name { get; private set; }
            public List<Project> Projects { get; private set; }
            public string ProjectGuid { get; private set; }

            public ServiceSolutionFolder(string folderName)
            {
                Name = folderName;
                Projects = new List<Project>();
                ProjectGuid = GetFolderGuid(folderName);
            }

            private static string GetFolderGuid(string folderName)
            {
                var hash = folderName.GetHashCode();
                var random = new Random(hash);
                var bytes = new byte[16];
                random.NextBytes(bytes);
                var guid = new Guid(bytes);
                var text = guid.ToString("B").ToUpper();
                return text;
            }
        }
    }
}
