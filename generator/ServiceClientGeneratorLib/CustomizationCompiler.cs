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
        public static void CompileServiceCustomizations(string modelsPath)
        {
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

            foreach (string serviceDirectory in Directory.GetDirectories(modelsPath))
            {
                var s = Path.GetFileName(serviceDirectory);
                var compiledFilePath = Path.Combine(compiledCustomizationsDirectory, s + ".customizations.json");
                var customizationFiles = Directory.GetFiles(serviceDirectory, "*.customizations*.json");

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

                var examples = Directory.GetFiles(serviceDirectory, "*.examples.json").FirstOrDefault();
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
