using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using Json.LitJson;

using ServiceClientGenerator.Generators;

namespace ServiceClientGenerator
{
    class Program
    {
        static int Main(string[] args)
        {
            string outputDir, outputDir45, outputDirRT, outputDirPortable;
            string manifestPath;
            string modelsFolder;
            string testsFolder;

            string servicesList = null;
            var servicesToProcess = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            var compileCustomizations = true;

            if (args.Length < 7)
            {
                manifestPath = @"..\..\..\_manifest.json";
                modelsFolder = @"..\..\..\ServiceModels";
                outputDir = @"..\..\..\AWSSDK_DotNet35";
                outputDir45 = @"..\..\..\AWSSDK_DotNet45";
                outputDirRT = @"..\..\..\AWSSDK_WinRT";
                outputDirPortable = @"..\..\..\AWSSDK_Portable";
                testsFolder = @"..\..\..\AWSSDK_DotNet.UnitTests";

                // last argument is the set of ;-delimited service basenames to process
                if (args.Length != 0)
                    servicesList = args[0];
            }
            else
            {
                manifestPath = args[0];
                modelsFolder = args[1];
                outputDir = args[2];
                outputDir45 = args[3];
                outputDirRT = args[4];
                outputDirPortable = args[5];
                testsFolder = args[6];

                // last argument is the set of ;-delimited service basenames to process
                if (args.Length == 8)
                    servicesList = args[7];
            }

            if (!string.IsNullOrEmpty(servicesList))
            {
                foreach (var s in servicesList.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    servicesToProcess.Add(s);
                }
            }

            try
            {
                if (compileCustomizations) // Compile all servicename.customizations*.json files into one json file in bin
                    CustomizationCompiler.CompileServiceCustomizations(modelsFolder);

                foreach (var config in LoadGeneratorConfigs(manifestPath, modelsFolder))
                {
                    if (servicesToProcess.Any() && !servicesToProcess.Contains(config.BaseName))
                    {
                        Console.WriteLine("Skipping Model (not in arg list to process): {0}", config.ModelPath);
                        continue;
                    }

                    Console.WriteLine("Processing Model: {0}", config.ModelPath);
                    var driver = new GeneratorDriver(config, outputDir, outputDir45, outputDirRT, outputDirPortable, testsFolder);
                    driver.Execute();
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error running generator: " + e.Message);
                Console.Error.WriteLine(e.StackTrace);
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Sets the properties of a GeneratorConfig for a service model
        /// </summary>
        /// <param name="manifestPath">Path to the manifest file to pull basic info from</param>
        /// <param name="modelsFolder">Path to the service models to be parsed</param>
        /// <returns></returns>
        static IEnumerable<GeneratorConfig> LoadGeneratorConfigs(string manifestPath, string modelsFolder)
        {
            JsonData document;
            using (StreamReader reader = new StreamReader(manifestPath))
                document = JsonMapper.ToObject(reader);

            var modelsNode = document["models"];
            foreach (JsonData modelNode in modelsNode)
            {
                var activeNode = modelNode["active"];
                if (activeNode != null && activeNode.IsBoolean && !(bool)activeNode) // skip models with active set to false
                    continue;

                // A new config that the api generates from
                var config = new GeneratorConfig
                {
                    ModelPath = DetermineModelPath(modelNode["model"].ToString(), modelsFolder), // Path to the file servicename-*-.normal.json
                    Namespace = modelNode["namespace"] != null ? modelNode["namespace"].ToString() : null, // Namespace of the service if it's different from basename
                    LockedAPIVersion = modelNode["locked-api-version"] != null ? modelNode["locked-api-version"].ToString() : null,
                    BaseName = modelNode["base-name"].ToString(), // The name that is used as the client name and base request name
                    ServiceName = modelNode["service-name"] != null ? modelNode["service-name"].ToString() : null,
                    RegionLookupName = modelNode["region-lookup-name"].ToString(),
                    AuthenticationServiceName = modelNode["authentication-service-name"] != null ? modelNode["authentication-service-name"].ToString() : null,
                    ServiceUrl = modelNode["service-url"] != null ? modelNode["service-url"].ToString() : null,
                    DefaultRegion = modelNode["default-region"] != null ? modelNode["default-region"].ToString() : null,
                    GenerateConstructors = modelNode["generate-client-constructors"] != null ? (bool)modelNode["generate-client-constructors"] : true // A way to prevent generating basic constructors
                };

                if (modelNode["mobile-platforms"] != null && modelNode["mobile-platforms"].IsArray)
                {
                    IList<string> mobilePlatforms = new List<string>();
                    foreach (var platform in modelNode["mobile-platforms"])
                        mobilePlatforms.Add(platform.ToString());
                    config.SetSupportedMobilePlatforms(mobilePlatforms);
                }

                if (modelNode["customization-file"] == null) // Provides a way to specify a customizations file rather than using a generated one
                    config.CustomizationsPath = DetermineCustomizationsPath(modelNode["model"].ToString());
                else
                    config.CustomizationsPath = Path.Combine(modelsFolder, modelNode["customization-file"].ToString());

                if (modelNode["append-service"] != null && (bool)modelNode["append-service"])
                    config.BaseName += "Service";

                if (modelNode["max-retries"] != null && modelNode["max-retries"].IsInt) 
                    config.OverrideMaxRetries = Convert.ToInt32(modelNode["max-retries"].ToString());

                yield return config;
            }
        }

        /// <summary>
        /// Finds the full path to the model*.normal.json file in order to parse the config
        /// </summary>
        /// <param name="model">The name of the model found in the manifest file</param>
        /// <param name="modelsFolder">The folder that contains the model*.normal.json files</param>
        /// <returns>Full path to model file as a string</returns>
        static string DetermineModelPath(string model, string modelsFolder)
        {
            var files = Directory.GetFiles(modelsFolder, model + "*.normal.json").OrderByDescending(x => x);
            if(files.Count() == 0)
                throw new Exception("Failed to find model for service " + model);

            return files.First();
        }

        /// <summary>
        /// Finds the customizations file in \customizations as model.customizations.json if it's there
        /// </summary>
        /// <param name="model">The name of the model as defined in the _manifest</param>
        /// <returns>Full path to the customization if it exists, null if it wasn't found</returns>
        static string DetermineCustomizationsPath(string model)
        {
            var files = Directory.GetFiles("customizations", model + "*.customizations.json").OrderByDescending(x => x);
            if (files.Count() == 0)
                return null;

            return files.Single();
        }
    }
}
