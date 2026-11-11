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
    /// Container for the parameters to the ModifyReplicationGroup operation. Modifies the
    /// settings for a replication group. This is limited to Valkey and Redis OSS 7 and above.
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/scaling-redis-cluster-mode-enabled.html">Scaling
    /// for Valkey or Redis OSS (cluster mode enabled)</a> in the ElastiCache User Guide </para>
    /// </li> <li> <para> <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyReplicationGroupShardConfiguration.html">ModifyReplicationGroupShardConfiguration</a>
    /// in the ElastiCache API Reference </para> </li> </ul> <note> <para> This operation
    /// is valid for Valkey or Redis OSS only. </para> </note>
    /// </summary>
    public partial class ModifyReplicationGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <c>true</c>, this parameter causes the modifications in this request and any pending
        /// modifications to be applied, asynchronously and as soon as possible, regardless of
        /// the <c>PreferredMaintenanceWindow</c> setting for the replication group.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, changes to the nodes in the replication group are applied on the
        /// next maintenance reboot, or the next failure reboot, whichever occurs first.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true</c> | <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// Reserved parameter. The password used to access a password protected server. This
        /// parameter must be specified with the <c>auth-token-update-strategy </c> parameter.
        /// Password constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be only printable ASCII characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 16 characters and no more than 128 characters in length
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot contain any of the following characters: '/', '"', or '@', '%'
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see AUTH password at <a href="http://redis.io/commands/AUTH">AUTH</a>.
        /// </para>
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenUpdateStrategy. 
        /// <para>
        /// Specifies the strategy to use to update the AUTH token. This parameter must be specified
        /// with the <c>auth-token</c> parameter. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ROTATE - default, if no update strategy is provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SET - allowed only after ROTATE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE - allowed only when transitioning to RBAC
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/auth.html">Authenticating
        /// Users with AUTH</a> 
        /// </para>
        /// </summary>
        public AuthTokenUpdateStrategyType AuthTokenUpdateStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenUpdateStrategy property is set.
        /// </summary>
        internal bool IsSetAuthTokenUpdateStrategy() => this.AuthTokenUpdateStrategy != null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  If you are running Valkey or Redis OSS engine version 6.0 or later, set this parameter
        /// to yes if you want to opt-in to the next auto minor version upgrade campaign. This
        /// parameter is disabled for previous versions. 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Determines whether a read replica is automatically promoted to read/write primary
        /// if the existing primary encounters a failure.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AutomaticFailoverEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFailoverEnabled property is set.
        /// </summary>
        internal bool IsSetAutomaticFailoverEnabled() => this.AutomaticFailoverEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// A valid cache node type that you want to scale this replication group to.
        /// </para>
        /// </summary>
        public string CacheNodeType { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeType property is set.
        /// </summary>
        internal bool IsSetCacheNodeType() => this.CacheNodeType != null;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to apply to all of the clusters in this replication
        /// group. This change is asynchronously applied as soon as possible for parameters when
        /// the <c>ApplyImmediately</c> parameter is specified as <c>true</c> for this request.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupName property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupName() => this.CacheParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupNames. 
        /// <para>
        /// A list of cache security group names to authorize for the clusters in this replication
        /// group. This change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with replication group containing clusters running
        /// outside of an Amazon Virtual Private Cloud (Amazon VPC).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters. Must not be <c>Default</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CacheSecurityGroupNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CacheSecurityGroupNames property is set.
        /// </summary>
        internal bool IsSetCacheSecurityGroupNames() => this.CacheSecurityGroupNames != null && (this.CacheSecurityGroupNames.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Durability. 
        /// <para>
        /// Specifies the durability setting for the replication group. Use this parameter to
        /// change the durability mode of an existing replication group, for example from <c>sync</c>
        /// to <c>async</c> or vice versa. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/durability.html">Durability</a>.
        /// </para>
        /// </summary>
        public Durability Durability { get; set; }

        /// <summary>
        /// Checks to see if the Durability property is set.
        /// </summary>
        internal bool IsSetDurability() => this.Durability != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed in a replication group message. The options are valkey,
        /// memcached or redis.
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
        /// The upgraded version of the cache engine to be run on the clusters in the replication
        /// group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>), but you cannot downgrade to an earlier engine version.
        /// If you want to use an earlier engine version, you must delete the existing replication
        /// group and create it anew with the earlier engine version. 
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The network type you choose when modifying a cluster, either <c>ipv4</c> | <c>ipv6</c>.
        /// IPv6 is supported for workloads using Valkey 7.2 and above, Redis OSS engine version
        /// 6.2 to 7.1 and Memcached engine version 1.6.6 and above on all instances built on
        /// the <a href="http://aws.amazon.com/ec2/nitro/">Nitro system</a>.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the IpDiscovery property is set.
        /// </summary>
        internal bool IsSetIpDiscovery() => this.IpDiscovery != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// Specifies the destination, format and type of the logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogDeliveryConfigurationRequest> LogDeliveryConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<LogDeliveryConfigurationRequest>() : null;

        /// <summary>
        /// Checks to see if the LogDeliveryConfigurations property is set.
        /// </summary>
        internal bool IsSetLogDeliveryConfigurations() => this.LogDeliveryConfigurations != null && (this.LogDeliveryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiAZEnabled. 
        /// <para>
        /// A flag to indicate MultiAZ is enabled.
        /// </para>
        /// </summary>
        public bool? MultiAZEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZEnabled property is set.
        /// </summary>
        internal bool IsSetMultiAZEnabled() => this.MultiAZEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// Deprecated. This parameter is not used.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and is no longer used.")]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupId property is set.
        /// </summary>
        internal bool IsSetNodeGroupId() => this.NodeGroupId != null;

        /// <summary>
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which notifications are
        /// sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon SNS topic owner must be same as the replication group owner. 
        /// </para>
        ///  </note>
        /// </summary>
        public string NotificationTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTopicArn property is set.
        /// </summary>
        internal bool IsSetNotificationTopicArn() => this.NotificationTopicArn != null;

        /// <summary>
        /// Gets and sets the property NotificationTopicStatus. 
        /// <para>
        /// The status of the Amazon SNS notification topic for the replication group. Notifications
        /// are sent only if the status is <c>active</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>active</c> | <c>inactive</c> 
        /// </para>
        /// </summary>
        public string NotificationTopicStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTopicStatus property is set.
        /// </summary>
        internal bool IsSetNotificationTopicStatus() => this.NotificationTopicStatus != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>ddd</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sun</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>thu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fri</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sat</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>sun:23:00-mon:01:30</c> 
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// For replication groups with a single primary, if this parameter is specified, ElastiCache
        /// promotes the specified cluster in the specified replication group to the primary role.
        /// The nodes of all other clusters in the replication group are read replicas.
        /// </para>
        /// </summary>
        public string PrimaryClusterId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryClusterId property is set.
        /// </summary>
        internal bool IsSetPrimaryClusterId() => this.PrimaryClusterId != null;

        /// <summary>
        /// Gets and sets the property RemoveUserGroups. 
        /// <para>
        /// Removes the user group associated with this replication group.
        /// </para>
        /// </summary>
        public bool? RemoveUserGroups { get; set; }

        /// <summary>
        /// Checks to see if the RemoveUserGroups property is set.
        /// </summary>
        internal bool IsSetRemoveUserGroups() => this.RemoveUserGroups.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationGroupDescription. 
        /// <para>
        /// A description for the replication group. Maximum length is 255 characters.
        /// </para>
        /// </summary>
        public string ReplicationGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupDescription property is set.
        /// </summary>
        internal bool IsSetReplicationGroupDescription() => this.ReplicationGroupDescription != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier of the replication group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specifies the VPC Security Groups associated with the clusters in the replication
        /// group.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with replication group containing clusters running
        /// in an Amazon Virtual Private Cloud (Amazon VPC).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic node group (shard) snapshots
        /// before deleting them. For example, if you set <c>SnapshotRetentionLimit</c> to 5,
        /// a snapshot that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important</b> If the value of SnapshotRetentionLimit is set to zero (0), backups
        /// are turned off.
        /// </para>
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
        /// of the node group (shard) specified by <c>SnapshottingClusterId</c>.
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
        /// This parameter cannot be set for Valkey or Redis OSS (cluster mode enabled) replication
        /// groups.
        /// </para>
        /// </summary>
        public string SnapshottingClusterId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshottingClusterId property is set.
        /// </summary>
        internal bool IsSetSnapshottingClusterId() => this.SnapshottingClusterId != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true. If you are enabling in-transit
        /// encryption for an existing cluster, you must also set <c>TransitEncryptionMode</c>
        /// to <c>preferred</c>.
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
        ///  
        /// <para>
        /// You must set <c>TransitEncryptionEnabled</c> to <c>true</c>, for your existing cluster,
        /// and set <c>TransitEncryptionMode</c> to <c>preferred</c> in the same request to allow
        /// both encrypted and unencrypted connections at the same time. Once you migrate all
        /// your Valkey or Redis OSS clients to use encrypted connections you can set the value
        /// to <c>required</c> to allow encrypted connections only.
        /// </para>
        ///  
        /// <para>
        /// Setting <c>TransitEncryptionMode</c> to <c>required</c> is a two-step process that
        /// requires you to first set the <c>TransitEncryptionMode</c> to <c>preferred</c>, after
        /// that you can set <c>TransitEncryptionMode</c> to <c>required</c>. 
        /// </para>
        /// </summary>
        public TransitEncryptionMode TransitEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionMode property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionMode() => this.TransitEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property UserGroupIdsToAdd. 
        /// <para>
        /// The ID of the user group you are associating with the replication group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroupIdsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserGroupIdsToAdd property is set.
        /// </summary>
        internal bool IsSetUserGroupIdsToAdd() => this.UserGroupIdsToAdd != null && (this.UserGroupIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserGroupIdsToRemove. 
        /// <para>
        /// The ID of the user group to disassociate from the replication group, meaning the users
        /// in the group no longer can access the replication group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroupIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserGroupIdsToRemove property is set.
        /// </summary>
        internal bool IsSetUserGroupIdsToRemove() => this.UserGroupIdsToRemove != null && (this.UserGroupIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
