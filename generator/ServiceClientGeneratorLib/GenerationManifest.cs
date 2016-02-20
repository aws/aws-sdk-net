using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.LitJson;

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
            public const string ModelsKey = "models";
            public const string ActiveKey = "active";
            public const string ModelKey = "model";
            public const string NamespaceKey = "namespace";
            public const string LockedApiVersionKey = "locked-api-version";
            public const string BaseNameKey = "base-name";
            public const string RegionLookupNameKey = "region-lookup-name";
            public const string NugetPackageTitleSuffix = "nuget-package-title-suffix";
            public const string AuthenticationServiceNameKey = "authentication-service-name";
            public const string ServiceUrlKey = "service-url";
            public const string DefaultRegionKey = "default-region";
            public const string GenerateClientConstructorsKey = "generate-client-constructors";
            public const string CustomizationFileKey = "customization-file";
            public const string AppendServiceKey = "append-service";
            public const string MaxRetriesKey = "max-retries";
            public const string SynopsisKey = "synopsis";
            public const string DependenciesKey = "dependencies";
            public const string PlatformsKey = "platforms";
            public const string ReferenceDependenciesKey = "reference-dependencies";
            public const string NugetDependenciesKey = "nuget-dependencies";
            public const string PclVariantsKey = "pcl-variants";
            public const string DependencyNameKey = "name";
            public const string DependencyVersionKey = "version";
            public const string DependencyHintPathKey = "hint-path";
            public const string ParentBaseNameKey = "parent-base-name";
            public const string EnableXamarinComponent = "enable-xamarin-component";
            public const string TagsKey = "tags";
            public const string UsePclProjectDependenciesKey = "use-pcl-project-dependencies";
            public const string LicenseUrlKey = "license-url";

        }

        abstract class ProjectsSectionKeys
        {
            public const string ProjectsKey = "projects";
            public const string NameKey = "name";
            public const string ConfigurationsKey = "configurations";
            public const string TargetFrameworkKey = "targetFramework";
            public const string DefineConstantsKey = "defineConstants";
            public const string BinSubFolderKey = "binSubFolder";
            public const string TemplateKey = "template";
            public const string PlatformCodeFoldersKey = "platformCodeFolders";
            public const string ExtraTestProjects = "extraTestProjects";
            public const string ParentProfile = "parentProfile";
            public const string NuGetTargetFrameworkKey = "nugetTargetPlatform";
        }

        /// <summary>
        /// URL for Apache License 2.0
        /// </summary>
        public const string ApacheLicenseURL = @"http://aws.amazon.com/apache2.0/";

        /// <summary>
        /// The set of services declared in the manifest as supporting generation. 
        /// </summary>
        public IEnumerable<ServiceConfiguration> ServiceConfigurations { get; private set; }

        //public IDictionary<string, string> ServiceVersions { get; private set; }

        /// <summary>
        /// The set of per-platform project metadata needed to generate a platform
        /// specific project file for a service.
        /// </summary>
        public IEnumerable<ProjectFileConfiguration> ProjectFileConfigurations { get; private set; }

        public string CoreVersion
        {
            get
            {
                return Utils.GetVersion(CoreFileVersion);
            }
        }
        public string CoreFileVersion { get; private set; }

        public bool DefaultToPreview
        {
            get;
            private set;
        }

        /// <summary>
        /// Processes the control manifest to yield the set of services available to
        /// generate and the Visual Studio project file information used to create
        /// new projects for services.
        /// </summary>
        /// <param name="manifestPath">Path to the manifest file to pull basic info from</param>
        /// <param name="modelsFolder">Path to the service models to be parsed</param>
        public static GenerationManifest Load(string manifestPath, string versionsPath, string modelsFolder)
        {
            var generationManifest = new GenerationManifest();

            var manifest = LoadJsonFromFile(manifestPath);
            var versionsManifest = LoadJsonFromFile(versionsPath);
            var coreVersionJson = versionsManifest["CoreVersion"];
            generationManifest.CoreFileVersion = coreVersionJson.ToString();
            var versions = versionsManifest["ServiceVersions"];

            generationManifest.DefaultToPreview = (bool)versionsManifest["DefaultToPreview"];

            generationManifest.LoadServiceConfigurations(manifest, generationManifest.CoreFileVersion, versions, modelsFolder);
            generationManifest.LoadProjectConfigurations(manifest);

            return generationManifest;
        }

        /// <summary>
        /// Parses the service configuration metadata from the supplied manifest document,
        /// fixing up file references to the actual service model and customization files.
        /// Sets the ServiceConfigurations member on exit with the collection of loaded
        /// configurations.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="modelsFolder"></param>
        void LoadServiceConfigurations(JsonData manifest, string coreVersion, JsonData versions, string modelsFolder)
        {
            var serviceConfigurations = new List<ServiceConfiguration>();

            var modelsNode = manifest[ModelsSectionKeys.ModelsKey];
            foreach (JsonData modelNode in modelsNode)
            {
                var activeNode = modelNode[ModelsSectionKeys.ActiveKey];
                if (activeNode != null && activeNode.IsBoolean && !(bool)activeNode) // skip models with active set to false
                    continue;

                // A new config that the api generates from
                var modelName = modelNode[ModelsSectionKeys.ModelKey].ToString();
                var config = new ServiceConfiguration
                {
                    ModelName = modelName,
                    ModelPath = DetermineModelPath(modelName, modelsFolder), // Path to the file servicename-*-.normal.json
                    Namespace = modelNode[ModelsSectionKeys.NamespaceKey] != null ? modelNode[ModelsSectionKeys.NamespaceKey].ToString() : null, // Namespace of the service if it's different from basename
                    LockedApiVersion = modelNode[ModelsSectionKeys.LockedApiVersionKey] != null ? modelNode[ModelsSectionKeys.LockedApiVersionKey].ToString() : null,
                    BaseName = modelNode[ModelsSectionKeys.BaseNameKey].ToString(), // The name that is used as the client name and base request name
                    RegionLookupName = modelNode[ModelsSectionKeys.RegionLookupNameKey].ToString(),
                    AuthenticationServiceName = modelNode[ModelsSectionKeys.AuthenticationServiceNameKey] != null ? modelNode[ModelsSectionKeys.AuthenticationServiceNameKey].ToString() : null,
                    ServiceUrl = modelNode[ModelsSectionKeys.ServiceUrlKey] != null ? modelNode[ModelsSectionKeys.ServiceUrlKey].ToString() : null,
                    DefaultRegion = modelNode[ModelsSectionKeys.DefaultRegionKey] != null ? modelNode[ModelsSectionKeys.DefaultRegionKey].ToString() : null,
                    GenerateConstructors = modelNode[ModelsSectionKeys.GenerateClientConstructorsKey] == null || (bool)modelNode[ModelsSectionKeys.GenerateClientConstructorsKey], // A way to prevent generating basic constructors
                    SupportedMobilePlatforms = modelNode[ModelsSectionKeys.PlatformsKey] == null ? new List<string>() : (from object pcf in modelNode[ModelsSectionKeys.PlatformsKey]
                                                                                                                         select pcf.ToString()).ToList(),
                    EnableXamarinComponent = modelNode.PropertyNames.Contains(ModelsSectionKeys.EnableXamarinComponent) && (bool)modelNode[ModelsSectionKeys.EnableXamarinComponent]
                };

                if (modelNode[ModelsSectionKeys.PclVariantsKey] != null)
                {
                    config.PclVariants = (from object pcf in modelNode[ModelsSectionKeys.PclVariantsKey]
                                          select pcf.ToString()).ToList();
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
                    ? DetermineCustomizationsPath(modelNode[ModelsSectionKeys.ModelKey].ToString())
                    : Path.Combine(modelsFolder, modelNode[ModelsSectionKeys.CustomizationFileKey].ToString());

                if (modelNode[ModelsSectionKeys.AppendServiceKey] != null && (bool)modelNode[ModelsSectionKeys.AppendServiceKey])
                    config.BaseName += "Service";

                if (modelNode[ModelsSectionKeys.MaxRetriesKey] != null && modelNode[ModelsSectionKeys.MaxRetriesKey].IsInt)
                    config.OverrideMaxRetries = Convert.ToInt32(modelNode[ModelsSectionKeys.MaxRetriesKey].ToString());

                if (modelNode[ModelsSectionKeys.SynopsisKey] != null)
                    config.Synopsis = (string)modelNode[ModelsSectionKeys.SynopsisKey];


                config.ServiceDependencies = new Dictionary<string, string>(StringComparer.Ordinal);
                if (modelNode[ModelsSectionKeys.DependenciesKey] != null && modelNode[ModelsSectionKeys.DependenciesKey].IsArray)
                {
                    foreach (var d in modelNode[ModelsSectionKeys.DependenciesKey])
                    {
                        config.ServiceDependencies.Add(d.ToString(), null);
                    }
                }

                if (modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey] != null && modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey].IsBoolean)
                    config.UsePclProjectDependencies = bool.Parse(modelNode[ModelsSectionKeys.UsePclProjectDependenciesKey].ToString());
                else
                    config.UsePclProjectDependencies = false;

                if (modelNode[ModelsSectionKeys.LicenseUrlKey] != null && modelNode[ModelsSectionKeys.LicenseUrlKey].IsString)
                {
                    config.LicenseUrl = modelNode[ModelsSectionKeys.LicenseUrlKey].ToString();
                    config.RequireLicenseAcceptance = true;
                }
                else
                    config.LicenseUrl = ApacheLicenseURL;

                var serviceName = config.ServiceNameRoot;
                var versionInfoJson = versions[serviceName];
                if (versionInfoJson != null)
                {
                    var dependencies = versionInfoJson["Dependencies"];
                    foreach (var name in dependencies.PropertyNames)
                    {
                        var version = dependencies[name].ToString();
                        config.ServiceDependencies[name] = version;
                    }


                    var versionText = versionInfoJson["Version"].ToString();
                    config.ServiceFileVersion = versionText;

                    config.InPreview = versionInfoJson["InPreview"] != null ? (bool)versionInfoJson["InPreview"] : this.DefaultToPreview;
                }
                else
                {
                    config.ServiceDependencies["Core"] = coreVersion;
                    var versionTokens = coreVersion.Split('.');
                    config.ServiceFileVersion = string.Format("{0}.{1}.0.0", versionTokens[0], versionTokens[1]);
                }

                // The parent model for current model, if set, the client will be generated
                // in the same namespace and share common types.
                var parentModelName = modelNode[ModelsSectionKeys.ParentBaseNameKey] != null ? modelNode[ModelsSectionKeys.ParentBaseNameKey].ToString() : null;
                if (parentModelName != null)
                {
                    try
                    {
                        config.ParentConfig = serviceConfigurations.Single(c => c.BaseName.Equals(parentModelName));
                    }
                    catch (KeyNotFoundException exception)
                    {
                        // Note : the parent model should be defined in the manifest before being referred by a child model
                        throw new KeyNotFoundException(
                            string.Format("A parent model with name {0} is not defined in the manifest", parentModelName),
                            exception); ;
                    }
                }

                serviceConfigurations.Add(config);
            }

            ServiceConfigurations = serviceConfigurations
                .OrderBy(sc => sc.ServiceDependencies.Count)
                .ToList();
            //ServiceVersions = serviceVersions;
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

            var projectsNode = document[ProjectsSectionKeys.ProjectsKey];
            foreach (JsonData projectNode in projectsNode)
            {
                var projectTypeName = projectNode[ProjectsSectionKeys.NameKey].ToString();
                var config = new ProjectFileConfiguration
                {
                    Name = projectTypeName,
                    TargetFrameworkVersion = projectNode[ProjectsSectionKeys.TargetFrameworkKey].ToString(),
                    CompilationConstants = projectNode[ProjectsSectionKeys.DefineConstantsKey].ToString(),
                    BinSubFolder = projectNode[ProjectsSectionKeys.BinSubFolderKey].ToString(),
                    Template = projectNode[ProjectsSectionKeys.TemplateKey].ToString(),
                    NuGetTargetPlatform = projectNode[ProjectsSectionKeys.NuGetTargetFrameworkKey] == null ? string.Empty : projectNode[ProjectsSectionKeys.NuGetTargetFrameworkKey].ToString()
                };

                config.Configurations = (from object bc in projectNode[ProjectsSectionKeys.ConfigurationsKey]
                                         select bc.ToString()).ToList();
                config.PlatformCodeFolders = (from object pcf in projectNode[ProjectsSectionKeys.PlatformCodeFoldersKey]
                                              select pcf.ToString()).ToList();
                var extraTestProjects = projectNode.SafeGet(ProjectsSectionKeys.ExtraTestProjects);
                if (extraTestProjects == null)
                {
                    config.ExtraTestProjects = new List<string>();
                }
                else
                {
                    config.ExtraTestProjects = (from object etp in extraTestProjects
                                                select etp.ToString()).ToList();
                }

                // This code assumes that the parent profile (project configuration) is defined in the manifest
                // before it's being referred by a sub profile.
                if (projectNode.PropertyNames.Contains(ProjectsSectionKeys.ParentProfile))
                {
                    var parentProfileName = projectNode[ProjectsSectionKeys.ParentProfile].ToString();
                    if (!string.IsNullOrEmpty(parentProfileName))
                    {
                        var parentProfile = projectConfigurations.SingleOrDefault(
                            p => p.Name.Equals(parentProfileName, StringComparison.InvariantCulture));
                        if (parentProfile == null)
                        {
                            throw new KeyNotFoundException(string.Format("Parent profile {0} referred by current profile {1} does not exist.",
                                parentProfile, config.Name));
                        }
                        config.ParentProfile = parentProfile;
                    }
                }

                projectConfigurations.Add(config);
            }

            ProjectFileConfigurations = projectConfigurations;
        }

        /// <summary>
        /// Finds the full path to the model*.normal.json file in order to parse the config
        /// </summary>
        /// <param name="model">The name of the model found in the manifest file</param>
        /// <param name="modelsFolder">The folder that contains the model*.normal.json files</param>
        /// <returns>Full path to model file as a string</returns>
        private static string DetermineModelPath(string model, string modelsFolder)
        {
            var files = Directory.GetFiles(modelsFolder, model + "*.normal.json").OrderByDescending(x => x);
            if (!files.Any())
                throw new Exception("Failed to find model for service " + model);

            return files.First();
        }

        /// <summary>
        /// Finds the customizations file in \customizations as model.customizations.json if it's there
        /// </summary>
        /// <param name="model">The name of the model as defined in the _manifest</param>
        /// <returns>Full path to the customization if it exists, null if it wasn't found</returns>
        private static string DetermineCustomizationsPath(string model)
        {
            var files = Directory.GetFiles("customizations", model + "*.customizations.json").OrderByDescending(x => x);
            return !files.Any() ? null : files.Single();
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

        private GenerationManifest()
        {

        }
    }
}
