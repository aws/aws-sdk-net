using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SDKDocGenerator.Writers;
using System.Diagnostics;

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

        /// <summary>
        /// Platforms to scan for APIs not present in the primary platform.
        /// This enables documentation of H2-only APIs that exist in modern frameworks.
        /// </summary>
        private static readonly string[] SupplementalPlatforms = { "net8.0" };

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
                Info("");
                Info("...SDKAssembliesRoot: {0}", Options.SDKAssembliesRoot);
                Info("...OutputFolder: {0}", Options.OutputFolder);
                Info("...Platform: {0}", Options.Platform);
                Info("...Services: {0}", string.Join(",", Options.Services));
                Info("...CodeSamplesRootFolder: {0}", Options.CodeSamplesRootFolder);
                Info("...ExampleMetaJson: {0}", Options.ExampleMetaJson);
                Info("...ExamplesErrorFile: {0}", Options.ExamplesErrorFile);
                Info("");
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

            // Generate the Code Examples fragments for all services            
            ExampleMetadataParser.GenerateExampleFragments(options.ExampleMetaJson, options.ExamplesErrorFile);

            // Process the service manifests
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

            // Process supplemental platforms for H2-only APIs
            var platformSubfolders = Directory.GetDirectories(Options.SDKAssembliesRoot, "*", SearchOption.TopDirectoryOnly);
            var availablePlatforms = platformSubfolders.Select(Path.GetFileName).ToList();
            var supplementalManifests = ConstructSupplementalManifests(manifests, availablePlatforms);

            foreach (var supManifest in supplementalManifests)
            {
                supManifest.GenerateSupplementalOnly(TOCWriter);
            }

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

            // Remove example fragments
            ExampleMetadataParser.CleanupExampleFragments();

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

        /// <summary>
        /// Constructs supplemental manifests for platforms that may contain APIs
        /// not present in the primary platform (e.g., H2 eventstream APIs in net8.0).
        /// </summary>
        private IList<GenerationManifest> ConstructSupplementalManifests(
            IList<GenerationManifest> primaryManifests,
            IEnumerable<string> availablePlatforms)
        {
            var supplementalManifests = new List<GenerationManifest>();

            Info("Discovering supplemental platforms for additional APIs...");

            foreach (var supPlatform in SupplementalPlatforms)
            {
                if (supPlatform.Equals(Options.Platform, StringComparison.OrdinalIgnoreCase))
                    continue; // Skip if supplemental is same as primary

                var supAssemblyPath = Path.Combine(Options.SDKAssembliesRoot, supPlatform);
                if (!Directory.Exists(supAssemblyPath))
                {
                    InfoVerbose("Supplemental platform folder not found: {0}", supAssemblyPath);
                    continue;
                }

                Info("Discovering supplemental assemblies in {0}", supAssemblyPath);

                foreach (var primary in primaryManifests)
                {
                    if (primary.ServiceName.Equals("Core", StringComparison.OrdinalIgnoreCase))
                        continue;

                    var supAssemblyFile = Path.Combine(supAssemblyPath, Path.GetFileName(primary.AssemblyPath));
                    if (!File.Exists(supAssemblyFile))
                        continue;

                    var supManifest = new GenerationManifest(
                        supAssemblyFile,
                        Options.ComputedContentFolder,
                        availablePlatforms,
                        Options,
                        primary);

                    if (supManifest.HasSupplementalMethods)
                    {
                        supplementalManifests.Add(supManifest);
                        Info("Found {0} supplemental method(s) in {1}/{2}",
                            supManifest.SupplementalMethodCount,
                            supPlatform,
                            Path.GetFileName(supAssemblyFile));
                    }
                }
            }

            Info("Found {0} assemblies with supplemental content", supplementalManifests.Count);
            return supplementalManifests;
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
