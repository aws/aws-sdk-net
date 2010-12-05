
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the CreateDBSecurityGroup action.
    /// </summary>
    public class CreateDBSecurityGroupResult : AmazonWebServiceResponse
    {
        private DBSecurityGroup dBSecurityGroupValue;

        /// 
        /// Gets and sets the CreateDBSecurityGroupResult property.
        /// Contains the result of a successful invocation of the CreateDBSecurityGroup
        /// action.
        /// 
        public DBSecurityGroup DBSecurityGroup
        {
            get { return this.dBSecurityGroupValue; }
            set { this.dBSecurityGroupValue = value; }
        }
    }
}
    
