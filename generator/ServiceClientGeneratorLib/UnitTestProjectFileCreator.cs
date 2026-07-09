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

        // The project-type variants that exist for Core/CRT/service references. A unit-test project
        // references the .NETFramework variant on .NET Framework targets and the NetStandard variant on
        // all other targets; the concrete target frameworks themselves come from the Sdk*Targets
        // properties in sdk/Directory.Build.props, not from this generator.
        private const string NetFrameworkProjectType = "NetFramework";
        private const string NetStandardProjectType = "NetStandard";
        private static readonly string[] ProjectTypes = { NetFrameworkProjectType, NetStandardProjectType };

        /// <summary>
        /// The MSBuild condition selecting the target frameworks that use the given project-type variant.
        /// Uses a framework-identifier comparison so it adapts to any TFM change without hardcoding names:
        /// the NetFramework variant applies to .NET Framework targets, the NetStandard variant to all others.
        /// </summary>
        private static string ConditionForProjectType(string projectType)
        {
            var op = projectType == NetFrameworkProjectType ? "==" : "!=";
            return $"$([MSBuild]::GetTargetFrameworkIdentifier('$(TargetFramework)')) {op} '.NETFramework'";
        }

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
                    // Uber projects: emit one csproj per project type (e.g. AWSSDK.UnitTests.NetFramework.csproj,
                    // AWSSDK.UnitTests.NetStandard.csproj). Each uber solution includes only the matching project.
                    foreach (var groupProjectType in ProjectTypes)
                    {
                        var excludeFolder = groupProjectType == NetFrameworkProjectType ? "_netstandard" : "_bcl";

                        var excludeFolders = configuration.PlatformExcludeFolders.Concat(new[] { excludeFolder }).ToList();

                        // MobileAnalytics only supports .NET Framework; exclude its test files from the NetStandard uber project.
                        if (groupProjectType == NetStandardProjectType)
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
                            TargetFrameworksProperty = UberTestTargetsProperty(groupProjectType),
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
                    // Per-service unit test projects multi-target the MSTest test frameworks (net472 plus the
                    // NetStandard-variant targets). Which project-type variant is referenced on which target is
                    // expressed with framework-identifier conditions, so no concrete TFM names are needed here.
                    // MobileAnalytics only supports .NET Framework, so it targets net472 only.
                    bool netFrameworkOnly = _serviceName == "MobileAnalytics";
                    var effectiveProjectTypes = netFrameworkOnly
                        ? new[] { NetFrameworkProjectType }
                        : ProjectTypes;

                    var targetFrameworksProperty = netFrameworkOnly
                        ? TargetFrameworkProperties.NetFrameworkProperty
                        : TargetFrameworkProperties.MSTestAllProperty;

                    // Per-service projects: single multi-target csproj with conditional references.
                    projectName = $"AWSSDK.UnitTests.{_serviceName}.csproj";
                    serviceProjectReferences = new List<ProjectFileCreator.ProjectReference>();

                    foreach (var groupProjectType in effectiveProjectTypes)
                    {
                        string condition = netFrameworkOnly ? null : ConditionForProjectType(groupProjectType);
                        var refs = ServiceProjectReferences(unitTestRoot, serviceConfigurations, groupProjectType);
                        foreach (var r in refs)
                        {
                            r.Condition = condition;
                            serviceProjectReferences.Add(r);
                        }
                    }

                    string projectGuid = Utils.GetProjectGuid(Utils.PathCombineAlt(unitTestRoot, projectName));
                    projectReferences = GetCommonReferences(unitTestRoot, useDllReference, configuration, effectiveProjectTypes);

                    var conditionalExcludes = new Dictionary<string, List<string>>();
                    foreach (var groupProjectType in effectiveProjectTypes)
                    {
                        string condition = netFrameworkOnly ? null : ConditionForProjectType(groupProjectType);
                        var excludeFolder = groupProjectType == NetFrameworkProjectType ? "_netstandard" : "_bcl";
                        // A null condition (net-framework-only service) means an unconditional exclude.
                        conditionalExcludes[condition ?? string.Empty] = new List<string> { excludeFolder };
                    }

                    var projectProperties = new Project
                    {
                        AssemblyName           = $"AWSSDK.UnitTests.{_serviceName}",
                        TargetFrameworksProperty = targetFrameworksProperty,
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
        /// The centralized MSBuild target-frameworks property for a legacy uber unit-test project of the
        /// given project type. NetFramework uses net472; NetStandard uses the MSTest non-.NET-Framework
        /// slice (netcoreapp3.1;net8.0) rather than the full source target set (which includes
        /// netstandard2.0, on which tests cannot run).
        /// </summary>
        private static string UberTestTargetsProperty(string projectType)
        {
            return projectType == NetFrameworkProjectType
                ? TargetFrameworkProperties.NetFrameworkProperty
                : TargetFrameworkProperties.MSTestNetProperty;
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

        private IList<ProjectFileCreator.ProjectReference> GetCommonReferences(string unitTestRoot, bool useDllReference, ProjectFileConfiguration configuration, IReadOnlyList<string> effectiveProjectTypes)
        {
            IList<ProjectFileCreator.ProjectReference> references = new List<ProjectFileCreator.ProjectReference>();

            // A single project type (e.g. the .NET Framework-only case) needs no condition; otherwise each
            // project-type variant is guarded by its framework-identifier condition.
            bool conditional = effectiveProjectTypes.Count > 1;

            if (!useDllReference)
            {
                foreach (var projectType in effectiveProjectTypes)
                {
                    string condition = conditional ? ConditionForProjectType(projectType) : null;
                    references.Add(CreateCoreReference(projectType, condition));
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

            foreach (var projectType in effectiveProjectTypes)
            {
                string condition = conditional ? ConditionForProjectType(projectType) : null;
                references.Add(CreateCrtReference(projectType, condition));
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
