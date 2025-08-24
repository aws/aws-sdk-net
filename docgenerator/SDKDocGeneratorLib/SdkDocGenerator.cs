using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SDKDocGenerator.Writers;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SDKDocGenerator
{
    /// <summary>
    /// Documentation generator for the AWS SDK for .NET v4+ codebase.
    /// </summary>
    public class SdkDocGenerator
    {
        private long? _startTimeTicks;
        // These may be packaged in the assemblies folder for non-NuGet users,
        // but shouldn't appear in the SDK's API reference
        private static readonly IEnumerable<string> _assembliesToSkip = new HashSet<string> 
        { 
            "AWSSDK.Extensions.CrtIntegration.dll",
            "AWSSDK.Extensions.NETCore.Setup.dll",
            "AWSSDK.Extensions.CloudFront.Signers.dll",
            "AWSSDK.Extensions.EC2.DecryptPassword.dll",
            "AWSSDK.Extensions.Bedrock.MEAI"
        };

        public GeneratorOptions Options { get; private set; }
        
        /// <summary>
        /// How long the documentation generation took.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                if (!_startTimeTicks.HasValue)
                    throw new InvalidOperationException("Execute(...) method has not been called, no run duration data available");

                return new TimeSpan(DateTime.Now.Ticks - _startTimeTicks.Value);
            }
        }

        /// <summary>
        /// Manages the individual namespace tocs and consolidates them all into
        /// a single tree on the conclusion of processing.
        /// </summary>
        public TOCWriter TOCWriter { get; private set; }

        /// <summary>
        /// Runs the doc generator to produce or update a consistent documentation
        /// set for the SDK.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>0 on successful completion</returns>
        public int Execute(GeneratorOptions options)
        {
            return ExecuteAsync(options).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Async version of Execute method
        /// </summary>
        /// <param name="options"></param>
        /// <returns>0 on successful completion</returns>
        public async Task<int> ExecuteAsync(GeneratorOptions options)
        {
            // this is just to record the run duration, so we can monitor and optimize 
            // build-time perf
            _startTimeTicks = DateTime.Now.Ticks;

            Options = options;

            Trace.Listeners.Add(new ConditionalConsoleTraceListener(Options.Verbose));

            if (Options.TestMode)
                SetOptionsForTestMode();

            if (string.IsNullOrEmpty(Options.SDKAssembliesRoot))
            {
                Info("ERROR: SDKAssembliesRoot option not set");
                return -1;
            }

            if (Options.Verbose)
            {
                Info("Starting generation with options:");
                Info("...TestMode: {0}", Options.TestMode);
                Info("...Clean: {0}", Options.Clean);
                Info("...WriteStaticContent: {0}", Options.WriteStaticContent);
                Info("...WaitOnExit: {0}", Options.WaitOnExit);
                Info("...UseDocFx: {0}", Options.UseDocFx);
                Info("");
                Info("...SDKAssembliesRoot: {0}", Options.SDKAssembliesRoot);
                Info("...OutputFolder: {0}", Options.OutputFolder);
                Info("...Platform: {0}", Options.Platform);
                Info("...Services: {0}", string.Join(",", Options.Services));
                Info("...CodeSamplesRootFolder: {0}", Options.CodeSamplesRootFolder);
                Info("");
            }

            // If using DocFX, delegate to the new DocFX-based generation
            if (Options.UseDocFx)
            {
                return await ExecuteDocFxGenerationAsync();
            }

            if (options.Clean)
                FileUtilties.CleanFolder(options.OutputFolder, true);

            if (!Directory.Exists(options.OutputFolder))
                Directory.CreateDirectory(options.OutputFolder);

            // use the sdk root and primary platform to determine the set of
            // service manifests to process
            var manifests = ConstructGenerationManifests();
            TOCWriter = new TOCWriter(options);

            GenerationManifest coreManifest = null;
            DeferredTypesProvider deferredTypes = new DeferredTypesProvider(null);

            foreach (var m in manifests)
            {
                if (m.ServiceName.Equals("Core", StringComparison.InvariantCultureIgnoreCase))
                {
                    coreManifest = m;
                    continue;
                }

                m.Generate(deferredTypes, TOCWriter);
            }

            // now all service assemblies are processed, handle core plus any types in those assemblies that 
            // we elected to defer until we processed core.
            coreManifest.ManifestAssemblyContext.SdkAssembly.DeferredTypesProvider = deferredTypes;
            coreManifest.Generate(null, TOCWriter);

            Info("Generating table of contents entries...");
            TOCWriter.Write();

            CopyVersionInfoManifest();

            if (options.WriteStaticContent)
            {
                Info("Generating/copying static content:");
                Info("...creating landing page");
                var lpWriter = new LandingPageWriter(options);
                lpWriter.Write();

                Info("...copying static resources");
                var sourceLocation = Directory.GetParent(typeof(SdkDocGenerator).Assembly.Location).FullName;
                FileUtilties.FolderCopy(Path.Combine(sourceLocation, "output-files"), options.OutputFolder, true);
            }

            // Write out all the redirect rules for doc cross-linking.
            using (Stream stream = File.Open(Path.Combine(options.OutputFolder, SDKDocRedirectWriter.RedirectFileName), FileMode.Create))
            {
                SDKDocRedirectWriter.Write(stream);
            }

            return 0;
        }

        /// <summary>
        /// Sets the generation options so as to perform a limited generation pass on one
        /// platform and a handul of assemblies to allow verification of doc generator changes.
        /// </summary>
        private void SetOptionsForTestMode()
        {
            Info("Revising command line options to limited set for test mode:");

            Options.WaitOnExit = true;
            Options.Verbose = true;

            if (string.IsNullOrEmpty(Options.SDKAssembliesRoot))
                Options.SDKAssembliesRoot = @"..\..\..\..\deployment\assemblies";

            Options.Services = new[]
            {
                "Core",
                "DynamoDBv2",
                "S3",
                "EC2"
            };

            Info("...sdkassembliesroot set to '{0}'", Options.SDKAssembliesRoot);
            Info("...platform set to '{0}'", Options.Platform);
            Info("...services set to {0}", string.Join(",", Options.Services));
            Info("");
        }

        /// <summary>
        /// Copies the json file containing the version information for each SDK assembly
        /// (by service) into the output docs folder.
        /// </summary>
        private void CopyVersionInfoManifest()
        {
            Info("Copying version information manifest...");

            if (File.Exists(Options.SDKVersionFilePath))
            {
                var destPath = Path.Combine(Options.ComputedContentFolder, Path.GetFileName(Options.SDKVersionFilePath));
                File.Copy(Options.SDKVersionFilePath, destPath, true);
            }
            else
            {
                throw new Exception($"Failed to find version file at {Options.SDKVersionFilePath}.");
            }
        }

        /// <summary>
        /// Enumerates the assembly, folder and platform settings in the options
        /// to construct a per-service manifest that we will then process. Our preferred
        /// documentation source is for the 'net472' platform but if a subfolder does
        /// not exist under the root for this platform, we'll generate using the
        /// assemblies in the first subfolder we find.
        /// </summary>
        /// <remarks>
        /// Currently we only construct manifests for the assemblies we find in the
        /// preferred or first platform subfolder. Distinct assemblies that exist
        /// outside this folder do not get included.
        /// </remarks>
        /// <returns>Collections of service manifests to process</returns>
        private IList<GenerationManifest> ConstructGenerationManifests()
        {
            var platformSubfolders = Directory.GetDirectories(Options.SDKAssembliesRoot, "*", SearchOption.TopDirectoryOnly);
            var availablePlatforms = platformSubfolders.Select(Path.GetFileName).ToList();

            if (!availablePlatforms.Any(ap => ap.Equals(Options.Platform, StringComparison.OrdinalIgnoreCase)))
            {
                Info("Warning: selected platform '{0}' is not available, switching to '{1}' for assembly discovery.", 
                                  Options.Platform,
                                  availablePlatforms[0]);
                Options.Platform = availablePlatforms[0];
            }

            var manifests = new List<GenerationManifest>();

            // discover the matching service/core assemblies in the selected platform folder and
            // construct a processing manifest for each
            var assemblySourcePath = Path.Combine(Options.SDKAssembliesRoot, Options.Platform);
            if (Options.Verbose)
                Info("Discovering assemblies in {0}", assemblySourcePath);

            foreach (var service in Options.Services)
            {
                var namePattern = $"{GenerationManifest.AWSAssemblyNamePrefix}.{service}.dll";
                var assemblies = Directory.GetFiles(assemblySourcePath, namePattern);
                foreach (var assembly in assemblies)
                {
                    if (_assembliesToSkip.Any(toSkip => assembly.Contains(toSkip)))
                    {
                        continue;
                    }
                    // keep items as the root for content, but a further subfolder of the root namespace
                    // will be added for the artifacts
                    var artifactManifest = new GenerationManifest(assembly, Options.ComputedContentFolder, availablePlatforms, Options);
                    manifests.Add(artifactManifest);
                }
            }

            return manifests;
        }

        private void Info(string message)
        {
            Trace.WriteLine(message);
            Trace.Flush();
        }

        private void Info(string format, params object[] args)
        {
            Trace.WriteLine(string.Format(format, args));
            Trace.Flush();
        }

        private void InfoVerbose(string message)
        {
            Trace.WriteLine(message, "Verbose");
            Trace.Flush();
        }

        private void InfoVerbose(string format, params object[] args)
        {
            Trace.WriteLine(String.Format(format, args), "Verbose");
            Trace.Flush();
        }

        /// <summary>
        /// Executes documentation generation using DocFX with Material theme
        /// </summary>
        /// <returns>0 on successful completion</returns>
        private async Task<int> ExecuteDocFxGenerationAsync()
        {
            try
            {
                Info("Starting DocFX-based documentation generation...");
                
                var docfxIntegration = new DocFxIntegration(Options);
                
                // Setup material theme
                Info("Setting up DocFX Material theme...");
                var themeSetup = await docfxIntegration.SetupMaterialThemeAsync();
                if (!themeSetup)
                {
                    Info("Failed to setup Material theme, but continuing...");
                }

                // Process code samples
                Info("Processing code samples...");
                var samplesProcessed = docfxIntegration.ProcessCodeSamples();
                if (!samplesProcessed)
                {
                    Info("Failed to process code samples, but continuing...");
                }

                // Update DocFX configuration with current SDK assemblies path
                Info("Updating DocFX configuration...");
                await UpdateDocFxConfigurationAsync();

                // Generate metadata from assemblies
                Info("Generating metadata from SDK assemblies...");
                var metadataGenerated = await docfxIntegration.GenerateMetadataAsync();
                if (!metadataGenerated)
                {
                    Info("ERROR: Failed to generate DocFX metadata");
                    return -1;
                }

                // Build documentation
                Info("Building documentation with DocFX...");
                var buildSuccess = await docfxIntegration.BuildDocumentationAsync();
                if (!buildSuccess)
                {
                    Info("ERROR: Failed to build documentation with DocFX");
                    return -1;
                }

                Info("DocFX documentation generation completed successfully!");
                return 0;
            }
            catch (Exception ex)
            {
                Info("ERROR: Exception during DocFX generation: {0}", ex.Message);
                if (Options.Verbose)
                    Info("Stack trace: {0}", ex.StackTrace);
                return -1;
            }
        }

        /// <summary>
        /// Updates the DocFX configuration file with current options
        /// </summary>
        private async Task UpdateDocFxConfigurationAsync()
        {
            try
            {
                var docGeneratorRoot = GetDocGeneratorRoot();
                var docfxConfigPath = Path.Combine(docGeneratorRoot, "docfx.json");
                
                if (!File.Exists(docfxConfigPath))
                {
                    Info("DocFX configuration file not found, using default");
                    return;
                }

                // Read current configuration
                var configContent = File.ReadAllText(docfxConfigPath);
                
                // Update the source paths to point to the current SDK assemblies
                var platformPath = Path.Combine(Options.SDKAssembliesRoot, Options.Platform);
                var relativePath = GetRelativePath(docGeneratorRoot, platformPath);
                
                // Simple string replacement for the source path
                // In a production scenario, you'd want to use a JSON parser
                configContent = configContent.Replace(
                    "\"src\": \"../sdk/src/Core/bin/Release/net472\"",
                    $"\"src\": \"{relativePath.Replace('\\', '/')}\""
                );
                
                // Update output path if specified
                if (!string.IsNullOrEmpty(Options.OutputFolder))
                {
                    var outputRelativePath = GetRelativePath(docGeneratorRoot, Options.OutputFolder);
                    configContent = configContent.Replace(
                        "\"dest\": \"../Deployment/docs\"",
                        $"\"dest\": \"{outputRelativePath.Replace('\\', '/')}\""
                    );
                }

                File.WriteAllText(docfxConfigPath, configContent);
                
                if (Options.Verbose)
                    Info("Updated DocFX configuration with current options");
            }
            catch (Exception ex)
            {
                Info("Warning: Failed to update DocFX configuration: {0}", ex.Message);
            }
        }

        /// <summary>
        /// Gets the root directory of the doc generator
        /// </summary>
        private string GetDocGeneratorRoot()
        {
            var assemblyLocation = typeof(SdkDocGenerator).Assembly.Location;
            var assemblyDir = Path.GetDirectoryName(assemblyLocation);
            
            var current = new DirectoryInfo(assemblyDir);
            while (current != null && !current.Name.Equals("docgenerator", StringComparison.OrdinalIgnoreCase))
            {
                current = current.Parent;
            }
            
            return current?.FullName ?? assemblyDir;
        }

        /// <summary>
        /// Gets a relative path from one directory to another (compatibility method for .NET Standard 2.0)
        /// </summary>
        private string GetRelativePath(string fromPath, string toPath)
        {
            if (string.IsNullOrEmpty(fromPath) || string.IsNullOrEmpty(toPath))
                return toPath;

            var fromUri = new Uri(fromPath.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar);
            var toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme)
                return toPath; // Different schemes, can't make relative

            var relativeUri = fromUri.MakeRelativeUri(toUri);
            var relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            if (toUri.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
            {
                relativePath = relativePath.Replace('/', Path.DirectorySeparatorChar);
            }

            return relativePath;
        }
    }

    public class ConditionalConsoleTraceListener : TraceListener
    {
        private readonly bool _verboseOption;

        public ConditionalConsoleTraceListener(bool verbose)
        {
            this._verboseOption = verbose;
        }

        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public override void WriteLine(string message, string category)
        {
            if (_verboseOption)
            {
                Console.WriteLine($"[{category}]: {message}");
            }
        }
    }
}
