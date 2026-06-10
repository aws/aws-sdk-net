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
    /// Container for the parameters to the UpdateAutonomousDatabase operation.
    /// Updates the properties of an Autonomous Database.
    /// </summary>
    public partial class UpdateAutonomousDatabaseRequest : AmazonOdbRequest
    {
        private string _adminPassword;
        private List<string> _allowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _autonomousDatabaseId;
        private AutonomousMaintenanceScheduleType _autonomousMaintenanceScheduleType;
        private int? _autoRefreshFrequencyInSeconds;
        private int? _autoRefreshPointLagInSeconds;
        private int? _backupRetentionPeriodInDays;
        private double? _byolComputeCountLimit;
        private double? _computeCount;
        private int? _cpuCoreCount;
        private List<CustomerContact> _customerContactsToSendToOCI = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;
        private DatabaseEdition _databaseEdition;
        private int? _dataStorageSizeInGBs;
        private int? _dataStorageSizeInTBs;
        private string _dbName;
        private List<DatabaseTool> _dbToolsDetails = AWSConfigs.InitializeCollections ? new List<DatabaseTool>() : null;
        private string _dbVersion;
        private DbWorkload _dbWorkload;
        private string _displayName;
        private EncryptionKeyConfigurationInput _encryptionKeyConfiguration;
        private EncryptionKeyProviderInput _encryptionKeyProvider;
        private bool? _isAutoScalingEnabled;
        private bool? _isAutoScalingForStorageEnabled;
        private bool? _isBackupRetentionLocked;
        private bool? _isDisconnectPeer;
        private bool? _isLocalDataGuardEnabled;
        private bool? _isMtlsConnectionRequired;
        private bool? _isRefreshableClone;
        private LicenseModel _licenseModel;
        private int? _localAdgAutoFailoverMaxDataLossLimit;
        private LongTermBackupSchedule _longTermBackupSchedule;
        private OpenMode _openMode;
        private string _peerDbId;
        private PermissionLevel _permissionLevel;
        private string _privateEndpointIp;
        private string _privateEndpointLabel;
        private RefreshableMode _refreshableMode;
        private string _resourcePoolLeaderId;
        private ResourcePoolSummary _resourcePoolSummary;
        private List<ScheduledOperationDetails> _scheduledOperations = AWSConfigs.InitializeCollections ? new List<ScheduledOperationDetails>() : null;
        private List<string> _standbyAllowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StandbyAllowlistedIpsSource _standbyAllowlistedIpsSource;
        private DateTime? _timeOfAutoRefreshStart;

        /// <summary>
        /// Gets and sets the property AdminPassword. 
        /// <para>
        /// The new password for the <c>ADMIN</c> user of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=12, Max=30)]
        public string AdminPassword
        {
            get { return this._adminPassword; }
            set { this._adminPassword = value; }
        }

        // Check to see if AdminPassword property is set
        internal bool IsSetAdminPassword()
        {
            return this._adminPassword != null;
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
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
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
        [AWSProperty(Min=3600, Max=604800)]
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
        [AWSProperty(Min=0, Max=604800)]
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
        /// Gets and sets the property BackupRetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for automatic backups of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        [AWSProperty(Min=2)]
        public double? ByolComputeCountLimit
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
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of ECPUs or OCPUs, to assign to the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public double? ComputeCount
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
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores to allocate to the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The list of customer contacts to receive operational notifications from OCI for the
        /// Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContactsToSendToOCI
        {
            get { return this._customerContactsToSendToOCI; }
            set { this._customerContactsToSendToOCI = value; }
        }

        // Check to see if CustomerContactsToSendToOCI property is set
        internal bool IsSetCustomerContactsToSendToOCI()
        {
            return this._customerContactsToSendToOCI != null && (this._customerContactsToSendToOCI.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The Oracle Database edition to apply to the Autonomous Database.
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
        /// Gets and sets the property DataStorageSizeInGBs. 
        /// <para>
        /// The size, in gigabytes (GB), of the data volume to allocate for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=393216)]
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
        /// The size, in terabytes (TB), of the data volume to allocate for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=384)]
        public int? DataStorageSizeInTBs
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
        /// The new name of the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
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
        /// The list of database management tools to enable for the Autonomous Database.
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
        /// The Oracle Database software version to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The new user-friendly name for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property EncryptionKeyConfiguration. 
        /// <para>
        /// The configuration of the encryption key to use for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyConfigurationInput EncryptionKeyConfiguration
        {
            get { return this._encryptionKeyConfiguration; }
            set { this._encryptionKeyConfiguration = value; }
        }

        // Check to see if EncryptionKeyConfiguration property is set
        internal bool IsSetEncryptionKeyConfiguration()
        {
            return this._encryptionKeyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyProvider. 
        /// <para>
        /// The provider of the encryption key to use for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyProviderInput EncryptionKeyProvider
        {
            get { return this._encryptionKeyProvider; }
            set { this._encryptionKeyProvider = value; }
        }

        // Check to see if EncryptionKeyProvider property is set
        internal bool IsSetEncryptionKeyProvider()
        {
            return this._encryptionKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property IsAutoScalingEnabled. 
        /// <para>
        /// Specifies whether to enable automatic scaling of the compute resources for the Autonomous
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
        /// Specifies whether to enable automatic scaling of the storage for the Autonomous Database.
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
        /// Specifies whether to lock the backup retention period of the Autonomous Database to
        /// prevent it from being shortened.
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
        /// Gets and sets the property IsDisconnectPeer. 
        /// <para>
        /// Specifies whether to disconnect the Autonomous Database from its peer database.
        /// </para>
        /// </summary>
        public bool? IsDisconnectPeer
        {
            get { return this._isDisconnectPeer; }
            set { this._isDisconnectPeer = value; }
        }

        // Check to see if IsDisconnectPeer property is set
        internal bool IsSetIsDisconnectPeer()
        {
            return this._isDisconnectPeer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsLocalDataGuardEnabled. 
        /// <para>
        /// Specifies whether to enable local Oracle Data Guard for the Autonomous Database.
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
        /// Specifies whether mutual TLS (mTLS) authentication is required to connect to the Autonomous
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
        /// Gets and sets the property IsRefreshableClone. 
        /// <para>
        /// Specifies whether the Autonomous Database is a refreshable clone.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Autonomous Database.
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
        [AWSProperty(Min=0, Max=3600)]
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
        /// Gets and sets the property OpenMode. 
        /// <para>
        /// The mode in which to open the Autonomous Database, either read-only or read/write.
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
        /// Gets and sets the property PeerDbId. 
        /// <para>
        /// The unique identifier of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
        public string PeerDbId
        {
            get { return this._peerDbId; }
            set { this._peerDbId = value; }
        }

        // Check to see if PeerDbId property is set
        internal bool IsSetPeerDbId()
        {
            return this._peerDbId != null;
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
        /// Gets and sets the property ResourcePoolLeaderId. 
        /// <para>
        /// The unique identifier of the resource pool leader Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
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

    }
}