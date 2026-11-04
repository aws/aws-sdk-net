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
    /// Container for the parameters to the RestoreDBInstanceFromDBSnapshot operation. Creates
    /// a new DB instance from a DB snapshot. The target database is created from the source
    /// database restore point with most of the source's original configuration, including
    /// the default security group and DB parameter group. By default, the new DB instance
    /// is created as a Single-AZ deployment, except when the instance is a SQL Server instance
    /// that has an option group associated with mirroring. In this case, the instance becomes
    /// a Multi-AZ deployment, not a Single-AZ deployment. <para> If you want to replace your
    /// original DB instance with the new, restored DB instance, then rename your original
    /// DB instance before you call the <c>RestoreDBInstanceFromDBSnapshot</c> operation.
    /// RDS doesn't allow two DB instances with the same name. After you have renamed your
    /// original DB instance with a different identifier, then you can pass the original name
    /// of the DB instance as the <c>DBInstanceIdentifier</c> in the call to the <c>RestoreDBInstanceFromDBSnapshot</c>
    /// operation. The result is that you replace the original DB instance with the DB instance
    /// created from the snapshot. </para> <para> If you are restoring from a shared manual
    /// DB snapshot, the <c>DBSnapshotIdentifier</c> must be the ARN of the shared DB snapshot.
    /// </para> <para> To restore from a DB snapshot with an unsupported engine version, you
    /// must first upgrade the engine version of the snapshot. For more information about
    /// upgrading a RDS for MySQL DB snapshot engine version, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/mysql-upgrade-snapshot.html">Upgrading
    /// a MySQL DB snapshot engine version</a>. For more information about upgrading a RDS
    /// for PostgreSQL DB snapshot engine version, <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBSnapshot.PostgreSQL.html">Upgrading
    /// a PostgreSQL DB snapshot engine version</a>. </para> <note> <para> This command doesn't
    /// apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use <c>RestoreDBClusterFromSnapshot</c>.
    /// </para> </note>
    /// </summary>
    public partial class RestoreDBInstanceFromDBSnapshotRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public RestoreDBInstanceFromDBSnapshotRequest() { }

        /// <summary>
        /// Instantiates RestoreDBInstanceFromDBSnapshotRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The name of the DB instance to create from the DB snapshot. This parameter isn't case-sensitive. Constraints: <ul> <li> Must contain from 1 to 63 numbers, letters, or hyphens. </li> <li> First character must be a letter. </li> <li> Can't end with a hyphen or contain two consecutive hyphens. </li> </ul> Example: <c>my-snapshot-id</c> </param>
        /// <param name="dbSnapshotIdentifier">The identifier for the DB snapshot to restore from. Constraints: <ul> <li> Must match the identifier of an existing DB snapshot. </li> <li> Can't be specified when <c>DBClusterSnapshotIdentifier</c> is specified. </li> <li> Must be specified when <c>DBClusterSnapshotIdentifier</c> isn't specified. </li> <li> If you are restoring from a shared manual DB snapshot, the <c>DBSnapshotIdentifier</c> must be the ARN of the shared DB snapshot. </li> </ul></param>
        public RestoreDBInstanceFromDBSnapshotRequest(string dbInstanceIdentifier, string dbSnapshotIdentifier)
        {
            this.DBInstanceIdentifier = dbInstanceIdentifier;
            this.DBSnapshotIdentifier = dbSnapshotIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// A list of additional storage volumes to create for the DB instance. You can create
        /// up to three additional storage volumes using the names <c>rdsdbdata2</c>, <c>rdsdbdata3</c>,
        /// and <c>rdsdbdata4</c>. Additional storage volumes are supported for RDS for Oracle
        /// and RDS for SQL Server DB instances only.
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
        /// The amount of storage (in gibibytes) to allocate initially for the DB instance. Follow
        /// the allocation rules specified in CreateDBInstance.
        /// </para>
        ///  
        /// <para>
        /// This setting isn't valid for RDS for SQL Server.
        /// </para>
        ///  <note> 
        /// <para>
        /// Be sure to allocate enough storage for your new DB instance so that the restore operation
        /// can succeed. You can also allocate additional storage for future growth.
        /// </para>
        ///  </note>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Specifies whether to automatically apply minor version upgrades to the DB instance
        /// during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// If you restore an RDS Custom DB instance, you must disable this parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information about automatic minor version upgrades, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Upgrading.html#USER_UpgradeDBInstance.Upgrading.AutoMinorVersionUpgrades">Automatically
        /// upgrading the minor engine version</a>.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone (AZ) where the DB instance will be created.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can't specify the <c>AvailabilityZone</c> parameter if the DB instance
        /// is a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>us-east-1a</c> 
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
        /// The number of days to retain automated backups. Setting this parameter to a positive
        /// number enables backups. Setting this parameter to 0 disables automated backups.
        /// </para>
        ///  <note> 
        /// <para>
        /// Enabling and disabling backups can result in a brief I/O suspension that lasts from
        /// a few seconds to a few minutes, depending on the size and class of your DB instance.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The retention period for
        /// automated backups is managed by the DB cluster. For more information, see <c>ModifyDBCluster</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 0 to 35.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 if the DB instance is a source to read replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be set to 0 for an RDS Custom for Oracle DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property BackupTarget. 
        /// <para>
        /// Specifies where automated backups and manual snapshots are stored for the restored
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// Possible values are <c>local</c> (Dedicated Local Zone), <c>outposts</c> (Amazon Web
        /// Services Outposts), and <c>region</c> (Amazon Web Services Region). The default is
        /// <c>region</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Working
        /// with Amazon RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public string BackupTarget { get; set; }

        /// <summary>
        /// Checks to see if the BackupTarget property is set.
        /// </summary>
        internal bool IsSetBackupTarget() => this.BackupTarget != null;

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The CA certificate identifier to use for the DB instance's server certificate.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
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
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the restored DB instance to snapshots of the
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// In most cases, tags aren't copied by default. However, when you restore a DB instance
        /// from a DB snapshot, RDS checks whether you specify new tags. If yes, the new tags
        /// are added to the restored DB instance. If there are no new tags, RDS looks for the
        /// tags from the source DB instance for the DB snapshot, and then adds those tags to
        /// the restored DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html#USER_Tagging.CopyTags">
        /// Copying tags to DB instance snapshots</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

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
        ///  
        /// <para>
        /// This setting is required for RDS Custom.
        /// </para>
        /// </summary>
        public string CustomIamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the CustomIamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetCustomIamInstanceProfile() => this.CustomIamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation to associate with this DB
        /// instance. You can specify the identifier, which has the prefix <c>dbcr-</c>, or the
        /// reservation name. When you specify this parameter, the DB instance uses reserved capacity
        /// from the specified reservation.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>AvailabilityZone</c>, Amazon RDS places the DB instance in that
        /// Availability Zone, and the reservation must cover it.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The reservation must reserve capacity for the DB instance class and the database engine
        /// of the DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the reservation reserves capacity for a specific license model, the license model
        /// of the DB instance must match it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must be in the <c>active</c> state, and it must not be past its end
        /// date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>AvailabilityZone</c>, it must be one of the Availability Zones of
        /// the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Multi-AZ DB instance, the reservation must cover two or more Availability Zones.
        /// A Multi-AZ DB instance uses one unit of reserved capacity in each of two Availability
        /// Zones. If the reservation covers more than two Availability Zones, Amazon RDS chooses
        /// the two that the DB instance uses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must have available capacity in each Availability Zone that the DB
        /// instance uses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB subnet group must be in a VPC with default tenancy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB subnet group must cover each Availability Zone that the DB instance uses.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationIdentifier property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationIdentifier() => this.DBCapacityReservationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier for the Multi-AZ DB cluster snapshot to restore from.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing Multi-AZ DB cluster snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified when <c>DBSnapshotIdentifier</c> is specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified when <c>DBSnapshotIdentifier</c> isn't specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are restoring from a shared manual Multi-AZ DB cluster snapshot, the <c>DBClusterSnapshotIdentifier</c>
        /// must be the ARN of the shared snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be the identifier of an Aurora DB cluster snapshot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBClusterSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterSnapshotIdentifier() => this.DBClusterSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the Amazon RDS DB instance, for example db.m4.large.
        /// Not all DB instance classes are available in all Amazon Web Services Regions, or for
        /// all database engines. For the full list of DB instance classes, and availability for
        /// your engine, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Default: The same DBInstanceClass as the original DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The name of the DB instance to create from the DB snapshot. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 numbers, letters, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-snapshot-id</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The name of the database for the restored DB instance.
        /// </para>
        ///  
        /// <para>
        /// This parameter only applies to RDS for Oracle and RDS for SQL Server DB instances.
        /// It doesn't apply to the other engines or to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>DBParameterGroupName</c>, then RDS uses the default
        /// <c>DBParameterGroup</c> for the specified DB engine.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupName() => this.DBParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the DB snapshot to restore from.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified when <c>DBClusterSnapshotIdentifier</c> is specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified when <c>DBClusterSnapshotIdentifier</c> isn't specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <c>DBSnapshotIdentifier</c>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBSnapshotIdentifier() => this.DBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name of the DB subnet group to use for the new instance.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB subnet group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property DedicatedLogVolume. 
        /// <para>
        /// Specifies whether to enable a dedicated log volume (DLV) for the DB instance.
        /// </para>
        /// </summary>
        public bool? DedicatedLogVolume { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedLogVolume property is set.
        /// </summary>
        internal bool IsSetDedicatedLogVolume() => this.DedicatedLogVolume.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the DB instance. The database
        /// can't be deleted when deletion protection is enabled. By default, deletion protection
        /// isn't enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to restore the DB instance in. The domain/ must
        /// be created prior to this operation. Currently, you can create only Db2, MySQL, Microsoft
        /// SQL Server, Oracle, and PostgreSQL DB instances in an Active Directory Domain.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainAuthSecretArn. 
        /// <para>
        /// The ARN for the Secrets Manager secret with the credentials for the user joining the
        /// domain.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>arn:aws:secretsmanager:region:account-number:secret:myselfmanagedADtestsecret-123456</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainAuthSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainAuthSecretArn property is set.
        /// </summary>
        internal bool IsSetDomainAuthSecretArn() => this.DomainAuthSecretArn != null;

        /// <summary>
        /// Gets and sets the property DomainDnsIps. 
        /// <para>
        /// The IPv4 DNS IP addresses of your primary and secondary Active Directory domain controllers.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Two IP addresses must be provided. If there isn't a secondary domain controller, use
        /// the IP address of the primary domain controller for both entries in the list.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>123.124.125.126,234.235.236.237</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainDnsIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainDnsIps property is set.
        /// </summary>
        internal bool IsSetDomainDnsIps() => this.DomainDnsIps != null && (this.DomainDnsIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of an Active Directory domain.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mymanagedADtest.mymanagedAD.mydomain</c> 
        /// </para>
        /// </summary>
        public string DomainFqdn { get; set; }

        /// <summary>
        /// Checks to see if the DomainFqdn property is set.
        /// </summary>
        internal bool IsSetDomainFqdn() => this.DomainFqdn != null;

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string DomainIAMRoleName { get; set; }

        /// <summary>
        /// Checks to see if the DomainIAMRoleName property is set.
        /// </summary>
        internal bool IsSetDomainIAMRoleName() => this.DomainIAMRoleName != null;

        /// <summary>
        /// Gets and sets the property DomainOu. 
        /// <para>
        /// The Active Directory organizational unit for your DB instance to join.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the distinguished name format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be longer than 64 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>OU=mymanagedADtestOU,DC=mymanagedADtest,DC=mymanagedAD,DC=mydomain</c>
        /// 
        /// </para>
        /// </summary>
        public string DomainOu { get; set; }

        /// <summary>
        /// Checks to see if the DomainOu property is set.
        /// </summary>
        internal bool IsSetDomainOu() => this.DomainOu != null;

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs for the restored DB instance to export to CloudWatch Logs. The values
        /// in the list depend on the DB engine. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableCloudwatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnableCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnableCloudwatchLogsExports() => this.EnableCloudwatchLogsExports != null && (this.EnableCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableCustomerOwnedIp. 
        /// <para>
        /// Specifies whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// A <i>CoIP</i> provides local or external connectivity to resources in your Outpost
        /// subnets through your on-premises network. For some use cases, a CoIP can provide lower
        /// latency for connections to the DB instance from outside of its virtual private cloud
        /// (VPC) on your local network.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        public bool? EnableCustomerOwnedIp { get; set; }

        /// <summary>
        /// Checks to see if the EnableCustomerOwnedIp property is set.
        /// </summary>
        internal bool IsSetEnableCustomerOwnedIp() => this.EnableCustomerOwnedIp.HasValue;

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping is disabled.
        /// </para>
        ///  
        /// <para>
        /// For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the EnableIAMDatabaseAuthentication property is set.
        /// </summary>
        internal bool IsSetEnableIAMDatabaseAuthentication() => this.EnableIAMDatabaseAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for the new instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Default: The same as source
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be compatible with the engine of the source. For example, you can
        /// restore a MariaDB 10.1 DB instance from a MySQL 5.6 snapshot.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db2-ae</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-ce</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The lifecycle type for this DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, this value is set to <c>open-source-rds-extended-support</c>, which enrolls
        /// your DB instance into Amazon RDS Extended Support. At the end of standard support,
        /// you can avoid charges for Extended Support by setting the value to <c>open-source-rds-extended-support-disabled</c>.
        /// In this case, RDS automatically upgrades your restored DB instance to a higher engine
        /// version, if the major engine version is past its end of standard support date.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use this setting to enroll your DB instance into Amazon RDS Extended Support.
        /// With RDS Extended Support, you can run the selected major engine version on your DB
        /// instance past the end of standard support for that engine version. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to RDS for MySQL and RDS for PostgreSQL. For Amazon Aurora
        /// DB instances, the engine lifecycle support is managed by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>open-source-rds-extended-support | open-source-rds-extended-support-disabled</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>open-source-rds-extended-support</c> 
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport { get; set; }

        /// <summary>
        /// Checks to see if the EngineLifecycleSupport property is set.
        /// </summary>
        internal bool IsSetEngineLifecycleSupport() => this.EngineLifecycleSupport != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the amount of provisioned IOPS for the DB instance, expressed in I/O operations
        /// per second. If this parameter isn't specified, the IOPS value is taken from the backup.
        /// If this parameter is set to 0, the new instance is converted to a non-PIOPS instance.
        /// The conversion takes additional time, though your DB instance is available for connections
        /// before the conversion starts.
        /// </para>
        ///  
        /// <para>
        /// The provisioned IOPS value must follow the requirements for your database engine.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// RDS Provisioned IOPS storage</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be an integer greater than 1000.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// License model information for the restored DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// License models for RDS for Db2 require additional configuration. The bring your own
        /// license (BYOL) model requires a custom parameter group and an Amazon Web Services
        /// License Manager self-managed license. The Db2 license through Amazon Web Services
        /// Marketplace model requires an Amazon Web Services Marketplace subscription. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-licensing.html">Amazon
        /// RDS for Db2 licensing options</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting doesn't apply to Amazon Aurora or RDS Custom DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Db2 - <c>bring-your-own-license | marketplace-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MariaDB - <c>general-public-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server - <c>license-included | bring-your-own-media</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for MySQL - <c>general-public-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - <c>bring-your-own-license | license-included</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for PostgreSQL - <c>postgresql-license</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Same as the source.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager in the restored DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Applies to RDS for Oracle only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ManageMasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the ManageMasterUserPassword property is set.
        /// </summary>
        internal bool IsSetManageMasterUserPassword() => this.ManageMasterUserPassword.HasValue;

        /// <summary>
        /// Gets and sets the property MasterUserSecretKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
        /// generated and managed in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MasterUserSecretKmsKeyId</c>, then the <c>aws/secretsmanager</c>
        /// KMS key is used to encrypt the secret. If the secret is in a different Amazon Web
        /// Services account, then you can't use the <c>aws/secretsmanager</c> KMS key to encrypt
        /// the secret, and you must use a customer managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// There is a default KMS key for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string MasterUserSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetMasterUserSecretKmsKeyId() => this.MasterUserSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the DB instance is a Multi-AZ deployment.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can't specify the <c>AvailabilityZone</c> parameter if the DB instance
        /// is a Multi-AZ deployment.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB instance.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of the option group to be used for the restored DB instance.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can't
        /// be removed from an option group, and that option group can't be removed from a DB
        /// instance after it is associated with a DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// The port number on which the database accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original DB instance
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be <c>1150-65535</c> 
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
        /// are enabled, as determined by the <c>BackupRetentionPeriod</c> parameter. Changing
        /// this parameter doesn't result in an outage and the change is asynchronously applied
        /// as soon as possible. The default is a 30-minute window selected at random from an
        /// 8-hour block of time for each Amazon Web Services Region. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithAutomatedBackups.html#USER_WorkingWithAutomatedBackups.BackupWindow">Backup
        /// window</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora DB instances. The daily time range for
        /// creating automated backups is managed by the DB cluster. For more information, see
        /// <c>ModifyDBCluster</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <c>hh24:mi-hh24:mi</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
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
        /// of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB instance's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB instance's VPC.
        /// Access to the DB instance is ultimately controlled by the security group it uses.
        /// That public access is not permitted if the security group assigned to the DB instance
        /// doesn't permit it.
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
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// Specifies the storage throughput value for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom or Amazon Aurora.
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
        /// Specifies the storage type to be associated with the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2 | standard</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>io1</c>, <c>io2</c>, or <c>gp3</c>, you must also include a value
        /// for the <c>Iops</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>io1</c> if the <c>Iops</c> parameter is specified, otherwise <c>gp3</c>
        /// 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Tags to assign to resources associated with the DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto-backup</c> - The DB instance's automated backup.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public string TdeCredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the TdeCredentialArn property is set.
        /// </summary>
        internal bool IsSetTdeCredentialArn() => this.TdeCredentialArn != null;

        /// <summary>
        /// Gets and sets the property TdeCredentialPassword. 
        /// <para>
        /// The password for the given ARN from the key store in order to access the device.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TdeCredentialPassword { get; set; }

        /// <summary>
        /// Checks to see if the TdeCredentialPassword property is set.
        /// </summary>
        internal bool IsSetTdeCredentialPassword() => this.TdeCredentialPassword != null;

        /// <summary>
        /// Gets and sets the property UseDefaultProcessorFeatures. 
        /// <para>
        /// Specifies whether the DB instance class of the DB instance uses its default processor
        /// features.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public bool? UseDefaultProcessorFeatures { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaultProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetUseDefaultProcessorFeatures() => this.UseDefaultProcessorFeatures.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// Default: The default EC2 VPC security group for the DB subnet group's VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
