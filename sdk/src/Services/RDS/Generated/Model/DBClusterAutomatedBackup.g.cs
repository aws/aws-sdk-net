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
    /// An automated backup of a DB cluster. It consists of system backups, transaction logs,
    /// and the database cluster properties that existed at the time you deleted the source
    /// cluster.
    /// </summary>
    public partial class DBClusterAutomatedBackup
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// For all database engines except Amazon Aurora, <c>AllocatedStorage</c> specifies the
        /// allocated storage size in gibibytes (GiB). For Aurora, <c>AllocatedStorage</c> always
        /// returns 1, because Aurora DB cluster storage size isn't fixed, but instead automatically
        /// adjusts as needed.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones where instances in the DB cluster can be created. For information
        /// on Amazon Web Services Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// The time when the DB cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the source DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterArn property is set.
        /// </summary>
        internal bool IsSetDBClusterArn() => this.DBClusterArn != null;

        /// <summary>
        /// Gets and sets the property DBClusterAutomatedBackupsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the automated backups.
        /// </para>
        /// </summary>
        public string DBClusterAutomatedBackupsArn { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterAutomatedBackupsArn property is set.
        /// </summary>
        internal bool IsSetDBClusterAutomatedBackupsArn() => this.DBClusterAutomatedBackupsArn != null;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier for the source DB cluster, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The resource ID for the source DB cluster, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbClusterResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterResourceId property is set.
        /// </summary>
        internal bool IsSetDbClusterResourceId() => this.DbClusterResourceId != null;

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
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode of the database engine for the automated backup.
        /// </para>
        /// </summary>
        public string EngineMode { get; set; }

        /// <summary>
        /// Checks to see if the EngineMode property is set.
        /// </summary>
        internal bool IsSetEngineMode() => this.EngineMode != null;

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
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS (I/O operations per second) value for the automated backup.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
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
        /// The license model information for this DB cluster automated backup.
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
        /// The master user name of the automated backup.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number that the automated backup used for connections.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB cluster
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
        ///  <c>retained</c> - Automated backups for deleted clusters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Indicates whether the source DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

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
        /// The storage throughput for the automated backup. The throughput is automatically set
        /// based on the IOPS that you provision, and is not configurable.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
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
        /// The storage type associated with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID associated with the DB cluster.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
