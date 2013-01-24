/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the RebootCacheCluster operation.
    /// <para> Reboots some (or all) of the cache cluster nodes within a previously provisioned ElastiCache cluster. This API results in the
    /// application of modified CacheParameterGroup parameters to the cache cluster. This action is taken as soon as possible, and results in a
    /// momentary outage to the cache cluster during which the cache cluster status is set to rebooting. During that momentary outage, the contents
    /// of the cache (for each cache cluster node being rebooted) are lost. A CacheCluster event is created when the reboot is completed. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
    public class RebootCacheClusterRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private List<string> cacheNodeIdsToReboot = new List<string>();

        /// <summary>
        /// The Cache Cluster identifier. This parameter is stored as a lowercase string.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        /// <summary>
        /// Sets the CacheClusterId property
        /// </summary>
        /// <param name="cacheClusterId">The value to set for the CacheClusterId property </param>
        /// <returns>this instance</returns>
        public RebootCacheClusterRequest WithCacheClusterId(string cacheClusterId)
        {
            this.cacheClusterId = cacheClusterId;
            return this;
        }
            

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// A list of Cache Cluster Node Ids to reboot. To reboot an entire cache cluster, specify all cache cluster node Ids.
        ///  
        /// </summary>
        public List<string> CacheNodeIdsToReboot
        {
            get { return this.cacheNodeIdsToReboot; }
            set { this.cacheNodeIdsToReboot = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeIdsToReboot collection
        /// </summary>
        /// <param name="cacheNodeIdsToReboot">The values to add to the CacheNodeIdsToReboot collection </param>
        /// <returns>this instance</returns>
        public RebootCacheClusterRequest WithCacheNodeIdsToReboot(params string[] cacheNodeIdsToReboot)
        {
            foreach (string element in cacheNodeIdsToReboot)
            {
                this.cacheNodeIdsToReboot.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeIdsToReboot collection
        /// </summary>
        /// <param name="cacheNodeIdsToReboot">The values to add to the CacheNodeIdsToReboot collection </param>
        /// <returns>this instance</returns>
        public RebootCacheClusterRequest WithCacheNodeIdsToReboot(IEnumerable<string> cacheNodeIdsToReboot)
        {
            foreach (string element in cacheNodeIdsToReboot)
            {
                this.cacheNodeIdsToReboot.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeIdsToReboot property is set
        internal bool IsSetCacheNodeIdsToReboot()
        {
            return this.cacheNodeIdsToReboot.Count > 0;
        }
    }
}
    
