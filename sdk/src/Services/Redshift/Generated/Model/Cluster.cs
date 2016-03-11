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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a cluster.
    /// </summary>
    public partial class Cluster
    {
        private bool? _allowVersionUpgrade;
        private int? _automatedSnapshotRetentionPeriod;
        private string _availabilityZone;
        private DateTime? _clusterCreateTime;
        private string _clusterIdentifier;
        private List<ClusterNode> _clusterNodes = new List<ClusterNode>();
        private List<ClusterParameterGroupStatus> _clusterParameterGroups = new List<ClusterParameterGroupStatus>();
        private string _clusterPublicKey;
        private string _clusterRevisionNumber;
        private List<ClusterSecurityGroupMembership> _clusterSecurityGroups = new List<ClusterSecurityGroupMembership>();
        private ClusterSnapshotCopyStatus _clusterSnapshotCopyStatus;
        private string _clusterStatus;
        private string _clusterSubnetGroupName;
        private string _clusterVersion;
        private string _dbName;
        private ElasticIpStatus _elasticIpStatus;
        private bool? _encrypted;
        private Endpoint _endpoint;
        private HsmStatus _hsmStatus;
        private string _kmsKeyId;
        private string _masterUsername;
        private string _modifyStatus;
        private string _nodeType;
        private int? _numberOfNodes;
        private PendingModifiedValues _pendingModifiedValues;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private RestoreStatus _restoreStatus;
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = new List<VpcSecurityGroupMembership>();

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        ///  If <code>true</code>, major version upgrades will be applied automatically to the
        /// cluster during the maintenance window. 
        /// </para>
        /// </summary>
        public bool AllowVersionUpgrade
        {
            get { return this._allowVersionUpgrade.GetValueOrDefault(); }
            set { this._allowVersionUpgrade = value; }
        }

        // Check to see if AllowVersionUpgrade property is set
        internal bool IsSetAllowVersionUpgrade()
        {
            return this._allowVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        ///  The number of days that automatic cluster snapshots are retained. 
        /// </para>
        /// </summary>
        public int AutomatedSnapshotRetentionPeriod
        {
            get { return this._automatedSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._automatedSnapshotRetentionPeriod = value; }
        }

        // Check to see if AutomatedSnapshotRetentionPeriod property is set
        internal bool IsSetAutomatedSnapshotRetentionPeriod()
        {
            return this._automatedSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The name of the Availability Zone in which the cluster is located. 
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        ///  The date and time that the cluster was created. 
        /// </para>
        /// </summary>
        public DateTime ClusterCreateTime
        {
            get { return this._clusterCreateTime.GetValueOrDefault(); }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///  The unique identifier of the cluster. 
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterNodes. 
        /// <para>
        /// The nodes in a cluster.
        /// </para>
        /// </summary>
        public List<ClusterNode> ClusterNodes
        {
            get { return this._clusterNodes; }
            set { this._clusterNodes = value; }
        }

        // Check to see if ClusterNodes property is set
        internal bool IsSetClusterNodes()
        {
            return this._clusterNodes != null && this._clusterNodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterParameterGroups. 
        /// <para>
        /// The list of cluster parameter groups that are associated with this cluster. Each parameter
        /// group in the list is returned with its status.
        /// </para>
        /// </summary>
        public List<ClusterParameterGroupStatus> ClusterParameterGroups
        {
            get { return this._clusterParameterGroups; }
            set { this._clusterParameterGroups = value; }
        }

        // Check to see if ClusterParameterGroups property is set
        internal bool IsSetClusterParameterGroups()
        {
            return this._clusterParameterGroups != null && this._clusterParameterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterPublicKey. 
        /// <para>
        /// The public key for the cluster.
        /// </para>
        /// </summary>
        public string ClusterPublicKey
        {
            get { return this._clusterPublicKey; }
            set { this._clusterPublicKey = value; }
        }

        // Check to see if ClusterPublicKey property is set
        internal bool IsSetClusterPublicKey()
        {
            return this._clusterPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterRevisionNumber. 
        /// <para>
        /// The specific revision number of the database in the cluster.
        /// </para>
        /// </summary>
        public string ClusterRevisionNumber
        {
            get { return this._clusterRevisionNumber; }
            set { this._clusterRevisionNumber = value; }
        }

        // Check to see if ClusterRevisionNumber property is set
        internal bool IsSetClusterRevisionNumber()
        {
            return this._clusterRevisionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroups. 
        /// <para>
        ///  A list of cluster security group that are associated with the cluster. Each security
        /// group is represented by an element that contains <code>ClusterSecurityGroup.Name</code>
        /// and <code>ClusterSecurityGroup.Status</code> subelements. 
        /// </para>
        ///  
        /// <para>
        /// Cluster security groups are used when the cluster is not created in a VPC. Clusters
        /// that are created in a VPC use VPC security groups, which are listed by the <b>VpcSecurityGroups</b>
        /// parameter. 
        /// </para>
        /// </summary>
        public List<ClusterSecurityGroupMembership> ClusterSecurityGroups
        {
            get { return this._clusterSecurityGroups; }
            set { this._clusterSecurityGroups = value; }
        }

        // Check to see if ClusterSecurityGroups property is set
        internal bool IsSetClusterSecurityGroups()
        {
            return this._clusterSecurityGroups != null && this._clusterSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterSnapshotCopyStatus. 
        /// <para>
        ///  Returns the destination region and retention period that are configured for cross-region
        /// snapshot copy. 
        /// </para>
        /// </summary>
        public ClusterSnapshotCopyStatus ClusterSnapshotCopyStatus
        {
            get { return this._clusterSnapshotCopyStatus; }
            set { this._clusterSnapshotCopyStatus = value; }
        }

        // Check to see if ClusterSnapshotCopyStatus property is set
        internal bool IsSetClusterSnapshotCopyStatus()
        {
            return this._clusterSnapshotCopyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        ///  The current state of the cluster. Possible values are: <ul> <li><code>available</code></li>
        /// <li><code>creating</code></li> <li><code>deleting</code></li> <li><code>final-snapshot</code></li>
        /// <li><code>hardware-failure</code></li> <li><code>incompatible-hsm</code></li> <li><code>incompatible-network</code></li>
        /// <li><code>incompatible-parameters</code></li> <li><code>incompatible-restore</code></li>
        /// <li><code>modifying</code></li> <li><code>rebooting</code></li> <li><code>renaming</code></li>
        /// <li><code>resizing</code></li> <li><code>rotating-keys</code></li> <li><code>storage-full</code></li>
        /// <li><code>updating-hsm</code></li> </ul> 
        /// </para>
        /// </summary>
        public string ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        ///  The name of the subnet group that is associated with the cluster. This parameter
        /// is valid only when the cluster is in a VPC. 
        /// </para>
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///  The version ID of the Amazon Redshift engine that is running on the cluster. 
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        ///  The name of the initial database that was created when the cluster was created. This
        /// same name is returned for the life of the cluster. If an initial database was not
        /// specified, a database named "dev" was created by default. 
        /// </para>
        /// </summary>
        public string DBName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticIpStatus. 
        /// <para>
        /// The status of the elastic IP (EIP) address.
        /// </para>
        /// </summary>
        public ElasticIpStatus ElasticIpStatus
        {
            get { return this._elasticIpStatus; }
            set { this._elasticIpStatus = value; }
        }

        // Check to see if ElasticIpStatus property is set
        internal bool IsSetElasticIpStatus()
        {
            return this._elasticIpStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// If <code>true</code>, data in the cluster is encrypted at rest.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        ///  The connection endpoint. 
        /// </para>
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HsmStatus. 
        /// <para>
        /// Reports whether the Amazon Redshift cluster has finished applying any HSM settings
        /// changes specified in a modify cluster command.
        /// </para>
        ///  
        /// <para>
        /// Values: active, applying
        /// </para>
        /// </summary>
        public HsmStatus HsmStatus
        {
            get { return this._hsmStatus; }
            set { this._hsmStatus = value; }
        }

        // Check to see if HsmStatus property is set
        internal bool IsSetHsmStatus()
        {
            return this._hsmStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (KMS) key ID of the encryption key used to encrypt
        /// data in the cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        ///  The master user name for the cluster. This name is used to connect to the database
        /// that is specified in <b>DBName</b>. 
        /// </para>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property ModifyStatus. 
        /// <para>
        /// The status of a modify operation, if any, initiated for the cluster.
        /// </para>
        /// </summary>
        public string ModifyStatus
        {
            get { return this._modifyStatus; }
            set { this._modifyStatus = value; }
        }

        // Check to see if ModifyStatus property is set
        internal bool IsSetModifyStatus()
        {
            return this._modifyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        ///  The node type for the nodes in the cluster. 
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
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        ///  The number of compute nodes in the cluster. 
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        ///  If present, changes to the cluster are pending. Specific pending changes are identified
        /// by subelements. 
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        ///  The weekly time range (in UTC) during which system maintenance can occur. 
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// If <code>true</code>, the cluster can be accessed from a public network.
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        ///  Describes the status of a cluster restore action. Returns null if the cluster was
        /// not created by restoring a snapshot. 
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get { return this._restoreStatus; }
            set { this._restoreStatus = value; }
        }

        // Check to see if RestoreStatus property is set
        internal bool IsSetRestoreStatus()
        {
            return this._restoreStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC the cluster is in, if the cluster is in a VPC. 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        ///  A list of Virtual Private Cloud (VPC) security groups that are associated with the
        /// cluster. This parameter is returned only if the cluster is in a VPC. 
        /// </para>
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && this._vpcSecurityGroups.Count > 0; 
        }

    }
}