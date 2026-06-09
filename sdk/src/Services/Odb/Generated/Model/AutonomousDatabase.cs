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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabase
    {
        private double? _actualUsedDataStorageSizeInTBs;
        private double? _allocatedStorageSizeInTBs;
        private List<string> _allowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AutonomousDatabaseApex _apexDetails;
        private string _autonomousDatabaseArn;
        private string _autonomousDatabaseId;
        private AutonomousMaintenanceScheduleType _autonomousMaintenanceScheduleType;
        private int? _autoRefreshFrequencyInSeconds;
        private int? _autoRefreshPointLagInSeconds;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private List<string> _availableUpgradeVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _backupRetentionPeriodInDays;
        private int? _byolComputeCountLimit;
        private string _characterSet;
        private List<int> _cloneTableSpaceList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private float? _computeCount;
        private ComputeModel _computeModel;
        private AutonomousDatabaseConnectionStrings _connectionStringDetails;
        private AutonomousDatabaseConnectionUrls _connectionUrls;
        private int? _cpuCoreCount;
        private DateTime? _createdAt;
        private List<CustomerContact> _customerContacts = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;
        private DatabaseEdition _databaseEdition;
        private DatabaseManagementStatus _databaseManagementStatus;
        private DatabaseType _databaseType;
        private DataSafeStatus _dataSafeStatus;
        private int? _dataStorageSizeInGBs;
        private double? _dataStorageSizeInTBs;
        private string _dbName;
        private List<DatabaseTool> _dbToolsDetails = AWSConfigs.InitializeCollections ? new List<DatabaseTool>() : null;
        private string _dbVersion;
        private DbWorkload _dbWorkload;
        private string _displayName;
        private EncryptionSummary _encryptionSummary;
        private int? _failedDataRecoveryInSeconds;
        private int? _inMemoryAreaInGBs;
        private bool? _isAutoScalingEnabled;
        private bool? _isAutoScalingForStorageEnabled;
        private bool? _isBackupRetentionLocked;
        private bool? _isLocalDataGuardEnabled;
        private bool? _isMtlsConnectionRequired;
        private bool? _isReconnectCloneEnabled;
        private bool? _isRefreshableClone;
        private bool? _isRemoteDataGuardEnabled;
        private LicenseModel _licenseModel;
        private int? _localAdgAutoFailoverMaxDataLossLimit;
        private DisasterRecoveryType _localDisasterRecoveryType;
        private DatabaseStandbySummary _localStandbyDb;
        private LongTermBackupSchedule _longTermBackupSchedule;
        private string _maintenanceTargetComponent;
        private int? _memoryPerOracleComputeUnitInGBs;
        private string _ncharacterSet;
        private NetServicesArchitecture _netServicesArchitecture;
        private DateTime? _nextLongTermBackupTimeStamp;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private string _odbNetworkArn;
        private string _odbNetworkId;
        private OpenMode _openMode;
        private OperationsInsightsStatus _operationsInsightsStatus;
        private List<string> _peerDbIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _percentProgress;
        private PermissionLevel _permissionLevel;
        private string _privateEndpoint;
        private string _privateEndpointIp;
        private string _privateEndpointLabel;
        private List<int> _provisionableCpus = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private RefreshableMode _refreshableMode;
        private RefreshableStatus _refreshableStatus;
        private DisasterRecoveryConfiguration _remoteDisasterRecoveryConfiguration;
        private string _resourcePoolLeaderId;
        private ResourcePoolSummary _resourcePoolSummary;
        private DataGuardRole _role;
        private List<ScheduledOperationDetails> _scheduledOperations = AWSConfigs.InitializeCollections ? new List<ScheduledOperationDetails>() : null;
        private string _serviceConsoleUrl;
        private string _sourceId;
        private string _sqlWebDeveloperUrl;
        private List<string> _standbyAllowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StandbyAllowlistedIpsSource _standbyAllowlistedIpsSource;
        private DatabaseStandbySummary _standbyDb;
        private AutonomousDatabaseResourceStatus _status;
        private string _statusReason;
        private DateTime? _timeDataGuardRoleChanged;
        private DateTime? _timeDeletionOfFreeAutonomousDatabase;
        private DateTime? _timeDisasterRecoveryRoleChanged;
        private DateTime? _timeLocalDataGuardEnabled;
        private DateTime? _timeMaintenanceBegin;
        private DateTime? _timeMaintenanceEnd;
        private DateTime? _timeOfAutoRefreshStart;
        private DateTime? _timeOfLastBackup;
        private DateTime? _timeOfLastFailover;
        private DateTime? _timeOfLastRefresh;
        private DateTime? _timeOfLastRefreshPoint;
        private DateTime? _timeOfLastSwitchover;
        private DateTime? _timeOfNextRefresh;
        private DateTime? _timeReclamationOfFreeAutonomousDatabase;
        private DateTime? _timeUndeleted;
        private DateTime? _timeUntilReconnectCloneEnabled;
        private double? _totalBackupStorageSizeInGBs;
        private int? _usedDataStorageSizeInGBs;
        private double? _usedDataStorageSizeInTBs;

        /// <summary>
        /// Gets and sets the property ActualUsedDataStorageSizeInTBs. 
        /// <para>
        /// The actual amount of data storage currently in use by the Autonomous Database, in
        /// TB.
        /// </para>
        /// </summary>
        public double? ActualUsedDataStorageSizeInTBs
        {
            get { return this._actualUsedDataStorageSizeInTBs; }
            set { this._actualUsedDataStorageSizeInTBs = value; }
        }

        // Check to see if ActualUsedDataStorageSizeInTBs property is set
        internal bool IsSetActualUsedDataStorageSizeInTBs()
        {
            return this._actualUsedDataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocatedStorageSizeInTBs. 
        /// <para>
        /// The amount of storage currently allocated to the Autonomous Database, in TB.
        /// </para>
        /// </summary>
        public double? AllocatedStorageSizeInTBs
        {
            get { return this._allocatedStorageSizeInTBs; }
            set { this._allocatedStorageSizeInTBs = value; }
        }

        // Check to see if AllocatedStorageSizeInTBs property is set
        internal bool IsSetAllocatedStorageSizeInTBs()
        {
            return this._allocatedStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowlistedIps. 
        /// <para>
        /// The list of IP addresses that are allowed to access the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> AllowlistedIps
        {
            get { return this._allowlistedIps; }
            set { this._allowlistedIps = value; }
        }

        // Check to see if AllowlistedIps property is set
        internal bool IsSetAllowlistedIps()
        {
            return this._allowlistedIps != null && (this._allowlistedIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApexDetails. 
        /// <para>
        /// The Oracle Application Express (APEX) details for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseApex ApexDetails
        {
            get { return this._apexDetails; }
            set { this._apexDetails = value; }
        }

        // Check to see if ApexDetails property is set
        internal bool IsSetApexDetails()
        {
            return this._apexDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AutonomousDatabaseArn
        {
            get { return this._autonomousDatabaseArn; }
            set { this._autonomousDatabaseArn = value; }
        }

        // Check to see if AutonomousDatabaseArn property is set
        internal bool IsSetAutonomousDatabaseArn()
        {
            return this._autonomousDatabaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousMaintenanceScheduleType. 
        /// <para>
        /// The maintenance schedule type for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousMaintenanceScheduleType AutonomousMaintenanceScheduleType
        {
            get { return this._autonomousMaintenanceScheduleType; }
            set { this._autonomousMaintenanceScheduleType = value; }
        }

        // Check to see if AutonomousMaintenanceScheduleType property is set
        internal bool IsSetAutonomousMaintenanceScheduleType()
        {
            return this._autonomousMaintenanceScheduleType != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRefreshFrequencyInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the refreshable clone Autonomous Database is automatically
        /// refreshed.
        /// </para>
        /// </summary>
        public int? AutoRefreshFrequencyInSeconds
        {
            get { return this._autoRefreshFrequencyInSeconds; }
            set { this._autoRefreshFrequencyInSeconds = value; }
        }

        // Check to see if AutoRefreshFrequencyInSeconds property is set
        internal bool IsSetAutoRefreshFrequencyInSeconds()
        {
            return this._autoRefreshFrequencyInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoRefreshPointLagInSeconds. 
        /// <para>
        /// The time lag, in seconds, between the refreshable clone and its source Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public int? AutoRefreshPointLagInSeconds
        {
            get { return this._autoRefreshPointLagInSeconds; }
            set { this._autoRefreshPointLagInSeconds = value; }
        }

        // Check to see if AutoRefreshPointLagInSeconds property is set
        internal bool IsSetAutoRefreshPointLagInSeconds()
        {
            return this._autoRefreshPointLagInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the Autonomous Database is located.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The unique identifier of the Availability Zone where the Autonomous Database is located.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableUpgradeVersions. 
        /// <para>
        /// The list of Oracle Database software versions to which the Autonomous Database can
        /// be upgraded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> AvailableUpgradeVersions
        {
            get { return this._availableUpgradeVersions; }
            set { this._availableUpgradeVersions = value; }
        }

        // Check to see if AvailableUpgradeVersions property is set
        internal bool IsSetAvailableUpgradeVersions()
        {
            return this._availableUpgradeVersions != null && (this._availableUpgradeVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for automatic backups of the Autonomous Database.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriodInDays
        {
            get { return this._backupRetentionPeriodInDays; }
            set { this._backupRetentionPeriodInDays = value; }
        }

        // Check to see if BackupRetentionPeriodInDays property is set
        internal bool IsSetBackupRetentionPeriodInDays()
        {
            return this._backupRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByolComputeCountLimit. 
        /// <para>
        /// The maximum number of compute resources that you can allocate to the Autonomous Database
        /// under the bring-your-own-license (BYOL) model.
        /// </para>
        /// </summary>
        public int? ByolComputeCountLimit
        {
            get { return this._byolComputeCountLimit; }
            set { this._byolComputeCountLimit = value; }
        }

        // Check to see if ByolComputeCountLimit property is set
        internal bool IsSetByolComputeCountLimit()
        {
            return this._byolComputeCountLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CharacterSet. 
        /// <para>
        /// The character set of the Autonomous Database.
        /// </para>
        /// </summary>
        public string CharacterSet
        {
            get { return this._characterSet; }
            set { this._characterSet = value; }
        }

        // Check to see if CharacterSet property is set
        internal bool IsSetCharacterSet()
        {
            return this._characterSet != null;
        }

        /// <summary>
        /// Gets and sets the property CloneTableSpaceList. 
        /// <para>
        /// The list of tablespace identifiers to clone for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> CloneTableSpaceList
        {
            get { return this._cloneTableSpaceList; }
            set { this._cloneTableSpaceList = value; }
        }

        // Check to see if CloneTableSpaceList property is set
        internal bool IsSetCloneTableSpaceList()
        {
            return this._cloneTableSpaceList != null && (this._cloneTableSpaceList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of Elastic CPUs (ECPUs) or Oracle CPUs (OCPUs), assigned
        /// to the Autonomous Database.
        /// </para>
        /// </summary>
        public float? ComputeCount
        {
            get { return this._computeCount; }
            set { this._computeCount = value; }
        }

        // Check to see if ComputeCount property is set
        internal bool IsSetComputeCount()
        {
            return this._computeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputeModel. 
        /// <para>
        /// The compute model of the Autonomous Database, either ECPU or OCPU.
        /// </para>
        /// </summary>
        public ComputeModel ComputeModel
        {
            get { return this._computeModel; }
            set { this._computeModel = value; }
        }

        // Check to see if ComputeModel property is set
        internal bool IsSetComputeModel()
        {
            return this._computeModel != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStringDetails. 
        /// <para>
        /// The connection string details for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseConnectionStrings ConnectionStringDetails
        {
            get { return this._connectionStringDetails; }
            set { this._connectionStringDetails = value; }
        }

        // Check to see if ConnectionStringDetails property is set
        internal bool IsSetConnectionStringDetails()
        {
            return this._connectionStringDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionUrls. 
        /// <para>
        /// The connection URLs for accessing tools and services for the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseConnectionUrls ConnectionUrls
        {
            get { return this._connectionUrls; }
            set { this._connectionUrls = value; }
        }

        // Check to see if ConnectionUrls property is set
        internal bool IsSetConnectionUrls()
        {
            return this._connectionUrls != null;
        }

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores allocated to the Autonomous Database.
        /// </para>
        /// </summary>
        public int? CpuCoreCount
        {
            get { return this._cpuCoreCount; }
            set { this._cpuCoreCount = value; }
        }

        // Check to see if CpuCoreCount property is set
        internal bool IsSetCpuCoreCount()
        {
            return this._cpuCoreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Autonomous Database was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerContacts. 
        /// <para>
        /// The list of customer contacts that receive operational notifications from Oracle for
        /// the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContacts
        {
            get { return this._customerContacts; }
            set { this._customerContacts = value; }
        }

        // Check to see if CustomerContacts property is set
        internal bool IsSetCustomerContacts()
        {
            return this._customerContacts != null && (this._customerContacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The Oracle Database edition of the Autonomous Database.
        /// </para>
        /// </summary>
        public DatabaseEdition DatabaseEdition
        {
            get { return this._databaseEdition; }
            set { this._databaseEdition = value; }
        }

        // Check to see if DatabaseEdition property is set
        internal bool IsSetDatabaseEdition()
        {
            return this._databaseEdition != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseManagementStatus. 
        /// <para>
        /// The status of Oracle Database Management for the Autonomous Database.
        /// </para>
        /// </summary>
        public DatabaseManagementStatus DatabaseManagementStatus
        {
            get { return this._databaseManagementStatus; }
            set { this._databaseManagementStatus = value; }
        }

        // Check to see if DatabaseManagementStatus property is set
        internal bool IsSetDatabaseManagementStatus()
        {
            return this._databaseManagementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseType. 
        /// <para>
        /// The type of the Autonomous Database, either a regular database or a clone.
        /// </para>
        /// </summary>
        public DatabaseType DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }

        // Check to see if DatabaseType property is set
        internal bool IsSetDatabaseType()
        {
            return this._databaseType != null;
        }

        /// <summary>
        /// Gets and sets the property DataSafeStatus. 
        /// <para>
        /// The status of the Oracle Data Safe registration for the Autonomous Database.
        /// </para>
        /// </summary>
        public DataSafeStatus DataSafeStatus
        {
            get { return this._dataSafeStatus; }
            set { this._dataSafeStatus = value; }
        }

        // Check to see if DataSafeStatus property is set
        internal bool IsSetDataSafeStatus()
        {
            return this._dataSafeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The size, in gigabytes (GB), of the data volume allocated for the Autonomous Database.
        /// </para>
        /// </summary>
        public int? DataStorageSizeInGBs
        {
            get { return this._dataStorageSizeInGBs; }
            set { this._dataStorageSizeInGBs = value; }
        }

        // Check to see if DataStorageSizeInGBs property is set
        internal bool IsSetDataStorageSizeInGBs()
        {
            return this._dataStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size, in terabytes (TB), of the data volume allocated for the Autonomous Database.
        /// </para>
        /// </summary>
        public double? DataStorageSizeInTBs
        {
            get { return this._dataStorageSizeInTBs; }
            set { this._dataStorageSizeInTBs = value; }
        }

        // Check to see if DataStorageSizeInTBs property is set
        internal bool IsSetDataStorageSizeInTBs()
        {
            return this._dataStorageSizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DbName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DbName property is set
        internal bool IsSetDbName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DbToolsDetails. 
        /// <para>
        /// The list of database management tools enabled for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatabaseTool> DbToolsDetails
        {
            get { return this._dbToolsDetails; }
            set { this._dbToolsDetails = value; }
        }

        // Check to see if DbToolsDetails property is set
        internal bool IsSetDbToolsDetails()
        {
            return this._dbToolsDetails != null && (this._dbToolsDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DbVersion. 
        /// <para>
        /// The Oracle Database software version of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DbVersion
        {
            get { return this._dbVersion; }
            set { this._dbVersion = value; }
        }

        // Check to see if DbVersion property is set
        internal bool IsSetDbVersion()
        {
            return this._dbVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DbWorkload. 
        /// <para>
        /// The intended use of the Autonomous Database, such as transaction processing, data
        /// warehouse, JSON database, or APEX.
        /// </para>
        /// </summary>
        public DbWorkload DbWorkload
        {
            get { return this._dbWorkload; }
            set { this._dbWorkload = value; }
        }

        // Check to see if DbWorkload property is set
        internal bool IsSetDbWorkload()
        {
            return this._dbWorkload != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the Autonomous Database.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionSummary. 
        /// <para>
        /// The encryption configuration for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionSummary EncryptionSummary
        {
            get { return this._encryptionSummary; }
            set { this._encryptionSummary = value; }
        }

        // Check to see if EncryptionSummary property is set
        internal bool IsSetEncryptionSummary()
        {
            return this._encryptionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property FailedDataRecoveryInSeconds. 
        /// <para>
        /// The amount of time, in seconds, that the data in the Autonomous Database is behind
        /// the data in the primary database.
        /// </para>
        /// </summary>
        public int? FailedDataRecoveryInSeconds
        {
            get { return this._failedDataRecoveryInSeconds; }
            set { this._failedDataRecoveryInSeconds = value; }
        }

        // Check to see if FailedDataRecoveryInSeconds property is set
        internal bool IsSetFailedDataRecoveryInSeconds()
        {
            return this._failedDataRecoveryInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InMemoryAreaInGBs. 
        /// <para>
        /// The size of the in-memory area of the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public int? InMemoryAreaInGBs
        {
            get { return this._inMemoryAreaInGBs; }
            set { this._inMemoryAreaInGBs = value; }
        }

        // Check to see if InMemoryAreaInGBs property is set
        internal bool IsSetInMemoryAreaInGBs()
        {
            return this._inMemoryAreaInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAutoScalingEnabled. 
        /// <para>
        /// Indicates whether automatic scaling of the compute resources is enabled for the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public bool? IsAutoScalingEnabled
        {
            get { return this._isAutoScalingEnabled; }
            set { this._isAutoScalingEnabled = value; }
        }

        // Check to see if IsAutoScalingEnabled property is set
        internal bool IsSetIsAutoScalingEnabled()
        {
            return this._isAutoScalingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAutoScalingForStorageEnabled. 
        /// <para>
        /// Indicates whether automatic scaling of the storage is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsAutoScalingForStorageEnabled
        {
            get { return this._isAutoScalingForStorageEnabled; }
            set { this._isAutoScalingForStorageEnabled = value; }
        }

        // Check to see if IsAutoScalingForStorageEnabled property is set
        internal bool IsSetIsAutoScalingForStorageEnabled()
        {
            return this._isAutoScalingForStorageEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsBackupRetentionLocked. 
        /// <para>
        /// Indicates whether the backup retention period of the Autonomous Database is locked.
        /// </para>
        /// </summary>
        public bool? IsBackupRetentionLocked
        {
            get { return this._isBackupRetentionLocked; }
            set { this._isBackupRetentionLocked = value; }
        }

        // Check to see if IsBackupRetentionLocked property is set
        internal bool IsSetIsBackupRetentionLocked()
        {
            return this._isBackupRetentionLocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsLocalDataGuardEnabled. 
        /// <para>
        /// Indicates whether local Oracle Data Guard is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsLocalDataGuardEnabled
        {
            get { return this._isLocalDataGuardEnabled; }
            set { this._isLocalDataGuardEnabled = value; }
        }

        // Check to see if IsLocalDataGuardEnabled property is set
        internal bool IsSetIsLocalDataGuardEnabled()
        {
            return this._isLocalDataGuardEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsMtlsConnectionRequired. 
        /// <para>
        /// Indicates whether mutual TLS (mTLS) authentication is required to connect to the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public bool? IsMtlsConnectionRequired
        {
            get { return this._isMtlsConnectionRequired; }
            set { this._isMtlsConnectionRequired = value; }
        }

        // Check to see if IsMtlsConnectionRequired property is set
        internal bool IsSetIsMtlsConnectionRequired()
        {
            return this._isMtlsConnectionRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsReconnectCloneEnabled. 
        /// <para>
        /// Indicates whether reconnecting the refreshable clone to its source Autonomous Database
        /// is enabled.
        /// </para>
        /// </summary>
        public bool? IsReconnectCloneEnabled
        {
            get { return this._isReconnectCloneEnabled; }
            set { this._isReconnectCloneEnabled = value; }
        }

        // Check to see if IsReconnectCloneEnabled property is set
        internal bool IsSetIsReconnectCloneEnabled()
        {
            return this._isReconnectCloneEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRefreshableClone. 
        /// <para>
        /// Indicates whether the Autonomous Database is a refreshable clone.
        /// </para>
        /// </summary>
        public bool? IsRefreshableClone
        {
            get { return this._isRefreshableClone; }
            set { this._isRefreshableClone = value; }
        }

        // Check to see if IsRefreshableClone property is set
        internal bool IsSetIsRefreshableClone()
        {
            return this._isRefreshableClone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRemoteDataGuardEnabled. 
        /// <para>
        /// Indicates whether remote Oracle Data Guard is enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public bool? IsRemoteDataGuardEnabled
        {
            get { return this._isRemoteDataGuardEnabled; }
            set { this._isRemoteDataGuardEnabled = value; }
        }

        // Check to see if IsRemoteDataGuardEnabled property is set
        internal bool IsSetIsRemoteDataGuardEnabled()
        {
            return this._isRemoteDataGuardEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model that applies to the Autonomous Database.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel
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
        /// Gets and sets the property LocalAdgAutoFailoverMaxDataLossLimit. 
        /// <para>
        /// The maximum data loss limit, in seconds, for automatic failover to the local Oracle
        /// Data Guard standby database.
        /// </para>
        /// </summary>
        public int? LocalAdgAutoFailoverMaxDataLossLimit
        {
            get { return this._localAdgAutoFailoverMaxDataLossLimit; }
            set { this._localAdgAutoFailoverMaxDataLossLimit = value; }
        }

        // Check to see if LocalAdgAutoFailoverMaxDataLossLimit property is set
        internal bool IsSetLocalAdgAutoFailoverMaxDataLossLimit()
        {
            return this._localAdgAutoFailoverMaxDataLossLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalDisasterRecoveryType. 
        /// <para>
        /// The type of local disaster recovery configured for the Autonomous Database.
        /// </para>
        /// </summary>
        public DisasterRecoveryType LocalDisasterRecoveryType
        {
            get { return this._localDisasterRecoveryType; }
            set { this._localDisasterRecoveryType = value; }
        }

        // Check to see if LocalDisasterRecoveryType property is set
        internal bool IsSetLocalDisasterRecoveryType()
        {
            return this._localDisasterRecoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property LocalStandbyDb. 
        /// <para>
        /// The details of the local standby Autonomous Database in an Oracle Data Guard configuration.
        /// </para>
        /// </summary>
        public DatabaseStandbySummary LocalStandbyDb
        {
            get { return this._localStandbyDb; }
            set { this._localStandbyDb = value; }
        }

        // Check to see if LocalStandbyDb property is set
        internal bool IsSetLocalStandbyDb()
        {
            return this._localStandbyDb != null;
        }

        /// <summary>
        /// Gets and sets the property LongTermBackupSchedule. 
        /// <para>
        /// The long-term backup schedule for the Autonomous Database.
        /// </para>
        /// </summary>
        public LongTermBackupSchedule LongTermBackupSchedule
        {
            get { return this._longTermBackupSchedule; }
            set { this._longTermBackupSchedule = value; }
        }

        // Check to see if LongTermBackupSchedule property is set
        internal bool IsSetLongTermBackupSchedule()
        {
            return this._longTermBackupSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTargetComponent. 
        /// <para>
        /// The component on the Autonomous Database that the current maintenance is being applied
        /// to.
        /// </para>
        /// </summary>
        public string MaintenanceTargetComponent
        {
            get { return this._maintenanceTargetComponent; }
            set { this._maintenanceTargetComponent = value; }
        }

        // Check to see if MaintenanceTargetComponent property is set
        internal bool IsSetMaintenanceTargetComponent()
        {
            return this._maintenanceTargetComponent != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryPerOracleComputeUnitInGBs. 
        /// <para>
        /// The amount of memory allocated per Oracle Compute Unit, in GB.
        /// </para>
        /// </summary>
        public int? MemoryPerOracleComputeUnitInGBs
        {
            get { return this._memoryPerOracleComputeUnitInGBs; }
            set { this._memoryPerOracleComputeUnitInGBs = value; }
        }

        // Check to see if MemoryPerOracleComputeUnitInGBs property is set
        internal bool IsSetMemoryPerOracleComputeUnitInGBs()
        {
            return this._memoryPerOracleComputeUnitInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NcharacterSet. 
        /// <para>
        /// The national character set of the Autonomous Database.
        /// </para>
        /// </summary>
        public string NcharacterSet
        {
            get { return this._ncharacterSet; }
            set { this._ncharacterSet = value; }
        }

        // Check to see if NcharacterSet property is set
        internal bool IsSetNcharacterSet()
        {
            return this._ncharacterSet != null;
        }

        /// <summary>
        /// Gets and sets the property NetServicesArchitecture. 
        /// <para>
        /// The Oracle Net Services architecture of the Autonomous Database, either dedicated
        /// or shared.
        /// </para>
        /// </summary>
        public NetServicesArchitecture NetServicesArchitecture
        {
            get { return this._netServicesArchitecture; }
            set { this._netServicesArchitecture = value; }
        }

        // Check to see if NetServicesArchitecture property is set
        internal bool IsSetNetServicesArchitecture()
        {
            return this._netServicesArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property NextLongTermBackupTimeStamp. 
        /// <para>
        /// The date and time of the next scheduled long-term backup of the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? NextLongTermBackupTimeStamp
        {
            get { return this._nextLongTermBackupTimeStamp; }
            set { this._nextLongTermBackupTimeStamp = value; }
        }

        // Check to see if NextLongTermBackupTimeStamp property is set
        internal bool IsSetNextLongTermBackupTimeStamp()
        {
            return this._nextLongTermBackupTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous Database.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the Oracle Cloud Infrastructure (OCI) resource anchor associated with
        /// the Autonomous Database.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The URL for accessing the OCI console page for the Autonomous Database.
        /// </para>
        /// </summary>
        public string OciUrl
        {
            get { return this._ociUrl; }
            set { this._ociUrl = value; }
        }

        // Check to see if OciUrl property is set
        internal bool IsSetOciUrl()
        {
            return this._ociUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network associated with the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string OdbNetworkArn
        {
            get { return this._odbNetworkArn; }
            set { this._odbNetworkArn = value; }
        }

        // Check to see if OdbNetworkArn property is set
        internal bool IsSetOdbNetworkArn()
        {
            return this._odbNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network associated with the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string OdbNetworkId
        {
            get { return this._odbNetworkId; }
            set { this._odbNetworkId = value; }
        }

        // Check to see if OdbNetworkId property is set
        internal bool IsSetOdbNetworkId()
        {
            return this._odbNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property OpenMode. 
        /// <para>
        /// The mode in which the Autonomous Database is open, either read-only or read/write.
        /// </para>
        /// </summary>
        public OpenMode OpenMode
        {
            get { return this._openMode; }
            set { this._openMode = value; }
        }

        // Check to see if OpenMode property is set
        internal bool IsSetOpenMode()
        {
            return this._openMode != null;
        }

        /// <summary>
        /// Gets and sets the property OperationsInsightsStatus. 
        /// <para>
        /// The status of Oracle Operations Insights for the Autonomous Database.
        /// </para>
        /// </summary>
        public OperationsInsightsStatus OperationsInsightsStatus
        {
            get { return this._operationsInsightsStatus; }
            set { this._operationsInsightsStatus = value; }
        }

        // Check to see if OperationsInsightsStatus property is set
        internal bool IsSetOperationsInsightsStatus()
        {
            return this._operationsInsightsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PeerDbIds. 
        /// <para>
        /// The list of unique identifiers of the peer Autonomous Databases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> PeerDbIds
        {
            get { return this._peerDbIds; }
            set { this._peerDbIds = value; }
        }

        // Check to see if PeerDbIds property is set
        internal bool IsSetPeerDbIds()
        {
            return this._peerDbIds != null && (this._peerDbIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the current operation on the Autonomous Database, as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermissionLevel. 
        /// <para>
        /// The permission level of the Autonomous Database.
        /// </para>
        /// </summary>
        public PermissionLevel PermissionLevel
        {
            get { return this._permissionLevel; }
            set { this._permissionLevel = value; }
        }

        // Check to see if PermissionLevel property is set
        internal bool IsSetPermissionLevel()
        {
            return this._permissionLevel != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpoint
        {
            get { return this._privateEndpoint; }
            set { this._privateEndpoint = value; }
        }

        // Check to see if PrivateEndpoint property is set
        internal bool IsSetPrivateEndpoint()
        {
            return this._privateEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpointIp. 
        /// <para>
        /// The private endpoint IP address for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpointIp
        {
            get { return this._privateEndpointIp; }
            set { this._privateEndpointIp = value; }
        }

        // Check to see if PrivateEndpointIp property is set
        internal bool IsSetPrivateEndpointIp()
        {
            return this._privateEndpointIp != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpointLabel. 
        /// <para>
        /// The private endpoint label for the Autonomous Database.
        /// </para>
        /// </summary>
        public string PrivateEndpointLabel
        {
            get { return this._privateEndpointLabel; }
            set { this._privateEndpointLabel = value; }
        }

        // Check to see if PrivateEndpointLabel property is set
        internal bool IsSetPrivateEndpointLabel()
        {
            return this._privateEndpointLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionableCpus. 
        /// <para>
        /// The list of CPU core counts that you can provision for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ProvisionableCpus
        {
            get { return this._provisionableCpus; }
            set { this._provisionableCpus = value; }
        }

        // Check to see if ProvisionableCpus property is set
        internal bool IsSetProvisionableCpus()
        {
            return this._provisionableCpus != null && (this._provisionableCpus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RefreshableMode. 
        /// <para>
        /// The refresh mode of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public RefreshableMode RefreshableMode
        {
            get { return this._refreshableMode; }
            set { this._refreshableMode = value; }
        }

        // Check to see if RefreshableMode property is set
        internal bool IsSetRefreshableMode()
        {
            return this._refreshableMode != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshableStatus. 
        /// <para>
        /// The refresh status of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public RefreshableStatus RefreshableStatus
        {
            get { return this._refreshableStatus; }
            set { this._refreshableStatus = value; }
        }

        // Check to see if RefreshableStatus property is set
        internal bool IsSetRefreshableStatus()
        {
            return this._refreshableStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDisasterRecoveryConfiguration. 
        /// <para>
        /// The configuration of the remote disaster recovery for the Autonomous Database.
        /// </para>
        /// </summary>
        public DisasterRecoveryConfiguration RemoteDisasterRecoveryConfiguration
        {
            get { return this._remoteDisasterRecoveryConfiguration; }
            set { this._remoteDisasterRecoveryConfiguration = value; }
        }

        // Check to see if RemoteDisasterRecoveryConfiguration property is set
        internal bool IsSetRemoteDisasterRecoveryConfiguration()
        {
            return this._remoteDisasterRecoveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePoolLeaderId. 
        /// <para>
        /// The unique identifier of the resource pool leader Autonomous Database.
        /// </para>
        /// </summary>
        public string ResourcePoolLeaderId
        {
            get { return this._resourcePoolLeaderId; }
            set { this._resourcePoolLeaderId = value; }
        }

        // Check to see if ResourcePoolLeaderId property is set
        internal bool IsSetResourcePoolLeaderId()
        {
            return this._resourcePoolLeaderId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePoolSummary. 
        /// <para>
        /// The configuration of the resource pool for the Autonomous Database.
        /// </para>
        /// </summary>
        public ResourcePoolSummary ResourcePoolSummary
        {
            get { return this._resourcePoolSummary; }
            set { this._resourcePoolSummary = value; }
        }

        // Check to see if ResourcePoolSummary property is set
        internal bool IsSetResourcePoolSummary()
        {
            return this._resourcePoolSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Oracle Data Guard role of the Autonomous Database.
        /// </para>
        /// </summary>
        public DataGuardRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledOperations. 
        /// <para>
        /// The list of scheduled start and stop times for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledOperationDetails> ScheduledOperations
        {
            get { return this._scheduledOperations; }
            set { this._scheduledOperations = value; }
        }

        // Check to see if ScheduledOperations property is set
        internal bool IsSetScheduledOperations()
        {
            return this._scheduledOperations != null && (this._scheduledOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceConsoleUrl. 
        /// <para>
        /// The URL for accessing the Oracle service console for the Autonomous Database.
        /// </para>
        /// </summary>
        public string ServiceConsoleUrl
        {
            get { return this._serviceConsoleUrl; }
            set { this._serviceConsoleUrl = value; }
        }

        // Check to see if ServiceConsoleUrl property is set
        internal bool IsSetServiceConsoleUrl()
        {
            return this._serviceConsoleUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique identifier of the source from which the Autonomous Database was created.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SqlWebDeveloperUrl. 
        /// <para>
        /// The URL for accessing Oracle SQL Developer Web for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SqlWebDeveloperUrl
        {
            get { return this._sqlWebDeveloperUrl; }
            set { this._sqlWebDeveloperUrl = value; }
        }

        // Check to see if SqlWebDeveloperUrl property is set
        internal bool IsSetSqlWebDeveloperUrl()
        {
            return this._sqlWebDeveloperUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StandbyAllowlistedIps. 
        /// <para>
        /// The list of IP addresses that are allowed to access the standby Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> StandbyAllowlistedIps
        {
            get { return this._standbyAllowlistedIps; }
            set { this._standbyAllowlistedIps = value; }
        }

        // Check to see if StandbyAllowlistedIps property is set
        internal bool IsSetStandbyAllowlistedIps()
        {
            return this._standbyAllowlistedIps != null && (this._standbyAllowlistedIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StandbyAllowlistedIpsSource. 
        /// <para>
        /// The source of the allowlisted IP addresses for the standby Autonomous Database.
        /// </para>
        /// </summary>
        public StandbyAllowlistedIpsSource StandbyAllowlistedIpsSource
        {
            get { return this._standbyAllowlistedIpsSource; }
            set { this._standbyAllowlistedIpsSource = value; }
        }

        // Check to see if StandbyAllowlistedIpsSource property is set
        internal bool IsSetStandbyAllowlistedIpsSource()
        {
            return this._standbyAllowlistedIpsSource != null;
        }

        /// <summary>
        /// Gets and sets the property StandbyDb. 
        /// <para>
        /// The details of the standby Autonomous Database in a cross-Region Oracle Data Guard
        /// configuration.
        /// </para>
        /// </summary>
        public DatabaseStandbySummary StandbyDb
        {
            get { return this._standbyDb; }
            set { this._standbyDb = value; }
        }

        // Check to see if StandbyDb property is set
        internal bool IsSetStandbyDb()
        {
            return this._standbyDb != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseResourceStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous Database, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TimeDataGuardRoleChanged. 
        /// <para>
        /// The date and time when the Oracle Data Guard role of the Autonomous Database last
        /// changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDataGuardRoleChanged
        {
            get { return this._timeDataGuardRoleChanged; }
            set { this._timeDataGuardRoleChanged = value; }
        }

        // Check to see if TimeDataGuardRoleChanged property is set
        internal bool IsSetTimeDataGuardRoleChanged()
        {
            return this._timeDataGuardRoleChanged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDeletionOfFreeAutonomousDatabase. 
        /// <para>
        /// The date and time when the inactive Always Free Autonomous Database is scheduled to
        /// be automatically deleted.
        /// </para>
        /// </summary>
        public DateTime? TimeDeletionOfFreeAutonomousDatabase
        {
            get { return this._timeDeletionOfFreeAutonomousDatabase; }
            set { this._timeDeletionOfFreeAutonomousDatabase = value; }
        }

        // Check to see if TimeDeletionOfFreeAutonomousDatabase property is set
        internal bool IsSetTimeDeletionOfFreeAutonomousDatabase()
        {
            return this._timeDeletionOfFreeAutonomousDatabase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDisasterRecoveryRoleChanged. 
        /// <para>
        /// The date and time when the disaster recovery role of the Autonomous Database last
        /// changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDisasterRecoveryRoleChanged
        {
            get { return this._timeDisasterRecoveryRoleChanged; }
            set { this._timeDisasterRecoveryRoleChanged = value; }
        }

        // Check to see if TimeDisasterRecoveryRoleChanged property is set
        internal bool IsSetTimeDisasterRecoveryRoleChanged()
        {
            return this._timeDisasterRecoveryRoleChanged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeLocalDataGuardEnabled. 
        /// <para>
        /// The date and time when local Oracle Data Guard was enabled for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeLocalDataGuardEnabled
        {
            get { return this._timeLocalDataGuardEnabled; }
            set { this._timeLocalDataGuardEnabled = value; }
        }

        // Check to see if TimeLocalDataGuardEnabled property is set
        internal bool IsSetTimeLocalDataGuardEnabled()
        {
            return this._timeLocalDataGuardEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceBegin. 
        /// <para>
        /// The date and time when the next maintenance of the Autonomous Database begins.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceBegin
        {
            get { return this._timeMaintenanceBegin; }
            set { this._timeMaintenanceBegin = value; }
        }

        // Check to see if TimeMaintenanceBegin property is set
        internal bool IsSetTimeMaintenanceBegin()
        {
            return this._timeMaintenanceBegin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceEnd. 
        /// <para>
        /// The date and time when the next maintenance of the Autonomous Database ends.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceEnd
        {
            get { return this._timeMaintenanceEnd; }
            set { this._timeMaintenanceEnd = value; }
        }

        // Check to see if TimeMaintenanceEnd property is set
        internal bool IsSetTimeMaintenanceEnd()
        {
            return this._timeMaintenanceEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfAutoRefreshStart. 
        /// <para>
        /// The date and time at which the automatic refresh of the refreshable clone Autonomous
        /// Database starts.
        /// </para>
        /// </summary>
        public DateTime? TimeOfAutoRefreshStart
        {
            get { return this._timeOfAutoRefreshStart; }
            set { this._timeOfAutoRefreshStart = value; }
        }

        // Check to see if TimeOfAutoRefreshStart property is set
        internal bool IsSetTimeOfAutoRefreshStart()
        {
            return this._timeOfAutoRefreshStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfLastBackup. 
        /// <para>
        /// The date and time of the last backup of the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastBackup
        {
            get { return this._timeOfLastBackup; }
            set { this._timeOfLastBackup = value; }
        }

        // Check to see if TimeOfLastBackup property is set
        internal bool IsSetTimeOfLastBackup()
        {
            return this._timeOfLastBackup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfLastFailover. 
        /// <para>
        /// The date and time of the last failover operation for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastFailover
        {
            get { return this._timeOfLastFailover; }
            set { this._timeOfLastFailover = value; }
        }

        // Check to see if TimeOfLastFailover property is set
        internal bool IsSetTimeOfLastFailover()
        {
            return this._timeOfLastFailover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfLastRefresh. 
        /// <para>
        /// The date and time of the last refresh of the refreshable clone Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastRefresh
        {
            get { return this._timeOfLastRefresh; }
            set { this._timeOfLastRefresh = value; }
        }

        // Check to see if TimeOfLastRefresh property is set
        internal bool IsSetTimeOfLastRefresh()
        {
            return this._timeOfLastRefresh.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfLastRefreshPoint. 
        /// <para>
        /// The date and time as of which the data in the refreshable clone Autonomous Database
        /// is current.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastRefreshPoint
        {
            get { return this._timeOfLastRefreshPoint; }
            set { this._timeOfLastRefreshPoint = value; }
        }

        // Check to see if TimeOfLastRefreshPoint property is set
        internal bool IsSetTimeOfLastRefreshPoint()
        {
            return this._timeOfLastRefreshPoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfLastSwitchover. 
        /// <para>
        /// The date and time of the last switchover operation for the Autonomous Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfLastSwitchover
        {
            get { return this._timeOfLastSwitchover; }
            set { this._timeOfLastSwitchover = value; }
        }

        // Check to see if TimeOfLastSwitchover property is set
        internal bool IsSetTimeOfLastSwitchover()
        {
            return this._timeOfLastSwitchover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfNextRefresh. 
        /// <para>
        /// The date and time of the next scheduled refresh of the refreshable clone Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public DateTime? TimeOfNextRefresh
        {
            get { return this._timeOfNextRefresh; }
            set { this._timeOfNextRefresh = value; }
        }

        // Check to see if TimeOfNextRefresh property is set
        internal bool IsSetTimeOfNextRefresh()
        {
            return this._timeOfNextRefresh.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeReclamationOfFreeAutonomousDatabase. 
        /// <para>
        /// The date and time when the Always Free Autonomous Database is scheduled to be stopped
        /// because of inactivity.
        /// </para>
        /// </summary>
        public DateTime? TimeReclamationOfFreeAutonomousDatabase
        {
            get { return this._timeReclamationOfFreeAutonomousDatabase; }
            set { this._timeReclamationOfFreeAutonomousDatabase = value; }
        }

        // Check to see if TimeReclamationOfFreeAutonomousDatabase property is set
        internal bool IsSetTimeReclamationOfFreeAutonomousDatabase()
        {
            return this._timeReclamationOfFreeAutonomousDatabase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeUndeleted. 
        /// <para>
        /// The date and time when the Autonomous Database was restored after deletion.
        /// </para>
        /// </summary>
        public DateTime? TimeUndeleted
        {
            get { return this._timeUndeleted; }
            set { this._timeUndeleted = value; }
        }

        // Check to see if TimeUndeleted property is set
        internal bool IsSetTimeUndeleted()
        {
            return this._timeUndeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeUntilReconnectCloneEnabled. 
        /// <para>
        /// The date and time until which reconnecting the refreshable clone to its source Autonomous
        /// Database is allowed.
        /// </para>
        /// </summary>
        public DateTime? TimeUntilReconnectCloneEnabled
        {
            get { return this._timeUntilReconnectCloneEnabled; }
            set { this._timeUntilReconnectCloneEnabled = value; }
        }

        // Check to see if TimeUntilReconnectCloneEnabled property is set
        internal bool IsSetTimeUntilReconnectCloneEnabled()
        {
            return this._timeUntilReconnectCloneEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBackupStorageSizeInGBs. 
        /// <para>
        /// The total amount of backup storage used by the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public double? TotalBackupStorageSizeInGBs
        {
            get { return this._totalBackupStorageSizeInGBs; }
            set { this._totalBackupStorageSizeInGBs = value; }
        }

        // Check to see if TotalBackupStorageSizeInGBs property is set
        internal bool IsSetTotalBackupStorageSizeInGBs()
        {
            return this._totalBackupStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsedDataStorageSizeInGBs. 
        /// <para>
        /// The amount of data storage currently in use by the Autonomous Database, in GB.
        /// </para>
        /// </summary>
        public int? UsedDataStorageSizeInGBs
        {
            get { return this._usedDataStorageSizeInGBs; }
            set { this._usedDataStorageSizeInGBs = value; }
        }

        // Check to see if UsedDataStorageSizeInGBs property is set
        internal bool IsSetUsedDataStorageSizeInGBs()
        {
            return this._usedDataStorageSizeInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsedDataStorageSizeInTBs. 
        /// <para>
        /// The amount of data storage currently in use by the Autonomous Database, in TB.
        /// </para>
        /// </summary>
        public double? UsedDataStorageSizeInTBs
        {
            get { return this._usedDataStorageSizeInTBs; }
            set { this._usedDataStorageSizeInTBs = value; }
        }

        // Check to see if UsedDataStorageSizeInTBs property is set
        internal bool IsSetUsedDataStorageSizeInTBs()
        {
            return this._usedDataStorageSizeInTBs.HasValue; 
        }

    }
}