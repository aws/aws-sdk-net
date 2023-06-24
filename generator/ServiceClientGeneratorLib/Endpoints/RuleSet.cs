using System.Collections.Generic;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Endpoints RuleSet
    /// </summary>
    public class RuleSet
    {
        /// <summary>
        /// RuleSet version
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// RuleSet applies to ServiceId
        /// </summary>
        public string serviceId { get; set; }
        /// <summary>
        /// Set of RuleSet parameters
        /// </summary>
        public Dictionary<string, Parameter> parameters { get; set; }
        /// <summary>
        /// Set of RuleSet rules
        /// </summary>
        public Rule[] rules { get; set; }
    }
}
