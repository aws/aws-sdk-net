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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
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
    /// Container for the parameters to the ModifyReplicationGroup operation.
    /// The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication
    /// group.
    /// </summary>
    public partial class ModifyReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private string _cacheParameterGroupName;
        private List<string> _cacheSecurityGroupNames = new List<string>();
        private string _engineVersion;
        private string _notificationTopicArn;
        private string _notificationTopicStatus;
        private string _preferredMaintenanceWindow;
        private string _primaryClusterId;
        private string _replicationGroupDescription;
        private string _replicationGroupId;
        private List<string> _securityGroupIds = new List<string>();
        private int? _snapshotRetentionLimit;
        private string _snapshottingClusterId;
        private string _snapshotWindow;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// If <code>true</code>, this parameter causes the modifications in this request and
        /// any pending modifications to be applied, asynchronously and as soon as possible, regardless
        /// of the <i>PreferredMaintenanceWindow</i> setting for the replication group.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, then changes to the nodes in the replication group are applied
        /// on the next maintenance reboot, or the next failure reboot, whichever occurs first.
        /// </para>
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
        /// Determines whether minor engine upgrades will be applied automatically to all of the
        /// cache nodes in the replication group during the maintenance window. A value of <code>true</code>
        /// allows these upgrades to occur; <code>false</code> disables automatic upgrades.
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
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to apply to all of the cache nodes in this replication
        /// group. This change is asynchronously applied as soon as possible for parameters when
        /// the <i>ApplyImmediately</i> parameter is specified as <i>true</i> for this request.
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
        /// A list of cache security group names to authorize for the clusters in this replication
        /// group. This change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with replication groups containing cache clusters
        /// running outside of an Amazon Virtual Private Cloud (VPC).
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
        /// The upgraded version of the cache engine to be run on the nodes in the replication
        /// group..
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
        /// The Amazon Resource Name (ARN) of the SNS topic to which notifications will be sent.
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
        /// The status of the Amazon SNS notification topic for the replication group. Notifications
        /// are sent only if the status is <i>active</i>.
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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which replication group system maintenance can
        /// occur. Note that system maintenance may result in an outage. This change is made immediately.
        /// If you are moving this window to the current time, there must be at least 120 minutes
        /// between the current time and end of the window to ensure that pending changes are
        /// applied.
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
        /// If this parameter is specified, ElastiCache will promote each of the nodes in the
        /// specified cache cluster to the primary role. The nodes of all other clusters in the
        /// replication group will be read replicas.
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
        /// A description for the replication group. Maximum length is 255 characters.
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
        /// The identifier of the replication group to modify.
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
        /// Specifies the VPC Security Groups associated with the cache clusters in the replication
        /// group.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be used only with replication groups containing cache clusters
        /// running in an Amazon Virtual Private Cloud (VPC).
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
        /// Gets and sets the property SnapshottingClusterId. 
        /// <para>
        /// The cache cluster ID that will be used as the daily snapshot source for the replication
        /// group.
        /// </para>
        /// </summary>
        public string SnapshottingClusterId
        {
            get { return this._snapshottingClusterId; }
            set { this._snapshottingClusterId = value; }
        }

        // Check to see if SnapshottingClusterId property is set
        internal bool IsSetSnapshottingClusterId()
        {
            return this._snapshottingClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which ElastiCache will begin taking a daily snapshot
        /// of the cache cluster specified by <i>SnapshottingClusterId</i>.
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