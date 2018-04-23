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
                string projectName;
                if (_isLegacyProj)
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.csproj", configuration.Name);
                }
                else
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.{1}.csproj", _serviceName, configuration.Name);
                }
                    
                string projectGuid = Utils.GetProjectGuid(Path.Combine(unitTestRoot, projectName));
                IList<ProjectFileCreator.ProjectReference> commonReferences;
                IList<ProjectFileCreator.ProjectReference> serviceProjectReferences;
                IList<ProjectFileCreator.Reference> dllProjectReferences;

                if (useDllReference)
                {
                    if (_isLegacyProj)
                    {
                        projectName = string.Format("Build.UnitTests.{0}.partial.csproj", configuration.Name);
                    }
                    else
                    {
                        projectName = string.Format("Build.UnitTests.{0}.{1}.partial.csproj", _serviceName, configuration.Name);
                    }
                    serviceProjectReferences = null;
                    dllProjectReferences = ServiceDllReferences(unitTestRoot, serviceConfigurations, configuration.Name);

                }
                else
                {
                    serviceProjectReferences = ServiceProjectReferences(unitTestRoot, serviceConfigurations, configuration.Name);
                    dllProjectReferences = null;
                }
                commonReferences = GetCommonReferences(unitTestRoot, configuration.Name, useDllReference);

                var session = new Dictionary<string, object>
                {
                    {"TargetFramework",         configuration.TargetFrameworkVersion },
                    {"DefineConstants",         "DEBUG;" + configuration.CompilationConstants},
                    {"Reference",               configuration.FrameworkReferences},
                    {"CompileRemoveList",       configuration.PlatformExcludeFolders},
                    {"Services",                configuration.VisualStudioServices},
                    {"ReferencePath",           configuration.ReferencePath},
                    {"FrameworkPathOverride",   configuration.FrameworkPathOverride },
                    {"FrameworkReferences",     configuration.FrameworkReferences },
                    {"PackageReferenceList",    configuration.PackageReferences },
                    {"NoWarn",                  configuration.NoWarn},
                    {"OutputPathOverride",      configuration.OutputPathOverride },
                    {"SignBinaries",            false},
                    {"ConfigurationName",       configuration.Name}
                };
                if (_isLegacyProj)
                {
                    session["AssemblyName"] = string.Format("AWSSDK.UnitTests.{0}", configuration.Name);
                    session["ExternalFilesInclude"] = "../Services/*/UnitTests/Custom/*.cs";
                    session["EmbeddedResources"] = configuration.EmbeddedResources;
                    session["SetBaseIntermediateOutputPath"] = false;
                }
                else
                {
                    session["AssemblyName"] = string.Format("AWSSDK.UnitTests.{0}.{1}", _serviceName, configuration.Name);
                    //Check for embedded resources
                    var embeddedResourcePath = Path.Combine(unitTestRoot, "Custom", "EmbeddedResource");
                    if (Directory.Exists(embeddedResourcePath))
                    {
                        session["EmbeddedResources"] = new List<string> { Path.Combine("Custom", "EmbeddedResource", "*") };
                    }
                    session["SetBaseIntermediateOutputPath"] = true;
                }

                if (useDllReference) session.Add("ServiceDllReferences", dllProjectReferences);
                if (serviceProjectReferences != null)
                {
                    session["ProjectReferenceList"] = commonReferences.Concat(serviceProjectReferences).ToList();
                }
                else
                {
                    session["ProjectReferenceList"] = commonReferences;
                }

                GenerateProjectFile(session, unitTestRoot, projectName);
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
            else
            {
                // if adding all serices as dll reference, add core dll as a dll reference in ServiceDllReferences()
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
                projectName = "AWSSDK.UnitTestUtilities";
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

        private IList<ProjectFileCreator.Reference> ServiceDllReferences(string unitTestRoot,
                                                                                    IEnumerable<ServiceConfiguration> serviceConfigurations,
                                                                                    string projectType)
        {
            HashSet<string> nameSet = new HashSet<string>();
            List<ProjectFileCreator.Reference> references = new List<ProjectFileCreator.Reference>();

            // Technically not a service dll, but we can add it here to avoid recompiling core dll.
            string coreAssemblyTitle = "AWSSDK.Core";
            references.Add(new ProjectFileCreator.Reference
            {
                Name = coreAssemblyTitle,
                HintPath = Path.Combine(@"..\..\..\Deployment\assemblies", projectType.ToLower(), coreAssemblyTitle + ".dll")
            });

            foreach (var configuration in serviceConfigurations)
            {
                if (nameSet.Contains(configuration.AssemblyTitle))
                {
                    // ServiceConfiguration list contains two entries for DynamoDBv2 and DynamoDBStreams
                    // which resolve to the same dll.
                    continue;
                }

                references.Add(new ProjectFileCreator.Reference
                {
                    Name = configuration.AssemblyTitle,
                    HintPath = Path.Combine(@"..\..\..\Deployment\assemblies", projectType.ToLower(), configuration.AssemblyTitle + ".dll")
                });

                nameSet.Add(configuration.AssemblyTitle);
            }

            references.Sort();
            return references;
        }

        private void GenerateProjectFile(IDictionary<string, object> session,
                                            string unitTestProjectRoot,
                                            string projectFilename)
        {
            var projectName = Path.GetFileNameWithoutExtension(projectFilename);
            string generatedContent = null;
            try
            {
                var projectTemplateType = Type.GetType(
                    "ServiceClientGenerator.Generators.ProjectFiles." +
                    TemplateName);
                dynamic generator = Activator.CreateInstance(projectTemplateType);
                generator.Session = session;
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
