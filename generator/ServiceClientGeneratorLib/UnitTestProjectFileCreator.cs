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
                IList<ProjectFileCreator.ProjectReference> commonReferences;
                IList<ProjectFileCreator.ProjectReference> serviceProjectReferences;
                string projectName;
                if (_isLegacyProj)
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.csproj", configuration.Name);
                    serviceProjectReferences = new List<ProjectFileCreator.ProjectReference>()
                    {
                        new ProjectFileCreator.ProjectReference
                        {
                            IncludePath = $@"..\..\src\Services\*\*.{configuration.Name}.csproj"
                        }
                    };
                }
                else
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.{1}.csproj", _serviceName, configuration.Name);
                    serviceProjectReferences = ServiceProjectReferences(unitTestRoot, serviceConfigurations, configuration.Name);
                }
                    
                string projectGuid = Utils.GetProjectGuid(Path.Combine(unitTestRoot, projectName));

                commonReferences = GetCommonReferences(unitTestRoot, configuration.Name, useDllReference);

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
                    projectProperties.IndividualFileIncludes = new List<string> { "../Services/*/UnitTests/**/*.cs" };
                    projectProperties.EmbeddedResources = configuration.EmbeddedResources;
                }
                else
                {
                    projectProperties.AssemblyName = string.Format("AWSSDK.UnitTests.{0}.{1}", _serviceName, configuration.Name);
                    //Check for embedded resources
                    var embeddedResourcePath = Path.Combine(unitTestRoot, "Custom", "EmbeddedResource");
                    if (Directory.Exists(embeddedResourcePath))
                    {
                        projectProperties.EmbeddedResources = new List<string> { Path.Combine("Custom", "EmbeddedResource", "*") };
                    }
                }
                                
                if (serviceProjectReferences != null)
                {
                    projectProperties.ProjectReferences = commonReferences.Concat(serviceProjectReferences).ToList();
                }
                else
                {
                    projectProperties.ProjectReferences = commonReferences;
                }

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
                string coreProjectName = string.Format("AWSSDK.Core.{0}", projectType);
                string coreIncludePath = Path.Combine("..", "..", "src", "Core", coreProjectName + ".csproj");
                if (!_isLegacyProj)
                {
                    coreIncludePath = Path.Combine("..", "..", coreIncludePath);
                }
                string coreProjectPath = Path.Combine(unitTestRoot, coreIncludePath);

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
            string commonTestIncludePath = Path.Combine("..", "Common", commonTestProjectName + ".csproj");
            if (!_isLegacyProj)
            {
                commonTestIncludePath = Path.Combine("..", "..", commonTestIncludePath);
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
                projectPath = string.Format("..\\..\\..\\generator\\ServiceClientGeneratorLib\\{0}.csproj", projectName);
            }
            else
            {
                projectName = $"AWSSDK.UnitTestUtilities.{projectType}";
                projectPath = Path.Combine("..", "..", "..", "UnitTests", "Custom", projectName + ".csproj");
            }

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = projectName,
                IncludePath = projectPath
            });
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
                string projectName = string.Format("{0}.{1}", configuration.AssemblyTitle, projectType);
                string includePath = Path.Combine("..", "..", "src", "Services", configuration.ServiceFolderName, projectName + ".csproj");
                if (!_isLegacyProj)
                {
                    includePath = Path.Combine("..", "..", includePath);
                }
                string guid = Utils.GetProjectGuid(Path.Combine(unitTestRoot, includePath));

                if (guidSet.Contains(guid))
                {
                    // ServiceConfiguration list contains two entries for DynamoDBv2 and DynamoDBStreams
                    // which resolve to the same project.
                    continue;
                }

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
            catch (Exception e)
            {
                throw new ArgumentException("Project template name "
                    + TemplateName + " is not recognized");
            }

            GeneratorDriver.WriteFile(unitTestProjectRoot, string.Empty, projectFilename, generatedContent);
        }
    }
}
