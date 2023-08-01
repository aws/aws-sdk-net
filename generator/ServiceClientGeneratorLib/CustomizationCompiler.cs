using Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Used to compile json customizations
    /// </summary>
    public static class CustomizationCompiler
    {
        /// <summary>
        /// Compiles all files in the namespace *.customizations*.json into one large json file in bin\Release|Debug\customizations folder
        /// </summary>
        /// <param name="modelsPath">The path the to customization models to be compiled</param>
        public static void CompileServiceCustomizations(GeneratorOptions options)
        {
            var modelsPath = options.ModelsFolder;

            string compiledCustomizationsDirectory = "customizations";
            Console.WriteLine("Compiling service customizations from {0}", modelsPath);

            if (Directory.Exists(compiledCustomizationsDirectory))
            {
                Console.WriteLine("...cleaning previous compilation output");
                Directory.Delete(compiledCustomizationsDirectory, true);
            }
            else
            {
                Directory.CreateDirectory(compiledCustomizationsDirectory);
            }

            var serviceDirectories = Utils.GetServiceDirectories(options);

            foreach (string serviceDirectory in serviceDirectories)
            {
                var s = Path.GetFileName(serviceDirectory);
                var compiledFilePath = Utils.PathCombineAlt(compiledCustomizationsDirectory, s + ".customizations.json");
                var customizationFiles = Directory.GetFiles(serviceDirectory, "*.customizations*.json").OrderBy(f => f);

                var jsonWriter = new JsonWriter { PrettyPrint = true };

                JsonData outputJson = new JsonData();
                outputJson.SetJsonType(JsonType.Object);

                foreach (var entry in customizationFiles)
                {
                    var customJson = JsonMapper.ToObject(new StreamReader(entry));
                    foreach (var property in customJson.PropertyNames)
                    {
                        outputJson[property] = customJson[property];
                    }
                }

                // Load examples into the customizations as well
                // We're sorting by name of the file since some services contain multiple examples files,
                // and Directory.GetFiles may return a different order when running on Linux.
                var examples = Directory.GetFiles(serviceDirectory, "*.examples.json").OrderBy(f => f).FirstOrDefault();
                if (null != examples)
                {
                    var exampleData = JsonMapper.ToObject(new StreamReader(examples));
                    if (exampleData.IsObject && exampleData.PropertyNames.Contains("examples"))
                    {
                        outputJson["examples"] = exampleData["examples"];
                    }
                }

                outputJson.ToJson(jsonWriter);

                // Fixes json being placed into the json mapper
                var output = jsonWriter.ToString();

                // Empty json file
                if (output.Length < 10)
                    continue;

                var compiledFileDirectory = Path.GetDirectoryName(compiledFilePath);
                if (!Directory.Exists(compiledFileDirectory))
                {
                    Directory.CreateDirectory(compiledFileDirectory);
                }

                File.WriteAllText(compiledFilePath, output);
                Console.WriteLine("...updated {0}", Path.GetFullPath(compiledFilePath));
            }
        }
    }
}
