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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details of an Amazon Neptune DB cluster.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBClusters</a>.
    /// </para>
    /// </summary>
    public partial class DBCluster
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        ///  <c>AllocatedStorage</c> always returns 1, because Neptune DB cluster storage size
        /// is not fixed, but instead automatically adjusts as needed.
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
        /// Provides a list of the Amazon Identity and Access Management (IAM) roles that are
        /// associated with the DB cluster. IAM roles that are associated with a DB cluster grant
        /// permission for the DB cluster to access other Amazon services on your behalf.
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
        /// Gets and sets the property AutomaticRestartTime. 
        /// <para>
        /// Time at which the DB cluster will be automatically restarted.
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
        /// Provides the list of EC2 Availability Zones that instances in the DB cluster can be
        /// created in.
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// Specifies the number of days for which automatic DB snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// Not supported by Neptune.
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
        /// Identifies the clone group to which the DB cluster is associated.
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
        /// Specifies the time when the DB cluster was created, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        ///  <i>If set to <c>true</c>, tags are copied to any snapshot of the DB cluster that
        /// is created.</i> 
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
        /// If set to <c>true</c>, the DB cluster can be cloned across accounts.
        /// </para>
        /// </summary>
        public bool? CrossAccountClone { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountClone property is set.
        /// </summary>
        internal bool IsSetCrossAccountClone() => this.CrossAccountClone.HasValue;

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
        /// Contains a user-supplied DB cluster identifier. This identifier is the unique key
        /// that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterMembers. 
        /// <para>
        /// Provides the list of instances that make up the DB cluster.
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
        /// Not supported by Neptune.
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
        /// Specifies the name of the DB cluster parameter group for the DB cluster.
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
        /// Specifies information on the subnet group associated with the DB cluster, including
        /// the name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroup() => this.DBSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Contains the name of the initial database of this DB cluster that was provided at
        /// create time, if one was specified when the DB cluster was created. This same name
        /// is returned for the life of the DB cluster.
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
        /// The Amazon Region-unique, immutable identifier for the DB cluster. This identifier
        /// is found in Amazon CloudTrail log entries whenever the Amazon KMS key for the DB cluster
        /// is accessed.
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
        /// Indicates whether or not the DB cluster has deletion protection enabled. The database
        /// can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property EarliestRestorableTime. 
        /// <para>
        /// Specifies the earliest time to which a database can be restored with point-in-time
        /// restore.
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
        /// A list of the log types that this DB cluster is configured to export to CloudWatch
        /// Logs. Valid log types are: <c>audit</c> (to publish audit logs to CloudWatch) and
        /// slowquery (to publish slow-query logs to CloudWatch). See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/cloudwatch-logs.html">Publishing
        /// Neptune logs to Amazon CloudWatch logs</a>.
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
        /// Specifies the connection endpoint for the primary instance of the DB cluster.
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
        /// Provides the name of the database engine to be used for this DB cluster.
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
        /// Indicates the database engine version.
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
        /// unique key that identifies a global database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specifies the ID that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property IAMDatabaseAuthenticationEnabled. 
        /// <para>
        /// True if mapping of Amazon Identity and Access Management (IAM) accounts to database
        /// accounts is enabled, and otherwise false.
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
        /// The next time you can modify the DB cluster to use the <c>iopt1</c> storage type.
        /// </para>
        /// </summary>
        public DateTime? IOOptimizedNextAllowedModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the IOOptimizedNextAllowedModificationTime property is set.
        /// </summary>
        internal bool IsSetIOOptimizedNextAllowedModificationTime() => this.IOOptimizedNextAllowedModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>StorageEncrypted</c> is true, the Amazon KMS key identifier for the encrypted
        /// DB cluster.
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
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the DB cluster has instances in multiple Availability Zones.
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
        /// The network type of the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>IPV4</c> </b> – The DB cluster uses only IPv4 addresses for communication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DUAL</c> </b> – The DB cluster uses both IPv4 and IPv6 addresses for communication.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// This data type is used as a response element in the <c>ModifyDBCluster</c> operation
        /// and contains changes that will be applied during the next maintenance window.
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
        /// Specifies the progress of the operation as a percentage.
        /// </para>
        /// </summary>
        public string PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine is listening on.
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
        /// Specifies the daily time range during which automated backups are created if automated
        /// backups are enabled, as determined by the <c>BackupRetentionPeriod</c>.
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
        /// Specifies the weekly time range during which system maintenance can occur, in Universal
        /// Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property ReadReplicaIdentifiers. 
        /// <para>
        /// Contains one or more identifiers of the Read Replicas associated with this DB cluster.
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
        /// connections across the Read Replicas that are available in a DB cluster. As clients
        /// request new connections to the reader endpoint, Neptune distributes the connection
        /// requests among the Read Replicas in the DB cluster. This functionality can help balance
        /// your read workload across multiple Read Replicas in your DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If a failover occurs, and the Read Replica that you are connected to is promoted to
        /// be the primary instance, your connection is dropped. To continue sending your read
        /// workload to other Read Replicas in the cluster, you can then reconnect to the reader
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
        /// Not supported by Neptune.
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSourceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationSourceIdentifier() => this.ReplicationSourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// Shows the scaling configuration for a Neptune Serverless DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-serverless-using.html">Using
        /// Amazon Neptune Serverless</a> in the <i>Amazon Neptune User Guide</i>.
        /// </para>
        /// </summary>
        public ServerlessV2ScalingConfigurationInfo ServerlessV2ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetServerlessV2ScalingConfiguration() => this.ServerlessV2ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current state of this DB cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type used by the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>standard</c> </b> – ( <i>the default</i> ) Provides cost-effective database
        /// storage for applications with moderate to small I/O usage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>iopt1</c> </b> – Enables <a href="https://docs.aws.amazon.com/neptune/latest/userguide/storage-types.html#provisioned-iops-storage">I/O-Optimized
        /// storage</a> that's designed to meet the needs of I/O-intensive graph workloads that
        /// require predictable pricing with low I/O latency and consistent I/O throughput.
        /// </para>
        ///  
        /// <para>
        /// Neptune I/O-Optimized storage is only available starting with engine release 1.3.0.0.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Provides a list of VPC security groups that the DB cluster belongs to.
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
