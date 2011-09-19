
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The results from the ModifyCacheCluster action.
    /// </summary>
    public class ModifyCacheClusterResult : AmazonWebServiceResponse
    {
        private CacheCluster cacheClusterValue;

        /// 
        /// Gets and sets the ModifyCacheClusterResult property.
        /// Contains the result of a successful invocation of the ModifyCacheCluster
        /// action.
        /// 
        public CacheCluster CacheCluster
        {
            get { return this.cacheClusterValue; }
            set { this.cacheClusterValue = value; }
        }
    }
}
    
