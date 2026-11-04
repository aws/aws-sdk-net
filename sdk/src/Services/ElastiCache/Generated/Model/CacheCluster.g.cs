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
    /// Contains all of the attributes of a specific cluster.
    /// </summary>
    public partial class CacheCluster
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the cache cluster.
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
        /// A flag that enables encryption at-rest when set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <c>AtRestEncryptionEnabled</c> after the cluster is
        /// created. To enable at-rest encryption on a cluster you must set <c>AtRestEncryptionEnabled</c>
        /// to <c>true</c> when you create a cluster.
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
        /// Gets and sets the property CacheClusterCreateTime. 
        /// <para>
        /// The date and time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CacheClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetCacheClusterCreateTime() => this.CacheClusterCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The user-supplied identifier of the cluster. This identifier is a unique key that
        /// identifies a cluster.
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheClusterStatus. 
        /// <para>
        /// The current state of this cluster, one of the following values: <c>available</c>,
        /// <c>creating</c>, <c>deleted</c>, <c>deleting</c>, <c>incompatible-network</c>, <c>modifying</c>,
        /// <c>rebooting cluster nodes</c>, <c>restore-failed</c>, or <c>snapshotting</c>.
        /// </para>
        /// </summary>
        public string CacheClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterStatus property is set.
        /// </summary>
        internal bool IsSetCacheClusterStatus() => this.CacheClusterStatus != null;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The name of the compute and memory capacity node type for the cluster.
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
        /// Gets and sets the property CacheNodes. 
        /// <para>
        /// A list of cache nodes that are members of the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheNode> CacheNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheNode>() : null;

        /// <summary>
        /// Checks to see if the CacheNodes property is set.
        /// </summary>
        internal bool IsSetCacheNodes() => this.CacheNodes != null && (this.CacheNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CacheParameterGroup. 
        /// <para>
        /// Status of the cache parameter group.
        /// </para>
        /// </summary>
        public CacheParameterGroupStatus CacheParameterGroup { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroup property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroup() => this.CacheParameterGroup != null;

        /// <summary>
        /// Gets and sets the property CacheSecurityGroups. 
        /// <para>
        /// A list of cache security group elements, composed of name and status sub-elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheSecurityGroupMembership> CacheSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the CacheSecurityGroups property is set.
        /// </summary>
        internal bool IsSetCacheSecurityGroups() => this.CacheSecurityGroups != null && (this.CacheSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group associated with the cluster.
        /// </para>
        /// </summary>
        public string CacheSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetCacheSubnetGroupName() => this.CacheSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property ClientDownloadLandingPage. 
        /// <para>
        /// The URL of the web page where you can download the latest ElastiCache client library.
        /// </para>
        /// </summary>
        public string ClientDownloadLandingPage { get; set; }

        /// <summary>
        /// Checks to see if the ClientDownloadLandingPage property is set.
        /// </summary>
        internal bool IsSetClientDownloadLandingPage() => this.ClientDownloadLandingPage != null;

        /// <summary>
        /// Gets and sets the property ConfigurationEndpoint. 
        /// <para>
        /// Represents a Memcached cluster endpoint which can be used by an application to connect
        /// to any node in the cluster. The configuration endpoint will always have <c>.cfg</c>
        /// in it.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mem-3.9dvc4r<u>.cfg</u>.usw2.cache.amazonaws.com:11211</c> 
        /// </para>
        /// </summary>
        public Endpoint ConfigurationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationEndpoint property is set.
        /// </summary>
        internal bool IsSetConfigurationEndpoint() => this.ConfigurationEndpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine (<c>memcached</c> or <c>redis</c>) to be used for this
        /// cluster.
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
        /// The version of the cache engine that is used in this cluster.
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
        /// The network type associated with the cluster, either <c>ipv4</c> | <c>ipv6</c>. IPv6
        /// is supported for workloads using Valkey 7.2 and above, Redis OSS engine version 6.2
        /// to 7.1 or Memcached engine version 1.6.6 and above on all instances built on the <a
        /// href="http://aws.amazon.com/ec2/nitro/">Nitro system</a>.
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Must be either <c>ipv4</c> | <c>ipv6</c> | <c>dual_stack</c>. IPv6 is supported for
        /// workloads using Valkey 7.2 and above, Redis OSS engine version 6.2 7.1 or Memcached
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
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Describes a notification topic and its status. Notification topics are used for publishing
        /// ElastiCache events to subscribers using Amazon Simple Notification Service (SNS).
        /// 
        /// </para>
        /// </summary>
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes in the cluster.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters running
        /// Memcached, this value must be between 1 and 40.
        /// </para>
        /// </summary>
        public int? NumCacheNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumCacheNodes property is set.
        /// </summary>
        internal bool IsSetNumCacheNodes() => this.NumCacheNodes.HasValue;

        /// <summary>
        /// Gets and sets the property PendingModifiedValues.
        /// </summary>
        public PendingModifiedValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the cluster is located or "Multiple" if
        /// the cache nodes are located in different Availability Zones.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the PreferredAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetPreferredAvailabilityZone() => this.PreferredAvailabilityZone != null;

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
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The replication group to which this cluster belongs. If this field is empty, the cluster
        /// is not associated with any replication group.
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupLogDeliveryEnabled. 
        /// <para>
        /// A boolean value indicating whether log delivery is enabled for the replication group.
        /// </para>
        /// </summary>
        public bool? ReplicationGroupLogDeliveryEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupLogDeliveryEnabled property is set.
        /// </summary>
        internal bool IsSetReplicationGroupLogDeliveryEnabled() => this.ReplicationGroupLogDeliveryEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of VPC Security Groups associated with the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic cluster snapshots before
        /// deleting them. For example, if you set <c>SnapshotRetentionLimit</c> to 5, a snapshot
        /// that was taken today is retained for 5 days before being deleted.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If the value of SnapshotRetentionLimit is set to zero (0), backups are turned off.
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
        /// of your cluster.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>05:00-09:00</c> 
        /// </para>
        /// </summary>
        public string SnapshotWindow { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWindow property is set.
        /// </summary>
        internal bool IsSetSnapshotWindow() => this.SnapshotWindow != null;

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
    }
}
