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
    /// Contains the details of an Amazon RDS DB snapshot.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBSnapshots</c> action.
    /// </para>
    /// </summary>
    public partial class DBSnapshot
    {
        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// The additional storage volumes associated with the DB snapshot. RDS supports additional
        /// storage volumes for RDS for Oracle and RDS for SQL Server.
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
        /// Specifies the allocated storage size in gibibytes (GiB).
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
        /// Specifies the name of the Availability Zone the DB instance was located in at the
        /// time of the DB snapshot.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Specifies the DB instance identifier of the DB instance this DB snapshot was created
        /// from.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB snapshot.
        /// </para>
        /// </summary>
        public string DBSnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotArn property is set.
        /// </summary>
        internal bool IsSetDBSnapshotArn() => this.DBSnapshotArn != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// Specifies the identifier for the DB snapshot.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBSnapshotIdentifier() => this.DBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// The Oracle system identifier (SID), which is the name of the Oracle database instance
        /// that manages your database files. The Oracle SID is also the name of your CDB.
        /// </para>
        /// </summary>
        public string DBSystemId { get; set; }

        /// <summary>
        /// Checks to see if the DBSystemId property is set.
        /// </summary>
        internal bool IsSetDBSystemId() => this.DBSystemId != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
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
        /// Indicates whether the DB snapshot is encrypted.
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
        /// Specifies the name of the database engine.
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
        /// Specifies the version of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property FullSnapshotSizeInBytes. 
        /// <para>
        /// The full size of the DB snapshot, in bytes.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is not the incremental size of the snapshot. This is the full snapshot size and
        /// represents the size of all the blocks that were written to the source volume at the
        /// time the snapshot was created.
        /// </para>
        ///  </important>
        /// </summary>
        public long? FullSnapshotSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the FullSnapshotSizeInBytes property is set.
        /// </summary>
        internal bool IsSetFullSnapshotSizeInBytes() => this.FullSnapshotSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether mapping of Amazon Web Services Identity and Access Management (IAM)
        /// accounts to database accounts is enabled.
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
        /// Specifies the time in Coordinated Universal Time (UTC) when the DB instance, from
        /// which the snapshot was taken, was created.
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
        /// Specifies the Provisioned IOPS (I/O operations per second) value of the DB instance
        /// at the time of the snapshot.
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
        /// If <c>Encrypted</c> is true, the Amazon Web Services KMS key identifier for the encrypted
        /// DB snapshot.
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
        /// License model information for the restored DB instance.
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
        /// Provides the master username for the DB snapshot.
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
        /// Indicates whether the snapshot is of a DB instance using the multi-tenant configuration
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
        /// Provides the option group name for the DB snapshot.
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

        /// <summary>
        /// Gets and sets the property OriginalSnapshotCreateTime. 
        /// <para>
        /// Specifies the time of the CreateDBSnapshot operation in Coordinated Universal Time
        /// (UTC). Doesn't change when the snapshot is copied.
        /// </para>
        /// </summary>
        public DateTime? OriginalSnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the OriginalSnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetOriginalSnapshotCreateTime() => this.OriginalSnapshotCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The percentage of the estimated data that has been transferred.
        /// </para>
        /// </summary>
        public int? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine was listening on at the time of the snapshot.
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
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance when the DB snapshot was created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessorFeature>() : null;

        /// <summary>
        /// Checks to see if the ProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetProcessorFeatures() => this.ProcessorFeatures != null && (this.ProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotAvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone where RDS stores the DB snapshot. This
        /// value is valid only for snapshots that RDS stores on a Dedicated Local Zone.
        /// </para>
        /// </summary>
        public string SnapshotAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSnapshotAvailabilityZone() => this.SnapshotAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// Specifies when the snapshot was taken in Coordinated Universal Time (UTC). Changes
        /// for the copy when the snapshot is copied.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotDatabaseTime. 
        /// <para>
        /// The timestamp of the most recent transaction applied to the database that you're backing
        /// up. Thus, if you restore a snapshot, SnapshotDatabaseTime is the most recent transaction
        /// in the restored DB instance. In contrast, originalSnapshotCreateTime specifies the
        /// system time that the snapshot completed.
        /// </para>
        ///  
        /// <para>
        /// If you back up a read replica, you can determine the replica lag by comparing SnapshotDatabaseTime
        /// with originalSnapshotCreateTime. For example, if originalSnapshotCreateTime is two
        /// hours later than SnapshotDatabaseTime, then the replica lag is two hours.
        /// </para>
        /// </summary>
        public DateTime? SnapshotDatabaseTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotDatabaseTime property is set.
        /// </summary>
        internal bool IsSetSnapshotDatabaseTime() => this.SnapshotDatabaseTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotTarget. 
        /// <para>
        /// Specifies where manual snapshots are stored: Dedicated Local Zones, Amazon Web Services
        /// Outposts or the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string SnapshotTarget { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotTarget property is set.
        /// </summary>
        internal bool IsSetSnapshotTarget() => this.SnapshotTarget != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// Provides the type of the DB snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property SourceDBSnapshotIdentifier. 
        /// <para>
        /// The DB snapshot Amazon Resource Name (ARN) that the DB snapshot was copied from. It
        /// only has a value in the case of a cross-account or cross-Region copy.
        /// </para>
        /// </summary>
        public string SourceDBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBSnapshotIdentifier() => this.SourceDBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The Amazon Web Services Region that the DB snapshot was created in or copied from.
        /// </para>
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of this DB snapshot.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncryptionType. 
        /// <para>
        /// The type of encryption used to protect data at rest in the DB snapshot. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c> - The DB snapshot is not encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-rds</c> - The DB snapshot is encrypted using an Amazon Web Services owned
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-kms</c> - The DB snapshot is encrypted using a customer managed KMS key or
        /// Amazon Web Services managed KMS key.
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
        /// Specifies the storage throughput for the DB snapshot.
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
        /// Specifies the storage type associated with DB snapshot.
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
        /// The ARN from the key store with which to associate the instance for TDE encryption.
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
        /// The time zone of the DB snapshot. In most cases, the <c>Timezone</c> element is empty.
        /// <c>Timezone</c> content appears only for snapshots taken from Microsoft SQL Server
        /// DB instances that were created with a time zone specified.
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
        /// Provides the VPC ID associated with the DB snapshot.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
