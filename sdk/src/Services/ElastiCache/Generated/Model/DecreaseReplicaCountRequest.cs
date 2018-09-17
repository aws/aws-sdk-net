/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DecreaseReplicaCount operation.
    /// Dynamically decreases the number of replics in a Redis (cluster mode disabled) replication
    /// group or the number of replica nodes in one or more node groups (shards) of a Redis
    /// (cluster mode enabled) replication group. This operation is performed with no cluster
    /// down time.
    /// </summary>
    public partial class DecreaseReplicaCountRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private int? _newReplicaCount;
        private List<ConfigureShard> _replicaConfiguration = new List<ConfigureShard>();
        private List<string> _replicasToRemove = new List<string>();
        private string _replicationGroupId;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <code>True</code>, the number of replica nodes is decreased immediately. If <code>False</code>,
        /// the number of replica nodes is decreased during the next maintenance window.
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
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
        /// Redis (cluster mode disabled) replication groups, this is the number of replica nodes
        /// in the replication group. For Redis (cluster mode enabled) replication groups, this
        /// is the number of replica nodes in each of the replication group's node groups.
        /// </para>
        ///  
        /// <para>
        /// The minimum number of replicas in a shard or replication group is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Redis (cluster mode disabled)
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Multi-AZ with Automatic Failover is enabled: 1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Multi-AZ with Automatic Failover is not enabled: 0
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Redis (cluster mode enabled): 0 (though you will not be able to failover to a replica
        /// if your primary node fails)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int NewReplicaCount
        {
            get { return this._newReplicaCount.GetValueOrDefault(); }
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
        /// A list of <code>ConfigureShard</code> objects that can be used to configure each shard
        /// in a Redis (cluster mode enabled) replication group. The <code>ConfigureShard</code>
        /// has three members: <code>NewReplicaCount</code>, <code>NodeGroupId</code>, and <code>PreferredAvailabilityZones</code>.
        /// </para>
        /// </summary>
        public List<ConfigureShard> ReplicaConfiguration
        {
            get { return this._replicaConfiguration; }
            set { this._replicaConfiguration = value; }
        }

        // Check to see if ReplicaConfiguration property is set
        internal bool IsSetReplicaConfiguration()
        {
            return this._replicaConfiguration != null && this._replicaConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicasToRemove. 
        /// <para>
        /// A list of the node ids to remove from the replication group or node group (shard).
        /// </para>
        /// </summary>
        public List<string> ReplicasToRemove
        {
            get { return this._replicasToRemove; }
            set { this._replicasToRemove = value; }
        }

        // Check to see if ReplicasToRemove property is set
        internal bool IsSetReplicasToRemove()
        {
            return this._replicasToRemove != null && this._replicasToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The id of the replication group from which you want to remove replica nodes.
        /// </para>
        /// </summary>
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