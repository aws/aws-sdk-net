/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Contains all of the attributes of a specific replication group.</para>
    /// </summary>
    public partial class ReplicationGroup : AmazonWebServiceResponse
    {
        
        private string replicationGroupId;
        private string description;
        private string status;
        private ReplicationGroupPendingModifiedValues pendingModifiedValues;
        private List<string> memberClusters = new List<string>();
        private List<NodeGroup> nodeGroups = new List<NodeGroup>();


        /// <summary>
        /// The identifier for the replication group.
        ///  
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this.replicationGroupId; }
            set { this.replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }

        /// <summary>
        /// The description of the replication group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The current state of this replication group - <i>creating</i>, <i>available</i>, etc.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// A group of settings to be applied to the replication group, either immediately or during the next maintenance window.
        ///  
        /// </summary>
        public ReplicationGroupPendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValues; }
            set { this.pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this.pendingModifiedValues != null;
        }

        /// <summary>
        /// The names of all the cache clusters that are part of this replication group.
        ///  
        /// </summary>
        public List<string> MemberClusters
        {
            get { return this.memberClusters; }
            set { this.memberClusters = value; }
        }

        // Check to see if MemberClusters property is set
        internal bool IsSetMemberClusters()
        {
            return this.memberClusters.Count > 0;
        }

        /// <summary>
        /// A single element list with information about the nodes in the replication group.
        ///  
        /// </summary>
        public List<NodeGroup> NodeGroups
        {
            get { return this.nodeGroups; }
            set { this.nodeGroups = value; }
        }

        // Check to see if NodeGroups property is set
        internal bool IsSetNodeGroups()
        {
            return this.nodeGroups.Count > 0;
        }
    }
}
