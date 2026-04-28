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

            // Find Core manifest first - we need to pre-load its documentation
            // because service types may inherit from Core types and need to look up
            // documentation for inherited members (e.g., ReadWriteTimeout on ClientConfig)
            foreach (var m in manifests)
            {
                if (m.ServiceName.Equals("Core", StringComparison.InvariantCultureIgnoreCase))
                {
                    coreManifest = m;
                    break;
                }
            }

            // Pre-load Core documentation for all platforms before generating service docs
            if (coreManifest != null)
            {
                coreManifest.PreloadDocumentation();
            }

            // Build platform availability maps for all services
            // This scans ALL platforms upfront and creates { memberSignature → Set<platforms> } maps
            // that are used for page generation decisions.
            var availablePlatforms = GetAvailablePlatforms();

            Info("Building platform availability maps for all services...");

            foreach (var manifest in manifests)
            {
                PlatformMap.PlatformAvailabilityMap map = null;
                try
                {
                    map = PlatformMap.PlatformMapBuilder.BuildMap(
                        manifest.ServiceName,
                        manifest.AssemblyName,
                        availablePlatforms,
                        Options.Platform,
                        Options.SDKAssembliesRoot,
                        Options.Verbose);

                    manifest.AttachPlatformMap(map);

                    if (Options.Verbose)
                    {
                        Info("  Built platform map for {0}: {1} members across {2} platforms ({3} restricted)",
                            manifest.ServiceName,
                            map.MemberCount,
                            map.AllPlatforms.Count,
                            map.PlatformRestrictedMemberCount);
                    }
                }
                catch (Exception ex)
                {
                    // Dispose the map if it was built but attachment failed (C2)
                    map?.Dispose();
                    // Log but don't fail entire generation if one service fails
                    Info("  WARNING: Failed to build platform map for {0}: {1}",
                        manifest.ServiceName, ex.Message);
                }
            }

            try
            {
                foreach (var m in manifests)
                {
                    if (m.ServiceName.Equals("Core", StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    m.Generate(deferredTypes, TOCWriter);
                }

                // now all service assemblies are processed, handle core plus any types in those assemblies that
                // we elected to defer until we processed core.
                if (coreManifest != null)
                {
                    coreManifest.ManifestAssemblyContext.SdkAssembly.DeferredTypesProvider = deferredTypes;
                    coreManifest.Generate(null, TOCWriter);
                }

                // Generate pages for platform-exclusive APIs (e.g., H2 methods only in net8.0)
                // The unified platform map already contains wrappers for exclusive members
                Info("Generating exclusive member pages from unified platform map...");

                // Re-load Core documentation before exclusive page generation.
                // Class pages may contain properties inherited from Core (e.g., ReadWriteTimeout).
                if (coreManifest != null)
                {
                    coreManifest.PreloadDocumentation();
                }

                // Process service manifests first, then Core.
                // Core is processed last because it may depend on deferred types
                // from service assemblies, and its exclusive members (e.g.,
                // ClientConfig.SetWebProxy(IWebProxy)) need page generation too.
                foreach (var manifest in manifests)
                {
                    if (manifest.ServiceName.Equals("Core", StringComparison.OrdinalIgnoreCase))
                        continue;

                    manifest.GenerateExclusivePagesFromMap(TOCWriter);
                }

                // Now process Core's exclusive members
                if (coreManifest != null)
                {
                    coreManifest.GenerateExclusivePagesFromMap(TOCWriter);
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
            }
            finally
            {
                // Dispose all platform maps to release assembly contexts (C1: ensures cleanup on exception)
                Info("Releasing platform map resources...");
                foreach (var manifest in manifests)
                {
                    manifest.DisposePlatformMap();
                }
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

        /// <summary>
        /// Returns the list of available platform folder names under the SDK assemblies root.
        /// </summary>
        private List<string> GetAvailablePlatforms()
        {
            var platformSubfolders = Directory.GetDirectories(Options.SDKAssembliesRoot, "*", SearchOption.TopDirectoryOnly);
            return platformSubfolders.Select(Path.GetFileName).ToList();
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
