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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DecreaseNodeGroupsInGlobalReplicationGroup operation.
    /// Decreases the number of node groups in a Global Datastore
    /// </summary>
    public partial class DecreaseNodeGroupsInGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private List<string> _globalNodeGroupsToRemove = new List<string>();
        private List<string> _globalNodeGroupsToRetain = new List<string>();
        private string _globalReplicationGroupId;
        private int? _nodeGroupCount;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates that the shard reconfiguration process begins immediately. At present, the
        /// only permitted value for this parameter is true. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GlobalNodeGroupsToRemove. 
        /// <para>
        /// If the value of NodeGroupCount is less than the current number of node groups (shards),
        /// then either NodeGroupsToRemove or NodeGroupsToRetain is required. NodeGroupsToRemove
        /// is a list of NodeGroupIds to remove from the cluster. ElastiCache for Redis will attempt
        /// to remove all node groups listed by NodeGroupsToRemove from the cluster. 
        /// </para>
        /// </summary>
        public List<string> GlobalNodeGroupsToRemove
        {
            get { return this._globalNodeGroupsToRemove; }
            set { this._globalNodeGroupsToRemove = value; }
        }

        // Check to see if GlobalNodeGroupsToRemove property is set
        internal bool IsSetGlobalNodeGroupsToRemove()
        {
            return this._globalNodeGroupsToRemove != null && this._globalNodeGroupsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GlobalNodeGroupsToRetain. 
        /// <para>
        /// If the value of NodeGroupCount is less than the current number of node groups (shards),
        /// then either NodeGroupsToRemove or NodeGroupsToRetain is required. NodeGroupsToRemove
        /// is a list of NodeGroupIds to remove from the cluster. ElastiCache for Redis will attempt
        /// to remove all node groups listed by NodeGroupsToRemove from the cluster. 
        /// </para>
        /// </summary>
        public List<string> GlobalNodeGroupsToRetain
        {
            get { return this._globalNodeGroupsToRetain; }
            set { this._globalNodeGroupsToRetain = value; }
        }

        // Check to see if GlobalNodeGroupsToRetain property is set
        internal bool IsSetGlobalNodeGroupsToRetain()
        {
            return this._globalNodeGroupsToRetain != null && this._globalNodeGroupsToRetain.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global Datastore
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlobalReplicationGroupId
        {
            get { return this._globalReplicationGroupId; }
            set { this._globalReplicationGroupId = value; }
        }

        // Check to see if GlobalReplicationGroupId property is set
        internal bool IsSetGlobalReplicationGroupId()
        {
            return this._globalReplicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupCount. 
        /// <para>
        /// The number of node groups (shards) that results from the modification of the shard
        /// configuration
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NodeGroupCount
        {
            get { return this._nodeGroupCount.GetValueOrDefault(); }
            set { this._nodeGroupCount = value; }
        }

        // Check to see if NodeGroupCount property is set
        internal bool IsSetNodeGroupCount()
        {
            return this._nodeGroupCount.HasValue; 
        }

    }
}