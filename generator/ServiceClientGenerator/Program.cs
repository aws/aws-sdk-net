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
                }

                GeneratorDriver.UpdateSolutionFiles(generationManifest, options);
                GeneratorDriver.UpdateAssemblyVersionInfo(generationManifest, options);
                GeneratorDriver.UpdateUnitTestProjectReferences(options);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error running generator: " + e.Message);
                Console.Error.WriteLine(e.StackTrace);
                returnCode = -1;
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
