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
    /// Container for the parameters to the ModifyCacheCluster operation. Modifies the settings
    /// for a cluster. You can use this operation to change one or more cluster configuration
    /// parameters by specifying the parameters and the new values.
    /// </summary>
    public partial class ModifyCacheClusterRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ModifyCacheClusterRequest() { }

        /// <summary>
        /// Instantiates ModifyCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The cluster identifier. This value is stored as a lowercase string.</param>
        public ModifyCacheClusterRequest(string cacheClusterId)
        {
            this.CacheClusterId = cacheClusterId;
        }

        /// <summary>
        /// Gets and sets the property AZMode. 
        /// <para>
        /// Specifies whether the new nodes in this Memcached cluster are all created in a single
        /// Availability Zone or created across multiple Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>single-az</c> | <c>cross-az</c>.
        /// </para>
        ///  
        /// <para>
        /// This option is only supported for Memcached clusters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot specify <c>single-az</c> if the Memcached cluster already has cache nodes
        /// in different Availability Zones. If <c>cross-az</c> is specified, existing Memcached
        /// nodes remain in their current Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Only newly created nodes are located in different Availability Zones. 
        /// </para>
        ///  </note>
        /// </summary>
        public AZMode AZMode { get; set; }

        /// <summary>
        /// Checks to see if the AZMode property is set.
        /// </summary>
        internal bool IsSetAZMode() => this.AZMode != null;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <c>true</c>, this parameter causes the modifications in this request and any pending
        /// modifications to be applied, asynchronously and as soon as possible, regardless of
        /// the <c>PreferredMaintenanceWindow</c> setting for the cluster.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, changes to the cluster are applied on the next maintenance reboot,
        /// or the next failure reboot, whichever occurs first.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you perform a <c>ModifyCacheCluster</c> before a pending modification is applied,
        /// the pending modification is replaced by the newer modification. However, a pending
        /// node-count increase on Memcached clusters cannot be superseded by a request to add
        /// fewer nodes. To change a pending node addition, first cancel it by setting <c>NumCacheNodes</c>
        /// equal to the current number of nodes in the cluster, then submit the new request.
        /// See the <c>NumCacheNodes</c> parameter for details on node scaling behavior.
        /// </para>
        ///  </important> 
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
        /// parameter must be specified with the <c>auth-token-update</c> parameter. Password
        /// constraints:
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
        ///  If you are running Valkey 7.2 or Redis OSS engine version 6.0 or later, set this
        /// parameter to yes to opt-in to the next auto minor version upgrade campaign. This parameter
        /// is disabled for previous versions. 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cluster identifier. This value is stored as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheNodeIdsToRemove. 
        /// <para>
        /// A list of cache node IDs to be removed. A node ID is a numeric identifier (0001, 0002,
        /// etc.). This parameter is only valid when <c>NumCacheNodes</c> is less than the existing
        /// number of cache nodes. The number of cache node IDs supplied in this parameter must
        /// match the difference between the existing number of cache nodes in the cluster or
        /// pending cache nodes, whichever is greater, and the value of <c>NumCacheNodes</c> in
        /// the request.
        /// </para>
        ///  
        /// <para>
        /// For example: If you have 3 active cache nodes, 7 pending cache nodes, and the number
        /// of cache nodes in this <c>ModifyCacheCluster</c> call is 5, you must list 2 (7 - 5)
        /// cache node IDs to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CacheNodeIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CacheNodeIdsToRemove property is set.
        /// </summary>
        internal bool IsSetCacheNodeIdsToRemove() => this.CacheNodeIdsToRemove != null && (this.CacheNodeIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// A valid cache node type that you want to scale this cluster up to.
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
        /// The name of the cache parameter group to apply to this cluster. This change is asynchronously
        /// applied as soon as possible for parameters when the <c>ApplyImmediately</c> parameter
        /// is specified as <c>true</c> for this request.
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
        /// A list of cache security group names to authorize on this cluster. This change is
        /// asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only with clusters that are created outside of an Amazon
        /// Virtual Private Cloud (Amazon VPC).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters. Must not be "Default".
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine type used by the cache cluster. The options are valkey, memcached or redis.
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
        /// The upgraded version of the cache engine to be run on the cache nodes.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>), but you cannot downgrade to an earlier engine version.
        /// If you want to use an earlier engine version, you must delete the existing cluster
        /// and create it anew with the earlier engine version. 
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
        /// Gets and sets the property NewAvailabilityZones. <note> 
        /// <para>
        /// This option is only supported on Memcached clusters.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of Availability Zones where the new Memcached cache nodes are created.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only valid when <c>NumCacheNodes</c> in the request is greater than
        /// the sum of the number of active cache nodes and the number of cache nodes pending
        /// creation (which may be zero). The number of Availability Zones supplied in this list
        /// must match the cache nodes being added in this request.
        /// </para>
        ///  
        /// <para>
        /// Scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Scenario 1:</b> You have 3 active nodes and wish to add 2 nodes. Specify <c>NumCacheNodes=5</c>
        /// (3 + 2) and optionally specify two Availability Zones for the two new nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scenario 2:</b> You have 3 active nodes and 2 nodes pending creation (from the
        /// scenario 1 call) and want to add 1 more node. Specify <c>NumCacheNodes=6</c> ((3 +
        /// 2) + 1) and optionally specify an Availability Zone for the new node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scenario 3:</b> You want to cancel all pending operations. Specify <c>NumCacheNodes=3</c>
        /// to cancel all pending operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Availability Zone placement of nodes pending creation cannot be modified. If you
        /// wish to cancel any nodes pending creation, add 0 nodes by setting <c>NumCacheNodes</c>
        /// to the number of current nodes.
        /// </para>
        ///  
        /// <para>
        /// If <c>cross-az</c> is specified, existing Memcached nodes remain in their current
        /// Availability Zone. Only newly created nodes can be located in different Availability
        /// Zones. For guidance on how to move existing Memcached nodes to different Availability
        /// Zones, see the <b>Availability Zone Considerations</b> section of <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html">Cache
        /// Node Considerations for Memcached</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Impact of new add/remove requests upon pending requests</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scenario-1
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Action: Delete
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New Request: Delete
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Result: The new delete, pending or immediate, replaces the pending delete.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Scenario-2
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Action: Delete
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New Request: Create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Result: The new create, pending or immediate, replaces the pending delete.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Scenario-3
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Action: Create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New Request: Delete
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Result: The new delete, pending or immediate, replaces the pending create.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Scenario-4
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending Action: Create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New Request: Create
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Result: The new create is added to the pending create.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <b>Important:</b> If the new create request is <b>Apply Immediately - Yes</b>, all
        /// creates are performed immediately. If the new create request is <b>Apply Immediately
        /// - No</b>, all creates are pending.
        /// </para>
        ///  </important> </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NewAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NewAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetNewAvailabilityZones() => this.NewAvailabilityZones != null && (this.NewAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which notifications are
        /// sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon SNS topic owner must be same as the cluster owner.
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
        /// The status of the Amazon SNS notification topic. Notifications are sent only if the
        /// status is <c>active</c>.
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
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes that the cluster should have. If the value for <c>NumCacheNodes</c>
        /// is greater than the sum of the number of current cache nodes and the number of cache
        /// nodes pending creation (which may be zero), more nodes are added. If the value is
        /// less than the number of existing cache nodes, nodes are removed. If the value is equal
        /// to the number of current cache nodes, any pending add or remove requests are canceled.
        /// </para>
        ///  
        /// <para>
        /// If you are removing cache nodes, you must use the <c>CacheNodeIdsToRemove</c> parameter
        /// to provide the IDs of the specific cache nodes to remove.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters running
        /// Memcached, this value must be between 1 and 40.
        /// </para>
        ///  <note> 
        /// <para>
        /// Adding or removing Memcached cache nodes can be applied immediately or as a pending
        /// operation (see <c>ApplyImmediately</c>).
        /// </para>
        ///  
        /// <para>
        /// A pending operation to modify the number of cache nodes in a cluster during its maintenance
        /// window, whether by adding or removing nodes in accordance with the scale out architecture,
        /// is not queued. The customer's latest request to add or remove nodes to the cluster
        /// overrides any previous pending operations to modify the number of cache nodes in the
        /// cluster. For example, a request to remove 2 nodes would override a previous pending
        /// operation to remove 3 nodes. Similarly, a request to add 2 nodes would override a
        /// previous pending operation to remove 3 nodes and vice versa. As Memcached cache nodes
        /// may now be provisioned in different Availability Zones with flexible cache node placement,
        /// a request to add nodes does not automatically override a previous pending operation
        /// to add nodes. The customer can modify the previous pending operation to add more nodes
        /// or explicitly cancel the pending request and retry the new request. To cancel pending
        /// operations to modify the number of cache nodes in a cluster, use the <c>ModifyCacheCluster</c>
        /// request and set <c>NumCacheNodes</c> equal to the number of cache nodes currently
        /// in the cluster.
        /// </para>
        ///  </note>
        /// </summary>
        public int? NumCacheNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumCacheNodes property is set.
        /// </summary>
        internal bool IsSetNumCacheNodes() => this.NumCacheNodes.HasValue;

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
        /// Gets and sets the property ScaleConfig. 
        /// <para>
        /// Configures horizontal or vertical scaling for Memcached clusters, specifying the scaling
        /// percentage and interval.
        /// </para>
        /// </summary>
        public ScaleConfig ScaleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScaleConfig property is set.
        /// </summary>
        internal bool IsSetScaleConfig() => this.ScaleConfig != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specifies the VPC Security Groups associated with the cluster.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with clusters that are created in an Amazon Virtual
        /// Private Cloud (Amazon VPC).
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
        /// The number of days for which ElastiCache retains automatic cluster snapshots before
        /// deleting them. For example, if you set <c>SnapshotRetentionLimit</c> to 5, a snapshot
        /// that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the value of <c>SnapshotRetentionLimit</c> is set to zero (0), backups are turned
        /// off.
        /// </para>
        ///  </note>
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
        /// of your cluster. 
        /// </para>
        /// </summary>
        public string SnapshotWindow { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWindow property is set.
        /// </summary>
        internal bool IsSetSnapshotWindow() => this.SnapshotWindow != null;
    }
}
