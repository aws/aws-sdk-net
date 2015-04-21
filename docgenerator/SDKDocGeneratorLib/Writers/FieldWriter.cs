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
    public class FieldWriter : MemberWriter
    {
        readonly FieldInfoWrapper _fieldInfo;

        public FieldWriter(GenerationManifest artifacts, FrameworkVersion version, FieldInfoWrapper FieldInfo)
            : base(artifacts, version, FieldInfo)
        {
            this._fieldInfo = FieldInfo;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._fieldInfo);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_fieldInfo.DeclaringType.Namespace);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return string.Format("{0}.{1}", this._fieldInfo.DeclaringType.GetDisplayName(false), this._fieldInfo.Name);
        }

        protected override string GetMemberType()
        {
            return "Field";
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._fieldInfo);
            return element;
        }

        protected override string GetSyntax()
        {
            return new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._fieldInfo);
        }
    }
}
