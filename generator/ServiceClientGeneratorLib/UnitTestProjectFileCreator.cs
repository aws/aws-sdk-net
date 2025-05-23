using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    class UnitTestProjectFileCreator
    {
        private readonly string TemplateName = "VS2017ProjectFile";

        private GeneratorOptions _options;
        private IEnumerable<ProjectFileConfiguration> _configurations;
        private string _serviceName;
        private bool _isLegacyProj;

        public UnitTestProjectFileCreator(GeneratorOptions options, IEnumerable<ProjectFileConfiguration> configurations)
        {
            _options = options;
            _configurations = configurations;
            _isLegacyProj = true;
        }
        public UnitTestProjectFileCreator(GeneratorOptions options, IEnumerable<ProjectFileConfiguration> configurations, string serviceName)
        {
            _options = options;
            _configurations = configurations;
            _serviceName = serviceName;
            _isLegacyProj = false;
        }

        public void Execute(string unitTestRoot, IEnumerable<ServiceConfiguration> serviceConfigurations, bool useDllReference)
        {
            foreach (var configuration in _configurations)
            {
                IList<ProjectFileCreator.ProjectReference> projectReferences;
                IList<ProjectFileCreator.ProjectReference> serviceProjectReferences;
                string projectName;
                if (_isLegacyProj)
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.csproj", configuration.Name);
                    serviceProjectReferences = new List<ProjectFileCreator.ProjectReference>()
                    {
                        new ProjectFileCreator.ProjectReference
                        {
                            IncludePath = Utils.PathCombineAlt("..", "..", "src", "Services", "*", $"*.{configuration.Name}.csproj")
                        },
                        new ProjectFileCreator.ProjectReference
                        {
                            IncludePath = Utils.PathCombineAlt("..", "..", "test", "Services", "*", $"*.{configuration.Name}.csproj")
                        }
                    };
                }
                else
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.{1}.csproj", _serviceName, configuration.Name);
                    serviceProjectReferences = ServiceProjectReferences(unitTestRoot, serviceConfigurations, configuration.Name);
                }
                    
                string projectGuid = Utils.GetProjectGuid(Utils.PathCombineAlt(unitTestRoot, projectName));

                projectReferences = GetCommonReferences(unitTestRoot, configuration.Name, useDllReference);

                var projectProperties = new Project()
                {
                    TargetFrameworks       = configuration.TargetFrameworkVersions,
                    DefineConstants        = configuration.CompilationConstants.Concat(new string[] { "DEBUG" }).ToList(),
                    ReferenceDependencies  = configuration.DllReferences,
                    CompileRemoveList      = configuration.PlatformExcludeFolders,
                    Services               = configuration.VisualStudioServices,
                    FrameworkPathOverride  = configuration.FrameworkPathOverride,
                    PackageReferences      = configuration.PackageReferences,
                    SupressWarnings        = configuration.NoWarn,
                    OutputPathOverride     = configuration.OutputPathOverride,
                    SignBinaries           = false
                };
                if (_isLegacyProj)
                {
                    projectProperties.AssemblyName = string.Format("AWSSDK.UnitTests.{0}", configuration.Name);
                    projectProperties.IndividualFileIncludes = new List<string> { Utils.PathCombineAlt("..", "Services", "*", "UnitTests", "**", "*.cs") };
                    projectProperties.EmbeddedResources = configuration.EmbeddedResources;
                    projectProperties.FxcopAnalyzerRuleSetFilePath = Utils.PathCombineAlt("..", "..", "AWSDotNetSDK.ruleset");
                    projectProperties.FxcopAnalyzerRuleSetFilePathForBuild = Utils.PathCombineAlt("..", "..", "AWSDotNetSDKForBuild.ruleset");
                    projectProperties.SignBinaries = true;

                }
                else
                {
                    projectProperties.AssemblyName = $"AWSSDK.UnitTests.{_serviceName}.{configuration.Name}";
                    //Check for embedded resources
                    var embeddedResourcePath = Utils.PathCombineAlt(unitTestRoot, "Custom", "EmbeddedResource");
                    if (Directory.Exists(embeddedResourcePath))
                    {
                        projectProperties.EmbeddedResources = new List<string> { Utils.PathCombineAlt("Custom", "EmbeddedResource", "*") };
                    }
                    projectProperties.FxcopAnalyzerRuleSetFilePath = Utils.PathCombineAlt("..", "..", "..", "..", "AWSDotNetSDK.ruleset");
                    projectProperties.FxcopAnalyzerRuleSetFilePathForBuild = Utils.PathCombineAlt("..", "..", "..", "..", "AWSDotNetSDKForBuild.ruleset");
                    projectProperties.SignBinaries = true;
                    
                }

                if (serviceProjectReferences != null)
                {
                    Array.ForEach(serviceProjectReferences.ToArray(), x => projectReferences.Add(x));
                }

                projectProperties.ProjectReferences = projectReferences;
                GenerateProjectFile(projectProperties, unitTestRoot, projectName);
            }
        }

        private IList<ProjectFileCreator.ProjectReference> GetCommonReferences(string unitTestRoot, string projectType, bool useDllReference)
        {
            IList<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            //
            // Core project reference
            //
            if (!useDllReference)
            {
                string coreProjectName = $"AWSSDK.Core.{projectType}";
                string coreIncludePath = Utils.PathCombineAlt("..", "..", "src", "Core", coreProjectName + ".csproj");
                if (!_isLegacyProj)
                {
                    coreIncludePath = Utils.PathCombineAlt("..", "..", coreIncludePath);
                }

                references.Add(new ProjectFileCreator.ProjectReference
                {
                    Name = coreProjectName,
                    IncludePath = coreIncludePath
                });
            }
            
            //
            // CommonTest project reference
            //
            string commonTestProjectName = "AWSSDK.CommonTest";
            string commonTestIncludePath = Utils.PathCombineAlt("..", "Common", commonTestProjectName + ".csproj");
            if (!_isLegacyProj)
            {
                commonTestIncludePath = Utils.PathCombineAlt("..", "..", commonTestIncludePath);
            }

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = commonTestProjectName,
                IncludePath = commonTestIncludePath
            });

            string projectName, projectPath;

            if (_isLegacyProj)
            {
                projectName = "ServiceClientGeneratorLib";
                projectPath = Utils.PathCombineAlt("..", "..", "..",  "generator", "ServiceClientGeneratorLib", $"{projectName}.csproj");
            }
            else
            {
                projectName = $"AWSSDK.UnitTestUtilities.{projectType}";
                projectPath = Utils.PathCombineAlt("..", "..", "..", "UnitTests", "Custom", $"{projectName}.csproj");
            }

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = projectName,
                IncludePath = projectPath
            });

            // Add reference to CRT extension to all unit test projects now
            // that any service can start using flexible checksums
            var crtExtension = new ProjectFileCreator.ProjectReference
            {
                Name = $"AWSSDK.Extensions.CrtIntegration.{projectType}"
            };
            if (_isLegacyProj) // unit test projects with all services, which need CRT also but have a different relative path
            {
                crtExtension.IncludePath = Utils.PathCombineAlt(new string[] { "..", "..", "..", "extensions", "src",
                    "AWSSDK.Extensions.CrtIntegration", $"AWSSDK.Extensions.CrtIntegration.{projectType}.csproj" });
            }
            else // service-specific project
            {
                crtExtension.IncludePath = Utils.PathCombineAlt(new string[] {"..", "..", "..", "..", "..", "extensions", "src",
                    "AWSSDK.Extensions.CrtIntegration", $"AWSSDK.Extensions.CrtIntegration.{projectType}.csproj"});
            }
            references.Add(crtExtension);

            return references;
        }

        private IList<ProjectFileCreator.ProjectReference> ServiceProjectReferences(string unitTestRoot,
                                                                                    IEnumerable<ServiceConfiguration> serviceConfigurations,
                                                                                    string projectType)
        {
            HashSet<string> guidSet = new HashSet<string>();
            List<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            foreach (var configuration in serviceConfigurations)
            {
                string projectName = $"{configuration.AssemblyTitle}.{projectType}";
                string includePath = Utils.PathCombineAlt("..", "..", "src", "Services", configuration.ServiceFolderName, $"{projectName}.csproj");

                if (!_isLegacyProj)
                {
                    includePath = Utils.PathCombineAlt("..", "..", includePath);
                }

                // for test service unit tests project the actual service is generated one level up the tree
                if (configuration.IsTestService)
                {
                    includePath = Utils.PathCombineAlt("..", $"{projectName}.csproj");
                }

                string guid = Utils.GetProjectGuid(Utils.PathCombineAlt(unitTestRoot, includePath));

                references.Add(new ProjectFileCreator.ProjectReference
                {
                    Name = projectName,
                    IncludePath = includePath,
                    ProjectGuid = guid
                });

                guidSet.Add(guid);
            }

            references.Sort();
            return references;
        }

        private void GenerateProjectFile(Project projectProperties, string unitTestProjectRoot, string projectFilename)
        {
            var projectName = Path.GetFileNameWithoutExtension(projectFilename);
            string generatedContent = null;
            try
            {
                var projectTemplateType = Type.GetType(
                    "ServiceClientGenerator.Generators.ProjectFiles." +
                    TemplateName);
                dynamic generator = Activator.CreateInstance(projectTemplateType);
                generator.Project = projectProperties;
                generatedContent = generator.TransformText();
            }
            catch (Exception)
            {
                throw new ArgumentException("Project template name "
                    + TemplateName + " is not recognized");
            }

            GeneratorDriver.WriteFile(unitTestProjectRoot, string.Empty, projectFilename, generatedContent);
        }
    }
}
