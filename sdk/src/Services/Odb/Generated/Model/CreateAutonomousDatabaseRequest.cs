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
    /// Container for the parameters to the CreateAutonomousDatabase operation.
    /// Creates a new Autonomous Database.
    /// </summary>
    public partial class CreateAutonomousDatabaseRequest : AmazonOdbRequest
    {
        private string _adminPassword;
        private AdminPasswordSource _adminPasswordSource;
        private AdminPasswordSourceConfigurationInput _adminPasswordSourceConfiguration;
        private List<string> _allowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AutonomousMaintenanceScheduleType _autonomousMaintenanceScheduleType;
        private int? _backupRetentionPeriodInDays;
        private double? _byolComputeCountLimit;
        private string _characterSet;
        private string _clientToken;
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
        private bool? _isLocalDataGuardEnabled;
        private bool? _isMtlsConnectionRequired;
        private LicenseModel _licenseModel;
        private string _ncharacterSet;
        private string _odbNetworkId;
        private string _privateEndpointIp;
        private string _privateEndpointLabel;
        private string _resourcePoolLeaderId;
        private ResourcePoolSummary _resourcePoolSummary;
        private List<ScheduledOperationDetails> _scheduledOperations = AWSConfigs.InitializeCollections ? new List<ScheduledOperationDetails>() : null;
        private SourceType _source;
        private SourceConfiguration _sourceConfiguration;
        private List<string> _standbyAllowlistedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StandbyAllowlistedIpsSource _standbyAllowlistedIpsSource;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TransportableTablespace _transportableTablespace;

        /// <summary>
        /// Gets and sets the property AdminPassword. 
        /// <para>
        /// The password for the <c>ADMIN</c> user of the Autonomous Database.
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
        /// Gets and sets the property AdminPasswordSource. 
        /// <para>
        /// The source of the admin password for the Autonomous Database. When set to <c>CUSTOMER_MANAGED_AWS_SECRET</c>,
        /// the admin password is retrieved from an Amazon Web Services Secrets Manager secret.
        /// </para>
        /// </summary>
        public AdminPasswordSource AdminPasswordSource
        {
            get { return this._adminPasswordSource; }
            set { this._adminPasswordSource = value; }
        }

        // Check to see if AdminPasswordSource property is set
        internal bool IsSetAdminPasswordSource()
        {
            return this._adminPasswordSource != null;
        }

        /// <summary>
        /// Gets and sets the property AdminPasswordSourceConfiguration. 
        /// <para>
        /// The configuration of the admin password source for the Autonomous Database.
        /// </para>
        /// </summary>
        public AdminPasswordSourceConfigurationInput AdminPasswordSourceConfiguration
        {
            get { return this._adminPasswordSourceConfiguration; }
            set { this._adminPasswordSourceConfiguration = value; }
        }

        // Check to see if AdminPasswordSourceConfiguration property is set
        internal bool IsSetAdminPasswordSourceConfiguration()
        {
            return this._adminPasswordSourceConfiguration != null;
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
        /// Gets and sets the property CharacterSet. 
        /// <para>
        /// The character set to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-provided token to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity, in number of Elastic CPUs (ECPUs) or Oracle CPUs (OCPUs), to
        /// assign to the Autonomous Database.
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
        /// The list of customer contacts to receive operational notifications from Oracle Cloud
        /// Infrastructure (OCI) for the Autonomous Database.
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
        /// The name of the Autonomous Database. The name must begin with an alphabetic character
        /// and can contain a maximum of 30 alphanumeric characters. Special characters are not
        /// permitted. The name must be unique in the Amazon Web Services account.
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
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique.
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
        /// Gets and sets the property NcharacterSet. 
        /// <para>
        /// The national character set to use for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to be used for the Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=2048)]
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from which to create the Autonomous Database, such as a clone, backup,
        /// or cross-Region copy.
        /// </para>
        /// </summary>
        public SourceType Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The configuration details for the source used to create the Autonomous Database.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Autonomous Database. Each tag is a key-value
        /// pair with no predefined name, type, or namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransportableTablespace. 
        /// <para>
        /// The transportable tablespace configuration to use when creating the Autonomous Database.
        /// </para>
        /// </summary>
        public TransportableTablespace TransportableTablespace
        {
            get { return this._transportableTablespace; }
            set { this._transportableTablespace = value; }
        }

        // Check to see if TransportableTablespace property is set
        internal bool IsSetTransportableTablespace()
        {
            return this._transportableTablespace != null;
        }

    }
}