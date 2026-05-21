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

                var projectTypes = configuration.TargetFrameworkProjectTypes;
                if (_isLegacyProj)
                {
                    // Uber projects: emit one csproj per project type group (e.g. AWSSDK.UnitTests.NetFramework.csproj, AWSSDK.UnitTests.NetStandard.csproj).
                    // Each uber solution includes only the matching project.
                    foreach (var group in projectTypes.GroupBy(kvp => kvp.Value))
                    {
                        var groupTfms = group.Select(kvp => kvp.Key).ToList();
                        var groupProjectType = group.Key;
                        var excludeFolder = groupProjectType == "NetFramework" ? "_netstandard" : "_bcl";
             
                        var excludeFolders = configuration.PlatformExcludeFolders.Concat(new[] { excludeFolder }).ToList();

                        // MobileAnalytics only supports .NET Framework; exclude its test files from the NetStandard uber project.
                        if (groupProjectType == "NetStandard")
                        {
                            excludeFolders.Add(Utils.PathCombineAlt("..", "Services", "MobileAnalytics", "UnitTests", "**", "*.cs"));
                        }

                        projectName = $"AWSSDK.UnitTests.{groupProjectType}.csproj";
                        serviceProjectReferences = new List<ProjectFileCreator.ProjectReference>
                        {
                            new ProjectFileCreator.ProjectReference
                            {
                                IncludePath = Utils.PathCombineAlt("..", "..", "src", "Services", "*", $"*.{groupProjectType}.csproj")
                            },
                            new ProjectFileCreator.ProjectReference
                            {
                                IncludePath = Utils.PathCombineAlt("..", "..", "test", "Services", "*", $"*.{groupProjectType}.csproj")
                            }
                        };

                        projectReferences = GetCommonReferences(unitTestRoot, useDllReference, groupProjectType);
                        foreach (var r in serviceProjectReferences) projectReferences.Add(r);

                        var projectProperties = new Project
                        {
                            AssemblyName           = $"AWSSDK.UnitTests.{groupProjectType}",
                            TargetFrameworks       = groupTfms,
                            DefineConstants        = configuration.CompilationConstants,
                            ReferenceDependencies  = configuration.DllReferences,
                            CompileRemoveList      = excludeFolders,
                            Services               = configuration.VisualStudioServices,
                            FrameworkPathOverride  = configuration.FrameworkPathOverride,
                            PackageReferences      = configuration.PackageReferences,
                            SupressWarnings        = configuration.NoWarn,
                            OutputPathOverride     = configuration.OutputPathOverride,
                            SignBinaries           = true,
                            KeyFilePath            = Utils.PathCombineAlt("..", "..", "awssdk.dll.snk"),
                            IndividualFileIncludes = new List<string> { Utils.PathCombineAlt("..", "Services", "*", "UnitTests", "**", "*.cs") },
                            EmbeddedResources      = configuration.EmbeddedResources,
                            FxcopAnalyzerRuleSetFilePath = Utils.PathCombineAlt("..", "..", "AWSDotNetSDK.ruleset"),
                            FxcopAnalyzerRuleSetFilePathForBuild = Utils.PathCombineAlt("..", "..", "AWSDotNetSDKForBuild.ruleset"),
                            ProjectReferences      = projectReferences
                        };

                        GenerateProjectFile(projectProperties, unitTestRoot, projectName);
                    }
                }
                else
                {
                    // MobileAnalytics only supports .NET Framework, so restrict its TFMs to net472 only.
                    bool netFrameworkOnly = _serviceName == "MobileAnalytics";
                    var effectiveProjectTypes = netFrameworkOnly
                        ? projectTypes.Where(kvp => kvp.Value == "NetFramework").ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                        : projectTypes.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    var effectiveTargetFrameworks = netFrameworkOnly ? effectiveProjectTypes.Keys.ToList() : configuration.TargetFrameworkVersions;

                    // Per-service projects: single multi-target csproj with conditional references.
                    projectName = $"AWSSDK.UnitTests.{_serviceName}.csproj";
                    serviceProjectReferences = new List<ProjectFileCreator.ProjectReference>();

                    foreach (var group in effectiveProjectTypes.GroupBy(kvp => kvp.Value))
                    {
                        string condition = BuildCondition(group.Select(kvp => kvp.Key).ToList(), effectiveProjectTypes);
                        var refs = ServiceProjectReferences(unitTestRoot, serviceConfigurations, group.Key);
                        foreach (var r in refs) 
                        { 
                            r.Condition = condition; 
                        }

                        foreach (var r in refs)
                        {
                            serviceProjectReferences.Add(r);
                        }
                    }

                    string projectGuid = Utils.GetProjectGuid(Utils.PathCombineAlt(unitTestRoot, projectName));
                    projectReferences = GetCommonReferences(unitTestRoot, useDllReference, configuration);

                    var conditionalExcludes = new Dictionary<string, List<string>>();
                    foreach (var group in effectiveProjectTypes.GroupBy(kvp => kvp.Value))
                    {
                        string condition = BuildCondition(group.Select(kvp => kvp.Key).ToList(), effectiveProjectTypes);
                        var excludeFolder = group.Key == "NetFramework" ? "_netstandard" : "_bcl";
                        conditionalExcludes[condition] = new List<string> { excludeFolder };
                    }

                    var projectProperties = new Project
                    {
                        AssemblyName           = $"AWSSDK.UnitTests.{_serviceName}",
                        TargetFrameworks       = effectiveTargetFrameworks,
                        DefineConstants        = configuration.CompilationConstants,
                        ReferenceDependencies  = configuration.DllReferences,
                        CompileRemoveList      = configuration.PlatformExcludeFolders,
                        ConditionalCompileRemoves = conditionalExcludes,
                        Services               = configuration.VisualStudioServices,
                        FrameworkPathOverride  = configuration.FrameworkPathOverride,
                        PackageReferences      = configuration.PackageReferences,
                        SupressWarnings        = configuration.NoWarn,
                        OutputPathOverride     = configuration.OutputPathOverride,
                        SignBinaries           = true,
                        KeyFilePath            = Utils.PathCombineAlt("..", "..", "..", "..", "awssdk.dll.snk"),
                        FxcopAnalyzerRuleSetFilePath = Utils.PathCombineAlt("..", "..", "..", "..", "AWSDotNetSDK.ruleset"),
                        FxcopAnalyzerRuleSetFilePathForBuild = Utils.PathCombineAlt("..", "..", "..", "..", "AWSDotNetSDKForBuild.ruleset"),
                        ProjectReferences      = projectReferences
                    };

                    var embeddedResourcePath = Utils.PathCombineAlt(unitTestRoot, "Custom", "EmbeddedResource");
                    if (Directory.Exists(embeddedResourcePath))
                    {
                        projectProperties.EmbeddedResources = new List<string> { Utils.PathCombineAlt("Custom", "EmbeddedResource", "*") };
                    }

                    foreach (var r in serviceProjectReferences)
                    {
                        projectReferences.Add(r);
                    }

                    GenerateProjectFile(projectProperties, unitTestRoot, projectName);
                }
            }
        }

        /// <summary>
        /// Builds an MSBuild condition expression for a group of TFMs that share the same project type.
        /// If the group is the minority, uses equality checks; otherwise uses inequality against the other group.
        /// </summary>
        private static string BuildCondition(List<string> tfmsInGroup, IReadOnlyDictionary<string, string> allMappings)
        {
            var otherTfms = allMappings.Keys.Where(t => !tfmsInGroup.Contains(t)).ToList();

            // Use whichever produces a simpler condition
            if (tfmsInGroup.Count <= otherTfms.Count)
            {
                if (tfmsInGroup.Count == 1)
                {
                    return $"'$(TargetFramework)' == '{tfmsInGroup[0]}'";
                }

                return string.Join(" Or ", tfmsInGroup.Select(t => $"'$(TargetFramework)' == '{t}'"));
            }
            else
            {
                if (otherTfms.Count == 1)
                {
                    return $"'$(TargetFramework)' != '{otherTfms[0]}'";
                }

                return string.Join(" And ", otherTfms.Select(t => $"'$(TargetFramework)' != '{t}'"));
            }
        }

        private IList<ProjectFileCreator.ProjectReference> GetCommonReferences(string unitTestRoot, bool useDllReference, string projectType)
        {
            IList<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            if (!useDllReference)
            {
                references.Add(CreateCoreReference(projectType, null));
            }

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = "AWSSDK.CommonTest",
                IncludePath = Utils.PathCombineAlt("..", "Common", "AWSSDK.CommonTest.csproj")
            });

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = "ServiceClientGeneratorLib",
                IncludePath = Utils.PathCombineAlt("..", "..", "..", "generator", "ServiceClientGeneratorLib", "ServiceClientGeneratorLib.csproj")
            });

            references.Add(CreateCrtReference(projectType, null));

            return references;
        }

        private IList<ProjectFileCreator.ProjectReference> GetCommonReferences(string unitTestRoot, bool useDllReference, ProjectFileConfiguration configuration)
        {
            IList<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            var projectTypes = configuration.TargetFrameworkProjectTypes;

            if (!useDllReference)
            {
                foreach (var group in projectTypes.GroupBy(kvp => kvp.Value))
                {
                    string condition = BuildCondition(group.Select(kvp => kvp.Key).ToList(), projectTypes);
                    references.Add(CreateCoreReference(group.Key, condition));
                }
            }

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = "AWSSDK.CommonTest",
                IncludePath = Utils.PathCombineAlt("..", "..", "..", "Common", "AWSSDK.CommonTest.csproj")
            });

            references.Add(new ProjectFileCreator.ProjectReference
            {
                Name = "AWSSDK.UnitTestUtilities",
                IncludePath = Utils.PathCombineAlt("..", "..", "..", "UnitTests", "Custom", "AWSSDK.UnitTestUtilities.csproj")
            });

            foreach (var group in projectTypes.GroupBy(kvp => kvp.Value))
            {
                string condition = BuildCondition(group.Select(kvp => kvp.Key).ToList(), projectTypes);
                references.Add(CreateCrtReference(group.Key, condition));
            }

            return references;
        }

        private ProjectFileCreator.ProjectReference CreateCoreReference(string projectType, string condition)
        {
            string coreProjectName = $"AWSSDK.Core.{projectType}";
            string coreIncludePath = Utils.PathCombineAlt("..", "..", "src", "Core", coreProjectName + ".csproj");
            if (!_isLegacyProj)
            {
                coreIncludePath = Utils.PathCombineAlt("..", "..", coreIncludePath);
            }

            return new ProjectFileCreator.ProjectReference
            {
                Name = coreProjectName,
                IncludePath = coreIncludePath,
                Condition = condition
            };
        }

        private ProjectFileCreator.ProjectReference CreateCrtReference(string projectType, string condition)
        {
            var crtExtension = new ProjectFileCreator.ProjectReference
            {
                Name = $"AWSSDK.Extensions.CrtIntegration.{projectType}",
                Condition = condition
            };
            if (_isLegacyProj)
            {
                crtExtension.IncludePath = Utils.PathCombineAlt(new string[] { "..", "..", "..", "extensions", "src",
                    "AWSSDK.Extensions.CrtIntegration", $"AWSSDK.Extensions.CrtIntegration.{projectType}.csproj" });
            }
            else
            {
                crtExtension.IncludePath = Utils.PathCombineAlt(new string[] {"..", "..", "..", "..", "..", "extensions", "src",
                    "AWSSDK.Extensions.CrtIntegration", $"AWSSDK.Extensions.CrtIntegration.{projectType}.csproj"});
            }
            return crtExtension;
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
