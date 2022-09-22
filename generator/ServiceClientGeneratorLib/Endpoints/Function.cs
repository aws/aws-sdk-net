using Json.LitJson;
using System.Collections.Generic;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Function
    /// </summary>
    public class Function
    {
        public Function(string name, JsonData arguments, string assign = null)
        {
            Name = name;
            foreach (JsonData arg in arguments)
            {
                Arguments.Add(Argument.BuildFrom(arg));
            }
            Assign = assign;
        }

        public string Name { get; set; }

        public List<Argument> Arguments { get; set; } = new List<Argument>(); // string value | boolean value | Reference | Function

        /// <summary>
        /// Assign function to internal reference which can be used in other ruleset conditions
        /// </summary>
        public string Assign { get; set; }
    }
}
