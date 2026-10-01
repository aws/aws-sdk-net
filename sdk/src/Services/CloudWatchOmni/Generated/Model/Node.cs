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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// A node in the context graph representing a service, resource, or remote service.
    /// </summary>
    public partial class Node
    {
        private List<string> _alternateNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Edge> _edges = AWSConfigs.InitializeCollections ? new List<Edge>() : null;
        private DateTime? _firstObservedAt;
        private DateTime? _lastObservedAt;
        private Metadata _metadata;
        private string _name;
        private string _nodeId;
        private NodeProperties _nodeProperties;
        private NodeType _nodeType;
        private Dictionary<string, List<Dictionary<string, string>>> _operationDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, List<Dictionary<string, string>>>() : null;
        private List<string> _signalTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _telemetryAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AlternateNames. 
        /// <para>
        /// Other names this node was observed under. A node that merged across sources reports
        /// one resolved name, and the names it was merged away from appear here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> AlternateNames
        {
            get { return this._alternateNames; }
            set { this._alternateNames = value; }
        }

        // Check to see if AlternateNames property is set
        internal bool IsSetAlternateNames()
        {
            return this._alternateNames != null && (this._alternateNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// Outbound edges originating from this node. Each edge carries its <c>from</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public List<Edge> Edges
        {
            get { return this._edges; }
            set { this._edges = value; }
        }

        // Check to see if Edges property is set
        internal bool IsSetEdges()
        {
            return this._edges != null && (this._edges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// When this node was first observed (UTC), at minute granularity. For a node that merged
        /// across sources, this is the earliest value any source reported.
        /// </para>
        /// </summary>
        public DateTime? FirstObservedAt
        {
            get { return this._firstObservedAt; }
            set { this._firstObservedAt = value; }
        }

        // Check to see if FirstObservedAt property is set
        internal bool IsSetFirstObservedAt()
        {
            return this._firstObservedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// When this node was most recently observed (UTC), at minute granularity. For a node
        /// that merged across sources, this is the latest value any source reported.
        /// </para>
        /// </summary>
        public DateTime? LastObservedAt
        {
            get { return this._lastObservedAt; }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Descriptive metadata about the node. Present only when the request sets includeMetadata.
        /// </para>
        /// </summary>
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The primary display name of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The unique identifier of the node within the context graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// Identity attributes promoted out of the flat attribute map onto typed members.
        /// </para>
        /// </summary>
        public NodeProperties NodeProperties
        {
            get { return this._nodeProperties; }
            set { this._nodeProperties = value; }
        }

        // Check to see if NodeProperties property is set
        internal bool IsSetNodeProperties()
        {
            return this._nodeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// Whether the node is a service, a resource, or a remote service.
        /// </para>
        /// </summary>
        public NodeType NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property OperationDetails. 
        /// <para>
        /// The operations observed on this node, keyed by operation name. Each value lists the
        /// dimension sets that identify the metric series for that operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, List<Dictionary<string, string>>> OperationDetails
        {
            get { return this._operationDetails; }
            set { this._operationDetails = value; }
        }

        // Check to see if OperationDetails property is set
        internal bool IsSetOperationDetails()
        {
            return this._operationDetails != null && (this._operationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalTypes. 
        /// <para>
        /// The kinds of telemetry signal observed on this node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SignalTypes
        {
            get { return this._signalTypes; }
            set { this._signalTypes = value; }
        }

        // Check to see if SignalTypes property is set
        internal bool IsSetSignalTypes()
        {
            return this._signalTypes != null && (this._signalTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The discovery sources that contributed this node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags observed on the underlying resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TelemetryAttributes. 
        /// <para>
        /// The node's OpenTelemetry (OTel) attributes, as emitted by telemetry — the raw values,
        /// as opposed to the normalized <c>nodeProperties</c>. A key promoted onto a <c>nodeProperties</c>
        /// member is removed here, so no value appears twice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> TelemetryAttributes
        {
            get { return this._telemetryAttributes; }
            set { this._telemetryAttributes = value; }
        }

        // Check to see if TelemetryAttributes property is set
        internal bool IsSetTelemetryAttributes()
        {
            return this._telemetryAttributes != null && (this._telemetryAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}