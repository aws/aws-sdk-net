using Json.LitJson;

namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for Expectation.
    /// </summary>
    public class Expectation
    {
        public Endpoint endpoint { get; set; }
        public string error { get; set; }
    }
}