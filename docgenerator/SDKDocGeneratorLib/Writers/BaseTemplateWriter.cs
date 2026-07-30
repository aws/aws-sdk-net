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

        /// <summary>
        /// Loads the embedded template and applies <see cref="ReplaceTokens"/>.
        /// </summary>
        protected string LoadAndReplace()
        {
            var templateName = GetTemplateName();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SDKDocGenerator.Templates." + templateName))
            using (var reader = new StreamReader(stream))
            {
                return ReplaceTokens(reader.ReadToEnd());
            }
        }

        public virtual void Write()
        {
            var finalBody = LoadAndReplace();

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
