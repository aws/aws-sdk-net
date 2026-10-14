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
    /// Container for the parameters to the CreateMultiRegionCluster operation. Creates a
    /// new multi-Region cluster.
    /// </summary>
    public partial class CreateMultiRegionClusterRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the multi-Region cluster.
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
        /// The name of the engine to be used for the multi-Region cluster.
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
        /// The version of the engine to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property MultiRegionClusterNameSuffix. 
        /// <para>
        /// A suffix to be added to the Multi-Region cluster name. Amazon MemoryDB automatically
        /// applies a prefix to the Multi-Region cluster Name when it is created. Each Amazon
        /// Region has its own prefix. For instance, a Multi-Region cluster Name created in the
        /// US-West-1 region will begin with "virxk", along with the suffix name you provide.
        /// The suffix guarantees uniqueness of the Multi-Region cluster name across multiple
        /// regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MultiRegionClusterNameSuffix { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionClusterNameSuffix property is set.
        /// </summary>
        internal bool IsSetMultiRegionClusterNameSuffix() => this.MultiRegionClusterNameSuffix != null;

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The name of the multi-Region parameter group to be associated with the cluster.
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
        /// The node type to be used for the multi-Region cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumShards. 
        /// <para>
        /// The number of shards for the multi-Region cluster.
        /// </para>
        /// </summary>
        public int? NumShards { get; set; }

        /// <summary>
        /// Checks to see if the NumShards property is set.
        /// </summary>
        internal bool IsSetNumShards() => this.NumShards.HasValue;

        /// <summary>
        /// Gets and sets the property TLSEnabled. 
        /// <para>
        /// Whether to enable TLS encryption for the multi-Region cluster.
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
        /// A list of tags to be applied to the multi-Region cluster.
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
