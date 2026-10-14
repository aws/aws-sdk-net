/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation. Modifies the settings
    /// for a cluster. You can use this operation to change one or more cluster configuration
    /// settings by specifying the settings and the new values.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The Access Control List that is associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ACLName { get; set; }

        /// <summary>
        /// Checks to see if the ACLName property is set.
        /// </summary>
        internal bool IsSetACLName() => this.ACLName != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster to update.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine to be used for the cluster.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The upgraded version of the engine to be run on the nodes. You can upgrade to a newer
        /// engine version, but you cannot downgrade to an earlier engine version. If you want
        /// to use an earlier engine version, you must delete the existing cluster and create
        /// it anew with the earlier engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IpDiscovery. 
        /// <para>
        /// The mechanism for discovering IP addresses for the cluster discovery protocol. Valid
        /// values are 'ipv4' or 'ipv6'. When set to 'ipv4', cluster discovery functions such
        /// as cluster slots, cluster shards, and cluster nodes will return IPv4 addresses for
        /// cluster nodes. When set to 'ipv6', the cluster discovery functions return IPv6 addresses
        /// for cluster nodes. The value must be compatible with the NetworkType parameter. If
        /// not specified, the default is 'ipv4'.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the IpDiscovery property is set.
        /// </summary>
        internal bool IsSetIpDiscovery() => this.IpDiscovery != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which maintenance on the cluster is performed.
        /// It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC).
        /// The minimum maintenance window is a 60 minute period.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>ddd</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sun</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>thu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fri</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sat</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>sun:23:00-mon:01:30</c> 
        /// </para>
        /// </summary>
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// A valid node type that you want to scale this cluster up or down to.
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group to update.
        /// </para>
        /// </summary>
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property ReplicaConfiguration. 
        /// <para>
        /// The number of replicas that will reside in each shard.
        /// </para>
        /// </summary>
        public ReplicaConfigurationRequest ReplicaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaConfiguration property is set.
        /// </summary>
        internal bool IsSetReplicaConfiguration() => this.ReplicaConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The SecurityGroupIds to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShardConfiguration. 
        /// <para>
        /// The number of shards in the cluster.
        /// </para>
        /// </summary>
        public ShardConfigurationRequest ShardConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ShardConfiguration property is set.
        /// </summary>
        internal bool IsSetShardConfiguration() => this.ShardConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which MemoryDB retains automatic cluster snapshots before deleting
        /// them. For example, if you set SnapshotRetentionLimit to 5, a snapshot that was taken
        /// today is retained for 5 days before being deleted.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionLimit property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionLimit() => this.SnapshotRetentionLimit.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which MemoryDB begins taking a daily snapshot
        /// of your cluster.
        /// </para>
        /// </summary>
        public string SnapshotWindow { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWindow property is set.
        /// </summary>
        internal bool IsSetSnapshotWindow() => this.SnapshotWindow != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic ARN to update.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SnsTopicStatus. 
        /// <para>
        /// The status of the Amazon SNS notification topic. Notifications are sent only if the
        /// status is active.
        /// </para>
        /// </summary>
        public string SnsTopicStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicStatus property is set.
        /// </summary>
        internal bool IsSetSnsTopicStatus() => this.SnsTopicStatus != null;
    }
}
