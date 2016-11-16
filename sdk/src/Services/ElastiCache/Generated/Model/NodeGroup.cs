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
    /// Represents a collection of cache nodes in a replication group. One node in the node
    /// group is the read/write primary node. All the other nodes are read-only Replica nodes.
    /// </summary>
    public partial class NodeGroup
    {
        private string _nodeGroupId;
        private List<NodeGroupMember> _nodeGroupMembers = new List<NodeGroupMember>();
        private Endpoint _primaryEndpoint;
        private string _slots;
        private string _status;

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// The identifier for the node group (shard). A Redis (cluster mode disabled) replication
        /// group contains only 1 node group; therefore, the node group ID is 0001. A Redis (cluster
        /// mode enabled) replication group contains 1 to 15 node groups numbered 0001 to 0015.
        /// 
        /// </para>
        /// </summary>
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupMembers. 
        /// <para>
        /// A list containing information about individual nodes within the node group (shard).
        /// </para>
        /// </summary>
        public List<NodeGroupMember> NodeGroupMembers
        {
            get { return this._nodeGroupMembers; }
            set { this._nodeGroupMembers = value; }
        }

        // Check to see if NodeGroupMembers property is set
        internal bool IsSetNodeGroupMembers()
        {
            return this._nodeGroupMembers != null && this._nodeGroupMembers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryEndpoint. 
        /// <para>
        /// The endpoint of the primary node in this node group (shard).
        /// </para>
        /// </summary>
        public Endpoint PrimaryEndpoint
        {
            get { return this._primaryEndpoint; }
            set { this._primaryEndpoint = value; }
        }

        // Check to see if PrimaryEndpoint property is set
        internal bool IsSetPrimaryEndpoint()
        {
            return this._primaryEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The keyspace for this node group (shard).
        /// </para>
        /// </summary>
        public string Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - <code>creating</code>, <code>available</code>,
        /// etc.
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