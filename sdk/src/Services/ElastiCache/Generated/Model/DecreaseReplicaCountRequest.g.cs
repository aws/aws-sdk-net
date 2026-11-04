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
    /// Container for the parameters to the DecreaseReplicaCount operation. Dynamically decreases
    /// the number of replicas in a Valkey or Redis OSS (cluster mode disabled) replication
    /// group or the number of replica nodes in one or more node groups (shards) of a Valkey
    /// or Redis OSS (cluster mode enabled) replication group. This operation is performed
    /// with no cluster down time.
    /// </summary>
    public partial class DecreaseReplicaCountRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <c>True</c>, the number of replica nodes is decreased immediately. <c>ApplyImmediately=False</c>
        /// is not currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property NewReplicaCount. 
        /// <para>
        /// The number of read replica nodes you want at the completion of this operation. For
        /// Valkey or Redis OSS (cluster mode disabled) replication groups, this is the number
        /// of replica nodes in the replication group. For Valkey or Redis OSS (cluster mode enabled)
        /// replication groups, this is the number of replica nodes in each of the replication
        /// group's node groups.
        /// </para>
        ///  
        /// <para>
        /// The minimum number of replicas in a shard or replication group is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode disabled)
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Multi-AZ is enabled: 1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Multi-AZ is not enabled: 0
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode enabled): 0 (though you will not be able to failover
        /// to a replica if your primary node fails)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? NewReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the NewReplicaCount property is set.
        /// </summary>
        internal bool IsSetNewReplicaCount() => this.NewReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaConfiguration. 
        /// <para>
        /// A list of <c>ConfigureShard</c> objects that can be used to configure each shard in
        /// a Valkey or Redis OSS replication group. The <c>ConfigureShard</c> has three members:
        /// <c>NewReplicaCount</c>, <c>NodeGroupId</c>, and <c>PreferredAvailabilityZones</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigureShard> ReplicaConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigureShard>() : null;

        /// <summary>
        /// Checks to see if the ReplicaConfiguration property is set.
        /// </summary>
        internal bool IsSetReplicaConfiguration() => this.ReplicaConfiguration != null && (this.ReplicaConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicasToRemove. 
        /// <para>
        /// A list of the node ids to remove from the replication group or node group (shard).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicasToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicasToRemove property is set.
        /// </summary>
        internal bool IsSetReplicasToRemove() => this.ReplicasToRemove != null && (this.ReplicasToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The id of the replication group from which you want to remove replica nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;
    }
}
