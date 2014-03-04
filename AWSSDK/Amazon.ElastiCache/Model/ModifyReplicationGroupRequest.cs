/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ModifyReplicationGroup operation.
    /// <para>The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication group.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyReplicationGroup"/>
    public class ModifyReplicationGroupRequest : AmazonWebServiceRequest
    {
        private string replicationGroupId;
        private string replicationGroupDescription;
        private List<string> cacheSecurityGroupNames = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private string preferredMaintenanceWindow;
        private string notificationTopicArn;
        private string cacheParameterGroupName;
        private string notificationTopicStatus;
        private bool? applyImmediately;
        private string engineVersion;
        private bool? autoMinorVersionUpgrade;
        private string primaryClusterId;

        /// <summary>
        /// The identifier of the replication group to modify.
        ///  
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this.replicationGroupId; }
            set { this.replicationGroupId = value; }
        }

        /// <summary>
        /// Sets the ReplicationGroupId property
        /// </summary>
        /// <param name="replicationGroupId">The value to set for the ReplicationGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithReplicationGroupId(string replicationGroupId)
        {
            this.replicationGroupId = replicationGroupId;
            return this;
        }
            

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }

        /// <summary>
        /// A description for the replication group. Maximum length is 255 characters.
        ///  
        /// </summary>
        public string ReplicationGroupDescription
        {
            get { return this.replicationGroupDescription; }
            set { this.replicationGroupDescription = value; }
        }

        /// <summary>
        /// Sets the ReplicationGroupDescription property
        /// </summary>
        /// <param name="replicationGroupDescription">The value to set for the ReplicationGroupDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithReplicationGroupDescription(string replicationGroupDescription)
        {
            this.replicationGroupDescription = replicationGroupDescription;
            return this;
        }
            

        // Check to see if ReplicationGroupDescription property is set
        internal bool IsSetReplicationGroupDescription()
        {
            return this.replicationGroupDescription != null;
        }

        /// <summary>
        /// A list of cache security group names to authorize for the clusters in this replication group. This change is asynchronously applied as soon
        /// as possible. This parameter can be used only with replication groups containing cache clusters running outside of an Amazon Virtual Private
        /// Cloud (VPC). Constraints: Must contain no more than 255 alphanumeric characters. Must not be "Default".
        ///  
        /// </summary>
        public List<string> CacheSecurityGroupNames
        {
            get { return this.cacheSecurityGroupNames; }
            set { this.cacheSecurityGroupNames = value; }
        }
        /// <summary>
        /// Adds elements to the CacheSecurityGroupNames collection
        /// </summary>
        /// <param name="cacheSecurityGroupNames">The values to add to the CacheSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithCacheSecurityGroupNames(params string[] cacheSecurityGroupNames)
        {
            foreach (string element in cacheSecurityGroupNames)
            {
                this.cacheSecurityGroupNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheSecurityGroupNames collection
        /// </summary>
        /// <param name="cacheSecurityGroupNames">The values to add to the CacheSecurityGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithCacheSecurityGroupNames(IEnumerable<string> cacheSecurityGroupNames)
        {
            foreach (string element in cacheSecurityGroupNames)
            {
                this.cacheSecurityGroupNames.Add(element);
            }

            return this;
        }

        // Check to see if CacheSecurityGroupNames property is set
        internal bool IsSetCacheSecurityGroupNames()
        {
            return this.cacheSecurityGroupNames.Count > 0;
        }

        /// <summary>
        /// Specifies the VPC Security Groups associated with the cache clusters in the replication group. This parameter can be used only with
        /// replication groups containing cache clusters running in an Amazon Virtual Private Cloud (VPC).
        ///  
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this.securityGroupIds; }
            set { this.securityGroupIds = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroupIds collection
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithSecurityGroupIds(params string[] securityGroupIds)
        {
            foreach (string element in securityGroupIds)
            {
                this.securityGroupIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SecurityGroupIds collection
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithSecurityGroupIds(IEnumerable<string> securityGroupIds)
        {
            foreach (string element in securityGroupIds)
            {
                this.securityGroupIds.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this.securityGroupIds.Count > 0;
        }

        /// <summary>
        /// The weekly time range (in UTC) during which replication group system maintenance can occur. Note that system maintenance may result in an
        /// outage. This change is made immediately. If you are moving this window to the current time, there must be at least 120 minutes between the
        /// current time and end of the window to ensure that pending changes are applied.
        ///  
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this.preferredMaintenanceWindow; }
            set { this.preferredMaintenanceWindow = value; }
        }

        /// <summary>
        /// Sets the PreferredMaintenanceWindow property
        /// </summary>
        /// <param name="preferredMaintenanceWindow">The value to set for the PreferredMaintenanceWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
        {
            this.preferredMaintenanceWindow = preferredMaintenanceWindow;
            return this;
        }
            

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this.preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the SNS topic to which notifications will be sent. <note> The SNS topic owner must be same as the
        /// replication group owner. </note>
        ///  
        /// </summary>
        public string NotificationTopicArn
        {
            get { return this.notificationTopicArn; }
            set { this.notificationTopicArn = value; }
        }

        /// <summary>
        /// Sets the NotificationTopicArn property
        /// </summary>
        /// <param name="notificationTopicArn">The value to set for the NotificationTopicArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithNotificationTopicArn(string notificationTopicArn)
        {
            this.notificationTopicArn = notificationTopicArn;
            return this;
        }
            

        // Check to see if NotificationTopicArn property is set
        internal bool IsSetNotificationTopicArn()
        {
            return this.notificationTopicArn != null;
        }

        /// <summary>
        /// The name of the cache parameter group to apply to all of the cache nodes in this replication group. This change is asynchronously applied as
        /// soon as possible for parameters when the <i>ApplyImmediately</i> parameter is specified as <i>true</i> for this request.
        ///  
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this.cacheParameterGroupName; }
            set { this.cacheParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheParameterGroupName property
        /// </summary>
        /// <param name="cacheParameterGroupName">The value to set for the CacheParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithCacheParameterGroupName(string cacheParameterGroupName)
        {
            this.cacheParameterGroupName = cacheParameterGroupName;
            return this;
        }
            

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this.cacheParameterGroupName != null;
        }

        /// <summary>
        /// The status of the Amazon SNS notification topic for the replication group. Notifications are sent only if the status is <i>active</i>. Valid
        /// values: <c>active</c> | <c>inactive</c>
        ///  
        /// </summary>
        public string NotificationTopicStatus
        {
            get { return this.notificationTopicStatus; }
            set { this.notificationTopicStatus = value; }
        }

        /// <summary>
        /// Sets the NotificationTopicStatus property
        /// </summary>
        /// <param name="notificationTopicStatus">The value to set for the NotificationTopicStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithNotificationTopicStatus(string notificationTopicStatus)
        {
            this.notificationTopicStatus = notificationTopicStatus;
            return this;
        }
            

        // Check to see if NotificationTopicStatus property is set
        internal bool IsSetNotificationTopicStatus()
        {
            return this.notificationTopicStatus != null;
        }

        /// <summary>
        /// If <c>true</c>, this parameter causes the modifications in this request and any pending modifications to be applied, asynchronously and as
        /// soon as possible, regardless of the <i>PreferredMaintenanceWindow</i> setting for the replication group. If <c>false</c>, then changes to
        /// the nodes in the replication group are applied on the next maintenance reboot, or the next failure reboot, whichever occurs first. Valid
        /// values: <c>true</c> | <c>false</c> Default: <c>false</c>
        ///  
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this.applyImmediately ?? default(bool); }
            set { this.applyImmediately = value; }
        }

        /// <summary>
        /// Sets the ApplyImmediately property
        /// </summary>
        /// <param name="applyImmediately">The value to set for the ApplyImmediately property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithApplyImmediately(bool applyImmediately)
        {
            this.applyImmediately = applyImmediately;
            return this;
        }
            

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this.applyImmediately.HasValue;
        }

        /// <summary>
        /// The upgraded version of the cache engine to be run on the nodes in the replication group..
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// Determines whether minor engine upgrades will be applied automatically to all of the cache nodes in the replication group during the
        /// maintenance window. A value of <c>true</c> allows these upgrades to occur; <c>false</c> disables automatic upgrades.
        ///  
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        /// <summary>
        /// Sets the AutoMinorVersionUpgrade property
        /// </summary>
        /// <param name="autoMinorVersionUpgrade">The value to set for the AutoMinorVersionUpgrade property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
        {
            this.autoMinorVersionUpgrade = autoMinorVersionUpgrade;
            return this;
        }
            

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }

        /// <summary>
        /// If this parameter is specified, ElastiCache will promote each of the nodes in the specified cache cluster to the primary role. The nodes of
        /// all other clusters in the replication group will be read replicas.
        ///  
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this.primaryClusterId; }
            set { this.primaryClusterId = value; }
        }

        /// <summary>
        /// Sets the PrimaryClusterId property
        /// </summary>
        /// <param name="primaryClusterId">The value to set for the PrimaryClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyReplicationGroupRequest WithPrimaryClusterId(string primaryClusterId)
        {
            this.primaryClusterId = primaryClusterId;
            return this;
        }
            

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this.primaryClusterId != null;
        }
    }
}
    
