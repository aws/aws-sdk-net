/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationGroup operation.
    /// Creates a Redis (cluster mode disabled) or a Redis (cluster mode enabled) replication
    /// group.
    /// 
    ///  
    /// <para>
    /// A Redis (cluster mode disabled) replication group is a collection of cache clusters,
    /// where one of the cache clusters is a read/write primary and the others are read-only
    /// replicas. Writes to the primary are asynchronously propagated to the replicas.
    /// </para>
    ///  
    /// <para>
    /// A Redis (cluster mode enabled) replication group is a collection of 1 to 15 node groups
    /// (shards). Each node group (shard) has one read/write primary node and up to 5 read-only
    /// replica nodes. Writes to the primary are asynchronously propagated to the replicas.
    /// Redis (cluster mode enabled) replication groups partition the data across node groups
    /// (shards).
    /// </para>
    ///  
    /// <para>
    /// When a Redis (cluster mode disabled) replication group has been successfully created,
    /// you can add one or more read replicas to it, up to a total of 5 read replicas. You
    /// cannot alter a Redis (cluster mode enabled) replication group after it has been created.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is valid for Redis only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _authToken;
        private bool? _automaticFailoverEnabled;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _cacheSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private List<NodeGroupConfiguration> _nodeGroupConfiguration = new List<NodeGroupConfiguration>();
        private string _notificationTopicArn;
        private int? _numCacheClusters;
        private int? _numNodeGroups;
        private int? _port;
        private List<string> _preferredCacheClusterAZs = new List<string>();
        private string _preferredMaintenanceWindow;
        private string _primaryClusterId;
        private int? _replicasPerNodeGroup;
        private string _replicationGroupDescription;
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _snapshotArns = new List<string>();
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        ///  <b>Reserved parameter.</b> The password used to access a password protected server.
        /// </para>
        ///  
        /// <para>
        /// Password constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be only printable ASCII characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 16 characters and no more than 128 characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot contain any of the following characters: '/', '"', or "@". 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://redis.io/commands/AUTH">AUTH password</a>
        /// at Redis.
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
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Specifies whether a read-only replica is automatically promoted to read/write primary
        /// if the existing primary fails.
        /// </para>
        ///  
        /// <para>
        /// If <code>true</code>, Multi-AZ is enabled for this replication group. If <code>false</code>,
        /// Multi-AZ is disabled for this replication group.
        /// </para>
        ///  
        /// <para>
        ///  <code>AutomaticFailoverEnabled</code> must be enabled for Redis (cluster mode enabled)
        /// replication groups.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        ///  <note> 
        /// <para>
        /// ElastiCache Multi-AZ replication groups is not supported on:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Redis versions earlier than 2.8.6.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis (cluster mode disabled): T1 and T2 node types.
        /// </para>
        ///  
        /// <para>
        /// Redis (cluster mode enabled): T2 node types.
        /// </para>
        ///  </li> </ul> </note>
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
        /// This parameter is currently disabled.
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
        /// The compute and memory capacity of the nodes in the node group (shard).
        /// </para>
        ///  
        /// <para>
        /// Valid node types are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General purpose:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Current generation: <code>cache.t2.micro</code>, <code>cache.t2.small</code>, <code>cache.t2.medium</code>,
        /// <code>cache.m3.medium</code>, <code>cache.m3.large</code>, <code>cache.m3.xlarge</code>,
        /// <code>cache.m3.2xlarge</code>, <code>cache.m4.large</code>, <code>cache.m4.xlarge</code>,
        /// <code>cache.m4.2xlarge</code>, <code>cache.m4.4xlarge</code>, <code>cache.m4.10xlarge</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: <code>cache.t1.micro</code>, <code>cache.m1.small</code>, <code>cache.m1.medium</code>,
        /// <code>cache.m1.large</code>, <code>cache.m1.xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Compute optimized: <code>cache.c1.xlarge</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Memory optimized:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Current generation: <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>, <code>cache.r3.2xlarge</code>,
        /// <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>,
        /// <code>cache.m2.4xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Notes:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All T2 instances are created in an Amazon Virtual Private Cloud (Amazon VPC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis backup/restore is not supported for Redis (cluster mode disabled) T1 and T2
        /// instances. Backup/restore is supported on Redis (cluster mode enabled) T2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis Append-only files (AOF) functionality is not supported for T1 or T2 instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a complete listing of node types and specifications, see <a href="http://aws.amazon.com/elasticache/details">Amazon
        /// ElastiCache Product Features and Details</a> and either <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Memcached.html#ParameterGroups.Memcached.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Memcached</a> or <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Redis.html#ParameterGroups.Redis.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Redis</a>.
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
        /// The name of the parameter group to associate with this replication group. If this
        /// argument is omitted, the default cache parameter group for the specified engine is
        /// used.
        /// </para>
        ///  
        /// <para>
        /// If you are running Redis version 3.2.4 or later, only one node group (shard), and
        /// want to use a default parameter group, we recommend that you specify the parameter
        /// group by name. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a Redis (cluster mode disabled) replication group, use <code>CacheParameterGroupName=default.redis3.2</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a Redis (cluster mode enabled) replication group, use <code>CacheParameterGroupName=default.redis3.2.cluster.on</code>.
        /// </para>
        ///  </li> </ul>
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
        /// A list of cache security group names to associate with this replication group.
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
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group to be used for the replication group.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're going to launch your cluster in an Amazon VPC, you need to create a subnet
        /// group before you start creating a cluster. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/SubnetGroups.html">Subnets
        /// and Subnet Groups</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this._cacheSubnetGroupName; }
            set { this._cacheSubnetGroupName = value; }
        }

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this._cacheSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine to be used for the cache clusters in this replication
        /// group.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the cache engine to be used for the cache clusters in this replication
        /// group. To view the supported cache engine versions, use the <code>DescribeCacheEngineVersions</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>) in the <i>ElastiCache User Guide</i>, but you cannot
        /// downgrade to an earlier engine version. If you want to use an earlier engine version,
        /// you must delete the existing cache cluster or replication group and create it anew
        /// with the earlier engine version. 
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
        /// Gets and sets the property NodeGroupConfiguration. 
        /// <para>
        /// A list of node group (shard) configuration options. Each node group (shard) configuration
        /// has the following: Slots, PrimaryAvailabilityZone, ReplicaAvailabilityZones, ReplicaCount.
        /// </para>
        ///  
        /// <para>
        /// If you're creating a Redis (cluster mode disabled) or a Redis (cluster mode enabled)
        /// replication group, you can use this parameter to configure one node group (shard)
        /// or you can omit this parameter.
        /// </para>
        /// </summary>
        public List<NodeGroupConfiguration> NodeGroupConfiguration
        {
            get { return this._nodeGroupConfiguration; }
            set { this._nodeGroupConfiguration = value; }
        }

        // Check to see if NodeGroupConfiguration property is set
        internal bool IsSetNodeGroupConfiguration()
        {
            return this._nodeGroupConfiguration != null && this._nodeGroupConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic
        /// to which notifications are sent.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon SNS topic owner must be the same as the cache cluster owner.
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
        /// Gets and sets the property NumCacheClusters. 
        /// <para>
        /// The number of clusters this replication group initially has.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not used if there is more than one node group (shard). You should
        /// use <code>ReplicasPerNodeGroup</code> instead.
        /// </para>
        ///  
        /// <para>
        /// If <code>Multi-AZ</code> is <code>enabled</code>, the value of this parameter must
        /// be at least 2.
        /// </para>
        ///  
        /// <para>
        /// The maximum permitted value for <code>NumCacheClusters</code> is 6 (primary plus 5
        /// replicas).
        /// </para>
        /// </summary>
        public int NumCacheClusters
        {
            get { return this._numCacheClusters.GetValueOrDefault(); }
            set { this._numCacheClusters = value; }
        }

        // Check to see if NumCacheClusters property is set
        internal bool IsSetNumCacheClusters()
        {
            return this._numCacheClusters.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumNodeGroups. 
        /// <para>
        /// An optional parameter that specifies the number of node groups (shards) for this Redis
        /// (cluster mode enabled) replication group. For Redis (cluster mode disabled) either
        /// omit this parameter or set it to 1.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        public int NumNodeGroups
        {
            get { return this._numNodeGroups.GetValueOrDefault(); }
            set { this._numNodeGroups = value; }
        }

        // Check to see if NumNodeGroups property is set
        internal bool IsSetNumNodeGroups()
        {
            return this._numNodeGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each member of the replication group accepts connections.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredCacheClusterAZs. 
        /// <para>
        /// A list of EC2 Availability Zones in which the replication group's cache clusters are
        /// created. The order of the Availability Zones in the list is the order in which clusters
        /// are allocated. The primary cluster is created in the first AZ in the list.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not used if there is more than one node group (shard). You should
        /// use <code>NodeGroupConfiguration</code> instead.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating your replication group in an Amazon VPC (recommended), you can
        /// only locate cache clusters in Availability Zones associated with the subnets in the
        /// selected subnet group.
        /// </para>
        ///  
        /// <para>
        /// The number of Availability Zones listed must equal the value of <code>NumCacheClusters</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: system chosen Availability Zones.
        /// </para>
        /// </summary>
        public List<string> PreferredCacheClusterAZs
        {
            get { return this._preferredCacheClusterAZs; }
            set { this._preferredCacheClusterAZs = value; }
        }

        // Check to see if PreferredCacheClusterAZs property is set
        internal bool IsSetPreferredCacheClusterAZs()
        {
            return this._preferredCacheClusterAZs != null && this._preferredCacheClusterAZs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cache cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period. Valid values for <code>ddd</code>
        /// are:
        /// </para>
        ///  
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
        /// The identifier of the cache cluster that serves as the primary for this replication
        /// group. This cache cluster must already exist and have a status of <code>available</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not required if <code>NumCacheClusters</code>, <code>NumNodeGroups</code>,
        /// or <code>ReplicasPerNodeGroup</code> is specified.
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
        /// Gets and sets the property ReplicasPerNodeGroup. 
        /// <para>
        /// An optional parameter that specifies the number of replica nodes in each node group
        /// (shard). Valid values are 0 to 5.
        /// </para>
        /// </summary>
        public int ReplicasPerNodeGroup
        {
            get { return this._replicasPerNodeGroup.GetValueOrDefault(); }
            set { this._replicasPerNodeGroup = value; }
        }

        // Check to see if ReplicasPerNodeGroup property is set
        internal bool IsSetReplicasPerNodeGroup()
        {
            return this._replicasPerNodeGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupDescription. 
        /// <para>
        /// A user-created description for the replication group.
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
        /// The replication group identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name must contain from 1 to 20 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A name cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more Amazon VPC security groups associated with this replication group.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a replication group in an Amazon Virtual
        /// Private Cloud (Amazon VPC).
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
        /// Gets and sets the property SnapshotArns. 
        /// <para>
        /// A list of Amazon Resource Names (ARN) that uniquely identify the Redis RDB snapshot
        /// files stored in Amazon S3. The snapshot files are used to populate the replication
        /// group. The Amazon S3 object name in the ARN cannot contain any commas. The list must
        /// match the number of node groups (shards) in the replication group, which means you
        /// cannot repartition.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <code>Engine</code> parameter is <code>redis</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Example of an Amazon S3 ARN: <code>arn:aws:s3:::my_bucket/snapshot1.rdb</code> 
        /// </para>
        /// </summary>
        public List<string> SnapshotArns
        {
            get { return this._snapshotArns; }
            set { this._snapshotArns = value; }
        }

        // Check to see if SnapshotArns property is set
        internal bool IsSetSnapshotArns()
        {
            return this._snapshotArns != null && this._snapshotArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of a snapshot from which to restore data into the new replication group.
        /// The snapshot status changes to <code>restoring</code> while the new replication group
        /// is being created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <code>Engine</code> parameter is <code>redis</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic snapshots before deleting
        /// them. For example, if you set <code>SnapshotRetentionLimit</code> to 5, a snapshot
        /// that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <code>Engine</code> parameter is <code>redis</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: 0 (i.e., automatic backups are disabled for this cache cluster).
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of cost allocation tags to be added to this resource. A tag is a key-value
        /// pair. A tag key must be accompanied by a tag value.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}