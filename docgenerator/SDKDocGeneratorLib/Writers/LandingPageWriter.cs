using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator.Writers
{
    public class LandingPageWriter : BaseTemplateWriter
    {
        public LandingPageWriter(GeneratorOptions options)
            : base(options)
        {
        }

        protected override string GetTemplateName()
        {
            return "sdk-api-home.html";
        }

        protected override string TemplateOutputPath
        {
            get
            {
                return Path.Combine(Options.ComputedContentFolder, GetTemplateName());
            }
        }

        protected override string ReplaceTokens(string templateBody)
        {
            var disclaimer = string.Format("<p>{0}</p>", string.Format(BaseWriter.BJSDisclaimerTemplate, Options.BJSDocsDomain));
            var finalBody = templateBody.Replace("{regionDisclaimer}", disclaimer);
            return finalBody;
        }
    }
}
