using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace CustomTasks.Endpoint
{
    /// <summary>
    /// Implementation of a IEndpointOverrider
    /// Endpoint overrider: will override the endpoints.json file and remove/add endpoints
    /// Based on a json input file for addition and removal
    /// </summary>
    public class EndpointOverrider : IEndpointOverrider
    {
        private readonly IFileSystem _fs;

        public EndpointOverrider() : this(new FileSystem()) { }

        public EndpointOverrider(IFileSystem fs)
        {
            _fs = fs;
        }

        /// <summary>
        /// Applies overrides to an endpoints.json file
        /// </summary>
        /// <param name="endpointsJsonSourceFilePath">The endpoints-original.json source location</param>
        /// <param name="endpointsOverrideFilePath">The path to the endpoints override json file</param>
        /// <returns>String: the new endpoints.json input text.</returns>
        public string ApplyOverrides(string endpointsJsonSourceFilePath, string endpointsOverrideFilePath)
        {
            // Retrieve the current endpoints-original.json file
            string input = _fs.ReadAllText(endpointsJsonSourceFilePath);


            JObject endpointsData = JObject.Parse(input);

            // Retrieve the endpoints-override.json file
            string overrideJson = _fs.ReadAllText(endpointsOverrideFilePath);
            if (!string.IsNullOrWhiteSpace(overrideJson))
            {
                JObject configuration = JObject.Parse(overrideJson);
                if (configuration != null)
                {
                    foreach (var service in configuration.Children())
                    {
                        var servicePrefix = service.Path;
                        JToken serviceNode = endpointsData["partitions"][0]["services"][servicePrefix];
                        if (serviceNode != null)
                        {
                            JObject endpointsNode = serviceNode["endpoints"] as JObject;

                            var endpointsToRemove = configuration.SelectTokens($"{servicePrefix}.remove");
                            foreach (var endpointToRemove in endpointsToRemove.Children())
                            {
                                endpointsNode.Remove(endpointToRemove.ToObject<string>());
                            }
                            var endpointsToAdd = configuration.SelectTokens($"{servicePrefix}.add");
                            foreach (var endpointToAdd in endpointsToAdd.Children())
                            {
                                // We can not have two properties with the same name
                                var endpointProperty = endpointToAdd as JProperty;
                                var exists = endpointsNode.Properties().ToList().Exists(p => p.Name == endpointProperty.Name);
                                if (!exists)
                                {
                                    endpointsNode.Add(endpointToAdd);
                                }
                                else
                                {
                                    throw new InvalidOperationException($"The endpoint {endpointProperty.Name} already exists for service {servicePrefix}");
                                }
                            }
                        }
                        else
                        {
                            throw new InvalidOperationException($"The service {servicePrefix} does not exist in the endpoints.json file");
                        }
                    }
                }
            }

            var targetPath = Path.Combine(Path.GetDirectoryName(endpointsJsonSourceFilePath), "endpoints.json");
            string output = JsonConvert.SerializeObject(endpointsData, Formatting.Indented);
            _fs.WriteAllText(targetPath, output);
            return output;
        }
    }
}
