using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Json.LitJson;
using ServiceClientGenerator.DefaultConfiguration;
using ServiceClientGenerator.Endpoints;
using ServiceClientGenerator.Endpoints.Tests;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Loads the generator control manifest document. This document
    /// yields the Visual Studio project metadata (for new project files
    /// that we create) and the set of service configurations available
    /// to process.
    /// </summary>
    public class GenerationManifest
    {
        abstract class ModelsSectionKeys
        {
            public const string ActiveKey = "active";
            public const string NamespaceKey = "namespace";
            public const string BaseNameKey = "base-name";
            public const string NugetPackageTitleSuffix = "nuget-package-title-suffix";
            public const string DefaultRegionKey = "default-region";
            public const string GenerateClientConstructorsKey = "generate-client-constructors";
            public const string CustomizationFileKey = "customization-file";
            public const string MaxRetriesKey = "max-retries";
            public const string SynopsisKey = "synopsis";
            public const string NetStandardSupportKey = "netstandard-support";
            public const string DependenciesKey = "dependencies";
            public const string ReferenceDependenciesKey = "reference-dependencies";
            public const string NugetDependenciesKey = "nuget-dependencies";
            public const string DependencyNameKey = "name";
            public const string DependencyVersionKey = "version";
            public const string DependencyHintPathKey = "hint-path";
            public const string ParentBaseNameKey = "parent-base-name";
            public const string TagsKey = "tags";
            public const string LicenseUrlKey = "license-url";
            public const string TestServiceKey = "test-service";
            public const string LegacyServiceIdKey = "legacy-service-id";
        }

        /// <summary>
        /// URL for Apache License 2.0
        /// </summary>
        public const string ApacheLicenseURL = @"http://aws.amazon.com/apache2.0/";

        /// <summary>
        /// The set of services declared in the manifest as supporting generation. 
        /// </summary>
        public IEnumerable<ServiceConfiguration> ServiceConfigurations { get; private set; }

        /// <summary>
        /// The set of extensions declared in the manifest as supporting generation. 
        /// </summary>
        public IEnumerable<ExtensionConfiguration> ExtensionConfigurations { get; private set; }

        /// <summary>
        /// The set of per-platform project metadata needed to generate a platform
        /// specific project file for a service.
        /// </summary>
        public IEnumerable<ProjectFileConfiguration> ProjectFileConfigurations { get; private set; }

        public IEnumerable<ProjectFileConfiguration> UnitTestProjectFileConfigurations { get; private set; }

        public string CoreFileVersion { get; private set; }

        public string CoreVersion { get; private set; }

        public bool DefaultToPreview
        {
            get;
            private set;
        }

        public string PreviewLabel
        {
            get;
            private set;
        }

        /// <summary>
        /// Model representing the default configuration modes as built
        /// from the sdk-default-configurations.json file.
        /// </summary>
        public DefaultConfiguration.DefaultConfigurationModel DefaultConfiguration { get; set; }

        //This should be the same version number as SdkVersioning.DefaultAssemblyVersion in BuildTasks
        private const string DefaultAssemblyVersion = "4.0";

        /// <summary>
        /// Processes the control manifest to yield the set of services available to
        /// generate and the Visual Studio project file information used to create
        /// new projects for services.
        /// </summary>
        /// <param name="options">GeneratorOptions containing information requred to load GenerationManifest</param>
        public static GenerationManifest Load(GeneratorOptions options)
        {
            var generationManifest = 
                new GenerationManifest(
                    new DefaultConfigurationController(
                        new FileReader(),
                        new DefaultConfigurationParser()));

            var manifest = LoadJsonFromFile(options.Manifest);
            var versionsManifest = LoadJsonFromFile(options.Versions);

            generationManifest.CoreFileVersion = versionsManifest["CoreVersion"].ToString();
            generationManifest.CoreVersion = Utils.GetVersion(versionsManifest["OverrideCoreVersion"]?.ToString() ?? generationManifest.CoreFileVersion);

            generationManifest.DefaultToPreview = (bool)versionsManifest["DefaultToPreview"];
            if (generationManifest.DefaultToPreview)
            {
                generationManifest.PreviewLabel = (string)versionsManifest["PreviewLabel"];
            }
            if (!string.IsNullOrEmpty(generationManifest.PreviewLabel))
                generationManifest.PreviewLabel = "-" + generationManifest.PreviewLabel;

            generationManifest.LoadDefaultConfiguration(options.ModelsFolder);
            generationManifest.LoadServiceConfigurations(manifest, versionsManifest["ServiceVersions"], versionsManifest["ExtensionVersions"], options);
            generationManifest.LoadExtensionConfigurations(versionsManifest["ServiceVersions"], versionsManifest["ExtensionVersions"], options);
            generationManifest.LoadProjectConfigurations(manifest);
            generationManifest.LoadUnitTestProjectConfigurations(manifest);

            return generationManifest;
        }

        /// <summary>
        /// Loads the sdk-default-configurations.json file.
        /// </summary>
        private void LoadDefaultConfiguration(string manifestPath)
        {
            var repositoryRootDirectoryPath = Utils.PathCombineAlt(manifestPath, "..","..");

            DefaultConfiguration = _defaultConfigurationController.LoadDefaultConfiguration(repositoryRootDirectoryPath);
        }

        /// <summary>
        /// Recursively walk through the ServiceModels folder and load/parse the 
        /// model files to generate ServiceConfiguration objects.
        /// </summary>
        /// <param name="manifest">loaded _manifest.json file</param>
        /// <param name="serviceVersions">loaded _sdk-versions.json file "ServiceVersions" secton</param>
        /// <param name="extensionVersions">loaded _sdk-versions.json file "ExtensionVersions" secton</param>
        /// <param name="options">generator options</param>
        void LoadServiceConfigurations(JsonData manifest, JsonData serviceVersions, JsonData extensionVersions, GeneratorOptions options)
        {
            List<Tuple<JsonData, ServiceConfiguration>> modelConfigList = new List<Tuple<JsonData, ServiceConfiguration>>();
            var serviceConfigurations = new List<ServiceConfiguration>();

            var serviceDirectories = Utils.GetServiceDirectories(options);

            foreach (string serviceDirectory in serviceDirectories)
            {
                string metadataJsonFile = Utils.PathCombineAlt(serviceDirectory, "metadata.json");
                if (File.Exists(metadataJsonFile))
                {
                    JsonData metadataNode = LoadJsonFromFile(metadataJsonFile);

                    var activeNode = metadataNode[ModelsSectionKeys.ActiveKey];
                    if (activeNode != null
                        &&  activeNode.IsBoolean
                        && !(bool)activeNode )
                    {
                        continue;
                    }

                    var serviceModelFileName = GetLatestModel(serviceDirectory);
                    string paginatorsFileName = GetLatestPaginators(serviceDirectory);
                    
                    var config = CreateServiceConfiguration(metadataNode, serviceVersions, extensionVersions, serviceDirectory, serviceModelFileName, paginatorsFileName);
                    serviceConfigurations.Add(config);

                    modelConfigList.Add(new Tuple<JsonData, ServiceConfiguration>(metadataNode, config));
                }
            }

            
            if (string.IsNullOrEmpty(options.ServiceModels))
            {
                // We skip this check if ServiceModels provided, as we would never satisfy condition below.
                //
                // We need to make sure that we have configuration files for all expected services and
                // that there aren't mismatches in the service names.
                foreach (string serviceVersionEntry in serviceVersions.GetMap().Keys)
                {
                    if (!serviceConfigurations.Any(config => config.ServiceNameRoot == serviceVersionEntry))
                    {
                        throw new Exception($"Service entry {serviceVersionEntry} doesn't match any of the available service configurations.");
                    }
                }
            }

            // The parent model for current model, if set, the client will be generated
            // in the same namespace and share common types.

            foreach (var modelConfig in modelConfigList)
            {
                var modelNode = modelConfig.Item1;
                var config = modelConfig.Item2;

                var parentClassName = modelNode[ModelsSectionKeys.ParentBaseNameKey] != null ? modelNode[ModelsSectionKeys.ParentBaseNameKey].ToString() : null;
                if (parentClassName != null)
                {
                    try
                    {
                        config.ParentConfig = serviceConfigurations.Single(c => c.ClassName.Equals(parentClassName));
                    }
                    catch (KeyNotFoundException exception)
                    {
                        // Note : the parent model should be defined in the manifest before being referred by a child model
                        throw new KeyNotFoundException(
                            string.Format("A parent model with name {0} is not defined in the manifest", parentClassName),
                            exception); ;
                    }
                }
            }

            ServiceConfigurations = serviceConfigurations
                .OrderBy(sc => sc.SdkDependencies.Count)
                .ToList();
        }

        /// <summary>
        /// Load ExtensionConfiguration objects.
        /// </summary>        
        /// <param name="serviceVersions">loaded _sdk-versions.json file "ServiceVersions" secton</param>
        /// <param name="extensionVersions">loaded _sdk-versions.json file "ExtensionVersions" secton</param>
        /// <param name="options">generator options</param>
        void LoadExtensionConfigurations(JsonData serviceVersions, JsonData extensionVersions, GeneratorOptions options)
        {
            var extensionConfigurations = new List<ExtensionConfiguration>();

            var extensionDirectories = Utils.GetExtensionDirectories(options);

            foreach (var extensionDirectory in extensionDirectories)
            {
                var altExtensionDirectory = Utils.ConvertPathAlt(extensionDirectory);
                var extensionId = altExtensionDirectory.Substring(altExtensionDirectory.LastIndexOf(Path.AltDirectorySeparatorChar) + 1);

                string nuspecFile = Utils.PathCombineAlt(altExtensionDirectory, extensionId + ".nuspec");
                if (!File.Exists(nuspecFile))
                {
                    // Not an active extension so skip it.
                    continue;
                }

                var config = CreateExtensionConfiguration(serviceVersions, extensionVersions, altExtensionDirectory, extensionId);
                extensionConfigurations.Add(config);
            }

            ExtensionConfigurations = extensionConfigurations
                .OrderBy(sc => sc.Id)
                .ToList();
        }

        /// <summary>
        /// Use the date order of the models combined with default string sort
        /// to find the latest models file
        /// </summary>
        /// <param name="serviceDirectory"></param>
        /// <returns></returns>
        private static string GetLatestModel(string serviceDirectory)
        {
            string latestModelName = Directory.GetFiles(serviceDirectory, "*.normal.json", SearchOption.TopDirectoryOnly).OrderBy(x => x).LastOrDefault();
            if (string.IsNullOrEmpty(latestModelName))
                throw new FileNotFoundException("Failed to find a model file in " + serviceDirectory);

            return latestModelName;
        }

        /// <summary>
        /// Use the date order of the paginators combined with default string sort
        /// to find the latest paginators file
        /// </summary>
        /// <param name="serviceDirectory"></param>
        /// <returns></returns>
        private static string GetLatestPaginators(string serviceDirectory)
        {
            var latestPaginatorsName = Directory.GetFiles(serviceDirectory, "*.paginators.json", SearchOption.TopDirectoryOnly)
                .OrderBy(x => x).LastOrDefault() ?? "";
            return Path.GetFileName(latestPaginatorsName);
        }

        private const string EndpointRuleSetFile = "endpoint-rule-set.json";
        private const string EndpointRuleSetTestsFile = "endpoint-tests.json";

        private ServiceConfiguration CreateServiceConfiguration(JsonData modelNode, JsonData serviceVersions, JsonData extensionVersions, string serviceDirectoryPath, string serviceModelFileName, string servicePaginatorsFileName)
        {
            var paginatorsFullPath = Utils.PathCombineAlt(serviceDirectoryPath, servicePaginatorsFileName);

            JsonData metadata = JsonMapper.ToObject(File.ReadAllText(serviceModelFileName))[ServiceModel.MetadataKey];

            // A new config that the api generates from            
            var modelName = Path.GetFileName(serviceDirectoryPath);
            var config = new ServiceConfiguration
            {
                ModelName = modelName,
                ModelPath = serviceModelFileName,
                PaginatorsPath = paginatorsFullPath,
                Namespace = Utils.JsonDataToString(modelNode[ModelsSectionKeys.NamespaceKey]), // Namespace of the service if it's different from basename
                ClassNameOverride = Utils.JsonDataToString(modelNode[ModelsSectionKeys.BaseNameKey]),
                DefaultRegion = Utils.JsonDataToString(modelNode[ModelsSectionKeys.DefaultRegionKey]),
                GenerateConstructors = modelNode[ModelsSectionKeys.GenerateClientConstructorsKey] == null || (bool)modelNode[ModelsSectionKeys.GenerateClientConstructorsKey], // A way to prevent generating basic constructors
                IsTestService = modelNode[ModelsSectionKeys.TestServiceKey] != null && (bool)modelNode[ModelsSectionKeys.TestServiceKey]
            };

            // Load endpoints ruleset and tests if present
            var rulesetFileName = Directory.GetFiles(serviceDirectoryPath, "*." + EndpointRuleSetFile, SearchOption.TopDirectoryOnly).LastOrDefault();
            var testsFileName = Directory.GetFiles(serviceDirectoryPath, "*." + EndpointRuleSetTestsFile, SearchOption.TopDirectoryOnly).LastOrDefault();

            // We have found tests but not rules, something is wrong!
            if (rulesetFileName == null && testsFileName != null)
            {
                throw new FileNotFoundException($"We have found endpoints tests but endpoints rules are missing. Expected file suffix is .{EndpointRuleSetFile}");
            }

            if (rulesetFileName != null)
            {
                var json = File.ReadAllText(rulesetFileName);
                config.EndpointsRuleSet = JsonMapper.ToObject<RuleSet>(json);
                if (testsFileName == null)
                {
                    throw new FileNotFoundException($"Endpoints tests are missing. Expected file suffix is .{EndpointRuleSetTestsFile}");
                }
                json = File.ReadAllText(testsFileName);
                config.EndpointTests = JsonMapper.ToObject<EndpointTests>(json, true);
            }

            if (modelNode[ModelsSectionKeys.NugetPackageTitleSuffix] != null)
                config.NugetPackageTitleSuffix = modelNode[ModelsSectionKeys.NugetPackageTitleSuffix].ToString();


            if (modelNode[ModelsSectionKeys.ReferenceDependenciesKey] != null)
            {
                config.ReferenceDependencies = new Dictionary<string, List<Dependency>>();
                foreach (KeyValuePair<string, JsonData> kvp in modelNode[ModelsSectionKeys.ReferenceDependenciesKey])
                {
                    var platformDependencies = new List<Dependency>();
                    foreach (JsonData item in kvp.Value)
                    {
                        var platformDependency = new Dependency
                        {
                            Name = item[ModelsSectionKeys.DependencyNameKey].ToString(),
                            Version = item.PropertyNames.Contains(ModelsSectionKeys.DependencyVersionKey) ? item[ModelsSectionKeys.DependencyVersionKey].ToString() : "0.0.0.0",
                            HintPath = item[ModelsSectionKeys.DependencyHintPathKey].ToString(),
                        };
                        platformDependencies.Add(platformDependency);
                    }
                    config.ReferenceDependencies.Add(kvp.Key, platformDependencies);
                }
            }

            if (modelNode[ModelsSectionKeys.NugetDependenciesKey] != null)
            {
                config.NugetDependencies = new Dictionary<string, List<Dependency>>();
                foreach (KeyValuePair<string, JsonData> kvp in modelNode[ModelsSectionKeys.NugetDependenciesKey])
                {
                    var nugetDependencies = new List<Dependency>();
                    foreach (JsonData item in kvp.Value)
                    {
                        var nugetDependency = new Dependency
                        {
                            Name = item[ModelsSectionKeys.DependencyNameKey].ToString(),
                            Version = item[ModelsSectionKeys.DependencyVersionKey].ToString(),
                        };
                        nugetDependencies.Add(nugetDependency);
                    }
                    config.NugetDependencies.Add(kvp.Key, nugetDependencies);
                }
            }

            config.Tags = new List<string>();
            if (modelNode[ModelsSectionKeys.TagsKey] != null)
            {
                foreach (JsonData tag in modelNode[ModelsSectionKeys.TagsKey])
                {
                    config.Tags.Add(tag.ToString());
                }
            }

            // Provides a way to specify a customizations file rather than using a generated one
            config.CustomizationsPath = modelNode[ModelsSectionKeys.CustomizationFileKey] == null
                ? DetermineCustomizationsPath(config.ServiceDirectoryName)
                : Utils.PathCombineAlt(serviceDirectoryPath, modelNode[ModelsSectionKeys.CustomizationFileKey].ToString());

            if (modelNode[ModelsSectionKeys.MaxRetriesKey] != null && modelNode[ModelsSectionKeys.MaxRetriesKey].IsInt)
                config.OverrideMaxRetries = Convert.ToInt32(modelNode[ModelsSectionKeys.MaxRetriesKey].ToString());

            if (modelNode[ModelsSectionKeys.SynopsisKey] != null)
                config.Synopsis = (string)modelNode[ModelsSectionKeys.SynopsisKey];

            if (modelNode[ModelsSectionKeys.LegacyServiceIdKey] != null)
                config.LegacyServiceId = (string)modelNode[ModelsSectionKeys.LegacyServiceIdKey];            
            
            if (modelNode[ModelsSectionKeys.NetStandardSupportKey] != null)
                config.NetStandardSupport = (bool)modelNode[ModelsSectionKeys.NetStandardSupportKey];
            else
                config.NetStandardSupport = true;

            config.SdkDependencies = new Dictionary<string, string>(StringComparer.Ordinal);
            if (modelNode[ModelsSectionKeys.DependenciesKey] != null && modelNode[ModelsSectionKeys.DependenciesKey].IsArray)
            {
                foreach (var d in modelNode[ModelsSectionKeys.DependenciesKey])
                {
                    config.SdkDependencies.Add(d.ToString(), null);
                }
            }

            if (config.ServiceModel.Type == ServiceType.Cbor)
            {
                config.SdkDependencies.Add("Extensions.CborProtocol", extensionVersions["Extensions.CborProtocol"]["Version"].ToString());                
            }

            if (modelNode[ModelsSectionKeys.LicenseUrlKey] != null && modelNode[ModelsSectionKeys.LicenseUrlKey].IsString)
            {
                config.LicenseUrl = modelNode[ModelsSectionKeys.LicenseUrlKey].ToString();
                config.RequireLicenseAcceptance = true;
            }
            else
                config.LicenseUrl = ApacheLicenseURL;

            var serviceName = config.ServiceNameRoot;
            var versionInfoJson = serviceVersions[serviceName];
            if (versionInfoJson != null)
            {
                var dependencies = versionInfoJson["Dependencies"];
                foreach (var name in dependencies.PropertyNames)
                {
                    var version = dependencies[name].ToString();
                    config.SdkDependencies[name] = version;
                }

                var versionText = versionInfoJson["Version"].ToString();
                config.ServiceFileVersion = versionText;

                var assemblyVersionOverride = versionInfoJson["AssemblyVersionOverride"];
                if (assemblyVersionOverride != null)
                {
                    config.ServiceAssemblyVersionOverride = assemblyVersionOverride.ToString();
                }

                if(versionInfoJson["InPreview"] != null && (bool)versionInfoJson["InPreview"])
                    config.InPreview = true;
                else
                    config.InPreview = this.DefaultToPreview;
            }
            else
            {
                config.SdkDependencies["Core"] = CoreFileVersion;
                config.InPreview = this.DefaultToPreview;

                config.ServiceFileVersion = DefaultAssemblyVersion;
                var versionTokens = CoreVersion.Split('.');
                if (!DefaultAssemblyVersion.StartsWith($"{versionTokens[0]}.{versionTokens[1]}"))
                {
                    throw new NotImplementedException($"{nameof(DefaultAssemblyVersion)} '{DefaultAssemblyVersion}' should be updated to match the AWSSDK.Core minor version number '{versionTokens[0]}.{versionTokens[1]}'.");
                }
            }

            return config;
        }

        private ExtensionConfiguration CreateExtensionConfiguration(JsonData serviceVersions, JsonData extensionVersions, string extensionDirectoryPath, string extensionId)
        {
            var config = new ExtensionConfiguration
            {
                Id = extensionId,
                Name = extensionId.Substring("AWSSDK.".Length),
                Path = extensionDirectoryPath,
                SdkDependencies = new Dictionary<string, string>(StringComparer.Ordinal)
            };
                        
            var versionInfoJson = extensionVersions[config.Name];
            if (versionInfoJson != null)
            {
                var dependencies = versionInfoJson["Dependencies"];
                foreach (var name in dependencies.PropertyNames)
                {
                    var version = dependencies[name].ToString();
                    config.SdkDependencies[name] = version;
                }

                var versionText = versionInfoJson["Version"].ToString();
                config.FileVersion = versionText;

                var assemblyVersionOverride = versionInfoJson["AssemblyVersionOverride"];
                if (assemblyVersionOverride != null)
                {
                    config.AssemblyVersionOverride = assemblyVersionOverride.ToString();
                }

                if (versionInfoJson["InPreview"] != null && (bool)versionInfoJson["InPreview"])
                    config.InPreview = true;
                else
                    config.InPreview = this.DefaultToPreview;
            }

            return config;
        }

        /// <summary>
        /// Parses the Visual Studio project metadata entries from the manifest. These
        /// are used when generating project files for a service.
        /// Sets the ProjectFileConfigurations member on exit with the collection of loaded
        /// configurations.
        /// </summary>
        /// <param name="document"></param>
        void LoadProjectConfigurations(JsonData document)
        {
            var projectConfigurations = new List<ProjectFileConfiguration>();

            var projectsNode = document[ProjectFileConfiguration.ProjectsSectionKeys.ProjectsKey];
            foreach (JsonData projectNode in projectsNode)
            {
                var config = ProjectFileConfiguration.Load(projectNode, loadExtraTestProjects: true);
                projectConfigurations.Add(config);
            }

            ProjectFileConfigurations = projectConfigurations;
        }

        void LoadUnitTestProjectConfigurations(JsonData document)
        {
            IList<ProjectFileConfiguration> configuraitons = new List<ProjectFileConfiguration>();
            var projectsNode = document[ProjectFileConfiguration.ProjectsSectionKeys.UnitTestProjectsKey];
            foreach (JsonData projectNode in projectsNode)
            {
                var configuration = ProjectFileConfiguration.Load(projectNode, loadExtraTestProjects: false);
                configuraitons.Add(configuration);
            }

            UnitTestProjectFileConfigurations = configuraitons;
        }

        /// <summary>
        /// Finds the customizations file in \customizations as model.customizations.json if it's there
        /// </summary>
        /// <param name="model">The name of the model as defined in the _manifest</param>
        /// <returns>Full path to the customization if it exists, null if it wasn't found</returns>
        private static string DetermineCustomizationsPath(string serviceKey)
        {
            if (!Directory.Exists("customizations"))
            {
                return null;
            }
            var customizationFile = Directory.GetFiles("customizations", serviceKey + ".customizations.json").OrderBy(x => x).LastOrDefault();
            return customizationFile;
        }

        /// <summary>
        /// Loads a JsonData object for data in a given file.
        /// </summary>
        /// <param name="path">Path to the JSON file.</param>
        /// <returns>JsonData corresponding to JSON in the file.</returns>
        private static JsonData LoadJsonFromFile(string path)
        {
            JsonData data;
            using (var reader = new StreamReader(path))
                data = JsonMapper.ToObject(reader);
            return data;
        }

        private readonly IDefaultConfigurationController _defaultConfigurationController;
        private GenerationManifest(IDefaultConfigurationController defaultConfigurationController)
        {
            _defaultConfigurationController = defaultConfigurationController;
        }

        public GenerationManifest()
        {

        }
    }
}
