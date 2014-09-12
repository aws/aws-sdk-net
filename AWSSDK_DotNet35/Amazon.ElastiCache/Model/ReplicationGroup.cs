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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
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
    /// Contains all of the attributes of a specific replication group.
    /// </summary>
    public partial class ReplicationGroup
    {
        private string _description;
        private List<string> _memberClusters = new List<string>();
        private List<NodeGroup> _nodeGroups = new List<NodeGroup>();
        private ReplicationGroupPendingModifiedValues _pendingModifiedValues;
        private string _replicationGroupId;
        private string _snapshottingClusterId;
        private string _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replication group.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MemberClusters. 
        /// <para>
        /// The names of all the cache clusters that are part of this replication group.
        /// </para>
        /// </summary>
        public List<string> MemberClusters
        {
            get { return this._memberClusters; }
            set { this._memberClusters = value; }
        }

        // Check to see if MemberClusters property is set
        internal bool IsSetMemberClusters()
        {
            return this._memberClusters != null && this._memberClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NodeGroups. 
        /// <para>
        /// A single element list with information about the nodes in the replication group.
        /// </para>
        /// </summary>
        public List<NodeGroup> NodeGroups
        {
            get { return this._nodeGroups; }
            set { this._nodeGroups = value; }
        }

        // Check to see if NodeGroups property is set
        internal bool IsSetNodeGroups()
        {
            return this._nodeGroups != null && this._nodeGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A group of settings to be applied to the replication group, either immediately or
        /// during the next maintenance window.
        /// </para>
        /// </summary>
        public ReplicationGroupPendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier for the replication group.
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

        /// <summary>
        /// Gets and sets the property SnapshottingClusterId. 
        /// <para>
        /// The cache cluster ID that is used as the daily snapshot source for the replication
        /// group.
        /// </para>
        /// </summary>
        public string SnapshottingClusterId
        {
            get { return this._snapshottingClusterId; }
            set { this._snapshottingClusterId = value; }
        }

        // Check to see if SnapshottingClusterId property is set
        internal bool IsSetSnapshottingClusterId()
        {
            return this._snapshottingClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - <i>creating</i>, <i>available</i>, etc.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}