using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SDKDocGenerator.Writers
{
    public abstract class BaseTemplateWriter
    {
        public GeneratorOptions Options { get; private set; }

        protected BaseTemplateWriter(GeneratorOptions options)
        {
            this.Options = options;
        }

        protected abstract string GetTemplateName();
        protected abstract String ReplaceTokens(String templateBody);

        protected virtual string TemplateOutputPath
        {
            get
            {
                return Path.Combine(Options.OutputFolder, GetTemplateName()); 
            }
        }

        public void Write()
        {
            var templateName = GetTemplateName();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SDKDocGenerator.Templates." + templateName))
            using (var reader = new StreamReader(stream))
            {
                var templateBody = reader.ReadToEnd();
                var finalBody = ReplaceTokens(templateBody);

                var templateOutput = TemplateOutputPath;
                var outputPath = Path.GetDirectoryName(templateOutput);
                if (!Directory.Exists(outputPath))
                    Directory.CreateDirectory(outputPath);

                using (var writer = new StreamWriter(templateOutput))
                {
                    writer.Write(finalBody);
                }
            }
        }

    }
}
