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
        private readonly string TemplateName = "UnitTestProjectFile";

        private GeneratorOptions _options;
        private IEnumerable<UnitTestProjectConfiguration> _configurations;

        public UnitTestProjectFileCreator(GeneratorOptions options, IEnumerable<UnitTestProjectConfiguration> configurations)
        {
            _options = options;
            _configurations = configurations;
        }
        public void Execute(string unitTestRoot, IEnumerable<ServiceConfiguration> serviceConfigurations, bool useDllReference)
        {
            foreach (var configuration in _configurations)
            {
                string projectName = string.Format("AWSSDK.UnitTests.{0}.csproj", configuration.Name);
                string projectGuid = Utils.GetProjectGuid(Path.Combine(unitTestRoot, projectName));
                IList<ProjectFileCreator.ProjectReference> commonReferences;
                IList<ProjectFileCreator.ProjectReference> serviceProjectReferences;
                IList<ProjectFileCreator.Reference> dllProjectReferences;

                if (useDllReference)
                {
                    projectName = string.Format("AWSSDK.UnitTests.{0}.partial.csproj", configuration.Name);
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
                    {"ProjectGuid",             projectGuid},
                    {"RootNamespace",           string.Format("AWSSDK_Dot{0}.UnitTests", configuration.Name)},
                    {"AssemblyName",            string.Format("AWSSDK.UnitTests.{0}", configuration.Name)},
                    {"DebugOutputPath",         string.Format(@"bin\Debug\{0}", configuration.Name.ToLower())},
                    {"ReleaseOutputPath",       string.Format(@"bin\Release\{0}", configuration.Name.ToLower())},
                    {"ReleaseDefineConstants",  configuration.DefineConstants},
                    {"DebugDefineConstants",    "DEBUG;" + configuration.DefineConstants},
                    {"Reference",               configuration.References},
                    {"CompileInclude",          configuration.CompileInclude},
                    {"CommonReferences",        commonReferences},
                    {"ServiceProjectReferences",serviceProjectReferences},
                    {"ServiceDllReferences",    dllProjectReferences},
                };

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
                string coreProjectPath = Path.Combine(unitTestRoot, coreIncludePath);

                references.Add(new ProjectFileCreator.ProjectReference
                {
                    Name = coreProjectName,
                    IncludePath = coreIncludePath,
                    ProjectGuid = Utils.GetProjectGuid(coreProjectPath)
                });
            }
            else
            {
                // if adding all serices as dll refernece, add core dll as a dll reference in ServiceDllReferences()
            }

            //
            // CommonTest project reference
            //
            string commonTestProjectName = string.Format("AWSSDK.CommonTest.{0}", projectType);
            string commonTestIncludePath = Path.Combine("..", "Common", commonTestProjectName + ".csproj");
            string commonTestPath = Path.Combine(unitTestRoot, commonTestIncludePath);

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = commonTestProjectName,
                IncludePath = commonTestIncludePath,
                ProjectGuid = Utils.GetProjectGuid(commonTestPath)
            });

            return references;
        }

        private IList<ProjectFileCreator.ProjectReference> ServiceProjectReferences(string unitTestRoot,
                                                                                    IEnumerable<ServiceConfiguration> serviceConfigurations,
                                                                                    string projectType)
        {
            HashSet<string> guidSet = new HashSet<string>();
            List<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            foreach(var configuration in serviceConfigurations)
            {
                string projectName = string.Format("{0}.{1}", configuration.AssemblyTitle, projectType);
                string includePath = Path.Combine("..", "..", "src", "Services", configuration.ServiceFolderName, projectName + ".csproj");
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

        private void GenerateProjectFile(   IDictionary<string, object> session,
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
