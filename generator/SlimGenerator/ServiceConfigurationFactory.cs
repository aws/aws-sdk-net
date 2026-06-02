using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Json.LitJson;
using ServiceClientGenerator;
using ServiceClientGenerator.Endpoints;
using ServiceClientGenerator.Endpoints.Tests;

namespace SlimGenerator
{
    internal static class ServiceConfigurationFactory
    {
        public static ServiceConfiguration CreateFromModelDirectory(string serviceDirectory, string customizationsPath)
        {
            var modelPath = GetLatestFile(serviceDirectory, "*.normal.json");
            if (modelPath == null)
                throw new FileNotFoundException($"No *.normal.json model file found in {serviceDirectory}");

            var paginatorsPath = GetLatestFile(serviceDirectory, "*.paginators.json") ?? "";

            var modelName = Path.GetFileName(serviceDirectory);

            var metadataJsonPath = Path.Combine(serviceDirectory, "metadata.json");
            string legacyServiceId = null;
            if (File.Exists(metadataJsonPath))
            {
                var metadataJson = JsonMapper.ToObject(File.ReadAllText(metadataJsonPath));
                if (metadataJson["legacy-service-id"] != null)
                    legacyServiceId = metadataJson["legacy-service-id"].ToString();
            }

            var config = new ServiceConfiguration
            {
                ModelName = modelName,
                ModelPath = modelPath,
                PaginatorsPath = paginatorsPath,
                CustomizationsPath = customizationsPath,
                GenerateConstructors = true,
                ServiceFileVersion = "4.0.0.0",
            };

            if (legacyServiceId != null)
                config.LegacyServiceId = legacyServiceId;

            config.SdkDependencies = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                { "Core", "4.0.0.0" }
            };

            if (config.ServiceModel.Type == ServiceType.Cbor)
            {
                config.SdkDependencies["Extensions.CborProtocol"] = "4.0.0.0";
            }

            LoadEndpointRuleSet(serviceDirectory, config);

            return config;
        }

        private static void LoadEndpointRuleSet(string serviceDirectory, ServiceConfiguration config)
        {
            var rulesetFile = Directory.GetFiles(serviceDirectory, "*.endpoint-rule-set.json", SearchOption.TopDirectoryOnly)
                .OrderBy(x => x).LastOrDefault();
            var testsFile = Directory.GetFiles(serviceDirectory, "*.endpoint-tests.json", SearchOption.TopDirectoryOnly)
                .OrderBy(x => x).LastOrDefault();

            if (rulesetFile != null)
            {
                var json = File.ReadAllText(rulesetFile);
                config.EndpointsRuleSet = JsonMapper.ToObject<RuleSet>(json);

                if (testsFile != null)
                {
                    json = File.ReadAllText(testsFile);
                    config.EndpointTests = JsonMapper.ToObject<EndpointTests>(json, true);
                }
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
