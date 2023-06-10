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
    /// Contains the details of an Amazon RDS DB instance.
    /// </summary>
    public partial class AwsRdsDbInstanceDetails
    {
        private int? _allocatedStorage;
        private List<AwsRdsDbInstanceAssociatedRole> _associatedRoles = new List<AwsRdsDbInstanceAssociatedRole>();
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private string _characterSetName;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private int? _dbInstancePort;
        private string _dbInstanceStatus;
        private string _dbiResourceId;
        private string _dbName;
        private List<AwsRdsDbParameterGroup> _dbParameterGroups = new List<AwsRdsDbParameterGroup>();
        private List<string> _dbSecurityGroups = new List<string>();
        private AwsRdsDbSubnetGroup _dbSubnetGroup;
        private bool? _deletionProtection;
        private List<AwsRdsDbDomainMembership> _domainMemberships = new List<AwsRdsDbDomainMembership>();
        private List<string> _enabledCloudWatchLogsExports = new List<string>();
        private AwsRdsDbInstanceEndpoint _endpoint;
        private string _engine;
        private string _engineVersion;
        private string _enhancedMonitoringResourceArn;
        private bool? _iamDatabaseAuthenticationEnabled;
        private string _instanceCreateTime;
        private int? _iops;
        private string _kmsKeyId;
        private string _latestRestorableTime;
        private string _licenseModel;
        private AwsRdsDbInstanceEndpoint _listenerEndpoint;
        private string _masterUsername;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAz;
        private List<AwsRdsDbOptionGroupMembership> _optionGroupMemberships = new List<AwsRdsDbOptionGroupMembership>();
        private AwsRdsDbPendingModifiedValues _pendingModifiedValues;
        private bool? _performanceInsightsEnabled;
        private string _performanceInsightsKmsKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<AwsRdsDbProcessorFeature> _processorFeatures = new List<AwsRdsDbProcessorFeature>();
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private List<string> _readReplicaDBClusterIdentifiers = new List<string>();
        private List<string> _readReplicaDBInstanceIdentifiers = new List<string>();
        private string _readReplicaSourceDBInstanceIdentifier;
        private string _secondaryAvailabilityZone;
        private List<AwsRdsDbStatusInfo> _statusInfos = new List<AwsRdsDbStatusInfo>();
        private bool? _storageEncrypted;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _timezone;
        private List<AwsRdsDbInstanceVpcSecurityGroup> _vpcSecurityGroups = new List<AwsRdsDbInstanceVpcSecurityGroup>();

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to initially allocate for the DB instance.
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
        /// The IAM roles associated with the DB instance.
        /// </para>
        /// </summary>
        public List<AwsRdsDbInstanceAssociatedRole> AssociatedRoles
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
        /// The Availability Zone where the DB instance will be created.
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which to retain automated backups.
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
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The identifier of the CA certificate for this DB instance.
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
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// The name of the character set that this DB instance is associated with.
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
        /// Whether to copy resource tags to snapshots of the DB instance.
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
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// If the DB instance is a member of a DB cluster, contains the name of the DB cluster
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// Contains the name of the compute and memory capacity class of the DB instance.
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
        /// Contains a user-supplied database identifier. This identifier is the unique key that
        /// identifies a DB instance.
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
        /// Specifies the port that the DB instance listens on. If the DB instance is part of
        /// a DB cluster, this can be a different port than the DB cluster port.
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
        /// Gets and sets the property DbInstanceStatus. 
        /// <para>
        /// The current status of the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceStatus
        {
            get { return this._dbInstanceStatus; }
            set { this._dbInstanceStatus = value; }
        }

        // Check to see if DbInstanceStatus property is set
        internal bool IsSetDbInstanceStatus()
        {
            return this._dbInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB instance. This
        /// identifier is found in CloudTrail log entries whenever the KMS key for the DB instance
        /// is accessed. 
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
        /// The meaning of this parameter differs according to the database engine you use.
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL, MariaDB, SQL Server, PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Contains the name of the initial database of this instance that was provided at create
        /// time, if one was specified when the DB instance was created. This same name is returned
        /// for the life of the DB instance.
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  
        /// <para>
        /// Contains the Oracle System ID (SID) of the created DB instance. Not shown when the
        /// returned parameters do not apply to an Oracle DB instance. 
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
        /// Gets and sets the property DbParameterGroups. 
        /// <para>
        /// A list of the DB parameter groups to assign to the DB instance.
        /// </para>
        /// </summary>
        public List<AwsRdsDbParameterGroup> DbParameterGroups
        {
            get { return this._dbParameterGroups; }
            set { this._dbParameterGroups = value; }
        }

        // Check to see if DbParameterGroups property is set
        internal bool IsSetDbParameterGroups()
        {
            return this._dbParameterGroups != null && this._dbParameterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DbSecurityGroups. 
        /// <para>
        /// A list of the DB security groups to assign to the DB instance.
        /// </para>
        /// </summary>
        public List<string> DbSecurityGroups
        {
            get { return this._dbSecurityGroups; }
            set { this._dbSecurityGroups = value; }
        }

        // Check to see if DbSecurityGroups property is set
        internal bool IsSetDbSecurityGroups()
        {
            return this._dbSecurityGroups != null && this._dbSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DbSubnetGroup. 
        /// <para>
        /// Information about the subnet group that is associated with the DB instance.
        /// </para>
        /// </summary>
        public AwsRdsDbSubnetGroup DbSubnetGroup
        {
            get { return this._dbSubnetGroup; }
            set { this._dbSubnetGroup = value; }
        }

        // Check to see if DbSubnetGroup property is set
        internal bool IsSetDbSubnetGroup()
        {
            return this._dbSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the DB instance has deletion protection enabled.
        /// </para>
        ///  
        /// <para>
        /// When deletion protection is enabled, the database cannot be deleted.
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
        /// The Active Directory domain membership records associated with the DB instance.
        /// </para>
        /// </summary>
        public List<AwsRdsDbDomainMembership> DomainMemberships
        {
            get { return this._domainMemberships; }
            set { this._domainMemberships = value; }
        }

        // Check to see if DomainMemberships property is set
        internal bool IsSetDomainMemberships()
        {
            return this._domainMemberships != null && this._domainMemberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnabledCloudWatchLogsExports. 
        /// <para>
        /// A list of log types that this DB instance is configured to export to CloudWatch Logs.
        /// </para>
        /// </summary>
        public List<string> EnabledCloudWatchLogsExports
        {
            get { return this._enabledCloudWatchLogsExports; }
            set { this._enabledCloudWatchLogsExports = value; }
        }

        // Check to see if EnabledCloudWatchLogsExports property is set
        internal bool IsSetEnabledCloudWatchLogsExports()
        {
            return this._enabledCloudWatchLogsExports != null && this._enabledCloudWatchLogsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint.
        /// </para>
        /// </summary>
        public AwsRdsDbInstanceEndpoint Endpoint
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
        /// Provides the name of the database engine to use for this DB instance.
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
        /// Gets and sets the property EnhancedMonitoringResourceArn. 
        /// <para>
        /// The ARN of the CloudWatch Logs log stream that receives the enhanced monitoring metrics
        /// data for the DB instance.
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
        /// True if mapping of IAM accounts to database accounts is enabled, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// IAM database authentication can be enabled for the following database engines.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For MySQL 5.6, minor version 5.6.34 or higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For MySQL 5.7, minor version 5.7.16 or higher
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Aurora 5.6 or higher
        /// </para>
        ///  </li> </ul>
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
        /// Indicates when the DB instance was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the provisioned IOPS (I/O operations per second) for this DB instance.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <code>StorageEncrypted</code> is true, the KMS key identifier for the encrypted
        /// DB instance.
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
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LatestRestorableTime
        {
            get { return this._latestRestorableTime; }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// License model information for this DB instance.
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
        /// </summary>
        public AwsRdsDbInstanceEndpoint ListenerEndpoint
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
        /// The master user name of the DB instance.
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
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit to which Amazon RDS can automatically scale the storage of the DB
        /// instance.
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
        /// The interval, in seconds, between points when enhanced monitoring metrics are collected
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
        /// The ARN for the IAM role that permits Amazon RDS to send enhanced monitoring metrics
        /// to CloudWatch Logs.
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
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// Whether the DB instance is a multiple Availability Zone deployment.
        /// </para>
        /// </summary>
        public bool MultiAz
        {
            get { return this._multiAz.GetValueOrDefault(); }
            set { this._multiAz = value; }
        }

        // Check to see if MultiAz property is set
        internal bool IsSetMultiAz()
        {
            return this._multiAz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB instance.
        /// </para>
        /// </summary>
        public List<AwsRdsDbOptionGroupMembership> OptionGroupMemberships
        {
            get { return this._optionGroupMemberships; }
            set { this._optionGroupMemberships = value; }
        }

        // Check to see if OptionGroupMemberships property is set
        internal bool IsSetOptionGroupMemberships()
        {
            return this._optionGroupMemberships != null && this._optionGroupMemberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Changes to the DB instance that are currently pending.
        /// </para>
        /// </summary>
        public AwsRdsDbPendingModifiedValues PendingModifiedValues
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
        /// Gets and sets the property PerformanceInsightsKmsKeyId. 
        /// <para>
        /// The identifier of the KMS key used to encrypt the Performance Insights data.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKmsKeyId
        {
            get { return this._performanceInsightsKmsKeyId; }
            set { this._performanceInsightsKmsKeyId = value; }
        }

        // Check to see if PerformanceInsightsKmsKeyId property is set
        internal bool IsSetPerformanceInsightsKmsKeyId()
        {
            return this._performanceInsightsKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
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
        /// The range of time each day when automated backups are created, if automated backups
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// Uses the format <code>HH:MM-HH:MM</code>. For example, <code>04:52-05:22</code>.
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
        ///  
        /// <para>
        /// Uses the format <code>&lt;day&gt;:HH:MM-&lt;day&gt;:HH:MM</code>.
        /// </para>
        ///  
        /// <para>
        /// For the day values, use <code>mon</code>|<code>tue</code>|<code>wed</code>|<code>thu</code>|<code>fri</code>|<code>sat</code>|<code>sun</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, <code>sun:09:32-sun:10:02</code>.
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
        public List<AwsRdsDbProcessorFeature> ProcessorFeatures
        {
            get { return this._processorFeatures; }
            set { this._processorFeatures = value; }
        }

        // Check to see if ProcessorFeatures property is set
        internal bool IsSetProcessorFeatures()
        {
            return this._processorFeatures != null && this._processorFeatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The order in which to promote an Aurora replica to the primary instance after a failure
        /// of the existing primary instance.
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
        /// Specifies the accessibility options for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// A value of true specifies an Internet-facing instance with a publicly resolvable DNS
        /// name, which resolves to a public IP address.
        /// </para>
        ///  
        /// <para>
        /// A value of false specifies an internal instance with a DNS name that resolves to a
        /// private IP address. 
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
        /// List of identifiers of Aurora DB clusters to which the RDS DB instance is replicated
        /// as a read replica.
        /// </para>
        /// </summary>
        public List<string> ReadReplicaDBClusterIdentifiers
        {
            get { return this._readReplicaDBClusterIdentifiers; }
            set { this._readReplicaDBClusterIdentifiers = value; }
        }

        // Check to see if ReadReplicaDBClusterIdentifiers property is set
        internal bool IsSetReadReplicaDBClusterIdentifiers()
        {
            return this._readReplicaDBClusterIdentifiers != null && this._readReplicaDBClusterIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaDBInstanceIdentifiers. 
        /// <para>
        /// List of identifiers of the read replicas associated with this DB instance.
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
            return this._readReplicaDBInstanceIdentifiers != null && this._readReplicaDBInstanceIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBInstanceIdentifier. 
        /// <para>
        /// If this DB instance is a read replica, contains the identifier of the source DB instance.
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
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// For a DB instance with multi-Availability Zone support, the name of the secondary
        /// Availability Zone.
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
        /// The status of a read replica. If the instance isn't a read replica, this is empty.
        /// </para>
        /// </summary>
        public List<AwsRdsDbStatusInfo> StatusInfos
        {
            get { return this._statusInfos; }
            set { this._statusInfos = value; }
        }

        // Check to see if StatusInfos property is set
        internal bool IsSetStatusInfos()
        {
            return this._statusInfos != null && this._statusInfos.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB instance is encrypted.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type for the DB instance.
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
        /// The time zone of the DB instance.
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
        /// A list of VPC security groups that the DB instance belongs to.
        /// </para>
        /// </summary>
        public List<AwsRdsDbInstanceVpcSecurityGroup> VpcSecurityGroups
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