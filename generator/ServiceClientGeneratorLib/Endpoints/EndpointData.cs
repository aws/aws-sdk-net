using Json.LitJson;
using System.Collections.Generic;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Endpoint data
    /// </summary>
    public class EndpointData
    {
        /// <summary>
        /// Endpoint URL
        /// </summary>
        public JsonData url { get; set; }
        /// <summary>
        /// Property bag for various properties assosiated with Endpoint
        /// </summary>
        public JsonData properties { get; set; }
        /// <summary>
        /// Set of headers required for Endpoint
        /// </summary>
        public JsonData headers { get; set; }
    }
}
