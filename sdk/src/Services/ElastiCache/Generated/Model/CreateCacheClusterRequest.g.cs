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
    /// Container for the parameters to the CreateCacheCluster operation. Creates a cluster.
    /// All nodes in the cluster run the same protocol-compliant cache engine software, either
    /// Memcached, Valkey or Redis OSS. <para> This operation is not supported for Valkey
    /// or Redis OSS (cluster mode enabled) clusters. </para>
    /// </summary>
    public partial class CreateCacheClusterRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateCacheClusterRequest() { }

        /// <summary>
        /// Instantiates CreateCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The node group (shard) identifier. This parameter is stored as a lowercase   string.      <b>Constraints:</b>      <ul>   <li>      A name must contain from 1 to 50 alphanumeric characters or hyphens.   </li>   <li>      The first character must be a letter.   </li>   <li>      A name cannot end with a hyphen or contain two consecutive hyphens.   </li>   </ul></param>
        /// <param name="numCacheNodes">The initial number of cache nodes that the cluster has.   For clusters running Valkey or Redis OSS, this value must be 1. For clusters running Memcached, this   value must be between 1 and 40.   If you need more than 40 nodes for your Memcached cluster, please fill out the   ElastiCache Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/">http://aws.amazon.com/contact-us/elasticache-node-limit-request/</a>.</param>
        /// <param name="cacheNodeType">The compute and memory capacity of the nodes in the node group (shard).   The following node types are supported by ElastiCache. Generally speaking, the current   generation types provide more memory and computational power at lower cost when compared   to their equivalent previous generation counterparts.   <ul>   <li>      General purpose:      <ul>      <li>      Current generation:             <b>M7g node types</b>: 					<c>cache.m7g.large</c>, 					<c>cache.m7g.xlarge</c>, 					<c>cache.m7g.2xlarge</c>, 					<c>cache.m7g.4xlarge</c>, 					<c>cache.m7g.8xlarge</c>, 					<c>cache.m7g.12xlarge</c>, 					<c>cache.m7g.16xlarge</c>            <note>      For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported Node Types</a>            </note>            <b>M6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and for Memcached engine version 1.5.16 onward):					 					 	<c>cache.m6g.large</c>,							<c>cache.m6g.xlarge</c>,							<c>cache.m6g.2xlarge</c>,							<c>cache.m6g.4xlarge</c>,							<c>cache.m6g.8xlarge</c>,							<c>cache.m6g.12xlarge</c>,							<c>cache.m6g.16xlarge</c>                  <b>M5 node types:</b>      <c>cache.m5.large</c>, 						<c>cache.m5.xlarge</c>, 						<c>cache.m5.2xlarge</c>, 						<c>cache.m5.4xlarge</c>, 						<c>cache.m5.12xlarge</c>, 						<c>cache.m5.24xlarge</c>                  <b>M4 node types:</b>      <c>cache.m4.large</c>, 						<c>cache.m4.xlarge</c>, 						<c>cache.m4.2xlarge</c>, 						<c>cache.m4.4xlarge</c>, 						<c>cache.m4.10xlarge</c>                  <b>T4g node types</b> (available only for Redis OSS engine version 5.0.6 onward and Memcached engine version 1.5.16 onward):					  <c>cache.t4g.micro</c>,					  <c>cache.t4g.small</c>,					  <c>cache.t4g.medium</c>                  <b>T3 node types:</b>      <c>cache.t3.micro</c>,  						<c>cache.t3.small</c>, 						<c>cache.t3.medium</c>                  <b>T2 node types:</b>      <c>cache.t2.micro</c>,  						<c>cache.t2.small</c>, 						<c>cache.t2.medium</c>            </li>      <li>      Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)            <b>T1 node types:</b>      <c>cache.t1.micro</c>                  <b>M1 node types:</b>      <c>cache.m1.small</c>, 						   <c>cache.m1.medium</c>, 						   <c>cache.m1.large</c>,						   <c>cache.m1.xlarge</c>                  <b>M3 node types:</b>      <c>cache.m3.medium</c>, 						<c>cache.m3.large</c>,  						<c>cache.m3.xlarge</c>, 						<c>cache.m3.2xlarge</c>            </li>      </ul>   </li>   <li>      Compute optimized:      <ul>      <li>      Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)            <b>C1 node types:</b>      <c>cache.c1.xlarge</c>            </li>      </ul>   </li>   <li>      Memory optimized:      <ul>      <li>      Current generation:             <b>R7g node types</b>:								<c>cache.r7g.large</c>,							<c>cache.r7g.xlarge</c>,							<c>cache.r7g.2xlarge</c>,							<c>cache.r7g.4xlarge</c>,							<c>cache.r7g.8xlarge</c>,							<c>cache.r7g.12xlarge</c>,							<c>cache.r7g.16xlarge</c>            <note>      For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported Node Types</a>            </note>            <b>R6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and for Memcached engine version 1.5.16 onward):							<c>cache.r6g.large</c>,							<c>cache.r6g.xlarge</c>,							<c>cache.r6g.2xlarge</c>,							<c>cache.r6g.4xlarge</c>,							<c>cache.r6g.8xlarge</c>,							<c>cache.r6g.12xlarge</c>,							<c>cache.r6g.16xlarge</c>                  <b>R5 node types:</b>      <c>cache.r5.large</c>, 					   <c>cache.r5.xlarge</c>, 					   <c>cache.r5.2xlarge</c>, 					   <c>cache.r5.4xlarge</c>, 					   <c>cache.r5.12xlarge</c>, 					   <c>cache.r5.24xlarge</c>                  <b>R4 node types:</b>      <c>cache.r4.large</c>, 					   <c>cache.r4.xlarge</c>, 					   <c>cache.r4.2xlarge</c>, 					   <c>cache.r4.4xlarge</c>, 					   <c>cache.r4.8xlarge</c>, 					   <c>cache.r4.16xlarge</c>            </li>      <li>      Previous generation: (not recommended. Existing clusters are still supported but creation of new clusters is not supported for these types.)            <b>M2 node types:</b>      <c>cache.m2.xlarge</c>,  						<c>cache.m2.2xlarge</c>, 						<c>cache.m2.4xlarge</c>                  <b>R3 node types:</b>      <c>cache.r3.large</c>,  						<c>cache.r3.xlarge</c>, 						<c>cache.r3.2xlarge</c>,   						<c>cache.r3.4xlarge</c>, 						<c>cache.r3.8xlarge</c>            </li>      </ul>   </li>   </ul>      <b>Additional node type info</b>      <ul>   <li>      All current generation instance types are created in Amazon VPC by     default.   </li>   <li>      Valkey or Redis OSS append-only files (AOF) are not supported for T1 or T2 instances.   </li>   <li>      Valkey or Redis OSS Multi-AZ with automatic failover is not supported on T1     instances.   </li>   <li>      The configuration variables <c>appendonly</c> and      <c>appendfsync</c> are not supported on Valkey, or on Redis OSS version 2.8.22 and     later.   </li>   </ul></param>
        /// <param name="engine">The name of the cache engine to be used for this cluster.   Valid values for this parameter are: <c>memcached</c> |   <c>redis</c>   </param>
        /// <param name="cacheSecurityGroupNames">A list of security group names to associate with this cluster.   Use this parameter only when you are creating a cluster outside of an Amazon Virtual   Private Cloud (Amazon VPC).</param>
        public CreateCacheClusterRequest(string cacheClusterId, int? numCacheNodes, string cacheNodeType, string engine, List<string> cacheSecurityGroupNames)
        {
            this.CacheClusterId = cacheClusterId;
            this.NumCacheNodes = numCacheNodes;
            this.CacheNodeType = cacheNodeType;
            this.Engine = engine;
            this.CacheSecurityGroupNames = cacheSecurityGroupNames;
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
        /// If the <c>AZMode</c> and <c>PreferredAvailabilityZones</c> are not specified, ElastiCache
        /// assumes <c>single-az</c> mode.
        /// </para>
        /// </summary>
        public AZMode AZMode { get; set; }

        /// <summary>
        /// Checks to see if the AZMode property is set.
        /// </summary>
        internal bool IsSetAZMode() => this.AZMode != null;

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
        /// The only permitted printable special characters are !, &amp;, #, $, ^, &lt;, >, and
        /// -. Other printable special characters cannot be used in the AUTH token.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://redis.io/commands/AUTH">AUTH password</a>
        /// at http://redis.io/commands/AUTH.
        /// </para>
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  If you are running Valkey 7.2 and above or Redis OSS engine version 6.0 and above,
        /// set this parameter to yes to opt-in to the next auto minor version upgrade campaign.
        /// This parameter is disabled for previous versions. 
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
        [AWSProperty(Required = true)]
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

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
        ///  <b>M7g node types</b>: <c>cache.m7g.large</c>, <c>cache.m7g.xlarge</c>, <c>cache.m7g.2xlarge</c>,
        /// <c>cache.m7g.4xlarge</c>, <c>cache.m7g.8xlarge</c>, <c>cache.m7g.12xlarge</c>, <c>cache.m7g.16xlarge</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
        /// Node Types</a> 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>M6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
        /// for Memcached engine version 1.5.16 onward): <c>cache.m6g.large</c>, <c>cache.m6g.xlarge</c>,
        /// <c>cache.m6g.2xlarge</c>, <c>cache.m6g.4xlarge</c>, <c>cache.m6g.8xlarge</c>, <c>cache.m6g.12xlarge</c>,
        /// <c>cache.m6g.16xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M5 node types:</b> <c>cache.m5.large</c>, <c>cache.m5.xlarge</c>, <c>cache.m5.2xlarge</c>,
        /// <c>cache.m5.4xlarge</c>, <c>cache.m5.12xlarge</c>, <c>cache.m5.24xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M4 node types:</b> <c>cache.m4.large</c>, <c>cache.m4.xlarge</c>, <c>cache.m4.2xlarge</c>,
        /// <c>cache.m4.4xlarge</c>, <c>cache.m4.10xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>T4g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
        /// Memcached engine version 1.5.16 onward): <c>cache.t4g.micro</c>, <c>cache.t4g.small</c>,
        /// <c>cache.t4g.medium</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>T3 node types:</b> <c>cache.t3.micro</c>, <c>cache.t3.small</c>, <c>cache.t3.medium</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>T2 node types:</b> <c>cache.t2.micro</c>, <c>cache.t2.small</c>, <c>cache.t2.medium</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended. Existing clusters are still supported but creation
        /// of new clusters is not supported for these types.)
        /// </para>
        ///  
        /// <para>
        ///  <b>T1 node types:</b> <c>cache.t1.micro</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M1 node types:</b> <c>cache.m1.small</c>, <c>cache.m1.medium</c>, <c>cache.m1.large</c>,
        /// <c>cache.m1.xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M3 node types:</b> <c>cache.m3.medium</c>, <c>cache.m3.large</c>, <c>cache.m3.xlarge</c>,
        /// <c>cache.m3.2xlarge</c> 
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
        ///  <b>C1 node types:</b> <c>cache.c1.xlarge</c> 
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
        ///  <b>R7g node types</b>: <c>cache.r7g.large</c>, <c>cache.r7g.xlarge</c>, <c>cache.r7g.2xlarge</c>,
        /// <c>cache.r7g.4xlarge</c>, <c>cache.r7g.8xlarge</c>, <c>cache.r7g.12xlarge</c>, <c>cache.r7g.16xlarge</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
        /// Node Types</a> 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>R6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
        /// for Memcached engine version 1.5.16 onward): <c>cache.r6g.large</c>, <c>cache.r6g.xlarge</c>,
        /// <c>cache.r6g.2xlarge</c>, <c>cache.r6g.4xlarge</c>, <c>cache.r6g.8xlarge</c>, <c>cache.r6g.12xlarge</c>,
        /// <c>cache.r6g.16xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>R5 node types:</b> <c>cache.r5.large</c>, <c>cache.r5.xlarge</c>, <c>cache.r5.2xlarge</c>,
        /// <c>cache.r5.4xlarge</c>, <c>cache.r5.12xlarge</c>, <c>cache.r5.24xlarge</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>R4 node types:</b> <c>cache.r4.large</c>, <c>cache.r4.xlarge</c>, <c>cache.r4.2xlarge</c>,
        /// <c>cache.r4.4xlarge</c>, <c>cache.r4.8xlarge</c>, <c>cache.r4.16xlarge</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended. Existing clusters are still supported but creation
        /// of new clusters is not supported for these types.)
        /// </para>
        ///  
        /// <para>
        ///  <b>M2 node types:</b> <c>cache.m2.xlarge</c>, <c>cache.m2.2xlarge</c>, <c>cache.m2.4xlarge</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>R3 node types:</b> <c>cache.r3.large</c>, <c>cache.r3.xlarge</c>, <c>cache.r3.2xlarge</c>,
        /// <c>cache.r3.4xlarge</c>, <c>cache.r3.8xlarge</c> 
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
        /// Valkey or Redis OSS append-only files (AOF) are not supported for T1 or T2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valkey or Redis OSS Multi-AZ with automatic failover is not supported on T1 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The configuration variables <c>appendonly</c> and <c>appendfsync</c> are not supported
        /// on Valkey, or on Redis OSS version 2.8.22 and later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CacheNodeType { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeType property is set.
        /// </summary>
        internal bool IsSetCacheNodeType() => this.CacheNodeType != null;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the parameter group to associate with this cluster. If this argument is
        /// omitted, the default parameter group for the specified engine is used. You cannot
        /// use any parameter group which has <c>cluster-enabled='yes'</c> when creating a cluster.
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
        /// A list of security group names to associate with this cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (Amazon VPC).
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
        /// group before you start creating a cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SubnetGroups.html">Subnets
        /// and Subnet Groups</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string CacheSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetCacheSubnetGroupName() => this.CacheSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine to be used for this cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values for this parameter are: <c>memcached</c> | <c>redis</c> 
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
        /// The version number of the cache engine to be used for this cluster. To view the supported
        /// cache engine versions, use the DescribeCacheEngineVersions operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> You can upgrade to a newer engine version (see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SelectEngine.html#VersionManagement">Selecting
        /// a Cache Engine and Version</a>), but you cannot downgrade to an earlier engine version.
        /// If you want to use an earlier engine version, you must delete the existing cluster
        /// or replication group and create it anew with the earlier engine version. 
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Must be either <c>ipv4</c> | <c>ipv6</c> | <c>dual_stack</c>. IPv6 is supported for
        /// workloads using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 and Memcached
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
        public string NotificationTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTopicArn property is set.
        /// </summary>
        internal bool IsSetNotificationTopicArn() => this.NotificationTopicArn != null;

        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The initial number of cache nodes that the cluster has.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters running
        /// Memcached, this value must be between 1 and 40.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 40 nodes for your Memcached cluster, please fill out the ElastiCache
        /// Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/">http://aws.amazon.com/contact-us/elasticache-node-limit-request/</a>.
        /// </para>
        /// </summary>
        public int? NumCacheNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumCacheNodes property is set.
        /// </summary>
        internal bool IsSetNumCacheNodes() => this.NumCacheNodes.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostMode. 
        /// <para>
        /// Specifies whether the nodes in the cluster are created in a single outpost or across
        /// multiple outposts.
        /// </para>
        /// </summary>
        public OutpostMode OutpostMode { get; set; }

        /// <summary>
        /// Checks to see if the OutpostMode property is set.
        /// </summary>
        internal bool IsSetOutpostMode() => this.OutpostMode != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each of the cache nodes accepts connections.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The EC2 Availability Zone in which the cluster is created.
        /// </para>
        ///  
        /// <para>
        /// All nodes belonging to this cluster are placed in the preferred Availability Zone.
        /// If you want to create your nodes across multiple Availability Zones, use <c>PreferredAvailabilityZones</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: System chosen Availability Zone.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the PreferredAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetPreferredAvailabilityZone() => this.PreferredAvailabilityZone != null;

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
        /// The number of Availability Zones listed must equal the value of <c>NumCacheNodes</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want all the nodes in the same Availability Zone, use <c>PreferredAvailabilityZone</c>
        /// instead, or repeat the Availability Zone multiple times in the list.
        /// </para>
        ///  
        /// <para>
        /// Default: System chosen Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PreferredAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PreferredAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetPreferredAvailabilityZones() => this.PreferredAvailabilityZones != null && (this.PreferredAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period. 
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PreferredOutpostArn. 
        /// <para>
        /// The outpost ARN in which the cache cluster is created.
        /// </para>
        /// </summary>
        public string PreferredOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the PreferredOutpostArn property is set.
        /// </summary>
        internal bool IsSetPreferredOutpostArn() => this.PreferredOutpostArn != null;

        /// <summary>
        /// Gets and sets the property PreferredOutpostArns. 
        /// <para>
        /// The outpost ARNs in which the cache cluster is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PreferredOutpostArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PreferredOutpostArns property is set.
        /// </summary>
        internal bool IsSetPreferredOutpostArns() => this.PreferredOutpostArns != null && (this.PreferredOutpostArns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// This parameter is only valid if the <c>Engine</c> parameter is <c>redis</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

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
        /// Gets and sets the property SnapshotArns. 
        /// <para>
        /// A single-element string list containing an Amazon Resource Name (ARN) that uniquely
        /// identifies a Valkey or Redis OSS RDB snapshot file stored in Amazon S3. The snapshot
        /// file is used to populate the node group (shard). The Amazon S3 object name in the
        /// ARN cannot contain any commas.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <c>Engine</c> parameter is <c>redis</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Example of an Amazon S3 ARN: <c>arn:aws:s3:::my_bucket/snapshot1.rdb</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotArns property is set.
        /// </summary>
        internal bool IsSetSnapshotArns() => this.SnapshotArns != null && (this.SnapshotArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of a Valkey or Redis OSS snapshot from which to restore data into the new
        /// node group (shard). The snapshot status changes to <c>restoring</c> while the new
        /// node group (shard) is being created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <c>Engine</c> parameter is <c>redis</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic snapshots before deleting
        /// them. For example, if you set <c>SnapshotRetentionLimit</c> to 5, a snapshot taken
        /// today is retained for 5 days before being deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid if the <c>Engine</c> parameter is <c>redis</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: 0 (i.e., automatic backups are disabled for this cache cluster).
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true.
        /// </para>
        /// </summary>
        public bool? TransitEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionEnabled() => this.TransitEncryptionEnabled.HasValue;
    }
}
