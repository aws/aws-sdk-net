using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Build.Framework;

using System.IO;

using Newtonsoft.Json;

namespace CustomTasks
{
    public class PlaceModelTask : BuildTaskBase
    {
        public const string METADATA_JSON = "metadata.json";
        public const string SERVICE_MODEL_PATH = "generator\\ServiceModels";

        public string SDKRepoPath { get; set; }

        public string ModelPath { get; set; }
        public string ServicePrefix { get; set; }

        [Output]
        public string BaseName { get; set; }

        public PlaceModelTask()
        {
            WaitForDebugger = true;
        }

        public override bool Execute()
        {
            string apiVersion = GetAPIVersion(ModelPath);
            string c2jFileName = string.Format("{0}-{1}.normal.json", ServicePrefix, apiVersion);
            string serviceModelDirectory = Path.Combine(SDKRepoPath, SERVICE_MODEL_PATH, ServicePrefix);

            if (!Directory.Exists(serviceModelDirectory))
            {
                Directory.CreateDirectory(serviceModelDirectory);
            }

            File.Copy(ModelPath, Path.Combine(serviceModelDirectory, c2jFileName), /* overwrite = */ true);

            BaseName = GetBaseName(serviceModelDirectory, c2jFileName);

            return true;
        }

        private string GetAPIVersion(string modelPath)
        {
            C2JModel c2jModel = JsonConvert.DeserializeObject<C2JModel>(
                                    File.ReadAllText(modelPath));
            C2JMetadata metadata = c2jModel.Metadata;

            return metadata.APIVersion;
        }

        private string GetBaseName(string directory, string modelName)
        {
            string baseName = "";

            try {
                var metadatapath = Path.Combine(directory, METADATA_JSON);
                Metadata metadatajson = new Metadata();
                if (File.Exists(metadatapath))
                {
                    metadatajson = JsonConvert.DeserializeObject<Metadata>(
                                    File.ReadAllText(metadatapath));
                }
                else
                {
                    metadatajson.Active = true;
                    metadatajson.Synopsis = "Generated from self-service";
                    File.WriteAllText(metadatapath, JsonConvert.SerializeObject(metadatajson));
                }

                baseName = metadatajson.BaseName;
            } catch {};

            if (string.IsNullOrEmpty(baseName))
            {
                C2JModel c2jModel = JsonConvert.DeserializeObject<C2JModel>(
                                    File.ReadAllText(Path.Combine(directory, modelName)));
                C2JMetadata metadata = c2jModel.Metadata;

                if (!string.IsNullOrEmpty(metadata.ServiceAbbreviation))
                {
                    baseName = SanitizeStringForClassName(metadata.ServiceAbbreviation);
                }
                else if (!string.IsNullOrEmpty(metadata.ServiceFullName))
                {
                    baseName = SanitizeStringForClassName(metadata.ServiceFullName);
                }
            }

            return baseName;
        }

        private static string SanitizeStringForClassName(string name)
        {
            string className = name;
            className = className.Replace("AWS", "");
            className = className.Replace("Amazon", "");

            // concatenate all the words by removing whitespace.
            className = System.Text.RegularExpressions.Regex.Replace(className, @"[^a-zA-Z0-9]", "");

            return className;
        }

        private class Metadata
        {
            [JsonProperty("active")]
            public bool Active { get; set; }

            [JsonProperty("base-name")]
            public string BaseName { get; set; }

            [JsonProperty("synopsis")]
            public string Synopsis { get; set; }
        }

        private class C2JMetadata
        {
            [JsonProperty("serviceAbbreviation")]
            public string ServiceAbbreviation { get; set; }

            [JsonProperty("serviceFullName")]
            public string ServiceFullName { get; set; }

            [JsonProperty("apiVersion")]
            public string APIVersion { get; set; }
        }

        private class C2JModel
        {
            [JsonProperty("metadata")]
            public C2JMetadata Metadata { get; set; }
        }
    }
}
