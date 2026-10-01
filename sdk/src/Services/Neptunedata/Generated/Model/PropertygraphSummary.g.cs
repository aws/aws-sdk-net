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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// The graph summary API returns a read-only list of node and edge labels and property
    /// keys, along with counts of nodes, edges, and properties. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-graph-summary.html#neptune-graph-summary-pg-response">Graph
    /// summary response for a property graph (PG)</a>.
    /// </summary>
    public partial class PropertygraphSummary
    {
        /// <summary>
        /// Gets and sets the property EdgeLabels. 
        /// <para>
        /// A list of the distinct edge labels in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLabels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EdgeLabels property is set.
        /// </summary>
        internal bool IsSetEdgeLabels() => this.EdgeLabels != null && (this.EdgeLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EdgeProperties. 
        /// <para>
        /// A list of the distinct edge properties in the graph, along with the count of edges
        /// where each property is used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> EdgeProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;

        /// <summary>
        /// Checks to see if the EdgeProperties property is set.
        /// </summary>
        internal bool IsSetEdgeProperties() => this.EdgeProperties != null && (this.EdgeProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EdgeStructures. 
        /// <para>
        /// This field is only present when the requested mode is <c>DETAILED</c>. It contains
        /// a list of edge structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeStructure> EdgeStructures { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeStructure>() : null;

        /// <summary>
        /// Checks to see if the EdgeStructures property is set.
        /// </summary>
        internal bool IsSetEdgeStructures() => this.EdgeStructures != null && (this.EdgeStructures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeLabels. 
        /// <para>
        /// A list of the distinct node labels in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeLabels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeLabels property is set.
        /// </summary>
        internal bool IsSetNodeLabels() => this.NodeLabels != null && (this.NodeLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// The number of distinct node properties in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> NodeProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;

        /// <summary>
        /// Checks to see if the NodeProperties property is set.
        /// </summary>
        internal bool IsSetNodeProperties() => this.NodeProperties != null && (this.NodeProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeStructures. 
        /// <para>
        /// This field is only present when the requested mode is <c>DETAILED</c>. It contains
        /// a list of node structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeStructure> NodeStructures { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeStructure>() : null;

        /// <summary>
        /// Checks to see if the NodeStructures property is set.
        /// </summary>
        internal bool IsSetNodeStructures() => this.NodeStructures != null && (this.NodeStructures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumEdgeLabels. 
        /// <para>
        /// The number of distinct edge labels in the graph.
        /// </para>
        /// </summary>
        public long? NumEdgeLabels { get; set; }

        /// <summary>
        /// Checks to see if the NumEdgeLabels property is set.
        /// </summary>
        internal bool IsSetNumEdgeLabels() => this.NumEdgeLabels.HasValue;

        /// <summary>
        /// Gets and sets the property NumEdgeProperties. 
        /// <para>
        /// The number of distinct edge properties in the graph.
        /// </para>
        /// </summary>
        public long? NumEdgeProperties { get; set; }

        /// <summary>
        /// Checks to see if the NumEdgeProperties property is set.
        /// </summary>
        internal bool IsSetNumEdgeProperties() => this.NumEdgeProperties.HasValue;

        /// <summary>
        /// Gets and sets the property NumEdges. 
        /// <para>
        /// The number of edges in the graph.
        /// </para>
        /// </summary>
        public long? NumEdges { get; set; }

        /// <summary>
        /// Checks to see if the NumEdges property is set.
        /// </summary>
        internal bool IsSetNumEdges() => this.NumEdges.HasValue;

        /// <summary>
        /// Gets and sets the property NumNodeLabels. 
        /// <para>
        /// The number of distinct node labels in the graph.
        /// </para>
        /// </summary>
        public long? NumNodeLabels { get; set; }

        /// <summary>
        /// Checks to see if the NumNodeLabels property is set.
        /// </summary>
        internal bool IsSetNumNodeLabels() => this.NumNodeLabels.HasValue;

        /// <summary>
        /// Gets and sets the property NumNodeProperties. 
        /// <para>
        /// A list of the distinct node properties in the graph, along with the count of nodes
        /// where each property is used.
        /// </para>
        /// </summary>
        public long? NumNodeProperties { get; set; }

        /// <summary>
        /// Checks to see if the NumNodeProperties property is set.
        /// </summary>
        internal bool IsSetNumNodeProperties() => this.NumNodeProperties.HasValue;

        /// <summary>
        /// Gets and sets the property NumNodes. 
        /// <para>
        /// The number of nodes in the graph.
        /// </para>
        /// </summary>
        public long? NumNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumNodes property is set.
        /// </summary>
        internal bool IsSetNumNodes() => this.NumNodes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalEdgePropertyValues. 
        /// <para>
        /// The total number of usages of all edge properties.
        /// </para>
        /// </summary>
        public long? TotalEdgePropertyValues { get; set; }

        /// <summary>
        /// Checks to see if the TotalEdgePropertyValues property is set.
        /// </summary>
        internal bool IsSetTotalEdgePropertyValues() => this.TotalEdgePropertyValues.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNodePropertyValues. 
        /// <para>
        /// The total number of usages of all node properties.
        /// </para>
        /// </summary>
        public long? TotalNodePropertyValues { get; set; }

        /// <summary>
        /// Checks to see if the TotalNodePropertyValues property is set.
        /// </summary>
        internal bool IsSetTotalNodePropertyValues() => this.TotalNodePropertyValues.HasValue;
    }
}
