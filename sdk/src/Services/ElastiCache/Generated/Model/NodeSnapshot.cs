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
    /// Represents an individual cache node in a snapshot of a cluster.
    /// </summary>
    public partial class NodeSnapshot
    {
        private string _cacheClusterId;
        private DateTime? _cacheNodeCreateTime;
        private string _cacheNodeId;
        private string _cacheSize;
        private NodeGroupConfiguration _nodeGroupConfiguration;
        private string _nodeGroupId;
        private DateTime? _snapshotCreateTime;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// A unique identifier for the source cluster.
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
        /// Gets and sets the property CacheNodeCreateTime. 
        /// <para>
        /// The date and time when the cache node was created in the source cluster.
        /// </para>
        /// </summary>
        public DateTime? CacheNodeCreateTime
        {
            get { return this._cacheNodeCreateTime; }
            set { this._cacheNodeCreateTime = value; }
        }

        // Check to see if CacheNodeCreateTime property is set
        internal bool IsSetCacheNodeCreateTime()
        {
            return this._cacheNodeCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The cache node identifier for the node in the source cluster.
        /// </para>
        /// </summary>
        public string CacheNodeId
        {
            get { return this._cacheNodeId; }
            set { this._cacheNodeId = value; }
        }

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this._cacheNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property CacheSize. 
        /// <para>
        /// The size of the cache on the source cache node.
        /// </para>
        /// </summary>
        public string CacheSize
        {
            get { return this._cacheSize; }
            set { this._cacheSize = value; }
        }

        // Check to see if CacheSize property is set
        internal bool IsSetCacheSize()
        {
            return this._cacheSize != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupConfiguration. 
        /// <para>
        /// The configuration for the source node group (shard).
        /// </para>
        /// </summary>
        public NodeGroupConfiguration NodeGroupConfiguration
        {
            get { return this._nodeGroupConfiguration; }
            set { this._nodeGroupConfiguration = value; }
        }

        // Check to see if NodeGroupConfiguration property is set
        internal bool IsSetNodeGroupConfiguration()
        {
            return this._nodeGroupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// A unique identifier for the source node group (shard).
        /// </para>
        /// </summary>
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// The date and time when the source node's metadata and cache data set was obtained
        /// for the snapshot.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime
        {
            get { return this._snapshotCreateTime; }
            set { this._snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this._snapshotCreateTime.HasValue; 
        }

    }
}