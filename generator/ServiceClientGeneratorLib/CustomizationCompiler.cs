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
            Console.WriteLine("Compiling service customizations from {0}", modelsPath);

            if (Directory.Exists("customizations"))
            {
                Console.WriteLine("...cleaning previous compilation output");

                // Cleanup any previous run customization.
                foreach (var file in Directory.GetFiles("customizations"))
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory("customizations");
            }

            var fileServices = Directory.GetFiles(modelsPath, "*.customizations*.json");

            foreach (var file in fileServices)
            {
                // The name before the .customizations extension
                // Used to get all files for that service
				var baseName = file.Substring(file.IndexOf("ServiceModels"+Path.DirectorySeparatorChar , StringComparison.OrdinalIgnoreCase)
					+ ("ServiceModels"+Path.DirectorySeparatorChar).Length, file.IndexOf(".customizations", StringComparison.OrdinalIgnoreCase)
					- Convert.ToInt32(file.IndexOf("ServiceModels"+Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase) 
						+ ("ServiceModels"+Path.DirectorySeparatorChar).Length));

                var filePath = Path.Combine("customizations", baseName + ".customizations.json");
                var fileEntries = Directory.GetFiles(modelsPath, baseName + "*.customizations*.json");

                var jsonWriter = new JsonWriter {PrettyPrint = true};

                JsonData outputJson = new JsonData();
                outputJson.SetJsonType(JsonType.Object);

                foreach (var entry in fileEntries)
                {
                    var customJson = JsonMapper.ToObject(new StreamReader(entry));
                    foreach (var property in customJson.PropertyNames)
                    {
                        outputJson[property] = customJson[property];
                    }
                }

                // Load examples into the customizations as well

                var examples = Directory.GetFiles(modelsPath, baseName + ".examples.json").FirstOrDefault();
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

                File.WriteAllText(filePath, output);
                Console.WriteLine("...updated {0}", Path.GetFullPath(filePath));
            }
        }
    }
}
