
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the DescribeEngineDefaultParameters action.
    /// </summary>
    public class DescribeEngineDefaultParametersResult : AmazonWebServiceResponse
    {
        private EngineDefaults engineDefaultsValue;

        /// 
        /// Gets and sets the DescribeEngineDefaultParametersResult property.
        /// Contains the result of a successful invocation of the DescribeEngineDefaultParameters
        /// action.
        /// 
        public EngineDefaults EngineDefaults
        {
            get { return this.engineDefaultsValue; }
            set { this.engineDefaultsValue = value; }
        }
    }
}
    
