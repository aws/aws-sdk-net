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
    /// Container for the parameters to the IncreaseReplicaCount operation.
    /// Dynamically increases the number of replicas in a Valkey or Redis OSS (cluster mode
    /// disabled) replication group or the number of replica nodes in one or more node groups
    /// (shards) of a Valkey or Redis OSS (cluster mode enabled) replication group. This operation
    /// is performed with no cluster down time.
    /// </summary>
    public partial class IncreaseReplicaCountRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private int? _newReplicaCount;
        private List<ConfigureShard> _replicaConfiguration = AWSConfigs.InitializeCollections ? new List<ConfigureShard>() : null;
        private string _replicationGroupId;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <c>True</c>, the number of replica nodes is increased immediately. <c>ApplyImmediately=False</c>
        /// is not currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ApplyImmediately
        {
            get { return this._applyImmediately; }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NewReplicaCount. 
        /// <para>
        /// The number of read replica nodes you want at the completion of this operation. For
        /// Valkey or Redis OSS (cluster mode disabled) replication groups, this is the number
        /// of replica nodes in the replication group. For Valkey or Redis OSS (cluster mode enabled)
        /// replication groups, this is the number of replica nodes in each of the replication
        /// group's node groups.
        /// </para>
        /// </summary>
        public int? NewReplicaCount
        {
            get { return this._newReplicaCount; }
            set { this._newReplicaCount = value; }
        }

        // Check to see if NewReplicaCount property is set
        internal bool IsSetNewReplicaCount()
        {
            return this._newReplicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaConfiguration. 
        /// <para>
        /// A list of <c>ConfigureShard</c> objects that can be used to configure each shard in
        /// a Valkey or Redis OSS (cluster mode enabled) replication group. The <c>ConfigureShard</c>
        /// has three members: <c>NewReplicaCount</c>, <c>NodeGroupId</c>, and <c>PreferredAvailabilityZones</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigureShard> ReplicaConfiguration
        {
            get { return this._replicaConfiguration; }
            set { this._replicaConfiguration = value; }
        }

        // Check to see if ReplicaConfiguration property is set
        internal bool IsSetReplicaConfiguration()
        {
            return this._replicaConfiguration != null && (this._replicaConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The id of the replication group to which you want to add replica nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
        }

    }
}