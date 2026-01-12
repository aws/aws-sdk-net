using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
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
        /// Creates a supplemental manifest for a different platform assembly. This is used to
        /// discover and document APIs that exist only in supplemental platforms (like net8.0)
        /// but not in the primary platform (like net472).
        /// </summary>
        /// <param name="assemblyPath">Path to the supplemental platform assembly</param>
        /// <param name="outputFolderRoot">Root output folder</param>
        /// <param name="allPlatforms">All available platforms</param>
        /// <param name="options">Generator options</param>
        /// <param name="primaryManifest">The primary platform manifest to compare against</param>
        public GenerationManifest(string assemblyPath,
                                  string outputFolderRoot,
                                  IEnumerable<string> allPlatforms,
                                  GeneratorOptions options,
                                  GenerationManifest primaryManifest)
            : this(assemblyPath, outputFolderRoot, allPlatforms, options)
        {
            IsSupplemental = true;
            PrimaryManifest = primaryManifest;
            IdentifySupplementalMethods();

            if (Options.Verbose)
            {
                Trace.WriteLine($"\t...IsSupplemental: {IsSupplemental}");
                Trace.WriteLine($"\t...SupplementalMethodCount: {SupplementalMethodCount}");
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
        /// True if this is a supplemental manifest (for discovering APIs not in the primary platform).
        /// </summary>
        public bool IsSupplemental { get; }

        /// <summary>
        /// For supplemental manifests, the primary manifest to compare against for method discovery.
        /// </summary>
        public GenerationManifest PrimaryManifest { get; }

        /// <summary>
        /// Dictionary mapping type full names to lists of methods that exist only in the
        /// supplemental platform. The key is the full name of a type that exists in both
        /// platforms, and the value is the list of methods on that type that only exist
        /// in the supplemental platform.
        /// </summary>
        private Dictionary<string, List<MethodInfoWrapper>> _supplementalMethods;

        /// <summary>
        /// Returns true if this supplemental manifest contains methods not present in the primary platform.
        /// </summary>
        public bool HasSupplementalMethods => _supplementalMethods?.Any() == true;

        /// <summary>
        /// Gets the dictionary of supplemental methods by type full name.
        /// </summary>
        public IReadOnlyDictionary<string, List<MethodInfoWrapper>> SupplementalMethods =>
            _supplementalMethods ?? new Dictionary<string, List<MethodInfoWrapper>>();

        /// <summary>
        /// Returns the total count of supplemental methods across all types.
        /// </summary>
        public int SupplementalMethodCount =>
            _supplementalMethods?.Values.Sum(list => list.Count) ?? 0;

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
                    // Use isolated context for supplemental manifests to avoid
                    // "Assembly with same name is already loaded" errors when loading
                    // assemblies from different platforms (e.g., net472 and net8.0)
                    _manifestAssemblyWrapper = new ManifestAssemblyWrapper(
                        ServiceName,
                        Options.Platform,
                        AssemblyPath,
                        useIsolatedContext: IsSupplemental);
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
        public void Generate(DeferredTypesProvider deferrableTypes, TOCWriter tocWriter)
        {
            Trace.WriteLine($"\tgenerating from {Options.Platform}/{Path.GetFileName(AssemblyPath)}");

            // load the assembly and ndoc dataset for the service we're about to generate; assuming
            // they contain no deferrable types we'll release them when done
            var discardAssemblyOnExit = true;

            foreach (var platform in AllPlatforms)
            {
                NDocUtilities.LoadDocumentation(AssemblyName, ServiceName, platform, Options);
            }

            var namespaceNames = ManifestAssemblyContext.SdkAssembly.GetNamespaces();

            var frameworkVersion = FrameworkVersion.FromPlatformFolder(Options.Platform);
            var processed = 0;

            foreach (var namespaceName in namespaceNames)
            {
                // when processing awssdk.core, we don't get handed a collection to hold
                // deferrable types
                if (deferrableTypes != null)
                {
                    if (deferrableTypes.Namespaces.Contains(namespaceName))
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
                }

                WriteNamespace(frameworkVersion, namespaceName);
                tocWriter.BuildNamespaceToc(namespaceName, ManifestAssemblyContext.SdkAssembly);

                Trace.WriteLine($"\t\t{namespaceName} processed ({++processed} of {namespaceNames.Count()})");
            }

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
        /// Identifies methods that exist in the supplemental platform but not in the primary platform.
        /// This handles the case where types exist in both platforms but have different methods
        /// (e.g., H2 eventstream client methods like InvokeModelWithBidirectionalStreamAsync).
        /// </summary>
        private void IdentifySupplementalMethods()
        {
            _supplementalMethods = new Dictionary<string, List<MethodInfoWrapper>>();

            if (PrimaryManifest?.ManifestAssemblyContext?.SdkAssembly == null)
            {
                return;
            }

            // For each type in the supplemental assembly
            foreach (var supplementalType in ManifestAssemblyContext.SdkAssembly.GetTypes())
            {
                // Find the corresponding type in the primary assembly
                var primaryType = PrimaryManifest.ManifestAssemblyContext.SdkAssembly.GetType(supplementalType.FullName);
                if (primaryType == null)
                {
                    // Type doesn't exist in primary - skip (this would be handled separately if needed)
                    continue;
                }

                // Get method signatures from the primary type
                var primaryMethodSignatures = new HashSet<string>(
                    primaryType.GetMethodsToDocument().Select(m => GetMethodSignature(m)));

                // Find methods in the supplemental type that don't exist in primary
                var supplementalMethodsForType = new List<MethodInfoWrapper>();
                foreach (var method in supplementalType.GetMethodsToDocument())
                {
                    var signature = GetMethodSignature(method);
                    if (!primaryMethodSignatures.Contains(signature))
                    {
                        supplementalMethodsForType.Add(method);
                        if (Options.Verbose)
                        {
                            Trace.WriteLine($"\t\tFound supplemental method: {supplementalType.FullName}.{method.Name}");
                        }
                    }
                }

                if (supplementalMethodsForType.Any())
                {
                    _supplementalMethods[supplementalType.FullName] = supplementalMethodsForType;
                }
            }
        }

        /// <summary>
        /// Generates a unique signature for a method based on its name and parameter types.
        /// This is used to compare methods between platforms and identify supplemental methods.
        /// </summary>
        private static string GetMethodSignature(MethodInfoWrapper method)
        {
            var parameters = string.Join(",", method.GetParameters().Select(p => p.ParameterType.FullName ?? p.ParameterType.Name));
            return $"{method.Name}({parameters})";
        }

        /// <summary>
        /// Generates documentation only for supplemental methods (methods not present in the primary platform).
        /// This is used for APIs like H2 eventstream that only exist in modern frameworks.
        /// </summary>
        /// <param name="tocWriter">TOC generation handler</param>
        public void GenerateSupplementalOnly(TOCWriter tocWriter)
        {
            if (!HasSupplementalMethods)
            {
                Trace.WriteLine($"\tNo supplemental methods found in {Options.Platform}/{Path.GetFileName(AssemblyPath)}");
                return;
            }

            Trace.WriteLine($"\tgenerating supplemental content from {Options.Platform}/{Path.GetFileName(AssemblyPath)} (0 types, {SupplementalMethodCount} methods)");

            // Load NDoc documentation for all platforms
            foreach (var platform in AllPlatforms)
            {
                NDocUtilities.LoadDocumentation(AssemblyName, ServiceName, platform, Options);
            }

            var frameworkVersion = FrameworkVersion.FromPlatformFolder(Options.Platform);

            Trace.WriteLine($"\t\tProcessing {SupplementalMethodCount} supplemental methods across {_supplementalMethods.Count} types");

            foreach (var kvp in _supplementalMethods)
            {
                var typeFullName = kvp.Key;
                var methods = kvp.Value;

                // Get the supplemental type that contains these methods
                var supplementalType = ManifestAssemblyContext.SdkAssembly.GetType(typeFullName);
                if (supplementalType == null)
                {
                    Trace.WriteLine($"\t\tWarning: Could not find type {typeFullName} for supplemental methods");
                    continue;
                }

                // Generate individual method pages for each supplemental method
                foreach (var method in methods)
                {
                    // Only write if the method is declared in this type's namespace
                    if (method.DeclaringType.Namespace == supplementalType.Namespace)
                    {
                        var methodWriter = new MethodWriter(this, frameworkVersion, method);
                        methodWriter.Write();
                        Trace.WriteLine($"\t\t\tGenerated method page: {supplementalType.Name}.{method.Name}");
                    }
                }

                // Regenerate the class page to include supplemental methods
                // IMPORTANT: Use the PRIMARY type from net472 as the base - it has ALL methods including sync methods.
                // The supplemental type (net8.0) is missing sync methods since they're net472-only.
                var primaryType = PrimaryManifest.ManifestAssemblyContext.SdkAssembly.GetType(typeFullName);
                if (primaryType == null)
                {
                    Trace.WriteLine($"\t\tWarning: Could not find primary type {typeFullName} for class page regeneration");
                    continue;
                }

                // Use PrimaryManifest to write the class page - ensures correct assembly context for XML docs
                var classWriter = new ClassWriter(PrimaryManifest, frameworkVersion, primaryType, methods);
                classWriter.Write();
                Trace.WriteLine($"\t\t\tRegenerated class page: {primaryType.Name} with {methods.Count} supplemental methods (base: primary platform)");
            }

            // Cleanup
            foreach (var platform in AllPlatforms)
            {
                NDocUtilities.UnloadDocumentation(ServiceName, platform);
            }

            ManifestAssemblyContext.Dispose();
            ManifestAssemblyContext = null;
        }

        void WriteNamespace(FrameworkVersion version, string namespaceName)
        {
            var writer = new NamespaceWriter(this, version, namespaceName);
            writer.Write();

            foreach (var type in ManifestAssemblyContext.SdkAssembly.GetTypesForNamespace(namespaceName))
            {
                WriteType(version, type);
            }
        }

        void WriteType(FrameworkVersion version, TypeWrapper type)
        {
            var writer = new ClassWriter(this, version, type);
            writer.Write();

            foreach (var item in type.GetConstructors().Where(x => x.IsPublic))
            {
                var itemWriter = new ConstructorWriter(this, version, item);
                itemWriter.Write();
            }

            foreach (var item in type.GetMethodsToDocument())
            {
                // If a method is in another namespace, it is inherited and should not be overwritten
                if (item.DeclaringType.Namespace == type.Namespace)
                {
                    var itemWriter = new MethodWriter(this, version, item);
                    itemWriter.Write();
                }
            }

            foreach (var item in type.GetEvents())
            {
                // If an event is in another namespace, it is inherited and should not be overwritten
                if (item.DeclaringType.Namespace == type.Namespace)
                {
                    var itemWriter = new EventWriter(this, version, item);
                    itemWriter.Write();
                }
            }
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
