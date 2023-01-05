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
    /// Container for the parameters to the CreateCacheCluster operation.
    /// Creates a cluster. All nodes in the cluster run the same protocol-compliant cache
    /// engine software, either Memcached or Redis.
    /// 
    ///  
    /// <para>
    /// This operation is not supported for Redis (cluster mode enabled) clusters.
    /// </para>
    /// </summary>
    public partial class CreateCacheClusterRequest : AmazonElastiCacheRequest
    {
        private string _authToken;
        private bool? _autoMinorVersionUpgrade;
        private AZMode _azMode;
        private string _cacheClusterId;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _cacheSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private IpDiscovery _ipDiscovery;
        private List<LogDeliveryConfigurationRequest> _logDeliveryConfigurations = new List<LogDeliveryConfigurationRequest>();
        private NetworkType _networkType;
        private string _notificationTopicArn;
        private int? _numCacheNodes;
        private OutpostMode _outpostMode;
        private int? _port;
        private string _preferredAvailabilityZone;
        private List<string> _preferredAvailabilityZones = new List<string>();
        private string _preferredMaintenanceWindow;
        private string _preferredOutpostArn;
        private List<string> _preferredOutpostArns = new List<string>();
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _snapshotArns = new List<string>();
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private List<Tag> _tags = new List<Tag>();
        private bool? _transitEncryptionEnabled;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCacheClusterRequest() { }

        /// <summary>
        /// Instantiates CreateCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The node group (shard) identifier. This parameter is stored as a lowercase string.  <b>Constraints:</b>  <ul> <li> A name must contain from 1 to 50 alphanumeric characters or hyphens. </li> <li> The first character must be a letter. </li> <li> A name cannot end with a hyphen or contain two consecutive hyphens. </li> </ul></param>
        /// <param name="numCacheNodes">The initial number of cache nodes that the cluster has. For clusters running Redis, this value must be 1. For clusters running Memcached, this value must be between 1 and 40. If you need more than 40 nodes for your Memcached cluster, please fill out the ElastiCache Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/">http://aws.amazon.com/contact-us/elasticache-node-limit-request/</a>.</param>
        /// <param name="cacheNodeType">The compute and memory capacity of the nodes in the node group (shard). The following node types are supported by ElastiCache. Generally speaking, the current generation types provide more memory and computational power at lower cost when compared to their equivalent previous generation counterparts. <ul> <li> General purpose: <ul> <li> Current generation:   <b>M6g node types</b> (available only for Redis engine version 5.0.6 onward and for Memcached engine version 1.5.16 onward): <code>cache.m6g.large</code>, <code>cache.m6g.xlarge</code>, <code>cache.m6g.2xlarge</code>, <code>cache.m6g.4xlarge</code>, <code>cache.m6g.8xlarge</code>, <code>cache.m6g.12xlarge</code>, <code>cache.m6g.16xlarge</code>  <note> For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported Node Types</a>  </note>  <b>M5 node types:</b> <code>cache.m5.large</code>, <code>cache.m5.xlarge</code>, <code>cache.m5.2xlarge</code>, <code>cache.m5.4xlarge</code>, <code>cache.m5.12xlarge</code>, <code>cache.m5.24xlarge</code>   <b>M4 node types:</b> <code>cache.m4.large</code>, <code>cache.m4.xlarge</code>, <code>cache.m4.2xlarge</code>, <code>cache.m4.4xlarge</code>, <code>cache.m4.10xlarge</code>   <b>T4g node types</b> (available only for Redis engine version 5.0.6 onward and Memcached engine version 1.5.16 onward): <code>cache.t4g.micro</code>, <code>cache.t4g.small</code>, <code>cache.t4g.medium</code>   <b>T3 node types:</b> <code>cache.t3.micro</code>, <code>cache.t3.small</code>, <code>cache.t3.medium</code>   <b>T2 node types:</b> <code>cache.t2.micro</code>, <code>cache.t2.small</code>, <code>cache.t2.medium</code>  </li> <li> Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)  <b>T1 node types:</b> <code>cache.t1.micro</code>   <b>M1 node types:</b> <code>cache.m1.small</code>, <code>cache.m1.medium</code>, <code>cache.m1.large</code>, <code>cache.m1.xlarge</code>   <b>M3 node types:</b> <code>cache.m3.medium</code>, <code>cache.m3.large</code>, <code>cache.m3.xlarge</code>, <code>cache.m3.2xlarge</code>  </li> </ul> </li> <li> Compute optimized: <ul> <li> Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)  <b>C1 node types:</b> <code>cache.c1.xlarge</code>  </li> </ul> </li> <li> Memory optimized: <ul> <li> Current generation:   <b>R6g node types</b> (available only for Redis engine version 5.0.6 onward and for Memcached engine version 1.5.16 onward).  <code>cache.r6g.large</code>, <code>cache.r6g.xlarge</code>, <code>cache.r6g.2xlarge</code>, <code>cache.r6g.4xlarge</code>, <code>cache.r6g.8xlarge</code>, <code>cache.r6g.12xlarge</code>, <code>cache.r6g.16xlarge</code>  <note> For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported Node Types</a>  </note>  <b>R5 node types:</b> <code>cache.r5.large</code>, <code>cache.r5.xlarge</code>, <code>cache.r5.2xlarge</code>, <code>cache.r5.4xlarge</code>, <code>cache.r5.12xlarge</code>, <code>cache.r5.24xlarge</code>   <b>R4 node types:</b> <code>cache.r4.large</code>, <code>cache.r4.xlarge</code>, <code>cache.r4.2xlarge</code>, <code>cache.r4.4xlarge</code>, <code>cache.r4.8xlarge</code>, <code>cache.r4.16xlarge</code>  </li> <li> Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)  <b>M2 node types:</b> <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>, <code>cache.m2.4xlarge</code>   <b>R3 node types:</b> <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>, <code>cache.r3.2xlarge</code>, <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code>  </li> </ul> </li> </ul>  <b>Additional node type info</b>  <ul> <li> All current generation instance types are created in Amazon VPC by default. </li> <li> Redis append-only files (AOF) are not supported for T1 or T2 instances. </li> <li> Redis Multi-AZ with automatic failover is not supported on T1 instances. </li> <li> Redis configuration variables <code>appendonly</code> and <code>appendfsync</code> are not supported on Redis version 2.8.22 and later. </li> </ul></param>
        /// <param name="engine">The name of the cache engine to be used for this cluster. Valid values for this parameter are: <code>memcached</code> | <code>redis</code> </param>
        /// <param name="cacheSecurityGroupNames">A list of security group names to associate with this cluster. Use this parameter only when you are creating a cluster outside of an Amazon Virtual Private Cloud (Amazon VPC).</param>
        public CreateCacheClusterRequest(string cacheClusterId, int numCacheNodes, string cacheNodeType, string engine, List<string> cacheSecurityGroupNames)
        {
            _cacheClusterId = cacheClusterId;
            _numCacheNodes = numCacheNodes;
            _cacheNodeType = cacheNodeType;
            _engine = engine;
            _cacheSecurityGroupNames = cacheSecurityGroupNames;
        }

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
        /// Gets and sets the property AZMode. 
        /// <para>
        /// Specifies whether the nodes in this Memcached cluster are created in a single Availability
        /// Zone or created across multiple Availability Zones in the cluster's region.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported for Memcached clusters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>AZMode</code> and <code>PreferredAvailabilityZones</code> are not specified,
        /// ElastiCache assumes <code>single-az</code> mode.
        /// </para>
        /// </summary>
        public AZMode AZMode
        {
            get { return this._azMode; }
            set { this._azMode = value; }
        }

        // Check to see if AZMode property is set
        internal bool IsSetAZMode()
        {
            return this._azMode != null;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The node group (shard) identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        ///  <b>Constraints:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name must contain from 1 to 50 alphanumeric characters or hyphens.
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
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
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
        /// The name of the parameter group to associate with this cluster. If this argument is
        /// omitted, the default parameter group for the specified engine is used. You cannot
        /// use any parameter group which has <code>cluster-enabled='yes'</code> when creating
        /// a cluster.
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
        /// A list of security group names to associate with this cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (Amazon VPC).
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
        /// The name of the subnet group to be used for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (Amazon VPC).
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine to be used for this cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values for this parameter are: <code>memcached</code> | <code>redis</code> 
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
        /// The version number of the cache engine to be used for this cluster. To view the supported
        /// cache engine versions, use the DescribeCacheEngineVersions operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>), but you cannot downgrade to an earlier engine version.
        /// If you want to use an earlier engine version, you must delete the existing cluster
        /// or replication group and create it anew with the earlier engine version. 
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
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The initial number of cache nodes that the cluster has.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Redis, this value must be 1. For clusters running Memcached,
        /// this value must be between 1 and 40.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 40 nodes for your Memcached cluster, please fill out the ElastiCache
        /// Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/">http://aws.amazon.com/contact-us/elasticache-node-limit-request/</a>.
        /// </para>
        /// </summary>
        public int NumCacheNodes
        {
            get { return this._numCacheNodes.GetValueOrDefault(); }
            set { this._numCacheNodes = value; }
        }

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this._numCacheNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostMode. 
        /// <para>
        /// Specifies whether the nodes in the cluster are created in a single outpost or across
        /// multiple outposts.
        /// </para>
        /// </summary>
        public OutpostMode OutpostMode
        {
            get { return this._outpostMode; }
            set { this._outpostMode = value; }
        }

        // Check to see if OutpostMode property is set
        internal bool IsSetOutpostMode()
        {
            return this._outpostMode != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each of the cache nodes accepts connections.
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
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The EC2 Availability Zone in which the cluster is created.
        /// </para>
        ///  
        /// <para>
        /// All nodes belonging to this cluster are placed in the preferred Availability Zone.
        /// If you want to create your nodes across multiple Availability Zones, use <code>PreferredAvailabilityZones</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: System chosen Availability Zone.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone
        {
            get { return this._preferredAvailabilityZone; }
            set { this._preferredAvailabilityZone = value; }
        }

        // Check to see if PreferredAvailabilityZone property is set
        internal bool IsSetPreferredAvailabilityZone()
        {
            return this._preferredAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZones. 
        /// <para>
        /// A list of the Availability Zones in which cache nodes are created. The order of the
        /// zones in the list is not important.
        /// </para>
        ///  
        /// <para>
        /// This option is only supported on Memcached.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating your cluster in an Amazon VPC (recommended) you can only locate
        /// nodes in Availability Zones that are associated with the subnets in the selected subnet
        /// group.
        /// </para>
        ///  
        /// <para>
        /// The number of Availability Zones listed must equal the value of <code>NumCacheNodes</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want all the nodes in the same Availability Zone, use <code>PreferredAvailabilityZone</code>
        /// instead, or repeat the Availability Zone multiple times in the list.
        /// </para>
        ///  
        /// <para>
        /// Default: System chosen Availability Zones.
        /// </para>
        /// </summary>
        public List<string> PreferredAvailabilityZones
        {
            get { return this._preferredAvailabilityZones; }
            set { this._preferredAvailabilityZones = value; }
        }

        // Check to see if PreferredAvailabilityZones property is set
        internal bool IsSetPreferredAvailabilityZones()
        {
            return this._preferredAvailabilityZones != null && this._preferredAvailabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period. 
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
        /// Gets and sets the property PreferredOutpostArn. 
        /// <para>
        /// The outpost ARN in which the cache cluster is created.
        /// </para>
        /// </summary>
        public string PreferredOutpostArn
        {
            get { return this._preferredOutpostArn; }
            set { this._preferredOutpostArn = value; }
        }

        // Check to see if PreferredOutpostArn property is set
        internal bool IsSetPreferredOutpostArn()
        {
            return this._preferredOutpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredOutpostArns. 
        /// <para>
        /// The outpost ARNs in which the cache cluster is created.
        /// </para>
        /// </summary>
        public List<string> PreferredOutpostArns
        {
            get { return this._preferredOutpostArns; }
            set { this._preferredOutpostArns = value; }
        }

        // Check to see if PreferredOutpostArns property is set
        internal bool IsSetPreferredOutpostArns()
        {
            return this._preferredOutpostArns != null && this._preferredOutpostArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group to which this cluster should belong. If this parameter
        /// is specified, the cluster is added to the specified replication group as a read replica;
        /// otherwise, the cluster is a standalone primary that is not part of any replication
        /// group.
        /// </para>
        ///  
        /// <para>
        /// If the specified replication group is Multi-AZ enabled and the Availability Zone is
        /// not specified, the cluster is created in Availability Zones that provide the best
        /// spread of read replicas across Availability Zones.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <code>Engine</code> parameter is <code>redis</code>.
        /// </para>
        ///  </note>
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
        /// One or more VPC security groups associated with the cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (Amazon VPC).
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
        /// A single-element string list containing an Amazon Resource Name (ARN) that uniquely
        /// identifies a Redis RDB snapshot file stored in Amazon S3. The snapshot file is used
        /// to populate the node group (shard). The Amazon S3 object name in the ARN cannot contain
        /// any commas.
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
        /// The name of a Redis snapshot from which to restore data into the new node group (shard).
        /// The snapshot status changes to <code>restoring</code> while the new node group (shard)
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
        /// taken today is retained for 5 days before being deleted.
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
        /// A list of tags to be added to this resource.
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
        /// A flag that enables in-transit encryption when set to true.
        /// </para>
        ///  
        /// <para>
        ///  Only available when creating a cache cluster in an Amazon VPC using Memcached version
        /// 1.6.12 or later.
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

    }
}