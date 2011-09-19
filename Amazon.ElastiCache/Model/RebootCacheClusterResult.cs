
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the RebootCacheCluster action.
    /// </summary>
    public class RebootCacheClusterResult : AmazonWebServiceResponse
    {
        private CacheCluster cacheClusterValue;

        /// 
        /// Gets and sets the RebootCacheClusterResult property.
        /// Contains the result of a successful invocation of the RebootCacheCluster
        /// action.
        /// 
        public CacheCluster CacheCluster
        {
            get { return this.cacheClusterValue; }
            set { this.cacheClusterValue = value; }
        }
    }
}
    
