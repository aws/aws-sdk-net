using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.XPath;
using System.Xml.Linq;

using SDKDocGenerator.Syntax;

namespace SDKDocGenerator.Writers
{
    public class PropertyWriter : MemberWriter
    {
        readonly PropertyInfoWrapper _propertyInfo;

        public PropertyWriter(GenerationManifest artifacts, FrameworkVersion version, PropertyInfoWrapper propertyInfo)
            : base(artifacts, version, propertyInfo)
        {
            this._propertyInfo = propertyInfo;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._propertyInfo);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_propertyInfo.DeclaringType.Namespace);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return string.Format("{0}.{1}", this._propertyInfo.DeclaringType.GetDisplayName(false), this._propertyInfo.Name);
        }

        protected override string GetMemberType()
        {
            return "Property";
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._propertyInfo);
            return element;
        }

        protected override string GetSyntax()
        {
            return new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._propertyInfo);
        }

        protected override void AddReturn(System.IO.TextWriter writer)
        {
            var returnType = this._propertyInfo.PropertyType;
            if (returnType == null)
                return;

            writer.WriteLine("<div class=\"sectionbody\">");
                writer.WriteLine("<div id=\"returnType\">");
                    writer.WriteLine("<strong class=\"subHeading\">Property Value</strong><br />");
                writer.WriteLine("</div>");

                var sb = new StringBuilder("Type: <span>");

                var nsFolder = GenerationManifest.OutputSubFolderFromNamespace(_propertyInfo.DeclaringType.Namespace);
                sb.Append(EmitTypeLinkMarkup(returnType, this._version));

                if (returnType.IsGenericType)
                {
                    sb.Append(ProcessGenericParameterTypes(returnType.GenericTypeArguments(), _version));
                }

                writer.WriteLine("{0}</span>", sb);

            writer.WriteLine("</div>");
        }

        internal static string ProcessGenericParameterTypes(IList<TypeWrapper> typedArgs, FrameworkVersion version)
        {
            var sb = new StringBuilder();

            sb.Append("&lt;");
            for (var i = 0; i < typedArgs.Count; i++)
            {
                if (i > 0)
                    sb.Append(", ");
                var a = typedArgs[i];
                sb.Append(EmitTypeLinkMarkup(a, version));
                if (a.IsGenericType)
                    sb.Append(ProcessGenericParameterTypes(a.GenericTypeArguments(), version));
            }
            sb.Append("&gt;");

            return sb.ToString();
        }

        internal static string EmitTypeLinkMarkup(TypeWrapper t, FrameworkVersion version)
        {
            string url, target;

            t.GetHelpURL(version, out url, out target);
            if (url != null)
                return string.Format("<a href=\"{0}\" {1}>{2}</a>",
                                url,
                                target,
                                t.IsGenericType ? t.GenericTypeName : t.GetDisplayName(true));

            return t.IsGenericType ? t.GenericTypeName : t.GetDisplayName(true);
        }
    }
}
