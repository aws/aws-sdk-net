
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the CreateDBParameterGroup action.
    /// </summary>
    public class CreateDBParameterGroupResult : AmazonWebServiceResponse
    {
        private DBParameterGroup dBParameterGroupValue;

        /// 
        /// Gets and sets the CreateDBParameterGroupResult property.
        /// Contains the result of a successful invocation of the CreateDBParameterGroup
        /// action.
        /// 
        public DBParameterGroup DBParameterGroup
        {
            get { return this.dBParameterGroupValue; }
            set { this.dBParameterGroupValue = value; }
        }
    }
}
    
