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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The invocation metrics for the guardrail.
    /// </summary>
    public partial class GuardrailInvocationMetrics
    {
        /// <summary>
        /// Gets and sets the property GuardrailCoverage. 
        /// <para>
        /// The coverage details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public GuardrailCoverage GuardrailCoverage { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailCoverage property is set.
        /// </summary>
        internal bool IsSetGuardrailCoverage() => this.GuardrailCoverage != null;

        /// <summary>
        /// Gets and sets the property GuardrailProcessingLatency. 
        /// <para>
        /// The processing latency details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public long? GuardrailProcessingLatency { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailProcessingLatency property is set.
        /// </summary>
        internal bool IsSetGuardrailProcessingLatency() => this.GuardrailProcessingLatency.HasValue;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The usage details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public GuardrailUsage Usage { get; set; }

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null;
    }
}
