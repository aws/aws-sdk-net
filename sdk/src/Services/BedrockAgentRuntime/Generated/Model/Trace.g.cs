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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains one part of the agent's reasoning process and results from calling API actions
    /// and querying knowledge bases. You can use the trace to understand how the agent arrived
    /// at the response it provided the customer. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-enablement">Trace
    /// enablement</a>.
    /// </summary>
    public partial class Trace
    {
        /// <summary>
        /// Gets and sets the property CustomOrchestrationTrace. 
        /// <para>
        ///  Details about the custom orchestration step in which the agent determines the order
        /// in which actions are executed. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CustomOrchestrationTrace CustomOrchestrationTrace { get; set; }

        /// <summary>
        /// Checks to see if the CustomOrchestrationTrace property is set.
        /// </summary>
        internal bool IsSetCustomOrchestrationTrace() => this.CustomOrchestrationTrace != null;

        /// <summary>
        /// Gets and sets the property FailureTrace. 
        /// <para>
        /// Contains information about the failure of the interaction.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FailureTrace FailureTrace { get; set; }

        /// <summary>
        /// Checks to see if the FailureTrace property is set.
        /// </summary>
        internal bool IsSetFailureTrace() => this.FailureTrace != null;

        /// <summary>
        /// Gets and sets the property GuardrailTrace. 
        /// <para>
        /// The trace details for a trace defined in the Guardrail filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailTrace GuardrailTrace { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailTrace property is set.
        /// </summary>
        internal bool IsSetGuardrailTrace() => this.GuardrailTrace != null;

        /// <summary>
        /// Gets and sets the property OrchestrationTrace. 
        /// <para>
        /// Details about the orchestration step, in which the agent determines the order in which
        /// actions are executed and which knowledge bases are retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public OrchestrationTrace OrchestrationTrace { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationTrace property is set.
        /// </summary>
        internal bool IsSetOrchestrationTrace() => this.OrchestrationTrace != null;

        /// <summary>
        /// Gets and sets the property PostProcessingTrace. 
        /// <para>
        /// Details about the post-processing step, in which the agent shapes the response..
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PostProcessingTrace PostProcessingTrace { get; set; }

        /// <summary>
        /// Checks to see if the PostProcessingTrace property is set.
        /// </summary>
        internal bool IsSetPostProcessingTrace() => this.PostProcessingTrace != null;

        /// <summary>
        /// Gets and sets the property PreProcessingTrace. 
        /// <para>
        /// Details about the pre-processing step, in which the agent contextualizes and categorizes
        /// user inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PreProcessingTrace PreProcessingTrace { get; set; }

        /// <summary>
        /// Checks to see if the PreProcessingTrace property is set.
        /// </summary>
        internal bool IsSetPreProcessingTrace() => this.PreProcessingTrace != null;

        /// <summary>
        /// Gets and sets the property RoutingClassifierTrace. 
        /// <para>
        /// A routing classifier's trace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RoutingClassifierTrace RoutingClassifierTrace { get; set; }

        /// <summary>
        /// Checks to see if the RoutingClassifierTrace property is set.
        /// </summary>
        internal bool IsSetRoutingClassifierTrace() => this.RoutingClassifierTrace != null;
    }
}
