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
    /// Represents a copy of an entire Redis cache cluster as of the time when the snapshot
    /// was taken.
    /// </summary>
    public partial class Snapshot
    {
        private AutomaticFailoverStatus _automaticFailover;
        private bool? _autoMinorVersionUpgrade;
        private DateTime? _cacheClusterCreateTime;
        private string _cacheClusterId;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private string _cacheSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private List<NodeSnapshot> _nodeSnapshots = new List<NodeSnapshot>();
        private int? _numCacheNodes;
        private int? _numNodeGroups;
        private int? _port;
        private string _preferredAvailabilityZone;
        private string _preferredMaintenanceWindow;
        private string _replicationGroupDescription;
        private string _replicationGroupId;
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotSource;
        private string _snapshotStatus;
        private string _snapshotWindow;
        private string _topicArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates the status of Multi-AZ for the source replication group.
        /// </para>
        ///  <note> 
        /// <para>
        /// ElastiCache Multi-AZ replication groups are not supported on:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Redis versions earlier than 2.8.6.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis (cluster mode disabled):T1 and T2 cache node types.
        /// </para>
        ///  
        /// <para>
        /// Redis (cluster mode enabled): T1 node types.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property CacheClusterCreateTime. 
        /// <para>
        /// The date and time when the source cache cluster was created.
        /// </para>
        /// </summary>
        public DateTime CacheClusterCreateTime
        {
            get { return this._cacheClusterCreateTime.GetValueOrDefault(); }
            set { this._cacheClusterCreateTime = value; }
        }

        // Check to see if CacheClusterCreateTime property is set
        internal bool IsSetCacheClusterCreateTime()
        {
            return this._cacheClusterCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The user-supplied identifier of the source cache cluster.
        /// </para>
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
        /// The name of the compute and memory capacity node type for the source cache cluster.
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
        /// The cache parameter group that is associated with the source cache cluster.
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
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group associated with the source cache cluster.
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
        /// The name of the cache engine (<code>memcached</code> or <code>redis</code>) used by
        /// the source cache cluster.
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
        /// The version of the cache engine version that is used by the source cache cluster.
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
        /// Gets and sets the property NodeSnapshots. 
        /// <para>
        /// A list of the cache nodes in the source cache cluster.
        /// </para>
        /// </summary>
        public List<NodeSnapshot> NodeSnapshots
        {
            get { return this._nodeSnapshots; }
            set { this._nodeSnapshots = value; }
        }

        // Check to see if NodeSnapshots property is set
        internal bool IsSetNodeSnapshots()
        {
            return this._nodeSnapshots != null && this._nodeSnapshots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes in the source cache cluster.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Redis, this value must be 1. For clusters running Memcached,
        /// this value must be between 1 and 20.
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
        /// Gets and sets the property NumNodeGroups. 
        /// <para>
        /// The number of node groups (shards) in this snapshot. When restoring from a snapshot,
        /// the number of node groups (shards) in the snapshot and in the restored replication
        /// group must be the same.
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
        /// The port number used by each cache nodes in the source cache cluster.
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
        /// The name of the Availability Zone in which the source cache cluster is located.
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
        /// Gets and sets the property ReplicationGroupDescription. 
        /// <para>
        /// A description of the source replication group.
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
        /// The unique identifier of the source replication group.
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
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of a snapshot. For an automatic snapshot, the name is system-generated. For
        /// a manual snapshot, this is the user-provided name.
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
        /// For an automatic snapshot, the number of days for which ElastiCache retains the snapshot
        /// before deleting it.
        /// </para>
        ///  
        /// <para>
        /// For manual snapshots, this field reflects the <code>SnapshotRetentionLimit</code>
        /// for the source cache cluster when the snapshot was created. This field is otherwise
        /// ignored: Manual snapshots do not expire, and can only be deleted using the <code>DeleteSnapshot</code>
        /// operation. 
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
        /// Gets and sets the property SnapshotSource. 
        /// <para>
        /// Indicates whether the snapshot is from an automatic backup (<code>automated</code>)
        /// or was created manually (<code>manual</code>).
        /// </para>
        /// </summary>
        public string SnapshotSource
        {
            get { return this._snapshotSource; }
            set { this._snapshotSource = value; }
        }

        // Check to see if SnapshotSource property is set
        internal bool IsSetSnapshotSource()
        {
            return this._snapshotSource != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// The status of the snapshot. Valid values: <code>creating</code> | <code>available</code>
        /// | <code>restoring</code> | <code>copying</code> | <code>deleting</code>.
        /// </para>
        /// </summary>
        public string SnapshotStatus
        {
            get { return this._snapshotStatus; }
            set { this._snapshotStatus = value; }
        }

        // Check to see if SnapshotStatus property is set
        internal bool IsSetSnapshotStatus()
        {
            return this._snapshotStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range during which ElastiCache takes daily snapshots of the source
        /// cache cluster.
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
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the topic used by the source cache cluster for
        /// publishing notifications.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet group for
        /// the source cache cluster.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}