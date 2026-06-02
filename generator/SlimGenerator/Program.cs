using System;
using System.IO;
using System.Text.Json;
using ServiceClientGenerator;
using ServiceClientGenerator.DefaultConfiguration;

namespace SlimGenerator
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var commandArgs = CommandArguments.Parse(args);
            if (!string.IsNullOrEmpty(commandArgs.Error))
            {
                Console.Error.WriteLine(commandArgs.Error);
                CommandArguments.PrintUsage();
                return 1;
            }

            var serviceDirectory = Path.GetFullPath(commandArgs.ModelPath);
            if (!Directory.Exists(serviceDirectory))
            {
                Console.Error.WriteLine($"Directory not found: {serviceDirectory}");
                return 1;
            }

            try
            {
                var outputDir = string.IsNullOrEmpty(commandArgs.OutputDir)
                    ? Path.Combine(Directory.GetCurrentDirectory(), "output")
                    : Path.GetFullPath(commandArgs.OutputDir);

                var result = Run(serviceDirectory, commandArgs.CoreVersion, outputDir);
                Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine(ex.StackTrace);
                return 1;
            }
        }

        static GenerationResult Run(string serviceDirectory, string coreVersion, string outputDir)
        {
            var tempSdkRoot = Path.Combine(Path.GetTempPath(), "slim-generator-" + Guid.NewGuid().ToString("N"));

            try
            {
                // 1. Compile customization fragments into a single file
                Console.Error.WriteLine("Compiling customizations...");
                var customizationsPath = CustomizationHelper.CompileCustomizations(serviceDirectory);

                // 2. Build ServiceConfiguration from model directory
                Console.Error.WriteLine("Loading service configuration...");
                var serviceConfig = ServiceConfigurationFactory.CreateFromModelDirectory(serviceDirectory, customizationsPath);

                // 3. Create minimal GenerationManifest (no external file dependencies)
                var defaultConfig = LoadDefaultConfiguration();
                var manifest = GenerationManifest.CreateMinimal(defaultConfig);

                // 4. Set up output directory structure expected by GeneratorDriver
                Directory.CreateDirectory(Path.Combine(tempSdkRoot, "src", "Services"));
                Directory.CreateDirectory(Path.Combine(tempSdkRoot, "test", "Services"));
                Directory.CreateDirectory(Path.Combine(tempSdkRoot, "code-analysis", "ServiceAnalysis"));

                var options = new GeneratorOptions
                {
                    SlimMode = true,
                    SdkRootFolder = tempSdkRoot,
                    Clean = false,
                    Verbose = false
                };

                // 5. Generate source code
                Console.Error.WriteLine($"Generating code for {serviceConfig.ClassName} (ServiceId: {serviceConfig.ServiceId})...");
                var driver = new GeneratorDriver(serviceConfig, manifest, options);
                driver.Execute();

                // 6. Compile into DLL
                var generatedRoot = Path.Combine(tempSdkRoot, "src", "Services", serviceConfig.ServiceFolderName);
                var dllName = $"AWSSDK." +
                    $"{serviceConfig.ServiceId.Replace(" ", "")}.dll";
                var outputDllPath = Path.Combine(outputDir, dllName);

                Console.Error.WriteLine($"Compiling {serviceConfig.ServiceFolderName}...");
                Compiler.Compile(generatedRoot, outputDllPath, coreVersion);

                return new GenerationResult
                {
                    ServiceId = serviceConfig.ServiceId,
                    DllPath = outputDllPath
                };
            }
            finally
            {
                Console.Error.WriteLine($"Generated files at: {tempSdkRoot}");
                // Uncomment to clean up: Directory.Delete(tempSdkRoot, true);
            }
        }

        static DefaultConfigurationModel LoadDefaultConfiguration()
        {
            var assembly = typeof(Program).Assembly;
            var resourceName = "SlimGenerator.sdk-default-configuration.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    return new DefaultConfigurationModel
                    {
                        Modes = new System.Collections.Generic.List<DefaultConfigurationMode>()
                    };
                }

                using (var reader = new StreamReader(stream))
                {
                    var parser = new DefaultConfigurationParser();
                    var model = parser.Parse(reader.ReadToEnd());
                    model.Modes.RemoveAll(m => string.Equals(m.Name, "legacy", StringComparison.OrdinalIgnoreCase));
                    return model;
                }
            }
        }
    }

    public class GenerationResult
    {
        public string ServiceId { get; set; }
        public string DllPath { get; set; }
    }
}
