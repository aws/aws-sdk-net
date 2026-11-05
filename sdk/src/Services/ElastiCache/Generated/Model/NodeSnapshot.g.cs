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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// A unique identifier for the source cluster.
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheNodeCreateTime. 
        /// <para>
        /// The date and time when the cache node was created in the source cluster.
        /// </para>
        /// </summary>
        public DateTime? CacheNodeCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeCreateTime property is set.
        /// </summary>
        internal bool IsSetCacheNodeCreateTime() => this.CacheNodeCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The cache node identifier for the node in the source cluster.
        /// </para>
        /// </summary>
        public string CacheNodeId { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeId property is set.
        /// </summary>
        internal bool IsSetCacheNodeId() => this.CacheNodeId != null;

        /// <summary>
        /// Gets and sets the property CacheSize. 
        /// <para>
        /// The size of the cache on the source cache node.
        /// </para>
        /// </summary>
        public string CacheSize { get; set; }

        /// <summary>
        /// Checks to see if the CacheSize property is set.
        /// </summary>
        internal bool IsSetCacheSize() => this.CacheSize != null;

        /// <summary>
        /// Gets and sets the property NodeGroupConfiguration. 
        /// <para>
        /// The configuration for the source node group (shard).
        /// </para>
        /// </summary>
        public NodeGroupConfiguration NodeGroupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupConfiguration property is set.
        /// </summary>
        internal bool IsSetNodeGroupConfiguration() => this.NodeGroupConfiguration != null;

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// A unique identifier for the source node group (shard).
        /// </para>
        /// </summary>
        public string NodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupId property is set.
        /// </summary>
        internal bool IsSetNodeGroupId() => this.NodeGroupId != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// The date and time when the source node's metadata and cache data set was obtained
        /// for the snapshot.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime.HasValue;
    }
}
