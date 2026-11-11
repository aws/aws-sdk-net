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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about a cluster.
    /// </summary>
    public partial class DBCluster
    {
        /// <summary>
        /// Gets and sets the property AssociatedRoles. 
        /// <para>
        /// Provides a list of the Identity and Access Management (IAM) roles that are associated
        /// with the cluster. (IAM) roles that are associated with a cluster grant permission
        /// for the cluster to access other Amazon Web Services services on your behalf.
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of Amazon EC2 Availability Zones that instances in the cluster can
        /// be created in.
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
        /// Specifies the number of days for which automatic snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

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
        /// Specifies the time when the cluster was created, in Universal Coordinated Time (UTC).
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
        /// Specifies whether to copy all tags from the DB cluster to snapshots of the DB cluster.
        /// The default is not to copy them.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cluster.
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
        /// Contains a user-supplied cluster identifier. This identifier is the unique key that
        /// identifies a cluster.
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
        /// Provides the list of instances that make up the cluster.
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
        /// Gets and sets the property DBClusterParameterGroup. 
        /// <para>
        /// Specifies the name of the cluster parameter group for the cluster.
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
        /// Specifies information on the subnet group that is associated with the cluster, including
        /// the name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroup { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroup property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroup() => this.DBSubnetGroup != null;

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the cluster. This
        /// identifier is found in CloudTrail log entries whenever the KMS key for the cluster
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
        /// Specifies whether this cluster can be deleted. If <c>DeletionProtection</c> is enabled,
        /// the cluster cannot be deleted unless it is modified and <c>DeletionProtection</c>
        /// is disabled. <c>DeletionProtection</c> protects clusters from being accidentally deleted.
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
        /// A list of log types that this cluster is configured to export to Amazon CloudWatch
        /// Logs.
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
        /// Specifies the connection endpoint for the primary instance of the cluster.
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
        /// Provides the name of the database engine to be used for this cluster.
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
        /// Gets and sets the property IOOptimizedNextAllowedModificationTime. 
        /// <para>
        /// The next time you can modify the Amazon DocumentDB cluster to use the iopt1 storage
        /// type.
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
        /// If <c>StorageEncrypted</c> is <c>true</c>, the KMS key identifier for the encrypted
        /// cluster.
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
        /// Gets and sets the property MasterUserSecret. 
        /// <para>
        /// The secret managed by Amazon DocumentDB in Amazon Web Services Secrets Manager for
        /// the master user password.
        /// </para>
        /// </summary>
        public ClusterMasterUserSecret MasterUserSecret { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserSecret property is set.
        /// </summary>
        internal bool IsSetMasterUserSecret() => this.MasterUserSecret != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Contains the master user name for the cluster.
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
        /// Specifies whether the cluster has instances in multiple Availability Zones.
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
        /// The network type of the cluster.
        /// </para>
        ///  
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/vpc-clusters.html">DocumentDB
        /// clusters in a VPC</a> in the Amazon DocumentDB Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IPV4</c> | <c>DUAL</c> 
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

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
        /// Contains one or more identifiers of the secondary clusters that are associated with
        /// this cluster.
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
        /// The reader endpoint for the cluster. The reader endpoint for a cluster load balances
        /// connections across the Amazon DocumentDB replicas that are available in a cluster.
        /// As clients request new connections to the reader endpoint, Amazon DocumentDB distributes
        /// the connection requests among the Amazon DocumentDB replicas in the cluster. This
        /// functionality can help balance your read workload across multiple Amazon DocumentDB
        /// replicas in your cluster. 
        /// </para>
        ///  
        /// <para>
        /// If a failover occurs, and the Amazon DocumentDB replica that you are connected to
        /// is promoted to be the primary instance, your connection is dropped. To continue sending
        /// your read workload to other Amazon DocumentDB replicas in the cluster, you can then
        /// reconnect to the reader endpoint.
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
        /// Contains the identifier of the source cluster if this cluster is a secondary cluster.
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationSourceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationSourceIdentifier() => this.ReplicationSourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersion. 
        /// <para>
        /// The version of the Amazon DocumentDB Serverless platform used by the cluster.
        /// </para>
        /// </summary>
        public string ServerlessV2PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessV2PlatformVersion property is set.
        /// </summary>
        internal bool IsSetServerlessV2PlatformVersion() => this.ServerlessV2PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration. 
        /// <para>
        /// The scaling configuration of an Amazon DocumentDB Serverless cluster.
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
        /// Specifies the current state of this cluster.
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
        /// Specifies whether the cluster is encrypted.
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
        /// Storage type associated with your cluster
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Amazon DocumentDB clusters, see Cluster storage
        /// configurations in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for storage type - <c>standard | iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>standard </c> 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Provides a list of virtual private cloud (VPC) security groups that the cluster belongs
        /// to.
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
