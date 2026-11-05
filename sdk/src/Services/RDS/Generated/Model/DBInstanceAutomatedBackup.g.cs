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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// The additional storage volumes associated with the automated backup.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>GP3 | IO2</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalStorageVolume> AdditionalStorageVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalStorageVolume>() : null;

        /// <summary>
        /// Checks to see if the AdditionalStorageVolumes property is set.
        /// </summary>
        internal bool IsSetAdditionalStorageVolumes() => this.AdditionalStorageVolumes != null && (this.AdditionalStorageVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage size for the automated backup in gibibytes (GiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that the automated backup was created in. For information on
        /// Amazon Web Services Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AwsBackupRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point in Amazon Web Services Backup.
        /// </para>
        /// </summary>
        public string AwsBackupRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsBackupRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetAwsBackupRecoveryPointArn() => this.AwsBackupRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The retention period for the automated backups.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// The location where automated backups are stored: Dedicated Local Zones, Amazon Web
        /// Services Outposts or the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string BackupTarget { get; set; }

        /// <summary>
        /// Checks to see if the BackupTarget property is set.
        /// </summary>
        internal bool IsSetBackupTarget() => this.BackupTarget != null;

        /// <summary>
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the automated backups.
        /// </para>
        /// </summary>
        public string DBInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceArn property is set.
        /// </summary>
        internal bool IsSetDBInstanceArn() => this.DBInstanceArn != null;

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the replicated automated backups.
        /// </para>
        /// </summary>
        public string DBInstanceAutomatedBackupsArn { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceAutomatedBackupsArn property is set.
        /// </summary>
        internal bool IsSetDBInstanceAutomatedBackupsArn() => this.DBInstanceAutomatedBackupsArn != null;

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsReplications. 
        /// <para>
        /// The list of replications to different Amazon Web Services Regions associated with
        /// the automated backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBInstanceAutomatedBackupsReplication> DBInstanceAutomatedBackupsReplications { get; set; } = AWSConfigs.InitializeCollections ? new List<DBInstanceAutomatedBackupsReplication>() : null;

        /// <summary>
        /// Checks to see if the DBInstanceAutomatedBackupsReplications property is set.
        /// </summary>
        internal bool IsSetDBInstanceAutomatedBackupsReplications() => this.DBInstanceAutomatedBackupsReplications != null && (this.DBInstanceAutomatedBackupsReplications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The resource ID for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Indicates whether the DB instance has a dedicated log volume (DLV) enabled.
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedLogVolume property is set.
        /// </summary>
        internal bool IsSetDedicatedLogVolume() => this.DedicatedLogVolume.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the automated backup is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine for this automated backup.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine for the automated backup.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// True if mapping of Amazon Web Services Identity and Access Management (IAM) accounts
        /// to database accounts is enabled, and otherwise false.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// The date and time when the DB instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCreateTime property is set.
        /// </summary>
        internal bool IsSetInstanceCreateTime() => this.InstanceCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS (I/O operations per second) value for the automated backup.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

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
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model information for the automated backup.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of an automated backup.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Specifies whether the automatic backup is for a DB instance in the multi-tenant configuration
        /// (TRUE) or the single-tenant configuration (FALSE). 
        /// </para>
        /// </summary>
        public bool? MultiTenant { get; set; }

        /// <summary>
        /// Checks to see if the MultiTenant property is set.
        /// </summary>
        internal bool IsSetMultiTenant() => this.MultiTenant.HasValue;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group the automated backup is associated with. If omitted, the default
        /// option group for the engine specified is used.
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

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
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled, as determined by the <c>BackupRetentionPeriod</c>.
        /// </para>
        /// </summary>
        public string PreferredBackupWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredBackupWindow property is set.
        /// </summary>
        internal bool IsSetPreferredBackupWindow() => this.PreferredBackupWindow != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region associated with the automated backup.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RestoreWindow. 
        /// <para>
        /// The earliest and latest time a DB instance can be restored to.
        /// </para>
        /// </summary>
        public RestoreWindow RestoreWindow { get; set; }

        /// <summary>
        /// Checks to see if the RestoreWindow property is set.
        /// </summary>
        internal bool IsSetRestoreWindow() => this.RestoreWindow != null;

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
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncryptionType. 
        /// <para>
        /// The type of encryption used to protect data at rest in the automated backup. Possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c> - The automated backup is not encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-rds</c> - The automated backup is encrypted using an Amazon Web Services owned
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-kms</c> - The automated backup is encrypted using a customer managed KMS key
        /// or Amazon Web Services managed KMS key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageEncryptionType StorageEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncryptionType property is set.
        /// </summary>
        internal bool IsSetStorageEncryptionType() => this.StorageEncryptionType != null;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput for the automated backup.
        /// </para>
        /// </summary>
        public int? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the automated backup.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which the automated backup is associated for TDE encryption.
        /// </para>
        /// </summary>
        public string TdeCredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the TdeCredentialArn property is set.
        /// </summary>
        internal bool IsSetTdeCredentialArn() => this.TdeCredentialArn != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the automated backup. In most cases, the <c>Timezone</c> element
        /// is empty. <c>Timezone</c> content appears only for Microsoft SQL Server DB instances
        /// that were created with a time zone specified.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID associated with the DB instance.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
