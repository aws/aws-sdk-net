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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Contains all of the attributes of a specific DAX cluster.
    /// </summary>
    public partial class Cluster
    {
        private int? _activeNodes;
        private string _clusterArn;
        private Endpoint _clusterDiscoveryEndpoint;
        private string _clusterName;
        private string _description;
        private string _iamRoleArn;
        private List<string> _nodeIdsToRemove = new List<string>();
        private List<Node> _nodes = new List<Node>();
        private string _nodeType;
        private NotificationConfiguration _notificationConfiguration;
        private ParameterGroupStatus _parameterGroup;
        private string _preferredMaintenanceWindow;
        private List<SecurityGroupMembership> _securityGroups = new List<SecurityGroupMembership>();
        private SSEDescription _sseDescription;
        private string _status;
        private string _subnetGroup;
        private int? _totalNodes;

        /// <summary>
        /// Gets and sets the property ActiveNodes. 
        /// <para>
        /// The number of nodes in the cluster that are active (i.e., capable of serving requests).
        /// </para>
        /// </summary>
        public int ActiveNodes
        {
            get { return this._activeNodes.GetValueOrDefault(); }
            set { this._activeNodes = value; }
        }

        // Check to see if ActiveNodes property is set
        internal bool IsSetActiveNodes()
        {
            return this._activeNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster. 
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterDiscoveryEndpoint. 
        /// <para>
        /// The configuration endpoint for this DAX cluster, consisting of a DNS name and a port
        /// number. Client applications can specify this endpoint, rather than an individual node
        /// endpoint, and allow the DAX client software to intelligently route requests and responses
        /// to nodes in the DAX cluster.
        /// </para>
        /// </summary>
        public Endpoint ClusterDiscoveryEndpoint
        {
            get { return this._clusterDiscoveryEndpoint; }
            set { this._clusterDiscoveryEndpoint = value; }
        }

        // Check to see if ClusterDiscoveryEndpoint property is set
        internal bool IsSetClusterDiscoveryEndpoint()
        {
            return this._clusterDiscoveryEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster.
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// A valid Amazon Resource Name (ARN) that identifies an IAM role. At runtime, DAX will
        /// assume this role and use the role's permissions to access DynamoDB on your behalf.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property NodeIdsToRemove. 
        /// <para>
        /// A list of nodes to be removed from the cluster.
        /// </para>
        /// </summary>
        public List<string> NodeIdsToRemove
        {
            get { return this._nodeIdsToRemove; }
            set { this._nodeIdsToRemove = value; }
        }

        // Check to see if NodeIdsToRemove property is set
        internal bool IsSetNodeIdsToRemove()
        {
            return this._nodeIdsToRemove != null && this._nodeIdsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// A list of nodes that are currently in the cluster.
        /// </para>
        /// </summary>
        public List<Node> Nodes
        {
            get { return this._nodes; }
            set { this._nodes = value; }
        }

        // Check to see if Nodes property is set
        internal bool IsSetNodes()
        {
            return this._nodes != null && this._nodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster. (All nodes in a DAX cluster are of the
        /// same type.)
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Describes a notification topic and its status. Notification topics are used for publishing
        /// DAX events to subscribers using Amazon Simple Notification Service (SNS).
        /// </para>
        /// </summary>
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroup. 
        /// <para>
        /// The parameter group being used by nodes in the cluster.
        /// </para>
        /// </summary>
        public ParameterGroupStatus ParameterGroup
        {
            get { return this._parameterGroup; }
            set { this._parameterGroup = value; }
        }

        // Check to see if ParameterGroup property is set
        internal bool IsSetParameterGroup()
        {
            return this._parameterGroup != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// A range of time when maintenance of DAX cluster software will be performed. For example:
        /// <code>sun:01:00-sun:09:00</code>. Cluster maintenance normally takes less than 30
        /// minutes, and is performed automatically within the maintenance window.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security groups, and the status of each, for the nodes in the cluster.
        /// </para>
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SSEDescription. 
        /// <para>
        /// The description of the server-side encryption status on the specified DAX cluster.
        /// </para>
        /// </summary>
        public SSEDescription SSEDescription
        {
            get { return this._sseDescription; }
            set { this._sseDescription = value; }
        }

        // Check to see if SSEDescription property is set
        internal bool IsSetSSEDescription()
        {
            return this._sseDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster.
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

        /// <summary>
        /// Gets and sets the property SubnetGroup. 
        /// <para>
        /// The subnet group where the DAX cluster is running.
        /// </para>
        /// </summary>
        public string SubnetGroup
        {
            get { return this._subnetGroup; }
            set { this._subnetGroup = value; }
        }

        // Check to see if SubnetGroup property is set
        internal bool IsSetSubnetGroup()
        {
            return this._subnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property TotalNodes. 
        /// <para>
        /// The total number of nodes in the cluster.
        /// </para>
        /// </summary>
        public int TotalNodes
        {
            get { return this._totalNodes.GetValueOrDefault(); }
            set { this._totalNodes = value; }
        }

        // Check to see if TotalNodes property is set
        internal bool IsSetTotalNodes()
        {
            return this._totalNodes.HasValue; 
        }

    }
}