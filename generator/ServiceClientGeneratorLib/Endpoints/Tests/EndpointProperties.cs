namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for EndpointProperties.
    /// </summary>
    public class EndpointProperties
    {
        public AuthSchema[] authSchemes { get; set; }
        public string backend { get; set; }
        public string bucketType { get; set; }
    }
}