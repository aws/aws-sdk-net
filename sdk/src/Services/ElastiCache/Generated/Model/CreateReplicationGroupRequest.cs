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
    /// Container for the parameters to the CreateReplicationGroup operation.
    /// Creates a Redis (cluster mode disabled) or a Redis (cluster mode enabled) replication
    /// group.
    /// 
    ///  
    /// <para>
    /// This API can be used to create a standalone regional replication group or a secondary
    /// replication group associated with a Global datastore.
    /// </para>
    ///  
    /// <para>
    /// A Redis (cluster mode disabled) replication group is a collection of clusters, where
    /// one of the clusters is a read/write primary and the others are read-only replicas.
    /// Writes to the primary are asynchronously propagated to the replicas.
    /// </para>
    ///  
    /// <para>
    /// A Redis cluster-mode enabled cluster is comprised of from 1 to 90 shards (API/CLI:
    /// node groups). Each shard has a primary node and up to 5 read-only replica nodes. The
    /// configuration can range from 90 shards and 0 replicas to 15 shards and 5 replicas,
    /// which is the maximum number or replicas allowed. 
    /// </para>
    ///  
    /// <para>
    /// The node or shard limit can be increased to a maximum of 500 per cluster if the Redis
    /// engine version is 5.0.6 or higher. For example, you can choose to configure a 500
    /// node cluster that ranges between 83 shards (one primary and 5 replicas per shard)
    /// and 500 shards (single primary and no replicas). Make sure there are enough available
    /// IP addresses to accommodate the increase. Common pitfalls include the subnets in the
    /// subnet group have too small a CIDR range or the subnets are shared and heavily used
    /// by other clusters. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/SubnetGroups.Creating.html">Creating
    /// a Subnet Group</a>. For versions below 5.0.6, the limit is 250 per cluster.
    /// </para>
    ///  
    /// <para>
    /// To request a limit increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
    /// Service Limits</a> and choose the limit type <b>Nodes per cluster per instance type</b>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// When a Redis (cluster mode disabled) replication group has been successfully created,
    /// you can add one or more read replicas to it, up to a total of 5 read replicas. If
    /// you need to increase or decrease the number of node groups (console: shards), you
    /// can avail yourself of ElastiCache for Redis' scaling. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Scaling.html">Scaling
    /// ElastiCache for Redis Clusters</a> in the <i>ElastiCache User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is valid for Redis only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _atRestEncryptionEnabled;
        private string _authToken;
        private bool? _automaticFailoverEnabled;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _cacheSubnetGroupName;
        private bool? _dataTieringEnabled;
        private string _engine;
        private string _engineVersion;
        private string _globalReplicationGroupId;
        private IpDiscovery _ipDiscovery;
        private string _kmsKeyId;
        private List<LogDeliveryConfigurationRequest> _logDeliveryConfigurations = new List<LogDeliveryConfigurationRequest>();
        private bool? _multiAZEnabled;
        private NetworkType _networkType;
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
        private bool? _transitEncryptionEnabled;
        private TransitEncryptionMode _transitEncryptionMode;
        private List<string> _userGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// A flag that enables encryption at rest when set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <code>AtRestEncryptionEnabled</code> after the replication
        /// group is created. To enable encryption at rest on a replication group you must set
        /// <code>AtRestEncryptionEnabled</code> to <code>true</code> when you create the replication
        /// group. 
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
        /// Gets and sets the property AuthToken. 
        /// <para>
        ///  <b>Reserved parameter.</b> The password used to access a password protected server.
        /// </para>
        ///  
        /// <para>
        ///  <code>AuthToken</code> can be specified only on replication groups where <code>TransitEncryptionEnabled</code>
        /// is <code>true</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// For HIPAA compliance, you must specify <code>TransitEncryptionEnabled</code> as <code>true</code>,
        /// an <code>AuthToken</code>, and a <code>CacheSubnetGroup</code>.
        /// </para>
        ///  </important> 
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
        /// The only permitted printable special characters are !, &amp;, #, $, ^, &lt;, &gt;,
        /// and -. Other printable special characters cannot be used in the AUTH token.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://redis.io/commands/AUTH">AUTH password</a>
        /// at http://redis.io/commands/AUTH.
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
        ///  <code>AutomaticFailoverEnabled</code> must be enabled for Redis (cluster mode enabled)
        /// replication groups.
        /// </para>
        ///  
        /// <para>
        /// Default: false
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
        /// The compute and memory capacity of the nodes in the node group (shard).
        /// </para>
        ///  
        /// <para>
        /// The following node types are supported by ElastiCache. Generally speaking, the current
        /// generation types provide more memory and computational power at lower cost when compared
        /// to their equivalent previous generation counterparts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General purpose:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Current generation: 
        /// </para>
        ///  
        /// <para>
        ///  <b>M6g node types</b> (available only for Redis engine version 5.0.6 onward and for
        /// Memcached engine version 1.5.16 onward): <code>cache.m6g.large</code>, <code>cache.m6g.xlarge</code>,
        /// <code>cache.m6g.2xlarge</code>, <code>cache.m6g.4xlarge</code>, <code>cache.m6g.8xlarge</code>,
        /// <code>cache.m6g.12xlarge</code>, <code>cache.m6g.16xlarge</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
        /// Node Types</a> 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>M5 node types:</b> <code>cache.m5.large</code>, <code>cache.m5.xlarge</code>,
        /// <code>cache.m5.2xlarge</code>, <code>cache.m5.4xlarge</code>, <code>cache.m5.12xlarge</code>,
        /// <code>cache.m5.24xlarge</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M4 node types:</b> <code>cache.m4.large</code>, <code>cache.m4.xlarge</code>,
        /// <code>cache.m4.2xlarge</code>, <code>cache.m4.4xlarge</code>, <code>cache.m4.10xlarge</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>T4g node types</b> (available only for Redis engine version 5.0.6 onward and Memcached
        /// engine version 1.5.16 onward): <code>cache.t4g.micro</code>, <code>cache.t4g.small</code>,
        /// <code>cache.t4g.medium</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>T3 node types:</b> <code>cache.t3.micro</code>, <code>cache.t3.small</code>, <code>cache.t3.medium</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>T2 node types:</b> <code>cache.t2.micro</code>, <code>cache.t2.small</code>, <code>cache.t2.medium</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended. Existing clusters are still supported but creation
        /// of new clusters is not supported for these types.)
        /// </para>
        ///  
        /// <para>
        ///  <b>T1 node types:</b> <code>cache.t1.micro</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M1 node types:</b> <code>cache.m1.small</code>, <code>cache.m1.medium</code>,
        /// <code>cache.m1.large</code>, <code>cache.m1.xlarge</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M3 node types:</b> <code>cache.m3.medium</code>, <code>cache.m3.large</code>,
        /// <code>cache.m3.xlarge</code>, <code>cache.m3.2xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Compute optimized:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Previous generation: (not recommended. Existing clusters are still supported but creation
        /// of new clusters is not supported for these types.)
        /// </para>
        ///  
        /// <para>
        ///  <b>C1 node types:</b> <code>cache.c1.xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Memory optimized:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Current generation: 
        /// </para>
        ///  
        /// <para>
        ///  <b>R6g node types</b> (available only for Redis engine version 5.0.6 onward and for
        /// Memcached engine version 1.5.16 onward).
        /// </para>
        ///  
        /// <para>
        ///  <code>cache.r6g.large</code>, <code>cache.r6g.xlarge</code>, <code>cache.r6g.2xlarge</code>,
        /// <code>cache.r6g.4xlarge</code>, <code>cache.r6g.8xlarge</code>, <code>cache.r6g.12xlarge</code>,
        /// <code>cache.r6g.16xlarge</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
        /// Node Types</a> 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>R5 node types:</b> <code>cache.r5.large</code>, <code>cache.r5.xlarge</code>,
        /// <code>cache.r5.2xlarge</code>, <code>cache.r5.4xlarge</code>, <code>cache.r5.12xlarge</code>,
        /// <code>cache.r5.24xlarge</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>R4 node types:</b> <code>cache.r4.large</code>, <code>cache.r4.xlarge</code>,
        /// <code>cache.r4.2xlarge</code>, <code>cache.r4.4xlarge</code>, <code>cache.r4.8xlarge</code>,
        /// <code>cache.r4.16xlarge</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended. Existing clusters are still supported but creation
        /// of new clusters is not supported for these types.)
        /// </para>
        ///  
        /// <para>
        ///  <b>M2 node types:</b> <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>,
        /// <code>cache.m2.4xlarge</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>R3 node types:</b> <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>,
        /// <code>cache.r3.2xlarge</code>, <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Additional node type info</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All current generation instance types are created in Amazon VPC by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis append-only files (AOF) are not supported for T1 or T2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis Multi-AZ with automatic failover is not supported on T1 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis configuration variables <code>appendonly</code> and <code>appendfsync</code>
        /// are not supported on Redis version 2.8.22 and later.
        /// </para>
        ///  </li> </ul>
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
        /// group before you start creating a cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/SubnetGroups.html">Subnets
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
        /// Gets and sets the property DataTieringEnabled. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for replication groups using
        /// the r6gd node type. This parameter must be set to true when using r6gd nodes. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public bool DataTieringEnabled
        {
            get { return this._dataTieringEnabled.GetValueOrDefault(); }
            set { this._dataTieringEnabled = value; }
        }

        // Check to see if DataTieringEnabled property is set
        internal bool IsSetDataTieringEnabled()
        {
            return this._dataTieringEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine to be used for the clusters in this replication group.
        /// The value must be set to <code>Redis</code>.
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
        /// The version number of the cache engine to be used for the clusters in this replication
        /// group. To view the supported cache engine versions, use the <code>DescribeCacheEngineVersions</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>) in the <i>ElastiCache User Guide</i>, but you cannot
        /// downgrade to an earlier engine version. If you want to use an earlier engine version,
        /// you must delete the existing cluster or replication group and create it anew with
        /// the earlier engine version. 
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
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupId
        {
            get { return this._globalReplicationGroupId; }
            set { this._globalReplicationGroupId = value; }
        }

        // Check to see if GlobalReplicationGroupId property is set
        internal bool IsSetGlobalReplicationGroupId()
        {
            return this._globalReplicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The network type you choose when creating a replication group, either <code>ipv4</code>
        /// | <code>ipv6</code>. IPv6 is supported for workloads using Redis engine version 6.2
        /// onward or Memcached engine version 1.6.6 on all instances built on the <a href="https://aws.amazon.com/ec2/nitro/">Nitro
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
        /// A flag indicating if you have Multi-AZ enabled to enhance fault tolerance. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/AutoFailover.html">Minimizing
        /// Downtime: Multi-AZ</a>.
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
        /// Gets and sets the property NodeGroupConfiguration. 
        /// <para>
        /// A list of node group (shard) configuration options. Each node group (shard) configuration
        /// has the following members: <code>PrimaryAvailabilityZone</code>, <code>ReplicaAvailabilityZones</code>,
        /// <code>ReplicaCount</code>, and <code>Slots</code>.
        /// </para>
        ///  
        /// <para>
        /// If you're creating a Redis (cluster mode disabled) or a Redis (cluster mode enabled)
        /// replication group, you can use this parameter to individually configure each node
        /// group (shard), or you can omit this parameter. However, it is required when seeding
        /// a Redis (cluster mode enabled) cluster from a S3 rdb file. You must configure each
        /// node group (shard) using this parameter because you must specify the slots for each
        /// node group.
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
        /// The Amazon SNS topic owner must be the same as the cluster owner.
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
        /// If <code>AutomaticFailoverEnabled</code> is <code>true</code>, the value of this parameter
        /// must be at least 2. If <code>AutomaticFailoverEnabled</code> is <code>false</code>
        /// you can omit this parameter (it will default to 1), or you can explicitly set it to
        /// a value between 2 and 6.
        /// </para>
        ///  
        /// <para>
        /// The maximum permitted value for <code>NumCacheClusters</code> is 6 (1 primary plus
        /// 5 replicas).
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
        /// A list of EC2 Availability Zones in which the replication group's clusters are created.
        /// The order of the Availability Zones in the list is the order in which clusters are
        /// allocated. The primary cluster is created in the first AZ in the list.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not used if there is more than one node group (shard). You should
        /// use <code>NodeGroupConfiguration</code> instead.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating your replication group in an Amazon VPC (recommended), you can
        /// only locate clusters in Availability Zones associated with the subnets in the selected
        /// subnet group.
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
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
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
        /// The identifier of the cluster that serves as the primary for this replication group.
        /// This cluster must already exist and have a status of <code>available</code>.
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
        [AWSProperty(Required=true)]
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
        /// A name must contain from 1 to 40 alphanumeric characters or hyphens.
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
        /// files stored in Amazon S3. The snapshot files are used to populate the new replication
        /// group. The Amazon S3 object name in the ARN cannot contain any commas. The new replication
        /// group will have the number of node groups (console: shards) specified by the parameter
        /// <i>NumNodeGroups</i> or the number of node groups configured by <i>NodeGroupConfiguration</i>
        /// regardless of the number of ARNs specified here.
        /// </para>
        ///  
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
        ///  
        /// <para>
        /// Default: 0 (i.e., automatic backups are disabled for this cluster).
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
        /// A list of tags to be added to this resource. Tags are comma-separated key,value pairs
        /// (e.g. Key=<code>myKey</code>, Value=<code>myKeyValue</code>. You can include multiple
        /// tags as shown following: Key=<code>myKey</code>, Value=<code>myKeyValue</code> Key=<code>mySecondKey</code>,
        /// Value=<code>mySecondKeyValue</code>. Tags on replication groups will be replicated
        /// to all nodes.
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

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only if the <code>Engine</code> parameter is <code>redis</code>,
        /// the <code>EngineVersion</code> parameter is <code>3.2.6</code>, <code>4.x</code> or
        /// later, and the cluster is being created in an Amazon VPC.
        /// </para>
        ///  
        /// <para>
        /// If you enable in-transit encryption, you must also specify a value for <code>CacheSubnetGroup</code>.
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
        ///  <important> 
        /// <para>
        /// For HIPAA compliance, you must specify <code>TransitEncryptionEnabled</code> as <code>true</code>,
        /// an <code>AuthToken</code>, and a <code>CacheSubnetGroup</code>.
        /// </para>
        ///  </important>
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
        /// When setting <code>TransitEncryptionEnabled</code> to <code>true</code>, you can set
        /// your <code>TransitEncryptionMode</code> to <code>preferred</code> in the same request,
        /// to allow both encrypted and unencrypted connections at the same time. Once you migrate
        /// all your Redis clients to use encrypted connections you can modify the value to <code>required</code>
        /// to allow encrypted connections only.
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
        /// Gets and sets the property UserGroupIds. 
        /// <para>
        /// The user group to associate with the replication group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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