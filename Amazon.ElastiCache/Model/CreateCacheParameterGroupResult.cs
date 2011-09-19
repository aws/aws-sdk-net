
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the CreateCacheParameterGroup action.
    /// </summary>
    public class CreateCacheParameterGroupResult : AmazonWebServiceResponse
    {
        private CacheParameterGroup cacheParameterGroupValue;

        /// 
        /// Gets and sets the CreateCacheParameterGroupResult property.
        /// Contains the result of a successful invocation of the CreateCacheParameterGroup
        /// action.
        /// 
        public CacheParameterGroup CacheParameterGroup
        {
            get { return this.cacheParameterGroupValue; }
            set { this.cacheParameterGroupValue = value; }
        }
    }
}
    
