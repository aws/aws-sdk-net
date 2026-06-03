using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using SDKDocGenerator.PlatformMap;
using SDKDocGenerator.Writers;
using System.Diagnostics;
using System.Reflection;

namespace SDKDocGenerator
{
    /// <summary>
    /// Wraps the generation information required to emit documentation for
    /// a service, which may have assemblies in all or some of the platforms
    /// subfolders.
    /// </summary>
    public class GenerationManifest
    {
        /// <summary>
        /// The expected naming pattern of AWS generated assemblies is 'awssdk.*.dll' with
        /// the variable part being the service name (long or short form).
        /// </summary>
        public const string AWSAssemblyNamePrefix = "AWSSDK";

        /// <summary>
        /// The preferred platform against which we generate documentation, if it's available.
        /// </summary>
        public const string PreferredPlatform = "net472";

        // The only non-preferred platform whose parsed XML doc is still consumed during generation:
        // MethodWriter reads it to detect whether a method has an async (CancellationToken) variant.
        // (Platform *availability* is sourced from the assembly-based PlatformAvailabilityMap, not XML,
        // so netstandard2.0 / net8.0 docs are never read - we must not waste time parsing them.)
        private const string AsyncProbePlatform = "netcoreapp3.1";

        /// <summary>
        /// Represents a single service, supported on one or more platforms, that we will be
        /// generating documentation for.
        /// </summary>
        /// <param name="assemblyPath">
        /// The full path and filename of the assembly. The .Net platform for the assembly
        /// is assumed to be the name of the folder containing the assembly. The name of the
        /// service will be inferred from the name pattern of the assembly.
        /// </param>
        /// <param name="outputFolderRoot">
        /// The root output folder that the artifacts should be placed in. A further subfolder
        /// representing the service (or 'core' if the assembly is the runtime) is added.
        /// </param>
        /// <param name="allPlatforms">The set of platform subfolders to use to discover ndoc tables</param>
        /// <param name="options">The user options governing doc generation</param>
        /// <param name="useAppDomain"></param>
        public GenerationManifest(string assemblyPath,
                                  string outputFolderRoot,
                                  IEnumerable<string> allPlatforms,
                                  GeneratorOptions options)
        {
            AssemblyPath = Path.GetFullPath(assemblyPath);
            AssemblyName = Path.GetFileNameWithoutExtension(AssemblyPath);

            ServiceName = AssemblyName.StartsWith(AWSAssemblyNamePrefix + ".", StringComparison.OrdinalIgnoreCase)
                ? AssemblyName.Substring(AWSAssemblyNamePrefix.Length + 1)
                : AssemblyName;            

            Options = options;
            OutputFolder = Path.GetFullPath(outputFolderRoot);
            AllPlatforms = allPlatforms;

            if (Options.Verbose)
            {
                Trace.WriteLine("\tConstructed GenerationManifest:");
                Trace.WriteLine($"\t...AssemblyPath: {AssemblyPath}");
                Trace.WriteLine($"\t...ServiceName: {ServiceName}");
                Trace.WriteLine($"\t...OutputFolder: {OutputFolder}");
            }
        }

        /// <summary>
        /// The path and filename to the assembly represented by this set of artifacts
        /// </summary>
        public string AssemblyPath { get; }

        /// <summary>
        /// The basename of the sdk assembly we're generating docs for, less extension.
        /// </summary>
        public string AssemblyName { get; }

        public IEnumerable<string> AllPlatforms { get; }

        /// <summary>
        /// The root output folder; the artifacts will be placed under
        /// here in their top-level namespace subfolders (less the Amazon. 
        /// part). So Amazon.DynamoDBv2.* types get emitted to 'dynamodbv2'
        /// underneath this root.
        /// </summary>
        public string OutputFolder { get; }

        /// <summary>
        /// The generation options specified by the user
        /// </summary>
        public GeneratorOptions Options { get; }

        /// <summary>
        /// Platform availability map for this service.
        /// Built once during initialization, used for page generation decisions
        /// throughout documentation generation.
        /// </summary>
        public PlatformMap.PlatformAvailabilityMap PlatformMap { get; private set; }

        // The shared concurrency budget for this generation pass (null when running serially). Set at
        // the start of Generate() and used to opportunistically parallelize both the namespace loop
        // and the per-type member loops without exceeding the global degree.
        private ConcurrencyGate _gate;

        /// <summary>
        /// Attaches a platform availability map to this manifest.
        /// Should only be called once during initialization.
        /// </summary>
        public void AttachPlatformMap(PlatformMap.PlatformAvailabilityMap map)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));

            if (PlatformMap != null)
                throw new InvalidOperationException("PlatformMap has already been attached");

            if (!map.ServiceName.Equals(ServiceName, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException($"Map service name '{map.ServiceName}' doesn't match manifest service name '{ServiceName}'");

            PlatformMap = map;
        }

        /// <summary>
        /// Returns the discovered NDoc table for a given platform, if it existed. If platform
        /// is not specified, we attempt to return the NDoc for the primary platform specified
        /// in the generator options.
        /// </summary>
        /// <param name="platform"></param>
        /// <returns></returns>
        public IDictionary<string, XElement> NDocForPlatform(string platform = null)
        {
            if (string.IsNullOrEmpty(platform))
            {
                platform = Options.Platform;
            }
            return NDocUtilities.GetDocumentationInstance(ServiceName, platform);
        }

        /// <summary>
        /// The logical name of the service. This is assumed to exist
        /// in the assembly name after 'awssdk.' and before the extension.
        /// </summary>
        public string ServiceName { get; }

        private ManifestAssemblyWrapper _manifestAssemblyWrapper;
        /// <summary>
        /// Contains the wrapped sdk assembly and the app domain we loaded it
        /// into, if so configured. Dispose of this when processing of the
        /// assembly is complete if the assembly contained no types that need
        /// deferred processing alongside the core sdk assembly.
        /// </summary>
        public ManifestAssemblyWrapper ManifestAssemblyContext
        {
            get
            {
                if (_manifestAssemblyWrapper == null)
                {
                    _manifestAssemblyWrapper = new ManifestAssemblyWrapper(
                        ServiceName,
                        Options.Platform,
                        AssemblyPath,
                        useIsolatedContext: true);
                }

                return _manifestAssemblyWrapper;
            }
            private set
            {
                if (value == null)
                {
                    _manifestAssemblyWrapper?.Dispose();
                }
                _manifestAssemblyWrapper = value;
            }
        }

        /// <summary>
        /// Returns the subfolder name that should be used for Amazon artifacts
        /// belonging to the specified namespace. Typically we use the service 
        /// root level (the second part) in the namespace. If the namespace is
        /// not recognized as belonging to Amazon, an empty string is returned.
        /// </summary>
        /// <param name="ns">The namespace of a discovered type (Amazon or 3rd party)</param>
        /// <returns></returns>
        public static string OutputSubFolderFromNamespace(string ns)
        {
            if (ns.IndexOf('.') == -1)
                return ns;

            if (!ns.StartsWith("Amazon."))
                return string.Empty;

            var nsParts = ns.Split('.');
            string nsPart;
            switch (nsParts.Length)
            {
                case 0:
                    nsPart = ns;
                    break;
                case 1:
                    nsPart = nsParts[0];
                    break;
                default:
                    nsPart = nsParts[1];
                    break;
            }

            if (FilenameGenerator.ServiceNamespaceContractions.ContainsKey(nsPart))
                return FilenameGenerator.ServiceNamespaceContractions[nsPart];

            return nsPart;
        }

        /// <summary>
        /// Pre-loads XML documentation for all platforms without generating pages.
        /// This is used to ensure Core documentation is available when service types
        /// inherit from Core types and need to look up inherited member documentation.
        /// </summary>
        public void PreloadDocumentation()
        {
            Trace.WriteLine($"\tpre-loading documentation for {ServiceName}");
            LoadDocumentationForAllPlatforms();
        }

        /// <summary>
        /// Parses and caches the XML documentation for every platform of this service. Each platform's
        /// XML file is large and independent, and the underlying cache (NDocUtilities._ndocCache) is a
        /// ConcurrentDictionary keyed by a per-(service, platform) docId, so the parses run in parallel.
        /// This matters because the parse sits on the critical path at the start of Generate (before the
        /// namespace fan-out) - serializing 4 multi-MB XML parses there was a measurable bottleneck for
        /// large services like EC2.
        /// </summary>
        /// <summary>
        /// Parses and caches only the NDoc XML docs this manifest actually reads:
        ///   - the preferred platform (all page content, keyed on Options.Platform);
        ///   - the async-probe platform (MethodWriter's async-variant detection);
        ///   - any platform contributing platform-exclusive members, whose docs are surfaced on
        ///     class pages (and the exclusive method pages) and exist only in that platform's XML.
        ///
        /// The remaining platforms' XML was historically loaded for AddVersionInformation, but that
        /// now derives availability from the assembly-based PlatformAvailabilityMap. Parsing those
        /// large XML files - the single biggest CPU cost in the run - is dead work, so we skip them.
        /// For the common service with no exclusive members this loads just 2 of the 4 platforms.
        /// </summary>
        private void LoadDocumentationForAllPlatforms()
        {
            var needed = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                Options.Platform,
                AsyncProbePlatform
            };

            // Exclusive members (and their docs) live only in their own platform's XML; include those.
            if (PlatformMap != null)
            {
                foreach (var platform in PlatformMap.GetPlatformsWithExclusiveMembers())
                    needed.Add(platform);
            }

            var platforms = AllPlatforms.Where(needed.Contains).ToList();

            if (platforms.Count <= 1)
            {
                foreach (var platform in platforms)
                    NDocUtilities.LoadDocumentation(AssemblyName, ServiceName, platform, Options);
                return;
            }

            Parallel.ForEach(platforms, platform =>
                NDocUtilities.LoadDocumentation(AssemblyName, ServiceName, platform, Options));
        }

        /// <summary>
        /// Generates the documentation for the artifacts represented by this
        /// manifest, starting at the namespace(s) in the assembly and working
        /// down through the type hierarchy. Types that exist in the deferable
        /// namespaces will be processed later in generation, when the awssdk.core
        /// assembly is processed.
        /// </summary>
        /// <param name="deferrableTypes">
        /// Collection for types in service assemblies that we want to defer processing
        /// on until we process awssdk.core.
        /// </param>
        /// <param name="tocWriter">
        /// Toc generation handler to which each processed namespace is registered
        /// </param>
        public void Generate(DeferredTypesProvider deferrableTypes, TOCWriter tocWriter, ConcurrencyGate gate = null)
        {
            _gate = gate;
            Trace.WriteLine($"\tgenerating from {Options.Platform}/{Path.GetFileName(AssemblyPath)}");

            // load the assembly and ndoc dataset for the service we're about to generate; assuming
            // they contain no deferrable types we'll release them when done
            var discardAssemblyOnExit = true;

            LoadDocumentationForAllPlatforms();

            var namespaceNames = ManifestAssemblyContext.SdkAssembly.GetNamespaces();

            var frameworkVersion = FrameworkVersion.FromPlatformFolder(Options.Platform);

            // Serial pre-pass: handle deferred namespaces (Core-only) and collect the namespaces we
            // will actually write. This stays serial because it mutates discardAssemblyOnExit and
            // feeds the shared DeferredTypesProvider; it's cheap (no page writes).
            var namespacesToWrite = new List<string>();
            foreach (var namespaceName in namespaceNames)
            {
                if (deferrableTypes != null && deferrableTypes.Namespaces.Contains(namespaceName))
                {
                    var types = ManifestAssemblyContext.SdkAssembly.GetTypesForNamespace(namespaceName);
                    if (types.Any())
                    {
                        Trace.WriteLine($"\t\tdeferring processing of types in namespace {namespaceName} for {Path.GetFileName(AssemblyPath)}");
                        deferrableTypes.AddTypes(types);
                        discardAssemblyOnExit = false;
                    }
                    continue;
                }

                namespacesToWrite.Add(namespaceName);
            }

            // Generate each namespace's pages. Namespaces within a service are independent (each owns
            // its own shared type wrappers; cross-references create fresh wrappers), and WriteNamespace
            // + BuildNamespaceToc only touch already-thread-safe shared state, so this is safe to run
            // concurrently. We only borrow spare slots from the shared budget so we never oversubscribe.
            ProcessNamespaces(namespacesToWrite, frameworkVersion, tocWriter, gate);

            // Don't discard if this manifest has exclusive members that need page generation
            if (PlatformMap?.ExclusiveMemberCount > 0)
                discardAssemblyOnExit = false;

            if (discardAssemblyOnExit)
            {
                // release artifact roots for future GC collections to operate on
                foreach (var platform in AllPlatforms)
                {
                    NDocUtilities.UnloadDocumentation(ServiceName, platform);
                }

                ManifestAssemblyContext.Dispose();
                ManifestAssemblyContext = null;
            }
        }

        /// <summary>
        /// Writes the pages + TOC entry for each namespace. Runs serially when no concurrency gate is
        /// supplied. When a gate is supplied, each namespace tries to borrow a spare slot from the
        /// shared budget and run on a worker thread; if no slot is free it is processed inline on the
        /// current thread. Borrowing-or-inline guarantees forward progress (no deadlock) and means the
        /// extra parallelism only materializes when cores would otherwise be idle (the run's tail).
        /// </summary>
        private void ProcessNamespaces(IList<string> namespacesToWrite, FrameworkVersion frameworkVersion, TOCWriter tocWriter, ConcurrencyGate gate)
        {
            RunGated(namespacesToWrite, ns => WriteNamespaceAndToc(frameworkVersion, ns, tocWriter));
        }

        /// <summary>
        /// Runs <paramref name="action"/> over each item. When the shared concurrency gate has a spare
        /// slot, the item runs on a worker thread (slot released on completion); otherwise it runs
        /// inline on the current thread. Borrow-or-inline guarantees forward progress (no deadlock) and
        /// caps total concurrency at the global degree, so the extra fan-out only appears when cores
        /// would otherwise be idle (e.g. the run's tail, where one huge service/type is finishing).
        /// Used for both the namespace loop and the per-type member loops.
        /// </summary>
        private void RunGated<T>(IList<T> items, Action<T> action)
        {
            if (_gate == null || items.Count <= 1)
            {
                foreach (var item in items)
                    action(item);
                return;
            }

            var tasks = new List<Task>();
            foreach (var item in items)
            {
                var captured = item;
                if (_gate.TryAcquire())
                {
                    tasks.Add(Task.Run(() =>
                    {
                        try { action(captured); }
                        finally { _gate.Release(); }
                    }));
                }
                else
                {
                    action(captured);
                }
            }

            if (tasks.Count > 0)
                Task.WaitAll(tasks.ToArray());
        }

        private void WriteNamespaceAndToc(FrameworkVersion frameworkVersion, string namespaceName, TOCWriter tocWriter)
        {
            WriteNamespace(frameworkVersion, namespaceName);
            tocWriter.BuildNamespaceToc(namespaceName, ManifestAssemblyContext.SdkAssembly);
            Trace.WriteLine($"\t\t{namespaceName} processed");
        }

        /// <summary>
        /// Generates individual method pages for platform-exclusive methods.
        /// Class pages already include exclusive methods (assembled during WriteType()),
        /// so this method only creates the per-method detail pages.
        ///
        /// Uses MethodInfoWrapper instances stored in the map during the initial scan,
        /// so no assemblies need to be reloaded.
        /// </summary>
        /// <param name="tocWriter">TOC generation handler</param>
        public void GenerateExclusivePagesFromMap(TOCWriter tocWriter)
        {
            if (PlatformMap == null)
            {
                if (Options.Verbose)
                    Trace.WriteLine($"\tNo platform map available for {ServiceName}, skipping exclusive page generation");
                return;
            }

            // Get types that have exclusive members
            var typesWithExclusive = PlatformMap.GetTypesWithExclusiveMembers().ToList();
            if (!typesWithExclusive.Any())
            {
                if (Options.Verbose)
                    Trace.WriteLine($"\tNo exclusive members found for {ServiceName}");
                return;
            }

            var exclusiveCount = PlatformMap.ExclusiveMemberCount;
            Trace.WriteLine($"\tgenerating exclusive method pages from unified map for {ServiceName} ({exclusiveCount} methods across {typesWithExclusive.Count} types)");

            LoadDocumentationForAllPlatforms();

            var frameworkVersion = FrameworkVersion.FromPlatformFolder(Options.Platform);

            try
            {
                foreach (var typeFullName in typesWithExclusive)
                {
                    // Get all exclusive methods for this type from the map
                    var exclusiveMethods = PlatformMap.GetExclusiveMethodsForType(typeFullName).ToList();

                    if (!exclusiveMethods.Any())
                        continue;

                    // Get the primary type for class page regeneration
                    var primaryType = ManifestAssemblyContext.SdkAssembly.GetType(typeFullName);
                    if (primaryType == null)
                    {
                        if (Options.Verbose)
                            Trace.WriteLine($"\t\tWarning: Could not find primary type {typeFullName} for exclusive methods");
                        continue;
                    }

                    // Generate individual method pages for each exclusive method
                    // The wrappers are already valid because assemblies are kept loaded in the map
                    // Class pages are already generated with exclusive methods included during WriteType()
                    foreach (var method in exclusiveMethods)
                    {
                        // Only write if the method is declared in this type's namespace
                        if (method.DeclaringType.Namespace == primaryType.Namespace)
                        {
                            var methodWriter = new MethodWriter(this, frameworkVersion, method);
                            methodWriter.Write();
                            if (Options.Verbose)
                                Trace.WriteLine($"\t\t\tGenerated exclusive method page: {primaryType.Name}.{method.Name}");
                        }
                    }
                }
            }
            finally
            {
                // NDoc lifecycle: We intentionally do NOT unload NDoc documentation here.
                // Unlike Generate() which owns its NDoc lifecycle per-manifest,
                // GenerateExclusivePagesFromMap() runs after all manifests have generated.
                // NDoc tables are shared across manifests and cleaned up globally by the
                // caller (SdkDocGenerator.Execute) at the end of the generation pass.
            }
        }

        /// <summary>
        /// Disposes the platform map, releasing all loaded assembly contexts.
        /// The reference is kept so that post-disposal calls receive
        /// <see cref="ObjectDisposedException"/> rather than a null reference.
        /// </summary>
        public void DisposePlatformMap()
        {
            PlatformMap?.Dispose();
        }

        void WriteNamespace(FrameworkVersion version, string namespaceName)
        {
            var writer = new NamespaceWriter(this, version, namespaceName);
            writer.Write();

            // Fan the per-type work across spare gate slots. This is the dominant tail cost: a few
            // services are overwhelmingly concentrated in a single namespace (e.g. EC2's
            // Amazon.EC2.Model has ~5,000 types), so when such a service is the last one running, a
            // serial type loop here pins it to one core while the rest idle. Each WriteType is
            // independent (writes its own files; shared-file cases are guarded write-once), so it is
            // safe to gate. Borrow-or-inline keeps total concurrency capped at the global degree.
            var types = ManifestAssemblyContext.SdkAssembly.GetTypesForNamespace(namespaceName).ToList();
            RunGated(types, type => WriteType(version, type));
        }

        void WriteType(FrameworkVersion version, TypeWrapper type)
        {
            // Assemble complete method list: primary platform + any platform-exclusive methods
            var methods = type.GetMethodsToDocument().ToList();
            var exclusive = PlatformMap?.GetExclusiveMethodsForType(type.FullName);
            if (exclusive != null)
            {
                var existingSigs = new HashSet<string>(
                    methods.Select(m => MemberSignature.ForMethod(m)));
                foreach (var m in exclusive)
                {
                    if (!existingSigs.Contains(MemberSignature.ForMethod(m)))
                        methods.Add(m);
                }
            }

            var writer = new ClassWriter(this, version, type, methods);
            writer.Write();

            // The per-member pages are independent of one another (each writes its own file and only
            // reads the now-thread-safe shared wrappers + caches), so we emit them through the shared
            // gate. This is the dominant cost for "mega" types like AmazonEC2Client (~1,788 methods),
            // which can now fan their method pages across idle cores in the tail of a run.
            var constructorItems = type.GetConstructors().Where(x => x.IsPublic).ToList();
            RunGated(constructorItems, item => new ConstructorWriter(this, version, item).Write());

            // If a member is in another namespace, it is inherited and should not be overwritten.
            var methodItems = type.GetMethodsToDocument()
                .Where(item => item.DeclaringType.Namespace == type.Namespace)
                .ToList();
            RunGated(methodItems, item => new MethodWriter(this, version, item).Write());

            var eventItems = type.GetEvents()
                .Where(item => item.DeclaringType.Namespace == type.Namespace)
                .ToList();
            RunGated(eventItems, item => new EventWriter(this, version, item).Write());
        }

        public class ManifestAssemblyWrapper : IDisposable
        {
            public AssemblyWrapper SdkAssembly { get; private set; }
            public AppDomain Domain { get; private set; }

            /// <summary>
            /// Creates a manifest assembly wrapper for loading an SDK assembly.
            /// </summary>
            /// <param name="serviceName">The service name for documentation ID generation.</param>
            /// <param name="platform">The platform identifier (e.g., "net472", "net8.0").</param>
            /// <param name="assemblyPath">The path to the assembly file.</param>
            /// <param name="useIsolatedContext">
            /// If true, loads the assembly in an isolated AssemblyLoadContext. This should be
            /// used for supplemental platform assemblies to avoid conflicts when the primary
            /// platform assembly with the same name is already loaded.
            /// </param>
            public ManifestAssemblyWrapper(string serviceName, string platform, string assemblyPath, bool useIsolatedContext = false)
            {
                var docId = NDocUtilities.GenerateDocId(serviceName, platform);
                SdkAssembly = new AssemblyWrapper(docId);
                SdkAssembly.LoadAssembly(assemblyPath, useIsolatedContext);
            }

            #region IDisposable Support
            private bool _disposedValue; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposedValue)
                {
                    if (disposing)
                    {
                        // Unload the assembly (including isolated context if used)
                        SdkAssembly?.Unload();
                        SdkAssembly = null;
                        if (Domain != null)
                        {
                            AppDomain.Unload(Domain);
                            Domain = null;
                        }
                    }

                    _disposedValue = true;
                }
            }

            public void Dispose()
            {
                // we have no finalizer and/or unmanaged resources, so no need to use GC.SuppressFinalize()
                Dispose(true);
            }
            #endregion
        }
    }
}
