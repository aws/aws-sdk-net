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
    /// Container for the parameters to the ModifyCacheCluster operation.
    /// <para>The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster. You can use this operation to change one or more
    /// cluster configuration parameters by specifying the parameters and the new values.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheCluster"/>
    public class ModifyCacheClusterRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private int? numCacheNodes;
        private List<string> cacheNodeIdsToRemove = new List<string>();
        private List<string> cacheSecurityGroupNames = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private string preferredMaintenanceWindow;
        private string notificationTopicArn;
        private string cacheParameterGroupName;
        private string notificationTopicStatus;
        private bool? applyImmediately;
        private string engineVersion;
        private bool? autoMinorVersionUpgrade;

        /// <summary>
        /// The cache cluster identifier. This value is stored as a lowercase string.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        /// <summary>
        /// Sets the CacheClusterId property
        /// </summary>
        /// <param name="cacheClusterId">The value to set for the CacheClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyCacheClusterRequest WithCacheClusterId(string cacheClusterId)
        {
            this.cacheClusterId = cacheClusterId;
            return this;
        }
            

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// The number of cache nodes that the cache cluster should have. If the value for <i>NumCacheNodes</i> is greater than the existing number of
        /// cache nodes, then more nodes will be added. If the value is less than the existing number of cache nodes, then cache nodes will be removed.
        /// If you are removing cache nodes, you must use the <i>CacheNodeIdsToRemove</i> parameter to provide the IDs of the specific cache nodes to be
        /// removed.
        ///  
        /// </summary>
        public int NumCacheNodes
        {
            get { return this.numCacheNodes ?? default(int); }
            set { this.numCacheNodes = value; }
        }

        /// <summary>
        /// Sets the NumCacheNodes property
        /// </summary>
        /// <param name="numCacheNodes">The value to set for the NumCacheNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyCacheClusterRequest WithNumCacheNodes(int numCacheNodes)
        {
            this.numCacheNodes = numCacheNodes;
            return this;
        }
            

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this.numCacheNodes.HasValue;
        }

        /// <summary>
        /// A list of cache node IDs to be removed. A node ID is a numeric identifier (0001, 0002, etc.). This parameter is only valid when
        /// NumCacheNodes is less than the existing number of cache nodes. The number of cache node IDs supplied in this parameter must match the
        /// difference between the existing number of cache nodes in the cluster and the value of <i>NumCacheNodes</i> in the request.
        ///  
        /// </summary>
        public List<string> CacheNodeIdsToRemove
        {
            get { return this.cacheNodeIdsToRemove; }
            set { this.cacheNodeIdsToRemove = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeIdsToRemove collection
        /// </summary>
        /// <param name="cacheNodeIdsToRemove">The values to add to the CacheNodeIdsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyCacheClusterRequest WithCacheNodeIdsToRemove(params string[] cacheNodeIdsToRemove)
        {
            foreach (string element in cacheNodeIdsToRemove)
            {
                this.cacheNodeIdsToRemove.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeIdsToRemove collection
        /// </summary>
        /// <param name="cacheNodeIdsToRemove">The values to add to the CacheNodeIdsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyCacheClusterRequest WithCacheNodeIdsToRemove(IEnumerable<string> cacheNodeIdsToRemove)
        {
            foreach (string element in cacheNodeIdsToRemove)
            {
                this.cacheNodeIdsToRemove.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeIdsToRemove property is set
        internal bool IsSetCacheNodeIdsToRemove()
        {
            return this.cacheNodeIdsToRemove.Count > 0;
        }

        /// <summary>
        /// A list of cache security group names to authorize on this cache cluster. This change is asynchronously applied as soon as possible. This
        /// parameter can be used only with clusters that are created outside of an Amazon Virtual Private Cloud (VPC). Constraints: Must contain no
        /// more than 255 alphanumeric characters. Must not be "Default".
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
        public ModifyCacheClusterRequest WithCacheSecurityGroupNames(params string[] cacheSecurityGroupNames)
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
        public ModifyCacheClusterRequest WithCacheSecurityGroupNames(IEnumerable<string> cacheSecurityGroupNames)
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
        /// Specifies the VPC Security Groups associated with the cache cluster. This parameter can be used only with clusters that are created in an
        /// Amazon Virtual Private Cloud (VPC).
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
        public ModifyCacheClusterRequest WithSecurityGroupIds(params string[] securityGroupIds)
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
        public ModifyCacheClusterRequest WithSecurityGroupIds(IEnumerable<string> securityGroupIds)
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
        /// The weekly time range (in UTC) during which system maintenance can occur. Note that system maintenance may result in an outage. This change
        /// is made immediately. If you are moving this window to the current time, there must be at least 120 minutes between the current time and end
        /// of the window to ensure that pending changes are applied.
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
        public ModifyCacheClusterRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// The Amazon Resource Name (ARN) of the SNS topic to which notifications will be sent. <note> The SNS topic owner must be same as the cache
        /// cluster owner. </note>
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
        public ModifyCacheClusterRequest WithNotificationTopicArn(string notificationTopicArn)
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
        /// The name of the cache parameter group to apply to this cache cluster. This change is asynchronously applied as soon as possible for
        /// parameters when the <i>ApplyImmediately</i> parameter is specified as <i>true</i> for this request.
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
        public ModifyCacheClusterRequest WithCacheParameterGroupName(string cacheParameterGroupName)
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
        /// The status of the Amazon SNS notification topic. Notifications are sent only if the status is <i>active</i>. Valid values: <c>active</c> |
        /// <c>inactive</c>
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
        public ModifyCacheClusterRequest WithNotificationTopicStatus(string notificationTopicStatus)
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
        /// soon as possible, regardless of the <i>PreferredMaintenanceWindow</i> setting for the cache cluster. If <c>false</c>, then changes to the
        /// cache cluster are applied on the next maintenance reboot, or the next failure reboot, whichever occurs first. Valid values: <c>true</c> |
        /// <c>false</c> Default: <c>false</c>
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
        public ModifyCacheClusterRequest WithApplyImmediately(bool applyImmediately)
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
        /// The upgraded version of the cache engine to be run on the cache cluster nodes.
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
        public ModifyCacheClusterRequest WithEngineVersion(string engineVersion)
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
        /// If <c>true</c>, then minor engine upgrades will be applied automatically to the cache cluster during the maintenance window. Valid values:
        /// <c>true</c> | <c>false</c> Default: <c>true</c>
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
        public ModifyCacheClusterRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
        {
            this.autoMinorVersionUpgrade = autoMinorVersionUpgrade;
            return this;
        }
            

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }
    }
}
    
