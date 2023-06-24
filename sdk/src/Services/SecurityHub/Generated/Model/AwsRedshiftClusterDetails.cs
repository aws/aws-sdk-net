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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterDetails
    {
        private bool? _allowVersionUpgrade;
        private int? _automatedSnapshotRetentionPeriod;
        private string _availabilityZone;
        private string _clusterAvailabilityStatus;
        private string _clusterCreateTime;
        private string _clusterIdentifier;
        private List<AwsRedshiftClusterClusterNode> _clusterNodes = new List<AwsRedshiftClusterClusterNode>();
        private List<AwsRedshiftClusterClusterParameterGroup> _clusterParameterGroups = new List<AwsRedshiftClusterClusterParameterGroup>();
        private string _clusterPublicKey;
        private string _clusterRevisionNumber;
        private List<AwsRedshiftClusterClusterSecurityGroup> _clusterSecurityGroups = new List<AwsRedshiftClusterClusterSecurityGroup>();
        private AwsRedshiftClusterClusterSnapshotCopyStatus _clusterSnapshotCopyStatus;
        private string _clusterStatus;
        private string _clusterSubnetGroupName;
        private string _clusterVersion;
        private string _dbName;
        private List<AwsRedshiftClusterDeferredMaintenanceWindow> _deferredMaintenanceWindows = new List<AwsRedshiftClusterDeferredMaintenanceWindow>();
        private AwsRedshiftClusterElasticIpStatus _elasticIpStatus;
        private string _elasticResizeNumberOfNodeOptions;
        private bool? _encrypted;
        private AwsRedshiftClusterEndpoint _endpoint;
        private bool? _enhancedVpcRouting;
        private string _expectedNextSnapshotScheduleTime;
        private string _expectedNextSnapshotScheduleTimeStatus;
        private AwsRedshiftClusterHsmStatus _hsmStatus;
        private List<AwsRedshiftClusterIamRole> _iamRoles = new List<AwsRedshiftClusterIamRole>();
        private string _kmsKeyId;
        private AwsRedshiftClusterLoggingStatus _loggingStatus;
        private string _maintenanceTrackName;
        private int? _manualSnapshotRetentionPeriod;
        private string _masterUsername;
        private string _nextMaintenanceWindowStartTime;
        private string _nodeType;
        private int? _numberOfNodes;
        private List<string> _pendingActions = new List<string>();
        private AwsRedshiftClusterPendingModifiedValues _pendingModifiedValues;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private AwsRedshiftClusterResizeInfo _resizeInfo;
        private AwsRedshiftClusterRestoreStatus _restoreStatus;
        private string _snapshotScheduleIdentifier;
        private string _snapshotScheduleState;
        private string _vpcId;
        private List<AwsRedshiftClusterVpcSecurityGroup> _vpcSecurityGroups = new List<AwsRedshiftClusterVpcSecurityGroup>();

        /// <summary>
        /// Gets and sets the property AllowVersionUpgrade. 
        /// <para>
        /// Indicates whether major version upgrades are applied automatically to the cluster
        /// during the maintenance window.
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
        /// Gets and sets the property ClusterAvailabilityStatus. 
        /// <para>
        /// The availability status of the cluster for queries. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Available</code> - The cluster is available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Unavailable</code> - The cluster is not available for queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maintenance</code> - The cluster is intermittently available for queries due
        /// to maintenance activities.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Modifying</code> -The cluster is intermittently available for queries due to
        /// changes that modify the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - The cluster failed and is not available for queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Indicates when the cluster was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string ClusterCreateTime
        {
            get { return this._clusterCreateTime; }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster.
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
        /// The nodes in the cluster.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterClusterNode> ClusterNodes
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
        /// The list of cluster parameter groups that are associated with this cluster.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterClusterParameterGroup> ClusterParameterGroups
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
        /// A list of cluster security groups that are associated with the cluster.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterClusterSecurityGroup> ClusterSecurityGroups
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
        /// Information about the destination Region and retention period for the cross-Region
        /// snapshot copy.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterClusterSnapshotCopyStatus ClusterSnapshotCopyStatus
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
        /// The current status of the cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>available</code> | <code>available, prep-for-resize</code> | <code>available,
        /// resize-cleanup</code> |<code> cancelling-resize</code> | <code>creating</code> | <code>deleting</code>
        /// | <code>final-snapshot</code> | <code>hardware-failure</code> | <code>incompatible-hsm</code>
        /// |<code> incompatible-network</code> | <code>incompatible-parameters</code> | <code>incompatible-restore</code>
        /// | <code>modifying</code> | <code>paused</code> | <code>rebooting</code> | <code>renaming</code>
        /// | <code>resizing</code> | <code>rotating-keys</code> | <code>storage-full</code> |
        /// <code>updating-hsm</code> 
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
        /// The name of the subnet group that is associated with the cluster. This parameter is
        /// valid only when the cluster is in a VPC.
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
        /// The version ID of the Amazon Redshift engine that runs on the cluster.
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
        /// The name of the initial database that was created when the cluster was created.
        /// </para>
        ///  
        /// <para>
        /// The same name is returned for the life of the cluster.
        /// </para>
        ///  
        /// <para>
        /// If an initial database is not specified, a database named <code>devdev</code> is created
        /// by default.
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
        /// Gets and sets the property DeferredMaintenanceWindows. 
        /// <para>
        /// List of time windows during which maintenance was deferred.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterDeferredMaintenanceWindow> DeferredMaintenanceWindows
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
        /// Information about the status of the Elastic IP (EIP) address.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterElasticIpStatus ElasticIpStatus
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
        /// The number of nodes that you can use the elastic resize method to resize the cluster
        /// to.
        /// </para>
        /// </summary>
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
        /// Indicates whether the data in the cluster is encrypted at rest.
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
        public AwsRedshiftClusterEndpoint Endpoint
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
        /// Indicates whether to create the cluster with enhanced VPC routing enabled.
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
        /// Indicates when the next snapshot is expected to be taken. The cluster must have a
        /// valid snapshot schedule and have backups enabled.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string ExpectedNextSnapshotScheduleTime
        {
            get { return this._expectedNextSnapshotScheduleTime; }
            set { this._expectedNextSnapshotScheduleTime = value; }
        }

        // Check to see if ExpectedNextSnapshotScheduleTime property is set
        internal bool IsSetExpectedNextSnapshotScheduleTime()
        {
            return this._expectedNextSnapshotScheduleTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedNextSnapshotScheduleTimeStatus. 
        /// <para>
        /// The status of the next expected snapshot.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>OnTrack</code> | <code>Pending</code> 
        /// </para>
        /// </summary>
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
        /// Information about whether the Amazon Redshift cluster finished applying any changes
        /// to hardware security module (HSM) settings that were specified in a modify cluster
        /// command.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterHsmStatus HsmStatus
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
        /// A list of IAM roles that the cluster can use to access other Amazon Web Services services.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterIamRole> IamRoles
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
        /// The identifier of the KMS encryption key that is used to encrypt data in the cluster.
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
        /// Gets and sets the property LoggingStatus. 
        /// <para>
        /// Information about the logging status of the cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterLoggingStatus LoggingStatus
        {
            get { return this._loggingStatus; }
            set { this._loggingStatus = value; }
        }

        // Check to see if LoggingStatus property is set
        internal bool IsSetLoggingStatus()
        {
            return this._loggingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track for the cluster.
        /// </para>
        /// </summary>
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
        /// The default number of days to retain a manual snapshot.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>-1</code>, the snapshot is retained indefinitely.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't change the retention period of existing snapshots.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Either <code>-1</code> or an integer between 1 and 3,653
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
        /// that is specified in as the value of <code>DBName</code>.
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
        /// Gets and sets the property NextMaintenanceWindowStartTime. 
        /// <para>
        /// Indicates the start of the next maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string NextMaintenanceWindowStartTime
        {
            get { return this._nextMaintenanceWindowStartTime; }
            set { this._nextMaintenanceWindowStartTime = value; }
        }

        // Check to see if NextMaintenanceWindowStartTime property is set
        internal bool IsSetNextMaintenanceWindowStartTime()
        {
            return this._nextMaintenanceWindowStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the nodes in the cluster.
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
        /// A list of cluster operations that are waiting to start.
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
        /// A list of changes to the cluster that are currently pending.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterPendingModifiedValues PendingModifiedValues
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
        ///  
        /// <para>
        /// Format: <code> <i>&lt;day&gt;</i>:HH:MM-<i>&lt;day&gt;</i>:HH:MM</code> 
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <code>mon</code> | <code>tue</code> | <code>wed</code> | <code>thu</code>
        /// | <code>fri</code> | <code>sat</code> | <code>sun</code> 
        /// </para>
        ///  
        /// <para>
        /// For example, <code>sun:09:32-sun:10:02</code> 
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
        /// Whether the cluster can be accessed from a public network.
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
        /// Information about the resize operation for the cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterResizeInfo ResizeInfo
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
        /// Information about the status of a cluster restore action. Only applies to a cluster
        /// that was created by restoring a snapshot.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterRestoreStatus RestoreStatus
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
        ///  
        /// <para>
        /// Valid values: <code>MODIFYING</code> | <code>ACTIVE</code> | <code>FAILED</code> 
        /// </para>
        /// </summary>
        public string SnapshotScheduleState
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the cluster is in, if the cluster is in a VPC.
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
        /// The list of VPC security groups that the cluster belongs to, if the cluster is in
        /// a VPC.
        /// </para>
        /// </summary>
        public List<AwsRedshiftClusterVpcSecurityGroup> VpcSecurityGroups
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