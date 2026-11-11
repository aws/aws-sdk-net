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
    /// Node group (shard) configuration options. Each node group (shard) configuration has
    /// the following: <c>Slots</c>, <c>PrimaryAvailabilityZone</c>, <c>ReplicaAvailabilityZones</c>,
    /// <c>ReplicaCount</c>.
    /// </summary>
    public partial class NodeGroupConfiguration
    {
        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// Either the ElastiCache supplied 4-digit id or a user supplied id for the node group
        /// these configuration values apply to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupId property is set.
        /// </summary>
        internal bool IsSetNodeGroupId() => this.NodeGroupId != null;

        /// <summary>
        /// Gets and sets the property PrimaryAvailabilityZone. 
        /// <para>
        /// The Availability Zone where the primary node of this node group (shard) is launched.
        /// </para>
        /// </summary>
        public string PrimaryAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetPrimaryAvailabilityZone() => this.PrimaryAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property PrimaryOutpostArn. 
        /// <para>
        /// The outpost ARN of the primary node.
        /// </para>
        /// </summary>
        public string PrimaryOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryOutpostArn property is set.
        /// </summary>
        internal bool IsSetPrimaryOutpostArn() => this.PrimaryOutpostArn != null;

        /// <summary>
        /// Gets and sets the property ReplicaAvailabilityZones. 
        /// <para>
        /// A list of Availability Zones to be used for the read replicas. The number of Availability
        /// Zones in this list must match the value of <c>ReplicaCount</c> or <c>ReplicasPerNodeGroup</c>
        /// if not specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicaAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicaAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetReplicaAvailabilityZones() => this.ReplicaAvailabilityZones != null && (this.ReplicaAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of read replica nodes in this node group (shard).
        /// </para>
        /// </summary>
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaCount property is set.
        /// </summary>
        internal bool IsSetReplicaCount() => this.ReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaOutpostArns. 
        /// <para>
        /// The outpost ARN of the node replicas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicaOutpostArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicaOutpostArns property is set.
        /// </summary>
        internal bool IsSetReplicaOutpostArns() => this.ReplicaOutpostArns != null && (this.ReplicaOutpostArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// A string that specifies the keyspace for a particular node group. Keyspaces range
        /// from 0 to 16,383. The string is in the format <c>startkey-endkey</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"0-3999"</c> 
        /// </para>
        /// </summary>
        public string Slots { get; set; }

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null;
    }
}
