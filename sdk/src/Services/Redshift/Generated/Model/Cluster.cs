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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private string _availabilityZoneRelocationStatus;
        private string _clusterAvailabilityStatus;
        private DateTime? _clusterCreateTime;
        private string _clusterIdentifier;
        private string _clusterNamespaceArn;
        private List<ClusterNode> _clusterNodes = new List<ClusterNode>();
        private List<ClusterParameterGroupStatus> _clusterParameterGroups = new List<ClusterParameterGroupStatus>();
        private string _clusterPublicKey;
        private string _clusterRevisionNumber;
        private List<ClusterSecurityGroupMembership> _clusterSecurityGroups = new List<ClusterSecurityGroupMembership>();
        private ClusterSnapshotCopyStatus _clusterSnapshotCopyStatus;
        private string _clusterStatus;
        private string _clusterSubnetGroupName;
        private string _clusterVersion;
        private DataTransferProgress _dataTransferProgress;
        private string _dbName;
        private List<DeferredMaintenanceWindow> _deferredMaintenanceWindows = new List<DeferredMaintenanceWindow>();
        private ElasticIpStatus _elasticIpStatus;
        private string _elasticResizeNumberOfNodeOptions;
        private bool? _encrypted;
        private Endpoint _endpoint;
        private bool? _enhancedVpcRouting;
        private DateTime? _expectedNextSnapshotScheduleTime;
        private string _expectedNextSnapshotScheduleTimeStatus;
        private HsmStatus _hsmStatus;
        private List<ClusterIamRole> _iamRoles = new List<ClusterIamRole>();
        private string _kmsKeyId;
        private string _maintenanceTrackName;
        private int? _manualSnapshotRetentionPeriod;
        private string _masterUsername;
        private string _modifyStatus;
        private DateTime? _nextMaintenanceWindowStartTime;
        private string _nodeType;
        private int? _numberOfNodes;
        private List<string> _pendingActions = new List<string>();
        private PendingModifiedValues _pendingModifiedValues;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private ResizeInfo _resizeInfo;
        private RestoreStatus _restoreStatus;
        private string _snapshotScheduleIdentifier;
        private ScheduleState _snapshotScheduleState;
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = new List<VpcSecurityGroupMembership>();

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// A boolean value that, if <code>true</code>, indicates that major version upgrades
        /// will be applied automatically to the cluster during the maintenance window. 
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
        /// The number of days that automatic cluster snapshots are retained.
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
        /// The name of the Availability Zone in which the cluster is located.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property AvailabilityZoneRelocationStatus. 
        /// <para>
        /// Describes the status of the Availability Zone relocation operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AvailabilityZoneRelocationStatus
        {
            get { return this._availabilityZoneRelocationStatus; }
            set { this._availabilityZoneRelocationStatus = value; }
        }

        // Check to see if AvailabilityZoneRelocationStatus property is set
        internal bool IsSetAvailabilityZoneRelocationStatus()
        {
            return this._availabilityZoneRelocationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterAvailabilityStatus. 
        /// <para>
        /// The availability status of the cluster for queries. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Available - The cluster is available for queries. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unavailable - The cluster is not available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maintenance - The cluster is intermittently available for queries due to maintenance
        /// activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifying - The cluster is intermittently available for queries due to changes that
        /// modify the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed - The cluster failed and is not available for queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterAvailabilityStatus
        {
            get { return this._clusterAvailabilityStatus; }
            set { this._clusterAvailabilityStatus = value; }
        }

        // Check to see if ClusterAvailabilityStatus property is set
        internal bool IsSetClusterAvailabilityStatus()
        {
            return this._clusterAvailabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// The date and time that the cluster was created.
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
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property ClusterNamespaceArn. 
        /// <para>
        /// The namespace Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterNamespaceArn
        {
            get { return this._clusterNamespaceArn; }
            set { this._clusterNamespaceArn = value; }
        }

        // Check to see if ClusterNamespaceArn property is set
        internal bool IsSetClusterNamespaceArn()
        {
            return this._clusterNamespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterNodes. 
        /// <para>
        /// The nodes in the cluster.
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
        [AWSProperty(Max=2147483647)]
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
        [AWSProperty(Max=2147483647)]
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
        /// A list of cluster security group that are associated with the cluster. Each security
        /// group is represented by an element that contains <code>ClusterSecurityGroup.Name</code>
        /// and <code>ClusterSecurityGroup.Status</code> subelements. 
        /// </para>
        ///  
        /// <para>
        /// Cluster security groups are used when the cluster is not created in an Amazon Virtual
        /// Private Cloud (VPC). Clusters that are created in a VPC use VPC security groups, which
        /// are listed by the <b>VpcSecurityGroups</b> parameter. 
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
        /// A value that returns the destination region and retention period that are configured
        /// for cross-region snapshot copy.
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
        ///  The current state of the cluster. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>available</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available, prep-for-resize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available, resize-cleanup</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelling-resize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>creating</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>final-snapshot</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hardware-failure</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>incompatible-hsm</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>incompatible-network</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>incompatible-parameters</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>incompatible-restore</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modifying</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>paused</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rebooting</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>renaming</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resizing</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rotating-keys</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>storage-full</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>updating-hsm</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The name of the subnet group that is associated with the cluster. This parameter is
        /// valid only when the cluster is in a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The version ID of the Amazon Redshift engine that is running on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property DataTransferProgress.
        /// </summary>
        public DataTransferProgress DataTransferProgress
        {
            get { return this._dataTransferProgress; }
            set { this._dataTransferProgress = value; }
        }

        // Check to see if DataTransferProgress property is set
        internal bool IsSetDataTransferProgress()
        {
            return this._dataTransferProgress != null;
        }

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the initial database that was created when the cluster was created. This
        /// same name is returned for the life of the cluster. If an initial database was not
        /// specified, a database named <code>dev</code>dev was created by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property DeferredMaintenanceWindows. 
        /// <para>
        /// Describes a group of <code>DeferredMaintenanceWindow</code> objects.
        /// </para>
        /// </summary>
        public List<DeferredMaintenanceWindow> DeferredMaintenanceWindows
        {
            get { return this._deferredMaintenanceWindows; }
            set { this._deferredMaintenanceWindows = value; }
        }

        // Check to see if DeferredMaintenanceWindows property is set
        internal bool IsSetDeferredMaintenanceWindows()
        {
            return this._deferredMaintenanceWindows != null && this._deferredMaintenanceWindows.Count > 0; 
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
        /// Gets and sets the property ElasticResizeNumberOfNodeOptions. 
        /// <para>
        /// The number of nodes that you can resize the cluster to with the elastic resize method.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ElasticResizeNumberOfNodeOptions
        {
            get { return this._elasticResizeNumberOfNodeOptions; }
            set { this._elasticResizeNumberOfNodeOptions = value; }
        }

        // Check to see if ElasticResizeNumberOfNodeOptions property is set
        internal bool IsSetElasticResizeNumberOfNodeOptions()
        {
            return this._elasticResizeNumberOfNodeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A boolean value that, if <code>true</code>, indicates that data in the cluster is
        /// encrypted at rest.
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
        /// The connection endpoint.
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
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// An option that specifies whether to create the cluster with enhanced VPC routing enabled.
        /// To create a cluster that uses enhanced VPC routing, the cluster must be in a VPC.
        /// For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/enhanced-vpc-routing.html">Enhanced
        /// VPC Routing</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If this option is <code>true</code>, enhanced VPC routing is enabled. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting.GetValueOrDefault(); }
            set { this._enhancedVpcRouting = value; }
        }

        // Check to see if EnhancedVpcRouting property is set
        internal bool IsSetEnhancedVpcRouting()
        {
            return this._enhancedVpcRouting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTime. 
        /// <para>
        /// The date and time when the next snapshot is expected to be taken for clusters with
        /// a valid snapshot schedule and backups enabled. 
        /// </para>
        /// </summary>
        public DateTime ExpectedNextSnapshotScheduleTime
        {
            get { return this._expectedNextSnapshotScheduleTime.GetValueOrDefault(); }
            set { this._expectedNextSnapshotScheduleTime = value; }
        }

        // Check to see if ExpectedNextSnapshotScheduleTime property is set
        internal bool IsSetExpectedNextSnapshotScheduleTime()
        {
            return this._expectedNextSnapshotScheduleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTimeStatus. 
        /// <para>
        ///  The status of next expected snapshot for clusters having a valid snapshot schedule
        /// and backups enabled. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// OnTrack - The next snapshot is expected to be taken on time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending - The next snapshot is pending to be taken. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ExpectedNextSnapshotScheduleTimeStatus
        {
            get { return this._expectedNextSnapshotScheduleTimeStatus; }
            set { this._expectedNextSnapshotScheduleTimeStatus = value; }
        }

        // Check to see if ExpectedNextSnapshotScheduleTimeStatus property is set
        internal bool IsSetExpectedNextSnapshotScheduleTimeStatus()
        {
            return this._expectedNextSnapshotScheduleTimeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HsmStatus. 
        /// <para>
        /// A value that reports whether the Amazon Redshift cluster has finished applying any
        /// hardware security module (HSM) settings changes specified in a modify cluster command.
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
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of AWS Identity and Access Management (IAM) roles that can be used by the cluster
        /// to access other AWS services.
        /// </para>
        /// </summary>
        public List<ClusterIamRole> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && this._iamRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key ID of the encryption key used to encrypt
        /// data in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MaintenanceTrackName
        {
            get { return this._maintenanceTrackName; }
            set { this._maintenanceTrackName = value; }
        }

        // Check to see if MaintenanceTrackName property is set
        internal bool IsSetMaintenanceTrackName()
        {
            return this._maintenanceTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property ManualSnapshotRetentionPeriod. 
        /// <para>
        /// The default number of days to retain a manual snapshot. If the value is -1, the snapshot
        /// is retained indefinitely. This setting doesn't change the retention period of existing
        /// snapshots.
        /// </para>
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </summary>
        public int ManualSnapshotRetentionPeriod
        {
            get { return this._manualSnapshotRetentionPeriod.GetValueOrDefault(); }
            set { this._manualSnapshotRetentionPeriod = value; }
        }

        // Check to see if ManualSnapshotRetentionPeriod property is set
        internal bool IsSetManualSnapshotRetentionPeriod()
        {
            return this._manualSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name for the cluster. This name is used to connect to the database
        /// that is specified in the <b>DBName</b> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property NextMaintenanceWindowStartTime. 
        /// <para>
        /// The date and time in UTC when system maintenance can begin.
        /// </para>
        /// </summary>
        public DateTime NextMaintenanceWindowStartTime
        {
            get { return this._nextMaintenanceWindowStartTime.GetValueOrDefault(); }
            set { this._nextMaintenanceWindowStartTime = value; }
        }

        // Check to see if NextMaintenanceWindowStartTime property is set
        internal bool IsSetNextMaintenanceWindowStartTime()
        {
            return this._nextMaintenanceWindowStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// The number of compute nodes in the cluster.
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
        /// Gets and sets the property PendingActions. 
        /// <para>
        /// Cluster operations that are waiting to be started.
        /// </para>
        /// </summary>
        public List<string> PendingActions
        {
            get { return this._pendingActions; }
            set { this._pendingActions = value; }
        }

        // Check to see if PendingActions property is set
        internal bool IsSetPendingActions()
        {
            return this._pendingActions != null && this._pendingActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A value that, if present, indicates that changes to the cluster are pending. Specific
        /// pending changes are identified by subelements.
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
        /// The weekly time range, in Universal Coordinated Time (UTC), during which system maintenance
        /// can occur.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// A boolean value that, if <code>true</code>, indicates that the cluster can be accessed
        /// from a public network.
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
        /// Gets and sets the property ResizeInfo. 
        /// <para>
        /// Returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AllowCancelResize: a boolean value indicating if the resize operation can be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResizeType: Returns ClassicResize
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResizeInfo ResizeInfo
        {
            get { return this._resizeInfo; }
            set { this._resizeInfo = value; }
        }

        // Check to see if ResizeInfo property is set
        internal bool IsSetResizeInfo()
        {
            return this._resizeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// A value that describes the status of a cluster restore action. This parameter returns
        /// null if the cluster was not created by restoring a snapshot.
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
        /// Gets and sets the property SnapshotScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the cluster snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotScheduleIdentifier
        {
            get { return this._snapshotScheduleIdentifier; }
            set { this._snapshotScheduleIdentifier = value; }
        }

        // Check to see if SnapshotScheduleIdentifier property is set
        internal bool IsSetSnapshotScheduleIdentifier()
        {
            return this._snapshotScheduleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotScheduleState. 
        /// <para>
        /// The current state of the cluster snapshot schedule.
        /// </para>
        /// </summary>
        public ScheduleState SnapshotScheduleState
        {
            get { return this._snapshotScheduleState; }
            set { this._snapshotScheduleState = value; }
        }

        // Check to see if SnapshotScheduleState property is set
        internal bool IsSetSnapshotScheduleState()
        {
            return this._snapshotScheduleState != null;
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
        [AWSProperty(Max=2147483647)]
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
        /// A list of Amazon Virtual Private Cloud (Amazon VPC) security groups that are associated
        /// with the cluster. This parameter is returned only if the cluster is in a VPC.
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