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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Contains all of the attributes of a specific Valkey or Redis OSS replication group.
    /// </summary>
    public partial class ReplicationGroup
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the replication group.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// A flag that enables encryption at-rest on the cluster when set to <c>true</c>. In
        /// some cases, encryption at-rest may be enabled even when this value is false. Use <c>StorageEncryptionType</c>
        /// to view the effective encryption state of a cluster.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <c>AtRestEncryptionEnabled</c> after the cluster is
        /// created.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> when using Valkey, <c>false</c> when using Redis OSS
        /// </para>
        /// </summary>
        public bool? AtRestEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AtRestEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetAtRestEncryptionEnabled() => this.AtRestEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AuthTokenEnabled. 
        /// <para>
        /// A flag that enables using an <c>AuthToken</c> (password) when issuing Valkey or Redis
        /// OSS commands.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AuthTokenEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenEnabled property is set.
        /// </summary>
        internal bool IsSetAuthTokenEnabled() => this.AuthTokenEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AuthTokenLastModifiedDate. 
        /// <para>
        /// The date the auth token was last modified
        /// </para>
        /// </summary>
        public DateTime? AuthTokenLastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenLastModifiedDate property is set.
        /// </summary>
        internal bool IsSetAuthTokenLastModifiedDate() => this.AuthTokenLastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// If you are running Valkey 7.2 and above, or Redis OSS engine version 6.0 and above,
        /// set this parameter to yes if you want to opt-in to the next auto minor version upgrade
        /// campaign. This parameter is disabled for previous versions. 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates the status of automatic failover for this Valkey or Redis OSS replication
        /// group.
        /// </para>
        /// </summary>
        public AutomaticFailoverStatus AutomaticFailover { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFailover property is set.
        /// </summary>
        internal bool IsSetAutomaticFailover() => this.AutomaticFailover != null;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The name of the compute and memory capacity node type for each node in the replication
        /// group.
        /// </para>
        /// </summary>
        public string CacheNodeType { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeType property is set.
        /// </summary>
        internal bool IsSetCacheNodeType() => this.CacheNodeType != null;

        /// <summary>
        /// Gets and sets the property ClusterEnabled. 
        /// <para>
        /// A flag indicating whether or not this replication group is cluster enabled; i.e.,
        /// whether its data can be partitioned across multiple shards (API/CLI: node groups).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ClusterEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ClusterEnabled property is set.
        /// </summary>
        internal bool IsSetClusterEnabled() => this.ClusterEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterMode. 
        /// <para>
        /// Enabled or Disabled. To modify cluster mode from Disabled to Enabled, you must first
        /// set the cluster mode to Compatible. Compatible mode allows your Valkey or Redis OSS
        /// clients to connect using both cluster mode enabled and cluster mode disabled. After
        /// you migrate all Valkey or Redis OSS clients to use cluster mode enabled, you can then
        /// complete cluster mode configuration and set the cluster mode to Enabled.
        /// </para>
        /// </summary>
        public ClusterMode ClusterMode { get; set; }

        /// <summary>
        /// Checks to see if the ClusterMode property is set.
        /// </summary>
        internal bool IsSetClusterMode() => this.ClusterMode != null;

        /// <summary>
        /// Gets and sets the property ConfigurationEndpoint. 
        /// <para>
        /// The configuration endpoint for this replication group. Use the configuration endpoint
        /// to connect to this replication group.
        /// </para>
        /// </summary>
        public Endpoint ConfigurationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationEndpoint property is set.
        /// </summary>
        internal bool IsSetConfigurationEndpoint() => this.ConfigurationEndpoint != null;

        /// <summary>
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for replication groups using
        /// the r6gd node type. This parameter must be set to true when using r6gd nodes. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public DataTieringStatus DataTiering { get; set; }

        /// <summary>
        /// Checks to see if the DataTiering property is set.
        /// </summary>
        internal bool IsSetDataTiering() => this.DataTiering != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user supplied description of the replication group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Durability. 
        /// <para>
        /// The durability setting of the replication group. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/durability.html">Durability</a>.
        /// </para>
        /// </summary>
        public Durability Durability { get; set; }

        /// <summary>
        /// Checks to see if the Durability property is set.
        /// </summary>
        internal bool IsSetDurability() => this.Durability != null;

        /// <summary>
        /// Gets and sets the property EffectiveDurability. 
        /// <para>
        /// The effective durability of the replication group. When <c>Durability</c> is set to
        /// <c>default</c>, the service resolves the actual durability based on the engine version,
        /// cluster mode, and other parameters. This field reflects the resolved value. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Durability.Configuring.html">Configuring
        /// Durability</a>.
        /// </para>
        /// </summary>
        public EffectiveDurability EffectiveDurability { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDurability property is set.
        /// </summary>
        internal bool IsSetEffectiveDurability() => this.EffectiveDurability != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine used in a replication group. The options are valkey, memcached or redis.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupInfo. 
        /// <para>
        /// The name of the Global datastore and role of this replication group in the Global
        /// datastore.
        /// </para>
        /// </summary>
        public GlobalReplicationGroupInfo GlobalReplicationGroupInfo { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupInfo property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupInfo() => this.GlobalReplicationGroupInfo != null;

        /// <summary>
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The network type you choose when modifying a cluster, either <c>ipv4</c> | <c>ipv6</c>.
        /// IPv6 is supported for workloads using Valkey 7.2 and above, Redis OSS engine version
        /// 6.2 to 7.1 or Memcached engine version 1.6.6 and above on all instances built on the
        /// <a href="http://aws.amazon.com/ec2/nitro/">Nitro system</a>.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the IpDiscovery property is set.
        /// </summary>
        internal bool IsSetIpDiscovery() => this.IpDiscovery != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the disk in the cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// Returns the destination, format and type of the logs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogDeliveryConfiguration> LogDeliveryConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<LogDeliveryConfiguration>() : null;

        /// <summary>
        /// Checks to see if the LogDeliveryConfigurations property is set.
        /// </summary>
        internal bool IsSetLogDeliveryConfigurations() => this.LogDeliveryConfigurations != null && (this.LogDeliveryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemberClusters. 
        /// <para>
        /// The names of all the cache clusters that are part of this replication group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MemberClusters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemberClusters property is set.
        /// </summary>
        internal bool IsSetMemberClusters() => this.MemberClusters != null && (this.MemberClusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemberClustersOutpostArns. 
        /// <para>
        /// The outpost ARNs of the replication group's member clusters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MemberClustersOutpostArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemberClustersOutpostArns property is set.
        /// </summary>
        internal bool IsSetMemberClustersOutpostArns() => this.MemberClustersOutpostArns != null && (this.MemberClustersOutpostArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// A flag indicating if you have Multi-AZ enabled to enhance fault tolerance. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/AutoFailover.html">Minimizing
        /// Downtime: Multi-AZ</a> 
        /// </para>
        /// </summary>
        public MultiAZStatus MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Must be either <c>ipv4</c> | <c>ipv6</c> | <c>dual_stack</c>. IPv6 is supported for
        /// workloads using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 or Memcached
        /// engine version 1.6.6 and above on all instances built on the <a href="http://aws.amazon.com/ec2/nitro/">Nitro
        /// system</a>.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NodeGroups. 
        /// <para>
        /// A list of node groups in this replication group. For Valkey or Redis OSS (cluster
        /// mode disabled) replication groups, this is a single-element list. For Valkey or Redis
        /// OSS (cluster mode enabled) replication groups, the list contains an entry for each
        /// node group (shard).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeGroup> NodeGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeGroup>() : null;

        /// <summary>
        /// Checks to see if the NodeGroups property is set.
        /// </summary>
        internal bool IsSetNodeGroups() => this.NodeGroups != null && (this.NodeGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A group of settings to be applied to the replication group, either immediately or
        /// during the next maintenance window.
        /// </para>
        /// </summary>
        public ReplicationGroupPendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupCreateTime. 
        /// <para>
        /// The date and time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? ReplicationGroupCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupCreateTime property is set.
        /// </summary>
        internal bool IsSetReplicationGroupCreateTime() => this.ReplicationGroupCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier for the replication group.
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic cluster snapshots before
        /// deleting them. For example, if you set <c>SnapshotRetentionLimit</c> to 5, a snapshot
        /// that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If the value of <c>SnapshotRetentionLimit</c> is set to zero (0), backups are turned
        /// off.
        /// </para>
        ///  </important>
        /// </summary>
        public int? SnapshotRetentionLimit { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionLimit property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionLimit() => this.SnapshotRetentionLimit.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which ElastiCache begins taking a daily snapshot
        /// of your node group (shard).
        /// </para>
        ///  
        /// <para>
        /// Example: <c>05:00-09:00</c> 
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, ElastiCache automatically chooses an appropriate
        /// time range.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <c>Engine</c> parameter is <c>redis</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SnapshotWindow { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWindow property is set.
        /// </summary>
        internal bool IsSetSnapshotWindow() => this.SnapshotWindow != null;

        /// <summary>
        /// Gets and sets the property SnapshottingClusterId. 
        /// <para>
        /// The cluster ID that is used as the daily snapshot source for the replication group.
        /// </para>
        /// </summary>
        public string SnapshottingClusterId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshottingClusterId property is set.
        /// </summary>
        internal bool IsSetSnapshottingClusterId() => this.SnapshottingClusterId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - <c>creating</c>, <c>available</c>, <c>modifying</c>,
        /// <c>deleting</c>, <c>create-failed</c>, <c>snapshotting</c>.
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
        /// Indicates the type of encryption for data stored at rest in the replication group.
        /// The value is <c>none</c> if at-rest encryption is not enabled, <c>sse-elasticache</c>
        /// if an ElastiCache service-managed key is used, or <c>sse-kms</c> if a customer-managed
        /// KMS key is used.
        /// </para>
        /// </summary>
        public StorageEncryptionType StorageEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncryptionType property is set.
        /// </summary>
        internal bool IsSetStorageEncryptionType() => this.StorageEncryptionType != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using Redis OSS version <c>3.2.6</c>, <c>4.x</c> or later.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? TransitEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionEnabled() => this.TransitEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TransitEncryptionMode. 
        /// <para>
        /// A setting that allows you to migrate your clients to use in-transit encryption, with
        /// no downtime.
        /// </para>
        /// </summary>
        public TransitEncryptionMode TransitEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionMode property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionMode() => this.TransitEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property UserGroupIds. 
        /// <para>
        /// The ID of the user group associated to the replication group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserGroupIds property is set.
        /// </summary>
        internal bool IsSetUserGroupIds() => this.UserGroupIds != null && (this.UserGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
