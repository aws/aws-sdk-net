using System.IO;
using System.Linq;
using Json.LitJson;

namespace SlimGenerator
{
    internal static class CustomizationHelper
    {
        /// <summary>
        /// Merges all *.customizations*.json fragments in the service directory
        /// into a single temp file and returns its path.
        /// </summary>
        public static string CompileCustomizations(string serviceDirectory)
        {
            var customizationFiles = Directory.GetFiles(serviceDirectory, "*.customizations*.json")
                .OrderBy(f => f)
                .ToArray();

            JsonData outputJson = new JsonData();
            outputJson.SetJsonType(JsonType.Object);

            foreach (var file in customizationFiles)
            {
                using (var reader = new StreamReader(file))
                {
                    var customJson = JsonMapper.ToObject(reader);
                    foreach (var property in customJson.PropertyNames)
                    {
                        if (outputJson.PropertyNames.Contains(property))
                        {
                            outputJson[property] = MergeJsonData(outputJson[property], customJson[property]);
                        }
                        else
                        {
                            outputJson[property] = customJson[property];
                        }
                    }
                }
            }

            var writer = new JsonWriter { PrettyPrint = false };
            outputJson.ToJson(writer);
            var merged = writer.ToString();

            var tempPath = Path.Combine(Path.GetTempPath(), $"slim-gen-{Path.GetFileName(serviceDirectory)}.customizations.json");
            File.WriteAllText(tempPath, merged);
            return tempPath;
        }

        private static JsonData MergeJsonData(JsonData target, JsonData source)
        {
            if (target.IsObject && source.IsObject)
            {
                foreach (var property in source.PropertyNames)
                {
                    if (target.PropertyNames.Contains(property))
                        target[property] = MergeJsonData(target[property], source[property]);
                    else
                        target[property] = source[property];
                }
                return target;
            }
            else if (target.IsArray && source.IsArray)
            {
                JsonData mergedArray = new JsonData();
                mergedArray.SetJsonType(JsonType.Array);
                for (int i = 0; i < target.Count; i++)
                    mergedArray.Add(target[i]);
                for (int i = 0; i < source.Count; i++)
                    mergedArray.Add(source[i]);
                return mergedArray;
            }
            else
            {
                return source;
            }
        }
    }
}
