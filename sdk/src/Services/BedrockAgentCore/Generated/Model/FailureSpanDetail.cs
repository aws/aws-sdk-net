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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Details about a specific span where a failure was detected.
    /// </summary>
    public partial class FailureSpanDetail
    {
        private List<InsightsFailureSignal> _signals = AWSConfigs.InitializeCollections ? new List<InsightsFailureSignal>() : null;
        private string _spanId;
        private string _traceId;

        /// <summary>
        /// Gets and sets the property Signals. 
        /// <para>
        /// The failure signals detected in this span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InsightsFailureSignal> Signals
        {
            get { return this._signals; }
            set { this._signals = value; }
        }

        // Check to see if Signals property is set
        internal bool IsSetSignals()
        {
            return this._signals != null && (this._signals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpanId. 
        /// <para>
        /// The unique identifier of the span where the failure occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpanId
        {
            get { return this._spanId; }
            set { this._spanId = value; }
        }

        // Check to see if SpanId property is set
        internal bool IsSetSpanId()
        {
            return this._spanId != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier associated with the failure span.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

    }
}