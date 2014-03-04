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
    /// <para>The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache cluster nodes within a provisioned cache cluster. This API
    /// will apply any modified cache parameter groups to the cache cluster. The reboot action takes place as soon as possible, and results in a
    /// momentary outage to the cache cluster. During the reboot, the cache cluster status is set to REBOOTING.</para> <para>The reboot causes the
    /// contents of the cache (for each cache cluster node being rebooted) to be lost.</para> <para>When the reboot is complete, a cache cluster
    /// event is created.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
    public class RebootCacheClusterRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private List<string> cacheNodeIdsToReboot = new List<string>();

        /// <summary>
        /// The cache cluster identifier. This parameter is stored as a lowercase string.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// A list of cache cluster node IDs to reboot. A node ID is a numeric identifier (0001, 0002, etc.). To reboot an entire cache cluster, specify
        /// all of the cache cluster node IDs.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
    
