namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for EndpointTests.
    /// </summary>
    public class EndpointTests
    {
        public string service { get; set; }
        public string version { get; set; }
        public Test[] testCases { get; set; }
    }
}
