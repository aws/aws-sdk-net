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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a DAX cluster. All nodes in the cluster run the same DAX caching software.
    /// </summary>
    public partial class CreateClusterRequest : AmazonDAXRequest
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ClusterEndpointEncryptionType _clusterEndpointEncryptionType;
        private string _clusterName;
        private string _description;
        private string _iamRoleArn;
        private NetworkType _networkType;
        private string _nodeType;
        private string _notificationTopicArn;
        private string _parameterGroupName;
        private string _preferredMaintenanceWindow;
        private int? _replicationFactor;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SSESpecification _sseSpecification;
        private string _subnetGroupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones (AZs) in which the cluster nodes will reside after the cluster
        /// has been created or updated. If provided, the length of this list must equal the <c>ReplicationFactor</c>
        /// parameter. If you omit this parameter, DAX will spread the nodes across Availability
        /// Zones for the highest availability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterEndpointEncryptionType. 
        /// <para>
        /// The type of encryption the cluster's endpoint should support. Values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> for no encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS</c> for Transport Layer Security
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClusterEndpointEncryptionType ClusterEndpointEncryptionType
        {
            get { return this._clusterEndpointEncryptionType; }
            set { this._clusterEndpointEncryptionType = value; }
        }

        // Check to see if ClusterEndpointEncryptionType property is set
        internal bool IsSetClusterEndpointEncryptionType()
        {
            return this._clusterEndpointEncryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The cluster identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        ///  <b>Constraints:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name must contain from 1 to 20 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A name cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A description of the cluster.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Specifies the IP protocol(s) the cluster uses for network communications. Values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipv4</c> - The cluster is accessible only through IPv4 addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6</c> - The cluster is accessible only through IPv6 addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dual_stack</c> - The cluster is accessible through both IPv4 and IPv6 addresses.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If no explicit <c>NetworkType</c> is provided, the network type is derived based on
        /// the subnet group's configuration.
        /// </para>
        ///  </note>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The compute and memory capacity of the nodes in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which notifications will
        /// be sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon SNS topic owner must be same as the DAX cluster owner.
        /// </para>
        ///  </note>
        /// </summary>
        public string NotificationTopicArn
        {
            get { return this._notificationTopicArn; }
            set { this._notificationTopicArn = value; }
        }

        // Check to see if NotificationTopicArn property is set
        internal bool IsSetNotificationTopicArn()
        {
            return this._notificationTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The parameter group to be associated with the DAX cluster.
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the DAX cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period. Valid values for <c>ddd</c>
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sun</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>thu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fri</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sat</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>sun:05:00-sun:09:00</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a preferred maintenance window when you create or modify a cache
        /// cluster, DAX assigns a 60-minute maintenance window on a randomly selected day of
        /// the week.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// The number of nodes in the DAX cluster. A replication factor of 1 will create a single-node
        /// cluster, without any read replicas. For additional fault tolerance, you can create
        /// a multiple node cluster with one or more read replicas. To do this, set <c>ReplicationFactor</c>
        /// to a number between 3 (one primary and two read replicas) and 10 (one primary and
        /// nine read replicas). <c>If the AvailabilityZones</c> parameter is provided, its length
        /// must equal the <c>ReplicationFactor</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services recommends that you have at least two read replicas per cluster.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReplicationFactor
        {
            get { return this._replicationFactor; }
            set { this._replicationFactor = value; }
        }

        // Check to see if ReplicationFactor property is set
        internal bool IsSetReplicationFactor()
        {
            return this._replicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group IDs to be assigned to each node in the DAX cluster. (Each
        /// of the security group ID is system-generated.)
        /// </para>
        ///  
        /// <para>
        /// If this parameter is not specified, DAX assigns the default VPC security group to
        /// each node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SSESpecification. 
        /// <para>
        /// Represents the settings used to enable server-side encryption on the cluster.
        /// </para>
        /// </summary>
        public SSESpecification SSESpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SSESpecification property is set
        internal bool IsSetSSESpecification()
        {
            return this._sseSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group to be used for the replication group.
        /// </para>
        ///  <important> 
        /// <para>
        /// DAX clusters can only run in an Amazon VPC environment. All of the subnets that you
        /// specify in a subnet group must exist in the same VPC.
        /// </para>
        ///  </important>
        /// </summary>
        public string SubnetGroupName
        {
            get { return this._subnetGroupName; }
            set { this._subnetGroupName = value; }
        }

        // Check to see if SubnetGroupName property is set
        internal bool IsSetSubnetGroupName()
        {
            return this._subnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to associate with the DAX cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}