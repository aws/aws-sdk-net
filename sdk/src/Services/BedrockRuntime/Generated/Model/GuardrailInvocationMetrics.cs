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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The invocation metrics for the guardrail.
    /// </summary>
    public partial class GuardrailInvocationMetrics
    {
        private GuardrailCoverage _guardrailCoverage;
        private long? _guardrailProcessingLatency;
        private GuardrailUsage _usage;

        /// <summary>
        /// Gets and sets the property GuardrailCoverage. 
        /// <para>
        /// The coverage details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public GuardrailCoverage GuardrailCoverage
        {
            get { return this._guardrailCoverage; }
            set { this._guardrailCoverage = value; }
        }

        // Check to see if GuardrailCoverage property is set
        internal bool IsSetGuardrailCoverage()
        {
            return this._guardrailCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailProcessingLatency. 
        /// <para>
        /// The processing latency details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public long? GuardrailProcessingLatency
        {
            get { return this._guardrailProcessingLatency; }
            set { this._guardrailProcessingLatency = value; }
        }

        // Check to see if GuardrailProcessingLatency property is set
        internal bool IsSetGuardrailProcessingLatency()
        {
            return this._guardrailProcessingLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The usage details for the guardrail invocation metrics.
        /// </para>
        /// </summary>
        public GuardrailUsage Usage
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