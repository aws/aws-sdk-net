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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Details about a specific span where a failure was detected.
    /// </summary>
    public partial class FailureSpanDetail
    {
        /// <summary>
        /// Gets and sets the property Signals. 
        /// <para>
        /// The failure signals detected in this span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InsightsFailureSignal> Signals { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightsFailureSignal>() : null;

        /// <summary>
        /// Checks to see if the Signals property is set.
        /// </summary>
        internal bool IsSetSignals() => this.Signals != null && (this.Signals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpanId. 
        /// <para>
        /// The unique identifier of the span where the failure occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpanId { get; set; }

        /// <summary>
        /// Checks to see if the SpanId property is set.
        /// </summary>
        internal bool IsSetSpanId() => this.SpanId != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier associated with the failure span.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;
    }
}
