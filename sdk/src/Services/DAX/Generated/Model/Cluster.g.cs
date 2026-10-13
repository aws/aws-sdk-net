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

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Contains all of the attributes of a specific DAX cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property ActiveNodes. 
        /// <para>
        /// The number of nodes in the cluster that are active (i.e., capable of serving requests).
        /// </para>
        /// </summary>
        public int? ActiveNodes { get; set; }

        /// <summary>
        /// Checks to see if the ActiveNodes property is set.
        /// </summary>
        internal bool IsSetActiveNodes() => this.ActiveNodes.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster. 
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterDiscoveryEndpoint. 
        /// <para>
        /// The endpoint for this DAX cluster, consisting of a DNS name, a port number, and a
        /// URL. Applications should use the URL to configure the DAX client to find their cluster.
        /// </para>
        /// </summary>
        public Endpoint ClusterDiscoveryEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ClusterDiscoveryEndpoint property is set.
        /// </summary>
        internal bool IsSetClusterDiscoveryEndpoint() => this.ClusterDiscoveryEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClusterEndpointEncryptionType. 
        /// <para>
        /// The type of encryption supported by the cluster's endpoint. Values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> for no encryption
        /// </para>
        ///  
        /// <para>
        ///  <c>TLS</c> for Transport Layer Security
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClusterEndpointEncryptionType ClusterEndpointEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterEndpointEncryptionType property is set.
        /// </summary>
        internal bool IsSetClusterEndpointEncryptionType() => this.ClusterEndpointEncryptionType != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the DAX cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// A valid Amazon Resource Name (ARN) that identifies an IAM role. At runtime, DAX will
        /// assume this role and use the role's permissions to access DynamoDB on your behalf.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The IP address type of the cluster. Values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipv4</c> - IPv4 addresses only
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6</c> - IPv6 addresses only
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dual_stack</c> - Both IPv4 and IPv6 addresses
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NodeIdsToRemove. 
        /// <para>
        /// A list of nodes to be removed from the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeIdsToRemove property is set.
        /// </summary>
        internal bool IsSetNodeIdsToRemove() => this.NodeIdsToRemove != null && (this.NodeIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster. (All nodes in a DAX cluster are of the
        /// same type.)
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// A list of nodes that are currently in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Node> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<Node>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Describes a notification topic and its status. Notification topics are used for publishing
        /// DAX events to subscribers using Amazon Simple Notification Service (SNS).
        /// </para>
        /// </summary>
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ParameterGroup. 
        /// <para>
        /// The parameter group being used by nodes in the cluster.
        /// </para>
        /// </summary>
        public ParameterGroupStatus ParameterGroup { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroup property is set.
        /// </summary>
        internal bool IsSetParameterGroup() => this.ParameterGroup != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// A range of time when maintenance of DAX cluster software will be performed. For example:
        /// <c>sun:01:00-sun:09:00</c>. Cluster maintenance normally takes less than 30 minutes,
        /// and is performed automatically within the maintenance window.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property SSEDescription. 
        /// <para>
        /// The description of the server-side encryption status on the specified DAX cluster.
        /// </para>
        /// </summary>
        public SSEDescription SSEDescription { get; set; }

        /// <summary>
        /// Checks to see if the SSEDescription property is set.
        /// </summary>
        internal bool IsSetSSEDescription() => this.SSEDescription != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security groups, and the status of each, for the nodes in the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetGroup. 
        /// <para>
        /// The subnet group where the DAX cluster is running.
        /// </para>
        /// </summary>
        public string SubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the SubnetGroup property is set.
        /// </summary>
        internal bool IsSetSubnetGroup() => this.SubnetGroup != null;

        /// <summary>
        /// Gets and sets the property TotalNodes. 
        /// <para>
        /// The total number of nodes in the cluster.
        /// </para>
        /// </summary>
        public int? TotalNodes { get; set; }

        /// <summary>
        /// Checks to see if the TotalNodes property is set.
        /// </summary>
        internal bool IsSetTotalNodes() => this.TotalNodes.HasValue;
    }
}
