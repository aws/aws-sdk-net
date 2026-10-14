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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// A directed edge in the context graph connecting two nodes.
    /// </summary>
    public partial class Edge
    {
        /// <summary>
        /// Gets and sets the property EdgeId. The unique identifier of the edge within the context
        /// graph.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EdgeId { get; set; }

        /// <summary>
        /// Checks to see if the EdgeId property is set.
        /// </summary>
        internal bool IsSetEdgeId() => this.EdgeId != null;

        /// <summary>
        /// Gets and sets the property EdgeProperties. Attributes promoted out of the flat attribute
        /// map onto typed members. Which members are present depends on what produced the edge.
        /// </summary>
        public EdgeProperties EdgeProperties { get; set; }

        /// <summary>
        /// Checks to see if the EdgeProperties property is set.
        /// </summary>
        internal bool IsSetEdgeProperties() => this.EdgeProperties != null;

        /// <summary>
        /// Gets and sets the property EdgeType. The kind of relationship the edge represents.
        /// </summary>
        public EdgeType EdgeType { get; set; }

        /// <summary>
        /// Checks to see if the EdgeType property is set.
        /// </summary>
        internal bool IsSetEdgeType() => this.EdgeType != null;

        /// <summary>
        /// Gets and sets the property FirstObservedAt. When this edge was first observed (UTC),
        /// at minute granularity. For an edge that merged across sources, this is the earliest
        /// value any source reported.
        /// </summary>
        public DateTime? FirstObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstObservedAt property is set.
        /// </summary>
        internal bool IsSetFirstObservedAt() => this.FirstObservedAt.HasValue;

        /// <summary>
        /// Gets and sets the property From. The node identifier the edge originates from.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property LastObservedAt. When this edge was most recently observed
        /// (UTC), at minute granularity. For an edge that merged across sources, this is the
        /// latest value any source reported.
        /// </summary>
        public DateTime? LastObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastObservedAt property is set.
        /// </summary>
        internal bool IsSetLastObservedAt() => this.LastObservedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. Descriptive metadata about the edge. Present
        /// only when the request sets includeMetadata.
        /// </summary>
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Operations. The operations observed on this edge.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalTypes. The kinds of telemetry signal observed on
        /// this edge.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SignalTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SignalTypes property is set.
        /// </summary>
        internal bool IsSetSignalTypes() => this.SignalTypes != null && (this.SignalTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sources. The discovery sources that contributed this edge.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryAttributes. The edge's OpenTelemetry (OTel) attributes,
        /// as emitted by telemetry. A key promoted onto an `edgeProperties` member is removed
        /// here, so no value appears twice.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> TelemetryAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TelemetryAttributes property is set.
        /// </summary>
        internal bool IsSetTelemetryAttributes() => this.TelemetryAttributes != null && (this.TelemetryAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property To. The node identifier the edge points to.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;
    }
}
