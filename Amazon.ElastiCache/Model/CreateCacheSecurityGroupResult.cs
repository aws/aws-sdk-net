
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the CreateCacheSecurityGroup action.
    /// </summary>
    public class CreateCacheSecurityGroupResult : AmazonWebServiceResponse
    {
        private CacheSecurityGroup cacheSecurityGroupValue;

        /// 
        /// Gets and sets the CreateCacheSecurityGroupResult property.
        /// Contains the result of a successful invocation of the CreateCacheSecurityGroup
        /// action.
        /// 
        public CacheSecurityGroup CacheSecurityGroup
        {
            get { return this.cacheSecurityGroupValue; }
            set { this.cacheSecurityGroupValue = value; }
        }
    }
}
    
