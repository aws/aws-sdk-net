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
    /// A directed edge in the context graph connecting two nodes.
    /// </summary>
    public partial class Edge
    {
        private string _edgeId;
        private EdgeProperties _edgeProperties;
        private EdgeType _edgeType;
        private DateTime? _firstObservedAt;
        private string _from;
        private DateTime? _lastObservedAt;
        private Metadata _metadata;
        private List<string> _operations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _signalTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _telemetryAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _to;

        /// <summary>
        /// Gets and sets the property EdgeId. 
        /// <para>
        /// The unique identifier of the edge within the context graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EdgeId
        {
            get { return this._edgeId; }
            set { this._edgeId = value; }
        }

        // Check to see if EdgeId property is set
        internal bool IsSetEdgeId()
        {
            return this._edgeId != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeProperties. 
        /// <para>
        /// Attributes promoted out of the flat attribute map onto typed members. Which members
        /// are present depends on what produced the edge.
        /// </para>
        /// </summary>
        public EdgeProperties EdgeProperties
        {
            get { return this._edgeProperties; }
            set { this._edgeProperties = value; }
        }

        // Check to see if EdgeProperties property is set
        internal bool IsSetEdgeProperties()
        {
            return this._edgeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeType. 
        /// <para>
        /// The kind of relationship the edge represents.
        /// </para>
        /// </summary>
        public EdgeType EdgeType
        {
            get { return this._edgeType; }
            set { this._edgeType = value; }
        }

        // Check to see if EdgeType property is set
        internal bool IsSetEdgeType()
        {
            return this._edgeType != null;
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// When this edge was first observed (UTC), at minute granularity. For an edge that merged
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
        /// Gets and sets the property From. 
        /// <para>
        /// The node identifier the edge originates from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// When this edge was most recently observed (UTC), at minute granularity. For an edge
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
        /// Descriptive metadata about the edge. Present only when the request sets includeMetadata.
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
        /// Gets and sets the property Operations. 
        /// <para>
        /// The operations observed on this edge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalTypes. 
        /// <para>
        /// The kinds of telemetry signal observed on this edge.
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
        /// The discovery sources that contributed this edge.
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
        /// Gets and sets the property TelemetryAttributes. 
        /// <para>
        /// The edge's OpenTelemetry (OTel) attributes, as emitted by telemetry. A key promoted
        /// onto an <c>edgeProperties</c> member is removed here, so no value appears twice.
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

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The node identifier the edge points to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

    }
}