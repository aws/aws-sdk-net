
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the CreateCacheCluster action.
    /// </summary>
    public class CreateCacheClusterResult : AmazonWebServiceResponse
    {
        private CacheCluster cacheClusterValue;

        /// 
        /// Gets and sets the CreateCacheClusterResult property.
        /// Contains the result of a successful invocation of the CreateCacheCluster
        /// action.
        /// 
        public CacheCluster CacheCluster
        {
            get { return this.cacheClusterValue; }
            set { this.cacheClusterValue = value; }
        }
    }
}
    
