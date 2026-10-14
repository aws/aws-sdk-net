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
    /// Container for the parameters to the CreateCluster operation. Creates a cluster. All
    /// nodes in the cluster run the same protocol-compliant engine software.
    /// </summary>
    public partial class CreateClusterRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List to associate with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ACLName { get; set; }

        /// <summary>
        /// Checks to see if the ACLName property is set.
        /// </summary>
        internal bool IsSetACLName() => this.ACLName != null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// When set to true, the cluster will automatically receive minor engine version upgrades
        /// after launch.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster. This value must be unique as it also serves as the cluster
        /// identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for clusters using the r6gd node
        /// type. This parameter must be set when using r6gd nodes. For more information, see
        /// <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public bool? DataTiering { get; set; }

        /// <summary>
        /// Checks to see if the DataTiering property is set.
        /// </summary>
        internal bool IsSetDataTiering() => this.DataTiering.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the cluster.
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
        /// The version number of the Redis OSS engine to be used for the cluster.
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
        /// as cluster slots, cluster shards, and cluster nodes return IPv4 addresses for cluster
        /// nodes. When set to 'ipv6', the cluster discovery functions return IPv6 addresses for
        /// cluster nodes. The value must be compatible with the NetworkType parameter. If not
        /// specified, the default is 'ipv4'.
        /// </para>
        /// </summary>
        public IpDiscovery IpDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the IpDiscovery property is set.
        /// </summary>
        internal bool IsSetIpDiscovery() => this.IpDiscovery != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the cluster.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

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
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster to be created.
        /// </para>
        /// </summary>
        public string MultiRegionClusterName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterName property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterName() => this.MultiRegionClusterName != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Specifies the IP address type for the cluster. Valid values are 'ipv4', 'ipv6', or
        /// 'dual_stack'. When set to 'ipv4', the cluster will only be accessible via IPv4 addresses.
        /// When set to 'ipv6', the cluster will only be accessible via IPv6 addresses. When set
        /// to 'dual_stack', the cluster will be accessible via both IPv4 and IPv6 addresses.
        /// If not specified, the default is 'ipv4'.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The compute and memory capacity of the nodes in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumReplicasPerShard. 
        /// <para>
        /// The number of replicas to apply to each shard. The default value is 1. The maximum
        /// is 5. 
        /// </para>
        /// </summary>
        public int? NumReplicasPerShard { get; set; }

        /// <summary>
        /// Checks to see if the NumReplicasPerShard property is set.
        /// </summary>
        internal bool IsSetNumReplicasPerShard() => this.NumReplicasPerShard.HasValue;

        /// <summary>
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards the cluster will contain. The default value is 1. 
        /// </para>
        /// </summary>
        public int? NumShards { get; set; }

        /// <summary>
        /// Checks to see if the NumShards property is set.
        /// </summary>
        internal bool IsSetNumShards() => this.NumShards.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group associated with the cluster.
        /// </para>
        /// </summary>
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which each of the nodes accepts connections.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group names to associate with this cluster.
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
        /// Gets and sets the property SnapshotArns. 
        /// <para>
        /// A list of Amazon Resource Names (ARN) that uniquely identify the RDB snapshot files
        /// stored in Amazon S3. The snapshot files are used to populate the new cluster. The
        /// Amazon S3 object name in the ARN cannot contain any commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotArns property is set.
        /// </summary>
        internal bool IsSetSnapshotArns() => this.SnapshotArns != null && (this.SnapshotArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of a snapshot from which to restore data into the new cluster. The snapshot
        /// status changes to restoring while the new cluster is being created.
        /// </para>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which MemoryDB retains automatic snapshots before deleting
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
        /// of your shard.
        /// </para>
        ///  
        /// <para>
        ///  Example: 05:00-09:00
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify this parameter, MemoryDB automatically chooses an appropriate
        /// time range.
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
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic
        /// to which notifications are sent.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group to be used for the cluster.
        /// </para>
        /// </summary>
        public string SubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the SubnetGroupName property is set.
        /// </summary>
        internal bool IsSetSubnetGroupName() => this.SubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// A flag to enable in-transit encryption on the cluster.
        /// </para>
        /// </summary>
        public bool? TLSEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TLSEnabled property is set.
        /// </summary>
        internal bool IsSetTLSEnabled() => this.TLSEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. Tags are comma-separated key,value pairs
        /// (e.g. Key=myKey, Value=myKeyValue. You can include multiple tags as shown following:
        /// Key=myKey, Value=myKeyValue Key=mySecondKey, Value=mySecondKeyValue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
