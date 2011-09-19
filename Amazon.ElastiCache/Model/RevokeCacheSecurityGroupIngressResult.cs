
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the RevokeCacheSecurityGroupIngress action.
    /// </summary>
    public class RevokeCacheSecurityGroupIngressResult : AmazonWebServiceResponse
    {
        private CacheSecurityGroup cacheSecurityGroupValue;

        /// 
        /// Gets and sets the RevokeCacheSecurityGroupIngressResult property.
        /// Contains the result of a successful invocation of the RevokeCacheSecurityGroupIngress
        /// action.
        /// 
        public CacheSecurityGroup CacheSecurityGroup
        {
            get { return this.cacheSecurityGroupValue; }
            set { this.cacheSecurityGroupValue = value; }
        }
    }
}
    
