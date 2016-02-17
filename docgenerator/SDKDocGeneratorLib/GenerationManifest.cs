using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using SDKDocGenerator.Writers;
using System.Diagnostics;

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
        public const string PreferredPlatform = "net45";

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
                                  GeneratorOptions options,
                                  bool useAppDomain)
        {
            AssemblyPath = Path.GetFullPath(assemblyPath);
            Options = options;
            AssemblyWrapper = CreateAssemblyWrapper(AssemblyPath, useAppDomain);

            OutputFolder = Path.GetFullPath(outputFolderRoot);

            var assemblyName = Path.GetFileNameWithoutExtension(AssemblyPath);
            ServiceName = assemblyName.StartsWith(AWSAssemblyNamePrefix + ".", StringComparison.OrdinalIgnoreCase)
                ? assemblyName.Substring(AWSAssemblyNamePrefix.Length + 1)
                : assemblyName;

            NDocTables = new Dictionary<string, IDictionary<string, XElement>>();

            var ndocFilename = assemblyName + ".xml";
            foreach (var p in allPlatforms)
            {
                var platformSpecificNdocFile = Path.Combine(Options.SDKAssembliesRoot, p, ndocFilename);
                if (File.Exists(platformSpecificNdocFile))
                {
                    var platformNDoc = CreateNDocTable(platformSpecificNdocFile);
                    NDocTables.Add(p, platformNDoc);
                }
            }

            if (Options.Verbose)
            {
                Trace.WriteLine("\tConstructed GenerationManifest:");
                Trace.WriteLine(String.Format("\t...AssemblyPath: {0}", AssemblyPath));
                Trace.WriteLine(String.Format("\t...ServiceName: {0}", ServiceName));
                Trace.WriteLine(String.Format("\t...OutputFolder: {0}", OutputFolder));
            }
        }

        /// <summary>
        /// The path and filename to the assembly represented by this set of artifacts
        /// </summary>
        public string AssemblyPath { get; private set; }

        /// <summary>
        /// The root output folder; the artifacts will be placed under
        /// here in their top-level namespace subfolders (less the Amazon. 
        /// part). So Amazon.DynamoDBv2.* types get emitted to 'dynamodbv2'
        /// underneath this root.
        /// </summary>
        public string OutputFolder { get; private set; }

        /// <summary>
        /// The generation options specified by the user
        /// </summary>
        public GeneratorOptions Options { get; private set; }

        /// <summary>
        /// Wrapper around the assembly we're generating docs for.
        /// </summary>
        public AssemblyWrapper AssemblyWrapper { get; private set; }

        /// <summary>
        /// The collection of ndoc tables, one per platform we discover.
        /// </summary>
        public IDictionary<string, IDictionary<string, XElement>> NDocTables { get; private set; }

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
                return NDocTables[Options.Platform];

            if (NDocTables.ContainsKey(platform))
                return NDocTables[platform];

            return null;
        }

        /// <summary>
        /// The logical name of the service. This is assumed to exist
        /// in the assembly name after 'awssdk.' and before the extension.
        /// </summary>
        public string ServiceName { get; private set; }

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
        /// down through the type hierarchy.
        /// </summary>
        public void Generate()
        {
            Trace.WriteLine(String.Format("\tgenerating from {0}/{1}", Options.Platform, Path.GetFileName(AssemblyPath)));

            var namespaceNames = AssemblyWrapper.GetNamespaces();

            var frameworkVersion = FrameworkVersion.FromPlatformFolder(Options.Platform);
            var processed = 0;
            foreach (var namespaceName in namespaceNames)
            {
                WriteNamespace(frameworkVersion, namespaceName);
                Trace.WriteLine(String.Format("\t\t{0} processed ({1} of {2})", namespaceName, ++processed, namespaceNames.Count()));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="useAppDomain"></param>
        /// <returns></returns>
        private AssemblyWrapper CreateAssemblyWrapper(string filePath, bool useAppDomain)
        {
            if (useAppDomain)
            {
                var domain = AppDomain.CreateDomain(filePath);
                var inst = domain.CreateInstance(this.GetType().Assembly.FullName, typeof(AssemblyWrapper).FullName);
                var wrapper = (AssemblyWrapper)inst.Unwrap();
                wrapper.LoadAssembly(filePath);
                return wrapper;
            }
            else
            {
                var wrapper = new AssemblyWrapper();
                wrapper.LoadAssembly(filePath);
                return wrapper;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private IDictionary<string, XElement> CreateNDocTable(string filePath)
        {
            var dict = new Dictionary<string, XElement>();
            var document = NDocUtilities.LoadAssemblyDocumentationWithSamples(filePath, Options.CodeSamplesRootFolder, ServiceName);
            NDocUtilities.PreprocessCodeBlocksToPreTags(Options, document);

            foreach (var element in document.XPathSelectElements("//members/member"))
            {
                var xattribute = element.Attributes().FirstOrDefault(x => x.Name.LocalName == "name");
                if (xattribute == null)
                    continue;

                dict[xattribute.Value] = element;
            }

            return dict;
        }

        void WriteNamespace(FrameworkVersion version, string namespaceName)
        {
            var writer = new NamespaceWriter(this, version, namespaceName);
            writer.Write();

            foreach (var type in AssemblyWrapper.GetTypesForNamespace(namespaceName))
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
    }
}
