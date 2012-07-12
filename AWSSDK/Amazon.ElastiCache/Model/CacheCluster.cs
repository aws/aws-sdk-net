/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Contains information about a Cache Cluster. </para>
    /// </summary>
    public class CacheCluster  
    {
        
        private string cacheClusterId;
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
        private List<CacheNode> cacheNodes = new List<CacheNode>();
        private bool? autoMinorVersionUpgrade;

        /// <summary>
        /// Specifies a user-supplied identifier. This is the unique key that identifies a Cache Cluster.
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
        /// Specifies the name of the compute and memory capacity node type for the Cache Cluster.
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
        /// Provides the name of the cache engine to be used for this Cache Cluster.
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
        /// Provides the cache engine version of the cache engine to be used for this Cache Cluster.
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
        /// Specifies the current state of this Cache Cluster.
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
        /// Specifies the number of Cache Nodes the Cache Cluster contains.
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
        /// Specifies the name of the Availability Zone the Cache Cluster is located in.
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
        /// Provides the date and time the Cache Cluster was created.
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
        /// Specifies the weekly time range (in UTC) during which system maintenance can occur.
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
        /// Specifies that changes to the Cache Cluster are pending. This element is only included when changes are pending. Specific changes are
        /// identified by sub-elements.
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
        /// Specifies the notification details the Cache Cluster contains.
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
        /// Provides the list of Cache Security Group elements containing <i>CacheSecurityGroup.Name</i> and <i>CacheSecurityGroup.Status</i>
        /// sub-elements.
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
        /// Provides the status of the Cache Parameter Group assigned to the Cache Cluster.
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
        /// Specifies the list of Cache Nodes the Cache Cluster contains.
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
        /// Indicates that minor version patches are applied automatically.
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
    }
}
