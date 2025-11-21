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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details of an Amazon Aurora DB cluster or Multi-AZ DB cluster. 
    /// 
    ///  
    /// <para>
    /// For an Amazon Aurora DB cluster, this data type is used as a response element in the
    /// operations <c>CreateDBCluster</c>, <c>DeleteDBCluster</c>, <c>DescribeDBClusters</c>,
    /// <c>FailoverDBCluster</c>, <c>ModifyDBCluster</c>, <c>PromoteReadReplicaDBCluster</c>,
    /// <c>RestoreDBClusterFromS3</c>, <c>RestoreDBClusterFromSnapshot</c>, <c>RestoreDBClusterToPointInTime</c>,
    /// <c>StartDBCluster</c>, and <c>StopDBCluster</c>.
    /// </para>
    ///  
    /// <para>
    /// For a Multi-AZ DB cluster, this data type is used as a response element in the operations
    /// <c>CreateDBCluster</c>, <c>DeleteDBCluster</c>, <c>DescribeDBClusters</c>, <c>FailoverDBCluster</c>,
    /// <c>ModifyDBCluster</c>, <c>RebootDBCluster</c>, <c>RestoreDBClusterFromSnapshot</c>,
    /// and <c>RestoreDBClusterToPointInTime</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
    /// User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class DBCluster
    {
        private string _activityStreamKinesisStreamName;
        private string _activityStreamKmsKeyId;
        private ActivityStreamMode _activityStreamMode;
        private ActivityStreamStatus _activityStreamStatus;
        private int? _allocatedStorage;
        private List<DBClusterRole> _associatedRoles = AWSConfigs.InitializeCollections ? new List<DBClusterRole>() : null;
        private DateTime? _automaticRestartTime;
        private bool? _autoMinorVersionUpgrade;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsBackupRecoveryPointArn;
        private long? _backtrackConsumedChangeRecords;
        private long? _backtrackWindow;
        private int? _backupRetentionPeriod;
        private int? _capacity;
        private CertificateDetails _certificateDetails;
        private string _characterSetName;
        private string _cloneGroupId;
        private DateTime? _clusterCreateTime;
        private ClusterScalabilityType _clusterScalabilityType;
        private bool? _copyTagsToSnapshot;
        private bool? _crossAccountClone;
        private List<string> _customEndpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _databaseName;
        private string _dbClusterArn;
        private string _dbClusterIdentifier;
        private string _dbClusterInstanceClass;
        private List<DBClusterMember> _dbClusterMembers = AWSConfigs.InitializeCollections ? new List<DBClusterMember>() : null;
        private List<DBClusterOptionGroupStatus> _dbClusterOptionGroupMemberships = AWSConfigs.InitializeCollections ? new List<DBClusterOptionGroupStatus>() : null;
        private string _dbClusterParameterGroup;
        private string _dbClusterResourceId;
        private string _dbSubnetGroup;
        private string _dbSystemId;
        private bool? _deletionProtection;
        private List<DomainMembership> _domainMemberships = AWSConfigs.InitializeCollections ? new List<DomainMembership>() : null;
        private DateTime? _earliestBacktrackTime;
        private DateTime? _earliestRestorableTime;
        private List<string> _enabledCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _endpoint;
        private string _engine;
        private string _engineLifecycleSupport;
        private string _engineMode;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private bool? _globalWriteForwardingRequested;
        private WriteForwardingStatus _globalWriteForwardingStatus;
        private string _hostedZoneId;
        private bool? _httpEndpointEnabled;
        private bool? _iamDatabaseAuthenticationEnabled;
        private DateTime? _ioOptimizedNextAllowedModificationTime;
        private int? _iops;
        private string _kmsKeyId;
        private DateTime? _latestRestorableTime;
        private LimitlessDatabase _limitlessDatabase;
        private LocalWriteForwardingStatus _localWriteForwardingStatus;
        private string _masterUsername;
        private MasterUserSecret _masterUserSecret;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _networkType;
        private ClusterPendingModifiedValues _pendingModifiedValues;
        private string _percentProgress;
        private bool? _performanceInsightsEnabled;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private RdsCustomClusterConfiguration _rdsCustomClusterConfiguration;
        private string _readerEndpoint;
        private List<string> _readReplicaIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _replicationSourceIdentifier;
        private ScalingConfigurationInfo _scalingConfigurationInfo;
        private string _serverlessV2PlatformVersion;
        private ServerlessV2ScalingConfigurationInfo _serverlessV2ScalingConfiguration;
        private string _status;
        private List<DBClusterStatusInfo> _statusInfos = AWSConfigs.InitializeCollections ? new List<DBClusterStatusInfo>() : null;
        private bool? _storageEncrypted;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property ActivityStreamKinesisStreamName. 
        /// <para>
        /// The name of the Amazon Kinesis data stream used for the database activity stream.
        /// </para>
        /// </summary>
        public string ActivityStreamKinesisStreamName
        {
            get { return this._activityStreamKinesisStreamName; }
            set { this._activityStreamKinesisStreamName = value; }
        }

        // Check to see if ActivityStreamKinesisStreamName property is set
        internal bool IsSetActivityStreamKinesisStreamName()
        {
            return this._activityStreamKinesisStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityStreamKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier used for encrypting messages in the database
        /// activity stream.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        /// </summary>
        public string ActivityStreamKmsKeyId
        {
            get { return this._activityStreamKmsKeyId; }
            set { this._activityStreamKmsKeyId = value; }
        }

        // Check to see if ActivityStreamKmsKeyId property is set
        internal bool IsSetActivityStreamKmsKeyId()
        {
            return this._activityStreamKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityStreamMode. 
        /// <para>
        /// The mode of the database activity stream. Database events such as a change or access
        /// generate an activity stream event. The database session can handle these events either
        /// synchronously or asynchronously.
        /// </para>
        /// </summary>
        public ActivityStreamMode ActivityStreamMode
        {
            get { return this._activityStreamMode; }
            set { this._activityStreamMode = value; }
        }

        // Check to see if ActivityStreamMode property is set
        internal bool IsSetActivityStreamMode()
        {
            return this._activityStreamMode != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityStreamStatus. 
        /// <para>
        /// The status of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamStatus ActivityStreamStatus
        {
            get { return this._activityStreamStatus; }
            set { this._activityStreamStatus = value; }
        }

        // Check to see if ActivityStreamStatus property is set
        internal bool IsSetActivityStreamStatus()
        {
            return this._activityStreamStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  <c>AllocatedStorage</c> specifies the allocated storage size in gibibytes (GiB).
        /// For Aurora, <c>AllocatedStorage</c> can vary because Aurora DB cluster storage size
        /// adjusts as needed.
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
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
        /// A list of the Amazon Web Services Identity and Access Management (IAM) roles that
        /// are associated with the DB cluster. IAM roles that are associated with a DB cluster
        /// grant permission for the DB cluster to access other Amazon Web Services on your behalf.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterRole> AssociatedRoles
        {
            get { return this._associatedRoles; }
            set { this._associatedRoles = value; }
        }

        // Check to see if AssociatedRoles property is set
        internal bool IsSetAssociatedRoles()
        {
            return this._associatedRoles != null && (this._associatedRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutomaticRestartTime. 
        /// <para>
        /// The time when a stopped DB cluster is restarted automatically.
        /// </para>
        /// </summary>
        public DateTime? AutomaticRestartTime
        {
            get { return this._automaticRestartTime; }
            set { this._automaticRestartTime = value; }
        }

        // Check to see if AutomaticRestartTime property is set
        internal bool IsSetAutomaticRestartTime()
        {
            return this._automaticRestartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates whether minor version patches are applied automatically.
        /// </para>
        ///  
        /// <para>
        /// This setting is for Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        ///  
        /// <para>
        /// For more information about automatic minor version upgrades, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Upgrading.html#USER_UpgradeDBInstance.Upgrading.AutoMinorVersionUpgrades">Automatically
        /// upgrading the minor engine version</a>.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones (AZs) where instances in the DB cluster can be created.
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
        /// Gets and sets the property AwsBackupRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point in Amazon Web Services Backup.
        /// </para>
        /// </summary>
        public string AwsBackupRecoveryPointArn
        {
            get { return this._awsBackupRecoveryPointArn; }
            set { this._awsBackupRecoveryPointArn = value; }
        }

        // Check to see if AwsBackupRecoveryPointArn property is set
        internal bool IsSetAwsBackupRecoveryPointArn()
        {
            return this._awsBackupRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property BacktrackConsumedChangeRecords. 
        /// <para>
        /// The number of change records stored for Backtrack.
        /// </para>
        /// </summary>
        public long? BacktrackConsumedChangeRecords
        {
            get { return this._backtrackConsumedChangeRecords; }
            set { this._backtrackConsumedChangeRecords = value; }
        }

        // Check to see if BacktrackConsumedChangeRecords property is set
        internal bool IsSetBacktrackConsumedChangeRecords()
        {
            return this._backtrackConsumedChangeRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. If this value is set to <c>0</c>, backtracking
        /// is disabled for the DB cluster. Otherwise, backtracking is enabled.
        /// </para>
        /// </summary>
        public long? BacktrackWindow
        {
            get { return this._backtrackWindow; }
            set { this._backtrackWindow = value; }
        }

        // Check to see if BacktrackWindow property is set
        internal bool IsSetBacktrackWindow()
        {
            return this._backtrackWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod; }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The current capacity of an Aurora Serverless v1 DB cluster. The capacity is <c>0</c>
        /// (zero) when the cluster is paused.
        /// </para>
        ///  
        /// <para>
        /// For more information about Aurora Serverless v1, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
        /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public int? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CertificateDetails.
        /// </summary>
        public CertificateDetails CertificateDetails
        {
            get { return this._certificateDetails; }
            set { this._certificateDetails = value; }
        }

        // Check to see if CertificateDetails property is set
        internal bool IsSetCertificateDetails()
        {
            return this._certificateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// If present, specifies the name of the character set that this cluster is associated
        /// with.
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
        /// The ID of the clone group with which the DB cluster is associated. For newly created
        /// clusters, the ID is typically null. 
        /// </para>
        ///  
        /// <para>
        /// If you clone a DB cluster when the ID is null, the operation populates the ID value
        /// for the source cluster and the clone because both clusters become part of the same
        /// clone group. Even if you delete the clone cluster, the clone group ID remains for
        /// the lifetime of the source cluster to show that it was used in a cloning operation.
        /// </para>
        ///  
        /// <para>
        /// For PITR, the clone group ID is inherited from the source cluster. For snapshot restore
        /// operations, the clone group ID isn't inherited from the source cluster.
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
        /// The time when the DB cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime
        {
            get { return this._clusterCreateTime; }
            set { this._clusterCreateTime = value; }
        }

        // Check to see if ClusterCreateTime property is set
        internal bool IsSetClusterCreateTime()
        {
            return this._clusterCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterScalabilityType. 
        /// <para>
        /// The scalability mode of the Aurora DB cluster. When set to <c>limitless</c>, the cluster
        /// operates as an Aurora Limitless Database. When set to <c>standard</c> (the default),
        /// the cluster uses normal DB instance creation.
        /// </para>
        /// </summary>
        public ClusterScalabilityType ClusterScalabilityType
        {
            get { return this._clusterScalabilityType; }
            set { this._clusterScalabilityType = value; }
        }

        // Check to see if ClusterScalabilityType property is set
        internal bool IsSetClusterScalabilityType()
        {
            return this._clusterScalabilityType != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Indicates whether tags are copied from the DB cluster to snapshots of the DB cluster.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot; }
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
        /// Indicates whether the DB cluster is a clone of a DB cluster owned by a different Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        public bool? CrossAccountClone
        {
            get { return this._crossAccountClone; }
            set { this._crossAccountClone = value; }
        }

        // Check to see if CrossAccountClone property is set
        internal bool IsSetCrossAccountClone()
        {
            return this._crossAccountClone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomEndpoints. 
        /// <para>
        /// The custom endpoints associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomEndpoints
        {
            get { return this._customEndpoints; }
            set { this._customEndpoints = value; }
        }

        // Check to see if CustomEndpoints property is set
        internal bool IsSetCustomEndpoints()
        {
            return this._customEndpoints != null && (this._customEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// The mode of Database Insights that is enabled for the DB cluster.
        /// </para>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode
        {
            get { return this._databaseInsightsMode; }
            set { this._databaseInsightsMode = value; }
        }

        // Check to see if DatabaseInsightsMode property is set
        internal bool IsSetDatabaseInsightsMode()
        {
            return this._databaseInsightsMode != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the initial database that was specified for the DB cluster when it was
        /// created, if one was provided. This same name is returned for the life of the DB cluster.
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
        /// The user-supplied identifier for the DB cluster. This identifier is the unique key
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
        /// Gets and sets the property DBClusterInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public string DBClusterInstanceClass
        {
            get { return this._dbClusterInstanceClass; }
            set { this._dbClusterInstanceClass = value; }
        }

        // Check to see if DBClusterInstanceClass property is set
        internal bool IsSetDBClusterInstanceClass()
        {
            return this._dbClusterInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterMembers. 
        /// <para>
        /// The list of DB instances that make up the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterMember> DBClusterMembers
        {
            get { return this._dbClusterMembers; }
            set { this._dbClusterMembers = value; }
        }

        // Check to see if DBClusterMembers property is set
        internal bool IsSetDBClusterMembers()
        {
            return this._dbClusterMembers != null && (this._dbClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBClusterOptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterOptionGroupStatus> DBClusterOptionGroupMemberships
        {
            get { return this._dbClusterOptionGroupMemberships; }
            set { this._dbClusterOptionGroupMemberships = value; }
        }

        // Check to see if DBClusterOptionGroupMemberships property is set
        internal bool IsSetDBClusterOptionGroupMemberships()
        {
            return this._dbClusterOptionGroupMemberships != null && (this._dbClusterOptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroup. 
        /// <para>
        /// The name of the DB cluster parameter group for the DB cluster.
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
        /// The Amazon Web Services Region-unique, immutable identifier for the DB cluster. This
        /// identifier is found in Amazon Web Services CloudTrail log entries whenever the KMS
        /// key for the DB cluster is accessed.
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
        /// Information about the subnet group associated with the DB cluster, including the name,
        /// description, and subnets in the subnet group.
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
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string DBSystemId
        {
            get { return this._dbSystemId; }
            set { this._dbSystemId = value; }
        }

        // Check to see if DBSystemId property is set
        internal bool IsSetDBSystemId()
        {
            return this._dbSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the DB cluster has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// The Active Directory Domain membership records associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainMembership> DomainMemberships
        {
            get { return this._domainMemberships; }
            set { this._domainMemberships = value; }
        }

        // Check to see if DomainMemberships property is set
        internal bool IsSetDomainMemberships()
        {
            return this._domainMemberships != null && (this._domainMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EarliestBacktrackTime. 
        /// <para>
        /// The earliest time to which a DB cluster can be backtracked.
        /// </para>
        /// </summary>
        public DateTime? EarliestBacktrackTime
        {
            get { return this._earliestBacktrackTime; }
            set { this._earliestBacktrackTime = value; }
        }

        // Check to see if EarliestBacktrackTime property is set
        internal bool IsSetEarliestBacktrackTime()
        {
            return this._earliestBacktrackTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EarliestRestorableTime. 
        /// <para>
        /// The earliest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? EarliestRestorableTime
        {
            get { return this._earliestRestorableTime; }
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
        ///  
        /// <para>
        /// Log types vary by DB engine. For information about the log types for each DB engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html">Amazon
        /// RDS Database Log Files</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudwatchLogsExports
        {
            get { return this._enabledCloudwatchLogsExports; }
            set { this._enabledCloudwatchLogsExports = value; }
        }

        // Check to see if EnabledCloudwatchLogsExports property is set
        internal bool IsSetEnabledCloudwatchLogsExports()
        {
            return this._enabledCloudwatchLogsExports != null && (this._enabledCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the primary instance of the DB cluster.
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
        /// The database engine used for this DB cluster.
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
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The lifecycle type for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see CreateDBCluster.
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport
        {
            get { return this._engineLifecycleSupport; }
            set { this._engineLifecycleSupport = value; }
        }

        // Check to see if EngineLifecycleSupport property is set
        internal bool IsSetEngineLifecycleSupport()
        {
            return this._engineLifecycleSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <c>provisioned</c> or <c>serverless</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBCluster.html">
        /// CreateDBCluster</a>.
        /// </para>
        /// </summary>
        public string EngineMode
        {
            get { return this._engineMode; }
            set { this._engineMode = value; }
        }

        // Check to see if EngineMode property is set
        internal bool IsSetEngineMode()
        {
            return this._engineMode != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine.
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
        /// unique key that identifies a global database cluster.
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
        /// Gets and sets the property GlobalWriteForwardingRequested. 
        /// <para>
        /// Indicates whether write forwarding is enabled for a secondary cluster in an Aurora
        /// global database. Because write forwarding takes time to enable, check the value of
        /// <c>GlobalWriteForwardingStatus</c> to confirm that the request has completed before
        /// using the write forwarding feature for this cluster.
        /// </para>
        /// </summary>
        public bool? GlobalWriteForwardingRequested
        {
            get { return this._globalWriteForwardingRequested; }
            set { this._globalWriteForwardingRequested = value; }
        }

        // Check to see if GlobalWriteForwardingRequested property is set
        internal bool IsSetGlobalWriteForwardingRequested()
        {
            return this._globalWriteForwardingRequested.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalWriteForwardingStatus. 
        /// <para>
        /// The status of write forwarding for a secondary cluster in an Aurora global database.
        /// </para>
        /// </summary>
        public WriteForwardingStatus GlobalWriteForwardingStatus
        {
            get { return this._globalWriteForwardingStatus; }
            set { this._globalWriteForwardingStatus = value; }
        }

        // Check to see if GlobalWriteForwardingStatus property is set
        internal bool IsSetGlobalWriteForwardingStatus()
        {
            return this._globalWriteForwardingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID that Amazon Route 53 assigns when you create a hosted zone.
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
        /// Gets and sets the property HttpEndpointEnabled. 
        /// <para>
        /// Indicates whether the HTTP endpoint is enabled for an Aurora DB cluster.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API (RDS Data
        /// API) for running SQL queries on the DB cluster. You can also query your database from
        /// inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public bool? HttpEndpointEnabled
        {
            get { return this._httpEndpointEnabled; }
            set { this._httpEndpointEnabled = value; }
        }

        // Check to see if HttpEndpointEnabled property is set
        internal bool IsSetHttpEndpointEnabled()
        {
            return this._httpEndpointEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether the mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled
        {
            get { return this._iamDatabaseAuthenticationEnabled; }
            set { this._iamDatabaseAuthenticationEnabled = value; }
        }

        // Check to see if IAMDatabaseAuthenticationEnabled property is set
        internal bool IsSetIAMDatabaseAuthenticationEnabled()
        {
            return this._iamDatabaseAuthenticationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IOOptimizedNextAllowedModificationTime. 
        /// <para>
        /// The next time you can modify the DB cluster to use the <c>aurora-iopt1</c> storage
        /// type.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters.
        /// </para>
        /// </summary>
        public DateTime? IOOptimizedNextAllowedModificationTime
        {
            get { return this._ioOptimizedNextAllowedModificationTime; }
            set { this._ioOptimizedNextAllowedModificationTime = value; }
        }

        // Check to see if IOOptimizedNextAllowedModificationTime property is set
        internal bool IsSetIOOptimizedNextAllowedModificationTime()
        {
            return this._ioOptimizedNextAllowedModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS (I/O operations per second) value.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>StorageEncrypted</c> is enabled, the Amazon Web Services KMS key identifier
        /// for the encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
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
        /// The latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime
        {
            get { return this._latestRestorableTime; }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LimitlessDatabase. 
        /// <para>
        /// The details for Aurora Limitless Database.
        /// </para>
        /// </summary>
        public LimitlessDatabase LimitlessDatabase
        {
            get { return this._limitlessDatabase; }
            set { this._limitlessDatabase = value; }
        }

        // Check to see if LimitlessDatabase property is set
        internal bool IsSetLimitlessDatabase()
        {
            return this._limitlessDatabase != null;
        }

        /// <summary>
        /// Gets and sets the property LocalWriteForwardingStatus. 
        /// <para>
        /// Indicates whether an Aurora DB cluster has in-cluster write forwarding enabled, not
        /// enabled, requested, or is in the process of enabling it.
        /// </para>
        /// </summary>
        public LocalWriteForwardingStatus LocalWriteForwardingStatus
        {
            get { return this._localWriteForwardingStatus; }
            set { this._localWriteForwardingStatus = value; }
        }

        // Check to see if LocalWriteForwardingStatus property is set
        internal bool IsSetLocalWriteForwardingStatus()
        {
            return this._localWriteForwardingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master username for the DB cluster.
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
        /// Gets and sets the property MasterUserSecret. 
        /// <para>
        /// The secret managed by RDS in Amazon Web Services Secrets Manager for the master user
        /// password.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        public MasterUserSecret MasterUserSecret
        {
            get { return this._masterUserSecret; }
            set { this._masterUserSecret = value; }
        }

        // Check to see if MasterUserSecret property is set
        internal bool IsSetMasterUserSecret()
        {
            return this._masterUserSecret != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for -Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public int? MonitoringInterval
        {
            get { return this._monitoringInterval; }
            set { this._monitoringInterval = value; }
        }

        // Check to see if MonitoringInterval property is set
        internal bool IsSetMonitoringInterval()
        {
            return this._monitoringInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The ARN for the IAM role that permits RDS to send Enhanced Monitoring metrics to Amazon
        /// CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn
        {
            get { return this._monitoringRoleArn; }
            set { this._monitoringRoleArn = value; }
        }

        // Check to see if MonitoringRoleArn property is set
        internal bool IsSetMonitoringRoleArn()
        {
            return this._monitoringRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates whether the DB cluster has instances in multiple Availability Zones.
        /// </para>
        /// </summary>
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4 | DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType
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
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Information about pending changes to the DB cluster. This information is returned
        /// only when there are pending changes. Specific changes are identified by subelements.
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
        /// The progress of the operation as a percentage.
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
        /// Gets and sets the property PerformanceInsightsEnabled. 
        /// <para>
        /// Indicates whether Performance Insights is enabled for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public bool? PerformanceInsightsEnabled
        {
            get { return this._performanceInsightsEnabled; }
            set { this._performanceInsightsEnabled = value; }
        }

        // Check to see if PerformanceInsightsEnabled property is set
        internal bool IsSetPerformanceInsightsEnabled()
        {
            return this._performanceInsightsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of Performance Insights
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId
        {
            get { return this._performanceInsightsKMSKeyId; }
            set { this._performanceInsightsKMSKeyId = value; }
        }

        // Check to see if PerformanceInsightsKMSKeyId property is set
        internal bool IsSetPerformanceInsightsKMSKeyId()
        {
            return this._performanceInsightsKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>month</i> * 31, where <i>month</i> is a number of months from 1-23. Examples:
        /// <c>93</c> (3 months * 31), <c>341</c> (11 months * 31), <c>589</c> (19 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>731</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>7</c> days
        /// </para>
        /// </summary>
        public int? PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod; }
            set { this._performanceInsightsRetentionPeriod = value; }
        }

        // Check to see if PerformanceInsightsRetentionPeriod property is set
        internal bool IsSetPerformanceInsightsRetentionPeriod()
        {
            return this._performanceInsightsRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the database engine is listening on.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
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
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by the <c>BackupRetentionPeriod</c>.
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
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
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
        /// Indicates whether the DB cluster is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible and you connect from outside of the DB
        /// cluster's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB cluster,
        /// the endpoint resolves to the private IP address. Access to the DB cluster is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB cluster doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster isn't publicly accessible, it is an internal DB cluster with a
        /// DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RdsCustomClusterConfiguration. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public RdsCustomClusterConfiguration RdsCustomClusterConfiguration
        {
            get { return this._rdsCustomClusterConfiguration; }
            set { this._rdsCustomClusterConfiguration = value; }
        }

        // Check to see if RdsCustomClusterConfiguration property is set
        internal bool IsSetRdsCustomClusterConfiguration()
        {
            return this._rdsCustomClusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The reader endpoint for the DB cluster. The reader endpoint for a DB cluster load-balances
        /// connections across the Aurora Replicas that are available in a DB cluster. As clients
        /// request new connections to the reader endpoint, Aurora distributes the connection
        /// requests among the Aurora Replicas in the DB cluster. This functionality can help
        /// balance your read workload across multiple Aurora Replicas in your DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If a failover occurs, and the Aurora Replica that you are connected to is promoted
        /// to be the primary instance, your connection is dropped. To continue sending your read
        /// workload to other Aurora Replicas in the cluster, you can then reconnect to the reader
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
        /// Contains one or more identifiers of the read replicas associated with this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaIdentifiers
        {
            get { return this._readReplicaIdentifiers; }
            set { this._readReplicaIdentifiers = value; }
        }

        // Check to see if ReadReplicaIdentifiers property is set
        internal bool IsSetReadReplicaIdentifiers()
        {
            return this._readReplicaIdentifiers != null && (this._readReplicaIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationSourceIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster if this DB cluster is a read replica.
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
        /// Gets and sets the property ScalingConfigurationInfo.
        /// </summary>
        public ScalingConfigurationInfo ScalingConfigurationInfo
        {
            get { return this._scalingConfigurationInfo; }
            set { this._scalingConfigurationInfo = value; }
        }

        // Check to see if ScalingConfigurationInfo property is set
        internal bool IsSetScalingConfigurationInfo()
        {
            return this._scalingConfigurationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersion. 
        /// <para>
        /// The version of the Aurora Serverless V2 platform used by the DB cluster. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.html">Using
        /// Aurora Serverless v2</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public string ServerlessV2PlatformVersion
        {
            get { return this._serverlessV2PlatformVersion; }
            set { this._serverlessV2PlatformVersion = value; }
        }

        // Check to see if ServerlessV2PlatformVersion property is set
        internal bool IsSetServerlessV2PlatformVersion()
        {
            return this._serverlessV2PlatformVersion != null;
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
        /// The current state of this DB cluster.
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
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterStatusInfo> StatusInfos
        {
            get { return this._statusInfos; }
            set { this._statusInfos = value; }
        }

        // Check to see if StatusInfos property is set
        internal bool IsSetStatusInfos()
        {
            return this._statusInfos != null && (this._statusInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Indicates whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted
        {
            get { return this._storageEncrypted; }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the DB cluster. The throughput is automatically set based
        /// on the IOPS that you provision, and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public int? StorageThroughput
        {
            get { return this._storageThroughput; }
            set { this._storageThroughput = value; }
        }

        // Check to see if StorageThroughput property is set
        internal bool IsSetStorageThroughput()
        {
            return this._storageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB cluster.
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The list of VPC security groups that the DB cluster belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}