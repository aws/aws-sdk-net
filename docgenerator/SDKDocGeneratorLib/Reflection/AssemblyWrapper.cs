using System.Collections.Generic;
using System.Reflection;

namespace SDKDocGenerator
{
    public class AssemblyWrapper : AbstractTypeProvider
    {
        Assembly _assembly;
        IList<TypeWrapper> _allTypes;
        IDictionary<string, TypeWrapper> _typesByFullName;
        IDictionary<string, IList<TypeWrapper>> _typesByNamespace;
        AbstractTypeProvider _deferredTypesProvider;
        IsolatedAssemblyLoadContext _isolatedContext;

        public AssemblyWrapper(string docId)
            : base(docId)
        {
        }

        /// <summary>
        /// Loads the assembly from the specified path.
        /// </summary>
        /// <param name="path">The path to the assembly file.</param>
        /// <param name="useIsolatedContext">
        /// If true, loads the assembly in an isolated AssemblyLoadContext to avoid
        /// conflicts when loading multiple versions of the same assembly.
        /// </param>
        public void LoadAssembly(string path, bool useIsolatedContext = false)
        {
            GenProfiler.Measure(GenProfiler.Reflection, () =>
            {
            if (useIsolatedContext)
            {
                _isolatedContext = new IsolatedAssemblyLoadContext(path);
                _assembly = _isolatedContext.LoadFromAssemblyPath(path);
            }
            else
            {
                _assembly = Assembly.LoadFrom(path);
            }

            _allTypes = new List<TypeWrapper>();
            _typesByNamespace = new Dictionary<string, IList<TypeWrapper>>();
            _typesByFullName = new Dictionary<string, TypeWrapper>();

            foreach (var type in this._assembly.GetTypes())
            {
                if (type.Namespace == null ||
                    !type.Namespace.StartsWith("Amazon") ||
                    type.Namespace.Contains(".Internal"))
                {
                    continue;
                }

                if (type.IsNested)
                {
                    if (type.IsVisible)
                    {
                        // nested + visible = publicly-accessible
                    }
                    else if (type.IsNestedFamily)
                    {
                        // nested + nested family = protected class inside a public class
                    }
                    else
                    {
                        continue;
                    }
                }
                else // not-nested
                {
                    if (!type.IsPublic)
                        continue;
                }

                var wrapper = new TypeWrapper(type, DocId);

                _typesByFullName[wrapper.FullName] = wrapper;
                _allTypes.Add(wrapper);

                IList<TypeWrapper> namespaceTypes;
                if (!this._typesByNamespace.TryGetValue(wrapper.Namespace, out namespaceTypes))
                {
                    namespaceTypes = new List<TypeWrapper>();
                    _typesByNamespace[wrapper.Namespace] = namespaceTypes;
                }
                namespaceTypes.Add(wrapper);
            }
            });
        }

        public string AssemblyVersion
        {
            get { return this._assembly.GetName().Version.ToString(); }
        }

        public AbstractTypeProvider DeferredTypesProvider
        {
            get { return _deferredTypesProvider; }
            set { _deferredTypesProvider = value; }
        }

        public override TypeWrapper GetType(string name)
        {
            TypeWrapper wrapper;
            if (!this._typesByFullName.TryGetValue(name, out wrapper))
            {
                if (_deferredTypesProvider != null)
                {
                    return _deferredTypesProvider.GetType(name);
                }
                return null;
            }

            return wrapper;
        }

        public override IEnumerable<TypeWrapper> GetTypes()
        {
            var types = new HashSet<TypeWrapper>(this._allTypes);

            if (_deferredTypesProvider != null)
            {
                types.UnionWith(_deferredTypesProvider.GetTypes());
            }
            return types;
        }

        public override IEnumerable<string> GetNamespaces()
        {
             var namespaces = new HashSet<string>(this._typesByNamespace.Keys);

            if (_deferredTypesProvider != null)
            {
                namespaces.UnionWith(_deferredTypesProvider.GetNamespaces());
            }

            return namespaces;
        }

        public override IEnumerable<TypeWrapper> GetTypesForNamespace(string namespaceName)
        {
            HashSet<TypeWrapper> typeSet = new HashSet<TypeWrapper>();
            IList<TypeWrapper> namespaceTypes;
            if (this._typesByNamespace.TryGetValue(namespaceName, out namespaceTypes))
            {
                typeSet.UnionWith(namespaceTypes);
            }

            if(_deferredTypesProvider != null)
            {
                typeSet.UnionWith(_deferredTypesProvider.GetTypesForNamespace(namespaceName));
            }

            return typeSet;
        }

        public override string ToString()
        {
            return this._assembly.FullName;
        }

        /// <summary>
        /// Unloads the isolated assembly context if one was used.
        /// This helps release resources when the assembly is no longer needed.
        /// Note: Full unloading is only available in .NET Core 3.0+ with collectible contexts.
        /// For netstandard2.0, we just null out references to allow GC.
        /// </summary>
        public void Unload()
        {
            _assembly = null;
            _allTypes = null;
            _typesByFullName = null;
            _typesByNamespace = null;

            // Just null out the reference; full unloading is not available in all frameworks
            _isolatedContext = null;
        }
    }
}
