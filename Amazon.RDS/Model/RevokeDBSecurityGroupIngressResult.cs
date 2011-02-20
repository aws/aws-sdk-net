
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the RevokeDBSecurityGroupIngress action.
    /// </summary>
    public class RevokeDBSecurityGroupIngressResult : AmazonWebServiceResponse
    {
        private DBSecurityGroup dBSecurityGroupValue;

        /// 
        /// Gets and sets the RevokeDBSecurityGroupIngressResult property.
        /// Contains the result of a successful invocation of the RevokeDBSecurityGroupIngress
        /// action.
        /// 
        public DBSecurityGroup DBSecurityGroup
        {
            get { return this.dBSecurityGroupValue; }
            set { this.dBSecurityGroupValue = value; }
        }
    }
}
    
