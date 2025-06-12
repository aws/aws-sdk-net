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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents a copy of an entire Valkey or Redis OSS cluster as of the time when the
    /// snapshot was taken.
    /// </summary>
    public partial class Snapshot
    {
        private string _arn;
        private AutomaticFailoverStatus _automaticFailover;
        private bool? _autoMinorVersionUpgrade;
        private DateTime? _cacheClusterCreateTime;
        private string _cacheClusterId;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private string _cacheSubnetGroupName;
        private DataTieringStatus _dataTiering;
        private string _engine;
        private string _engineVersion;
        private string _kmsKeyId;
        private List<NodeSnapshot> _nodeSnapshots = AWSConfigs.InitializeCollections ? new List<NodeSnapshot>() : null;
        private int? _numCacheNodes;
        private int? _numNodeGroups;
        private int? _port;
        private string _preferredAvailabilityZone;
        private string _preferredMaintenanceWindow;
        private string _preferredOutpostArn;
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the snapshot.
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
        /// Gets and sets the property AutomaticFailover. 
        /// <para>
        /// Indicates the status of automatic failover for the source Valkey or Redis OSS replication
        /// group.
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
        ///  If you are running Valkey 7.2 and above or Redis OSS engine version 6.0 and above,
        /// set this parameter to yes if you want to opt-in to the next auto minor version upgrade
        /// campaign. This parameter is disabled for previous versions.  
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
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
        /// The date and time when the source cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CacheClusterCreateTime
        {
            get { return this._cacheClusterCreateTime; }
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
        /// The user-supplied identifier of the source cluster.
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
        /// The name of the compute and memory capacity node type for the source cluster.
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
        /// The cache parameter group that is associated with the source cluster.
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
        /// The name of the cache subnet group associated with the source cluster.
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
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for replication groups using
        /// the r6gd node type. This parameter must be set to true when using r6gd nodes. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/data-tiering.html">Data
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine (<c>memcached</c> or <c>redis</c>) used by the source
        /// cluster.
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
        /// The version of the cache engine version that is used by the source cluster.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the snapshot.
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
        /// Gets and sets the property NodeSnapshots. 
        /// <para>
        /// A list of the cache nodes in the source cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeSnapshot> NodeSnapshots
        {
            get { return this._nodeSnapshots; }
            set { this._nodeSnapshots = value; }
        }

        // Check to see if NodeSnapshots property is set
        internal bool IsSetNodeSnapshots()
        {
            return this._nodeSnapshots != null && (this._nodeSnapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes in the source cluster.
        /// </para>
        ///  
        /// <para>
        /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters running
        /// Memcached, this value must be between 1 and 40.
        /// </para>
        /// </summary>
        public int? NumCacheNodes
        {
            get { return this._numCacheNodes; }
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
        public int? NumNodeGroups
        {
            get { return this._numNodeGroups; }
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
        /// The port number used by each cache nodes in the source cluster.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
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
        /// The name of the Availability Zone in which the source cluster is located.
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
        /// The ARN (Amazon Resource Name) of the preferred outpost.
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
        /// For manual snapshots, this field reflects the <c>SnapshotRetentionLimit</c> for the
        /// source cluster when the snapshot was created. This field is otherwise ignored: Manual
        /// snapshots do not expire, and can only be deleted using the <c>DeleteSnapshot</c> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Important</b> If the value of SnapshotRetentionLimit is set to zero (0), backups
        /// are turned off.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit; }
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
        /// Indicates whether the snapshot is from an automatic backup (<c>automated</c>) or was
        /// created manually (<c>manual</c>).
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
        /// The status of the snapshot. Valid values: <c>creating</c> | <c>available</c> | <c>restoring</c>
        /// | <c>copying</c> | <c>deleting</c>.
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
        /// cluster.
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
        /// The Amazon Resource Name (ARN) for the topic used by the source cluster for publishing
        /// notifications.
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
        /// the source cluster.
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