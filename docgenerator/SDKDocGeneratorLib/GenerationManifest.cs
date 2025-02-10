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
                    _manifestAssemblyWrapper = new ManifestAssemblyWrapper(ServiceName, Options.Platform, AssemblyPath);
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

            public ManifestAssemblyWrapper(string serviceName, string platform, string assemblyPath)
            {
                var docId = NDocUtilities.GenerateDocId(serviceName, platform);
                SdkAssembly = new AssemblyWrapper(docId);
                SdkAssembly.LoadAssembly(assemblyPath);
            }

            #region IDisposable Support
            private bool _disposedValue; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposedValue)
                {
                    if (disposing)
                    {
                        // unlink roots, then drop the domain if we used one
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
