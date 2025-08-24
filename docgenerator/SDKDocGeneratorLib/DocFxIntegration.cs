using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace SDKDocGenerator
{
    /// <summary>
    /// Handles integration with DocFX for generating modern documentation
    /// </summary>
    public class DocFxIntegration
    {
        private readonly GeneratorOptions _options;
        private readonly string _docfxConfigPath;

        public DocFxIntegration(GeneratorOptions options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _docfxConfigPath = Path.Combine(GetDocGeneratorRoot(), "docfx.json");
        }

        /// <summary>
        /// Gets the root directory of the doc generator
        /// </summary>
        /// <returns>The root directory path</returns>
        private string GetDocGeneratorRoot()
        {
            // Get the directory containing the current assembly
            var assemblyLocation = typeof(DocFxIntegration).Assembly.Location;
            var assemblyDir = Path.GetDirectoryName(assemblyLocation);
            
            // Navigate up to find the docgenerator directory
            var current = new DirectoryInfo(assemblyDir);
            while (current != null && !current.Name.Equals("docgenerator", StringComparison.OrdinalIgnoreCase))
            {
                current = current.Parent;
            }
            
            return current?.FullName ?? assemblyDir;
        }

        /// <summary>
        /// Downloads and sets up the DocFX Material theme
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public async Task<bool> SetupMaterialThemeAsync()
        {
            try
            {
                var docGeneratorRoot = GetDocGeneratorRoot();
                var templatesDir = Path.Combine(docGeneratorRoot, "templates");
                var materialThemeDir = Path.Combine(templatesDir, "material");

                // Create templates directory if it doesn't exist
                Directory.CreateDirectory(templatesDir);

                // Check if material theme already exists
                if (Directory.Exists(materialThemeDir))
                {
                    if (_options.Verbose)
                        Console.WriteLine("Material theme already exists, skipping download.");
                    return true;
                }

                if (_options.Verbose)
                    Console.WriteLine("Setting up DocFX Material theme...");

                // Clone the material theme repository
                var gitProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "git",
                        Arguments = $"clone https://github.com/ovasquez/docfx-material.git \"{materialThemeDir}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                gitProcess.Start();
                gitProcess.WaitForExit();

                if (gitProcess.ExitCode == 0)
                {
                    if (_options.Verbose)
                        Console.WriteLine("Material theme setup completed successfully.");
                    return true;
                }
                else
                {
                    var error = gitProcess.StandardError.ReadToEnd();
                    Console.WriteLine($"Failed to setup material theme: {error}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting up material theme: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Builds the documentation using DocFX
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public async Task<bool> BuildDocumentationAsync()
        {
            try
            {
                if (_options.Verbose)
                    Console.WriteLine("Building documentation with DocFX...");

                if (!File.Exists(_docfxConfigPath))
                {
                    Console.WriteLine($"DocFX configuration file not found at: {_docfxConfigPath}");
                    return false;
                }

                var docfxProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docfx",
                        Arguments = $"\"{_docfxConfigPath}\" --serve",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        WorkingDirectory = Path.GetDirectoryName(_docfxConfigPath)
                    }
                };

                docfxProcess.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data) && _options.Verbose)
                        Console.WriteLine($"DocFX: {e.Data}");
                };

                docfxProcess.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        Console.WriteLine($"DocFX Error: {e.Data}");
                };

                docfxProcess.Start();
                docfxProcess.BeginOutputReadLine();
                docfxProcess.BeginErrorReadLine();

                docfxProcess.WaitForExit();

                if (docfxProcess.ExitCode == 0)
                {
                    if (_options.Verbose)
                        Console.WriteLine("DocFX build completed successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"DocFX build failed with exit code: {docfxProcess.ExitCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error building documentation with DocFX: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Generates metadata for DocFX from SDK assemblies
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public async Task<bool> GenerateMetadataAsync()
        {
            try
            {
                if (_options.Verbose)
                    Console.WriteLine("Generating DocFX metadata...");

                var docfxProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docfx",
                        Arguments = $"metadata \"{_docfxConfigPath}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        WorkingDirectory = Path.GetDirectoryName(_docfxConfigPath)
                    }
                };

                docfxProcess.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data) && _options.Verbose)
                        Console.WriteLine($"DocFX Metadata: {e.Data}");
                };

                docfxProcess.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        Console.WriteLine($"DocFX Metadata Error: {e.Data}");
                };

                docfxProcess.Start();
                docfxProcess.BeginOutputReadLine();
                docfxProcess.BeginErrorReadLine();

                docfxProcess.WaitForExit();

                if (docfxProcess.ExitCode == 0)
                {
                    if (_options.Verbose)
                        Console.WriteLine("DocFX metadata generation completed successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"DocFX metadata generation failed with exit code: {docfxProcess.ExitCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating DocFX metadata: {ex.Message}");
                return false;
            }
        }
    }
}

