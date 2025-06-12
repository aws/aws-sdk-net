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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
        private List<string> _edgeLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Dictionary<string, long>> _edgeProperties = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;
        private List<EdgeStructure> _edgeStructures = AWSConfigs.InitializeCollections ? new List<EdgeStructure>() : null;
        private List<string> _nodeLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Dictionary<string, long>> _nodeProperties = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;
        private List<NodeStructure> _nodeStructures = AWSConfigs.InitializeCollections ? new List<NodeStructure>() : null;
        private long? _numEdgeLabels;
        private long? _numEdgeProperties;
        private long? _numEdges;
        private long? _numNodeLabels;
        private long? _numNodeProperties;
        private long? _numNodes;
        private long? _totalEdgePropertyValues;
        private long? _totalNodePropertyValues;

        /// <summary>
        /// Gets and sets the property EdgeLabels. 
        /// <para>
        /// A list of the distinct edge labels in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLabels
        {
            get { return this._edgeLabels; }
            set { this._edgeLabels = value; }
        }

        // Check to see if EdgeLabels property is set
        internal bool IsSetEdgeLabels()
        {
            return this._edgeLabels != null && (this._edgeLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EdgeProperties. 
        /// <para>
        /// A list of the distinct edge properties in the graph, along with the count of edges
        /// where each property is used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> EdgeProperties
        {
            get { return this._edgeProperties; }
            set { this._edgeProperties = value; }
        }

        // Check to see if EdgeProperties property is set
        internal bool IsSetEdgeProperties()
        {
            return this._edgeProperties != null && (this._edgeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EdgeStructures. 
        /// <para>
        /// This field is only present when the requested mode is <c>DETAILED</c>. It contains
        /// a list of edge structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeStructure> EdgeStructures
        {
            get { return this._edgeStructures; }
            set { this._edgeStructures = value; }
        }

        // Check to see if EdgeStructures property is set
        internal bool IsSetEdgeStructures()
        {
            return this._edgeStructures != null && (this._edgeStructures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeLabels. 
        /// <para>
        /// A list of the distinct node labels in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeLabels
        {
            get { return this._nodeLabels; }
            set { this._nodeLabels = value; }
        }

        // Check to see if NodeLabels property is set
        internal bool IsSetNodeLabels()
        {
            return this._nodeLabels != null && (this._nodeLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// The number of distinct node properties in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> NodeProperties
        {
            get { return this._nodeProperties; }
            set { this._nodeProperties = value; }
        }

        // Check to see if NodeProperties property is set
        internal bool IsSetNodeProperties()
        {
            return this._nodeProperties != null && (this._nodeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeStructures. 
        /// <para>
        /// This field is only present when the requested mode is <c>DETAILED</c>. It contains
        /// a list of node structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeStructure> NodeStructures
        {
            get { return this._nodeStructures; }
            set { this._nodeStructures = value; }
        }

        // Check to see if NodeStructures property is set
        internal bool IsSetNodeStructures()
        {
            return this._nodeStructures != null && (this._nodeStructures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumEdgeLabels. 
        /// <para>
        /// The number of distinct edge labels in the graph.
        /// </para>
        /// </summary>
        public long? NumEdgeLabels
        {
            get { return this._numEdgeLabels; }
            set { this._numEdgeLabels = value; }
        }

        // Check to see if NumEdgeLabels property is set
        internal bool IsSetNumEdgeLabels()
        {
            return this._numEdgeLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumEdgeProperties. 
        /// <para>
        /// The number of distinct edge properties in the graph.
        /// </para>
        /// </summary>
        public long? NumEdgeProperties
        {
            get { return this._numEdgeProperties; }
            set { this._numEdgeProperties = value; }
        }

        // Check to see if NumEdgeProperties property is set
        internal bool IsSetNumEdgeProperties()
        {
            return this._numEdgeProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumEdges. 
        /// <para>
        /// The number of edges in the graph.
        /// </para>
        /// </summary>
        public long? NumEdges
        {
            get { return this._numEdges; }
            set { this._numEdges = value; }
        }

        // Check to see if NumEdges property is set
        internal bool IsSetNumEdges()
        {
            return this._numEdges.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumNodeLabels. 
        /// <para>
        /// The number of distinct node labels in the graph.
        /// </para>
        /// </summary>
        public long? NumNodeLabels
        {
            get { return this._numNodeLabels; }
            set { this._numNodeLabels = value; }
        }

        // Check to see if NumNodeLabels property is set
        internal bool IsSetNumNodeLabels()
        {
            return this._numNodeLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumNodeProperties. 
        /// <para>
        /// A list of the distinct node properties in the graph, along with the count of nodes
        /// where each property is used.
        /// </para>
        /// </summary>
        public long? NumNodeProperties
        {
            get { return this._numNodeProperties; }
            set { this._numNodeProperties = value; }
        }

        // Check to see if NumNodeProperties property is set
        internal bool IsSetNumNodeProperties()
        {
            return this._numNodeProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumNodes. 
        /// <para>
        /// The number of nodes in the graph.
        /// </para>
        /// </summary>
        public long? NumNodes
        {
            get { return this._numNodes; }
            set { this._numNodes = value; }
        }

        // Check to see if NumNodes property is set
        internal bool IsSetNumNodes()
        {
            return this._numNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalEdgePropertyValues. 
        /// <para>
        /// The total number of usages of all edge properties.
        /// </para>
        /// </summary>
        public long? TotalEdgePropertyValues
        {
            get { return this._totalEdgePropertyValues; }
            set { this._totalEdgePropertyValues = value; }
        }

        // Check to see if TotalEdgePropertyValues property is set
        internal bool IsSetTotalEdgePropertyValues()
        {
            return this._totalEdgePropertyValues.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNodePropertyValues. 
        /// <para>
        /// The total number of usages of all node properties.
        /// </para>
        /// </summary>
        public long? TotalNodePropertyValues
        {
            get { return this._totalNodePropertyValues; }
            set { this._totalNodePropertyValues = value; }
        }

        // Check to see if TotalNodePropertyValues property is set
        internal bool IsSetTotalNodePropertyValues()
        {
            return this._totalNodePropertyValues.HasValue; 
        }

    }
}