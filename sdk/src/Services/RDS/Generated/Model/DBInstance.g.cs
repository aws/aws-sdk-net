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
        /// <summary>
        /// Gets and sets the property ActivityStreamEngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Indicates whether engine-native audit fields are included in the database activity
        /// stream.
        /// </para>
        /// </summary>
        public bool? ActivityStreamEngineNativeAuditFieldsIncluded { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamEngineNativeAuditFieldsIncluded property is set.
        /// </summary>
        internal bool IsSetActivityStreamEngineNativeAuditFieldsIncluded() => this.ActivityStreamEngineNativeAuditFieldsIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property ActivityStreamKinesisStreamName. 
        /// <para>
        /// The name of the Amazon Kinesis data stream used for the database activity stream.
        /// </para>
        /// </summary>
        public string ActivityStreamKinesisStreamName { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamKinesisStreamName property is set.
        /// </summary>
        internal bool IsSetActivityStreamKinesisStreamName() => this.ActivityStreamKinesisStreamName != null;

        /// <summary>
        /// Gets and sets the property ActivityStreamKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier used for encrypting messages in the database
        /// activity stream. The Amazon Web Services KMS key identifier is the key ARN, key ID,
        /// alias ARN, or alias name for the KMS key.
        /// </para>
        /// </summary>
        public string ActivityStreamKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamKmsKeyId property is set.
        /// </summary>
        internal bool IsSetActivityStreamKmsKeyId() => this.ActivityStreamKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ActivityStreamMode. 
        /// <para>
        /// The mode of the database activity stream. Database events such as a change or access
        /// generate an activity stream event. RDS for Oracle always handles these events asynchronously.
        /// </para>
        /// </summary>
        public ActivityStreamMode ActivityStreamMode { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamMode property is set.
        /// </summary>
        internal bool IsSetActivityStreamMode() => this.ActivityStreamMode != null;

        /// <summary>
        /// Gets and sets the property ActivityStreamPolicyStatus. 
        /// <para>
        /// The status of the policy state of the activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamPolicyStatus ActivityStreamPolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamPolicyStatus property is set.
        /// </summary>
        internal bool IsSetActivityStreamPolicyStatus() => this.ActivityStreamPolicyStatus != null;

        /// <summary>
        /// Gets and sets the property ActivityStreamStatus. 
        /// <para>
        /// The status of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamStatus ActivityStreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamStatus property is set.
        /// </summary>
        internal bool IsSetActivityStreamStatus() => this.ActivityStreamStatus != null;

        /// <summary>
        /// Gets and sets the property AdditionalStorageVolumes. 
        /// <para>
        /// The additional storage volumes associated with the DB instance. RDS supports additional
        /// storage volumes for RDS for Oracle and RDS for SQL Server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalStorageVolumeOutput> AdditionalStorageVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalStorageVolumeOutput>() : null;

        /// <summary>
        /// Checks to see if the AdditionalStorageVolumes property is set.
        /// </summary>
        internal bool IsSetAdditionalStorageVolumes() => this.AdditionalStorageVolumes != null && (this.AdditionalStorageVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) allocated for the DB instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// The Amazon Web Services Identity and Access Management (IAM) roles associated with
        /// the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBInstanceRole> AssociatedRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<DBInstanceRole>() : null;

        /// <summary>
        /// Checks to see if the AssociatedRoles property is set.
        /// </summary>
        internal bool IsSetAssociatedRoles() => this.AssociatedRoles != null && (this.AssociatedRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates whether minor version patches are applied automatically.
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
        /// Gets and sets the property AutomaticRestartTime. 
        /// <para>
        /// The time when a stopped DB instance is restarted automatically.
        /// </para>
        /// </summary>
        public DateTime? AutomaticRestartTime { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticRestartTime property is set.
        /// </summary>
        internal bool IsSetAutomaticRestartTime() => this.AutomaticRestartTime.HasValue;

        /// <summary>
        /// Gets and sets the property AutomationMode. 
        /// <para>
        /// The automation mode of the RDS Custom DB instance: <c>full</c> or <c>all paused</c>.
        /// If <c>full</c>, the DB instance automates monitoring and instance recovery. If <c>all
        /// paused</c>, the instance pauses automation for the duration set by <c>--resume-full-automation-mode-minutes</c>.
        /// </para>
        /// </summary>
        public AutomationMode AutomationMode { get; set; }

        /// <summary>
        /// Checks to see if the AutomationMode property is set.
        /// </summary>
        internal bool IsSetAutomationMode() => this.AutomationMode != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone where the DB instance is located.
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
        /// The number of days for which automatic DB snapshots are retained.
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
        /// The location where automated backups and manual snapshots are stored: Dedicated Local
        /// Zones, Amazon Web Services Outposts or the Amazon Web Services Region.
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
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CertificateDetails. 
        /// <para>
        /// The details of the DB instance's server certificate.
        /// </para>
        /// </summary>
        public CertificateDetails CertificateDetails { get; set; }

        /// <summary>
        /// Checks to see if the CertificateDetails property is set.
        /// </summary>
        internal bool IsSetCertificateDetails() => this.CertificateDetails != null;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// If present, specifies the name of the character set that this instance is associated
        /// with.
        /// </para>
        /// </summary>
        public string CharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSetName property is set.
        /// </summary>
        internal bool IsSetCharacterSetName() => this.CharacterSetName != null;

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
        /// </summary>
        public string CustomIamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the CustomIamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetCustomIamInstanceProfile() => this.CustomIamInstanceProfile != null;

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
        public bool? CustomerOwnedIpEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpEnabled property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpEnabled() => this.CustomerOwnedIpEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier of the DB capacity reservation associated with this DB instance. Amazon
        /// RDS doesn't return this value if the DB instance doesn't use a DB capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationIdentifier property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationIdentifier() => this.DBCapacityReservationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// If the DB instance is a member of a DB cluster, indicates the name of the DB cluster
        /// that the DB instance is a member of.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceArn property is set.
        /// </summary>
        internal bool IsSetDBInstanceArn() => this.DBInstanceArn != null;

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsReplications. 
        /// <para>
        /// The list of replicated automated backups associated with the DB instance.
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class of the DB instance.
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
        /// The user-supplied database identifier. This identifier is the unique key that identifies
        /// a DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

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
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceStatus property is set.
        /// </summary>
        internal bool IsSetDBInstanceStatus() => this.DBInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        /// The initial database name that you provided (if required) when you created the DB
        /// instance. This name is returned for the life of your DB instance. For an RDS for Oracle
        /// CDB instance, the name identifies the PDB rather than the CDB.
        /// </para>
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// Checks to see if the DBName property is set.
        /// </summary>
        internal bool IsSetDBName() => this.DBName != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroups. 
        /// <para>
        /// The list of DB parameter groups applied to this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBParameterGroupStatus> DBParameterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<DBParameterGroupStatus>() : null;

        /// <summary>
        /// Checks to see if the DBParameterGroups property is set.
        /// </summary>
        internal bool IsSetDBParameterGroups() => this.DBParameterGroups != null && (this.DBParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBSecurityGroups. 
        /// <para>
        /// A list of DB security group elements containing <c>DBSecurityGroup.Name</c> and <c>DBSecurityGroup.Status</c>
        /// subelements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<DBSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the DBSecurityGroups property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroups() => this.DBSecurityGroups != null && (this.DBSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Information about the subnet group associated with the DB instance, including the
        /// name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public DBSubnetGroup DBSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroup() => this.DBSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// The Oracle system ID (Oracle SID) for a container database (CDB). The Oracle SID is
        /// also the name of the CDB. This setting is only valid for RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string DBSystemId { get; set; }

        /// <summary>
        /// Checks to see if the DBSystemId property is set.
        /// </summary>
        internal bool IsSetDBSystemId() => this.DBSystemId != null;

        /// <summary>
        /// Gets and sets the property DatabaseInsightsMode. 
        /// <para>
        /// The mode of Database Insights that is enabled for the instance.
        /// </para>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInsightsMode property is set.
        /// </summary>
        internal bool IsSetDatabaseInsightsMode() => this.DatabaseInsightsMode != null;

        /// <summary>
        /// Gets and sets the property DbInstancePort. 
        /// <para>
        /// The port that the DB instance listens on. If the DB instance is part of a DB cluster,
        /// this can be a different port than the DB cluster port.
        /// </para>
        /// </summary>
        public int? DbInstancePort { get; set; }

        /// <summary>
        /// Checks to see if the DbInstancePort property is set.
        /// </summary>
        internal bool IsSetDbInstancePort() => this.DbInstancePort.HasValue;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB instance. This
        /// identifier is found in Amazon Web Services CloudTrail log entries whenever the Amazon
        /// Web Services KMS key for the DB instance is accessed.
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the DB instance has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property DomainMemberships. 
        /// <para>
        /// The Active Directory Domain membership records associated with the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainMembership> DomainMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainMembership>() : null;

        /// <summary>
        /// Checks to see if the DomainMemberships property is set.
        /// </summary>
        internal bool IsSetDomainMemberships() => this.DomainMemberships != null && (this.DomainMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudwatchLogsExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledCloudwatchLogsExports property is set.
        /// </summary>
        internal bool IsSetEnabledCloudwatchLogsExports() => this.EnabledCloudwatchLogsExports != null && (this.EnabledCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine used for this DB instance.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The lifecycle type for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see CreateDBInstance.
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport { get; set; }

        /// <summary>
        /// Checks to see if the EngineLifecycleSupport property is set.
        /// </summary>
        internal bool IsSetEngineLifecycleSupport() => this.EngineLifecycleSupport != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property EnhancedMonitoringResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch Logs log stream that receives
        /// the Enhanced Monitoring metrics data for the DB instance.
        /// </para>
        /// </summary>
        public string EnhancedMonitoringResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoringResourceArn property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoringResourceArn() => this.EnhancedMonitoringResourceArn != null;

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
        /// The Provisioned IOPS (I/O operations per second) value for the DB instance.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

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
        public bool? IsStorageConfigUpgradeAvailable { get; set; }

        /// <summary>
        /// Checks to see if the IsStorageConfigUpgradeAvailable property is set.
        /// </summary>
        internal bool IsSetIsStorageConfigUpgradeAvailable() => this.IsStorageConfigUpgradeAvailable.HasValue;

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
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// The latest time to which a database in this DB instance can be restored with point-in-time
        /// restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model information for this DB instance. This setting doesn't apply to
        /// Amazon Aurora or RDS Custom DB instances.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property ListenerEndpoint. 
        /// <para>
        /// The listener connection endpoint for SQL Server Always On.
        /// </para>
        /// </summary>
        public Endpoint ListenerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ListenerEndpoint property is set.
        /// </summary>
        internal bool IsSetListenerEndpoint() => this.ListenerEndpoint != null;

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
        public MasterUserSecret MasterUserSecret { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserSecret property is set.
        /// </summary>
        internal bool IsSetMasterUserSecret() => this.MasterUserSecret != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master username for the DB instance.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which Amazon RDS can automatically scale the
        /// storage of the DB instance.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMaxAllocatedStorage() => this.MaxAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB instance.
        /// </para>
        /// </summary>
        public int? MonitoringInterval { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringInterval property is set.
        /// </summary>
        internal bool IsSetMonitoringInterval() => this.MonitoringInterval.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The ARN for the IAM role that permits RDS to send Enhanced Monitoring metrics to Amazon
        /// CloudWatch Logs.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringRoleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringRoleArn() => this.MonitoringRoleArn != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates whether the DB instance is a Multi-AZ deployment. This setting doesn't apply
        /// to RDS Custom DB instances.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property MultiTenant. 
        /// <para>
        /// Specifies whether the DB instance is in the multi-tenant configuration (TRUE) or the
        /// single-tenant configuration (FALSE).
        /// </para>
        /// </summary>
        public bool? MultiTenant { get; set; }

        /// <summary>
        /// Checks to see if the MultiTenant property is set.
        /// </summary>
        internal bool IsSetMultiTenant() => this.MultiTenant.HasValue;

        /// <summary>
        /// Gets and sets the property NcharCharacterSetName. 
        /// <para>
        /// The name of the NCHAR character set for the Oracle DB instance. This character set
        /// specifies the Unicode encoding for data stored in table columns of type NCHAR, NCLOB,
        /// or NVARCHAR2.
        /// </para>
        /// </summary>
        public string NcharCharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the NcharCharacterSetName property is set.
        /// </summary>
        internal bool IsSetNcharCharacterSetName() => this.NcharCharacterSetName != null;

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
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionGroupMembership> OptionGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the OptionGroupMemberships property is set.
        /// </summary>
        internal bool IsSetOptionGroupMemberships() => this.OptionGroupMemberships != null && (this.OptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Information about pending changes to the DB instance. This information is returned
        /// only when there are pending changes. Specific changes are identified by subelements.
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the storage optimization operation as a percentage.
        /// </para>
        /// </summary>
        public string PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress != null;

        /// <summary>
        /// Gets and sets the property PerformanceInsightsEnabled. 
        /// <para>
        /// Indicates whether Performance Insights is enabled for the DB instance.
        /// </para>
        /// </summary>
        public bool? PerformanceInsightsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsEnabled property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsEnabled() => this.PerformanceInsightsEnabled.HasValue;

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
        public string PerformanceInsightsKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsKMSKeyId property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsKMSKeyId() => this.PerformanceInsightsKMSKeyId != null;

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
        public int? PerformanceInsightsRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsRetentionPeriod() => this.PerformanceInsightsRetentionPeriod.HasValue;

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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
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
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// The order of priority in which an Aurora Replica is promoted to the primary instance
        /// after a failure of the existing primary instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.AuroraHighAvailability.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public int? PromotionTier { get; set; }

        /// <summary>
        /// Checks to see if the PromotionTier property is set.
        /// </summary>
        internal bool IsSetPromotionTier() => this.PromotionTier.HasValue;

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
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaDBClusterIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaDBClusterIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaDBClusterIdentifiers() => this.ReadReplicaDBClusterIdentifiers != null && (this.ReadReplicaDBClusterIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadReplicaDBInstanceIdentifiers. 
        /// <para>
        /// The identifiers of the read replicas associated with this DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaDBInstanceIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaDBInstanceIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaDBInstanceIdentifiers() => this.ReadReplicaDBInstanceIdentifiers != null && (this.ReadReplicaDBInstanceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster if this DB instance is a read replica.
        /// </para>
        /// </summary>
        public string ReadReplicaSourceDBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReadReplicaSourceDBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetReadReplicaSourceDBClusterIdentifier() => this.ReadReplicaSourceDBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReadReplicaSourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the source DB instance if this DB instance is a read replica.
        /// </para>
        /// </summary>
        public string ReadReplicaSourceDBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReadReplicaSourceDBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetReadReplicaSourceDBInstanceIdentifier() => this.ReadReplicaSourceDBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// The open mode of a Db2 or an Oracle read replica. The default is <c>open-read-only</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/db2-replication.html">Working
        /// with replicas for Amazon RDS for Db2</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with read replicas for Amazon RDS for Oracle</a> in the <i>Amazon RDS User Guide</i>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This attribute is only supported in RDS for Db2, RDS for Oracle, and RDS Custom for
        /// Oracle.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicaMode ReplicaMode { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaMode property is set.
        /// </summary>
        internal bool IsSetReplicaMode() => this.ReplicaMode != null;

        /// <summary>
        /// Gets and sets the property ResumeFullAutomationModeTime. 
        /// <para>
        /// The number of minutes to pause the automation. When the time period ends, RDS Custom
        /// resumes full automation. The minimum value is 60 (default). The maximum value is 1,440.
        /// </para>
        /// </summary>
        public DateTime? ResumeFullAutomationModeTime { get; set; }

        /// <summary>
        /// Checks to see if the ResumeFullAutomationModeTime property is set.
        /// </summary>
        internal bool IsSetResumeFullAutomationModeTime() => this.ResumeFullAutomationModeTime.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// If present, specifies the name of the secondary Availability Zone for a DB instance
        /// with multi-AZ support.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSecondaryAvailabilityZone() => this.SecondaryAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// The status of a read replica. If the DB instance isn't a read replica, the value is
        /// blank.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBInstanceStatusInfo> StatusInfos { get; set; } = AWSConfigs.InitializeCollections ? new List<DBInstanceStatusInfo>() : null;

        /// <summary>
        /// Checks to see if the StatusInfos property is set.
        /// </summary>
        internal bool IsSetStatusInfos() => this.StatusInfos != null && (this.StatusInfos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Indicates whether the DB instance is encrypted.
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
        /// The type of encryption used to protect data at rest in the DB instance. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c> - The DB instance is not encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-rds</c> - The DB instance is encrypted using an Amazon Web Services owned
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-kms</c> - The DB instance is encrypted using a customer managed KMS key or
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
        /// Gets and sets the property StorageOperationPercentProgress. 
        /// <para>
        /// The percentage of the in-progress storage operation on the DB instance that has completed,
        /// from <c>0</c> to <c>100</c>. This field appears only while a storage operation is
        /// in progress. It isn't present when no storage operation is active.
        /// </para>
        /// </summary>
        public int? StorageOperationPercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the StorageOperationPercentProgress property is set.
        /// </summary>
        internal bool IsSetStorageOperationPercentProgress() => this.StorageOperationPercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property StorageOperationStatus. 
        /// <para>
        /// The status of an in-progress storage operation on the DB instance. This field appears
        /// only while a storage operation is in progress. It isn't present when no storage operation
        /// is active. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Initializing</c> - The volume is initializing from a snapshot, such as during
        /// a snapshot restore, point-in-time restore, read replica creation, or blue/green deployment.
        /// Performance can be lower than provisioned until initialization completes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Optimizing</c> - The volume is optimizing following a storage scaling or modification
        /// operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the StorageOperationStatus property is set.
        /// </summary>
        internal bool IsSetStorageOperationStatus() => this.StorageOperationStatus != null;

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
        public int? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property StorageVolumeStatus. 
        /// <para>
        /// The detailed status information for storage volumes associated with the DB instance.
        /// This information helps identify which specific volume is causing the instance to be
        /// in a storage-full state.
        /// </para>
        /// </summary>
        public string StorageVolumeStatus { get; set; }

        /// <summary>
        /// Checks to see if the StorageVolumeStatus property is set.
        /// </summary>
        internal bool IsSetStorageVolumeStatus() => this.StorageVolumeStatus != null;

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
        /// The ARN from the key store with which the instance is associated for TDE encryption.
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
        /// The time zone of the DB instance. In most cases, the <c>Timezone</c> element is empty.
        /// <c>Timezone</c> content appears only for RDS for Db2 and RDS for SQL Server DB instances
        /// that were created with a time zone specified.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property UpgradeRolloutOrder. 
        /// <para>
        /// This data type represents the order in which the instances are upgraded.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// [first] - Typically used for development or testing environments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [second] - Default order for resources not specifically configured.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [last] - Usually reserved for production environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UpgradeRolloutOrder UpgradeRolloutOrder { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeRolloutOrder property is set.
        /// </summary>
        internal bool IsSetUpgradeRolloutOrder() => this.UpgradeRolloutOrder != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The list of Amazon EC2 VPC security groups that the DB instance belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
