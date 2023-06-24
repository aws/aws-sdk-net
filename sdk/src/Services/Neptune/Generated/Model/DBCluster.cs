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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details of an Amazon Neptune DB cluster.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBClusters</a> action.
    /// </para>
    /// </summary>
    public partial class DBCluster
    {
        private int? _allocatedStorage;
        private List<DBClusterRole> _associatedRoles = new List<DBClusterRole>();
        private DateTime? _automaticRestartTime;
        private List<string> _availabilityZones = new List<string>();
        private int? _backupRetentionPeriod;
        private string _characterSetName;
        private string _cloneGroupId;
        private DateTime? _clusterCreateTime;
        private bool? _copyTagsToSnapshot;
        private bool? _crossAccountClone;
        private string _databaseName;
        private string _dbClusterArn;
        private string _dbClusterIdentifier;
        private List<DBClusterMember> _dbClusterMembers = new List<DBClusterMember>();
        private List<DBClusterOptionGroupStatus> _dbClusterOptionGroupMemberships = new List<DBClusterOptionGroupStatus>();
        private string _dbClusterParameterGroup;
        private string _dbClusterResourceId;
        private string _dbSubnetGroup;
        private bool? _deletionProtection;
        private DateTime? _earliestRestorableTime;
        private List<string> _enabledCloudwatchLogsExports = new List<string>();
        private string _endpoint;
        private string _engine;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private string _hostedZoneId;
        private bool? _iamDatabaseAuthenticationEnabled;
        private string _kmsKeyId;
        private DateTime? _latestRestorableTime;
        private string _masterUsername;
        private bool? _multiAZ;
        private ClusterPendingModifiedValues _pendingModifiedValues;
        private string _percentProgress;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _readerEndpoint;
        private List<string> _readReplicaIdentifiers = new List<string>();
        private string _replicationSourceIdentifier;
        private ServerlessV2ScalingConfigurationInfo _serverlessV2ScalingConfiguration;
        private string _status;
        private bool? _storageEncrypted;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = new List<VpcSecurityGroupMembership>();

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  <code>AllocatedStorage</code> always returns 1, because Neptune DB cluster storage
        /// size is not fixed, but instead automatically adjusts as needed.
        /// </para>
        /// </summary>
        public int AllocatedStorage
        {
            get { return this._allocatedStorage.GetValueOrDefault(); }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// Provides a list of the Amazon Identity and Access Management (IAM) roles that are
        /// associated with the DB cluster. IAM roles that are associated with a DB cluster grant
        /// permission for the DB cluster to access other Amazon services on your behalf.
        /// </para>
        /// </summary>
        public List<DBClusterRole> AssociatedRoles
        {
            get { return this._associatedRoles; }
            set { this._associatedRoles = value; }
        }

        // Check to see if AssociatedRoles property is set
        internal bool IsSetAssociatedRoles()
        {
            return this._associatedRoles != null && this._associatedRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutomaticRestartTime. 
        /// <para>
        /// Time at which the DB cluster will be automatically restarted.
        /// </para>
        /// </summary>
        public DateTime AutomaticRestartTime
        {
            get { return this._automaticRestartTime.GetValueOrDefault(); }
            set { this._automaticRestartTime = value; }
        }

        // Check to see if AutomaticRestartTime property is set
        internal bool IsSetAutomaticRestartTime()
        {
            return this._automaticRestartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of EC2 Availability Zones that instances in the DB cluster can be
        /// created in.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// Specifies the number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public string CharacterSetName
        {
            get { return this._characterSetName; }
            set { this._characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this._characterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property CloneGroupId. 
        /// <para>
        /// Identifies the clone group to which the DB cluster is associated.
        /// </para>
        /// </summary>
        public string CloneGroupId
        {
            get { return this._cloneGroupId; }
            set { this._cloneGroupId = value; }
        }

        // Check to see if CloneGroupId property is set
        internal bool IsSetCloneGroupId()
        {
            return this._cloneGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Specifies the time when the DB cluster was created, in Universal Coordinated Time
        /// (UTC).
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        ///  <i>If set to <code>true</code>, tags are copied to any snapshot of the DB cluster
        /// that is created.</i> 
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot.GetValueOrDefault(); }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossAccountClone. 
        /// <para>
        /// If set to <code>true</code>, the DB cluster can be cloned across accounts.
        /// </para>
        /// </summary>
        public bool CrossAccountClone
        {
            get { return this._crossAccountClone.GetValueOrDefault(); }
            set { this._crossAccountClone = value; }
        }

        // Check to see if CrossAccountClone property is set
        internal bool IsSetCrossAccountClone()
        {
            return this._crossAccountClone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Contains the name of the initial database of this DB cluster that was provided at
        /// create time, if one was specified when the DB cluster was created. This same name
        /// is returned for the life of the DB cluster.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterArn
        {
            get { return this._dbClusterArn; }
            set { this._dbClusterArn = value; }
        }

        // Check to see if DBClusterArn property is set
        internal bool IsSetDBClusterArn()
        {
            return this._dbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied DB cluster identifier. This identifier is the unique key
        /// that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterMembers. 
        /// <para>
        /// Provides the list of instances that make up the DB cluster.
        /// </para>
        /// </summary>
        public List<DBClusterMember> DBClusterMembers
        {
            get { return this._dbClusterMembers; }
            set { this._dbClusterMembers = value; }
        }

        // Check to see if DBClusterMembers property is set
        internal bool IsSetDBClusterMembers()
        {
            return this._dbClusterMembers != null && this._dbClusterMembers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterOptionGroupMemberships. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public List<DBClusterOptionGroupStatus> DBClusterOptionGroupMemberships
        {
            get { return this._dbClusterOptionGroupMemberships; }
            set { this._dbClusterOptionGroupMemberships = value; }
        }

        // Check to see if DBClusterOptionGroupMemberships property is set
        internal bool IsSetDBClusterOptionGroupMemberships()
        {
            return this._dbClusterOptionGroupMemberships != null && this._dbClusterOptionGroupMemberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroup. 
        /// <para>
        /// Specifies the name of the DB cluster parameter group for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroup
        {
            get { return this._dbClusterParameterGroup; }
            set { this._dbClusterParameterGroup = value; }
        }

        // Check to see if DBClusterParameterGroup property is set
        internal bool IsSetDBClusterParameterGroup()
        {
            return this._dbClusterParameterGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The Amazon Region-unique, immutable identifier for the DB cluster. This identifier
        /// is found in Amazon CloudTrail log entries whenever the Amazon KMS key for the DB cluster
        /// is accessed.
        /// </para>
        /// </summary>
        public string DbClusterResourceId
        {
            get { return this._dbClusterResourceId; }
            set { this._dbClusterResourceId = value; }
        }

        // Check to see if DbClusterResourceId property is set
        internal bool IsSetDbClusterResourceId()
        {
            return this._dbClusterResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Specifies information on the subnet group associated with the DB cluster, including
        /// the name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroup
        {
            get { return this._dbSubnetGroup; }
            set { this._dbSubnetGroup = value; }
        }

        // Check to see if DBSubnetGroup property is set
        internal bool IsSetDBSubnetGroup()
        {
            return this._dbSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not the DB cluster has deletion protection enabled. The database
        /// can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EarliestRestorableTime. 
        /// <para>
        /// Specifies the earliest time to which a database can be restored with point-in-time
        /// restore.
        /// </para>
        /// </summary>
        public DateTime EarliestRestorableTime
        {
            get { return this._earliestRestorableTime.GetValueOrDefault(); }
            set { this._earliestRestorableTime = value; }
        }

        // Check to see if EarliestRestorableTime property is set
        internal bool IsSetEarliestRestorableTime()
        {
            return this._earliestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnabledCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that this DB cluster is configured to export to CloudWatch Logs.
        /// </para>
        /// </summary>
        public List<string> EnabledCloudwatchLogsExports
        {
            get { return this._enabledCloudwatchLogsExports; }
            set { this._enabledCloudwatchLogsExports = value; }
        }

        // Check to see if EnabledCloudwatchLogsExports property is set
        internal bool IsSetEnabledCloudwatchLogsExports()
        {
            return this._enabledCloudwatchLogsExports != null && this._enabledCloudwatchLogsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint for the primary instance of the DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// Provides the name of the database engine to be used for this DB cluster.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Indicates the database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied global database cluster identifier. This identifier is the
        /// unique key that identifies a global database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specifies the ID that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// True if mapping of Amazon Identity and Access Management (IAM) accounts to database
        /// accounts is enabled, and otherwise false.
        /// </para>
        /// </summary>
        public bool IAMDatabaseAuthenticationEnabled
        {
            get { return this._iamDatabaseAuthenticationEnabled.GetValueOrDefault(); }
            set { this._iamDatabaseAuthenticationEnabled = value; }
        }

        // Check to see if IAMDatabaseAuthenticationEnabled property is set
        internal bool IsSetIAMDatabaseAuthenticationEnabled()
        {
            return this._iamDatabaseAuthenticationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <code>StorageEncrypted</code> is true, the Amazon KMS key identifier for the encrypted
        /// DB cluster.
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
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime LatestRestorableTime
        {
            get { return this._latestRestorableTime.GetValueOrDefault(); }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Not supported by Neptune.
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
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the DB cluster has instances in multiple Availability Zones.
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// This data type is used as a response element in the <code>ModifyDBCluster</code> operation
        /// and contains changes that will be applied during the next maintenance window.
        /// </para>
        /// </summary>
        public ClusterPendingModifiedValues PendingModifiedValues
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
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// Specifies the progress of the operation as a percentage.
        /// </para>
        /// </summary>
        public string PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine is listening on.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// Specifies the daily time range during which automated backups are created if automated
        /// backups are enabled, as determined by the <code>BackupRetentionPeriod</code>.
        /// </para>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which system maintenance can occur, in Universal
        /// Coordinated Time (UTC).
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
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The reader endpoint for the DB cluster. The reader endpoint for a DB cluster load-balances
        /// connections across the Read Replicas that are available in a DB cluster. As clients
        /// request new connections to the reader endpoint, Neptune distributes the connection
        /// requests among the Read Replicas in the DB cluster. This functionality can help balance
        /// your read workload across multiple Read Replicas in your DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If a failover occurs, and the Read Replica that you are connected to is promoted to
        /// be the primary instance, your connection is dropped. To continue sending your read
        /// workload to other Read Replicas in the cluster, you can then reconnect to the reader
        /// endpoint.
        /// </para>
        /// </summary>
        public string ReaderEndpoint
        {
            get { return this._readerEndpoint; }
            set { this._readerEndpoint = value; }
        }

        // Check to see if ReaderEndpoint property is set
        internal bool IsSetReaderEndpoint()
        {
            return this._readerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaIdentifiers. 
        /// <para>
        /// Contains one or more identifiers of the Read Replicas associated with this DB cluster.
        /// </para>
        /// </summary>
        public List<string> ReadReplicaIdentifiers
        {
            get { return this._readReplicaIdentifiers; }
            set { this._readReplicaIdentifiers = value; }
        }

        // Check to see if ReadReplicaIdentifiers property is set
        internal bool IsSetReadReplicaIdentifiers()
        {
            return this._readReplicaIdentifiers != null && this._readReplicaIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationSourceIdentifier. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier
        {
            get { return this._replicationSourceIdentifier; }
            set { this._replicationSourceIdentifier = value; }
        }

        // Check to see if ReplicationSourceIdentifier property is set
        internal bool IsSetReplicationSourceIdentifier()
        {
            return this._replicationSourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration.
        /// </summary>
        public ServerlessV2ScalingConfigurationInfo ServerlessV2ScalingConfiguration
        {
            get { return this._serverlessV2ScalingConfiguration; }
            set { this._serverlessV2ScalingConfiguration = value; }
        }

        // Check to see if ServerlessV2ScalingConfiguration property is set
        internal bool IsSetServerlessV2ScalingConfiguration()
        {
            return this._serverlessV2ScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current state of this DB cluster.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool StorageEncrypted
        {
            get { return this._storageEncrypted.GetValueOrDefault(); }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Provides a list of VPC security groups that the DB cluster belongs to.
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