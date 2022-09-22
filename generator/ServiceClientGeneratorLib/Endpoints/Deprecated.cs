namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Endpoints Parameter's deprecated attribute
    /// Used to mark parameter as [Obsolete]
    /// </summary>
    public class Deprecated
    {
        /// <summary>
        /// Deprecation message
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// Deprecated since
        /// </summary>
        public string since { get; set; }
    }
}
