/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the RebootCacheCluster operation.
    /// Reboots some, or all, of the cache nodes within a provisioned cluster. This operation
    /// applies any modified cache parameter groups to the cluster. The reboot operation takes
    /// place as soon as possible, and results in a momentary outage to the cluster. During
    /// the reboot, the cluster status is set to REBOOTING.
    /// 
    ///  
    /// <para>
    /// The reboot causes the contents of the cache (for each cache node being rebooted) to
    /// be lost.
    /// </para>
    ///  
    /// <para>
    /// When the reboot is complete, a cluster event is created.
    /// </para>
    ///  
    /// <para>
    /// Rebooting a cluster is currently supported on Memcached, Valkey and Redis OSS (cluster
    /// mode disabled) clusters. Rebooting is not supported on Valkey or Redis OSS (cluster
    /// mode enabled) clusters.
    /// </para>
    ///  
    /// <para>
    /// If you make changes to parameters that require a Valkey or Redis OSS (cluster mode
    /// enabled) cluster reboot for the changes to be applied, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/nodes.rebooting.html">Rebooting
    /// a Cluster</a> for an alternate process.
    /// </para>
    /// </summary>
    public partial class RebootCacheClusterRequest : AmazonElastiCacheRequest
    {
        private string _cacheClusterId;
        private List<string> _cacheNodeIdsToReboot = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RebootCacheClusterRequest() { }

        /// <summary>
        /// Instantiates RebootCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The cluster identifier. This parameter is stored as a lowercase string.</param>
        /// <param name="cacheNodeIdsToReboot">A list of cache node IDs to reboot. A node ID is a numeric identifier (0001, 0002, etc.). To reboot an entire cluster, specify all of the cache node IDs.</param>
        public RebootCacheClusterRequest(string cacheClusterId, List<string> cacheNodeIdsToReboot)
        {
            _cacheClusterId = cacheClusterId;
            _cacheNodeIdsToReboot = cacheNodeIdsToReboot;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cluster identifier. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CacheNodeIdsToReboot. 
        /// <para>
        /// A list of cache node IDs to reboot. A node ID is a numeric identifier (0001, 0002,
        /// etc.). To reboot an entire cluster, specify all of the cache node IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CacheNodeIdsToReboot
        {
            get { return this._cacheNodeIdsToReboot; }
            set { this._cacheNodeIdsToReboot = value; }
        }

        // Check to see if CacheNodeIdsToReboot property is set
        internal bool IsSetCacheNodeIdsToReboot()
        {
            return this._cacheNodeIdsToReboot != null && (this._cacheNodeIdsToReboot.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}