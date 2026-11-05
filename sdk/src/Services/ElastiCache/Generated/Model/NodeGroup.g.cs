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
    /// Represents a collection of cache nodes in a replication group. One node in the node
    /// group is the read/write primary node. All the other nodes are read-only Replica nodes.
    /// </summary>
    public partial class NodeGroup
    {
        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// The identifier for the node group (shard). A Valkey or Redis OSS (cluster mode disabled)
        /// replication group contains only 1 node group; therefore, the node group ID is 0001.
        /// A Valkey or Redis OSS (cluster mode enabled) replication group contains 1 to 90 node
        /// groups numbered 0001 to 0090. Optionally, the user can provide the id for a node group.
        /// 
        /// </para>
        /// </summary>
        public string NodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupId property is set.
        /// </summary>
        internal bool IsSetNodeGroupId() => this.NodeGroupId != null;

        /// <summary>
        /// Gets and sets the property NodeGroupMembers. 
        /// <para>
        /// A list containing information about individual nodes within the node group (shard).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeGroupMember> NodeGroupMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeGroupMember>() : null;

        /// <summary>
        /// Checks to see if the NodeGroupMembers property is set.
        /// </summary>
        internal bool IsSetNodeGroupMembers() => this.NodeGroupMembers != null && (this.NodeGroupMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrimaryEndpoint. 
        /// <para>
        /// The endpoint of the primary node in this node group (shard).
        /// </para>
        /// </summary>
        public Endpoint PrimaryEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEndpoint property is set.
        /// </summary>
        internal bool IsSetPrimaryEndpoint() => this.PrimaryEndpoint != null;

        /// <summary>
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The endpoint of the replica nodes in this node group (shard). This value is read-only.
        /// </para>
        /// </summary>
        public Endpoint ReaderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReaderEndpoint property is set.
        /// </summary>
        internal bool IsSetReaderEndpoint() => this.ReaderEndpoint != null;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The keyspace for this node group (shard).
        /// </para>
        /// </summary>
        public string Slots { get; set; }

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - <c>creating</c>, <c>available</c>, <c>modifying</c>,
        /// <c>deleting</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
