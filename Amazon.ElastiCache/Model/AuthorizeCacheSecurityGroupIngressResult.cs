
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the AuthorizeCacheSecurityGroupIngress action.
    /// </summary>
    public class AuthorizeCacheSecurityGroupIngressResult : AmazonWebServiceResponse
    {
        private CacheSecurityGroup cacheSecurityGroupValue;

        /// 
        /// Gets and sets the AuthorizeCacheSecurityGroupIngressResult property.
        /// Contains the result of a successful invocation of the AuthorizeCacheSecurityGroupIngress
        /// action.
        /// 
        public CacheSecurityGroup CacheSecurityGroup
        {
            get { return this.cacheSecurityGroupValue; }
            set { this.cacheSecurityGroupValue = value; }
        }
    }
}
    
