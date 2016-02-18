using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ServiceClientGenerator
{
    public class Program
    {
        static int Main(string[] args)
        {
            var commandArguments = CommandArguments.Parse(args);
            if (!string.IsNullOrEmpty(commandArguments.Error))
            {
                Console.WriteLine(commandArguments.Error);
                return -1;
            }

            var returnCode = 0;
            var options = commandArguments.ParsedOptions;
            var modelsToProcess = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (!string.IsNullOrEmpty(options.ServiceModels))
            {
                foreach (var s in options.ServiceModels.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    modelsToProcess.Add(s);
                }
            }

            try
            {
                if (options.CompileCustomizations) // Compile all servicename.customizations*.json files into one json file in bin
                    CustomizationCompiler.CompileServiceCustomizations(options.ModelsFolder);

                var generationManifest = GenerationManifest.Load(options.Manifest, options.Versions, options.ModelsFolder);

                if (string.IsNullOrEmpty(options.SelfServiceModel))
                {
                    HashSet<string> generatedFiles = new HashSet<string>();
					GeneratorDriver.GenerateCoreProjects(generationManifest, options);
					foreach (var serviceConfig in generationManifest.ServiceConfigurations)
                    {
                        if (modelsToProcess.Any() && !modelsToProcess.Contains(serviceConfig.ModelName))
                        {
                            Console.WriteLine("Skipping model (not in -servicemodels set to process): {0} ({1})", serviceConfig.ModelName, serviceConfig.ModelPath);
                            continue;
                        }

                        Console.WriteLine("Processing model: {0} ({1})", serviceConfig.ModelName, serviceConfig.ModelPath);
                        var driver = new GeneratorDriver(serviceConfig, generationManifest, options);
                        driver.Execute();
                        foreach(var file in driver.FilesWrittenToGeneratorFolder)
                        {
                            generatedFiles.Add(file);
                        }
                    }

                    GeneratorDriver.RemoveOrphanedShapes(generatedFiles, Path.Combine(options.SdkRootFolder, @"src\Services"));

					GeneratorDriver.UpdateSolutionFiles(generationManifest, options);
					GeneratorDriver.UpdateAssemblyVersionInfo(generationManifest, options);
                    GeneratorDriver.UpdateNuGetPackagesInReadme(generationManifest, options);
					GeneratorDriver.UpdateUnitTestProjectReferences(options);
                    GeneratorDriver.UpdateCodeAnalysisSoltion(generationManifest, options);

                }
                else
                {
                    var serviceConfig = new ServiceConfiguration
                    {
                        ModelPath = options.SelfServiceModel,
                        BaseName = options.SelfServiceBaseName,
                        AuthenticationServiceName = options.SelfServiceSigV4Name ?? options.SelfServiceBaseName.ToLower(),
                        RegionLookupName = options.SelfServiceEndpointPrefix ?? options.SelfServiceBaseName.ToLower(),
                        ServiceFileVersion = "3.1.0.0"
                    };
                    serviceConfig.ModelName = Path.GetFileName(serviceConfig.ModelPath);
                    serviceConfig.ServiceDependencies = new Dictionary<string, string> { {"Core", "3.1.0.0"} };
                    serviceConfig.GenerateConstructors = true;


                    var relativePathToCustomizations = Path.Combine("customizations", string.Format("{0}.customizations.json", options.SelfServiceBaseName.ToLowerInvariant()));
                    if (File.Exists(relativePathToCustomizations))
                    {
                        serviceConfig.CustomizationsPath = Path.GetFullPath(relativePathToCustomizations);
                        Console.WriteLine("Using customization file: {0}", serviceConfig.CustomizationsPath);
                    }
                    
                    Console.WriteLine("Processing self service {0} with model {1}.", options.SelfServiceBaseName, options.SelfServiceModel);
                    var driver = new GeneratorDriver(serviceConfig, generationManifest, options);
                    driver.Execute();

                    // Skip orphan clean for DynamoDB because of the complex nature of DynamDB and DynamoDB Streams
                    if(!serviceConfig.BaseName.StartsWith("DynamoDB"))
                    {
                        GeneratorDriver.RemoveOrphanedShapes(driver.FilesWrittenToGeneratorFolder, driver.GeneratedFilesRoot);
                    }
                    
                }
            }
            catch (Exception e)
            {
                if (options.WaitOnExit)
                {
                    Console.Error.WriteLine("Error running generator: " + e.Message);
                    Console.Error.WriteLine(e.StackTrace);
                    returnCode = -1;
                }
                else
                    throw;
            }

            if (options.WaitOnExit)
            {
                Console.WriteLine();
                Console.WriteLine("Generation complete. Press a key to exit.");
                Console.ReadLine();
            }

            return returnCode;
        }

    }
}
