using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SDKDocGenerator
{
    /// <summary>
    /// Represents a code example extracted from sample files
    /// </summary>
    public class CodeExample
    {
        public string MethodName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }

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
        /// Processes code samples and generates overwrite files for DocFX integration
        /// These overwrite files will inject code examples directly into API reference pages
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public bool ProcessCodeSamples()
        {
            try
            {
                Console.WriteLine("=== DEBUG: ProcessCodeSamples method called ===");
                Console.WriteLine("=== DEBUG: This should definitely show up ===");
                if (_options.Verbose)
                    Console.WriteLine("Processing code samples for DocFX integration...");

                var docGeneratorRoot = GetDocGeneratorRoot();
                var samplesPath = Path.Combine(docGeneratorRoot, "AWSSDKDocSamples");
                var overwritesPath = Path.Combine(docGeneratorRoot, "overwrites");
                
                if (!Directory.Exists(samplesPath))
                {
                    if (_options.Verbose)
                        Console.WriteLine("No code samples directory found, skipping samples integration.");
                    return true;
                }

                // Create overwrites directory if it doesn't exist
                if (!Directory.Exists(overwritesPath))
                {
                    Directory.CreateDirectory(overwritesPath);
                }

                // Process each service's samples
                foreach (var serviceDir in Directory.GetDirectories(samplesPath))
                {
                    var serviceName = Path.GetFileName(serviceDir);
                    ProcessServiceSamples(serviceDir, serviceName, overwritesPath);
                }

                if (_options.Verbose)
                    Console.WriteLine("Code samples processing completed successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing code samples: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Processes code samples for a specific service and generates overwrite files
        /// </summary>
        private void ProcessServiceSamples(string serviceDir, string serviceName, string overwritesPath)
        {
            try
            {
                // Look for .extra.xml files in the root samples directory
                var docGeneratorRoot = GetDocGeneratorRoot();
                var samplesRootPath = Path.Combine(docGeneratorRoot, "AWSSDKDocSamples");
                
                // Look for both service-specific .extra.xml files and the main service .extra.xml file
                var extraFiles = new List<string>();
                var serviceExtraFile = Path.Combine(samplesRootPath, $"{serviceName}.extra.xml");
                var serviceGeneratedExtraFile = Path.Combine(samplesRootPath, $"{serviceName}.GeneratedSamples.extra.xml");
                
                Console.WriteLine($"=== DEBUG: Looking for {serviceExtraFile} ===");
                Console.WriteLine($"=== DEBUG: Looking for {serviceGeneratedExtraFile} ===");
                
                if (File.Exists(serviceExtraFile))
                {
                    extraFiles.Add(serviceExtraFile);
                    Console.WriteLine($"=== DEBUG: Found {serviceExtraFile} ===");
                }
                if (File.Exists(serviceGeneratedExtraFile))
                {
                    extraFiles.Add(serviceGeneratedExtraFile);
                    Console.WriteLine($"=== DEBUG: Found {serviceGeneratedExtraFile} ===");
                }
                
                var codeFiles = Directory.GetFiles(serviceDir, "*.cs");

                if (!extraFiles.Any() || !codeFiles.Any())
                {
                    if (_options.Verbose)
                        Console.WriteLine($"No .extra.xml files or code files found for {serviceName}");
                    return;
                }

                if (_options.Verbose)
                    Console.WriteLine($"Processing samples for {serviceName}...");

                // Create overwrite files that will inject code examples into API reference pages
                CreateOverwriteFiles(serviceDir, serviceName, extraFiles.ToArray(), codeFiles, overwritesPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing samples for {serviceName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Creates overwrite files that will inject code examples directly into API reference pages
        /// </summary>
        private void CreateOverwriteFiles(string serviceDir, string serviceName, string[] extraFiles, string[] codeFiles, string overwritesPath)
        {
            try
            {
                // Process .extra.xml files to get member mappings and code regions
                foreach (var extraFile in extraFiles)
                {
                    if (_options.Verbose)
                        Console.WriteLine($"Processing extra file: {extraFile}");
                    
                    var extraDoc = System.Xml.Linq.XDocument.Load(extraFile);
                    var docs = extraDoc.Descendants("doc");
                    
                    Console.WriteLine($"=== DEBUG: Found {docs.Count()} doc elements in {extraFile} ===");
                    
                    foreach (var doc in docs)
                    {
                        var members = doc.Descendants("member");
                        var exampleNode = doc.Elements("value").FirstOrDefault()?.Elements("example").FirstOrDefault();
                        
                        Console.WriteLine($"=== DEBUG: Processing doc with {members.Count()} members, exampleNode: {(exampleNode != null ? "found" : "null")} ===");
                        
                        if (exampleNode != null)
                        {
                            var codeElement = exampleNode.Elements("code").FirstOrDefault();
                            if (codeElement != null)
                            {
                                var sourceFile = codeElement.Attribute("source")?.Value;
                                var regionName = codeElement.Attribute("region")?.Value;
                                var title = codeElement.Attribute("title")?.Value;
                                var description = exampleNode.Elements("para").FirstOrDefault()?.Value ?? "";
                                
                                if (!string.IsNullOrEmpty(sourceFile) && !string.IsNullOrEmpty(regionName))
                                {
                                    Console.WriteLine($"=== DEBUG: Processing sourceFile: {sourceFile}, region: {regionName} ===");
                                    
                                    // Extract code from the source file using the region
                                    var codeContent = ExtractCodeFromRegion(sourceFile, regionName);
                                    
                                    Console.WriteLine($"=== DEBUG: Code extraction result: {(string.IsNullOrEmpty(codeContent) ? "FAILED" : $"SUCCESS ({codeContent.Length} chars)")} ===");
                                    
                                    if (!string.IsNullOrEmpty(codeContent))
                                    {
                                        // Create overwrite files for each member
                                        foreach (var member in members)
                                        {
                                            var memberName = member.Attribute("name")?.Value;
                                            if (!string.IsNullOrEmpty(memberName))
                                            {
                                                // Create overwrite file with the exact member ID
                                                var overwriteFileName = $"{memberName.Replace(":", "_").Replace("(", "_").Replace(")", "_")}.overwrite.md";
                                                var overwritePath = Path.Combine(overwritesPath, overwriteFileName);
                                                
                                                var overwriteContent = new System.Text.StringBuilder();
                                                overwriteContent.AppendLine("## Code Example");
                                                if (!string.IsNullOrEmpty(title))
                                                    overwriteContent.AppendLine($"**{title}**");
                                                overwriteContent.AppendLine();
                                                overwriteContent.AppendLine(description);
                                                overwriteContent.AppendLine();
                                                overwriteContent.AppendLine("```csharp");
                                                overwriteContent.AppendLine(codeContent);
                                                overwriteContent.AppendLine("```");
                                                overwriteContent.AppendLine();
                                                
                                                // Add version information similar to the original documentation system
                                                AddVersionInformation(overwriteContent, memberName);
                                                
                                                File.WriteAllText(overwritePath, overwriteContent.ToString());
                                                
                                                if (_options.Verbose)
                                                    Console.WriteLine($"Created overwrite file: {overwritePath} for member {memberName}");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating overwrite files for {serviceName}: {ex.Message}");
                if (_options.Verbose)
                    Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Extracts code from a source file using a specific region name
        /// </summary>
        private string ExtractCodeFromRegion(string sourceFile, string regionName)
        {
            try
            {
                // Resolve the source file path relative to the current directory
                var resolvedPath = sourceFile;
                if (sourceFile.StartsWith(".\\"))
                {
                    var docGeneratorRoot = GetDocGeneratorRoot();
                    // Normalize path separators for cross-platform compatibility
                    var relativePath = sourceFile.Substring(2).Replace('\\', Path.DirectorySeparatorChar);
                    resolvedPath = Path.Combine(docGeneratorRoot, relativePath);
                }
                
                Console.WriteLine($"=== DEBUG: ExtractCodeFromRegion - sourceFile: {sourceFile}, resolvedPath: {resolvedPath} ===");
                Console.WriteLine($"=== DEBUG: File.Exists(resolvedPath): {File.Exists(resolvedPath)} ===");
                
                if (!File.Exists(resolvedPath))
                {
                    if (_options.Verbose)
                        Console.WriteLine($"Source file not found: {resolvedPath}");
                    return null;
                }
                
                var fileContent = File.ReadAllText(resolvedPath);
                var lines = fileContent.Split('\n');
                
                Console.WriteLine($"=== DEBUG: File read successfully, {lines.Length} lines found ===");
                
                var regionLinesFound = new List<string>();
                var inRegion = false;
                var codeLines = new List<string>();
                
                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    
                    if (line.Trim().StartsWith("#region"))
                    {
                        regionLinesFound.Add($"Line {i}: {line.Trim()}");
                        
                        // Check if this is the region we're looking for
                        if (line.Contains(regionName))
                        {
                            inRegion = true;
                            continue;
                        }
                    }
                    
                    if (line.Trim().StartsWith("#endregion"))
                    {
                        if (inRegion)
                        {
                            break;
                        }
                    }
                    
                    if (inRegion)
                    {
                        codeLines.Add(line);
                    }
                }
                
                if (_options.Verbose)
                {
                    Console.WriteLine($"=== DEBUG: Total regions found: {regionLinesFound.Count} ===");
                }
                
                return string.Join("\n", codeLines).Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting code from region {regionName} in {sourceFile}: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Extracts a code region between #region and #endregion markers
        /// </summary>
        private string ExtractCodeRegion(string[] lines, int startIndex)
        {
            var codeLines = new List<string>();
            bool inRegion = false;
            
            for (int i = startIndex; i < lines.Length; i++)
            {
                var line = lines[i];
                
                if (line.Trim().StartsWith("#region"))
                {
                    inRegion = true;
                    continue;
                }
                
                if (line.Trim().StartsWith("#endregion"))
                {
                    break;
                }
                
                if (inRegion)
                {
                    // Remove excessive indentation
                    var trimmedLine = line.Length > 12 ? line.Substring(12) : line;
                    codeLines.Add(trimmedLine);
                }
            }
            
            return string.Join("\n", codeLines).Trim();
        }

        /// <summary>
        /// Extracts method name from region identifier
        /// </summary>
        private string ExtractMethodNameFromRegion(string regionName)
        {
            // Region names are like: to-create-a-configuration-profile-1632264580336
            // Extract the descriptive part before the timestamp
            var parts = regionName.Split('-');
            if (parts.Length > 2)
            {
                // Skip "to" prefix and timestamp suffix, join the middle parts
                var meaningfulParts = parts.Skip(1).TakeWhile(p => !char.IsDigit(p[0])).ToArray();
                return string.Join(" ", meaningfulParts);
            }
            return regionName;
        }

        /// <summary>
        /// Formats method name for display
        /// </summary>
        private string FormatMethodName(string methodName)
        {
            return string.Join(" ", methodName.Split(' ').Select(word => 
                char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }

        /// <summary>
        /// Adds version information to the overwrite content, based on the original system's logic
        /// </summary>
        private void AddVersionInformation(System.Text.StringBuilder content, string memberName)
        {
            content.AppendLine("## Version Information");
            content.AppendLine();

            // For DocFX, we'll assume all members are available on all current platforms
            // since we don't have easy access to the platform-specific documentation here.
            // This matches the "boolNoDocs = true" case in the original system.
            
            // .NET Core / .NET
            var netAppVersions = new List<string> { "8.0 and newer", "Core 3.1" };
            content.AppendLine($"**.NET:**  ");
            content.AppendLine($"Supported in: {string.Join(", ", netAppVersions)}  ");
            content.AppendLine();

            // .NET Standard
            var netstandardVersions = new List<string> { "2.0" };
            content.AppendLine($"**.NET Standard:**  ");
            content.AppendLine($"Supported in: {string.Join(", ", netstandardVersions)}  ");
            content.AppendLine();

            // .NET Framework
            var netframeworkVersions = new List<string> { "4.7.2 and newer" };
            content.AppendLine($"**.NET Framework:**  ");
            content.AppendLine($"Supported in: {string.Join(", ", netframeworkVersions)}  ");
            content.AppendLine();
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


