using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace SDKDocGenerator
{
    public class TypeWrapper : AbstractWrapper
    {
        readonly Type _type;

        // Lazy + thread-safe so a shared TypeWrapper (the same instance is returned by both
        // GetTypesForNamespace and GetType, and base/related types are resolved to shared instances)
        // can be read concurrently during parallel page generation without racing on these caches.
        private readonly Lazy<string> _fullName;
        private readonly Lazy<IEnumerable<AttributeWrapper>> _attributes;
        private readonly Lazy<IList<ConstructorInfoWrapper>> _constructors;
        private readonly Lazy<IList<FieldInfoWrapper>> _fields;
        private readonly Lazy<IList<TypeWrapper>> _genericTypeArguments;

        public TypeWrapper(Type type, string docId)
            : base(docId)
        {
            this._type = type;

            _fullName = new Lazy<string>(() =>
            {
                // _type can be of generic type T in which case FullName is null
                if (this._type.FullName != null && this._type.IsNested)
                    return new StringBuilder(this._type.FullName).Replace("+", ".").ToString();
                return this._type.FullName;
            }, LazyThreadSafetyMode.ExecutionAndPublication);

            _attributes = new Lazy<IEnumerable<AttributeWrapper>>(() =>
                _type.CustomAttributes
                    .Where(attribute => attribute.AttributeType.FullName.Equals("System.ObsoleteAttribute"))
                    .Select(customAttribute => new AttributeWrapper(customAttribute, DocId))
                    .ToList(),
                LazyThreadSafetyMode.ExecutionAndPublication);

            _constructors = new Lazy<IList<ConstructorInfoWrapper>>(() =>
                this._type.GetConstructors()
                    .Select(info => new ConstructorInfoWrapper(info, DocId))
                    .ToList<ConstructorInfoWrapper>(),
                LazyThreadSafetyMode.ExecutionAndPublication);

            _fields = new Lazy<IList<FieldInfoWrapper>>(() =>
                this._type.GetFields().Where(x => x.IsPublic)
                    .Select(info => new FieldInfoWrapper(info, DocId))
                    .ToList<FieldInfoWrapper>(),
                LazyThreadSafetyMode.ExecutionAndPublication);

            _genericTypeArguments = new Lazy<IList<TypeWrapper>>(() =>
                this._type.GenericTypeArguments
                    .Select(t => new TypeWrapper(t, DocId))
                    .ToList<TypeWrapper>(),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TypeWrapper);
        }
        public bool Equals(TypeWrapper other)
        {
            if (other == null)
                return false;

            if (!string.Equals(DocId, other.DocId))
                return false;

            if (_type != other._type)
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            return _type.GetHashCode() + DocId.GetHashCode();
        }

        public string JustName
        {
            get { return this._type.Name; }
        }

        public string Name
        {
            get {
                string name = this._type.Name;

                if (name != null && this._type.IsNested)
                {
                    name = $"{this._type.DeclaringType.Name}.{this._type.Name}";
                }
                return name;
            }
        }

        public string Namespace
        {
            get { return this._type.Namespace; }
        }

        public string FullName => _fullName.Value;

        public IEnumerable<AttributeWrapper> Attributes => _attributes.Value;

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
                name = this.JustName;
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

                name = $"{baseName}&lt;{pars}&gt;";
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
                throw new ApplicationException($"Failed to resolve display for type {this._type}");

            return name;
        }

        public IList<ConstructorInfoWrapper> GetConstructors()
        {
            return this._constructors.Value;
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


        public TypeWrapper GetElementType()
        {
            var elementType = this._type.GetElementType();
            return new TypeWrapper(elementType, DocId);
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

        public IList<FieldInfoWrapper> GetFields()
        {
            return this._fields.Value;
        }

        public string CreateReferenceHtml(bool fullTypeName)
        {
            string html;
            var nameOrFullName = fullTypeName ? (this.FullName ?? this.Name) : this.Name;

            if (this.IsGenericParameter)
            {
                html = this.JustName;
            }
            else if (this.IsGenericType)
            {

                var fixedName = nameOrFullName.Substring(0, nameOrFullName.IndexOf('`'));
                using(var writer = new StringWriter())
                {
                    writer.Write("<a");

                    string url;
                    if (this.IsAmazonNamespace)
                    {
                        url = $"../{GenerationManifest.OutputSubFolderFromNamespace(this.Namespace)}/{FilenameGenerator.GenerateFilename(this)}";
                    }
                    else if (this.IsSystemNamespace)
                    {
                        writer.Write(" target=_new");

                        var fixedMsdnName = this.Name.Replace('`', '-');
                        url = $"https://docs.microsoft.com/en-us/dotnet/api/{this.Namespace}.{fixedMsdnName}";
                    }
                    else
                    {
                        throw new ApplicationException($"Type {this.FullName} is not a System or Amazon type, no idea how to handle its help URL");
                    }

                    writer.Write(" href=\"{0}\"", url);
                    writer.Write(">");

                    writer.Write(fixedName);
                    writer.Write("</a>");

                    writer.Write("&lt;");
                    var typeArguments = this.GenericTypeArguments();
                    for (int i = 0; i < typeArguments.Count;i++ )
                    {
                        if (i != 0)
                            writer.Write(", ");
                        var typeArgument = typeArguments[i];
                        var argumentHtml = typeArgument.CreateReferenceHtml(fullTypeName);
                        writer.Write(argumentHtml);
                    }
                    writer.Write("&gt;");

                    html = writer.ToString();
                }
            }
            else if (this.IsArray)
            {
                var elementType = this.GetElementType();
                var elementTypeHtml = elementType.CreateReferenceHtml(fullTypeName);
                html = $"{elementTypeHtml}[]";
            }
            else
            {
                string url, label, target;
                if (this.IsAmazonNamespace)
                {
                    url = $"../{GenerationManifest.OutputSubFolderFromNamespace(this.Namespace)}/{FilenameGenerator.GenerateFilename(this)}";
                    label = nameOrFullName;
                    target = string.Empty;
                }
                else if (this.IsSystemNamespace)
                {
                    url = string.Format(NDocUtilities.MSDN_TYPE_URL_PATTERN, this.GetDisplayName(true).ToLower());
                    target = " target=_new";
                    label = nameOrFullName;
                }
                else
                {
                    throw new ApplicationException($"Type {this.FullName} is not a System or Amazon type, no idea how to handle its help URL");
                }

                html = $"<a{target} href=\"{url}\" rel=\"noopener noreferrer\">{label}</a>";
            }

            return html;
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
                return $"{this.Namespace}.{(apos != -1 ? this.Name.Substring(0, apos) : this.Name)}";
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

        public bool IsArray
        {
            get { return this._type.IsArray; }
        }

        public override string ToString()
        {
            return this._type.FullName;
        }

        public IList<TypeWrapper> GenericTypeArguments()
        {
            return this._genericTypeArguments.Value;
        }

        public IList<TypeWrapper> GetGenericArguments()
        {
            return this._type
                .GetGenericArguments()
                .Select(a => new TypeWrapper(a, DocId))
                .ToList();
        }
    }
}
