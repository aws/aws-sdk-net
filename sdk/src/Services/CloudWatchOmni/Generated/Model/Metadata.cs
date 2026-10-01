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
    /// Descriptive information about a context graph node or edge, as opposed to its identity
    /// and structure. Returned only when the request sets includeMetadata.
    /// </summary>
    public partial class Metadata
    {
        private List<LogMetadata> _logs = AWSConfigs.InitializeCollections ? new List<LogMetadata>() : null;
        private List<MetricMetadata> _metrics = AWSConfigs.InitializeCollections ? new List<MetricMetadata>() : null;
        private NodeSemantics _semantics;
        private List<TraceMetadata> _traces = AWSConfigs.InitializeCollections ? new List<TraceMetadata>() : null;

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        /// Per-signal LOGS query selectors: a LIST of blocks the console ORs, each an AND of
        /// exact store column -&gt; raw values. Node-level (edges carry only traces). Populated
        /// when the request sets includeMetadata; derived labels (logSourceType) are added by
        /// the service projection, not stored here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<LogMetadata> Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null && (this._logs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics observed on the element.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<MetricMetadata> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Semantics. 
        /// <para>
        /// Semantic description of the node. Absent on an edge, because semantics describe a
        /// service rather than a relationship.
        /// </para>
        /// </summary>
        public NodeSemantics Semantics
        {
            get { return this._semantics; }
            set { this._semantics = value; }
        }

        // Check to see if Semantics property is set
        internal bool IsSetSemantics()
        {
            return this._semantics != null;
        }

        /// <summary>
        /// Gets and sets the property Traces. 
        /// <para>
        /// Per-signal TRACES query selectors (same block shape as logs). Present on both node
        /// and edge metadata. serviceName is derived at the service projection, not stored here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TraceMetadata> Traces
        {
            get { return this._traces; }
            set { this._traces = value; }
        }

        // Check to see if Traces property is set
        internal bool IsSetTraces()
        {
            return this._traces != null && (this._traces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}