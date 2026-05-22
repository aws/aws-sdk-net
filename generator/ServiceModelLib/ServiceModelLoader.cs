using System;
using System.IO;
using System.Linq;
using Json.LitJson;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Loads an AWS service model from a directory, automatically discovering
    /// and merging customization fragments, and returns a fully-customized
    /// ServiceModel ready for inspection.
    /// </summary>
    public static class ServiceModelLoader
    {
        /// <summary>
        /// Loads a service model from the given directory. Discovers the latest
        /// model file, merges all customization fragments in-memory, and optionally
        /// loads paginators.
        /// </summary>
        /// <param name="serviceDirectory">
        /// Path to a service directory containing *.normal.json, *.customizations*.json,
        /// and optionally *.paginators.json files.
        /// </param>
        /// <returns>A ServiceModel with all customizations applied.</returns>
        public static ServiceModel Load(string serviceDirectory)
        {
            if (!Directory.Exists(serviceDirectory))
                throw new DirectoryNotFoundException($"Service directory not found: {serviceDirectory}");

            var modelPath = GetLatestFile(serviceDirectory, "*.normal.json");
            if (modelPath == null)
                throw new FileNotFoundException($"No *.normal.json model file found in {serviceDirectory}");

            var paginatorsPath = GetLatestFile(serviceDirectory, "*.paginators.json");

            var mergedCustomizations = MergeCustomizationFragments(serviceDirectory);

            using (var modelReader = new StreamReader(modelPath))
            using (var customizationsReader = new StringReader(mergedCustomizations))
            {
                var model = new ServiceModel(modelReader, customizationsReader);

                if (paginatorsPath != null && File.Exists(paginatorsPath))
                {
                    using (var paginatorsReader = new StreamReader(paginatorsPath))
                    {
                        model.InitializePaginators(paginatorsReader);
                    }
                }

                return model;
            }
        }

        private static string MergeCustomizationFragments(string serviceDirectory)
        {
            var customizationFiles = Directory.GetFiles(serviceDirectory, "*.customizations*.json")
                .OrderBy(f => f)
                .ToArray();

            if (customizationFiles.Length == 0)
                return "{}";

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
            return writer.ToString();
        }

        private static JsonData MergeJsonData(JsonData target, JsonData source)
        {
            if (target.IsObject && source.IsObject)
            {
                foreach (var property in source.PropertyNames)
                {
                    if (target.PropertyNames.Contains(property))
                    {
                        target[property] = MergeJsonData(target[property], source[property]);
                    }
                    else
                    {
                        target[property] = source[property];
                    }
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

        private static string GetLatestFile(string directory, string pattern)
        {
            return Directory.GetFiles(directory, pattern, SearchOption.TopDirectoryOnly)
                .OrderBy(x => x)
                .LastOrDefault();
        }
    }
}
