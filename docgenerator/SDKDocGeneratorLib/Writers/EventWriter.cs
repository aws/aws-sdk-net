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
    public class EventWriter : MemberWriter
    {
        readonly EventInfoWrapper _eventInfo;

        public EventWriter(GenerationManifest artifacts, FrameworkVersion version, EventInfoWrapper eventInfo)
            : base(artifacts, version, eventInfo)
        {
            this._eventInfo = eventInfo;
        }

        protected override string GenerateFilename()
        {
            return FilenameGenerator.GenerateFilename(this._eventInfo);
        }

        protected override string GenerateFilepath()
        {
            return GenerationManifest.OutputSubFolderFromNamespace(_eventInfo.DeclaringType.Namespace);
        }

        protected override string GetTitle()
        {
            return string.Format("{0} {1}", GetMemberName(), GetMemberType());
        }

        protected override string GetMemberName()
        {
            return string.Format("{0}.{1}", this._eventInfo.DeclaringType.GetDisplayName(false), this._eventInfo.Name);
        }

        protected override string GetMemberType()
        {
            return "Property";
        }

        protected override XElement GetSummaryDocumentation()
        {
            var element = NDocUtilities.FindDocumentation(this._currentNDoc, this._eventInfo);
            return element;
        }

        protected override string GetSyntax()
        {
            return new CSharpSyntaxGenerator(this._version).GenerateSyntax(this._eventInfo);
        }
    }
}
