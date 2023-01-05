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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyReplicationGroup operation.
    /// Modifies the settings for a replication group.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/scaling-redis-cluster-mode-enabled.html">Scaling
    /// for Amazon ElastiCache for Redis (cluster mode enabled)</a> in the ElastiCache User
    /// Guide
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyReplicationGroupShardConfiguration.html">ModifyReplicationGroupShardConfiguration</a>
    /// in the ElastiCache API Reference
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// This operation is valid for Redis only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private string _authToken;
        private AuthTokenUpdateStrategyType _authTokenUpdateStrategy;
        private bool? _automaticFailoverEnabled;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _engineVersion;
        private IpDiscovery _ipDiscovery;
        private List<LogDeliveryConfigurationRequest> _logDeliveryConfigurations = new List<LogDeliveryConfigurationRequest>();
        private bool? _multiAZEnabled;
        private string _nodeGroupId;
        private string _notificationTopicArn;
        private string _notificationTopicStatus;
        private string _preferredMaintenanceWindow;
        private string _primaryClusterId;
        private bool? _removeUserGroups;
        private string _replicationGroupDescription;
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private int? _snapshotRetentionLimit;
        private string _snapshottingClusterId;
        private string _snapshotWindow;
        private bool? _transitEncryptionEnabled;
        private TransitEncryptionMode _transitEncryptionMode;
        private List<string> _userGroupIdsToAdd = new List<string>();
        private List<string> _userGroupIdsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <code>true</code>, this parameter causes the modifications in this request and
        /// any pending modifications to be applied, asynchronously and as soon as possible, regardless
        /// of the <code>PreferredMaintenanceWindow</code> setting for the replication group.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, changes to the nodes in the replication group are applied on
        /// the next maintenance reboot, or the next failure reboot, whichever occurs first.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// Reserved parameter. The password used to access a password protected server. This
        /// parameter must be specified with the <code>auth-token-update-strategy </code> parameter.
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
        public string AuthToken
        {
            get { return this._authToken; }
            set { this._authToken = value; }
        }

        // Check to see if AuthToken property is set
        internal bool IsSetAuthToken()
        {
            return this._authToken != null;
        }

        /// <summary>
        /// Gets and sets the property AuthTokenUpdateStrategy. 
        /// <para>
        /// Specifies the strategy to use to update the AUTH token. This parameter must be specified
        /// with the <code>auth-token</code> parameter. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Rotate
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/auth.html">Authenticating
        /// Users with Redis AUTH</a> 
        /// </para>
        /// </summary>
        public AuthTokenUpdateStrategyType AuthTokenUpdateStrategy
        {
            get { return this._authTokenUpdateStrategy; }
            set { this._authTokenUpdateStrategy = value; }
        }

        // Check to see if AuthTokenUpdateStrategy property is set
        internal bool IsSetAuthTokenUpdateStrategy()
        {
            return this._authTokenUpdateStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Determines whether a read replica is automatically promoted to read/write primary
        /// if the existing primary encounters a failure.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool AutomaticFailoverEnabled
        {
            get { return this._automaticFailoverEnabled.GetValueOrDefault(); }
            set { this._automaticFailoverEnabled = value; }
        }

        // Check to see if AutomaticFailoverEnabled property is set
        internal bool IsSetAutomaticFailoverEnabled()
        {
            return this._automaticFailoverEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  If you are running Redis engine version 6.0 or later, set this parameter to yes if
        /// you want to opt-in to the next auto minor version upgrade campaign. This parameter
        /// is disabled for previous versions.  
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// A valid cache node type that you want to scale this replication group to.
        /// </para>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to apply to all of the clusters in this replication
        /// group. This change is asynchronously applied as soon as possible for parameters when
        /// the <code>ApplyImmediately</code> parameter is specified as <code>true</code> for
        /// this request.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this._cacheParameterGroupName; }
            set { this._cacheParameterGroupName = value; }
        }

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this._cacheParameterGroupName != null;
        }

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
        /// Constraints: Must contain no more than 255 alphanumeric characters. Must not be <code>Default</code>.
        /// </para>
        /// </summary>
        public List<string> CacheSecurityGroupNames
        {
            get { return this._cacheSecurityGroupNames; }
            set { this._cacheSecurityGroupNames = value; }
        }

        // Check to see if CacheSecurityGroupNames property is set
        internal bool IsSetCacheSecurityGroupNames()
        {
            return this._cacheSecurityGroupNames != null && this._cacheSecurityGroupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The upgraded version of the cache engine to be run on the clusters in the replication
        /// group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>), but you cannot downgrade to an earlier engine version.
        /// If you want to use an earlier engine version, you must delete the existing replication
        /// group and create it anew with the earlier engine version. 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The network type you choose when modifying a cluster, either <code>ipv4</code> | <code>ipv6</code>.
        /// IPv6 is supported for workloads using Redis engine version 6.2 onward or Memcached
        /// engine version 1.6.6 on all instances built on the <a href="https://aws.amazon.com/ec2/nitro/">Nitro
        /// system</a>.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery
        {
            get { return this._ipDiscovery; }
            set { this._ipDiscovery = value; }
        }

        // Check to see if IpDiscovery property is set
        internal bool IsSetIpDiscovery()
        {
            return this._ipDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// Specifies the destination, format and type of the logs.
        /// </para>
        /// </summary>
        public List<LogDeliveryConfigurationRequest> LogDeliveryConfigurations
        {
            get { return this._logDeliveryConfigurations; }
            set { this._logDeliveryConfigurations = value; }
        }

        // Check to see if LogDeliveryConfigurations property is set
        internal bool IsSetLogDeliveryConfigurations()
        {
            return this._logDeliveryConfigurations != null && this._logDeliveryConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZEnabled. 
        /// <para>
        /// A flag to indicate MultiAZ is enabled.
        /// </para>
        /// </summary>
        public bool MultiAZEnabled
        {
            get { return this._multiAZEnabled.GetValueOrDefault(); }
            set { this._multiAZEnabled = value; }
        }

        // Check to see if MultiAZEnabled property is set
        internal bool IsSetMultiAZEnabled()
        {
            return this._multiAZEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// Deprecated. This parameter is not used.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and is no longer used.")]
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

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
        public string NotificationTopicArn
        {
            get { return this._notificationTopicArn; }
            set { this._notificationTopicArn = value; }
        }

        // Check to see if NotificationTopicArn property is set
        internal bool IsSetNotificationTopicArn()
        {
            return this._notificationTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationTopicStatus. 
        /// <para>
        /// The status of the Amazon SNS notification topic for the replication group. Notifications
        /// are sent only if the status is <code>active</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>active</code> | <code>inactive</code> 
        /// </para>
        /// </summary>
        public string NotificationTopicStatus
        {
            get { return this._notificationTopicStatus; }
            set { this._notificationTopicStatus = value; }
        }

        // Check to see if NotificationTopicStatus property is set
        internal bool IsSetNotificationTopicStatus()
        {
            return this._notificationTopicStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>ddd</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sun</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tue</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>wed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>thu</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fri</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sat</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>sun:23:00-mon:01:30</code> 
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// For replication groups with a single primary, if this parameter is specified, ElastiCache
        /// promotes the specified cluster in the specified replication group to the primary role.
        /// The nodes of all other clusters in the replication group are read replicas.
        /// </para>
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this._primaryClusterId; }
            set { this._primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this._primaryClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveUserGroups. 
        /// <para>
        /// Removes the user group associated with this replication group.
        /// </para>
        /// </summary>
        public bool RemoveUserGroups
        {
            get { return this._removeUserGroups.GetValueOrDefault(); }
            set { this._removeUserGroups = value; }
        }

        // Check to see if RemoveUserGroups property is set
        internal bool IsSetRemoveUserGroups()
        {
            return this._removeUserGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupDescription. 
        /// <para>
        /// A description for the replication group. Maximum length is 255 characters.
        /// </para>
        /// </summary>
        public string ReplicationGroupDescription
        {
            get { return this._replicationGroupDescription; }
            set { this._replicationGroupDescription = value; }
        }

        // Check to see if ReplicationGroupDescription property is set
        internal bool IsSetReplicationGroupDescription()
        {
            return this._replicationGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier of the replication group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
        }

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
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic node group (shard) snapshots
        /// before deleting them. For example, if you set <code>SnapshotRetentionLimit</code>
        /// to 5, a snapshot that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important</b> If the value of SnapshotRetentionLimit is set to zero (0), backups
        /// are turned off.
        /// </para>
        /// </summary>
        public int SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit.GetValueOrDefault(); }
            set { this._snapshotRetentionLimit = value; }
        }

        // Check to see if SnapshotRetentionLimit property is set
        internal bool IsSetSnapshotRetentionLimit()
        {
            return this._snapshotRetentionLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshottingClusterId. 
        /// <para>
        /// The cluster ID that is used as the daily snapshot source for the replication group.
        /// This parameter cannot be set for Redis (cluster mode enabled) replication groups.
        /// </para>
        /// </summary>
        public string SnapshottingClusterId
        {
            get { return this._snapshottingClusterId; }
            set { this._snapshottingClusterId = value; }
        }

        // Check to see if SnapshottingClusterId property is set
        internal bool IsSetSnapshottingClusterId()
        {
            return this._snapshottingClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which ElastiCache begins taking a daily snapshot
        /// of the node group (shard) specified by <code>SnapshottingClusterId</code>.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>05:00-09:00</code> 
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, ElastiCache automatically chooses an appropriate
        /// time range.
        /// </para>
        /// </summary>
        public string SnapshotWindow
        {
            get { return this._snapshotWindow; }
            set { this._snapshotWindow = value; }
        }

        // Check to see if SnapshotWindow property is set
        internal bool IsSetSnapshotWindow()
        {
            return this._snapshotWindow != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true. If you are enabling in-transit
        /// encryption for an existing cluster, you must also set <code>TransitEncryptionMode</code>
        /// to <code>preferred</code>.
        /// </para>
        /// </summary>
        public bool TransitEncryptionEnabled
        {
            get { return this._transitEncryptionEnabled.GetValueOrDefault(); }
            set { this._transitEncryptionEnabled = value; }
        }

        // Check to see if TransitEncryptionEnabled property is set
        internal bool IsSetTransitEncryptionEnabled()
        {
            return this._transitEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionMode. 
        /// <para>
        /// A setting that allows you to migrate your clients to use in-transit encryption, with
        /// no downtime.
        /// </para>
        ///  
        /// <para>
        /// You must set <code>TransitEncryptionEnabled</code> to <code>true</code>, for your
        /// existing cluster, and set <code>TransitEncryptionMode</code> to <code>preferred</code>
        /// in the same request to allow both encrypted and unencrypted connections at the same
        /// time. Once you migrate all your Redis clients to use encrypted connections you can
        /// set the value to <code>required</code> to allow encrypted connections only.
        /// </para>
        ///  
        /// <para>
        /// Setting <code>TransitEncryptionMode</code> to <code>required</code> is a two-step
        /// process that requires you to first set the <code>TransitEncryptionMode</code> to <code>preferred</code>
        /// first, after that you can set <code>TransitEncryptionMode</code> to <code>required</code>.
        /// 
        /// </para>
        /// </summary>
        public TransitEncryptionMode TransitEncryptionMode
        {
            get { return this._transitEncryptionMode; }
            set { this._transitEncryptionMode = value; }
        }

        // Check to see if TransitEncryptionMode property is set
        internal bool IsSetTransitEncryptionMode()
        {
            return this._transitEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroupIdsToAdd. 
        /// <para>
        /// The ID of the user group you are associating with the replication group.
        /// </para>
        /// </summary>
        public List<string> UserGroupIdsToAdd
        {
            get { return this._userGroupIdsToAdd; }
            set { this._userGroupIdsToAdd = value; }
        }

        // Check to see if UserGroupIdsToAdd property is set
        internal bool IsSetUserGroupIdsToAdd()
        {
            return this._userGroupIdsToAdd != null && this._userGroupIdsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserGroupIdsToRemove. 
        /// <para>
        /// The ID of the user group to disassociate from the replication group, meaning the users
        /// in the group no longer can access the replication group.
        /// </para>
        /// </summary>
        public List<string> UserGroupIdsToRemove
        {
            get { return this._userGroupIdsToRemove; }
            set { this._userGroupIdsToRemove = value; }
        }

        // Check to see if UserGroupIdsToRemove property is set
        internal bool IsSetUserGroupIdsToRemove()
        {
            return this._userGroupIdsToRemove != null && this._userGroupIdsToRemove.Count > 0; 
        }

    }
}