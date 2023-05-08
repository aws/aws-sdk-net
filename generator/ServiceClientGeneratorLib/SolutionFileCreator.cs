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

        /// Regex check to identify framework of a project.
        private static readonly Regex FrameworkRegex = new Regex(@"<TargetFramework[^>]*>(.*?)<\/TargetFramework>");

        /// <summary>
        /// The set of project 'types' (or platforms) that we generate the SDK against.
        /// These type names form part of the project filename.
        /// </summary>
        public abstract class ProjectTypes
        {
            public const string Net35 = "Net35";
            public const string Net45 = "Net45";
            public const string NetStandard = "NetStandard";
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

        private const string CommonTestProjectGuid = "{66F78F86-68D7-4538-8EA5-A669A08E1C19}";
        private const string CommonTestProjectName = "AWSSDK.CommonTest";

        private const string UnitTestUtilityProjectFileName35 = "AWSSDK.UnitTestUtilities.Net35";
        private const string UtilityProjectFileGuid35 = "{A23CE153-A4A3-4D3A-A6DC-0DD1B207118E}";

        private const string UnitTestUtilityProjectFileName45 = "AWSSDK.UnitTestUtilities.Net45";
        private const string UtilityProjectFileGuid45 = "{002B183F-E568-49CD-9D06-CBCFF2C2921F}";

        private const string IntegrationTestUtilityName35 = "AWSSDK.IntegrationTestUtilities.Net35";
        private const string IntegrationTestUtilityGuid35 = "{924D2906-70D6-4D77-8603-816648B2CCA6}";

        private const string IntegrationTestUtilityName45 = "AWSSDK.IntegrationTestUtilities.Net45";
        private const string IntegrationTestUtilityGuid45 = "{7AB0DA1C-CA0E-4579-BA82-2B41A9DA15C7}";

        private static Regex ProjectReferenceRegex = new Regex("\"([^\"]*)\"");

        private static readonly ProjectFileCreator.ProjectConfigurationData GeneratorLibProjectConfig
            = new ProjectFileCreator.ProjectConfigurationData
            {
                ProjectGuid = GeneratorLibProjectGuid,
                ConfigurationPlatforms = StandardPlatformConfigurations
            };

        private static readonly ProjectFileCreator.ProjectConfigurationData CommonTestProjectConfig
            = new ProjectFileCreator.ProjectConfigurationData
            {
                ProjectGuid = CommonTestProjectGuid,
                ConfigurationPlatforms = StandardPlatformConfigurations
            };

        private static readonly Project GeneratorLibProject = new Project
        {
            Name = GeneratorLibProjectName,
            ProjectGuid = GeneratorLibProjectGuid,
            ProjectPath = string.Format(@"..\generator\{0}\{0}.csproj", GeneratorLibProjectName)
        };

        private static readonly Project ServiceSlnGeneratorLibProject = new Project
        {
            Name = GeneratorLibProjectName,
            ProjectGuid = GeneratorLibProjectGuid,
            ProjectPath = Path.Combine("..", "..", "..", GeneratorLibProject.ProjectPath)
        };

        private static readonly Project CommonTestProject = new Project
        {
            Name = CommonTestProjectName,
            ProjectGuid = CommonTestProjectGuid,
            ProjectPath = string.Format(@"..\sdk\test\Common\{0}.csproj", CommonTestProjectName)
        };

        private static readonly Project ServiceSlnCommonTestProject = new Project
        {
            Name = CommonTestProjectName,
            ProjectGuid = CommonTestProjectGuid,
            ProjectPath = Path.Combine("..", "..", "..", CommonTestProject.ProjectPath),
            RelativePath = string.Format(@"..\..\..\test\Common\{0}.csproj", CommonTestProjectName)
        };

        private static readonly Project UnitTestUtilityProject35 = new Project
        {
            Name = UnitTestUtilityProjectFileName35,
            ProjectGuid = UtilityProjectFileGuid35,
            ProjectPath = string.Format(@"..\..\..\..\sdk\test\UnitTests\Custom\{0}.csproj", UnitTestUtilityProjectFileName35),
            RelativePath = string.Format(@"..\..\..\test\UnitTests\Custom\{0}.csproj", UnitTestUtilityProjectFileName35)
        };

        private static readonly Project UnitTestUtilityProject45 = new Project
        {
            Name = UnitTestUtilityProjectFileName45,
            ProjectGuid = UtilityProjectFileGuid45,
            ProjectPath = string.Format(@"..\..\..\..\sdk\test\UnitTests\Custom\{0}.csproj", UnitTestUtilityProjectFileName45),
            RelativePath = string.Format(@"..\..\..\test\UnitTests\Custom\{0}.csproj", UnitTestUtilityProjectFileName45)
        };

        private static readonly Project IntegrationTestUtility35Project = new Project
        {
            Name = IntegrationTestUtilityName35,
            ProjectGuid = IntegrationTestUtilityGuid35,
            ProjectPath = string.Format(@"..\..\..\..\sdk\test\IntegrationTests\{0}.csproj", IntegrationTestUtilityName35),
            RelativePath = string.Format(@"..\..\..\test\IntegrationTests\{0}.csproj", IntegrationTestUtilityName35)
        };

        private static readonly Project IntegrationTestUtility45Project = new Project
        {
            Name = IntegrationTestUtilityName45,
            ProjectGuid = IntegrationTestUtilityGuid45,
            ProjectPath = string.Format(@"..\..\..\..\sdk\test\IntegrationTests\{0}.csproj", IntegrationTestUtilityName45),
            RelativePath = string.Format(@"..\..\..\test\IntegrationTests\{0}.csproj", IntegrationTestUtilityName45)
        };

        private static readonly List<Project> CoreProjects = new List<Project>{ 
        new Project
        {
            Name = "AWSSDK.Core.Net35",
            ProjectGuid = "{1FACE5D0-97BF-4069-B4F7-0FE28BB160F8}",
            ProjectPath = @"..\..\Core\AWSSDK.Core.Net35.csproj"
        },
        new Project
        {
            Name = "AWSSDK.Core.Net45",
            ProjectGuid = "{7DE3AFA0-1B2D-41B1-82BD-120B8B210B43}",
            ProjectPath = @"..\..\Core\AWSSDK.Core.Net45.csproj"
        },
        new Project
        {
            Name = "AWSSDK.Core.NetStandard",
            ProjectGuid = "{A855B58E-ED32-40AE-AE8F-054F448B9F2C}",
            ProjectPath = @"..\..\Core\AWSSDK.Core.NetStandard.csproj"
        }
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

            var netStandardProjectConfigs = new List<ProjectFileConfiguration> {
                    GetProjectConfig(ProjectTypes.NetStandard)
                };

            GenerateVS2017ServiceSolution(net35ProjectConfigs);
            GenerateVS2017Solution("AWSSDK.Net35.sln", true, false, net35ProjectConfigs);
            GenerateVS2017Solution("AWSSDK.Net45.sln", true, false, net45ProjectConfigs);

            GenerateVS2017Solution("AWSSDK.NetStandard.sln", true, false, netStandardProjectConfigs);

            // Include solutions that Travis CI can build
            GenerateVS2017Solution("AWSSDK.Net35.Travis.sln", false, true, net35ProjectConfigs);
            GenerateVS2017Solution("AWSSDK.Net45.Travis.sln", false, true, net45ProjectConfigs);
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
                        ConfigurationPlatforms = GetProjectPlatforms(projectName, projectFile)
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

        private static IEnumerable<string> GetProjectPlatformsFromFile(string projectFile)
        {
            var platforms = new List<string>();

            var content = File.ReadAllText(projectFile);
            var doc = new XmlDocument();
            doc.LoadXml(content);

            var searchPhrase = "$(Configuration)|$(Platform)";
            var propertyGroups = doc.GetElementsByTagName("PropertyGroup");
            foreach (XmlNode pg in propertyGroups)
            {
                var conditionAttribute = pg.Attributes["Condition"];
                if (conditionAttribute != null)
                {
                    var condition = conditionAttribute.Value;
                    if (condition.IndexOf(searchPhrase, StringComparison.Ordinal) >= 0)
                    {
                        var thirdQuote = condition.IndexOfNthOccurrence('\'', 0, 3);
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
        private static IEnumerable<string> GetProjectPlatforms(string projectName, string projectFile)
        {
            string projectType = GetProjectType(projectName);

            var platformConfigurations = GetPlatformConfigurations(projectType);
            // Identify the framework of the project file if not already identified.
            return IdentifyProjectConfigurations(projectFile, platformConfigurations, projectType);
        }

        private static string GetProjectType(string projectName)
        {
            var projectTypeStart = projectName.LastIndexOf('.');
            var projectType = projectName.Substring(projectTypeStart + 1);
            return projectType;
        }

        private static IEnumerable<string> GetPlatformConfigurations(string projectType)
        {
            switch (projectType)
            {
                case ProjectTypes.Net35:
                case ProjectTypes.Net45:
                case ProjectTypes.NetStandard:
                case ProjectTypes.Partial:
                    return StandardPlatformConfigurations;
                default:
                    return null;
            }
        }
        /// <summary>
        /// Method that opens the project file and does a Regex match for <TargetFramework></TargetFramework>
        /// to identify the framework of the csproj.
        /// </summary>
        private static IEnumerable<string> IdentifyProjectConfigurations(string projectFile, IEnumerable<string> configurations, string projectType)
        {
            if (!string.IsNullOrEmpty(projectFile) && (configurations == null))
            {
                var fileContent = File.ReadAllText(projectFile);
                var match = FrameworkRegex.Match(fileContent);
                configurations = GetPlatformConfigurations(match.Groups[1].ToString());
            }

            if (configurations != null)
                return configurations;
            else
                throw new Exception(string.Format("Unrecognized platform type in project name - '{0}'", projectType));
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
            var testServiceProjectsRoot = serviceProjectsRoot.Replace("src", "test");
            var services = Directory.GetDirectories(serviceProjectsRoot).Select(c => new { Path = c, IsTestService = false });
            var testServices = Directory.GetDirectories(testServiceProjectsRoot).Select(c => new { Path = c, IsTestService = true });
            foreach (var servicePath in services.Concat(testServices))
            {
                var di = new DirectoryInfo(servicePath.Path);
                var folder = ServiceSolutionFolderFromPath(di.Name);

                // Previously, the project GUID was generated from a random array of bytes, but the output for that operation changed in netstandard.
                // To prevent all solution files from being modified, we re-use the GUID for the current service (if there's one available).
                if (projectGuidDictionary.ContainsKey(di.Name))
                {
                    folder.ProjectGuid = projectGuidDictionary[di.Name];
                }

                // If we are generating a partial solution, and the service project has not changed, omit it from the partial solution.
                bool omitService = serviceProjectsForPartialBuild != null && !serviceProjectsForPartialBuild.Contains(di.Name, StringComparer.InvariantCultureIgnoreCase);
                if (omitService)
                {
                    continue;
                }

                foreach (var configuration in projectFileConfigurations)
                {
                    string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                    foreach (var projectFile in Directory.GetFiles(servicePath.Path, projectFilePattern, SearchOption.TopDirectoryOnly))
                    {
                        if (isTravisSolution && projectFile.Contains("AWSSDK.MobileAnalytics"))
                            continue;

                        string projectName = Path.GetFileNameWithoutExtension(projectFile);
                        folder.Projects.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = string.Format(servicePath.IsTestService ? @"test\Services\{0}\{1}" : @"src\Services\{0}\{1}", di.Name, Path.GetFileName(projectFile)),
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                        });
                        SelectProjectAndConfigurationsForSolution(projectFile, solutionProjects, buildConfigurations);
                    }
                }

                if (folder.Projects.Count > 0)
                    serviceSolutionFolders.Add(folder);
            }

            IList<Project> coreProjects = new List<Project>();
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);
            foreach (var configuration in projectFileConfigurations)
            {
                string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                foreach (var projectFile in Directory.GetFiles(coreProjectsRoot, projectFilePattern, SearchOption.TopDirectoryOnly))
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
            IList<Project> integrationTestDependencies = new List<Project>();
            if (includeTests)
            {
                var testProjectsRoot = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
                foreach (var configuration in projectFileConfigurations)
                {
                    string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                    foreach (var projectFile in Directory.GetFiles(testProjectsRoot, projectFilePattern, SearchOption.AllDirectories)
                        .Where(projectFile => !Path.GetFileNameWithoutExtension(projectFile).Contains("Utilities") &&
                        !Path.GetFullPath(projectFile).Contains("Services") &&
                        !Path.GetFullPath(projectFile).Contains("CSM")))
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

                        solutionProjects.Add(CommonTestProjectName, CommonTestProjectConfig);
                        testProjects.Add(CommonTestProject);
                        SelectBuildConfigurationsForProject(CommonTestProjectName, buildConfigurations);
                    }

                    // We must add the CrtIntegration extension to the target framework-specific solutions (at this point there should only be a single projectFileConfiguration)
                    var platformSpecificCRTName = string.Format("AWSSDK.Extensions.CrtIntegration.{0}", projectFileConfigurations.First().Name);
                    var crtProject = new Project
                    {
                        Name = platformSpecificCRTName,
                        ProjectPath = $"..\\extensions\\src\\AWSSDK.Extensions.CrtIntegration\\{platformSpecificCRTName}.csproj",
                        ProjectGuid = projectGuidDictionary.ContainsKey(platformSpecificCRTName) ? projectGuidDictionary[platformSpecificCRTName] : Guid.NewGuid().ToString("B").ToUpper()
                    };
                    integrationTestDependencies.Add(crtProject);
                    solutionProjects.Add(platformSpecificCRTName, new ProjectFileCreator.ProjectConfigurationData
                    {
                        ProjectGuid = crtProject.ProjectGuid,
                        ConfigurationPlatforms = StandardPlatformConfigurations
                    });
                }
            }
            session["TestProjects"] = testProjects;
            session["IntegrationTestDependencies"] = integrationTestDependencies;
            session["CoreProjects"] = coreProjects;
            session["ServiceSolutionFolders"] = serviceSolutionFolders;
            session["SolutionGuid"] = solutionGuid;

            var generator = new SolutionFileBclAndNetStandard() { Session = session };
            var content = generator.TransformText();
            GeneratorDriver.WriteFile(Options.SdkRootFolder, null, solutionFileName, content, true, false);
        }

        private static string CreateRelativePath(string path1, string path2)
        {
            // we assume path2 is a strict subpath of path1 
            return path2.Replace(path1, "").TrimStart(new char[] { ' ', '\\', '/' });
        }

        /// <summary>
        /// Service specific solution generator. A single sln file is created that contains csproj for net35,net45,netstandard and their corresponding integ and unit tests.
        /// </summary>
        private void GenerateVS2017ServiceSolution(IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            var sdkSourceFolder = Path.Combine(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);
            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            var serviceProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            var coreProjectsRoot = Path.Combine(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);

            // Iterating through each service in the service folder
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot))
            {
                var session = new Dictionary<string, object>();
                var serviceSolutionFolders = new List<ServiceSolutionFolder>();
                var serviceDirectory = new DirectoryInfo(servicePath);
                var folder = ServiceSolutionFolderFromPath(serviceDirectory.Name);
                var solutionFileName = serviceDirectory.Name + ".sln";
                var serviceProjectDependencies = new List<string>();
                var testProjects = new List<Project>();
                var dependentProjects = new List<string>();
                var dependentProjectList = new List<Project>();
                var solutionPath = Path.Combine(serviceDirectory.ToString(), solutionFileName);
                // Since vs2017 .csproj files are not identified by guid, see if we can scan and determine the guid ahead of time to reduce changes
                // to .sln files if possible.
                IDictionary<string, string> projectGuidDictionary = GetItemGuidDictionary(solutionPath);

                // Previously, the project GUID was generated from a random array of bytes, but the output for that operation changed in netstandard.
                // To prevent all solution files from being modified, we re-use the GUID for the current service (if there's one available).
                if (projectGuidDictionary.ContainsKey(serviceDirectory.Name))
                {
                    folder.ProjectGuid = projectGuidDictionary[serviceDirectory.Name];
                }

                // Include only net35,net45,netstandard service csproj
                // in the service specific solutions
                foreach (var projectFile in Directory.EnumerateFiles(servicePath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.Contains("NetStandard") || s.Contains("Net35") || s.Contains("Net45")))
                {
                    serviceProjectDependencies.AddRange(AddProjectDependencies(projectFile, serviceDirectory.Name, new List<string>()));
                    serviceProjectDependencies.Add(projectFile);

                    SelectProjectAndConfigurationsForSolution(projectFile, buildConfigurations);
                }

                // Include service's Unit and Integ csproj files and its dependencies.
                AddTestProjectsAndDependencies(projectFileConfigurations, buildConfigurations, serviceDirectory, projectGuidDictionary, testProjects, dependentProjects);

                // Add AWSSDK.CommonTest.csproj 
                testProjects.Add(ServiceSlnCommonTestProject);
                SelectBuildConfigurationsForProject(CommonTestProjectName, buildConfigurations);

                foreach (var serviceProjectDependency in serviceProjectDependencies)
                {
                    string projectName = Path.GetFileNameWithoutExtension(serviceProjectDependency);
                    var filePath = serviceProjectDependency;
                    if (filePath.Contains(serviceDirectory.Name))
                    {
                        filePath = Path.GetFileName(serviceProjectDependency);
                    }
                    folder.Projects.Add(new Project
                    {
                        Name = projectName,
                        ProjectPath = filePath,
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper()
                    });
                }

                if (folder.Projects.Count == 0)
                {
                    continue;
                }

                ConvertToSlnRelativePath(testProjects, solutionPath);

                serviceSolutionFolders.Add(folder);
                // Adding core projects to service solution
                session["CoreProjects"] = CoreProjects;
                // Adding service projects and its dependencies to the service solution
                session["ServiceSolutionFolders"] = serviceSolutionFolders;
                // Adding test projects to the service solution
                session["TestProjects"] = testProjects;
                // Set solution guild property
                session["SolutionGuid"] = GetSolutionGuid(solutionPath);

                var dependentProjectPathList = dependentProjects.Distinct();
                var serviceProjectDependenciesNames = serviceProjectDependencies.Select(val => Path.GetFileNameWithoutExtension(val));
                foreach (var dependentProject in dependentProjectPathList)
                {
                    if (!serviceProjectDependenciesNames.Contains(Path.GetFileNameWithoutExtension(dependentProject)))
                    {
                        var projectName = Path.GetFileNameWithoutExtension(dependentProject);
                        dependentProjectList.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = dependentProject,
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper()
                        });
                    }
                }
                //Adding integration test service dependencies
                session["IntegrationTestDependencies"] = dependentProjectList;
                var generator = new SolutionFileBclAndNetStandard() { Session = session };
                var content = generator.TransformText();
                GeneratorDriver.WriteFile(serviceDirectory.FullName, null, solutionFileName, content, true, false);
            }
        }

        /// <summary>
        /// This method converts the test projects path from being generator sln relative to the service specific sln
        /// relative path
        /// Ex
        /// ..\..\..\..\sdk\test\Services\{ServiceName}\UnitTests\AWSSDK.UnitTests.{ServiceName}.Net35.csproj
        /// becomes
        /// ..\..\..\test\Services\{ServiceName}\UnitTests\AWSSDK.UnitTests.{ServiceName}.Net35.csproj
        /// </summary>
        private static void ConvertToSlnRelativePath(List<Project> testProjects, string solutionPath)
        {
            var solutionUri = new Uri(Path.GetFullPath(solutionPath));
            foreach (var testProject in testProjects)
            {
                if (!string.IsNullOrEmpty(testProject.RelativePath))
                {
                    continue;
                }
                var testProjecturi = new Uri(Path.GetFullPath(testProject.ProjectPath));
                testProject.RelativePath = solutionUri.MakeRelativeUri(testProjecturi).ToString().Replace('/', Path.DirectorySeparatorChar);
            }
        }

        /// <summary>
        /// Adding Service test projects and its dependecies
        /// </summary>
        private void AddTestProjectsAndDependencies(IEnumerable<ProjectFileConfiguration> projectFileConfigurations, HashSet<string> buildConfigurations, DirectoryInfo serviceDirectory, 
            IDictionary<string, string> projectGuidDictionary, IList<Project> testProjects, List<string> dependentProjects)
        {
            var testProjectsRoot = Path.Combine(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername, GeneratorDriver.ServicesSubFoldername, serviceDirectory.Name);
            foreach (var configuration in projectFileConfigurations)
            {
                string filePattern = string.Format("*.csproj");
                foreach (var projectFile in Directory.GetFiles(testProjectsRoot, filePattern, SearchOption.AllDirectories))
                {
                    string projectName = Path.GetFileNameWithoutExtension(projectFile);

                    if (GetProjectType(projectName).Equals(ProjectTypes.Partial, StringComparison.Ordinal))
                    {
                        continue;
                    }

                    if (projectName.Contains("Integration") || projectName.Contains("UnitTests"))
                    {
                        dependentProjects.AddRange(AddProjectDependencies
                            (projectFile, serviceDirectory.Name, new List<string>()));
                    }

                    testProjects.Add(new Project
                    {
                        Name = projectName,
                        ProjectPath = projectFile,
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                    });
                }

                if (configuration.Name.Equals(ProjectTypes.Net35, StringComparison.Ordinal) || configuration.Name.Equals(ProjectTypes.Net45, StringComparison.Ordinal))
                {
                    testProjects.Add(ServiceSlnGeneratorLibProject);
                    SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);

                    testProjects.Add(UnitTestUtilityProject35);
                    testProjects.Add(UnitTestUtilityProject45);

                    testProjects.Add(IntegrationTestUtility35Project);
                    dependentProjects.AddRange(AddProjectDependencies
                        (IntegrationTestUtility35Project.ProjectPath, serviceDirectory.Name, new List<string>()));

                    testProjects.Add(IntegrationTestUtility45Project);
                    dependentProjects.AddRange(AddProjectDependencies
                        (IntegrationTestUtility45Project.ProjectPath, serviceDirectory.Name, new List<string>()));
                }
            }
        }

        /// <summary>
        /// Opens a csproj file and recursively adds the project's reference to the sln dependency list
        /// </summary>
        private List<string> AddProjectDependencies(string projectFile, string serviceName, List<string> depsProjects)
        {
            foreach (var line in File.ReadAllLines(projectFile))
            {
                if (line.Contains("ProjectReference"))
                {
                    var matches = ProjectReferenceRegex.Match(line);
                    var fileName = matches.ToString().Replace("\"", "");
                    if (!(fileName.Contains("\\Core\\") || fileName.Contains($".{serviceName}.") || fileName.Contains("Test") || depsProjects.Contains(fileName)))
                    {
                        // This is in a different folder in than the usual service dependencies.
                        // Also skipping the recursion since this does not currently have any ProjectReferences beyond Core
                        if (fileName.Contains("AWSSDK.Extensions.CrtIntegration"))
                        {
                            var split = fileName.Split('\\');
                            // Build the relative path to \extensions\src\AWSSDK.Extensions.CrtIntegration\AWSSDK.Extensions.CrtIntegration.<target framework>.csproj
                            var deps = Path.Combine("..", "..", "..", "..", split[split.Length - 4], split[split.Length - 3], split[split.Length - 2], split[split.Length - 1]);
                            depsProjects.Add(deps);
                        }
                        else
                        {
                            var split = fileName.Split('\\');
                            // Build the relative path to \<service folder>\AWSSDK.<service>.<target framework>.csproj
                            var deps = Path.Combine("..", split[split.Length - 2], split[split.Length - 1]);
                            depsProjects.Add(deps);
                            AddProjectDependencies(Path.Combine(Options.SdkRootFolder, @"src\Services", split[split.Length - 2], split[split.Length - 1]), split[split.Length - 2], depsProjects);
                        }
                    }
                }
            }
            return depsProjects;
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

        void SelectProjectAndConfigurationsForSolution(string projectFile,
                                               ISet<string> buildConfigurations)
        {
            var projectKey = Path.GetFileNameWithoutExtension(projectFile);
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
            /// <summary>
            /// This property is being used only by service specific sln's test projects
            /// to denote a path relative to the sln files.
            /// </summary>
            public string RelativePath { get; set; }
        }

        public class ServiceSolutionFolder
        {
            public string Name { get; private set; }
            public List<Project> Projects { get; private set; }
            public string ProjectGuid { get; set; }

            public ServiceSolutionFolder(string folderName)
            {
                Name = folderName;
                Projects = new List<Project>();
                ProjectGuid = Guid.NewGuid().ToString("B").ToUpper();
            }
        }
    }
}
