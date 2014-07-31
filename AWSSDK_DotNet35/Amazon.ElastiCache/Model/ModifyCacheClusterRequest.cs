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
    /// Container for the parameters to the ModifyCacheCluster operation.
    /// The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster.
    /// You can use this operation to change one or more cluster configuration parameters
    /// by specifying the parameters and the new values.
    /// </summary>
    public partial class ModifyCacheClusterRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private string _aZMode;
        private string _cacheClusterId;
        private List<string> _cacheNodeIdsToRemove = new List<string>();
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _engineVersion;
        private List<string> _newAvailabilityZones = new List<string>();
        private string _notificationTopicArn;
        private string _notificationTopicStatus;
        private int? _numCacheNodes;
        private string _preferredMaintenanceWindow;
        private List<string> _securityGroupIds = new List<string>();
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;


        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <code>true</code>, this parameter causes the modifications in this request and
        /// any pending modifications to be applied, asynchronously and as soon as possible, regardless
        /// of the <i>PreferredMaintenanceWindow</i> setting for the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, then changes to the cache cluster are applied on the next maintenance
        /// reboot, or the next failure reboot, whichever occurs first.
        /// </para>
        ///  <important>If you perform a <code>ModifyCacheCluster</code> before a pending modification
        /// is applied, the pending modification is replaced by the newer modification.</important>
        /// 
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// If <code>true</code>, then minor engine upgrades will be applied automatically to
        /// the cache cluster during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code>
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
        /// Specifies whether the new nodes in this Memcached cache cluster are all created in
        /// a single Availability Zone or created across multiple Availability Zones.
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
        /// The cache cluster identifier. This value is stored as a lowercase string.
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
        /// Gets and sets the property CacheNodeIdsToRemove. 
        /// <para>
        /// A list of cache node IDs to be removed. A node ID is a numeric identifier (0001, 0002,
        /// etc.). This parameter is only valid when NumCacheNodes is less than the existing number
        /// of cache nodes. The number of cache node IDs supplied in this parameter must match
        /// the difference between the existing number of cache nodes in the cluster or pending
        /// cache nodes, whichever is greater, and the value of <i>NumCacheNodes</i> in the request.
        /// </para>
        ///  
        /// <para>
        /// For example: If you have 3 active cache nodes, 7 pending cache nodes, and the number
        /// of cache nodes in this <code>ModifyCacheCluser</code> call is 5, you must list 2 (7
        /// - 5) cache node IDs to remove.
        /// </para>
        /// </summary>
        public List<string> CacheNodeIdsToRemove
        {
            get { return this._cacheNodeIdsToRemove; }
            set { this._cacheNodeIdsToRemove = value; }
        }

        // Check to see if CacheNodeIdsToRemove property is set
        internal bool IsSetCacheNodeIdsToRemove()
        {
            return this._cacheNodeIdsToRemove != null && this._cacheNodeIdsToRemove.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to apply to this cache cluster. This change
        /// is asynchronously applied as soon as possible for parameters when the <i>ApplyImmediately</i>
        /// parameter is specified as <i>true</i> for this request.
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
        /// A list of cache security group names to authorize on this cache cluster. This change
        /// is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with clusters that are created outside of an Amazon
        /// Virtual Private Cloud (VPC).
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters. Must not be "Default".
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The upgraded version of the cache engine to be run on the cache nodes.
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
        /// Gets and sets the property NewAvailabilityZones. 
        /// <para>
        /// The list of Availability Zones where the new Memcached cache nodes will be created.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only valid when <code>NumCacheNodes</code> in the request is greater
        /// than the sum of the number of active cache nodes and the number of cache nodes pending
        /// creation (which may be zero). The number of Availability Zones supplied in this list
        /// must match the cache nodes being added in this request.
        /// </para>
        ///  
        /// <para>
        ///  This option is only supported on Memcached clusters. 
        /// </para>
        ///  
        /// <para>
        /// Scenarios: <ul> <li> <b>Scenario 1:</b> You have 3 active nodes and wish to add 2
        /// nodes. Specify <code>NumCacheNodes=5</code> (3 + 2) and opitonally specify two Availability
        /// Zones for the two new nodes.</li> <li> <b>Scenario 2:</b> You have 3 active nodes
        /// and 2 nodes pending creation (from the scenario 1 call) and want to add 1 more node.
        /// Specify <code>NumCacheNodes=6</code> ((3 + 2) + 1)</li> and optionally specify an
        /// Availability Zone for the new node. <li> <b>Scenario 3:</b> You have 3 active nodes
        /// and want to cancel the pending additional nodes from scenarios 1 and 2. Specify <code>NumCacheNodes=3</code>
        /// to cancel the additions from scenarios 1 and 2.</li> </ul> 
        /// </para>
        ///  
        /// <para>
        ///  The Availability Zone placement of nodes pending creation cannot be modified. If
        /// you wish to cancel any nodes pending creation, add 0 nodes by setting <code>NumCacheNodes</code>
        /// to the number of current nodes. 
        /// </para>
        ///  
        /// <para>
        ///  If <code>cross-az</code> is specified, existing Memcached nodes remain in their current
        /// Availability Zone. Only newly created nodes can be located in different Availability
        /// Zones. For guidance on how to move existing Memcached nodes to different Availability
        /// Zones, see the <b>Availability Zone Considerations</b> section of <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/CacheNode.Memcached.html">Cache
        /// Node Considerations for Memcached</a>. 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>NewAvailabilityZones.member.1=us-east-1a&amp;NewAvailabilityZones.member.2=us-east-1b&amp;NewAvailabilityZones.member.3=us-east-1d</code>
        /// </para>
        /// </summary>
        public List<string> NewAvailabilityZones
        {
            get { return this._newAvailabilityZones; }
            set { this._newAvailabilityZones = value; }
        }

        // Check to see if NewAvailabilityZones property is set
        internal bool IsSetNewAvailabilityZones()
        {
            return this._newAvailabilityZones != null && this._newAvailabilityZones.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NotificationTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which notifications will
        /// be sent.
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
        /// Gets and sets the property NotificationTopicStatus. 
        /// <para>
        /// The status of the Amazon SNS notification topic. Notifications are sent only if the
        /// status is <i>active</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>active</code> | <code>inactive</code>
        /// </para>
        /// </summary>
        public string NotificationTopicStatus
        {
            get { return this._notificationTopicStatus; }
            set { this._notificationTopicStatus = value; }
        }

        // Check to see if NotificationTopicStatus property is set
        internal bool IsSetNotificationTopicStatus()
        {
            return this._notificationTopicStatus != null;
        }


        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes that the cache cluster should have. If the value for <code>NumCacheNodes</code>
        /// is greater than the sum of the number of current cache nodes and the number of cache
        /// nodes pending creation (which may be zero), then more nodes will be added. If the
        /// value is less than the number of existing cache nodes, then nodes will be removed.
        /// If the value is equal to the number of current cache nodes, then any pending add or
        /// remove requests are canceled.
        /// </para>
        ///  
        /// <para>
        /// If you are removing cache nodes, you must use the <code>CacheNodeIdsToRemove</code>
        /// parameter to provide the IDs of the specific cache nodes to remove.
        /// </para>
        ///  
        /// <para>
        /// For cache clusters running Redis, the value of <code>NumCacheNodes</code>must be 1.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b>Adding or removing Memcached cache nodes can be applied immediately or
        /// as a pending action. See <code>ApplyImmediately</code>. A pending action to modify
        /// the number of cache nodes in a cluster during its maintenance window, whether by adding
        /// or removing nodes in accordance with the scale out architecture, is not queued. The
        /// customer's latest request to add or remove nodes to the cluster overrides any previous
        /// pending actions to modify the number of cache nodes in the cluster. For example, a
        /// request to remove 2 nodes would override a previous pending action to remove 3 nodes.
        /// Similarly, a request to add 2 nodes would override a previous pending action to remove
        /// 3 nodes and vice versa. As Memcached cache nodes may now be provisioned in different
        /// Availability Zones with flexible cache node placement, a request to add nodes does
        /// not automatically override a previous pending action to add nodes. The customer can
        /// modify the previous pending action to add more nodes or explicitly cancel the pending
        /// request and retry the new request. To cancel pending actions to modify the number
        /// of cache nodes in a cluster, use the <code>ModifyCacheCluster</code> request and set
        /// <code>NumCacheNodes</code> equal to the number of cache nodes currently in the cache
        /// cluster.
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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which system maintenance can occur. Note that
        /// system maintenance may result in an outage. This change is made immediately. If you
        /// are moving this window to the current time, there must be at least 120 minutes between
        /// the current time and end of the window to ensure that pending changes are applied.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specifies the VPC Security Groups associated with the cache cluster.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with clusters that are created in an Amazon Virtual
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
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache will retain automatic cache cluster snapshots
        /// before deleting them. For example, if you set <i>SnapshotRetentionLimit</i> to 5,
        /// then a snapshot that was taken today will be retained for 5 days before being deleted.
        /// </para>
        ///  
        /// <para>
        /// <b>Important</b>If the value of SnapshotRetentionLimit is set to zero (0), backups
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
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which ElastiCache will begin taking a daily snapshot
        /// of your cache cluster. 
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