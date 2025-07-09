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
    /// An automated backup of a DB instance. It consists of system backups, transaction logs,
    /// and the database instance properties that existed at the time you deleted the source
    /// instance.
    /// </summary>
    public partial class DBInstanceAutomatedBackup
    {
        private int? _allocatedStorage;
        private string _availabilityZone;
        private string _awsBackupRecoveryPointArn;
        private int? _backupRetentionPeriod;
        private string _backupTarget;
        private string _dbInstanceArn;
        private string _dbInstanceAutomatedBackupsArn;
        private List<DBInstanceAutomatedBackupsReplication> _dbInstanceAutomatedBackupsReplications = AWSConfigs.InitializeCollections ? new List<DBInstanceAutomatedBackupsReplication>() : null;
        private string _dbInstanceIdentifier;
        private string _dbiResourceId;
        private bool? _dedicatedLogVolume;
        private bool? _encrypted;
        private string _engine;
        private string _engineVersion;
        private bool? _iamDatabaseAuthenticationEnabled;
        private DateTime? _instanceCreateTime;
        private int? _iops;
        private string _kmsKeyId;
        private string _licenseModel;
        private string _masterUsername;
        private bool? _multiTenant;
        private string _optionGroupName;
        private int? _port;
        private string _region;
        private RestoreWindow _restoreWindow;
        private string _status;
        private int? _storageThroughput;
        private string _storageType;
        private string _tdeCredentialArn;
        private string _timezone;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size for the the automated backup in gibibytes (GiB).
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that the automated backup was created in. For information on
        /// Amazon Web Services Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>.
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
        /// The retention period for the automated backups.
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
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location where automated backups are stored: Dedicated Local Zones, Amazon Web
        /// Services Outposts or the Amazon Web Services Region.
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
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the automated backups.
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
        /// Gets and sets the property DBInstanceAutomatedBackupsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the replicated automated backups.
        /// </para>
        /// </summary>
        public string DBInstanceAutomatedBackupsArn
        {
            get { return this._dbInstanceAutomatedBackupsArn; }
            set { this._dbInstanceAutomatedBackupsArn = value; }
        }

        // Check to see if DBInstanceAutomatedBackupsArn property is set
        internal bool IsSetDBInstanceAutomatedBackupsArn()
        {
            return this._dbInstanceAutomatedBackupsArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsReplications. 
        /// <para>
        /// The list of replications to different Amazon Web Services Regions associated with
        /// the automated backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
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
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The resource ID for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
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
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume
        {
            get { return this._dedicatedLogVolume; }
            set { this._dedicatedLogVolume = value; }
        }

        // Check to see if DedicatedLogVolume property is set
        internal bool IsSetDedicatedLogVolume()
        {
            return this._dedicatedLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the automated backup is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine for this automated backup.
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
        /// The version of the database engine for the automated backup.
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
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// True if mapping of Amazon Web Services Identity and Access Management (IAM) accounts
        /// to database accounts is enabled, and otherwise false.
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
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// The date and time when the DB instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
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
        /// The IOPS (I/O operations per second) value for the automated backup.
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
        /// The Amazon Web Services KMS key ID for an automated backup.
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
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model information for the automated backup.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of an automated backup.
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
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Specifies whether the automatic backup is for a DB instance in the multi-tenant configuration
        /// (TRUE) or the single-tenant configuration (FALSE). 
        /// </para>
        /// </summary>
        public bool? MultiTenant
        {
            get { return this._multiTenant; }
            set { this._multiTenant = value; }
        }

        // Check to see if MultiTenant property is set
        internal bool IsSetMultiTenant()
        {
            return this._multiTenant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group the automated backup is associated with. If omitted, the default
        /// option group for the engine specified is used.
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that the automated backup used for connections.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB instance
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1150-65535</c> 
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region associated with the automated backup.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreWindow. 
        /// <para>
        /// The earliest and latest time a DB instance can be restored to.
        /// </para>
        /// </summary>
        public RestoreWindow RestoreWindow
        {
            get { return this._restoreWindow; }
            set { this._restoreWindow = value; }
        }

        // Check to see if RestoreWindow property is set
        internal bool IsSetRestoreWindow()
        {
            return this._restoreWindow != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A list of status information for an automated backup:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - Automated backups for current instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>retained</c> - Automated backups for deleted instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creating</c> - Automated backups that are waiting for the first automated snapshot
        /// to be available.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the automated backup.
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
        /// The storage type associated with the automated backup.
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
        /// The ARN from the key store with which the automated backup is associated for TDE encryption.
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
        /// The time zone of the automated backup. In most cases, the <c>Timezone</c> element
        /// is empty. <c>Timezone</c> content appears only for Microsoft SQL Server DB instances
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID associated with the DB instance.
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

    }
}