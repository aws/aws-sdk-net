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
    /// Container for the parameters to the ModifyReplicationGroupShardConfiguration operation.
    /// Modifies a replication group's shards (node groups) by allowing you to add shards,
    /// remove shards, or rebalance the keyspaces among existing shards.
    /// </summary>
    public partial class ModifyReplicationGroupShardConfigurationRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates that the shard reconfiguration process begins immediately. At present, the
        /// only permitted value for this parameter is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Value: true
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property NodeGroupCount. 
        /// <para>
        /// The number of node groups (shards) that results from the modification of the shard
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? NodeGroupCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupCount property is set.
        /// </summary>
        internal bool IsSetNodeGroupCount() => this.NodeGroupCount.HasValue;

        /// <summary>
        /// Gets and sets the property NodeGroupsToRemove. 
        /// <para>
        /// If the value of <c>NodeGroupCount</c> is less than the current number of node groups
        /// (shards), then either <c>NodeGroupsToRemove</c> or <c>NodeGroupsToRetain</c> is required.
        /// <c>NodeGroupsToRemove</c> is a list of <c>NodeGroupId</c>s to remove from the cluster.
        /// </para>
        ///  
        /// <para>
        /// ElastiCache will attempt to remove all node groups listed by <c>NodeGroupsToRemove</c>
        /// from the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeGroupsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeGroupsToRemove property is set.
        /// </summary>
        internal bool IsSetNodeGroupsToRemove() => this.NodeGroupsToRemove != null && (this.NodeGroupsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeGroupsToRetain. 
        /// <para>
        /// If the value of <c>NodeGroupCount</c> is less than the current number of node groups
        /// (shards), then either <c>NodeGroupsToRemove</c> or <c>NodeGroupsToRetain</c> is required.
        /// <c>NodeGroupsToRetain</c> is a list of <c>NodeGroupId</c>s to retain in the cluster.
        /// </para>
        ///  
        /// <para>
        /// ElastiCache will attempt to remove all node groups except those listed by <c>NodeGroupsToRetain</c>
        /// from the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeGroupsToRetain { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeGroupsToRetain property is set.
        /// </summary>
        internal bool IsSetNodeGroupsToRetain() => this.NodeGroupsToRetain != null && (this.NodeGroupsToRetain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the Valkey or Redis OSS (cluster mode enabled) cluster (replication group)
        /// on which the shards are to be configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ReshardingConfiguration. 
        /// <para>
        /// Specifies the preferred availability zones for each node group in the cluster. If
        /// the value of <c>NodeGroupCount</c> is greater than the current number of node groups
        /// (shards), you can use this parameter to specify the preferred availability zones of
        /// the cluster's shards. If you omit this parameter ElastiCache selects availability
        /// zones for you.
        /// </para>
        ///  
        /// <para>
        /// You can specify this parameter only if the value of <c>NodeGroupCount</c> is greater
        /// than the current number of node groups (shards).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReshardingConfiguration> ReshardingConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<ReshardingConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ReshardingConfiguration property is set.
        /// </summary>
        internal bool IsSetReshardingConfiguration() => this.ReshardingConfiguration != null && (this.ReshardingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
