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
    /// Descriptive information about a context graph node or edge, as opposed to its identity
    /// and structure. Returned only when the request sets includeMetadata.
    /// </summary>
    public partial class Metadata
    {
        /// <summary>
        /// Gets and sets the property Logs. Per-signal LOGS query selectors: a LIST of blocks
        /// the console ORs, each an AND of exact store column -> raw values. Node-level (edges
        /// carry only traces). Populated when the request sets includeMetadata; derived labels
        /// (logSourceType) are added by the service projection, not stored here.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<LogMetadata> Logs { get; set; } = AWSConfigs.InitializeCollections ? new List<LogMetadata>() : null;

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null && (this.Logs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metrics. The metrics observed on the element.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<MetricMetadata> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricMetadata>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Semantics. Semantic description of the node. Absent on
        /// an edge, because semantics describe a service rather than a relationship.
        /// </summary>
        public NodeSemantics Semantics { get; set; }

        /// <summary>
        /// Checks to see if the Semantics property is set.
        /// </summary>
        internal bool IsSetSemantics() => this.Semantics != null;

        /// <summary>
        /// Gets and sets the property Traces. Per-signal TRACES query selectors (same block shape
        /// as logs). Present on both node and edge metadata. serviceName is derived at the service
        /// projection, not stored here.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<TraceMetadata> Traces { get; set; } = AWSConfigs.InitializeCollections ? new List<TraceMetadata>() : null;

        /// <summary>
        /// Checks to see if the Traces property is set.
        /// </summary>
        internal bool IsSetTraces() => this.Traces != null && (this.Traces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
