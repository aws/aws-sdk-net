using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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

        // Per-phase wall-clock timings, recorded via TimePhase, printed at the end of a run
        // so we can see where build time is actually spent before optimizing.
        private readonly List<KeyValuePair<string, TimeSpan>> _phaseTimings = new List<KeyValuePair<string, TimeSpan>>();

        // Per-service wall-clock for the (parallel) service-page generation phase. Lets us see which
        // services are the "long pole" once that phase dominates. ConcurrentBag is safe for the
        // parallel adds; we sort/print at the end.
        private readonly System.Collections.Concurrent.ConcurrentBag<KeyValuePair<string, TimeSpan>> _serviceTimings =
            new System.Collections.Concurrent.ConcurrentBag<KeyValuePair<string, TimeSpan>>();

        /// <summary>
        /// Times one service's page generation and records it for the end-of-run "slowest services"
        /// report. Wraps the call so the timing is captured whether the loop is serial or parallel.
        /// </summary>
        private void GenerateTimed(GenerationManifest manifest, DeferredTypesProvider deferredTypes, TOCWriter tocWriter, ConcurrencyGate gate)
        {
            var sw = Stopwatch.StartNew();
            try
            {
                manifest.Generate(deferredTypes, tocWriter, gate);
            }
            finally
            {
                sw.Stop();
                _serviceTimings.Add(new KeyValuePair<string, TimeSpan>(manifest.ServiceName, sw.Elapsed));
            }
        }

        /// <summary>
        /// Prints the slowest services in the service-page phase. When that phase dominates and is
        /// parallelized across services, the wall-clock is bounded by the single slowest service, so
        /// this identifies the next bottleneck (and the candidates for intra-service parallelism).
        /// </summary>
        private void PrintSlowestServices(int top = 15)
        {
            if (_serviceTimings.IsEmpty)
                return;

            var ordered = _serviceTimings.OrderByDescending(t => t.Value).Take(top).ToList();

            Console.WriteLine();
            Console.WriteLine("Slowest services (service-page generation):");
            foreach (var t in ordered)
                Console.WriteLine("  {0,-40} {1,8:N1}s", t.Key, t.Value.TotalSeconds);
            Console.WriteLine();
        }

        /// <summary>
        /// Times the supplied phase, recording its elapsed wall-clock time for the
        /// end-of-run breakdown printed by <see cref="PrintPhaseTimings"/>.
        /// </summary>
        private void TimePhase(string name, Action body)
        {
            var sw = Stopwatch.StartNew();
            try
            {
                body();
            }
            finally
            {
                sw.Stop();
                _phaseTimings.Add(new KeyValuePair<string, TimeSpan>(name, sw.Elapsed));
            }
        }

        /// <summary>
        /// Prints the per-phase wall-clock breakdown collected during the run.
        /// </summary>
        private void PrintPhaseTimings()
        {
            if (_phaseTimings.Count == 0)
                return;

            var total = TimeSpan.Zero;
            foreach (var p in _phaseTimings)
                total += p.Value;

            Console.WriteLine();
            Console.WriteLine("Phase timing breakdown:");
            foreach (var p in _phaseTimings)
            {
                var pct = total.TotalMilliseconds > 0 ? (p.Value.TotalMilliseconds / total.TotalMilliseconds) * 100.0 : 0.0;
                Console.WriteLine("  {0,-40} {1,8:N1}s  ({2,5:N1}%)", p.Key, p.Value.TotalSeconds, pct);
            }
            Console.WriteLine("  {0,-40} {1,8:N1}s", "TOTAL (sum of phases)", total.TotalSeconds);
            Console.WriteLine();
        }
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
            GenProfiler.Enabled = options.Profile;

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
            IList<GenerationManifest> manifests = null;
            TimePhase("Construct manifests", () => manifests = ConstructGenerationManifests());
            TOCWriter = new TOCWriter(options);

            GenerationManifest coreManifest = null;
            DeferredTypesProvider deferredTypes = new DeferredTypesProvider(null);

            // Generate the Code Examples fragments for all services
            TimePhase("Generate example fragments",
                () => ExampleMetadataParser.GenerateExampleFragments(options.ExampleMetaJson, options.ExamplesErrorFile));

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
                TimePhase("Preload Core documentation", () => coreManifest.PreloadDocumentation());
            }

            // Build platform availability maps for all services
            // This scans ALL platforms upfront and creates { memberSignature → Set<platforms> } maps
            // that are used for page generation decisions.
            var availablePlatforms = GetAvailablePlatforms();

            Info("Building platform availability maps for all services...");

            TimePhase("Build platform maps", () =>
            {
                // Building a service's platform map is independent of every other service (it loads
                // that service's assemblies and writes only to its own manifest), so this is safe to
                // parallelize when requested.
                Action<GenerationManifest> buildMapFor = manifest =>
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
                };

                var degree = Options.MaxDegreeOfParallelism;
                if (degree > 1)
                    Parallel.ForEach(OrderLargestFirst(manifests), new ParallelOptions { MaxDegreeOfParallelism = degree }, buildMapFor);
                else
                    foreach (var manifest in manifests)
                        buildMapFor(manifest);
            });

            // Single shared budget across the outer (service) and inner (namespace) loops, used for
            // the whole generation pass (services + Core). Each actively-generating thread holds
            // exactly one slot, so total concurrency never exceeds 'degree'. Null when running serial.
            ConcurrencyGate gate = null;
            if (Options.MaxDegreeOfParallelism > 1)
            {
                gate = new ConcurrencyGate(Options.MaxDegreeOfParallelism);

                // Give the ThreadPool plenty of warm threads. Generation nests up to three levels
                // (service -> namespace -> member), and a parent waiting on Task.WaitAll occupies a
                // pool thread while its gated children run, so we provision generously beyond the
                // degree to avoid the pool's slow ramp-up stalling progress.
                ThreadPool.GetMinThreads(out var minWorker, out var minIo);
                ThreadPool.SetMinThreads(Math.Max(minWorker, Options.MaxDegreeOfParallelism * 4), minIo);
            }

            try
            {
                TimePhase("Generate service pages", () =>
                {
                    var serviceManifests = manifests
                        .Where(m => !m.ServiceName.Equals("Core", StringComparison.InvariantCultureIgnoreCase))
                        .ToList();

                    var degree = Options.MaxDegreeOfParallelism;
                    if (degree > 1)
                    {
                        Info("Generating service pages in parallel (max degree {0})...", degree);

                        // The inner namespace fan-out (inside Generate) only borrows slots that are
                        // momentarily free - which happens in the tail of the run when a few huge
                        // services (e.g. EC2) are finishing while other cores would otherwise idle.
                        Parallel.ForEach(
                            OrderLargestFirst(serviceManifests),
                            new ParallelOptions { MaxDegreeOfParallelism = degree },
                            m =>
                            {
                                // Each service holds one slot for the duration of its own generation;
                                // its inner namespace loop may additionally borrow free slots.
                                gate.Acquire();
                                try
                                {
                                    GenerateTimed(m, deferredTypes, TOCWriter, gate);
                                }
                                finally
                                {
                                    gate.Release();
                                }
                            });
                    }
                    else
                    {
                        foreach (var m in serviceManifests)
                        {
                            GenerateTimed(m, deferredTypes, TOCWriter, gate: null);
                        }
                    }
                });

                // now all service assemblies are processed, handle core plus any types in those assemblies that
                // we elected to defer until we processed core.
                if (coreManifest != null)
                {
                    TimePhase("Generate Core pages", () =>
                    {
                        coreManifest.ManifestAssemblyContext.SdkAssembly.DeferredTypesProvider = deferredTypes;
                        // Core runs alone after the services join, so the whole budget is free for its
                        // namespaces to fan out across.
                        coreManifest.Generate(null, TOCWriter, gate);
                    });
                }

                // Generate pages for platform-exclusive APIs (e.g., H2 methods only in net8.0)
                // The unified platform map already contains wrappers for exclusive members
                Info("Generating exclusive member pages from unified platform map...");

                TimePhase("Generate exclusive pages", () =>
                {
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
                    var exclusiveServiceManifests = manifests
                        .Where(m => !m.ServiceName.Equals("Core", StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    var exclusiveDegree = Options.MaxDegreeOfParallelism;
                    if (exclusiveDegree > 1)
                        Parallel.ForEach(
                            OrderLargestFirst(exclusiveServiceManifests),
                            new ParallelOptions { MaxDegreeOfParallelism = exclusiveDegree },
                            m => m.GenerateExclusivePagesFromMap(TOCWriter));
                    else
                        foreach (var manifest in exclusiveServiceManifests)
                            manifest.GenerateExclusivePagesFromMap(TOCWriter);

                    // Now process Core's exclusive members (serial, after services join)
                    if (coreManifest != null)
                    {
                        coreManifest.GenerateExclusivePagesFromMap(TOCWriter);
                    }
                });

                Info("Generating table of contents entries...");
                TimePhase("Write TOC", () => TOCWriter.Write());

                TimePhase("Copy version + static content", () =>
                {
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
                });
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

            PrintPhaseTimings();
            PrintSlowestServices();
            GenProfiler.PrintReport();

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

        /// <summary>
        /// Orders manifests largest-first so the biggest services start at the front of a parallel
        /// run. This minimizes the "long pole" tail where one huge service finishes long after the
        /// worker pool would otherwise have drained. Assembly file size is a cheap, stable proxy for
        /// how much work a service represents and is available before platform maps are built.
        /// Ordering only affects scheduling, not output (pages are independent; the TOC is sorted).
        /// </summary>
        private static IEnumerable<GenerationManifest> OrderLargestFirst(IEnumerable<GenerationManifest> manifests)
        {
            return manifests
                .OrderByDescending(m =>
                {
                    try { return new FileInfo(m.AssemblyPath).Length; }
                    catch { return 0L; }
                })
                .ToList();
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
