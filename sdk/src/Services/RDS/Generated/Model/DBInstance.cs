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
    /// Contains the details of an Amazon RDS DB instance.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the operations <c>CreateDBInstance</c>,
    /// <c>CreateDBInstanceReadReplica</c>, <c>DeleteDBInstance</c>, <c>DescribeDBInstances</c>,
    /// <c>ModifyDBInstance</c>, <c>PromoteReadReplica</c>, <c>RebootDBInstance</c>, <c>RestoreDBInstanceFromDBSnapshot</c>,
    /// <c>RestoreDBInstanceFromS3</c>, <c>RestoreDBInstanceToPointInTime</c>, <c>StartDBInstance</c>,
    /// and <c>StopDBInstance</c>.
    /// </para>
    /// </summary>
    public partial class DBInstance
    {
        private bool? _activityStreamEngineNativeAuditFieldsIncluded;
        private string _activityStreamKinesisStreamName;
        private string _activityStreamKmsKeyId;
        private ActivityStreamMode _activityStreamMode;
        private ActivityStreamPolicyStatus _activityStreamPolicyStatus;
        private ActivityStreamStatus _activityStreamStatus;
        private int? _allocatedStorage;
        private List<DBInstanceRole> _associatedRoles = AWSConfigs.InitializeCollections ? new List<DBInstanceRole>() : null;
        private DateTime? _automaticRestartTime;
        private AutomationMode _automationMode;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _awsBackupRecoveryPointArn;
        private int? _backupRetentionPeriod;
        private string _backupTarget;
        private string _caCertificateIdentifier;
        private CertificateDetails _certificateDetails;
        private string _characterSetName;
        private bool? _copyTagsToSnapshot;
        private bool? _customerOwnedIpEnabled;
        private string _customIamInstanceProfile;
        private DatabaseInsightsMode _databaseInsightsMode;
        private string _dbClusterIdentifier;
        private string _dbInstanceArn;
        private List<DBInstanceAutomatedBackupsReplication> _dbInstanceAutomatedBackupsReplications = AWSConfigs.InitializeCollections ? new List<DBInstanceAutomatedBackupsReplication>() : null;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private int? _dbInstancePort;
        private string _dbInstanceStatus;
        private string _dbiResourceId;
        private string _dbName;
        private List<DBParameterGroupStatus> _dbParameterGroups = AWSConfigs.InitializeCollections ? new List<DBParameterGroupStatus>() : null;
        private List<DBSecurityGroupMembership> _dbSecurityGroups = AWSConfigs.InitializeCollections ? new List<DBSecurityGroupMembership>() : null;
        private DBSubnetGroup _dbSubnetGroup;
        private string _dbSystemId;
        private bool? _dedicatedLogVolume;
        private bool? _deletionProtection;
        private List<DomainMembership> _domainMemberships = AWSConfigs.InitializeCollections ? new List<DomainMembership>() : null;
        private List<string> _enabledCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Endpoint _endpoint;
        private string _engine;
        private string _engineLifecycleSupport;
        private string _engineVersion;
        private string _enhancedMonitoringResourceArn;
        private bool? _iamDatabaseAuthenticationEnabled;
        private DateTime? _instanceCreateTime;
        private int? _iops;
        private bool? _isStorageConfigUpgradeAvailable;
        private string _kmsKeyId;
        private DateTime? _latestRestorableTime;
        private string _licenseModel;
        private Endpoint _listenerEndpoint;
        private string _masterUsername;
        private MasterUserSecret _masterUserSecret;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private bool? _multiTenant;
        private string _ncharCharacterSetName;
        private string _networkType;
        private List<OptionGroupMembership> _optionGroupMemberships = AWSConfigs.InitializeCollections ? new List<OptionGroupMembership>() : null;
        private PendingModifiedValues _pendingModifiedValues;
        private string _percentProgress;
        private bool? _performanceInsightsEnabled;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<ProcessorFeature> _processorFeatures = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private List<string> _readReplicaDBClusterIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _readReplicaDBInstanceIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _readReplicaSourceDBClusterIdentifier;
        private string _readReplicaSourceDBInstanceIdentifier;
        private ReplicaMode _replicaMode;
        private DateTime? _resumeFullAutomationModeTime;
        private string _secondaryAvailabilityZone;
        private List<DBInstanceStatusInfo> _statusInfos = AWSConfigs.InitializeCollections ? new List<DBInstanceStatusInfo>() : null;
        private bool? _storageEncrypted;
        private int? _storageThroughput;
        private string _storageType;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tdeCredentialArn;
        private string _timezone;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property ActivityStreamEngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Indicates whether engine-native audit fields are included in the database activity
        /// stream.
        /// </para>
        /// </summary>
        public bool ActivityStreamEngineNativeAuditFieldsIncluded
        {
            get { return this._activityStreamEngineNativeAuditFieldsIncluded.GetValueOrDefault(); }
            set { this._activityStreamEngineNativeAuditFieldsIncluded = value; }
        }

        // Check to see if ActivityStreamEngineNativeAuditFieldsIncluded property is set
        internal bool IsSetActivityStreamEngineNativeAuditFieldsIncluded()
        {
            return this._activityStreamEngineNativeAuditFieldsIncluded.HasValue; 
        }

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
        /// activity stream. The Amazon Web Services KMS key identifier is the key ARN, key ID,
        /// alias ARN, or alias name for the KMS key.
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
        /// generate an activity stream event. RDS for Oracle always handles these events asynchronously.
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
        /// Gets and sets the property ActivityStreamPolicyStatus. 
        /// <para>
        /// The status of the policy state of the activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamPolicyStatus ActivityStreamPolicyStatus
        {
            get { return this._activityStreamPolicyStatus; }
            set { this._activityStreamPolicyStatus = value; }
        }

        // Check to see if ActivityStreamPolicyStatus property is set
        internal bool IsSetActivityStreamPolicyStatus()
        {
            return this._activityStreamPolicyStatus != null;
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
        /// The amount of storage in gibibytes (GiB) allocated for the DB instance.
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
        /// The Amazon Web Services Identity and Access Management (IAM) roles associated with
        /// the DB instance.
        /// </para>
        /// </summary>
        public List<DBInstanceRole> AssociatedRoles
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
        /// The time when a stopped DB instance is restarted automatically.
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
        /// Gets and sets the property AutomationMode. 
        /// <para>
        /// The automation mode of the RDS Custom DB instance: <c>full</c> or <c>all paused</c>.
        /// If <c>full</c>, the DB instance automates monitoring and instance recovery. If <c>all
        /// paused</c>, the instance pauses automation for the duration set by <c>--resume-full-automation-mode-minutes</c>.
        /// </para>
        /// </summary>
        public AutomationMode AutomationMode
        {
            get { return this._automationMode; }
            set { this._automationMode = value; }
        }

        // Check to see if AutomationMode property is set
        internal bool IsSetAutomationMode()
        {
            return this._automationMode != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates whether minor version patches are applied automatically.
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone where the DB instance is located.
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic DB snapshots are retained.
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
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location where automated backups and manual snapshots are stored: Amazon Web Services
        /// Outposts or the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string BackupTarget
        {
            get { return this._backupTarget; }
            set { this._backupTarget = value; }
        }

        // Check to see if BackupTarget property is set
        internal bool IsSetBackupTarget()
        {
            return this._backupTarget != null;
        }

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The identifier of the CA certificate for this DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CACertificateIdentifier property is set
        internal bool IsSetCACertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateDetails. 
        /// <para>
        /// The details of the DB instance's server certificate.
        /// </para>
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
        /// If present, specifies the name of the character set that this instance is associated
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Indicates whether tags are copied from the DB instance to snapshots of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. Copying tags to snapshots
        /// is managed by the DB cluster. Setting this value for an Aurora DB instance has no
        /// effect on the DB cluster setting. For more information, see <c>DBCluster</c>.
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
        /// Gets and sets the property CustomerOwnedIpEnabled. 
        /// <para>
        /// Indicates whether a customer-owned IP address (CoIP) is enabled for an RDS on Outposts
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// A <i>CoIP </i>provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the DB instance from outside of its virtual private cloud
        /// (VPC) on your local network.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about CoIPs, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/routing.html#ip-addressing">Customer-owned
        /// IP addresses</a> in the <i>Amazon Web Services Outposts User Guide</i>.
        /// </para>
        /// </summary>
        public bool CustomerOwnedIpEnabled
        {
            get { return this._customerOwnedIpEnabled.GetValueOrDefault(); }
            set { this._customerOwnedIpEnabled = value; }
        }

        // Check to see if CustomerOwnedIpEnabled property is set
        internal bool IsSetCustomerOwnedIpEnabled()
        {
            return this._customerOwnedIpEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomIamInstanceProfile. 
        /// <para>
        /// The instance profile associated with the underlying Amazon EC2 instance of an RDS
        /// Custom DB instance. The instance profile must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The profile must exist in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The profile must have an IAM role that Amazon EC2 has permissions to assume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance profile name and the associated IAM role name must start with the prefix
        /// <c>AWSRDSCustom</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of permissions required for the IAM role, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-setup-orcl.html#custom-setup-orcl.iam-vpc">
        /// Configure IAM and your VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public string CustomIamInstanceProfile
        {
            get { return this._customIamInstanceProfile; }
            set { this._customIamInstanceProfile = value; }
        }

        // Check to see if CustomIamInstanceProfile property is set
        internal bool IsSetCustomIamInstanceProfile()
        {
            return this._customIamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// The mode of Database Insights that is enabled for the instance.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// If the DB instance is a member of a DB cluster, indicates the name of the DB cluster
        /// that the DB instance is a member of.
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
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceArn
        {
            get { return this._dbInstanceArn; }
            set { this._dbInstanceArn = value; }
        }

        // Check to see if DBInstanceArn property is set
        internal bool IsSetDBInstanceArn()
        {
            return this._dbInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsReplications. 
        /// <para>
        /// The list of replicated automated backups associated with the DB instance.
        /// </para>
        /// </summary>
        public List<DBInstanceAutomatedBackupsReplication> DBInstanceAutomatedBackupsReplications
        {
            get { return this._dbInstanceAutomatedBackupsReplications; }
            set { this._dbInstanceAutomatedBackupsReplications = value; }
        }

        // Check to see if DBInstanceAutomatedBackupsReplications property is set
        internal bool IsSetDBInstanceAutomatedBackupsReplications()
        {
            return this._dbInstanceAutomatedBackupsReplications != null && (this._dbInstanceAutomatedBackupsReplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class of the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The user-supplied database identifier. This identifier is the unique key that identifies
        /// a DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstancePort. 
        /// <para>
        /// The port that the DB instance listens on. If the DB instance is part of a DB cluster,
        /// this can be a different port than the DB cluster port.
        /// </para>
        /// </summary>
        public int DbInstancePort
        {
            get { return this._dbInstancePort.GetValueOrDefault(); }
            set { this._dbInstancePort = value; }
        }

        // Check to see if DbInstancePort property is set
        internal bool IsSetDbInstancePort()
        {
            return this._dbInstancePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceStatus. 
        /// <para>
        /// The current state of this database.
        /// </para>
        ///  
        /// <para>
        /// For information about DB instance statuses, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/accessing-monitoring.html#Overview.DBInstance.Status">Viewing
        /// DB instance status</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public string DBInstanceStatus
        {
            get { return this._dbInstanceStatus; }
            set { this._dbInstanceStatus = value; }
        }

        // Check to see if DBInstanceStatus property is set
        internal bool IsSetDBInstanceStatus()
        {
            return this._dbInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB instance. This
        /// identifier is found in Amazon Web Services CloudTrail log entries whenever the Amazon
        /// Web Services KMS key for the DB instance is accessed.
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The initial database name that you provided (if required) when you created the DB
        /// instance. This name is returned for the life of your DB instance. For an RDS for Oracle
        /// CDB instance, the name identifies the PDB rather than the CDB.
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
        /// Gets and sets the property DBParameterGroups. 
        /// <para>
        /// The list of DB parameter groups applied to this DB instance.
        /// </para>
        /// </summary>
        public List<DBParameterGroupStatus> DBParameterGroups
        {
            get { return this._dbParameterGroups; }
            set { this._dbParameterGroups = value; }
        }

        // Check to see if DBParameterGroups property is set
        internal bool IsSetDBParameterGroups()
        {
            return this._dbParameterGroups != null && (this._dbParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroups. 
        /// <para>
        /// A list of DB security group elements containing <c>DBSecurityGroup.Name</c> and <c>DBSecurityGroup.Status</c>
        /// subelements.
        /// </para>
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroups
        {
            get { return this._dbSecurityGroups; }
            set { this._dbSecurityGroups = value; }
        }

        // Check to see if DBSecurityGroups property is set
        internal bool IsSetDBSecurityGroups()
        {
            return this._dbSecurityGroups != null && (this._dbSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Information about the subnet group associated with the DB instance, including the
        /// name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public DBSubnetGroup DBSubnetGroup
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
        /// The Oracle system ID (Oracle SID) for a container database (CDB). The Oracle SID is
        /// also the name of the CDB. This setting is only valid for RDS Custom DB instances.
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
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.
        /// </para>
        /// </summary>
        public bool DedicatedLogVolume
        {
            get { return this._dedicatedLogVolume.GetValueOrDefault(); }
            set { this._dedicatedLogVolume = value; }
        }

        // Check to see if DedicatedLogVolume property is set
        internal bool IsSetDedicatedLogVolume()
        {
            return this._dedicatedLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the DB instance has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
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
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// The Active Directory Domain membership records associated with the DB instance.
        /// </para>
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
        /// Gets and sets the property EnabledCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that this DB instance is configured to export to CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        /// Log types vary by DB engine. For information about the log types for each DB engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html">Monitoring
        /// Amazon RDS log files</a> in the <i>Amazon RDS User Guide.</i> 
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
            return this._enabledCloudwatchLogsExports != null && (this._enabledCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// The endpoint might not be shown for instances with the status of <c>creating</c>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine used for this DB instance.
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
        /// The life cycle type for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see CreateDBInstance.
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
        /// Gets and sets the property EnhancedMonitoringResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch Logs log stream that receives
        /// the Enhanced Monitoring metrics data for the DB instance.
        /// </para>
        /// </summary>
        public string EnhancedMonitoringResourceArn
        {
            get { return this._enhancedMonitoringResourceArn; }
            set { this._enhancedMonitoringResourceArn = value; }
        }

        // Check to see if EnhancedMonitoringResourceArn property is set
        internal bool IsSetEnhancedMonitoringResourceArn()
        {
            return this._enhancedMonitoringResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether mapping of Amazon Web Services Identity and Access Management (IAM)
        /// accounts to database accounts is enabled for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For a list of engine versions that support IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RDS_Fea_Regions_DB-eng.Feature.IamDatabaseAuthentication.html">IAM
        /// database authentication</a> in the <i>Amazon RDS User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.Aurora_Fea_Regions_DB-eng.Feature.IAMdbauth.html">IAM
        /// database authentication in Aurora</a> in the <i>Amazon Aurora User Guide</i>.
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
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// The date and time when the DB instance was created.
        /// </para>
        /// </summary>
        public DateTime InstanceCreateTime
        {
            get { return this._instanceCreateTime.GetValueOrDefault(); }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS (I/O operations per second) value for the DB instance.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsStorageConfigUpgradeAvailable. 
        /// <para>
        /// Indicates whether an upgrade is recommended for the storage file system configuration
        /// on the DB instance. To migrate to the preferred configuration, you can either create
        /// a blue/green deployment, or create a read replica from the DB instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.UpgradeFileSystem">Upgrading
        /// the storage file system for a DB instance</a>.
        /// </para>
        /// </summary>
        public bool IsStorageConfigUpgradeAvailable
        {
            get { return this._isStorageConfigUpgradeAvailable.GetValueOrDefault(); }
            set { this._isStorageConfigUpgradeAvailable = value; }
        }

        // Check to see if IsStorageConfigUpgradeAvailable property is set
        internal bool IsSetIsStorageConfigUpgradeAvailable()
        {
            return this._isStorageConfigUpgradeAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>StorageEncrypted</c> is enabled, the Amazon Web Services KMS key identifier
        /// for the encrypted DB instance.
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
        /// The latest time to which a database in this DB instance can be restored with point-in-time
        /// restore.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model information for this DB instance. This setting doesn't apply to
        /// Amazon Aurora or RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerEndpoint. 
        /// <para>
        /// The listener connection endpoint for SQL Server Always On.
        /// </para>
        /// </summary>
        public Endpoint ListenerEndpoint
        {
            get { return this._listenerEndpoint; }
            set { this._listenerEndpoint = value; }
        }

        // Check to see if ListenerEndpoint property is set
        internal bool IsSetListenerEndpoint()
        {
            return this._listenerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master username for the DB instance.
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
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which Amazon RDS can automatically scale the
        /// storage of the DB instance.
        /// </para>
        /// </summary>
        public int MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage.GetValueOrDefault(); }
            set { this._maxAllocatedStorage = value; }
        }

        // Check to see if MaxAllocatedStorage property is set
        internal bool IsSetMaxAllocatedStorage()
        {
            return this._maxAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB instance.
        /// </para>
        /// </summary>
        public int MonitoringInterval
        {
            get { return this._monitoringInterval.GetValueOrDefault(); }
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
        /// Indicates whether the DB instance is a Multi-AZ deployment. This setting doesn't apply
        /// to RDS Custom DB instances.
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
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Specifies whether the DB instance is in the multi-tenant configuration (TRUE) or the
        /// single-tenant configuration (FALSE).
        /// </para>
        /// </summary>
        public bool MultiTenant
        {
            get { return this._multiTenant.GetValueOrDefault(); }
            set { this._multiTenant = value; }
        }

        // Check to see if MultiTenant property is set
        internal bool IsSetMultiTenant()
        {
            return this._multiTenant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The name of the NCHAR character set for the Oracle DB instance. This character set
        /// specifies the Unicode encoding for data stored in table columns of type NCHAR, NCLOB,
        /// or NVARCHAR2.
        /// </para>
        /// </summary>
        public string NcharCharacterSetName
        {
            get { return this._ncharCharacterSetName; }
            set { this._ncharCharacterSetName = value; }
        }

        // Check to see if NcharCharacterSetName property is set
        internal bool IsSetNcharCharacterSetName()
        {
            return this._ncharCharacterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB instance.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide</i> and <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
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
        /// Gets and sets the property OptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB instance.
        /// </para>
        /// </summary>
        public List<OptionGroupMembership> OptionGroupMemberships
        {
            get { return this._optionGroupMemberships; }
            set { this._optionGroupMemberships = value; }
        }

        // Check to see if OptionGroupMemberships property is set
        internal bool IsSetOptionGroupMemberships()
        {
            return this._optionGroupMemberships != null && (this._optionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Information about pending changes to the DB instance. This information is returned
        /// only when there are pending changes. Specific changes are identified by subelements.
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
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the storage optimization operation as a percentage.
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
        /// Indicates whether Performance Insights is enabled for the DB instance.
        /// </para>
        /// </summary>
        public bool PerformanceInsightsEnabled
        {
            get { return this._performanceInsightsEnabled.GetValueOrDefault(); }
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
        public int PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod.GetValueOrDefault(); }
            set { this._performanceInsightsRetentionPeriod = value; }
        }

        // Check to see if PerformanceInsightsRetentionPeriod property is set
        internal bool IsSetPerformanceInsightsRetentionPeriod()
        {
            return this._performanceInsightsRetentionPeriod.HasValue; 
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
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures
        {
            get { return this._processorFeatures; }
            set { this._processorFeatures = value; }
        }

        // Check to see if ProcessorFeatures property is set
        internal bool IsSetProcessorFeatures()
        {
            return this._processorFeatures != null && (this._processorFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The order of priority in which an Aurora Replica is promoted to the primary instance
        /// after a failure of the existing primary instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.AuroraHighAvailability.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public int PromotionTier
        {
            get { return this._promotionTier.GetValueOrDefault(); }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible and you connect from outside of the DB
        /// instance's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB instance,
        /// the endpoint resolves to the private IP address. Access to the DB cluster is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB cluster doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBInstance</a>.
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
        /// Gets and sets the property ReadReplicaDBClusterIdentifiers. 
        /// <para>
        /// The identifiers of Aurora DB clusters to which the RDS DB instance is replicated as
        /// a read replica. For example, when you create an Aurora read replica of an RDS for
        /// MySQL DB instance, the Aurora MySQL DB cluster for the Aurora read replica is shown.
        /// This output doesn't contain information about cross-Region Aurora read replicas.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, each RDS DB instance can have only one Aurora read replica.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> ReadReplicaDBClusterIdentifiers
        {
            get { return this._readReplicaDBClusterIdentifiers; }
            set { this._readReplicaDBClusterIdentifiers = value; }
        }

        // Check to see if ReadReplicaDBClusterIdentifiers property is set
        internal bool IsSetReadReplicaDBClusterIdentifiers()
        {
            return this._readReplicaDBClusterIdentifiers != null && (this._readReplicaDBClusterIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaDBInstanceIdentifiers. 
        /// <para>
        /// The identifiers of the read replicas associated with this DB instance.
        /// </para>
        /// </summary>
        public List<string> ReadReplicaDBInstanceIdentifiers
        {
            get { return this._readReplicaDBInstanceIdentifiers; }
            set { this._readReplicaDBInstanceIdentifiers = value; }
        }

        // Check to see if ReadReplicaDBInstanceIdentifiers property is set
        internal bool IsSetReadReplicaDBInstanceIdentifiers()
        {
            return this._readReplicaDBInstanceIdentifiers != null && (this._readReplicaDBInstanceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster if this DB instance is a read replica.
        /// </para>
        /// </summary>
        public string ReadReplicaSourceDBClusterIdentifier
        {
            get { return this._readReplicaSourceDBClusterIdentifier; }
            set { this._readReplicaSourceDBClusterIdentifier = value; }
        }

        // Check to see if ReadReplicaSourceDBClusterIdentifier property is set
        internal bool IsSetReadReplicaSourceDBClusterIdentifier()
        {
            return this._readReplicaSourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the source DB instance if this DB instance is a read replica.
        /// </para>
        /// </summary>
        public string ReadReplicaSourceDBInstanceIdentifier
        {
            get { return this._readReplicaSourceDBInstanceIdentifier; }
            set { this._readReplicaSourceDBInstanceIdentifier = value; }
        }

        // Check to see if ReadReplicaSourceDBInstanceIdentifier property is set
        internal bool IsSetReadReplicaSourceDBInstanceIdentifier()
        {
            return this._readReplicaSourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// The open mode of an Oracle read replica. The default is <c>open-read-only</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with Oracle Read Replicas for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This attribute is only supported in RDS for Oracle.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicaMode ReplicaMode
        {
            get { return this._replicaMode; }
            set { this._replicaMode = value; }
        }

        // Check to see if ReplicaMode property is set
        internal bool IsSetReplicaMode()
        {
            return this._replicaMode != null;
        }

        /// <summary>
        /// Gets and sets the property ResumeFullAutomationModeTime. 
        /// <para>
        /// The number of minutes to pause the automation. When the time period ends, RDS Custom
        /// resumes full automation. The minimum value is 60 (default). The maximum value is 1,440.
        /// </para>
        /// </summary>
        public DateTime ResumeFullAutomationModeTime
        {
            get { return this._resumeFullAutomationModeTime.GetValueOrDefault(); }
            set { this._resumeFullAutomationModeTime = value; }
        }

        // Check to see if ResumeFullAutomationModeTime property is set
        internal bool IsSetResumeFullAutomationModeTime()
        {
            return this._resumeFullAutomationModeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// If present, specifies the name of the secondary Availability Zone for a DB instance
        /// with multi-AZ support.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone
        {
            get { return this._secondaryAvailabilityZone; }
            set { this._secondaryAvailabilityZone = value; }
        }

        // Check to see if SecondaryAvailabilityZone property is set
        internal bool IsSetSecondaryAvailabilityZone()
        {
            return this._secondaryAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// The status of a read replica. If the DB instance isn't a read replica, the value is
        /// blank.
        /// </para>
        /// </summary>
        public List<DBInstanceStatusInfo> StatusInfos
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
        /// Indicates whether the DB instance is encrypted.
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
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to the <c>gp3</c> storage type.
        /// </para>
        /// </summary>
        public int StorageThroughput
        {
            get { return this._storageThroughput.GetValueOrDefault(); }
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
        /// The storage type associated with the DB instance.
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
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which the instance is associated for TDE encryption.
        /// </para>
        /// </summary>
        public string TdeCredentialArn
        {
            get { return this._tdeCredentialArn; }
            set { this._tdeCredentialArn = value; }
        }

        // Check to see if TdeCredentialArn property is set
        internal bool IsSetTdeCredentialArn()
        {
            return this._tdeCredentialArn != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the DB instance. In most cases, the <c>Timezone</c> element is empty.
        /// <c>Timezone</c> content appears only for RDS for Db2 and RDS for SQL Server DB instances
        /// that were created with a time zone specified.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The list of Amazon EC2 VPC security groups that the DB instance belongs to.
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
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}