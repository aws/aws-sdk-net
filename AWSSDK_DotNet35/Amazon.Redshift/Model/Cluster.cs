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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a cluster.</para>
    /// </summary>
    public partial class Cluster : AmazonWebServiceResponse
    {
        
        private string clusterIdentifier;
        private string nodeType;
        private string clusterStatus;
        private string modifyStatus;
        private string masterUsername;
        private string dBName;
        private Endpoint endpoint;
        private DateTime? clusterCreateTime;
        private int? automatedSnapshotRetentionPeriod;
        private List<ClusterSecurityGroupMembership> clusterSecurityGroups = new List<ClusterSecurityGroupMembership>();
        private List<VpcSecurityGroupMembership> vpcSecurityGroups = new List<VpcSecurityGroupMembership>();
        private List<ClusterParameterGroupStatus> clusterParameterGroups = new List<ClusterParameterGroupStatus>();
        private string clusterSubnetGroupName;
        private string vpcId;
        private string availabilityZone;
        private string preferredMaintenanceWindow;
        private PendingModifiedValues pendingModifiedValues;
        private string clusterVersion;
        private bool? allowVersionUpgrade;
        private int? numberOfNodes;
        private bool? publiclyAccessible;
        private bool? encrypted;
        private RestoreStatus restoreStatus;
        private HsmStatus hsmStatus;
        private ClusterSnapshotCopyStatus clusterSnapshotCopyStatus;
        private string clusterPublicKey;
        private List<ClusterNode> clusterNodes = new List<ClusterNode>();
        private ElasticIpStatus elasticIpStatus;


        /// <summary>
        /// The unique identifier of the cluster.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The node type for the nodes in the cluster.
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The current state of this cluster. Possible values include <c>available</c>, <c>creating</c>, <c>deleting</c>, <c>rebooting</c>, and
        /// <c>resizing</c>.
        ///  
        /// </summary>
        public string ClusterStatus
        {
            get { return this.clusterStatus; }
            set { this.clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this.clusterStatus != null;
        }

        /// <summary>
        /// The status of a modify operation, if any, initiated for the cluster.
        ///  
        /// </summary>
        public string ModifyStatus
        {
            get { return this.modifyStatus; }
            set { this.modifyStatus = value; }
        }

        // Check to see if ModifyStatus property is set
        internal bool IsSetModifyStatus()
        {
            return this.modifyStatus != null;
        }

        /// <summary>
        /// The master user name for the cluster. This name is used to connect to the database that is specified in <b>DBName</b>.
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;
        }

        /// <summary>
        /// The name of the initial database that was created when the cluster was created. This same name is returned for the life of the cluster. If
        /// an initial database was not specified, a database named "dev" was created by default.
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The connection endpoint.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// The date and time that the cluster was created.
        ///  
        /// </summary>
        public DateTime ClusterCreateTime
        {
            get { return this.clusterCreateTime ?? default(DateTime); }
            set { this.clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this.clusterCreateTime.HasValue;
        }

        /// <summary>
        /// The number of days that automatic cluster snapshots are retained.
        ///  
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this.automatedSnapshotRetentionPeriod ?? default(int); }
            set { this.automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this.automatedSnapshotRetentionPeriod.HasValue;
        }

        /// <summary>
        /// A list of cluster security group that are associated with the cluster. Each security group is represented by an element that contains
        /// <c>ClusterSecurityGroup.Name</c> and <c>ClusterSecurityGroup.Status</c> subelements. Cluster security groups are used when the cluster is
        /// not created in a VPC. Clusters that are created in a VPC use VPC security groups, which are listed by the <b>VpcSecurityGroups</b>
        /// parameter.
        ///  
        /// </summary>
        public List<ClusterSecurityGroupMembership> ClusterSecurityGroups
        {
            get { return this.clusterSecurityGroups; }
            set { this.clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this.clusterSecurityGroups.Count > 0;
        }

        /// <summary>
        /// A list of Virtual Private Cloud (VPC) security groups that are associated with the cluster. This parameter is returned only if the cluster
        /// is in a VPC.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this.vpcSecurityGroups; }
            set { this.vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this.vpcSecurityGroups.Count > 0;
        }

        /// <summary>
        /// The list of cluster parameter groups that are associated with this cluster.
        ///  
        /// </summary>
        public List<ClusterParameterGroupStatus> ClusterParameterGroups
        {
            get { return this.clusterParameterGroups; }
            set { this.clusterParameterGroups = value; }
        }

        // Check to see if ClusterParameterGroups property is set
        internal bool IsSetClusterParameterGroups()
        {
            return this.clusterParameterGroups.Count > 0;
        }

        /// <summary>
        /// The name of the subnet group that is associated with the cluster. This parameter is valid only when the cluster is in a VPC.
        ///  
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this.clusterSubnetGroupName; }
            set { this.clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this.clusterSubnetGroupName != null;
        }

        /// <summary>
        /// The identifier of the VPC the cluster is in, if the cluster is in a VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The name of the Availability Zone in which the cluster is located.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The weekly time range (in UTC) during which system maintenance can occur.
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// If present, changes to the cluster are pending. Specific pending changes are identified by subelements.
        ///  
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
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
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// If <c>true</c>, version upgrades will be applied automatically to the cluster during the maintenance window.
        ///  
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this.allowVersionUpgrade ?? default(bool); }
            set { this.allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this.allowVersionUpgrade.HasValue;
        }

        /// <summary>
        /// The number of compute nodes in the cluster.
        ///  
        /// </summary>
        public int NumberOfNodes
        {
            get { return this.numberOfNodes ?? default(int); }
            set { this.numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this.numberOfNodes.HasValue;
        }

        /// <summary>
        /// If <c>true</c>, the cluster can be accessed from a public network.
        ///  
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }

        /// <summary>
        /// If <c>true</c>, data in cluster is encrypted at rest.
        ///  
        /// </summary>
        public bool Encrypted
        {
            get { return this.encrypted ?? default(bool); }
            set { this.encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this.encrypted.HasValue;
        }

        /// <summary>
        /// Describes the status of a cluster restore action. Returns null if the cluster was not created by restoring a snapshot.
        ///  
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get { return this.restoreStatus; }
            set { this.restoreStatus = value; }
        }

        // Check to see if RestoreStatus property is set
        internal bool IsSetRestoreStatus()
        {
            return this.restoreStatus != null;
        }

        /// <summary>
        /// Reports whether the Amazon Redshift cluster has finished applying any HSM settings changes specified in a modify cluster command. Values:
        /// active, applying
        ///  
        /// </summary>
        public HsmStatus HsmStatus
        {
            get { return this.hsmStatus; }
            set { this.hsmStatus = value; }
        }

        // Check to see if HsmStatus property is set
        internal bool IsSetHsmStatus()
        {
            return this.hsmStatus != null;
        }

        /// <summary>
        /// Returns the destination region and retention period that are configured for cross-region snapshot copy.
        ///  
        /// </summary>
        public ClusterSnapshotCopyStatus ClusterSnapshotCopyStatus
        {
            get { return this.clusterSnapshotCopyStatus; }
            set { this.clusterSnapshotCopyStatus = value; }
        }

        // Check to see if ClusterSnapshotCopyStatus property is set
        internal bool IsSetClusterSnapshotCopyStatus()
        {
            return this.clusterSnapshotCopyStatus != null;
        }

        /// <summary>
        /// The public key for the cluster.
        ///  
        /// </summary>
        public string ClusterPublicKey
        {
            get { return this.clusterPublicKey; }
            set { this.clusterPublicKey = value; }
        }

        // Check to see if ClusterPublicKey property is set
        internal bool IsSetClusterPublicKey()
        {
            return this.clusterPublicKey != null;
        }

        /// <summary>
        /// The nodes in a cluster.
        ///  
        /// </summary>
        public List<ClusterNode> ClusterNodes
        {
            get { return this.clusterNodes; }
            set { this.clusterNodes = value; }
        }

        // Check to see if ClusterNodes property is set
        internal bool IsSetClusterNodes()
        {
            return this.clusterNodes.Count > 0;
        }

        /// <summary>
        /// Describes the status of the elastic IP (EIP) address.
        ///  
        /// </summary>
        public ElasticIpStatus ElasticIpStatus
        {
            get { return this.elasticIpStatus; }
            set { this.elasticIpStatus = value; }
        }

        // Check to see if ElasticIpStatus property is set
        internal bool IsSetElasticIpStatus()
        {
            return this.elasticIpStatus != null;
        }
    }
}
