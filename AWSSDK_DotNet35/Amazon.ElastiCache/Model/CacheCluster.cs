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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Contains all of the attributes of a specific cache cluster.</para>
    /// </summary>
    public partial class CacheCluster : AmazonWebServiceResponse
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

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }
    }
}
