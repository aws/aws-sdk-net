namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for AuthSchema.
    /// </summary>
    public class AuthSchema
    {
        public string signingName { get; set; }
        public bool disableDoubleEncoding { get; set; }
        public string name { get; set; }
        public string signingRegion { get; set; }
        public string[] signingRegionSet { get; set; }
    }
}