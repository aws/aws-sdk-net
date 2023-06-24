using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Condition.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Standard function name (lower-case)
        /// </summary>
        public string fn { get; set; }
        /// <summary>
        /// Standard function arguments
        /// </summary>
        public JsonData argv { get; set; }

        private Function _function;
        /// <summary>
        /// Object model for standard function
        /// </summary>
        public Function Function
        { 
            get 
            {
                if (_function == null)
                {
                    _function = new Function(fn, argv, assign);
                }
                return _function;
            }
        }

        /// <summary>
        /// Name of the internal reference you can assign function result to.
        /// This reference can be used in other ruleset conditions/functions as a parameter.
        /// </summary>
        public string assign { get; set; }
    }
}
