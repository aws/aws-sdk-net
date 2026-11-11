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
    /// Contains the details of an Amazon Aurora DB cluster or Multi-AZ DB cluster. 
    /// 
    ///  
    /// <para>
    /// For an Amazon Aurora DB cluster, this data type is used as a response element in the
    /// operations <c>CreateDBCluster</c>, <c>DeleteDBCluster</c>, <c>DescribeDBClusters</c>,
    /// <c>FailoverDBCluster</c>, <c>ModifyDBCluster</c>, <c>PromoteReadReplicaDBCluster</c>,
    /// <c>RestoreDBClusterFromS3</c>, <c>RestoreDBClusterFromSnapshot</c>, <c>RestoreDBClusterToPointInTime</c>,
    /// <c>StartDBCluster</c>, and <c>StopDBCluster</c>.
    /// </para>
    ///  
    /// <para>
    /// For a Multi-AZ DB cluster, this data type is used as a response element in the operations
    /// <c>CreateDBCluster</c>, <c>DeleteDBCluster</c>, <c>DescribeDBClusters</c>, <c>FailoverDBCluster</c>,
    /// <c>ModifyDBCluster</c>, <c>RebootDBCluster</c>, <c>RestoreDBClusterFromSnapshot</c>,
    /// and <c>RestoreDBClusterToPointInTime</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
    /// User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class DBCluster
    {
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
        /// activity stream.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
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
        /// generate an activity stream event. The database session can handle these events either
        /// synchronously or asynchronously.
        /// </para>
        /// </summary>
        public ActivityStreamMode ActivityStreamMode { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStreamMode property is set.
        /// </summary>
        internal bool IsSetActivityStreamMode() => this.ActivityStreamMode != null;

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
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  <c>AllocatedStorage</c> specifies the allocated storage size in gibibytes (GiB).
        /// For Aurora, <c>AllocatedStorage</c> can vary because Aurora DB cluster storage size
        /// adjusts as needed.
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
        /// A list of the Amazon Web Services Identity and Access Management (IAM) roles that
        /// are associated with the DB cluster. IAM roles that are associated with a DB cluster
        /// grant permission for the DB cluster to access other Amazon Web Services on your behalf.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterRole> AssociatedRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<DBClusterRole>() : null;

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
        /// This setting is for Aurora DB clusters and Multi-AZ DB clusters.
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
        /// The time when a stopped DB cluster is restarted automatically.
        /// </para>
        /// </summary>
        public DateTime? AutomaticRestartTime { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticRestartTime property is set.
        /// </summary>
        internal bool IsSetAutomaticRestartTime() => this.AutomaticRestartTime.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The list of Availability Zones (AZs) where instances in the DB cluster can be created.
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
        /// Gets and sets the property BacktrackConsumedChangeRecords. 
        /// <para>
        /// The number of change records stored for Backtrack.
        /// </para>
        /// </summary>
        public long? BacktrackConsumedChangeRecords { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackConsumedChangeRecords property is set.
        /// </summary>
        internal bool IsSetBacktrackConsumedChangeRecords() => this.BacktrackConsumedChangeRecords.HasValue;

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. If this value is set to <c>0</c>, backtracking
        /// is disabled for the DB cluster. Otherwise, backtracking is enabled.
        /// </para>
        /// </summary>
        public long? BacktrackWindow { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackWindow property is set.
        /// </summary>
        internal bool IsSetBacktrackWindow() => this.BacktrackWindow.HasValue;

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
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The current capacity of an Aurora Serverless v1 DB cluster. The capacity is <c>0</c>
        /// (zero) when the cluster is paused.
        /// </para>
        ///  
        /// <para>
        /// For more information about Aurora Serverless v1, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
        /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property CertificateDetails.
        /// </summary>
        public CertificateDetails CertificateDetails { get; set; }

        /// <summary>
        /// Checks to see if the CertificateDetails property is set.
        /// </summary>
        internal bool IsSetCertificateDetails() => this.CertificateDetails != null;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// If present, specifies the name of the character set that this cluster is associated
        /// with.
        /// </para>
        /// </summary>
        public string CharacterSetName { get; set; }

        /// <summary>
        /// Checks to see if the CharacterSetName property is set.
        /// </summary>
        internal bool IsSetCharacterSetName() => this.CharacterSetName != null;

        /// <summary>
        /// Gets and sets the property CloneGroupId. 
        /// <para>
        /// The ID of the clone group with which the DB cluster is associated. For newly created
        /// clusters, the ID is typically null. 
        /// </para>
        ///  
        /// <para>
        /// If you clone a DB cluster when the ID is null, the operation populates the ID value
        /// for the source cluster and the clone because both clusters become part of the same
        /// clone group. Even if you delete the clone cluster, the clone group ID remains for
        /// the lifetime of the source cluster to show that it was used in a cloning operation.
        /// </para>
        ///  
        /// <para>
        /// For PITR, the clone group ID is inherited from the source cluster. For snapshot restore
        /// operations, the clone group ID isn't inherited from the source cluster.
        /// </para>
        /// </summary>
        public string CloneGroupId { get; set; }

        /// <summary>
        /// Checks to see if the CloneGroupId property is set.
        /// </summary>
        internal bool IsSetCloneGroupId() => this.CloneGroupId != null;

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
        /// Gets and sets the property ClusterScalabilityType. 
        /// <para>
        /// The scalability mode of the Aurora DB cluster. When set to <c>limitless</c>, the cluster
        /// operates as an Aurora Limitless Database. When set to <c>standard</c> (the default),
        /// the cluster uses normal DB instance creation.
        /// </para>
        /// </summary>
        public ClusterScalabilityType ClusterScalabilityType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterScalabilityType property is set.
        /// </summary>
        internal bool IsSetClusterScalabilityType() => this.ClusterScalabilityType != null;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Indicates whether tags are copied from the DB cluster to snapshots of the DB cluster.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property CrossAccountClone. 
        /// <para>
        /// Indicates whether the DB cluster is a clone of a DB cluster owned by a different Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        public bool? CrossAccountClone { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountClone property is set.
        /// </summary>
        internal bool IsSetCrossAccountClone() => this.CrossAccountClone.HasValue;

        /// <summary>
        /// Gets and sets the property CustomEndpoints. 
        /// <para>
        /// The custom endpoints associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomEndpoints property is set.
        /// </summary>
        internal bool IsSetCustomEndpoints() => this.CustomEndpoints != null && (this.CustomEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterArn property is set.
        /// </summary>
        internal bool IsSetDBClusterArn() => this.DBClusterArn != null;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The user-supplied identifier for the DB cluster. This identifier is the unique key
        /// that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterInstanceClass. 
        /// <para>
        /// The name of the compute and memory capacity class of the DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public string DBClusterInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBClusterInstanceClass() => this.DBClusterInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBClusterMembers. 
        /// <para>
        /// The list of DB instances that make up the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterMember> DBClusterMembers { get; set; } = AWSConfigs.InitializeCollections ? new List<DBClusterMember>() : null;

        /// <summary>
        /// Checks to see if the DBClusterMembers property is set.
        /// </summary>
        internal bool IsSetDBClusterMembers() => this.DBClusterMembers != null && (this.DBClusterMembers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBClusterOptionGroupMemberships. 
        /// <para>
        /// The list of option group memberships for this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterOptionGroupStatus> DBClusterOptionGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<DBClusterOptionGroupStatus>() : null;

        /// <summary>
        /// Checks to see if the DBClusterOptionGroupMemberships property is set.
        /// </summary>
        internal bool IsSetDBClusterOptionGroupMemberships() => this.DBClusterOptionGroupMemberships != null && (this.DBClusterOptionGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroup. 
        /// <para>
        /// The name of the DB cluster parameter group for the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterParameterGroup property is set.
        /// </summary>
        internal bool IsSetDBClusterParameterGroup() => this.DBClusterParameterGroup != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Information about the subnet group associated with the DB cluster, including the name,
        /// description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroup() => this.DBSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DBSystemId. 
        /// <para>
        /// Reserved for future use.
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
        /// The mode of Database Insights that is enabled for the DB cluster.
        /// </para>
        /// </summary>
        public DatabaseInsightsMode DatabaseInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInsightsMode property is set.
        /// </summary>
        internal bool IsSetDatabaseInsightsMode() => this.DatabaseInsightsMode != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the initial database that was specified for the DB cluster when it was
        /// created, if one was provided. This same name is returned for the life of the DB cluster.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB cluster. This
        /// identifier is found in Amazon Web Services CloudTrail log entries whenever the KMS
        /// key for the DB cluster is accessed.
        /// </para>
        /// </summary>
        public string DbClusterResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterResourceId property is set.
        /// </summary>
        internal bool IsSetDbClusterResourceId() => this.DbClusterResourceId != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the DB cluster has deletion protection enabled. The database can't
        /// be deleted when deletion protection is enabled.
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
        /// The Active Directory Domain membership records associated with the DB cluster.
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
        /// Gets and sets the property EarliestBacktrackTime. 
        /// <para>
        /// The earliest time to which a DB cluster can be backtracked.
        /// </para>
        /// </summary>
        public DateTime? EarliestBacktrackTime { get; set; }

        /// <summary>
        /// Checks to see if the EarliestBacktrackTime property is set.
        /// </summary>
        internal bool IsSetEarliestBacktrackTime() => this.EarliestBacktrackTime.HasValue;

        /// <summary>
        /// Gets and sets the property EarliestRestorableTime. 
        /// <para>
        /// The earliest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? EarliestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the EarliestRestorableTime property is set.
        /// </summary>
        internal bool IsSetEarliestRestorableTime() => this.EarliestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnabledCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that this DB cluster is configured to export to CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        /// Log types vary by DB engine. For information about the log types for each DB engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html">Amazon
        /// RDS Database Log Files</a> in the <i>Amazon Aurora User Guide.</i> 
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
        /// The connection endpoint for the primary instance of the DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine used for this DB cluster.
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
        /// The lifecycle type for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see CreateDBCluster.
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport { get; set; }

        /// <summary>
        /// Checks to see if the EngineLifecycleSupport property is set.
        /// </summary>
        internal bool IsSetEngineLifecycleSupport() => this.EngineLifecycleSupport != null;

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <c>provisioned</c> or <c>serverless</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBCluster.html">
        /// CreateDBCluster</a>.
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
        /// The version of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied global database cluster identifier. This identifier is the
        /// unique key that identifies a global database cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property GlobalWriteForwardingRequested. 
        /// <para>
        /// Indicates whether write forwarding is enabled for a secondary cluster in an Aurora
        /// global database. Because write forwarding takes time to enable, check the value of
        /// <c>GlobalWriteForwardingStatus</c> to confirm that the request has completed before
        /// using the write forwarding feature for this cluster.
        /// </para>
        /// </summary>
        public bool? GlobalWriteForwardingRequested { get; set; }

        /// <summary>
        /// Checks to see if the GlobalWriteForwardingRequested property is set.
        /// </summary>
        internal bool IsSetGlobalWriteForwardingRequested() => this.GlobalWriteForwardingRequested.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalWriteForwardingStatus. 
        /// <para>
        /// The status of write forwarding for a secondary cluster in an Aurora global database.
        /// </para>
        /// </summary>
        public WriteForwardingStatus GlobalWriteForwardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the GlobalWriteForwardingStatus property is set.
        /// </summary>
        internal bool IsSetGlobalWriteForwardingStatus() => this.GlobalWriteForwardingStatus != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property HttpEndpointEnabled. 
        /// <para>
        /// Indicates whether the HTTP endpoint is enabled for an Aurora DB cluster.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API (RDS Data
        /// API) for running SQL queries on the DB cluster. You can also query your database from
        /// inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public bool? HttpEndpointEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpointEnabled property is set.
        /// </summary>
        internal bool IsSetHttpEndpointEnabled() => this.HttpEndpointEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// Indicates whether the mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IAMDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IAMDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIAMDatabaseAuthenticationEnabled() => this.IAMDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IOOptimizedNextAllowedModificationTime. 
        /// <para>
        /// The next time you can modify the DB cluster to use the <c>aurora-iopt1</c> storage
        /// type.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters.
        /// </para>
        /// </summary>
        public DateTime? IOOptimizedNextAllowedModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the IOOptimizedNextAllowedModificationTime property is set.
        /// </summary>
        internal bool IsSetIOOptimizedNextAllowedModificationTime() => this.IOOptimizedNextAllowedModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property InternetAccessGatewayEnabled. 
        /// <para>
        /// Indicates whether the DB cluster has internet-based connectivity enabled through an
        /// internet access gateway.
        /// </para>
        ///  
        /// <para>
        /// This setting is applicable only for Aurora PostgreSQL clusters created through express
        /// configuration.
        /// </para>
        /// </summary>
        public bool? InternetAccessGatewayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InternetAccessGatewayEnabled property is set.
        /// </summary>
        internal bool IsSetInternetAccessGatewayEnabled() => this.InternetAccessGatewayEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The Provisioned IOPS (I/O operations per second) value.
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
        /// If <c>StorageEncrypted</c> is enabled, the Amazon Web Services KMS key identifier
        /// for the encrypted DB cluster.
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
        /// The latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property LimitlessDatabase. 
        /// <para>
        /// The details for Aurora Limitless Database.
        /// </para>
        /// </summary>
        public LimitlessDatabase LimitlessDatabase { get; set; }

        /// <summary>
        /// Checks to see if the LimitlessDatabase property is set.
        /// </summary>
        internal bool IsSetLimitlessDatabase() => this.LimitlessDatabase != null;

        /// <summary>
        /// Gets and sets the property LocalWriteForwardingStatus. 
        /// <para>
        /// Indicates whether an Aurora DB cluster has in-cluster write forwarding enabled, not
        /// enabled, requested, or is in the process of enabling it.
        /// </para>
        /// </summary>
        public LocalWriteForwardingStatus LocalWriteForwardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the LocalWriteForwardingStatus property is set.
        /// </summary>
        internal bool IsSetLocalWriteForwardingStatus() => this.LocalWriteForwardingStatus != null;

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
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon Aurora User
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
        /// The master username for the DB cluster.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for -Aurora DB clusters and Multi-AZ DB clusters.
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
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
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
        /// Indicates whether the DB cluster has instances in multiple Availability Zones.
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
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters.
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
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Information about pending changes to the DB cluster. This information is returned
        /// only when there are pending changes. Specific changes are identified by subelements.
        /// </para>
        /// </summary>
        public ClusterPendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The progress of the operation as a percentage.
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
        /// Indicates whether Performance Insights is enabled for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
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
        ///  
        /// <para>
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
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
        /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the database engine is listening on.
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the DB cluster is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible and you connect from outside of the DB
        /// cluster's virtual private cloud (VPC), its Domain Name System (DNS) endpoint resolves
        /// to the public IP address. When you connect from within the same VPC as the DB cluster,
        /// the endpoint resolves to the private IP address. Access to the DB cluster is ultimately
        /// controlled by the security group it uses. That public access isn't permitted if the
        /// security group assigned to the DB cluster doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster isn't publicly accessible, it is an internal DB cluster with a
        /// DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBCluster</a>.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for non-Aurora Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property RdsCustomClusterConfiguration. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public RdsCustomClusterConfiguration RdsCustomClusterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RdsCustomClusterConfiguration property is set.
        /// </summary>
        internal bool IsSetRdsCustomClusterConfiguration() => this.RdsCustomClusterConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReadReplicaIdentifiers. 
        /// <para>
        /// Contains one or more identifiers of the read replicas associated with this DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadReplicaIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadReplicaIdentifiers property is set.
        /// </summary>
        internal bool IsSetReadReplicaIdentifiers() => this.ReadReplicaIdentifiers != null && (this.ReadReplicaIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The reader endpoint for the DB cluster. The reader endpoint for a DB cluster load-balances
        /// connections across the Aurora Replicas that are available in a DB cluster. As clients
        /// request new connections to the reader endpoint, Aurora distributes the connection
        /// requests among the Aurora Replicas in the DB cluster. This functionality can help
        /// balance your read workload across multiple Aurora Replicas in your DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If a failover occurs, and the Aurora Replica that you are connected to is promoted
        /// to be the primary instance, your connection is dropped. To continue sending your read
        /// workload to other Aurora Replicas in the cluster, you can then reconnect to the reader
        /// endpoint.
        /// </para>
        /// </summary>
        public string ReaderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReaderEndpoint property is set.
        /// </summary>
        internal bool IsSetReaderEndpoint() => this.ReaderEndpoint != null;

        /// <summary>
        /// Gets and sets the property ReplicationSourceIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster if this DB cluster is a read replica.
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSourceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationSourceIdentifier() => this.ReplicationSourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ScalingConfigurationInfo.
        /// </summary>
        public ScalingConfigurationInfo ScalingConfigurationInfo { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfigurationInfo property is set.
        /// </summary>
        internal bool IsSetScalingConfigurationInfo() => this.ScalingConfigurationInfo != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersion. 
        /// <para>
        /// The version of the Aurora Serverless V2 platform used by the DB cluster. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.html">Using
        /// Aurora Serverless v2</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public string ServerlessV2PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2PlatformVersion property is set.
        /// </summary>
        internal bool IsSetServerlessV2PlatformVersion() => this.ServerlessV2PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration.
        /// </summary>
        public ServerlessV2ScalingConfigurationInfo ServerlessV2ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetServerlessV2ScalingConfiguration() => this.ServerlessV2ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this DB cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBClusterStatusInfo> StatusInfos { get; set; } = AWSConfigs.InitializeCollections ? new List<DBClusterStatusInfo>() : null;

        /// <summary>
        /// Checks to see if the StatusInfos property is set.
        /// </summary>
        internal bool IsSetStatusInfos() => this.StatusInfos != null && (this.StatusInfos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB cluster is encrypted with an Amazon Web Services managed
        /// key or a customer managed key.
        /// </para>
        ///  
        /// <para>
        /// If the DB cluster is encrypted with an Amazon Web Services owned key, this value is
        /// <c>false</c> and <c>StorageEncryptionType</c> is <c>sse-rds</c>. In that case, the
        /// data at rest is still encrypted. To determine how the data at rest is protected, use
        /// <c>StorageEncryptionType</c>.
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
        /// The type of encryption used to protect data at rest in the DB cluster. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c> - The DB cluster is not encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-rds</c> - The DB cluster is encrypted using an Amazon Web Services owned KMS
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sse-kms</c> - The DB cluster is encrypted using a customer managed KMS key or
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
        /// The storage throughput for the DB cluster. The throughput is automatically set based
        /// on the IOPS that you provision, and is not configurable.
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
        /// Gets and sets the property UpgradeRolloutOrder. 
        /// <para>
        /// This data type represents the order in which the clusters are upgraded.
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
        /// Gets and sets the property VPCNetworkingEnabled. 
        /// <para>
        /// Indicates whether the DB cluster uses VPC-based networking.
        /// </para>
        ///  
        /// <para>
        /// This setting is applicable only for Aurora PostgreSQL clusters created through express
        /// configuration.
        /// </para>
        /// </summary>
        public bool? VPCNetworkingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the VPCNetworkingEnabled property is set.
        /// </summary>
        internal bool IsSetVPCNetworkingEnabled() => this.VPCNetworkingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The list of VPC security groups that the DB cluster belongs to.
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
