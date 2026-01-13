using SDKDocGenerator.Syntax;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SDKDocGenerator.Writers
{
    public class ClassWriter : BaseWriter
    {
        readonly TypeWrapper _versionType;
        readonly IEnumerable<MethodInfoWrapper> _supplementalMethods;

        public ClassWriter(GenerationManifest artifacts, FrameworkVersion version, TypeWrapper versionType)
            : base(artifacts, version)
        {
            _versionType = versionType;
            _version = version;
            _supplementalMethods = Enumerable.Empty<MethodInfoWrapper>();
        }

        /// <summary>
        /// Creates a ClassWriter that includes supplemental methods from another platform.
        /// This is used when generating documentation for types where methods differ between platforms
        /// (e.g., H2 eventstream APIs that only exist in net8.0).
        /// </summary>
        /// <param name="artifacts">The generation manifest</param>
        /// <param name="version">The framework version for documentation</param>
        /// <param name="versionType">The type to document</param>
        /// <param name="supplementalMethods">Additional methods to include that don't exist in the primary platform</param>
        public ClassWriter(GenerationManifest artifacts, FrameworkVersion version, TypeWrapper versionType,
                          IEnumerable<MethodInfoWrapper> supplementalMethods)
            : base(artifacts, version)
        {
            _versionType = versionType;
            _version = version;
            _supplementalMethods = supplementalMethods ?? Enumerable.Empty<MethodInfoWrapper>();
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._versionType);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_versionType.Namespace);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return this._versionType.GetDisplayName(false);
        }

        protected override string GetMemberType()
        {
            if (this._versionType.IsInterface)
                return "Interface";

            if (this._versionType.IsStructure)
                return "Structure";

            if (this._versionType.IsEnum)
                return "Enumeration";

            return "Class";
        }

        protected override void WriteContent(TextWriter writer)
        {
            AddSummaryDocumentation(writer);
            AddPageTOC(writer);
            AddInheritanceHierarchy(writer);
            AddNamespace(writer, this._versionType.Namespace, this._versionType.ManifestModuleName);

            AddSyntax(writer);

            writer.WriteLine("<p>The {0} type exposes the following members</p>", this._versionType.GetDisplayName(false));

            if (this._versionType.IsEnum)
            {
                AddEnumMembers(writer);
            }
            else
            {
                AddConstructors(writer);
                AddProperties(writer);
                AddMethods(writer);
                AddEvents(writer);
                AddFields(writer);
                AddExamples(writer);
            }

            AddRemarksDocumentation(writer);

            // Add Code Examples section before Version Information
            AddCodeExamples(writer);

            AddVersionInformation(writer, this._versionType);
        }

        private void AddPageTOC(TextWriter writer)
        {
            writer.WriteLine("<div id=\"pageTOC\" class=\"collapsible-toc collapsed\">");
            writer.WriteLine("<h2 onclick=\"toggleTOC()\">In this article <span id=\"tocToggle\">▶</span></h2>");
            writer.WriteLine("<ul id=\"tocList\" style=\"display: none;\">");
            
            writer.WriteLine("<li><a href=\"#inheritancehierarchy\">Inheritance Hierarchy</a></li>");
            writer.WriteLine("<li><a href=\"#syntax\">Syntax</a></li>");
            
            if (!this._versionType.IsEnum)
            {
                var constructors = this._versionType.GetConstructors().Where(x => x.IsPublic);
                if (constructors.Any())
                    writer.WriteLine("<li><a href=\"#constructors\">Constructors</a></li>");
                
                var properties = this._versionType.GetProperties();
                if (properties.Any())
                    writer.WriteLine("<li><a href=\"#properties\">Properties</a></li>");
                
                var methods = this._versionType.GetMethodsToDocument();
                if (methods.Any())
                    writer.WriteLine("<li><a href=\"#methods\">Methods</a></li>");
                
                var events = this._versionType.GetEvents();
                if (events.Any())
                    writer.WriteLine("<li><a href=\"#events\">Events</a></li>");
                
                var fields = this._versionType.GetFields();
                if (fields.Any())
                    writer.WriteLine("<li><a href=\"#fields\">Fields</a></li>");

                var serviceId = GetServiceIdFromNamespace();
                var fragmentPath = Path.Combine(ExampleMetadataParser.ExampleFragmentsFullPath, $"{serviceId}.fragment.html");
                if (File.Exists(fragmentPath))
                    writer.WriteLine("<li><a href=\"#codeexamples\">Code Examples</a></li>");
            }
            else
            {
                var enumNames = this._versionType.GetEnumNames();
                if (enumNames.Any())
                    writer.WriteLine("<li><a href=\"#members\">Members</a></li>");
            }
                        
            
            writer.WriteLine("<li><a href=\"#versioninformation\">Version Information</a></li>");
            writer.WriteLine("</ul>");
            writer.WriteLine("</div>");
        }

        private void AddCodeExamples(TextWriter writer)
        {
            var serviceId = GetServiceIdFromNamespace();
            var fragmentPath = Path.Combine(ExampleMetadataParser.ExampleFragmentsFullPath,$"{serviceId}.fragment.html"
            );

            if (!File.Exists(fragmentPath))
                return;
                        
            writer.WriteLine("<div>");
            writer.WriteLine("<div class=\"collapsibleSection\">");
            writer.WriteLine("<h2 id=\"codeexamples\" class=\"title\">Code Examples</h2>");
            writer.WriteLine("</div>");
            writer.WriteLine("</div>");
            writer.WriteLine("<div class=\"sectionbody\">");

            var fragmentContent = File.ReadAllText(fragmentPath);
            writer.WriteLine(fragmentContent);

            writer.WriteLine("</div>");
        }

        private string GetServiceIdFromNamespace()
        {
            if (string.IsNullOrEmpty(this._versionType.Namespace))
                return string.Empty;
                
            var namespaceParts = this._versionType.Namespace.Split('.');            
            var serviceId = namespaceParts[namespaceParts.Length - 1];
            return serviceId;            
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._versionType, TypeProvider);
            return element;
        }

        private void AddInheritanceHierarchy(TextWriter writer)
        {
            IList<TypeWrapper> types = new List<TypeWrapper>();

            var current = this._versionType;
            while (current != null)
            {
                types.Add(current);
                current = current.BaseType;
            }

            AddSectionHeader(writer, "Inheritance Hierarchy");

            int level = 0;
            foreach (var type in types.Reverse())
            {
                for (int i = 0; i < level * 2; i++)
                {
                    writer.Write("&nbsp;");
                }

                if (type.FullName == this._versionType.FullName)
                    writer.WriteLine("{0}.{1}", type.Namespace, type.GetDisplayName(false));
                else
                {
                    writer.WriteLine(type.CreateReferenceHtml(fullTypeName: true));
                }

                writer.WriteLine("<br />");

                ++level;
            }

            AddSectionClosing(writer);
        }

        void AddConstructors(TextWriter writer)
        {
            var constructors = this._versionType.GetConstructors().Where(x => x.IsPublic);
            if (!constructors.Any())
                return;
            AddMemberTableSectionHeader(writer, "Constructors");
            foreach (var info in constructors.OrderBy(x => x.Name))
            {
                AddConstructor(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddConstructor(TextWriter writer, ConstructorInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicMethod\" src=\"{0}/resources/blank.gif\" title=\"Public Method\" alt=\"Public Method\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Method\" alt=\"Static Method\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            var filename = FilenameGenerator.GenerateFilename(info);
            var parameters = FormatParameters(info.GetParameters());
            var hrefLink = string.Format("<a href=\"./{0}\">{1}({2})</a>", filename, info.DeclaringType.Name, parameters);
            writer.WriteLine(hrefLink);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            var docs = NDocUtilities.FindDocumentation(info, TypeProvider);
            var html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", this.Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddProperties(TextWriter writer)
        {
            var properties = this._versionType.GetProperties();
            if (!properties.Any())
                return;

            AddMemberTableSectionHeader(writer, "Properties", PropertiesTableColumnHeaders);
            foreach (var info in properties.OrderBy(x => x.Name))
            {
                AddProperty(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }


        void AddProperty(TextWriter writer, PropertyInfoWrapper propertyInfo)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicProperty\" src=\"{0}/resources/blank.gif\" title=\"Public Property\" alt=\"Public Property\"/>", RootRelativePath);
            if (propertyInfo.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Property\" alt=\"Static Property\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine(propertyInfo.Name);
            // Add inline platform badge if property is platform-restricted
            AddPropertyPlatformBadge(writer, propertyInfo);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.Write(ConstructTypeInfoLinkContent(propertyInfo.PropertyType));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            var isInherited = !propertyInfo.DeclaringType.Equals(_versionType);
            if (isInherited)
            {
                html = string.Format("Inherited from {0}.{1}.", propertyInfo.DeclaringType.Namespace, propertyInfo.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(propertyInfo, TypeProvider);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        /// <summary>
        /// Adds a small inline platform badge for properties that are only available on specific platforms.
        /// This helps users identify platform-restricted properties at a glance in the class property list.
        /// </summary>
        void AddPropertyPlatformBadge(TextWriter writer, PropertyInfoWrapper propertyInfo)
        {
            // For inherited properties, we need to look up docs from the declaring type's service,
            // not the current service. E.g., ReadWriteTimeout is declared in Core's ClientConfig,
            // not in BedrockRuntimeConfig.
            var declaringServiceName = GetServiceNameFromAssembly(propertyInfo.DeclaringType.ManifestModuleName);

            var ndoc472 = NDocUtilities.GetDocumentationInstance(declaringServiceName, "net472");
            var ndocNet80 = NDocUtilities.GetDocumentationInstance(declaringServiceName, "net8.0");

            // If neither platform's docs are loaded, we can't determine availability
            if (ndoc472 == null && ndocNet80 == null)
                return;

            var docs472 = ndoc472 != null
                ? NDocUtilities.FindDocumentation(ndoc472, propertyInfo, TypeProvider)
                : null;
            var docsNet80 = ndocNet80 != null
                ? NDocUtilities.FindDocumentation(ndocNet80, propertyInfo, TypeProvider)
                : null;

            // If no docs found in either platform, assume available everywhere
            if (docs472 == null && docsNet80 == null)
                return;

            bool availableNet472 = docs472 != null;
            bool availableNet8 = docsNet80 != null;

            // If available on both platforms, no badge needed
            if (availableNet472 && availableNet8)
                return;

            if (availableNet472 && !availableNet8)
            {
                writer.WriteLine("<span class=\"platform-badge-inline net472-only\" title=\".NET Framework 4.7.2 only\">.NET FW</span>");
            }
            else if (!availableNet472 && availableNet8)
            {
                writer.WriteLine("<span class=\"platform-badge-inline net8-only\" title=\".NET 8.0+ only\">.NET 8+</span>");
            }
        }

        /// <summary>
        /// Extracts the service name from an assembly module name.
        /// E.g., "AWSSDK.Core.dll" -> "Core", "AWSSDK.BedrockRuntime.dll" -> "BedrockRuntime"
        /// </summary>
        private static string GetServiceNameFromAssembly(string manifestModuleName)
        {
            // Format: AWSSDK.ServiceName.dll
            const string prefix = "AWSSDK.";
            const string suffix = ".dll";

            if (manifestModuleName.StartsWith(prefix) && manifestModuleName.EndsWith(suffix))
            {
                return manifestModuleName.Substring(prefix.Length,
                    manifestModuleName.Length - prefix.Length - suffix.Length);
            }
            return manifestModuleName;
        }

        void AddMethods(TextWriter writer)
        {
            // Get methods from the type and merge with any supplemental methods
            var methods = this._versionType.GetMethodsToDocument().ToList();

            // Add supplemental methods (methods that exist only in supplemental platforms like net8.0)
            if (_supplementalMethods.Any())
            {
                // Create a set of existing method signatures to avoid duplicates
                var existingSignatures = new HashSet<string>(
                    methods.Select(m => $"{m.Name}({string.Join(",", m.GetParameters().Select(p => p.ParameterType.FullName))})"));

                foreach (var supplementalMethod in _supplementalMethods)
                {
                    var sig = $"{supplementalMethod.Name}({string.Join(",", supplementalMethod.GetParameters().Select(p => p.ParameterType.FullName))})";
                    if (!existingSignatures.Contains(sig))
                    {
                        methods.Add(supplementalMethod);
                    }
                }
            }

            if (!methods.Any())
                return;

            AddMemberTableSectionHeader(writer, "Methods");

            const string netFrameworkPatternNote = "<div class=\"noteblock\"><div class=\"noteheader\">Note:</div>" +
                                            "<p>Asynchronous operations (methods ending with <i>Async</i>) in the table below are for .NET 4.7.2 or higher.</p></div>";

            writer.WriteLine(netFrameworkPatternNote);
            foreach (var info in methods.OrderBy(x => x.Name))
            {
                AddMethod(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddMethod(TextWriter writer, MethodInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"publicMethod\" src=\"{0}/resources/blank.gif\" title=\"Public Method\" alt=\"Public Method\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Method\" alt=\"Static Method\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine("<a href=\"{0}/items/{1}/{2}\">{3}({4})</a>",
                RootRelativePath,
                GenerationManifest.OutputSubFolderFromNamespace(info.DeclaringType.Namespace),
                FilenameGenerator.GenerateFilename(info),
                info.Name,
                FormatParameters(info.GetParameters()));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            var isInherited = !info.DeclaringType.Equals(_versionType);
            if (isInherited)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(info, TypeProvider);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);
            }
            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddFields(TextWriter writer)
        {
            var fields = this._versionType.GetFields();
            if (!fields.Any())
                return;

            AddMemberTableSectionHeader(writer, "Fields", FieldTableColumnHeaders);
            foreach (var info in fields.OrderBy(x => x.Name))
            {
                AddField(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddField(TextWriter writer, FieldInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"field\" src=\"{0}/resources/blank.gif\" title=\"Field\" alt=\"Field\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Field\" alt=\"Static Field\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>{0}</td>", info.Name);

            writer.WriteLine("<td>");
            writer.Write(ConstructTypeInfoLinkContent(info.FieldType));
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            var isInherited = !info.DeclaringType.Equals(_versionType);
            if (isInherited)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(info, TypeProvider);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        void AddEvents(TextWriter writer)
        {
            var fields = this._versionType.GetEvents();
            if (!fields.Any())
                return;
            AddMemberTableSectionHeader(writer, "Events");
            foreach (var info in fields.OrderBy(x => x.Name))
            {
                AddEvent(writer, info);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddEvent(TextWriter writer, EventInfoWrapper info)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"event\" src=\"{0}/resources/blank.gif\" title=\"Event\" alt=\"Event\"/>", RootRelativePath);
            if (info.IsStatic)
                writer.WriteLine("<img class=\"static\" src=\"{0}/resources/blank.gif\" title=\"Static Event\" alt=\"Static Event\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine("<a href=\"{0}/items/{1}/{2}\">{3}</a>",
                RootRelativePath,
                GenerationManifest.OutputSubFolderFromNamespace(info.DeclaringType.Namespace),
                FilenameGenerator.GenerateFilename(info),
                info.Name);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            string html = string.Empty;
            var isInherited = !info.DeclaringType.Equals(_versionType);
            if (isInherited)
            {
                html = string.Format("Inherited from {0}.{1}.", info.DeclaringType.Namespace, info.DeclaringType.Name);
            }
            else {
                var docs = NDocUtilities.FindDocumentation(info, TypeProvider);
                html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);
            }

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        public void AddEnumMembers(TextWriter writer)
        {
            var enumNames = this._versionType.GetEnumNames();
            if (!enumNames.Any())
                return;

            AddMemberTableSectionHeader(writer, "Members");
            foreach (var name in enumNames.OrderBy(x => x))
            {
                AddEnumMember(writer, name);
            }
            AddMemberTableSectionClosing(writer);
        }

        void AddEnumMember(TextWriter writer, string enumName)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine("<td>");
            writer.WriteLine("<img class=\"field\" src=\"{0}/resources/blank.gif\" title=\"Enum\" alt=\"Enum\"/>", RootRelativePath);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");
            writer.WriteLine(enumName);
            writer.WriteLine("</td>");

            writer.WriteLine("<td>");

            var docs = NDocUtilities.FindFieldDocumentation(this._versionType, enumName);
            var html = NDocUtilities.TransformDocumentationToHTML(docs, "summary", Artifacts.ManifestAssemblyContext.SdkAssembly, this._version);

            writer.WriteLine(html);
            writer.WriteLine("</td>");

            writer.WriteLine("</tr>");
        }

        /// <summary>
        /// Constructs href markup, enclosed in a span, to the page containing the details of the 
        /// specified type (this can be external to AWS documentation) as well as in another service.
        /// </summary>
        /// <param name="typeWrapper"></param>
        string ConstructTypeInfoLinkContent(TypeWrapper typeWrapper)
        {
            var sb = new StringBuilder("<span>");
            sb.Append(typeWrapper.CreateReferenceHtml(fullTypeName: true));
            sb.Append("</span>");

            return sb.ToString();
        }

        protected void AddSyntax(TextWriter writer)
        {
            var csharpSyntax = new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._versionType);
            base.AddSyntax(writer, csharpSyntax);
        }

        protected override string GetTOCID()
        {
            return this._versionType.FullName.Replace('.', '_');
        }

    }
}
