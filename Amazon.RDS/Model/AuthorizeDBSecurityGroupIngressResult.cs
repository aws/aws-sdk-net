
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The results from the AuthorizeDBSecurityGroupIngress action.
    /// </summary>
    public class AuthorizeDBSecurityGroupIngressResult : AmazonWebServiceResponse
    {
        private DBSecurityGroup dBSecurityGroupValue;

        /// 
        /// Gets and sets the AuthorizeDBSecurityGroupIngressResult property.
        /// Contains the result of a successful invocation of the AuthorizeDBSecurityGroupIngress
        /// action.
        /// 
        public DBSecurityGroup DBSecurityGroup
        {
            get { return this.dBSecurityGroupValue; }
            set { this.dBSecurityGroupValue = value; }
        }
    }
}
    
