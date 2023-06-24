using Json.LitJson;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for StaticContextParameter
    /// StaticContextParameter used to map static value from service operation to ruleset parameter
    /// </summary>
    public class StaticContextParameter
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Parameter value
        /// </summary>
        public JsonData value { get; set; }

        /// <summary>
        /// Parameter native C# value
        /// </summary>
        public string nativeValue { get { return value.ToNativeValue(); } }
    }
}
