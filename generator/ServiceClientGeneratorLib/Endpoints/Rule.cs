using System;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Rule Types
    /// </summary>
    public enum RuleType
    {
        /// <summary>
        /// Rule resolves to error
        /// </summary>
        Error,
        /// <summary>
        /// Rule resolves to endpoint
        /// </summary>
        Endpoint,
        /// <summary>
        /// Rule delegates resolution to inner (tree) rules
        /// </summary>
        Tree
    }

    /// <summary>
    /// Object model for Endpoints Rule
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// Rule type raw value
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Rule type
        /// </summary>
        public RuleType Type
        {
            get
            {
                switch (type.ToLower())
                {
                    case "tree": return RuleType.Tree;
                    case "endpoint": return RuleType.Endpoint;
                    case "error": return RuleType.Error;
                    default:  throw new Exception("Unknown rule type.");
                }
            }
        }

        /// <summary>
        /// Rule documentation
        /// </summary>
        public string documentation { get; set; }

        /// <summary>
        /// Set of conditions for a rule.
        /// Rule is resolved when all conditions are met (logical AND)
        /// Rule can be resolved into endpoint, error or delegate resolution to other inner rules (tree rule)
        /// </summary>
        public Condition[] conditions { get; set; }

        /// <summary>
        /// Rule resolves to an endpoint
        /// </summary>
        public EndpointData endpoint { get; set; }

        /// <summary>
        /// Rule resolves to an error
        /// </summary>
        public string error { get; set; }

        /// <summary>
        /// Rule delegates final resolution to inner (tree) rules
        /// </summary>
        public Rule[] rules { get; set; }
    }
}
