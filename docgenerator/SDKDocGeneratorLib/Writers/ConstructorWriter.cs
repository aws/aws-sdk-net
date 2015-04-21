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
    public class ConstructorWriter : MethodBaseWriter
    {
        readonly ConstructorInfoWrapper _constructorInfo;

        public ConstructorWriter(GenerationManifest artifacts, FrameworkVersion version, ConstructorInfoWrapper constructorInfo)
            : base(artifacts, version, constructorInfo)
        {
            this._constructorInfo = constructorInfo;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._constructorInfo);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_constructorInfo.DeclaringType.Namespace);
        }

        protected override string GetTitle()
        {
            var par = FormatParameters(this._constructorInfo.GetParameters());
            if (string.IsNullOrEmpty(par))
                return string.Format("{0} {1}", this._constructorInfo.DeclaringType.Name, GetMemberType());

            return string.Format("{0} {1} ({2})", this._constructorInfo.DeclaringType.GetDisplayName(false), 
                                                  GetMemberType(),
                                                  FormatParameters(this._constructorInfo.GetParameters()));
        }

        protected override string GetMemberName()
        {
            var par = FormatParameters(this._constructorInfo.GetParameters());
            if (string.IsNullOrEmpty(par))
                return string.Format("{0}", this._constructorInfo.DeclaringType.Name);

            return string.Format("{0} ({1})", this._constructorInfo.DeclaringType.GetDisplayName(false), FormatParameters(this._constructorInfo.GetParameters()));
        }

        protected override string GetMemberType()
        {
            return "Constructor";
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._constructorInfo);
            return element;
        }

        protected override string GetSyntax()
        {
            return new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._constructorInfo);
        }
    }
}
