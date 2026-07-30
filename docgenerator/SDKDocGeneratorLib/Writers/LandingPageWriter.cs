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

        /// <summary>
        /// Wraps the landing-page content fragment in the shared DocShell so the
        /// top bar / sidebar / head are identical to every other page and defined
        /// only once (in DocShell).
        /// </summary>
        public override void Write()
        {
            // Lives at items/sdk-api-home.html, so the doc-set root is one level up.
            var shell = new DocShell.Options
            {
                RootRelativePath = "..",
                Title = "AWS SDK for .NET Version 4 API Reference",
                Description = "Get started quickly using AWS with the AWS SDK for .NET. The SDK helps take "
                            + "the complexity out of coding by providing .NET APIs for many AWS services "
                            + "including Amazon S3, Amazon EC2, DynamoDB and more.",
                CanonicalUrl = "https://docs.aws.amazon.com/sdkfornet/v4/apidocs/items/sdk-api-home.html"
            };

            var content = LoadAndReplace();

            var templateOutput = TemplateOutputPath;
            var outputPath = Path.GetDirectoryName(templateOutput);
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            using (var sw = new StringWriter())
            {
                DocShell.WriteHeadAndChrome(sw, shell);
                sw.Write(content);
                DocShell.WriteFootShell(sw);

                using (var fileWriter = new StreamWriter(templateOutput))
                {
                    fileWriter.Write(sw.ToString());
                }
            }
        }
    }
}
