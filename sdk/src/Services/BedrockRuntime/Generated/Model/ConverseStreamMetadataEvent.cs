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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A conversation stream metadata event.
    /// </summary>
    public partial class ConverseStreamMetadataEvent
        : IEventStreamEvent
    {
        private ConverseStreamMetrics _metrics;
        private PerformanceConfiguration _performanceConfig;
        private ConverseStreamTrace _trace;
        private TokenUsage _usage;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for the conversation stream metadata event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConverseStreamMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// Model performance configuration metadata for the conversation stream event.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig
        {
            get { return this._performanceConfig; }
            set { this._performanceConfig = value; }
        }

        // Check to see if PerformanceConfig property is set
        internal bool IsSetPerformanceConfig()
        {
            return this._performanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// The trace object in the response from <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>
        /// that contains information about the guardrail behavior.
        /// </para>
        /// </summary>
        public ConverseStreamTrace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return this._trace != null;
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Usage information for the conversation stream event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenUsage Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}