using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator.Writers
{
    public abstract class MethodBaseWriter : MemberWriter
    {
        readonly MethodBaseWrapper _info;

        protected MethodBaseWriter(GenerationManifest artifacts, FrameworkVersion version, MethodBaseWrapper info)
            : base(artifacts, version, info)
        {
            this._info = info;
        }

        protected override void AddParameters(System.IO.TextWriter writer)
        {
            var parameters = this._info.GetParameters();
            if (parameters.Count == 0)
                return;

            var ndoc = GetSummaryDocumentation();

            writer.WriteLine("<div class=\"sectionbody\">");
                writer.WriteLine("<div id=\"parameters\">");
                    writer.WriteLine("<h3><strong class=\"subHeading\">Parameters</strong></h3>");
                writer.WriteLine("</div>");

                foreach (var parameter in parameters)
                {
                    writer.WriteLine("<dl>");
                
                        writer.WriteLine("<dt>");
                            writer.WriteLine("<span class=\"parameter\">{0}</span>", parameter.Name);
                        writer.WriteLine("</dt>");

                        writer.WriteLine("<dd>");

                            var paramType = parameter.ParameterType;

                            writer.WriteLine("Type: {0}<br />", paramType.CreateReferenceHtml(fullTypeName: true));
                            
                            var doc = NDocUtilities.FindParameterDocumentation(ndoc, parameter.Name);
                            writer.WriteLine("<p>{0}</p>", doc);

                        writer.WriteLine("</dd>");

                    writer.WriteLine("</dl>");
                }

            writer.WriteLine("</div>");
        }
    }
}
