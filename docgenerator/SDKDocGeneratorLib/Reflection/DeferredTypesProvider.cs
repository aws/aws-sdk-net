using System;
using System.Collections.Generic;

namespace SDKDocGenerator
{
    public class DeferredTypesProvider : AbstractTypeProvider
    {
        private readonly IDictionary<string, TypeWrapper> _typeDictionary = new Dictionary<string, TypeWrapper>();
        private readonly IDictionary<string, IList<TypeWrapper>> _namespaceToTypeNames = new Dictionary<string, IList<TypeWrapper>>();
        // A single DeferredTypesProvider instance is shared across all service manifests, which may
        // call AddTypes concurrently when generation is parallelized. Guards the collections below.
        // Deferred types are only consumed later (when Core is generated, after the parallel phase
        // joins), and output is per-file with a name-sorted TOC, so order of addition is irrelevant.
        private readonly object _deferredLock = new object();

        // Types implemented in service assemblies (such as AmazonS3Config) that exist in the namespaces below are output when we
        // process the awssdk.core manifest (which is done last), so they appear under the Amazon tree root in the docs. We
        // therefore collate these types and the parent assembly as we run, and will process them once we start to
        // process core.
        public readonly HashSet<string> Namespaces = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Amazon",
            "Amazon.Util",
            "Amazon.Runtime",
            "Amazon.Runtime.SharedInterfaces"
        };

        public DeferredTypesProvider(string docId)
            : base(docId)
        {
        }

        /// <summary>
        /// Registers a collection of types implemented in a service assembly to be processed
        /// when the doc set for awssdk.core.dll is generated.
        /// </summary>
        /// <param name="types"></param>
        public void AddTypes(IEnumerable<TypeWrapper> types)
        {
            lock (_deferredLock)
            {
                foreach (var type in types)
                {
                    IList<TypeWrapper> list;
                    if (_namespaceToTypeNames.TryGetValue(type.Namespace, out list))
                    {
                        list.Add(type);
                    }
                    else
                    {
                        _namespaceToTypeNames.Add(type.Namespace, new List<TypeWrapper> { type });
                    }

                    _typeDictionary[type.FullName] = type;
                }
            }
        }

        public override TypeWrapper GetType(string fullName)
        {
            TypeWrapper type;
            _typeDictionary.TryGetValue(fullName, out type);
            return type;
        }

        public override IEnumerable<TypeWrapper> GetTypes()
        {
            return _typeDictionary.Values;
        }

        public override IEnumerable<string> GetNamespaces()
        {
            return _namespaceToTypeNames.Keys;
        }

        public override IEnumerable<TypeWrapper> GetTypesForNamespace(string namespaceName)
        {
            IList<TypeWrapper> types;

            if (_namespaceToTypeNames.TryGetValue(namespaceName, out types))
            {
                return types;
            }
            else
            {
                return new List<TypeWrapper>();
            }
        }
    }
}
