using Json.LitJson;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Endpoints Parameter
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Parameter type
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// Parameter builtIn type
        /// </summary>
        public string builtIn { get; set; }
        /// <summary>
        /// Parameter default value
        /// </summary>
        public JsonData @default { get; set; }
        /// <summary>
        /// Parameter required
        /// </summary>
        public bool required { get; set; }
        /// <summary>
        /// Parameter documentation
        /// </summary>
        public string documentation { get; set; }
        /// <summary>
        /// Parameter deprecation information
        /// </summary>
        public Deprecated deprecated { get; set; }

        /// <summary>
        /// Native C# value for parameter's default value
        /// </summary>
        public string DefaultValue
        {
            get
            {
                if (@default == null) return null;
                if (@default.IsBoolean) return ((bool)@default).ToString().ToLower(); // true | false
                if (@default.IsString) return $@"""{@default}""";
                return null;
            }
        }
    }
}
