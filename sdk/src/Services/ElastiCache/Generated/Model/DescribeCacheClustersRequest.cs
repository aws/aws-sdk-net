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
    /// Container for the parameters to the DescribeCacheClusters operation.
    /// Returns information about all provisioned clusters if no cluster identifier is specified,
    /// or about a specific cache cluster if a cluster identifier is supplied.
    /// 
    ///  
    /// <para>
    /// By default, abbreviated information about the clusters is returned. You can use the
    /// optional <i>ShowCacheNodeInfo</i> flag to retrieve detailed information about the
    /// cache nodes associated with the clusters. These details include the DNS address and
    /// port for the cache node endpoint.
    /// </para>
    ///  
    /// <para>
    /// If the cluster is in the <i>creating</i> state, only cluster-level information is
    /// displayed until all of the nodes are successfully provisioned.
    /// </para>
    ///  
    /// <para>
    /// If the cluster is in the <i>deleting</i> state, only cluster-level information is
    /// displayed.
    /// </para>
    ///  
    /// <para>
    /// If cache nodes are currently being added to the cluster, node endpoint information
    /// and creation time for the additional nodes are not displayed until they are completely
    /// provisioned. When the cluster state is <i>available</i>, the cluster is ready for
    /// use.
    /// </para>
    ///  
    /// <para>
    /// If cache nodes are currently being removed from the cluster, no endpoint information
    /// for the removed nodes is displayed.
    /// </para>
    /// </summary>
    public partial class DescribeCacheClustersRequest : AmazonElastiCacheRequest
    {
        private string _cacheClusterId;
        private string _marker;
        private int? _maxRecords;
        private bool? _showCacheClustersNotInReplicationGroups;
        private bool? _showCacheNodeInfo;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeCacheClustersRequest() { }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The user-supplied cluster identifier. If this parameter is specified, only information
        /// about that specific cluster is returned. This parameter isn't case sensitive.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a marker is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShowCacheClustersNotInReplicationGroups. 
        /// <para>
        /// An optional flag that can be included in the <c>DescribeCacheCluster</c> request to
        /// show only nodes (API/CLI: clusters) that are not members of a replication group. In
        /// practice, this means Memcached and single node Valkey or Redis OSS clusters.
        /// </para>
        /// </summary>
        public bool? ShowCacheClustersNotInReplicationGroups
        {
            get { return this._showCacheClustersNotInReplicationGroups; }
            set { this._showCacheClustersNotInReplicationGroups = value; }
        }

        // Check to see if ShowCacheClustersNotInReplicationGroups property is set
        internal bool IsSetShowCacheClustersNotInReplicationGroups()
        {
            return this._showCacheClustersNotInReplicationGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShowCacheNodeInfo. 
        /// <para>
        /// An optional flag that can be included in the <c>DescribeCacheCluster</c> request to
        /// retrieve information about the individual cache nodes.
        /// </para>
        /// </summary>
        public bool? ShowCacheNodeInfo
        {
            get { return this._showCacheNodeInfo; }
            set { this._showCacheNodeInfo = value; }
        }

        // Check to see if ShowCacheNodeInfo property is set
        internal bool IsSetShowCacheNodeInfo()
        {
            return this._showCacheNodeInfo.HasValue; 
        }

    }
}