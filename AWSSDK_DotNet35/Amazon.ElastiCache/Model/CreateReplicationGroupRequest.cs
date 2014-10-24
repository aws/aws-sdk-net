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
 * Do not modify this file. This file is generated from the elasticache-2014-09-30.normal.json service model.
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
    /// The <i>CreateReplicationGroup</i> operation creates a replication group. A replication
    /// group is a collection of cache clusters, where one of the cache clusters is a read/write
    /// primary and the others are read-only replicas. Writes to the primary are automatically
    /// propagated to the replicas.
    /// 
    ///  
    /// <para>
    /// When you create a replication group, you must specify an existing cache cluster that
    /// is in the primary role. When the replication group has been successfully created,
    /// you can add one or more read replica replicas to it, up to a total of five read replicas.
    /// </para>
    ///  
    /// <para>
    /// <b>Note:</b> This action is valid only for Redis.
    /// </para>
    /// </summary>
    public partial class CreateReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _automaticFailoverEnabled;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _cacheSubnetGroupName;
        private string _engine;
        private string _engineVersion;
        private string _notificationTopicArn;
        private int? _numCacheClusters;
        private int? _port;
        private List<string> _preferredCacheClusterAZs = new List<string>();
        private string _preferredMaintenanceWindow;
        private string _primaryClusterId;
        private string _replicationGroupDescription;
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _snapshotArns = new List<string>();
        private string _snapshotName;
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;

        /// <summary>
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Specifies whether a read-only replica will be automatically promoted to read/write
        /// primary if the existing primary fails.
        /// </para>
        ///  
        /// <para>
        /// If <code>true</code>, automatic failover is enabled for this replication group. If
        /// <code>false</code>, automatic failover is disabled for this replication group.
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
        /// Determines whether minor engine upgrades will be applied automatically to the node
        /// group during the maintenance window. A value of <code>true</code> allows these upgrades
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
        /// The name of the parameter group to associate with this replication group. If this
        /// argument is omitted, the default cache parameter group for the specified engine is
        /// used.
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
        ///  
        /// <para>
        /// Default: redis
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
        /// The version number of the cach engine to be used for the cache clusters in this replication
        /// group. To view the supported cache engine versions, use the <i>DescribeCacheEngineVersions</i>
        /// operation.
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
        /// Gets and sets the property NumCacheClusters. 
        /// <para>
        /// The number of cache clusters this replication group will initially have.
        /// </para>
        ///  
        /// <para>
        /// If <i>AutomaticFailover</i> is <code>enabled</code>, the value of this parameter must
        /// be at least 2.
        /// </para>
        ///  
        /// <para>
        /// The maximum permitted value for <i>NumCacheClusters</i> is 6 (primary plus 5 replicas).
        /// If you need to exceed this limit, please fill out the ElastiCache Limit Increase Request
        /// forrm at <a href="http://aws.amazon.com/contact-us/elasticache-node-limit-request">http://aws.amazon.com/contact-us/elasticache-node-limit-request</a>.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each member of the replication group will accept connections.
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
        /// A list of EC2 availability zones in which the replication group's cache clusters will
        /// be created. The order of the availability zones in the list is not important.
        /// </para>
        ///  
        /// <para>
        /// Default: system chosen availability zones.
        /// </para>
        ///  
        /// <para>
        /// Example: One Redis cache cluster in each of three availability zones. PreferredAvailabilityZones.member.1=us-east-1a
        /// PreferredAvailabilityZones.member.2=us-east-1c PreferredAvailabilityZones.member.3=us-east-1d
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
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// The identifier of the cache cluster that will serve as the primary for this replication
        /// group. This cache cluster must already exist and have a status of <i>available</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not required if <i>NumCacheClusters</i> is specified.
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
        ///  <ul> <li>A name must contain from 1 to 20 alphanumeric characters or hyphens.</li>
        /// <li>The first character must be a letter.</li> <li>A name cannot end with a hyphen
        /// or contain two consecutive hyphens.</li> </ul>
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

    }
}