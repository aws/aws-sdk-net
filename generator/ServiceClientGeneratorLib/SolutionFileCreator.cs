using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ServiceClientGenerator.Generators.ProjectFiles;

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
            public const string NetFramework = "NetFramework";
            public const string NetStandard = "NetStandard";
            public const string Partial = "partial";
        }

        /// <summary>
        /// Standard configuration platforms used for all project types.
        /// </summary>
        static readonly List<string> StandardPlatformConfigurations = new List<string>
        {
            "Debug|Any CPU",
            "Release|Any CPU"
        };

        private const string GeneratorLibProjectGuid = "{7BEE7C44-BE12-43CC-AFB9-B5852A1F43C8}";
        private const string GeneratorLibProjectName = "ServiceClientGeneratorLib";

        private const string CommonTestProjectGuid = "{66F78F86-68D7-4538-8EA5-A669A08E1C19}";
        private const string CommonTestProjectName = "AWSSDK.CommonTest";

        private const string UnitTestsNetStandardCoreOnlyProjectGuid = "{B969DE99-0634-4989-A318-086AE1699974}";
        private const string UnitTestsNetStandardCoreOnlyProjectName = "UnitTests.NetStandard.CoreOnly";

        private const string UnitTestUtilityProjectFileName = "AWSSDK.UnitTestUtilities";
        private const string UtilityProjectFileGuid = "{002B183F-E568-49CD-9D06-CBCFF2C2921F}";

        private const string IntegrationTestUtilityName = "AWSSDK.IntegrationTestUtilities.NetFramework";
        private const string IntegrationTestUtilityGuid = "{7AB0DA1C-CA0E-4579-BA82-2B41A9DA15C7}";

        private static Regex ProjectReferenceRegex = new Regex("\"([^\"]*)\"");

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
            ProjectPath = Utils.PathCombineAlt("..", "generator", GeneratorLibProjectName, $"{GeneratorLibProjectName}.csproj")
        };

        private static readonly Project ServiceSlnGeneratorLibProject = new Project
        {
            Name = GeneratorLibProjectName,
            ProjectGuid = GeneratorLibProjectGuid,
            ProjectPath = Utils.PathCombineAlt("..", "..", "..", GeneratorLibProject.ProjectPath)
        };

        /// <summary>
        /// Common test project reference used in the uber solutions (i.e. "AWSSDK.NetFramework.sln").
        /// </summary>
        private static readonly Project CommonTestProject = new Project
        {
            Name = CommonTestProjectName,
            ProjectGuid = CommonTestProjectGuid,
            ProjectPath = Utils.PathCombineAlt("test", "Common", $"{CommonTestProjectName}.csproj")
        };

        /// <summary>
        /// Common test project reference used in the service specific solutions (i.e. "S3.sln").
        /// </summary>
        private static readonly Project ServiceSlnCommonTestProject = new Project
        {
            Name = CommonTestProjectName,
            ProjectGuid = CommonTestProjectGuid,
            ProjectPath = Utils.PathCombineAlt("..", "..", "..", CommonTestProject.ProjectPath),
            RelativePath = Utils.PathCombineAlt("..", "..", "..", "test", "Common", $"{CommonTestProjectName}.csproj")
        };

        /// <summary>
        /// Utilities project reference used in the uber solutions (i.e. "AWSSDK.NetFramework.sln").
        /// </summary>
        private static readonly Project UnitTestUtilityProject = new Project
        {
            Name = UnitTestUtilityProjectFileName,
            ProjectGuid = UtilityProjectFileGuid,
            ProjectPath = Utils.PathCombineAlt("test", "UnitTests", "Custom", $"{UnitTestUtilityProjectFileName}.csproj"),
        };

        /// <summary>
        /// Utilities project reference used in the service specific solutions (i.e. "S3.sln").
        /// </summary>
        private static readonly Project ServiceSlnUnitTestUtilityProject = new Project
        {
            Name = UnitTestUtilityProjectFileName,
            ProjectGuid = UtilityProjectFileGuid,
            ProjectPath = Utils.PathCombineAlt("..", "..", "..", "..", "sdk", "test", "UnitTests", "Custom", $"{UnitTestUtilityProjectFileName}.csproj"),
            RelativePath = Utils.PathCombineAlt("..", "..", "..", "test", "UnitTests", "Custom", $"{UnitTestUtilityProjectFileName}.csproj")
        };

        private static readonly Project IntegrationTestUtility45Project = new Project
        {
            Name = IntegrationTestUtilityName,
            ProjectGuid = IntegrationTestUtilityGuid,
            ProjectPath = Utils.PathCombineAlt("..", "..", "..", "..", "sdk", "test", "IntegrationTests", $"{IntegrationTestUtilityName}.csproj"),
            RelativePath = Utils.PathCombineAlt("..", "..", "..", "test", "IntegrationTests", $"{IntegrationTestUtilityName}.csproj")
        };

        private static readonly Project UnitTestsNetStandardCoreOnlyProject = new Project
        {
            Name = UnitTestsNetStandardCoreOnlyProjectName,
            ProjectGuid = UnitTestsNetStandardCoreOnlyProjectGuid,
            ProjectPath = Utils.PathCombineAlt("..", "sdk", "test", "NetStandard", "UnitTests", $"{UnitTestsNetStandardCoreOnlyProjectName}.csproj")
        };

        private static readonly Project ServiceSlnUnitTestsNetStandardCoreOnlyProject = new Project
        {
            Name = UnitTestsNetStandardCoreOnlyProjectName,
            ProjectGuid = UnitTestsNetStandardCoreOnlyProjectGuid,
            ProjectPath = Utils.PathCombineAlt("..", "..", "..", UnitTestsNetStandardCoreOnlyProject.ProjectPath),
            RelativePath = Utils.PathCombineAlt("..", "..", "..", "test", "NetStandard", "UnitTests", $"{UnitTestsNetStandardCoreOnlyProjectName}.csproj")
        };

        private static readonly List<Project> CoreProjects = new List<Project>
        {
            new Project
            {
                Name = "AWSSDK.Core.NetFramework",
                ProjectGuid = "{7DE3AFA0-1B2D-41B1-82BD-120B8B210B43}",
                ProjectPath = Utils.PathCombineAlt("..", "..", "Core", "AWSSDK.Core.NetFramework.csproj")
            },
            new Project
            {
                Name = "AWSSDK.Core.NetStandard",
                ProjectGuid = "{A855B58E-ED32-40AE-AE8F-054F448B9F2C}",
                ProjectPath = Utils.PathCombineAlt("..", "..", "Core", "AWSSDK.Core.NetStandard.csproj")
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
            AddSpecificTestProjects();
            ScanForExistingProjects();

            // Build project configurations for each solution
            var netFrameworkProjectConfigs = new List<ProjectFileConfiguration> { GetProjectConfig(ProjectTypes.NetFramework) };
            var netStandardProjectConfigs = new List<ProjectFileConfiguration>
            {
                GetProjectConfig(ProjectTypes.NetStandard)
            };

            GenerateVS2017ServiceSolution(netFrameworkProjectConfigs);
            GenerateVS2017Solution("AWSSDK.NetFramework.sln", true, false, netFrameworkProjectConfigs);
            GenerateVS2017Solution("AWSSDK.NetStandard.sln", true, false, netStandardProjectConfigs);
        }

        // adds any necessary projects to the collection prior to generating the solution file(s)
        private void AddSupportProjects()
        {
            _allProjects.Add(GeneratorLibProjectName, GeneratorLibProjectConfig);
        }

        private void AddSpecificTestProjects()
        {
            // Add UnitTests.NetStandard.CoreOnly
            var projectConfig = new ProjectFileCreator.ProjectConfigurationData
            {
                ProjectGuid = Utils.GetProjectGuid(UnitTestsNetStandardCoreOnlyProjectGuid),
                ConfigurationPlatforms = StandardPlatformConfigurations
            };

            _allProjects.Add(UnitTestsNetStandardCoreOnlyProjectName, projectConfig);
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
                Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername),
                Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername)
            };

            foreach (var rootFolder in foldersToProcess)
            {
                foreach (var projectFile in Directory.GetFiles(rootFolder, awssdkProjectNamePattern, SearchOption.AllDirectories).OrderBy(f => f))
                {
                    var projectName = Path.GetFileNameWithoutExtension(projectFile);
                    if (_allProjects.ContainsKey(projectName))
                        continue;

                    var projectConfig = new ProjectFileCreator.ProjectConfigurationData
                    {
                        ProjectGuid = Utils.GetProjectGuid(projectFile),
                        ConfigurationPlatforms = StandardPlatformConfigurations
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

        private static string GetProjectType(string projectName)
        {
            var projectTypeStart = projectName.LastIndexOf('.');
            var projectType = projectName.Substring(projectTypeStart + 1);
            return projectType;
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
            IDictionary<string, string> projectGuidDictionary = GetItemGuidDictionary(Utils.PathCombineAlt(Options.SdkRootFolder, solutionFileName));
            string solutionGuid = GetSolutionGuid(Utils.PathCombineAlt(Options.SdkRootFolder, solutionFileName));

            var sdkSourceFolder = Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);
            var session = new Dictionary<string, object>();

            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);            

            var serviceSolutionFolders = new List<ServiceSolutionFolder>();
            var serviceProjectsRoot = Utils.PathCombineAlt(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            var testServiceProjectsRoot = serviceProjectsRoot.Replace("src", "test");
            var services = Directory.GetDirectories(serviceProjectsRoot).OrderBy(d => d).Select(c => new { Path = Utils.ConvertPathAlt(c), IsTestService = false });
            var testServices = Directory.GetDirectories(testServiceProjectsRoot).OrderBy(d => d).Select(c => new { Path = Utils.ConvertPathAlt(c), IsTestService = true });
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
                    string projectFilePattern = $"*.{configuration.Name}.csproj";
                    foreach (var projectFile in Directory.GetFiles(servicePath.Path, projectFilePattern, SearchOption.TopDirectoryOnly).OrderBy(f => f))
                    {
                        if (isTravisSolution && projectFile.Contains("AWSSDK.MobileAnalytics"))
                            continue;

                        string projectName = Path.GetFileNameWithoutExtension(projectFile);
                        folder.Projects.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = servicePath.IsTestService 
                                ? Utils.PathCombineAlt("test", "Services", di.Name, Path.GetFileName(projectFile)) 
                                : Utils.PathCombineAlt("src", "Services" , di.Name, Path.GetFileName(projectFile)),
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                        });
                        SelectProjectAndConfigurationsForSolution(projectFile, buildConfigurations);
                    }
                }

                if (folder.Projects.Count > 0)
                    serviceSolutionFolders.Add(folder);
            }

            IList<Project> coreProjects = new List<Project>();
            var coreProjectsRoot = Utils.PathCombineAlt(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);
            foreach (var configuration in projectFileConfigurations)
            {
                string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                foreach (var projectFile in Directory.GetFiles(coreProjectsRoot, projectFilePattern, SearchOption.TopDirectoryOnly).OrderBy(f => f))
                {
                    string projectName = Path.GetFileNameWithoutExtension(projectFile);
                    coreProjects.Add(new Project
                    {
                        Name = projectName,
                        ProjectPath = Utils.PathCombineAlt("src", "Core", Path.GetFileName(projectFile)),
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                    });
                }

                // Add CborProtocol extension to core projects since it is required by some services.
                var cborExtensionProjectName = string.Format("AWSSDK.Extensions.CborProtocol.{0}", configuration.Name);
                coreProjects.Add(new Project
                {
                    Name = cborExtensionProjectName,
                    ProjectPath = Utils.PathCombineAlt("..", "extensions", "src", "AWSSDK.Extensions.CborProtocol", $"{ cborExtensionProjectName}.csproj"),
                    ProjectGuid = projectGuidDictionary.ContainsKey(cborExtensionProjectName) ? projectGuidDictionary[cborExtensionProjectName] : Guid.NewGuid().ToString("B").ToUpper()
                });
            }

            var testProjects = new List<Project>();
            var integrationTestDependencies = new List<Project>();
            if (includeTests)
            {
                // These projects support all target frameworks so they can be included in all solutions.
                testProjects.Add(CommonTestProject);
                SelectBuildConfigurationsForProject(CommonTestProjectName, buildConfigurations);
                testProjects.Add(UnitTestUtilityProject);
                SelectBuildConfigurationsForProject(UnitTestUtilityProjectFileName, buildConfigurations);

                var testProjectsRoot = Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername);
                foreach (var configuration in projectFileConfigurations)
                {
                    string projectFilePattern = string.Format("*.{0}.csproj", configuration.Name);
                    foreach (var projectFile in Directory.GetFiles(testProjectsRoot, projectFilePattern, SearchOption.AllDirectories)                        
                        .Where(projectFile => (Path.GetFileNameWithoutExtension(projectFile).Contains("UnitTestUtilities") || !Path.GetFileNameWithoutExtension(projectFile).Contains("Utilities")) &&
                        !Path.GetFullPath(projectFile).Contains("Services") &&
                        !Path.GetFullPath(projectFile).Contains("CSM"))
                        .OrderBy(f => f))
                    {
                        var profileFileAlt = Utils.ConvertPathAlt(projectFile);
                        string projectName = Path.GetFileNameWithoutExtension(profileFileAlt);
                        testProjects.Add(new Project
                        {
                            Name = projectName,
                            ProjectPath = CreateRelativePath(Options.SdkRootFolder, profileFileAlt),
                            ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                        });
                    }

                    testProjects.Add(GeneratorLibProject);
                    SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);

                    // We must add the CrtIntegration extension to the target framework-specific solutions (at this point there should only be a single projectFileConfiguration)
                    var platformSpecificCRTName = string.Format("AWSSDK.Extensions.CrtIntegration.{0}", projectFileConfigurations.First().Name);
                    var crtProject = new Project
                    {
                        Name = platformSpecificCRTName,
                        ProjectPath = Utils.PathCombineAlt("..", "extensions", "src", "AWSSDK.Extensions.CrtIntegration", $"{platformSpecificCRTName}.csproj"),
                        ProjectGuid = projectGuidDictionary.ContainsKey(platformSpecificCRTName) ? projectGuidDictionary[platformSpecificCRTName] : Guid.NewGuid().ToString("B").ToUpper()
                    };
                    integrationTestDependencies.Add(crtProject);                    
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
            return path2.Replace(path1, "").TrimStart(new char[] { ' ', '/' });
        }

        /// <summary>
        /// Service specific solution generator. A single sln file is created that contains csproj for all target frameworks and their corresponding integ and unit tests.
        /// </summary>
        private void GenerateVS2017ServiceSolution(IEnumerable<ProjectFileConfiguration> projectFileConfigurations)
        {
            var sdkSourceFolder = Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.SourceSubFoldername);
            var buildConfigurations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            var serviceProjectsRoot = Utils.PathCombineAlt(sdkSourceFolder, GeneratorDriver.ServicesSubFoldername);
            var coreProjectsRoot = Utils.PathCombineAlt(sdkSourceFolder, GeneratorDriver.CoreSubFoldername);

            // Iterating through each service in the service folder
            foreach (var servicePath in Directory.GetDirectories(serviceProjectsRoot).OrderBy(d => d))
            {
                var session = new Dictionary<string, object>();
                var serviceSolutionFolders = new List<ServiceSolutionFolder>();
                var serviceDirectory = new DirectoryInfo(servicePath);
                var serviceFolder = ServiceSolutionFolderFromPath(serviceDirectory.Name);
                var solutionFileName = serviceDirectory.Name + ".sln";
                var serviceProjectDependencies = new List<string>();
                var testProjects = new List<Project>();
                var coreDependenciesProjects = new List<Project>(CoreProjects);
                var dependentProjects = new List<string>();
                var dependentProjectList = new List<Project>();
                var solutionPath = Utils.PathCombineAlt(serviceDirectory.ToString(), solutionFileName);
                // Since vs2017 .csproj files are not identified by guid, see if we can scan and determine the guid ahead of time to reduce changes
                // to .sln files if possible.
                IDictionary<string, string> projectGuidDictionary = GetItemGuidDictionary(solutionPath);

                // Previously, the project GUID was generated from a random array of bytes, but the output for that operation changed in netstandard.
                // To prevent all solution files from being modified, we re-use the GUID for the current service (if there's one available).
                if (projectGuidDictionary.ContainsKey(serviceDirectory.Name))
                {
                    serviceFolder.ProjectGuid = projectGuidDictionary[serviceDirectory.Name];
                }

                // Include only the service csproj files in the service specific solution.
                foreach (var projectFile in Directory.EnumerateFiles(servicePath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.Contains("NetStandard") || s.Contains("NetFramework")).OrderBy(f => f))
                {
                    var projectFileAlt = Utils.ConvertPathAlt(projectFile);
                    serviceProjectDependencies.AddRange(AddProjectDependencies(projectFileAlt, serviceDirectory.Name, new List<string>()));
                    serviceProjectDependencies.Add(projectFileAlt);

                    SelectProjectAndConfigurationsForSolution(projectFileAlt, buildConfigurations);
                }

                // Include service's Unit and Integ csproj files and its dependencies.
                AddTestProjectsAndDependencies(projectFileConfigurations, buildConfigurations, serviceDirectory, projectGuidDictionary, testProjects, dependentProjects);

                // Add AWSSDK.CommonTest.csproj
                testProjects.Add(ServiceSlnCommonTestProject);
                testProjects.Add(ServiceSlnUnitTestsNetStandardCoreOnlyProject);
                SelectBuildConfigurationsForProject(CommonTestProjectName, buildConfigurations);
                SelectBuildConfigurationsForProject(UnitTestsNetStandardCoreOnlyProjectName, buildConfigurations);

                foreach (var serviceProjectDependency in serviceProjectDependencies)
                {
                    string projectName = Path.GetFileNameWithoutExtension(serviceProjectDependency);
                    var filePath = serviceProjectDependency;
                    if (filePath.Contains(serviceDirectory.Name))
                    {
                        filePath = Path.GetFileName(serviceProjectDependency);
                    }
                    var project = new Project
                    {
                        Name = projectName,
                        ProjectPath = filePath,
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper()
                    };

                    if (filePath.Contains("AWSSDK.Extensions.")) // Extensions dependencies are added to the core folder not the service.
                    {
                        coreDependenciesProjects.Add(project);
                    }
                    else
                    {
                        serviceFolder.Projects.Add(project);
                    }
                }

                if (serviceFolder.Projects.Count == 0)
                {
                    continue;
                }

                ConvertToSlnRelativePath(testProjects, solutionPath);

                serviceSolutionFolders.Add(serviceFolder);
                // Adding core projects to service solution
                session["CoreProjects"] = coreDependenciesProjects;
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
        /// ../../../../sdk/test/Services/{ServiceName}/UnitTests/AWSSDK.UnitTests.{ServiceName}.csproj
        /// becomes
        /// ../../../test/Services/{ServiceName}/UnitTests/AWSSDK.UnitTests.{ServiceName}.csproj
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
                testProject.RelativePath = solutionUri.MakeRelativeUri(testProjecturi).ToString();
            }
        }

        /// <summary>
        /// Adding Service test projects and its dependecies
        /// </summary>
        private void AddTestProjectsAndDependencies(IEnumerable<ProjectFileConfiguration> projectFileConfigurations, HashSet<string> buildConfigurations, DirectoryInfo serviceDirectory, 
            IDictionary<string, string> projectGuidDictionary, IList<Project> testProjects, List<string> dependentProjects)
        {
            var testProjectsRoot = Utils.PathCombineAlt(Options.SdkRootFolder, GeneratorDriver.TestsSubFoldername, GeneratorDriver.ServicesSubFoldername, serviceDirectory.Name);
            foreach (var configuration in projectFileConfigurations)
            {
                string filePattern = string.Format($"*.csproj");
                
                foreach (var projectFile in Directory.GetFiles(testProjectsRoot, filePattern, SearchOption.AllDirectories).OrderBy(f => f))
                {
                    var projectFileAlt = Utils.ConvertPathAlt(projectFile);
                    string projectName = Path.GetFileNameWithoutExtension(projectFileAlt);

                    if (GetProjectType(projectName).Equals(ProjectTypes.Partial, StringComparison.Ordinal))
                    {
                        continue;
                    }

                    if (projectName.Contains("Integration") || projectName.Contains("UnitTests"))
                    {
                        dependentProjects.AddRange(AddProjectDependencies
                            (projectFileAlt, serviceDirectory.Name, new List<string>()));
                    }

                    testProjects.Add(new Project
                    {
                        Name = projectName,
                        ProjectPath = projectFileAlt,
                        ProjectGuid = projectGuidDictionary.ContainsKey(projectName) ? projectGuidDictionary[projectName] : Guid.NewGuid().ToString("B").ToUpper(),
                    });
                }

                // The test utilities project uses classes from S3, so we need to add that as a dependency to
                // the other service solutions in order for them to work locally as well.
                testProjects.Add(ServiceSlnUnitTestUtilityProject);
                dependentProjects.AddRange(AddProjectDependencies(
                    ServiceSlnUnitTestUtilityProject.ProjectPath, 
                    serviceDirectory.Name, 
                    new List<string>()
                ));

                if (configuration.Name.Equals(ProjectTypes.NetFramework, StringComparison.Ordinal))
                {
                    testProjects.Add(ServiceSlnGeneratorLibProject);
                    SelectBuildConfigurationsForProject(GeneratorLibProjectName, buildConfigurations);
                    
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
                if (!line.Contains("ProjectReference"))
                {
                    continue;
                }

                var matches = ProjectReferenceRegex.Match(line);
                var fileName = matches.ToString().Replace("\"", "");
                
                // Some references such as Core and the service project itself are added prior to this method being called.
                var alreadyAdded = fileName.Contains("/Core/") || fileName.Contains($".{serviceName}.") || fileName.Contains("Test") || depsProjects.Contains(fileName);
                if (alreadyAdded)
                {
                    continue;
                }

                var split = fileName.Split(Path.AltDirectorySeparatorChar);

                // Extensions are in a different folder in than the usual service dependencies.
                // Also skipping the recursion since these does not currently have any ProjectReferences beyond Core
                if (fileName.Contains("AWSSDK.Extensions."))
                {
                    // Build the relative path to /extensions/src/AWSSDK.Extensions.{ExtensionName}/AWSSDK.Extensions.{ExtensionName}.<target framework>.csproj
                    var deps = Utils.PathCombineAlt("..", "..", "..", "..", split[split.Length - 4], split[split.Length - 3], split[split.Length - 2], split[split.Length - 1]);
                    depsProjects.Add(deps);
                }
                // The test utilities project references the generator as well, but that's already added to the service solutions.
                else if (projectFile.Contains(UnitTestUtilityProjectFileName) && fileName.Contains(GeneratorLibProjectName))
                {
                    continue;
                }
                else
                {
                    // Build the relative path to /<service folder>/AWSSDK.<service>.<target framework>.csproj
                    var deps = Utils.PathCombineAlt("..", split[split.Length - 2], split[split.Length - 1]);
                    depsProjects.Add(deps);
                    AddProjectDependencies(Utils.PathCombineAlt(Options.SdkRootFolder, "src", "Services", split[split.Length - 2], split[split.Length - 1]), split[split.Length - 2], depsProjects);
                }
            }
            return depsProjects;
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
