using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text.RegularExpressions;

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
            public const string CoreCLR = "CoreCLR";
            public const string Win8 = "Win8";
            public const string WinPhone81 = "WinPhone81";
            public const string WinPhoneSilverlight8 = "WinPhoneSilverlight8";
            public const string PCL = "PCL";
            public const string Android = "Android";
            public const string IOS = "iOS";
            public const string Unity = "Unity";
            public const string Partial = "partial";

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

            // build project configuraitons for each solution
            var net35ProjectConfigs = new List<ProjectFileConfiguration> { GetProjectConfig(ProjectTypes.Net35) };
            var net45ProjectConfigs = new List<ProjectFileConfiguration> { GetProjectConfig(ProjectTypes.Net45) };

            var pclProjectConfigs = new List<ProjectFileConfiguration> {
                    GetProjectConfig(ProjectTypes.PCL),
                    GetProjectConfig(ProjectTypes.Android),
                    GetProjectConfig(ProjectTypes.IOS),
                    GetProjectConfig(ProjectTypes.Win8),
                    GetProjectConfig(ProjectTypes.WinPhone81),
                    GetProjectConfig(ProjectTypes.WinPhoneSilverlight8)
                };

            var unityProjectConfigs = new List<ProjectFileConfiguration>{
                    GetProjectConfig(ProjectTypes.Unity)
                };

            var coreCLRProjectConfigs = new List<ProjectFileConfiguration> {
                    GetProjectConfig(ProjectTypes.CoreCLR)
                };

            GenerateVS2017Solution("AWSSDK.Net35.sln", true, false, net35ProjectConfigs);
            GenerateVS2017Solution("AWSSDK.Net45.sln", true, false, net45ProjectConfigs);
            GenerateCombinedSolution("AWSSDK.PCL.sln", true, pclProjectConfigs);
            GenerateCombinedSolution("AWSSDK.Unity.sln", false, unityProjectConfigs);

            GenerateVS2017Solution("AWSSDK.CoreCLR.sln", true, false, coreCLRProjectConfigs);

            // Include solutions that Travis CI can build
            GenerateVS2017Solution("AWSSDK.Net35.Travis.sln", false, true, net35ProjectConfigs);
            GenerateVS2017Solution("AWSSDK.Net45.Travis.sln", false, true, net45ProjectConfigs);

            ICollection<string> projectsForPartialBuild = Options.PartialBuildList;
            if (projectsForPartialBuild != null && projectsForPartialBuild.Count != 0)
            {
                // If we are explicitly rebuilding Core, all service projects must be rebuilt as well.
                if (projectsForPartialBuild.Contains("Core", StringComparer.InvariantCultureIgnoreCase))
                {
                    projectsForPartialBuild = null;
                }

                GenerateVS2017Solution("Build.Net35.partial.sln", false, false, net35ProjectConfigs, projectsForPartialBuild);
                GenerateVS2017Solution("Build.Net45.partial.sln", false, false, net45ProjectConfigs, projectsForPartialBuild);
                GenerateCombinedSolution("Build.PCL.partial.sln", false, pclProjectConfigs, projectsForPartialBuild);
                GenerateVS2017Solution("Build.CoreCLR.partial.sln", false, false, coreCLRProjectConfigs, projectsForPartialBuild);
            }
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
            const string awssdkProjectNamePattern = "AWSSDK.*.*proj";

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
                case ProjectTypes.CoreCLR:
                case ProjectTypes.PCL:
                case ProjectTypes.Android:
                case ProjectTypes.IOS:
                case ProjectTypes.Unity:
                case ProjectTypes.Partial:
                    return StandardPlatformConfigurations;
            }

            throw new Exception(string.Format("Unrecognized platform type in project name - '{0}'", projectType));
        }

        private void GenerateCombinedSolution(string solutionFileName, bool includeTests, IEnumerable<ProjectFileConfiguration> projectFileConfigurations, ICollection<string> serviceProjectsForPartialBuild = null)
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

                // If we are generating a partial solution, and the service project has not changed, omit it from the partial solution.
                if (serviceProjectsForPartialBuild != null && !serviceProjectsForPartialBuild.Contains(di.Name, StringComparer.InvariantCultureIgnoreCase))
                {
                    continue;
                }

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
                    string[] testFolderNames = (serviceProjectsForPartialBuild == null)
                        ? new string[] { GeneratorDriver.CommonTestSubFoldername, GeneratorDriver.UnitTestsSubFoldername, GeneratorDriver.IntegrationTestsSubFolderName }
                        : new string[] { GeneratorDriver.CommonTestSubFoldername, GeneratorDriver.UnitTestsSubFoldername};

                    foreach (var testFoldername in testFolderNames)
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

        private static IDictionary<string, string> GetItemGuidDictionary(string solutionsFilePath)
        {
            IDictionary<string, string> itemGuidDictionary = new Dictionary<string, string>();

            if (File.Exists(solutionsFilePath))
            {
                Regex expression = new Regex(@"Project\(""{(.*)}""\)\s*=\s*""(.*)"",\s*""(.*)"",\s*""(.*)""");
                foreach (string line in File.ReadAllLines(solutionsFilePath))
                {
                    Match match = expression.Match(line);
                    if (match.Success)
                    {
                        string itemType = match.Groups[1].ToString();
                        string itemName = match.Groups[2].ToString();
                        string itemSource = match.Groups[3].ToString();
                        string itemGuid = match.Groups[4].ToString();

                        itemGuidDictionary.Add(itemName, itemGuid);
                    }
                }
            }
            return itemGuidDictionary;
        }

        private static string GetSolutionGuid(string solutionsFilePath)
        {
            if (File.Exists(solutionsFilePath))
            {
                Regex expression = new Regex(@"\s*SolutionGuid\s*=\s*{(.*)}");
                foreach (string line in File.ReadAllLines(solutionsFilePath))
                {
                    Match match = expression.Match(line);
                    if (match.Success)
                    {
                        return match.Groups[1].ToString();
                    }
                }
            }
            return Guid.NewGuid().ToString("D").ToUpper();
        }


        private void GenerateVS2017Solution(string solutionFileName, bool includeTests, bool isTravisSolution, IEnumerable<ProjectFileConfiguration> projectFileConfigurations, ICollection<string> serviceProjectsForPartialBuild = null)
        {
            //
            // Since vs2017 .csproj files are not identified by guid, see if we can scan and determine the guid ahead of time to reduce changes
            // to .sln files if possible.
            //
            IDictionary<string, string> projectGuidDictionary = GetItemGuidDictionary(Path.Combine(Options.SdkRootFolder, solutionFileName));
            string solutionGuid = GetSolutionGuid(Path.Combine(Options.SdkRootFolder, solutionFileName));

            var sdkSourceFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);
            var session = new Dictionary<string, object>();

            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var solutionProjects = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

            var serviceSolutionFolders = new List<ServiceSolutionFolder>();
            var serviceProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot))
            {
                var di = new DirectoryInfo(servicePath);
                var folder = ServiceSolutionFolderFromPath(di.Name);

                // If we are generating a partial solution, and the service project has not changed, omit it from the partial solution.
                bool omitService = serviceProjectsForPartialBuild != null && !serviceProjectsForPartialBuild.Contains(di.Name, StringComparer.InvariantCultureIgnoreCase);
                if (omitService)
                {
                    continue;
                }

                foreach (var configuration in projectFileConfigurations)
                {
                    string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                    foreach (var projectFile in Directory.GetFiles(servicePath, projectFilePattern, SearchOption.TopDirectoryOnly))
                    {
                        if (isTravisSolution && projectFile.Contains("AWSSDK.MobileAnalytics"))
                            continue;

                        string projectName = Path.GetFileNameWithoutExtension(projectFile);
                        folder.Projects.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = string.Format(@"src\Services\{0}\{1}", di.Name, Path.GetFileName(projectFile)),
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                        });
                        SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
                    }
                }

                if(folder.Projects.Count > 0)
                    serviceSolutionFolders.Add(folder);
            }

            IList<Project> coreProjects = new List<Project>();
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);
            foreach (var configuration in projectFileConfigurations)
            {
                string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                foreach(var projectFile in Directory.GetFiles(coreProjectsRoot, projectFilePattern, SearchOption.TopDirectoryOnly))
                {
                    string projectName = Path.GetFileNameWithoutExtension(projectFile);
                    coreProjects.Add(new Project
                    {
                        Name = projectName,
                        ProjectPath = string.Format(@"src\Core\{0}", Path.GetFileName(projectFile)),
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                    });
                }
            }

            IList<Project> testProjects = new List<Project>();
            if (includeTests)
            {
                var testProjectsRoot = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
                foreach (var configuration in projectFileConfigurations)
                {
                    string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                    foreach (var projectFile in Directory.GetFiles(testProjectsRoot, projectFilePattern, SearchOption.AllDirectories))
                    {
                        string projectName = Path.GetFileNameWithoutExtension(projectFile);
                        testProjects.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = CreateRelativePath(Options.SdkRootFolder, projectFile),
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                        });
                    }

                    if (configuration.Name.Equals(ProjectTypes.Net35, StringComparison.Ordinal) || configuration.Name.Equals(ProjectTypes.Net45, StringComparison.Ordinal))
                    {
                        solutionProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
                        testProjects.Add(GeneratorLibProject);
                        SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);
                    }
                }
            }
            session["TestProjects"] = testProjects;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = serviceSolutionFolders;
            session["SolutionGuid"] = solutionGuid;

            var generator = new CoreCLRSolutionFile() { Session = session };
            var content = generator.TransformText();
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, solutionFileName, content, true, false);
        }

        private static string CreateRelativePath(string path1, string path2)
        {
            // we assume path2 is a strict subpath of path1 
            return path2.Replace(path1, "").TrimStart(new char[] { ' ', '\\', '/' });
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
                foreach (var testFoldername in new[] { GeneratorDriver.CommonTestSubFoldername, GeneratorDriver.UnitTestsSubFoldername, GeneratorDriver.IntegrationTestsSubFolderName })
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

            var session = new Dictionary<string, object>();
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

        private void GenerateBuildUnitTestSolution(string solutionFileName, IEnumerable<ProjectFileConfiguration> projectFileConfigurations, ICollection<string> serviceProjectsForPartialBuild = null)
        {
            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // AllProjects
            var solutionProjects = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

            // CoreProjects
            var coreProjects = new List<Project>();

            // TestProjects
            var testProjects = new List<Project>
            {
                GeneratorLibProject
            };
            foreach (var pfc in projectFileConfigurations)
            {
                var projectType = pfc.Name;
                var sdkTestsFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);

                // Add partial project files
                var projectTypeWildCard = string.Format("AWSSDK.*.{0}.partial.csproj", pfc.Name);
                var testFolder = Path.Combine(sdkTestsFolder, GeneratorDriver.UnitTestsSubFoldername);
                foreach (var projectFile in Directory.GetFiles(testFolder, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                {
                    testProjects.Add(TestProjectFromFile(GeneratorDriver.UnitTestsSubFoldername, projectFile));
                                                
                    var projectKey = Path.GetFileNameWithoutExtension(projectFile);
                    solutionProjects.Add(projectKey, _allProjects[projectKey]);
                    SelectBuildConfigurationsForProject(projectKey, buildConfigurations);
                }

                // Add common test project files
                projectTypeWildCard = string.Format("AWSSDK.*.{0}.csproj", pfc.Name);
                testFolder = Path.Combine(sdkTestsFolder, GeneratorDriver.CommonTestSubFoldername);
                foreach (var projectFile in Directory.GetFiles(testFolder, projectTypeWildCard, SearchOption.TopDirectoryOnly))
                {
                    testProjects.Add(TestProjectFromFile(GeneratorDriver.CommonTestSubFoldername, projectFile));

                    var projectKey = Path.GetFileNameWithoutExtension(projectFile);
                    solutionProjects.Add(projectKey, _allProjects[projectKey]);
                    SelectBuildConfigurationsForProject(projectKey, buildConfigurations);
                }

                if (projectType.Equals(ProjectTypes.Net35, StringComparison.Ordinal) || projectType.Equals(ProjectTypes.Net45, StringComparison.Ordinal) &&
                    !solutionProjects.ContainsKey(GeneratorLibProjectName))
                {
                    solutionProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
                    SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);
                }

                AddExtraTestProjects(pfc, solutionProjects, testProjects);
            }

            var configurationsList = buildConfigurations.ToList();
            configurationsList.Sort();

            var session = new Dictionary<string, object>();
            session["AllProjects"] = solutionProjects;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = new List<ServiceSolutionFolder>();
            session["TestProjects"] = testProjects;
            session["Configurations"] = configurationsList;

            var generator = new SolutionFileGenerator { Session = session };
            var content = generator.TransformText();
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, "Build.UnitTests.partial.sln", content, true, false);
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
            public string FolderGuid { get; set; }
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
