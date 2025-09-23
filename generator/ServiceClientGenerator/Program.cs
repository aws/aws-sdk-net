using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class Program
    {
        static int Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

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
                    CustomizationCompiler.CompileServiceCustomizations(options);

                var generationManifest = GenerationManifest.Load(options);

                if (string.IsNullOrEmpty(options.SelfServiceModel))
                {
                    ConcurrentDictionary<string, byte> generatedFiles = new ConcurrentDictionary<string, byte>();
                    ConcurrentDictionary<string, byte> generatedUnitTestFiles = new ConcurrentDictionary<string, byte>();
                    
                    GeneratorDriver.GenerateCoreProjects(generationManifest, options);
                    GeneratorDriver.GeneratePartitions(options);

                    var maxDegreeOfParallelism = Environment.ProcessorCount * 2;
                    Console.WriteLine($"Setting MaxDegreeOfParallelism = {maxDegreeOfParallelism}");

                    // Process services
                    Parallel.ForEach(generationManifest.ServiceConfigurations, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism }, (serviceConfig, state) =>
                    {
                        if (modelsToProcess.Any() && !modelsToProcess.Contains(serviceConfig.ModelName))
                        {
                            Console.WriteLine("Skipping model (not in -servicemodels set to process): {0} ({1})",
                                serviceConfig.ModelName, serviceConfig.ModelPath);
                            return;
                        }

                        Console.WriteLine("Processing model: {0} ({1})", serviceConfig.ModelName,
                            serviceConfig.ModelPath);
                        var driver = new GeneratorDriver(serviceConfig, generationManifest, options);
                        driver.Execute();
                        foreach (var file in driver.FilesWrittenToGeneratorFolder)
                        {
                            generatedFiles.TryAdd(file, 0);
                        }
                        var generatedTestFiles = GeneratorDriver.UpdateUnitTestProjects(generationManifest, options, driver.ServiceUnitTestFilesRoot, serviceConfig);
                        foreach (var file in generatedTestFiles)
                        {
                            generatedUnitTestFiles.TryAdd(file, 0);
                        }                        
                    });

                    // Process extensions
                    Parallel.ForEach(generationManifest.ExtensionConfigurations, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism }, (extensionConfig, state) =>
                    {
                        Console.WriteLine("Processing extension: {0} ({1})", extensionConfig.Id,
                            extensionConfig.Path);

                        var driver = new GeneratorExtensionsDriver(extensionConfig, options);
                        driver.Execute();
                    });

                    // Post processing services and extensions
                    var files = new HashSet<string>(generatedFiles.Keys);
                    var testFiles = new HashSet<string>(generatedUnitTestFiles.Keys);

                    if (!options.SkipRemoveOrphanCleanup)
                        GeneratorDriver.RemoveOrphanedShapesAndServices(files, testFiles, options.SdkRootFolder);

                    GeneratorDriver.UpdateUnitTestProjects(generationManifest, options);
                    GeneratorDriver.UpdateSolutionFiles(generationManifest, options);
                    GeneratorDriver.UpdateAssemblyVersionInfo(generationManifest, options);
                    GeneratorDriver.UpdateNuGetPackagesInReadme(generationManifest, options);
                    GeneratorDriver.UpdateCodeAnalysisSolution(generationManifest, options);
                    GeneratorDriver.GenerateDefaultConfigurationModeEnum(generationManifest, options);
                    GeneratorDriver.GenerateEndpoints(options);
                    GeneratorDriver.GenerateS3Enumerations(options);
                }
                else
                {
                    var serviceConfig = new ServiceConfiguration
                    {
                        ModelPath = options.SelfServiceModel,
                        ServiceFileVersion = "4.0.0.0"
                    };
                    serviceConfig.ModelName = Path.GetFileName(serviceConfig.ModelPath);
                    serviceConfig.SdkDependencies = new Dictionary<string, string> { {"Core", "4.0.0.18"} };
                    serviceConfig.GenerateConstructors = true;


                    var relativePathToCustomizations = Utils.PathCombineAlt("customizations", string.Format("{0}.customizations.json", options.SelfServiceBaseName.ToLowerInvariant()));
                    if (File.Exists(relativePathToCustomizations))
                    {
                        serviceConfig.CustomizationsPath = Utils.ConvertPathAlt(Path.GetFullPath(relativePathToCustomizations));
                        Console.WriteLine("Using customization file: {0}", serviceConfig.CustomizationsPath);
                    }
                    
                    Console.WriteLine("Processing self service {0} with model {1}.", options.SelfServiceBaseName, options.SelfServiceModel);
                    var driver = new GeneratorDriver(serviceConfig, generationManifest, options);
                    driver.Execute();

                    // Skip orphan clean for DynamoDB because of the complex nature of DynamoDB and DynamoDB Streams
                    if (!serviceConfig.ClassName.StartsWith("DynamoDB") && !options.SkipRemoveOrphanCleanup)
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

            sw.Stop();
            Console.WriteLine($"Generator executed in: {sw.Elapsed}");

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
