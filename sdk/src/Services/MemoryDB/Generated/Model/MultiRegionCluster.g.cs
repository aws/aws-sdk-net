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
    /// Represents a multi-Region cluster.
    /// </summary>
    public partial class MultiRegionCluster
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the multi-Region cluster.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// The clusters in this multi-Region cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionalCluster> Clusters { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionalCluster>() : null;

        /// <summary>
        /// Checks to see if the Clusters property is set.
        /// </summary>
        internal bool IsSetClusters() => this.Clusters != null && (this.Clusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the multi-Region cluster.
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
        /// The name of the engine used by the multi-Region cluster.
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
        /// The version of the engine used by the multi-Region cluster.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property MultiRegionClusterName. 
        /// <para>
        /// The name of the multi-Region cluster.
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
        /// The name of the multi-Region parameter group associated with the cluster.
        /// </para>
        /// </summary>
        public string MultiRegionParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionParameterGroupName property is set.
        /// </summary>
        internal bool IsSetMultiRegionParameterGroupName() => this.MultiRegionParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type used by the multi-Region cluster.
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
        /// The number of shards in the multi-Region cluster.
        /// </para>
        /// </summary>
        public int? NumberOfShards { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfShards property is set.
        /// </summary>
        internal bool IsSetNumberOfShards() => this.NumberOfShards.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the multi-Region cluster.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// Indiciates if the multi-Region cluster is TLS enabled.
        /// </para>
        /// </summary>
        public bool? TLSEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TLSEnabled property is set.
        /// </summary>
        internal bool IsSetTLSEnabled() => this.TLSEnabled.HasValue;
    }
}
