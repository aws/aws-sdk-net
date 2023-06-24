using Json.LitJson;
using System.Collections.Generic;

namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for Endpoint.
    /// </summary>
    public class Endpoint
    {
        public string url { get; set; }
        public EndpointProperties properties { get; set; }
        public JsonData headers { get; set; }
    }
}
