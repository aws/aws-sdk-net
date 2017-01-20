using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;

namespace SDKDocGenerator
{
    public abstract class AbstractWrapper : MarshalByRefObject
    {
        public string DocId
        {
            private set;
            get;
        }

        public AbstractWrapper(string docId)
        {
            DocId = docId;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    public abstract class AbstractTypeProvider : AbstractWrapper
    {
        public AbstractTypeProvider(string docId)
            : base(docId)
        {
        }

        virtual public TypeWrapper GetType(string name) { return null; }
        virtual public IEnumerable<TypeWrapper> GetTypes() { return null; }
        virtual public IEnumerable<string> GetNamespaces() { return null; }
        virtual public IEnumerable<TypeWrapper> GetTypesForNamespace(string namespaceName) { return null; }
    }

    public class AssemblyWrapper : AbstractTypeProvider
    {
        Assembly _assembly;
        IList<TypeWrapper> _allTypes;
        IDictionary<string, TypeWrapper> _typesByFullName;
        IDictionary<string, IList<TypeWrapper>> _typesByNamespace;
        AbstractTypeProvider _secondaryTypeProvider;

        public AssemblyWrapper(string docId)
            : base(docId)
        {
        }

        public void LoadAssembly(string path)
        {
            _assembly = Assembly.LoadFrom(path);

            _allTypes = new List<TypeWrapper>();
            _typesByNamespace = new Dictionary<string, IList<TypeWrapper>>();
            _typesByFullName = new Dictionary<string, TypeWrapper>();

            foreach (var type in this._assembly.GetTypes())
            {
                if (type.Namespace == null ||
                    !type.Namespace.StartsWith("Amazon") ||
                    type.Namespace.Contains("Internal") ||
                    !(type.IsPublic || type.IsNestedPublic))
                {
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
        }

        public string AssemblyVersion
        {
            get { return this._assembly.GetName().Version.ToString(); }
        }

        public void SetSecondaryTypeProvider(AbstractTypeProvider typeProvider)
        {
            _secondaryTypeProvider = typeProvider;
        }

        public override TypeWrapper GetType(string name)
        {
            TypeWrapper wrapper;
            if (!this._typesByFullName.TryGetValue(name, out wrapper))
            {
                if (_secondaryTypeProvider != null)
                {
                    return _secondaryTypeProvider.GetType(name);
                }
                return null;
            }

            return wrapper;
        }

        public override IEnumerable<TypeWrapper> GetTypes()
        {
            var types = new HashSet<TypeWrapper>(this._allTypes);
            
            if (_secondaryTypeProvider != null)
            {
                types.UnionWith(_secondaryTypeProvider.GetTypes());
            }
            return types;
        }

        public override IEnumerable<string> GetNamespaces()
        {
             var namespaces = new HashSet<string>(this._typesByNamespace.Keys);
            
            if (_secondaryTypeProvider != null)
            {
                namespaces.UnionWith(_secondaryTypeProvider.GetNamespaces());
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

            if(_secondaryTypeProvider != null)
            {
                typeSet.UnionWith(_secondaryTypeProvider.GetTypesForNamespace(namespaceName));
            }

            return typeSet;
        }

        public override string ToString()
        {
            return this._assembly.FullName;
        }
    }

    public class PartialTypeProvider : AbstractTypeProvider
    {
        private IDictionary<string, TypeWrapper> typeDictionary = new Dictionary<string, TypeWrapper>();
        private IDictionary<string, IList<TypeWrapper>> namespaceToTypes = new Dictionary<string, IList<TypeWrapper>>();

        public PartialTypeProvider(string docId)
            : base(docId)
        {
        }

        public void ProcessTypes(IEnumerable<TypeWrapper> types)
        {
            foreach(var type in types)
            {
                IList<TypeWrapper> list;
                if (namespaceToTypes.TryGetValue(type.Namespace, out list))
                {
                    list.Add(type);
                }
                else
                {
                    namespaceToTypes.Add(type.Namespace, new List<TypeWrapper> { type });
                }
                typeDictionary.Add(type.FullName, type);
            }
        }

        public override TypeWrapper GetType(string fullName) 
        {
            TypeWrapper type = null;
            typeDictionary.TryGetValue(fullName, out type);
            return type;
        }
        public override IEnumerable<TypeWrapper> GetTypes()
        {
            return typeDictionary.Values;
        }
        public override IEnumerable<string> GetNamespaces() 
        {
            return namespaceToTypes.Keys;
        }
        public override IEnumerable<TypeWrapper> GetTypesForNamespace(string namespaceName)
        {
            IList<TypeWrapper> types;

            if (namespaceToTypes.TryGetValue(namespaceName, out types))
            {
                return types;
            }
            else
            {
                return new List<TypeWrapper>();
            }
        }
    }

    public class TypeWrapper : AbstractWrapper
    {
        readonly Type _type;

        public TypeWrapper(Type type, string docId)
            : base(docId)
        {
            this._type = type;
        }

        public string Name
        {
            get {
                string name = this._type.Name;

                if (name != null && this._type.IsNested)
                {
                    name = string.Format("{0}.{1}", this._type.DeclaringType.Name, this._type.Name);
                }
                return name; 
            }
        }

        public string Namespace
        {
            get { return this._type.Namespace; }
        }

        public string FullName
        {
            get {
                string fullName = this._type.FullName;

                // _type can be of generic type T in which case FullName is null
                if (fullName != null && this._type.IsNested)
                {
                    fullName = fullName.Replace("+", ".");
                }

                return fullName;
            }
        }

        public string ManifestModuleName
        {
            get { return this._type.Assembly.ManifestModule.Name; }
        }

        public string[] GetEnumNames()
        {
            if (!this._type.IsEnum)
                return new string[0];

            return System.Enum.GetNames(this._type);
        }

        public string GetDisplayName(bool useFullName)
        {
            string name;
            if (this.IsGenericParameter)
                name = this.Name;
            else if (this.IsGenericType)
            {
                var baseName = this.Name;
                var pos = baseName.IndexOf('`');

                var paramCount = this.GenericTypeArguments().Count;
                baseName = baseName.Substring(0, pos);

                var pars = new StringBuilder();
                if (this._type.IsGenericTypeDefinition)
                {
                    if (paramCount == 1)
                        pars.Append("T");
                    else
                    {
                        for (var i = 1; i <= paramCount; i++)
                        {
                            if (pars.Length > 0)
                                pars.Append(", ");

                            pars.AppendFormat("T{0}", i);
                        }
                    }
                }
                else
                {
                    foreach (var t in this._type.GenericTypeArguments)
                    {
                        if (pars.Length > 0)
                            pars.Append(", ");
                        pars.AppendFormat(new TypeWrapper(t, DocId).GetDisplayName(useFullName));
                    }
                }

                name = string.Format("{0}&lt;{1}&gt;", baseName, pars);
            }
            else
            {
                // if it's an anonymous generic type, just return it as we can
                // dig no further
                if (this.Name.Equals("T[]", StringComparison.Ordinal))
                    name = this.Name;
                else
                    name = useFullName ? this.FullName : this.Name;
            }

            if (name == null)
                throw new ApplicationException(string.Format("Failed to resolve display for type {0}", this._type));

            return name;
        }

        IList<ConstructorInfoWrapper> _constructors;
        public IList<ConstructorInfoWrapper> GetConstructors()
        {
            if (this._constructors == null)
            {
                this._constructors = new List<ConstructorInfoWrapper>();
                foreach (var info in this._type.GetConstructors())
                {
                    this._constructors.Add(new ConstructorInfoWrapper(info, DocId));
                }
            }

            return this._constructors;
        }

        public TypeWrapper BaseType
        {
            get 
            {
                if (this._type.BaseType == null)
                    return null;

                return new TypeWrapper(this._type.BaseType, DocId); 
            }
        }

        public IList<TypeWrapper> GetInterfaces()
        {
            var interfaces = new List<TypeWrapper>();

            foreach(var real in this._type.GetInterfaces())
            {
                interfaces.Add(new TypeWrapper(real, DocId));
            }

            return interfaces;
        }


        public IList<PropertyInfoWrapper> GetProperties()
        {
            var wrappers = new List<PropertyInfoWrapper>();

            foreach (var info in this._type.GetProperties())
            {
                wrappers.Add(new PropertyInfoWrapper(info, DocId));
            }

            return wrappers;
        }

        public IList<MethodInfoWrapper> GetMethodsToDocument()
        {
            var wrappers = new List<MethodInfoWrapper>();

            foreach (var info in this._type.GetMethods().Where(x => x.IsPublic && 
                                                                !x.Name.StartsWith("get_") && 
                                                                !x.Name.StartsWith("set_") && 
                                                                !x.Name.StartsWith("add_") &&
                                                                !x.Name.StartsWith("op_") &&
                                                                !x.Name.StartsWith("remove_") &&
                                                                !x.Name.StartsWith("Equals") &&
                                                                !x.Name.StartsWith("GetHashCode") &&
                                                                !x.Name.StartsWith("ToString") &&
                                                                x.DeclaringType != typeof(object)))
            {
                if(info.DeclaringType.Namespace.StartsWith("Amazon"))
                    wrappers.Add(new MethodInfoWrapper(info, DocId));
            }

            return wrappers;
        }

        public IList<TypeWrapper> GetNestedTypesToDocument()
        {
            var wrappers = new List<TypeWrapper>();

            wrappers.AddRange(this._type.GetMembers()
                .Where(x =>
                    x.MemberType.Equals(MemberTypes.NestedType) &&
                    x.DeclaringType.Namespace.StartsWith("Amazon"))
                .Select(member => new TypeWrapper(_type.GetNestedType(member.Name), DocId)));

            return wrappers;
        }

        public IList<EventInfoWrapper> GetEvents()
        {
            var wrappers = new List<EventInfoWrapper>();

            foreach (var info in this._type.GetEvents().Where(x => x.AddMethod.IsPublic))
            {
                wrappers.Add(new EventInfoWrapper(info, DocId));
            }

            return wrappers;
        }

        IList<FieldInfoWrapper> _fields;
        public IList<FieldInfoWrapper> GetFields()
        {
            if (this._fields == null)
            {
                this._fields = new List<FieldInfoWrapper>();
                foreach (var info in this._type.GetFields().Where(x => x.IsPublic))
                {
                    this._fields.Add(new FieldInfoWrapper(info, DocId));
                }
            }

            return this._fields;
        }

        public void GetHelpURL(FrameworkVersion version, out string url, out string target)
        {
            target = "";
            url = null;

            if (IsSystemNamespace)
            {
                // msdn urls for generic collections are not predictable, so
                // we elect to output as simple text
                if (!this.IsGenericType)
                {
                    target = "target=_new";
                    url = string.Format(NDocUtilities.MSDN_TYPE_URL_PATTERN, this.GetDisplayName(true).ToLower());
                }
            }
            else if (IsAmazonNamespace)
            {
                // don't know if reference is to a type in folder for namespace of declaring type we're
                // processing, or in another namespace (folder), so jump to output root on the link
                url = string.Format("../{0}/{1}", 
                                    GenerationManifest.OutputSubFolderFromNamespace(this.Namespace),
                                    FilenameGenerator.GenerateFilename(this));
            }
        }

        public bool IsSystemNamespace
        {
            get
            {
                return this.Namespace.Equals("System", StringComparison.Ordinal) 
                    || this.Namespace.StartsWith("System.", StringComparison.Ordinal);
            }    
        }

        public bool IsAmazonNamespace
        {
            get
            {
                return this.Namespace.Equals("Amazon", StringComparison.Ordinal)
                    || this.Namespace.StartsWith("Amazon.", StringComparison.Ordinal);
            }
        }

        // strips the type argument count off of generic collections so
        // we get a cleaner display
        public string GenericTypeName
        {
            get
            {
                if (!this.IsGenericType)
                    return this.FullName;

                // FullName in this case includes the assembly info, reconstruct
                // using the namespace + name
                var apos = this.Name.LastIndexOf('`');
                return string.Format("{0}.{1}", 
                                     this.Namespace, 
                                     apos != -1 ? this.Name.Substring(0, apos) : this.Name);
            }
        }

        public bool IsEnum
        {
            get { return this._type.IsEnum; }
        }

        public bool ContainsGenericParameters
        {
            get { return this._type.ContainsGenericParameters; }
        }

        public bool IsGenericParameter
        {
            get { return this._type.IsGenericParameter; }
        }

        public bool IsGenericType
        {
            get { return this._type.IsGenericType; }
        }

        public bool IsGenericTypeDefinition
        {
            get { return this._type.IsGenericTypeDefinition; }
        }

        public bool IsNested
        {
            get { return this._type.IsNested; }
        }

        public bool IsPublic
        {
            get { return this._type.IsPublic || this._type.IsNestedPublic; }
        }

        public bool IsSealed
        {
            get { return this._type.IsSealed && !this._type.IsAbstract; }
        }

        public bool IsAbstract
        {
            get { return this._type.IsAbstract && !this._type.IsSealed && this._type.IsClass; }
        }

        public bool IsStatic
        {
            get { return this._type.IsAbstract && this._type.IsSealed && this._type.IsClass; }
        }

        public bool IsClass
        {
            get { return this._type.IsClass; }
        }

        public bool IsInterface
        {
            get { return this._type.IsInterface; }
        }

        public bool IsValueType
        {
            get { return this._type.IsValueType; }
        }

        public bool IsStructure
        {
            get { return this._type.IsValueType && !this._type.IsEnum; }
        }

        public override string ToString()
        {
            return this._type.FullName;
        }

        IList<TypeWrapper> _genericTypeArguments;
        public IList<TypeWrapper> GenericTypeArguments()
        {
            if (this._genericTypeArguments == null)
            {
                this._genericTypeArguments = new List<TypeWrapper>();
                foreach (var type in this._type.GenericTypeArguments)
                {
                    this._genericTypeArguments.Add(new TypeWrapper(type, DocId));
                }
            }

            return this._genericTypeArguments;
        }
    }

    public class MemberInfoWrapper : AbstractWrapper
    {
        readonly MemberInfo _info;

        public MemberInfoWrapper(MemberInfo info, string docId)
            : base(docId)
        {
            this._info = info;
        }

        public string Name
        {
            get { return this._info.Name; }
        }

        public TypeWrapper DeclaringType
        {
            get { return new TypeWrapper(this._info.DeclaringType, DocId); }
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this._info.DeclaringType.FullName, this._info.Name);
        }
    }


    public class FieldInfoWrapper : MemberInfoWrapper
    {
        readonly FieldInfo _info;

        public FieldInfoWrapper(FieldInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsPublic
        {
            get { return this._info.IsPublic; }
        }

        public bool IsStatic
        {
            get { return this._info.IsStatic; }
        }

        public bool IsInitOnly
        {
            get { return this._info.IsInitOnly; }
        }

        public bool IsLiteral
        {
            get { return this._info.IsLiteral; }
        }

        TypeWrapper _fieldType;
        public TypeWrapper FieldType
        {
            get
            {
                if (this._fieldType == null)
                    this._fieldType = new TypeWrapper(this._info.FieldType, DocId);

                return this._fieldType;
            }
        }
    }

    public class MethodBaseWrapper : MemberInfoWrapper
    {
        readonly MethodBase _info;

        public MethodBaseWrapper(MethodBase info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public IList<ParameterInfoWrapper> GetParameters()
        {
            var wrappers = new List<ParameterInfoWrapper>();

            foreach (var info in this._info.GetParameters())
            {
                wrappers.Add(new ParameterInfoWrapper(info, DocId));
            }

            return wrappers;
        }

        public bool IsPublic
        {
            get { return this._info.IsPublic; }
        }
    }


    public class ConstructorInfoWrapper : MethodBaseWrapper
    {
        readonly ConstructorInfo _info;

        public ConstructorInfoWrapper(ConstructorInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsStatic
        {
            get
            {
                return _info.IsStatic;
            }
        }
    }

    public class MethodInfoWrapper : MethodBaseWrapper
    {
        readonly MethodInfo _info;

        public MethodInfoWrapper(MethodInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsStatic
        {
            get
            {
                return _info.IsStatic;
            }
        }

        public bool IsAbstract
        {
            get { return this._info.IsAbstract; }
        }

        public bool IsVirtual
        {
            get { return this._info.IsVirtual && !this._info.IsAbstract; }
        }

        public TypeWrapper ReturnType
        {
            get { return new TypeWrapper(this._info.ReturnType, DocId); }
        }

        public bool IsGenericMethod
        {
            get { return this._info.IsGenericMethod; }
        }

        public TypeWrapper[] GetGenericArguments()
        {
            if (!this.IsGenericMethod)
                return null;

            var types = this._info.GetGenericArguments();
            var wrappers = new TypeWrapper[types.Length];
            for(int i = 0; i < types.Length; i++)
            {
                wrappers[i] = new TypeWrapper(types[i], DocId);
            }

            return wrappers;
        }
    }

    public class PropertyInfoWrapper : MemberInfoWrapper
    {
        readonly PropertyInfo _info;

        public PropertyInfoWrapper(PropertyInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsPublic
        {
            get
            {
                if (this._info.GetGetMethod() == null)
                    return false;

                var underlyingType = Nullable.GetUnderlyingType(this._info.GetGetMethod().GetType());
                if (underlyingType != null)
                    return underlyingType.IsPublic;

                return this._info.GetGetMethod().IsPublic;
            }
        }

        public bool IsStatic
        {
            get
            {
                // need to watch out for properties with only a single accessor, CanRead/CanWrite
                // don't seem too reliable with public/protected/private modifiers
                if (_info.CanRead)
                {
                    var mi = _info.GetGetMethod();
                    if (mi != null)
                        return mi.IsStatic;
                }

                if (_info.CanWrite)
                {
                    var mi = _info.GetSetMethod();
                    if (mi != null)
                        return mi.IsStatic;
                }

                return false;
           }
        }

        public TypeWrapper PropertyType
        {
            get { return new TypeWrapper(this._info.PropertyType, DocId); }
        }

        public MethodInfoWrapper GetGetMethod()
        {
            var method = this._info.GetGetMethod();
            if (method == null)
                return null;

            return new MethodInfoWrapper(method, DocId);
        }

        public MethodInfoWrapper GetSetMethod()
        {
            var method = this._info.GetSetMethod();
            if (method == null)
                return null;

            return new MethodInfoWrapper(method, DocId);
        }
    }

    public class ParameterInfoWrapper : AbstractWrapper
    {
        readonly ParameterInfo _info;

        public ParameterInfoWrapper(ParameterInfo info, string docId)
            : base(docId)
        {
            this._info = info;
        }

        public string Name
        {
            get { return this._info.Name; }
        }

        public TypeWrapper ParameterType
        {
            get
            {
                if (this._info.ParameterType.IsByRef)
                    return new TypeWrapper(this._info.ParameterType.GetElementType(), DocId);

                return new TypeWrapper(this._info.ParameterType, DocId);
            }
        }

        public bool IsOut
        {
            get { return this._info.IsOut; }
        }

        public override string ToString()
        {
            return string.Format("Parameter {0}", this._info.Name);
        }
    }

    public class EventInfoWrapper : MemberInfoWrapper
    {
        readonly EventInfo _info;

        public EventInfoWrapper(EventInfo info, string docId)
            : base(info, docId)
        {
            this._info = info;
        }

        public bool IsStatic
        {
            get
            {                
                // need to watch out for properties with only a single accessor, CanRead/CanWrite
                // don't seem too reliable with public/protected/private modifiers
                if (_info.AddMethod != null)
                {
                    return _info.AddMethod.IsStatic;
                }

                if (_info.RemoveMethod != null)
                {
                    return _info.RemoveMethod.IsStatic;
                }

                return false;
            }
        }
    }
}