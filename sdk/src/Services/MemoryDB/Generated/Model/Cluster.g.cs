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
    /// Contains all of the attributes of a specific cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List associated with this cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ACLName { get; set; }

        /// <summary>
        /// Checks to see if the ACLName property is set.
        /// </summary>
        internal bool IsSetACLName() => this.ACLName != null;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

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
        /// Gets and sets the property AvailabilityMode. 
        /// <para>
        /// Indicates if the cluster has a Multi-AZ configuration (multiaz) or not (singleaz).
        /// </para>
        /// </summary>
        public AZStatus AvailabilityMode { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityMode property is set.
        /// </summary>
        internal bool IsSetAvailabilityMode() => this.AvailabilityMode != null;

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The cluster's configuration endpoint
        /// </para>
        /// </summary>
        public Endpoint ClusterEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ClusterEndpoint property is set.
        /// </summary>
        internal bool IsSetClusterEndpoint() => this.ClusterEndpoint != null;

        /// <summary>
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for clusters using the r6gd node
        /// type. This parameter must be set when using r6gd nodes. For more information, see
        /// <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public DataTieringStatus DataTiering { get; set; }

        /// <summary>
        /// Checks to see if the DataTiering property is set.
        /// </summary>
        internal bool IsSetDataTiering() => this.DataTiering != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the cluster
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
        /// The name of the engine used by the cluster.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EnginePatchVersion. 
        /// <para>
        /// The Redis OSS engine patch version used by the cluster
        /// </para>
        /// </summary>
        public string EnginePatchVersion { get; set; }

        /// <summary>
        /// Checks to see if the EnginePatchVersion property is set.
        /// </summary>
        internal bool IsSetEnginePatchVersion() => this.EnginePatchVersion != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Redis OSS engine version used by the cluster
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
        /// The mechanism that the cluster uses to discover IP addresses. Returns 'ipv4' when
        /// DNS endpoints resolve to IPv4 addresses, or 'ipv6' when DNS endpoints resolve to IPv6
        /// addresses.
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
        /// The ID of the KMS key used to encrypt the cluster
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
        /// </summary>
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster that this cluster belongs to.
        /// </para>
        /// </summary>
        public string MultiRegionClusterName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterName property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterName() => this.MultiRegionClusterName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-supplied name of the cluster. This identifier is a unique key that identifies
        /// a cluster.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The IP address type for the cluster. Returns 'ipv4' for IPv4 only, 'ipv6' for IPv6
        /// only, or 'dual-stack' if the cluster supports both IPv4 and IPv6 addressing.
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
        /// The cluster's node type
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumberOfShards. 
        /// <para>
        /// The number of shards in the cluster
        /// </para>
        /// </summary>
        public int? NumberOfShards { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfShards property is set.
        /// </summary>
        internal bool IsSetNumberOfShards() => this.NumberOfShards.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group used by the cluster
        /// </para>
        /// </summary>
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupName property is set.
        /// </summary>
        internal bool IsSetParameterGroupName() => this.ParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupStatus. 
        /// <para>
        /// The status of the parameter group used by the cluster, for example 'active' or 'applying'.
        /// </para>
        /// </summary>
        public string ParameterGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupStatus property is set.
        /// </summary>
        internal bool IsSetParameterGroupStatus() => this.ParameterGroupStatus != null;

        /// <summary>
        /// Gets and sets the property PendingUpdates. 
        /// <para>
        /// A group of settings that are currently being applied.
        /// </para>
        /// </summary>
        public ClusterPendingUpdates PendingUpdates { get; set; }

        /// <summary>
        /// Checks to see if the PendingUpdates property is set.
        /// </summary>
        internal bool IsSetPendingUpdates() => this.PendingUpdates != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security groups used by the cluster
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// A list of shards that are members of the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Shard> Shards { get; set; } = AWSConfigs.InitializeCollections ? new List<Shard>() : null;

        /// <summary>
        /// Checks to see if the Shards property is set.
        /// </summary>
        internal bool IsSetShards() => this.Shards != null && (this.Shards.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// of your shard. Example: 05:00-09:00 If you do not specify this parameter, MemoryDB
        /// automatically chooses an appropriate time range.
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
        /// The Amazon Resource Name (ARN) of the SNS notification topic
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
        /// The SNS topic must be in Active status to receive notifications
        /// </para>
        /// </summary>
        public string SnsTopicStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicStatus property is set.
        /// </summary>
        internal bool IsSetSnsTopicStatus() => this.SnsTopicStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. For example, Available, Updating, Creating.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group used by the cluster
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
        /// A flag to indicate if In-transit encryption is enabled
        /// </para>
        /// </summary>
        public bool? TLSEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TLSEnabled property is set.
        /// </summary>
        internal bool IsSetTLSEnabled() => this.TLSEnabled.HasValue;
    }
}
