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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents a copy of an entire cache cluster as of the time when the snapshot was taken.</para>
    /// </summary>
    public partial class Snapshot
    {
        
        private string snapshotName;
        private string cacheClusterId;
        private string snapshotStatus;
        private string snapshotSource;
        private string cacheNodeType;
        private string engine;
        private string engineVersion;
        private int? numCacheNodes;
        private string preferredAvailabilityZone;
        private DateTime? cacheClusterCreateTime;
        private string preferredMaintenanceWindow;
        private string topicArn;
        private int? port;
        private string cacheParameterGroupName;
        private string cacheSubnetGroupName;
        private string vpcId;
        private bool? autoMinorVersionUpgrade;
        private int? snapshotRetentionLimit;
        private string snapshotWindow;
        private List<NodeSnapshot> nodeSnapshots = new List<NodeSnapshot>();

        /// <summary>
        /// The name of a snapshot. For an automatic snapshot, the name is system-generated; for a manual snapshot, this is the user-provided name.
        ///  
        /// </summary>
        public string SnapshotName
        {
            get { return this.snapshotName; }
            set { this.snapshotName = value; }
        }

        /// <summary>
        /// Sets the SnapshotName property
        /// </summary>
        /// <param name="snapshotName">The value to set for the SnapshotName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotName(string snapshotName)
        {
            this.snapshotName = snapshotName;
            return this;
        }
            

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this.snapshotName != null;
        }

        /// <summary>
        /// The user-supplied identifier of the source cache cluster.
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
        public Snapshot WithCacheClusterId(string cacheClusterId)
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
        /// The status of the snapshot. Valid values: <c>creating</c> | <c>available</c> | <c>restoring</c> | <c>deleting</c>.
        ///  
        /// </summary>
        public string SnapshotStatus
        {
            get { return this.snapshotStatus; }
            set { this.snapshotStatus = value; }
        }

        /// <summary>
        /// Sets the SnapshotStatus property
        /// </summary>
        /// <param name="snapshotStatus">The value to set for the SnapshotStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotStatus(string snapshotStatus)
        {
            this.snapshotStatus = snapshotStatus;
            return this;
        }
            

        // Check to see if SnapshotStatus property is set
        internal bool IsSetSnapshotStatus()
        {
            return this.snapshotStatus != null;
        }

        /// <summary>
        /// Indicates whether the snapshot is from an automatic backup (<c>automated</c>) or was created manually (<c>manual</c>).
        ///  
        /// </summary>
        public string SnapshotSource
        {
            get { return this.snapshotSource; }
            set { this.snapshotSource = value; }
        }

        /// <summary>
        /// Sets the SnapshotSource property
        /// </summary>
        /// <param name="snapshotSource">The value to set for the SnapshotSource property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotSource(string snapshotSource)
        {
            this.snapshotSource = snapshotSource;
            return this;
        }
            

        // Check to see if SnapshotSource property is set
        internal bool IsSetSnapshotSource()
        {
            return this.snapshotSource != null;
        }

        /// <summary>
        /// The name of the compute and memory capacity node type for the source cache cluster.
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
        public Snapshot WithCacheNodeType(string cacheNodeType)
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
        /// The name of the cache engine (<i>memcached</i> or <i>redis</i>) used by the source cache cluster.
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
        public Snapshot WithEngine(string engine)
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
        /// The version of the cache engine version that is used by the source cache cluster.
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
        public Snapshot WithEngineVersion(string engineVersion)
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
        /// The number of cache nodes in the source cache cluster.
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
        public Snapshot WithNumCacheNodes(int numCacheNodes)
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
        /// The name of the Availability Zone in which the source cache cluster is located.
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
        public Snapshot WithPreferredAvailabilityZone(string preferredAvailabilityZone)
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
        /// The date and time when the source cache cluster was created.
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
        public Snapshot WithCacheClusterCreateTime(DateTime cacheClusterCreateTime)
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
        /// The time range (in UTC) during which weekly system maintenance can occur on the source cache cluster.
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
        public Snapshot WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// The Amazon Resource Name (ARN) for the topic used by the source cache cluster for publishing notifications.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        /// <summary>
        /// Sets the TopicArn property
        /// </summary>
        /// <param name="topicArn">The value to set for the TopicArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithTopicArn(string topicArn)
        {
            this.topicArn = topicArn;
            return this;
        }
            

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// The port number used by each cache nodes in the source cache cluster.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The cache parameter group that is associated with the source cache cluster.
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
        public Snapshot WithCacheParameterGroupName(string cacheParameterGroupName)
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
        /// The name of the cache subnet group associated with the source cache cluster.
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
        public Snapshot WithCacheSubnetGroupName(string cacheSubnetGroupName)
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
        /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet group for the source cache cluster.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// For the source cache cluster, indicates whether minor version patches are applied automatically (<c>true</c>) or not (<c>false</c>).
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
        public Snapshot WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
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
        /// For an automatic snapshot, the number of days for which ElastiCache will retain the snapshot before deleting it. For manual snapshots, this
        /// field reflects the <i>SnapshotRetentionLimit</i> for the source cache cluster when the snapshot was created. This field is otherwise
        /// ignored: Manual snapshots do not expire, and can only be deleted using the <i>DeleteSnapshot</i> action.
        ///  
        /// </summary>
        public int SnapshotRetentionLimit
        {
            get { return this.snapshotRetentionLimit ?? default(int); }
            set { this.snapshotRetentionLimit = value; }
        }

        /// <summary>
        /// Sets the SnapshotRetentionLimit property
        /// </summary>
        /// <param name="snapshotRetentionLimit">The value to set for the SnapshotRetentionLimit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotRetentionLimit(int snapshotRetentionLimit)
        {
            this.snapshotRetentionLimit = snapshotRetentionLimit;
            return this;
        }
            

        // Check to see if SnapshotRetentionLimit property is set
        internal bool IsSetSnapshotRetentionLimit()
        {
            return this.snapshotRetentionLimit.HasValue;
        }

        /// <summary>
        /// The daily time range during which ElastiCache takes daily snapshots of the source cache cluster.
        ///  
        /// </summary>
        public string SnapshotWindow
        {
            get { return this.snapshotWindow; }
            set { this.snapshotWindow = value; }
        }

        /// <summary>
        /// Sets the SnapshotWindow property
        /// </summary>
        /// <param name="snapshotWindow">The value to set for the SnapshotWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotWindow(string snapshotWindow)
        {
            this.snapshotWindow = snapshotWindow;
            return this;
        }
            

        // Check to see if SnapshotWindow property is set
        internal bool IsSetSnapshotWindow()
        {
            return this.snapshotWindow != null;
        }

        /// <summary>
        /// A list of the cache cluster nodes in the source cache cluster.
        ///  
        /// </summary>
        public List<NodeSnapshot> NodeSnapshots
        {
            get { return this.nodeSnapshots; }
            set { this.nodeSnapshots = value; }
        }
        /// <summary>
        /// Adds elements to the NodeSnapshots collection
        /// </summary>
        /// <param name="nodeSnapshots">The values to add to the NodeSnapshots collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNodeSnapshots(params NodeSnapshot[] nodeSnapshots)
        {
            foreach (NodeSnapshot element in nodeSnapshots)
            {
                this.nodeSnapshots.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the NodeSnapshots collection
        /// </summary>
        /// <param name="nodeSnapshots">The values to add to the NodeSnapshots collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithNodeSnapshots(IEnumerable<NodeSnapshot> nodeSnapshots)
        {
            foreach (NodeSnapshot element in nodeSnapshots)
            {
                this.nodeSnapshots.Add(element);
            }

            return this;
        }

        // Check to see if NodeSnapshots property is set
        internal bool IsSetNodeSnapshots()
        {
            return this.nodeSnapshots.Count > 0;
        }
    }
}
