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
            if (Directory.Exists("customizations"))
            {
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

            string[] fileServices = Directory.GetFiles(modelsPath, "*.customizations*.json");

            foreach (var file in fileServices)
            {
                // The name before the .customizations extension
                // Used to get all files for that service
                var baseName = file.Substring(file.IndexOf("ServiceModels\\") + "ServiceModels\\".Length, file.IndexOf(".customizations") - Convert.ToInt32(file.IndexOf("ServiceModels\\") + "ServiceModels\\".Length));

                var filePath = "customizations\\" + baseName + ".customizations.json";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                string[] fileEntries = Directory.GetFiles(modelsPath, baseName + "*.customizations*.json");

                var jsonWriter = new JsonWriter();
                jsonWriter.PrettyPrint = true;
                jsonWriter.WriteObjectStart();

                foreach (var entry in fileEntries)
                {
                    var customJson = JsonMapper.ToObject(new StreamReader(entry));
                    foreach (var property in customJson.PropertyNames)
                    {
                        jsonWriter.WritePropertyName(property);
                        jsonWriter.Write(customJson[property].ToJson());
                    }
                }

                jsonWriter.WriteObjectEnd();
                
                // Fixes json being placed into the json mapper
                var output = jsonWriter.ToString().Replace("\\\"", "\"").Replace("\"{", "{").Replace("}\"", "}").Replace("\"[", "[").Replace("]\"", "]");
                
                // Empty json file
                if (jsonWriter.ToString().Length < 10)
                    continue;

                
                File.WriteAllText(filePath, output);
                Console.WriteLine("\tUpdated {0}", Path.GetFullPath(filePath));
            }
        }
    }
}
