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
    /// A list of cluster configuration options.
    /// </summary>
    public partial class ClusterConfiguration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster configuration
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
        /// The name of the engine used by the cluster configuration.
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
        /// The Redis OSS engine version used by the cluster
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The specified maintenance window for the cluster
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
        /// The name for the multi-Region cluster associated with the cluster configuration.
        /// </para>
        /// </summary>
        public string MultiRegionClusterName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterName property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterName() => this.MultiRegionClusterName != null;

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The name of the multi-Region parameter group associated with the cluster configuration.
        /// </para>
        /// </summary>
        public string MultiRegionParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionParameterGroupName property is set.
        /// </summary>
        internal bool IsSetMultiRegionParameterGroupName() => this.MultiRegionParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type used for the cluster
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards in the cluster
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
        /// The name of parameter group used by the cluster
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
        /// The port used by the cluster
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// The list of shards in the cluster
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ShardDetail> Shards { get; set; } = AWSConfigs.InitializeCollections ? new List<ShardDetail>() : null;

        /// <summary>
        /// Checks to see if the Shards property is set.
        /// </summary>
        internal bool IsSetShards() => this.Shards != null && (this.Shards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The snapshot retention limit set by the cluster
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
        /// The snapshot window set by the cluster
        /// </para>
        /// </summary>
        public string SnapshotWindow { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotWindow property is set.
        /// </summary>
        internal bool IsSetSnapshotWindow() => this.SnapshotWindow != null;

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
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS notification topic for the cluster
        /// </para>
        /// </summary>
        public string TopicArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicArn property is set.
        /// </summary>
        internal bool IsSetTopicArn() => this.TopicArn != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC the cluster belongs to
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
