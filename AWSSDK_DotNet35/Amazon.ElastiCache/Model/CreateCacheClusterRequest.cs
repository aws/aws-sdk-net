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
    /// The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in
    /// the cache cluster run the same protocol-compliant cache engine software - either Memcached
    /// or Redis.
    /// </summary>
    public partial class CreateCacheClusterRequest : AmazonElastiCacheRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private string _aZMode;
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


        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Determines whether minor engine upgrades will be applied automatically to the cache
        /// cluster during the maintenance window. A value of <code>true</code> allows these upgrades
        /// to occur; <code>false</code> disables automatic upgrades.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>true</code>
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
        /// Specifies whether the nodes in this Memcached cache cluster are created in a single
        /// Availability Zone or created across multiple Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>single-az</code> | <code>cross-az</code>.
        /// </para>
        /// </summary>
        public string AZMode
        {
            get { return this._aZMode; }
            set { this._aZMode = value; }
        }

        // Check to see if AZMode property is set
        internal bool IsSetAZMode()
        {
            return this._aZMode != null;
        }


        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cache cluster identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 20 alphanumeric characters or hyphens.</li> <li>First
        /// character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> </ul>
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
        /// The compute and memory capacity of the nodes in the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// <b>Valid cache types</b>
        /// </para>
        ///  <ul> <li>Micro
        /// <para>
        /// <code>cache.t1.micro | cache.m1.small</code>
        /// </para>
        /// </li> <li>General Purpose <ul> <li>Current Generation
        /// <para>
        /// <code>cache.m3.medium | cache.m3.large | cache.m3.xlarge | cache.m3.2xlarge</code>
        /// </para>
        /// </li> <li>Previous Generation
        /// <para>
        /// <code>cache.m1.medium | cache.m1.large | cache.m1.xlarge</code>
        /// </para>
        /// </li> </ul></li> <li>Compute Optimized
        /// <para>
        /// <code>cache.c1.xlarge</code>
        /// </para>
        /// </li> <li>Memory Optimized <ul> <li>Current Generation
        /// <para>
        /// <code>cache.r3.large | cache.r3.xlarge | cache.r3.2xlarge | cache.r3.4xlarge | cache.r3.8xlarge</code>
        /// </para>
        /// </li> <li>Previous Generation
        /// <para>
        /// <code>cache.m2.xlarge | cache.m2.2xlarge | cache.m2.4xlarge</code>
        /// </para>
        /// </li> </ul></li> </ul> 
        /// <para>
        /// For a complete listing of cache node types and specifications, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Memcached.html#CacheParameterGroups.Memcached.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Memcached</a> or <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheParameterGroups.Redis.html#CacheParameterGroups.Redis.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Redis</a> and <a href="http://aws.amazon.com/elasticache/details">Amazon
        /// ElastiCache Product Features and Details</a>.
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
        /// The name of the cache parameter group to associate with this cache cluster. If this
        /// argument is omitted, the default cache parameter group for the specified engine will
        /// be used.
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
        /// A list of cache security group names to associate with this cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (VPC).
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
        /// The name of the cache subnet group to be used for the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (VPC).
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
        /// The version number of the cache engine to be used for this cluster. To view the supported
        /// cache engine versions, use the <i>DescribeCacheEngineVersions</i> operation.
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
        /// For a Memcached cluster, valid values are between 1 and 20. If you need to exceed
        /// this limit, please fill out the ElastiCache Limit Increase Request form at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/"></a>
        /// .
        /// </para>
        ///  
        /// <para>
        /// For Redis, only single-node cache clusters are supported at this time, so the value
        /// for this parameter must be 1.
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
        /// All cache nodes belonging to this Memcached cache cluster are placed in the preferred
        /// Availability Zone. If you want to create your cache nodes across multiple Availability
        /// Zones, use <code>PreferredAvailabilityZones</code>.
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
        /// A list of the Availability Zones in which nodes will be created. The order of the
        /// zones in the list is not important.
        /// </para>
        ///  
        /// <para>
        /// This option is only supported on Memcached clusters.
        /// </para>
        ///  
        /// <para>
        /// If you want all your cache nodes in the same Availability Zone, use <code>PreferredAvailabilityZone</code>
        /// instead or repeat the Availability Zone multiple times in the list.
        /// </para>
        ///  
        /// <para>
        /// Default: System chosen Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// Example: One Memcached node in each of three Availability Zones: <code>PreferredAvailabilityZones.member.1=us-east-1a&amp;PreferredAvailabilityZones.member.2=us-east-1b&amp;PreferredAvailabilityZones.member.3=us-east-1d</code>
        /// </para>
        ///  
        /// <para>
        /// Example: All three Memcached nodes in one Availability Zone: <code>PreferredAvailabilityZones.member.1=us-east-1a&amp;PreferredAvailabilityZones.member.2=us-east-1a&amp;PreferredAvailabilityZones.member.3=us-east-1a</code>
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
        /// The weekly time range (in UTC) during which system maintenance can occur.
        /// </para>
        ///  
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
        /// The replication group to which this cache cluster should belong. If this parameter
        /// is specified, the cache cluster will be added to the specified replication group as
        /// a read replica; otherwise, the cache cluster will be a standalone primary that is
        /// not part of any replication group.
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
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (VPC).
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
        /// used to populate the Redis cache in the new cache cluster. The Amazon S3 object name
        /// in the ARN cannot contain any commas.
        /// </para>
        ///  
        /// <para>
        /// Here is an example of an Amazon S3 ARN: <code>arn:aws:s3:::my_bucket/snapshot1.rdb</code>
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This parameter is only valid if the <code>Engine</code> parameter is
        /// <code>redis</code>.
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
        /// The name of a snapshot from which to restore data into the new cache cluster. The
        /// snapshot's status changes to <code>restoring</code> while the new cache cluster is
        /// being created.
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
        /// The number of days for which ElastiCache will retain automatic cache cluster snapshots
        /// before deleting them. For example, if you set <code>SnapshotRetentionLimit</code>
        /// to 5, then a snapshot that was taken today will be retained for 5 days before being
        /// deleted.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, then <code>SnapshotRetentionLimit</code> will
        /// be set to 0 (i.e., automatic backups will be disabled for this cache cluster).
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
        /// of your cache cluster.
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

    }
}