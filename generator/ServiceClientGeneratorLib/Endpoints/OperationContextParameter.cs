using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for OperationContextParameter
    /// </summary>
    public class OperationContextParameter
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Parameter path
        /// </summary>
        public string path { get; set; }

        public string GetNativeValue(Shape requestStructure)
        {
            return Utils.JMESPathToNativeValue(path, requestStructure);
        }
    }
}
