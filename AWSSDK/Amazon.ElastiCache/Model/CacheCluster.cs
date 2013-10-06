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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Contains all of the attributes of a specific cache cluster.</para>
    /// </summary>
    public class CacheCluster
    {
        
        private string cacheClusterId;
        private Endpoint configurationEndpoint;
        private string clientDownloadLandingPage;
        private string cacheNodeType;
        private string engine;
        private string engineVersion;
        private string cacheClusterStatus;
        private int? numCacheNodes;
        private string preferredAvailabilityZone;
        private DateTime? cacheClusterCreateTime;
        private string preferredMaintenanceWindow;
        private PendingModifiedValues pendingModifiedValues;
        private NotificationConfiguration notificationConfiguration;
        private List<CacheSecurityGroupMembership> cacheSecurityGroups = new List<CacheSecurityGroupMembership>();
        private CacheParameterGroupStatus cacheParameterGroup;
        private string cacheSubnetGroupName;
        private List<CacheNode> cacheNodes = new List<CacheNode>();
        private bool? autoMinorVersionUpgrade;
        private List<SecurityGroupMembership> securityGroups = new List<SecurityGroupMembership>();
        private string replicationGroupId;

        /// <summary>
        /// The user-supplied identifier of the cache cluster. This is a unique key that identifies a cache cluster.
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
        public CacheCluster WithCacheClusterId(string cacheClusterId)
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
        /// Represents the information required for client programs to connect to a cache node.
        ///  
        /// </summary>
        public Endpoint ConfigurationEndpoint
        {
            get { return this.configurationEndpoint; }
            set { this.configurationEndpoint = value; }
        }

        /// <summary>
        /// Sets the ConfigurationEndpoint property
        /// </summary>
        /// <param name="configurationEndpoint">The value to set for the ConfigurationEndpoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithConfigurationEndpoint(Endpoint configurationEndpoint)
        {
            this.configurationEndpoint = configurationEndpoint;
            return this;
        }
            

        // Check to see if ConfigurationEndpoint property is set
        internal bool IsSetConfigurationEndpoint()
        {
            return this.configurationEndpoint != null;
        }

        /// <summary>
        /// The URL of the web page where you can download the latest ElastiCache client library.
        ///  
        /// </summary>
        public string ClientDownloadLandingPage
        {
            get { return this.clientDownloadLandingPage; }
            set { this.clientDownloadLandingPage = value; }
        }

        /// <summary>
        /// Sets the ClientDownloadLandingPage property
        /// </summary>
        /// <param name="clientDownloadLandingPage">The value to set for the ClientDownloadLandingPage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithClientDownloadLandingPage(string clientDownloadLandingPage)
        {
            this.clientDownloadLandingPage = clientDownloadLandingPage;
            return this;
        }
            

        // Check to see if ClientDownloadLandingPage property is set
        internal bool IsSetClientDownloadLandingPage()
        {
            return this.clientDownloadLandingPage != null;
        }

        /// <summary>
        /// The name of the compute and memory capacity node type for the cache cluster.
        ///  
        /// </summary>
        public string CacheNodeType
        {
            get { return this.cacheNodeType; }
            set { this.cacheNodeType = value; }
        }

        /// <summary>
        /// Sets the CacheNodeType property
        /// </summary>
        /// <param name="cacheNodeType">The value to set for the CacheNodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheNodeType(string cacheNodeType)
        {
            this.cacheNodeType = cacheNodeType;
            return this;
        }
            

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this.cacheNodeType != null;
        }

        /// <summary>
        /// The name of the cache engine (<i>memcached</i> or <i>redis</i>) to be used for this cache cluster.
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithEngine(string engine)
        {
            this.engine = engine;
            return this;
        }
            

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The version of the cache engine version that is used in this cache cluster.
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
        public CacheCluster WithEngineVersion(string engineVersion)
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
        /// The current state of this cache cluster - <i>creating</i>, <i>available</i>, etc.
        ///  
        /// </summary>
        public string CacheClusterStatus
        {
            get { return this.cacheClusterStatus; }
            set { this.cacheClusterStatus = value; }
        }

        /// <summary>
        /// Sets the CacheClusterStatus property
        /// </summary>
        /// <param name="cacheClusterStatus">The value to set for the CacheClusterStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheClusterStatus(string cacheClusterStatus)
        {
            this.cacheClusterStatus = cacheClusterStatus;
            return this;
        }
            

        // Check to see if CacheClusterStatus property is set
        internal bool IsSetCacheClusterStatus()
        {
            return this.cacheClusterStatus != null;
        }

        /// <summary>
        /// The number of cache nodes in the cache cluster.
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
        public CacheCluster WithNumCacheNodes(int numCacheNodes)
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
        /// The name of the Availability Zone in which the cache cluster is located.
        ///  
        /// </summary>
        public string PreferredAvailabilityZone
        {
            get { return this.preferredAvailabilityZone; }
            set { this.preferredAvailabilityZone = value; }
        }

        /// <summary>
        /// Sets the PreferredAvailabilityZone property
        /// </summary>
        /// <param name="preferredAvailabilityZone">The value to set for the PreferredAvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithPreferredAvailabilityZone(string preferredAvailabilityZone)
        {
            this.preferredAvailabilityZone = preferredAvailabilityZone;
            return this;
        }
            

        // Check to see if PreferredAvailabilityZone property is set
        internal bool IsSetPreferredAvailabilityZone()
        {
            return this.preferredAvailabilityZone != null;
        }

        /// <summary>
        /// The date and time the cache cluster was created.
        ///  
        /// </summary>
        public DateTime CacheClusterCreateTime
        {
            get { return this.cacheClusterCreateTime ?? default(DateTime); }
            set { this.cacheClusterCreateTime = value; }
        }

        /// <summary>
        /// Sets the CacheClusterCreateTime property
        /// </summary>
        /// <param name="cacheClusterCreateTime">The value to set for the CacheClusterCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheClusterCreateTime(DateTime cacheClusterCreateTime)
        {
            this.cacheClusterCreateTime = cacheClusterCreateTime;
            return this;
        }
            

        // Check to see if CacheClusterCreateTime property is set
        internal bool IsSetCacheClusterCreateTime()
        {
            return this.cacheClusterCreateTime.HasValue;
        }

        /// <summary>
        /// The time range (in UTC) during which weekly system maintenance can occur.
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
        public CacheCluster WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// A group of settings that will be applied to the cache cluster in the future, or that are currently being applied.
        ///  
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this.pendingModifiedValues; }
            set { this.pendingModifiedValues = value; }
        }

        /// <summary>
        /// Sets the PendingModifiedValues property
        /// </summary>
        /// <param name="pendingModifiedValues">The value to set for the PendingModifiedValues property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithPendingModifiedValues(PendingModifiedValues pendingModifiedValues)
        {
            this.pendingModifiedValues = pendingModifiedValues;
            return this;
        }
            

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this.pendingModifiedValues != null;
        }

        /// <summary>
        /// Describes a notification topic and its status. Notification topics are used for publishing ElastiCache events to subscribers using Amazon
        /// Simple Notification Service (SNS).
        ///  
        /// </summary>
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this.notificationConfiguration; }
            set { this.notificationConfiguration = value; }
        }

        /// <summary>
        /// Sets the NotificationConfiguration property
        /// </summary>
        /// <param name="notificationConfiguration">The value to set for the NotificationConfiguration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithNotificationConfiguration(NotificationConfiguration notificationConfiguration)
        {
            this.notificationConfiguration = notificationConfiguration;
            return this;
        }
            

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this.notificationConfiguration != null;
        }

        /// <summary>
        /// A list of cache security group elements, composed of name and status sub-elements.
        ///  
        /// </summary>
        public List<CacheSecurityGroupMembership> CacheSecurityGroups
        {
            get { return this.cacheSecurityGroups; }
            set { this.cacheSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the CacheSecurityGroups collection
        /// </summary>
        /// <param name="cacheSecurityGroups">The values to add to the CacheSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheSecurityGroups(params CacheSecurityGroupMembership[] cacheSecurityGroups)
        {
            foreach (CacheSecurityGroupMembership element in cacheSecurityGroups)
            {
                this.cacheSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheSecurityGroups collection
        /// </summary>
        /// <param name="cacheSecurityGroups">The values to add to the CacheSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheSecurityGroups(IEnumerable<CacheSecurityGroupMembership> cacheSecurityGroups)
        {
            foreach (CacheSecurityGroupMembership element in cacheSecurityGroups)
            {
                this.cacheSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if CacheSecurityGroups property is set
        internal bool IsSetCacheSecurityGroups()
        {
            return this.cacheSecurityGroups.Count > 0;
        }

        /// <summary>
        /// The status of the cache parameter group.
        ///  
        /// </summary>
        public CacheParameterGroupStatus CacheParameterGroup
        {
            get { return this.cacheParameterGroup; }
            set { this.cacheParameterGroup = value; }
        }

        /// <summary>
        /// Sets the CacheParameterGroup property
        /// </summary>
        /// <param name="cacheParameterGroup">The value to set for the CacheParameterGroup property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheParameterGroup(CacheParameterGroupStatus cacheParameterGroup)
        {
            this.cacheParameterGroup = cacheParameterGroup;
            return this;
        }
            

        // Check to see if CacheParameterGroup property is set
        internal bool IsSetCacheParameterGroup()
        {
            return this.cacheParameterGroup != null;
        }

        /// <summary>
        /// The name of the cache subnet group associated with the cache cluster.
        ///  
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this.cacheSubnetGroupName; }
            set { this.cacheSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheSubnetGroupName property
        /// </summary>
        /// <param name="cacheSubnetGroupName">The value to set for the CacheSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheSubnetGroupName(string cacheSubnetGroupName)
        {
            this.cacheSubnetGroupName = cacheSubnetGroupName;
            return this;
        }
            

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this.cacheSubnetGroupName != null;
        }

        /// <summary>
        /// A list of cache nodes that are members of the cache cluster.
        ///  
        /// </summary>
        public List<CacheNode> CacheNodes
        {
            get { return this.cacheNodes; }
            set { this.cacheNodes = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodes collection
        /// </summary>
        /// <param name="cacheNodes">The values to add to the CacheNodes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheNodes(params CacheNode[] cacheNodes)
        {
            foreach (CacheNode element in cacheNodes)
            {
                this.cacheNodes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodes collection
        /// </summary>
        /// <param name="cacheNodes">The values to add to the CacheNodes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithCacheNodes(IEnumerable<CacheNode> cacheNodes)
        {
            foreach (CacheNode element in cacheNodes)
            {
                this.cacheNodes.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodes property is set
        internal bool IsSetCacheNodes()
        {
            return this.cacheNodes.Count > 0;
        }

        /// <summary>
        /// If <c>true</c>, then minor version patches are applied automatically; if <c>false</c>, then automatic minor version patches are disabled.
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
        public CacheCluster WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
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
        /// A list of VPC Security Groups associated with the cache cluster.
        ///  
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithSecurityGroups(params SecurityGroupMembership[] securityGroups)
        {
            foreach (SecurityGroupMembership element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SecurityGroups collection
        /// </summary>
        /// <param name="securityGroups">The values to add to the SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheCluster WithSecurityGroups(IEnumerable<SecurityGroupMembership> securityGroups)
        {
            foreach (SecurityGroupMembership element in securityGroups)
            {
                this.securityGroups.Add(element);
            }

            return this;
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }

        /// <summary>
        /// The replication group to which this cache cluster belongs. If this field is empty, the cache cluster is not associated with any replication
        /// group.
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
        public CacheCluster WithReplicationGroupId(string replicationGroupId)
        {
            this.replicationGroupId = replicationGroupId;
            return this;
        }
            

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }
    }
}
