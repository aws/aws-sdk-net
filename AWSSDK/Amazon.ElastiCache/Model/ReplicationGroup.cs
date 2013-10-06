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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Contains all of the attributes of a specific replication group.</para>
    /// </summary>
    public class ReplicationGroup
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

        /// <summary>
        /// Sets the ReplicationGroupId property
        /// </summary>
        /// <param name="replicationGroupId">The value to set for the ReplicationGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithReplicationGroupId(string replicationGroupId)
        {
            this.replicationGroupId = replicationGroupId;
            return this;
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

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithDescription(string description)
        {
            this.description = description;
            return this;
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithStatus(string status)
        {
            this.status = status;
            return this;
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

        /// <summary>
        /// Sets the PendingModifiedValues property
        /// </summary>
        /// <param name="pendingModifiedValues">The value to set for the PendingModifiedValues property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithPendingModifiedValues(ReplicationGroupPendingModifiedValues pendingModifiedValues)
        {
            this.pendingModifiedValues = pendingModifiedValues;
            return this;
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
        /// <summary>
        /// Adds elements to the MemberClusters collection
        /// </summary>
        /// <param name="memberClusters">The values to add to the MemberClusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithMemberClusters(params string[] memberClusters)
        {
            foreach (string element in memberClusters)
            {
                this.memberClusters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the MemberClusters collection
        /// </summary>
        /// <param name="memberClusters">The values to add to the MemberClusters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithMemberClusters(IEnumerable<string> memberClusters)
        {
            foreach (string element in memberClusters)
            {
                this.memberClusters.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the NodeGroups collection
        /// </summary>
        /// <param name="nodeGroups">The values to add to the NodeGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithNodeGroups(params NodeGroup[] nodeGroups)
        {
            foreach (NodeGroup element in nodeGroups)
            {
                this.nodeGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the NodeGroups collection
        /// </summary>
        /// <param name="nodeGroups">The values to add to the NodeGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReplicationGroup WithNodeGroups(IEnumerable<NodeGroup> nodeGroups)
        {
            foreach (NodeGroup element in nodeGroups)
            {
                this.nodeGroups.Add(element);
            }

            return this;
        }

        // Check to see if NodeGroups property is set
        internal bool IsSetNodeGroups()
        {
            return this.nodeGroups.Count > 0;
        }
    }
}
