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
    /// Container for the parameters to the CreateCacheCluster operation.
    /// The <i>CreateCacheCluster</i> action creates a cache cluster. All nodes in the cache
    /// cluster run the same protocol-compliant cache engine software, either Memcached or
    /// Redis.
    /// </summary>
    public partial class CreateCacheClusterRequest : AmazonElastiCacheRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private AZMode _azMode;
        private string _cacheClusterId;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _cacheSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private string _notificationTopicArn;
        private int? _numCacheNodes;
        private int? _port;
        private string _preferredAvailabilityZone;
        private List<string> _preferredAvailabilityZones = new List<string>();
        private string _preferredMaintenanceWindow;
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _snapshotArns = new List<string>();
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCacheClusterRequest() { }

        /// <summary>
        /// Instantiates CreateCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The node group identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>A name must contain from 1 to 20 alphanumeric characters or hyphens.</li> <li>The first character must be a letter.</li> <li>A name cannot end with a hyphen or contain two consecutive hyphens.</li> </ul></param>
        /// <param name="numCacheNodes">The initial number of cache nodes that the cache cluster will have. For clusters running Redis, this value must be 1. For clusters running Memcached, this value must be between 1 and 20. If you need more than 20 nodes for your Memcached cluster, please fill out the ElastiCache Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/">http://aws.amazon.com/contact-us/elasticache-node-limit-request/</a>.</param>
        /// <param name="cacheNodeType">The compute and memory capacity of the nodes in the node group. Valid node types are as follows: <ul> <li>General purpose: <ul> <li>Current generation: <code>cache.t2.micro</code>, <code>cache.t2.small</code>, <code>cache.t2.medium</code>, <code>cache.m3.medium</code>, <code>cache.m3.large</code>, <code>cache.m3.xlarge</code>, <code>cache.m3.2xlarge</code></li> <li>Previous generation: <code>cache.t1.micro</code>, <code>cache.m1.small</code>, <code>cache.m1.medium</code>, <code>cache.m1.large</code>, <code>cache.m1.xlarge</code></li> </ul></li> <li>Compute optimized: <code>cache.c1.xlarge</code></li> <li>Memory optimized <ul> <li>Current generation: <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>, <code>cache.r3.2xlarge</code>, <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code></li> <li>Previous generation: <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>, <code>cache.m2.4xlarge</code></li> </ul></li> </ul> <b>Notes:</b> <ul> <li>All t2 instances are created in an Amazon Virtual Private Cloud (VPC).</li> <li>Redis backup/restore is not supported for t2 instances.</li> <li>Redis Append-only files (AOF) functionality is not supported for t1 or t2 instances.</li> </ul> For a complete listing of cache node types and specifications, see <a href="http://aws.amazon.com/elasticache/details">Amazon ElastiCache Product Features and Details</a> and <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Memcached.html#CacheParameterGroups.Memcached.NodeSpecific">Cache Node Type-Specific Parameters for Memcached</a> or <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Redis.html#CacheParameterGroups.Redis.NodeSpecific">Cache Node Type-Specific Parameters for Redis</a>. </param>
        /// <param name="engine">The name of the cache engine to be used for this cache cluster. Valid values for this parameter are: <code>memcached</code> | <code>redis</code></param>
        /// <param name="cacheSecurityGroupNames">A list of security group names to associate with this cache cluster. Use this parameter only when you are creating a cache cluster outside of an Amazon Virtual Private Cloud (VPC).</param>
        public CreateCacheClusterRequest(string cacheClusterId, int numCacheNodes, string cacheNodeType, string engine, List<string> cacheSecurityGroupNames)
        {
            _cacheClusterId = cacheClusterId;
            _numCacheNodes = numCacheNodes;
            _cacheNodeType = cacheNodeType;
            _engine = engine;
            _cacheSecurityGroupNames = cacheSecurityGroupNames;
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
        /// Gets and sets the property AZMode. 
        /// <para>
        /// Specifies whether the nodes in this Memcached node group are created in a single Availability
        /// Zone or created across multiple Availability Zones in the cluster's region.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported for Memcached cache clusters.
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
        /// The node group identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>A name must contain from 1 to 20 alphanumeric characters or hyphens.</li>
        /// <li>The first character must be a letter.</li> <li>A name cannot end with a hyphen
        /// or contain two consecutive hyphens.</li> </ul>
        /// </summary>
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
        /// The compute and memory capacity of the nodes in the node group.
        /// </para>
        ///  
        /// <para>
        /// Valid node types are as follows:
        /// </para>
        ///  <ul> <li>General purpose: <ul> <li>Current generation: <code>cache.t2.micro</code>,
        /// <code>cache.t2.small</code>, <code>cache.t2.medium</code>, <code>cache.m3.medium</code>,
        /// <code>cache.m3.large</code>, <code>cache.m3.xlarge</code>, <code>cache.m3.2xlarge</code></li>
        /// <li>Previous generation: <code>cache.t1.micro</code>, <code>cache.m1.small</code>,
        /// <code>cache.m1.medium</code>, <code>cache.m1.large</code>, <code>cache.m1.xlarge</code></li>
        /// </ul></li> <li>Compute optimized: <code>cache.c1.xlarge</code></li> <li>Memory optimized
        /// <ul> <li>Current generation: <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>,
        /// <code>cache.r3.2xlarge</code>, <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code></li>
        /// <li>Previous generation: <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>,
        /// <code>cache.m2.4xlarge</code></li> </ul></li> </ul> 
        /// <para>
        /// <b>Notes:</b>
        /// </para>
        ///  <ul> <li>All t2 instances are created in an Amazon Virtual Private Cloud (VPC).</li>
        /// <li>Redis backup/restore is not supported for t2 instances.</li> <li>Redis Append-only
        /// files (AOF) functionality is not supported for t1 or t2 instances.</li> </ul> 
        /// <para>
        /// For a complete listing of cache node types and specifications, see <a href="http://aws.amazon.com/elasticache/details">Amazon
        /// ElastiCache Product Features and Details</a> and <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Memcached.html#CacheParameterGroups.Memcached.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Memcached</a> or <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Redis.html#CacheParameterGroups.Redis.NodeSpecific">Cache
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
        /// The name of the parameter group to associate with this cache cluster. If this argument
        /// is omitted, the default parameter group for the specified engine is used.
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
        /// A list of security group names to associate with this cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cache cluster outside of an Amazon
        /// Virtual Private Cloud (VPC).
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
        /// The name of the subnet group to be used for the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cache cluster in an Amazon Virtual
        /// Private Cloud (VPC).
        /// </para>
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
        /// The name of the cache engine to be used for this cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values for this parameter are:
        /// </para>
        ///  
        /// <para>
        /// <code>memcached</code> | <code>redis</code>
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
        /// The version number of the cache engine to be used for this cache cluster. To view
        /// the supported cache engine versions, use the <i>DescribeCacheEngineVersions</i> action.
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
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic
        /// to which notifications will be sent.
        /// </para>
        ///  <note>The Amazon SNS topic owner must be the same as the cache cluster owner.</note>
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
        /// The initial number of cache nodes that the cache cluster will have.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Redis, this value must be 1. For clusters running Memcached,
        /// this value must be between 1 and 20.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 20 nodes for your Memcached cluster, please fill out the ElastiCache
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each of the cache nodes will accept connections.
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
        /// The EC2 Availability Zone in which the cache cluster will be created.
        /// </para>
        ///  
        /// <para>
        /// All nodes belonging to this Memcached cache cluster are placed in the preferred Availability
        /// Zone. If you want to create your nodes across multiple Availability Zones, use <code>PreferredAvailabilityZones</code>.
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
        /// A list of the Availability Zones in which cache nodes will be created. The order of
        /// the zones in the list is not important.
        /// </para>
        ///  
        /// <para>
        /// This option is only supported on Memcached.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are creating your cache cluster in an Amazon VPC (recommended) you can only
        /// locate nodes in Availability Zones that are associated with the subnets in the selected
        /// subnet group.
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
        ///  
        /// <para>
        /// Example: One Memcached node in each of three different Availability Zones: <code>PreferredAvailabilityZones.member.1=us-west-2a&amp;PreferredAvailabilityZones.member.2=us-west-2b&amp;PreferredAvailabilityZones.member.3=us-west-2c</code>
        /// </para>
        ///  
        /// <para>
        /// Example: All three Memcached nodes in one Availability Zone: <code>PreferredAvailabilityZones.member.1=us-west-2a&amp;PreferredAvailabilityZones.member.2=us-west-2a&amp;PreferredAvailabilityZones.member.3=us-west-2a</code>
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
        /// Specifies the weekly time range during which maintenance on the cache cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period. Valid values for <code>ddd</code>
        /// are:
        /// </para>
        ///  <ul> <li><code>sun</code></li> <li><code>mon</code></li> <li><code>tue</code></li>
        /// <li><code>wed</code></li> <li><code>thu</code></li> <li><code>fri</code></li> <li><code>sat</code></li>
        /// </ul> 
        /// <para>
        /// Example: <code>sun:05:00-sun:09:00</code>
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
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group to which this cache cluster should belong. If this
        /// parameter is specified, the cache cluster will be added to the specified replication
        /// group as a read replica; otherwise, the cache cluster will be a standalone primary
        /// that is not part of any replication group.
        /// </para>
        ///  
        /// <para>
        /// If the specified replication group is Multi-AZ enabled and the availability zone is
        /// not specified, the cache cluster will be created in availability zones that provide
        /// the best spread of read replicas across availability zones.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more VPC security groups associated with the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cache cluster in an Amazon Virtual
        /// Private Cloud (VPC).
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
        /// identifies a Redis RDB snapshot file stored in Amazon S3. The snapshot file will be
        /// used to populate the node group. The Amazon S3 object name in the ARN cannot contain
        /// any commas.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
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
        /// The name of a snapshot from which to restore data into the new node group. The snapshot
        /// status changes to <code>restoring</code> while the new node group is being created.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
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
        /// The number of days for which ElastiCache will retain automatic snapshots before deleting
        /// them. For example, if you set <code>SnapshotRetentionLimit</code> to 5, then a snapshot
        /// that was taken today will be retained for 5 days before being deleted.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
        /// </para>
        ///  
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
        /// The daily time range (in UTC) during which ElastiCache will begin taking a daily snapshot
        /// of your node group.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>05:00-09:00</code>
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, then ElastiCache will automatically choose an
        /// appropriate time range.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
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