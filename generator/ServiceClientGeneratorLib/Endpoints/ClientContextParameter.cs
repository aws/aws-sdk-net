
namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for ClientContextParameter
    /// ClientContextParameter is used to extend ClientConfig with new properties
    /// </summary>
    public class ClientContextParameter
    {
        public string name { get; set; }
        public string documentation { get; set; }
        public string type { get; set; }
        public string nativeType { get { return type.ToNativeType(); } }
    }
}
