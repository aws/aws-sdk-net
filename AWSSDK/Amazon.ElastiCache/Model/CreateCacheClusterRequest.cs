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
    /// Container for the parameters to the CreateCacheCluster operation.
    /// <para>The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in the cache cluster run the same protocol-compliant
    /// cache engine software - either Memcached or Redis.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheCluster"/>
    public class CreateCacheClusterRequest : AmazonWebServiceRequest
    {
        private string cacheClusterId;
        private string replicationGroupId;
        private int? numCacheNodes;
        private string cacheNodeType;
        private string engine;
        private string engineVersion;
        private string cacheParameterGroupName;
        private string cacheSubnetGroupName;
        private List<string> cacheSecurityGroupNames = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private List<string> snapshotArns = new List<string>();
        private string preferredAvailabilityZone;
        private string preferredMaintenanceWindow;
        private int? port;
        private string notificationTopicArn;
        private bool? autoMinorVersionUpgrade;

        /// <summary>
        /// The cache cluster identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>Must contain from 1 to 20 alphanumeric
        /// characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive hyphens.</li>
        /// </ul>
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
        public CreateCacheClusterRequest WithCacheClusterId(string cacheClusterId)
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
        /// The replication group to which this cache cluster should belong. If this parameter is specified, the cache cluster will be added to the
        /// specified replication group as a read replica; otherwise, the cache cluster will be a standalone primary that is not part of any replication
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
        public CreateCacheClusterRequest WithReplicationGroupId(string replicationGroupId)
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
        /// The initial number of cache nodes that the cache cluster will have. For a Memcached cluster, valid values are between 1 and 20. If you need
        /// to exceed this limit, please fill out the ElastiCache Limit Increase Request form at <a
        /// href="http://aws.amazon.com/contact-us/elasticache-node-limit-request/"></a> . For Redis, only single-node cache clusters are supported at
        /// this time, so the value for this parameter must be 1.
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
        public CreateCacheClusterRequest WithNumCacheNodes(int numCacheNodes)
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
        /// The compute and memory capacity of the nodes in the cache cluster. Valid values for Memcached: <c>cache.t1.micro</c> | <c>cache.m1.small</c>
        /// | <c>cache.m1.medium</c> | <c>cache.m1.large</c> | <c>cache.m1.xlarge</c> | <c>cache.m3.xlarge</c> | <c>cache.m3.2xlarge</c> |
        /// <c>cache.m2.xlarge</c> | <c>cache.m2.2xlarge</c> | <c>cache.m2.4xlarge</c> | <c>cache.c1.xlarge</c> Valid values for Redis:
        /// <c>cache.t1.micro</c> | <c>cache.m1.small</c> | <c>cache.m1.medium</c> | <c>cache.m1.large</c> | <c>cache.m1.xlarge</c> |
        /// <c>cache.m2.xlarge</c> | <c>cache.m2.2xlarge</c> | <c>cache.m2.4xlarge</c> | <c>cache.c1.xlarge</c> For a complete listing of cache node
        /// types and specifications, see <a href="http://aws.amazon.com/elasticache/"></a>.
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
        public CreateCacheClusterRequest WithCacheNodeType(string cacheNodeType)
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
        /// The name of the cache engine to be used for this cache cluster. Valid values for this parameter are: <c>memcached</c> | <c>redis</c>
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
        public CreateCacheClusterRequest WithEngine(string engine)
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
        /// The version number of the cache engine to be used for this cluster. To view the supported cache engine versions, use the
        /// <i>DescribeCacheEngineVersions</i> operation.
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
        public CreateCacheClusterRequest WithEngineVersion(string engineVersion)
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
        /// The name of the cache parameter group to associate with this cache cluster. If this argument is omitted, the default cache parameter group
        /// for the specified engine will be used.
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
        public CreateCacheClusterRequest WithCacheParameterGroupName(string cacheParameterGroupName)
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
        /// The name of the cache subnet group to be used for the cache cluster. Use this parameter only when you are creating a cluster in an Amazon
        /// Virtual Private Cloud (VPC).
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
        public CreateCacheClusterRequest WithCacheSubnetGroupName(string cacheSubnetGroupName)
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
        /// A list of cache security group names to associate with this cache cluster. Use this parameter only when you are creating a cluster outside
        /// of an Amazon Virtual Private Cloud (VPC).
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
        public CreateCacheClusterRequest WithCacheSecurityGroupNames(params string[] cacheSecurityGroupNames)
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
        public CreateCacheClusterRequest WithCacheSecurityGroupNames(IEnumerable<string> cacheSecurityGroupNames)
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
        /// One or more VPC security groups associated with the cache cluster. Use this parameter only when you are creating a cluster in an Amazon
        /// Virtual Private Cloud (VPC).
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
        public CreateCacheClusterRequest WithSecurityGroupIds(params string[] securityGroupIds)
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
        public CreateCacheClusterRequest WithSecurityGroupIds(IEnumerable<string> securityGroupIds)
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
        /// A single-element string list containing an Amazon Resource Name (ARN) that uniquely identifies a Redis RDB snapshot file stored in Amazon
        /// S3. The snapshot file will be used to populate the Redis cache in the new cache cluster. The Amazon S3 object name in the ARN cannot contain
        /// any commas. Here is an example of an Amazon S3 ARN: <c>arn:aws:s3:::my_bucket/snapshot1.rdb</c> <b>Note:</b> This parameter is only valid if
        /// the <c>Engine</c> parameter is <c>redis</c>.
        ///  
        /// </summary>
        public List<string> SnapshotArns
        {
            get { return this.snapshotArns; }
            set { this.snapshotArns = value; }
        }
        /// <summary>
        /// Adds elements to the SnapshotArns collection
        /// </summary>
        /// <param name="snapshotArns">The values to add to the SnapshotArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCacheClusterRequest WithSnapshotArns(params string[] snapshotArns)
        {
            foreach (string element in snapshotArns)
            {
                this.snapshotArns.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SnapshotArns collection
        /// </summary>
        /// <param name="snapshotArns">The values to add to the SnapshotArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCacheClusterRequest WithSnapshotArns(IEnumerable<string> snapshotArns)
        {
            foreach (string element in snapshotArns)
            {
                this.snapshotArns.Add(element);
            }

            return this;
        }

        // Check to see if SnapshotArns property is set
        internal bool IsSetSnapshotArns()
        {
            return this.snapshotArns.Count > 0;
        }

        /// <summary>
        /// The EC2 Availability Zone in which the cache cluster will be created. All cache nodes belonging to a cache cluster are placed in the
        /// preferred availability zone. Default: System chosen availability zone.
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
        public CreateCacheClusterRequest WithPreferredAvailabilityZone(string preferredAvailabilityZone)
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
        /// The weekly time range (in UTC) during which system maintenance can occur. Example: <c>sun:05:00-sun:09:00</c>
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
        public CreateCacheClusterRequest WithPreferredMaintenanceWindow(string preferredMaintenanceWindow)
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
        /// The port number on which each of the cache nodes will accept connections.
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
        public CreateCacheClusterRequest WithPort(int port)
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
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic to which notifications will be sent. <note> The Amazon
        /// SNS topic owner must be the same as the cache cluster owner. </note>
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
        public CreateCacheClusterRequest WithNotificationTopicArn(string notificationTopicArn)
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
        /// Determines whether minor engine upgrades will be applied automatically to the cache cluster during the maintenance window. A value of
        /// <c>true</c> allows these upgrades to occur; <c>false</c> disables automatic upgrades. Default: <c>true</c>
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
        public CreateCacheClusterRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
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
    
