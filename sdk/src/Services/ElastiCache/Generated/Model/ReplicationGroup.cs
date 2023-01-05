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
    /// Contains all of the attributes of a specific Redis replication group.
    /// </summary>
    public partial class ReplicationGroup
    {
        private string _arn;
        private bool? _atRestEncryptionEnabled;
        private bool? _authTokenEnabled;
        private DateTime? _authTokenLastModifiedDate;
        private AutomaticFailoverStatus _automaticFailover;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheNodeType;
        private bool? _clusterEnabled;
        private Endpoint _configurationEndpoint;
        private DataTieringStatus _dataTiering;
        private string _description;
        private GlobalReplicationGroupInfo _globalReplicationGroupInfo;
        private IpDiscovery _ipDiscovery;
        private string _kmsKeyId;
        private List<LogDeliveryConfiguration> _logDeliveryConfigurations = new List<LogDeliveryConfiguration>();
        private List<string> _memberClusters = new List<string>();
        private List<string> _memberClustersOutpostArns = new List<string>();
        private MultiAZStatus _multiAZ;
        private NetworkType _networkType;
        private List<NodeGroup> _nodeGroups = new List<NodeGroup>();
        private ReplicationGroupPendingModifiedValues _pendingModifiedValues;
        private DateTime? _replicationGroupCreateTime;
        private string _replicationGroupId;
        private int? _snapshotRetentionLimit;
        private string _snapshottingClusterId;
        private string _snapshotWindow;
        private string _status;
        private bool? _transitEncryptionEnabled;
        private TransitEncryptionMode _transitEncryptionMode;
        private List<string> _userGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the replication group.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// A flag that enables encryption at-rest when set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <code>AtRestEncryptionEnabled</code> after the cluster
        /// is created. To enable encryption at-rest on a cluster you must set <code>AtRestEncryptionEnabled</code>
        /// to <code>true</code> when you create a cluster.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using redis version <code>3.2.6</code>, <code>4.x</code> or later.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool AtRestEncryptionEnabled
        {
            get { return this._atRestEncryptionEnabled.GetValueOrDefault(); }
            set { this._atRestEncryptionEnabled = value; }
        }

        // Check to see if AtRestEncryptionEnabled property is set
        internal bool IsSetAtRestEncryptionEnabled()
        {
            return this._atRestEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthTokenEnabled. 
        /// <para>
        /// A flag that enables using an <code>AuthToken</code> (password) when issuing Redis
        /// commands.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool AuthTokenEnabled
        {
            get { return this._authTokenEnabled.GetValueOrDefault(); }
            set { this._authTokenEnabled = value; }
        }

        // Check to see if AuthTokenEnabled property is set
        internal bool IsSetAuthTokenEnabled()
        {
            return this._authTokenEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthTokenLastModifiedDate. 
        /// <para>
        /// The date the auth token was last modified
        /// </para>
        /// </summary>
        public DateTime AuthTokenLastModifiedDate
        {
            get { return this._authTokenLastModifiedDate.GetValueOrDefault(); }
            set { this._authTokenLastModifiedDate = value; }
        }

        // Check to see if AuthTokenLastModifiedDate property is set
        internal bool IsSetAuthTokenLastModifiedDate()
        {
            return this._authTokenLastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates the status of automatic failover for this Redis replication group.
        /// </para>
        /// </summary>
        public AutomaticFailoverStatus AutomaticFailover
        {
            get { return this._automaticFailover; }
            set { this._automaticFailover = value; }
        }

        // Check to see if AutomaticFailover property is set
        internal bool IsSetAutomaticFailover()
        {
            return this._automaticFailover != null;
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
        /// The name of the compute and memory capacity node type for each node in the replication
        /// group.
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
        /// Gets and sets the property ClusterEnabled. 
        /// <para>
        /// A flag indicating whether or not this replication group is cluster enabled; i.e.,
        /// whether its data can be partitioned across multiple shards (API/CLI: node groups).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool ClusterEnabled
        {
            get { return this._clusterEnabled.GetValueOrDefault(); }
            set { this._clusterEnabled = value; }
        }

        // Check to see if ClusterEnabled property is set
        internal bool IsSetClusterEnabled()
        {
            return this._clusterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationEndpoint. 
        /// <para>
        /// The configuration endpoint for this replication group. Use the configuration endpoint
        /// to connect to this replication group.
        /// </para>
        /// </summary>
        public Endpoint ConfigurationEndpoint
        {
            get { return this._configurationEndpoint; }
            set { this._configurationEndpoint = value; }
        }

        // Check to see if ConfigurationEndpoint property is set
        internal bool IsSetConfigurationEndpoint()
        {
            return this._configurationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for replication groups using
        /// the r6gd node type. This parameter must be set to true when using r6gd nodes. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public DataTieringStatus DataTiering
        {
            get { return this._dataTiering; }
            set { this._dataTiering = value; }
        }

        // Check to see if DataTiering property is set
        internal bool IsSetDataTiering()
        {
            return this._dataTiering != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user supplied description of the replication group.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupInfo. 
        /// <para>
        /// The name of the Global datastore and role of this replication group in the Global
        /// datastore.
        /// </para>
        /// </summary>
        public GlobalReplicationGroupInfo GlobalReplicationGroupInfo
        {
            get { return this._globalReplicationGroupInfo; }
            set { this._globalReplicationGroupInfo = value; }
        }

        // Check to see if GlobalReplicationGroupInfo property is set
        internal bool IsSetGlobalReplicationGroupInfo()
        {
            return this._globalReplicationGroupInfo != null;
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the disk in the cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryConfigurations. 
        /// <para>
        /// Returns the destination, format and type of the logs. 
        /// </para>
        /// </summary>
        public List<LogDeliveryConfiguration> LogDeliveryConfigurations
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
        /// Gets and sets the property MemberClusters. 
        /// <para>
        /// The names of all the cache clusters that are part of this replication group.
        /// </para>
        /// </summary>
        public List<string> MemberClusters
        {
            get { return this._memberClusters; }
            set { this._memberClusters = value; }
        }

        // Check to see if MemberClusters property is set
        internal bool IsSetMemberClusters()
        {
            return this._memberClusters != null && this._memberClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MemberClustersOutpostArns. 
        /// <para>
        /// The outpost ARNs of the replication group's member clusters.
        /// </para>
        /// </summary>
        public List<string> MemberClustersOutpostArns
        {
            get { return this._memberClustersOutpostArns; }
            set { this._memberClustersOutpostArns = value; }
        }

        // Check to see if MemberClustersOutpostArns property is set
        internal bool IsSetMemberClustersOutpostArns()
        {
            return this._memberClustersOutpostArns != null && this._memberClustersOutpostArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// A flag indicating if you have Multi-AZ enabled to enhance fault tolerance. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/AutoFailover.html">Minimizing
        /// Downtime: Multi-AZ</a> 
        /// </para>
        /// </summary>
        public MultiAZStatus MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Must be either <code>ipv4</code> | <code>ipv6</code> | <code>dual_stack</code>. IPv6
        /// is supported for workloads using Redis engine version 6.2 onward or Memcached engine
        /// version 1.6.6 on all instances built on the <a href="https://aws.amazon.com/ec2/nitro/">Nitro
        /// system</a>.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroups. 
        /// <para>
        /// A list of node groups in this replication group. For Redis (cluster mode disabled)
        /// replication groups, this is a single-element list. For Redis (cluster mode enabled)
        /// replication groups, the list contains an entry for each node group (shard).
        /// </para>
        /// </summary>
        public List<NodeGroup> NodeGroups
        {
            get { return this._nodeGroups; }
            set { this._nodeGroups = value; }
        }

        // Check to see if NodeGroups property is set
        internal bool IsSetNodeGroups()
        {
            return this._nodeGroups != null && this._nodeGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// A group of settings to be applied to the replication group, either immediately or
        /// during the next maintenance window.
        /// </para>
        /// </summary>
        public ReplicationGroupPendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupCreateTime. 
        /// <para>
        /// The date and time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime ReplicationGroupCreateTime
        {
            get { return this._replicationGroupCreateTime.GetValueOrDefault(); }
            set { this._replicationGroupCreateTime = value; }
        }

        // Check to see if ReplicationGroupCreateTime property is set
        internal bool IsSetReplicationGroupCreateTime()
        {
            return this._replicationGroupCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier for the replication group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic cluster snapshots before
        /// deleting them. For example, if you set <code>SnapshotRetentionLimit</code> to 5, a
        /// snapshot that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If the value of <code>SnapshotRetentionLimit</code> is set to zero (0), backups are
        /// turned off.
        /// </para>
        ///  </important>
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
        /// of your node group (shard).
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
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <code>Engine</code> parameter is <code>redis</code>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of this replication group - <code>creating</code>, <code>available</code>,
        /// <code>modifying</code>, <code>deleting</code>, <code>create-failed</code>, <code>snapshotting</code>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using redis version <code>3.2.6</code>, <code>4.x</code> or later.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
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
        /// Gets and sets the property UserGroupIds. 
        /// <para>
        /// The ID of the user group associated to the replication group.
        /// </para>
        /// </summary>
        public List<string> UserGroupIds
        {
            get { return this._userGroupIds; }
            set { this._userGroupIds = value; }
        }

        // Check to see if UserGroupIds property is set
        internal bool IsSetUserGroupIds()
        {
            return this._userGroupIds != null && this._userGroupIds.Count > 0; 
        }

    }
}