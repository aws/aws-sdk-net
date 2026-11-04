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
    /// Container for the parameters to the DecreaseNodeGroupsInGlobalReplicationGroup operation.
    /// Decreases the number of node groups in a Global datastore
    /// </summary>
    public partial class DecreaseNodeGroupsInGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates that the shard reconfiguration process begins immediately. At present, the
        /// only permitted value for this parameter is true. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalNodeGroupsToRemove. 
        /// <para>
        /// If the value of NodeGroupCount is less than the current number of node groups (shards),
        /// then either NodeGroupsToRemove or NodeGroupsToRetain is required. GlobalNodeGroupsToRemove
        /// is a list of NodeGroupIds to remove from the cluster. ElastiCache will attempt to
        /// remove all node groups listed by GlobalNodeGroupsToRemove from the cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GlobalNodeGroupsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlobalNodeGroupsToRemove property is set.
        /// </summary>
        internal bool IsSetGlobalNodeGroupsToRemove() => this.GlobalNodeGroupsToRemove != null && (this.GlobalNodeGroupsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalNodeGroupsToRetain. 
        /// <para>
        /// If the value of NodeGroupCount is less than the current number of node groups (shards),
        /// then either NodeGroupsToRemove or NodeGroupsToRetain is required. GlobalNodeGroupsToRetain
        /// is a list of NodeGroupIds to retain from the cluster. ElastiCache will attempt to
        /// retain all node groups listed by GlobalNodeGroupsToRetain from the cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GlobalNodeGroupsToRetain { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlobalNodeGroupsToRetain property is set.
        /// </summary>
        internal bool IsSetGlobalNodeGroupsToRetain() => this.GlobalNodeGroupsToRetain != null && (this.GlobalNodeGroupsToRetain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GlobalReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupId() => this.GlobalReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property NodeGroupCount. 
        /// <para>
        /// The number of node groups (shards) that results from the modification of the shard
        /// configuration
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? NodeGroupCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupCount property is set.
        /// </summary>
        internal bool IsSetNodeGroupCount() => this.NodeGroupCount.HasValue;
    }
}
