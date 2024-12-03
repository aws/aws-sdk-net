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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private CustomOrchestrationTrace _customOrchestrationTrace;
        private FailureTrace _failureTrace;
        private GuardrailTrace _guardrailTrace;
        private OrchestrationTrace _orchestrationTrace;
        private PostProcessingTrace _postProcessingTrace;
        private PreProcessingTrace _preProcessingTrace;
        private RoutingClassifierTrace _routingClassifierTrace;

        /// <summary>
        /// Gets and sets the property CustomOrchestrationTrace. 
        /// <para>
        ///  Details about the custom orchestration step in which the agent determines the order
        /// in which actions are executed. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CustomOrchestrationTrace CustomOrchestrationTrace
        {
            get { return this._customOrchestrationTrace; }
            set { this._customOrchestrationTrace = value; }
        }

        // Check to see if CustomOrchestrationTrace property is set
        internal bool IsSetCustomOrchestrationTrace()
        {
            return this._customOrchestrationTrace != null;
        }

        /// <summary>
        /// Gets and sets the property FailureTrace. 
        /// <para>
        /// Contains information about the failure of the interaction.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FailureTrace FailureTrace
        {
            get { return this._failureTrace; }
            set { this._failureTrace = value; }
        }

        // Check to see if FailureTrace property is set
        internal bool IsSetFailureTrace()
        {
            return this._failureTrace != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailTrace. 
        /// <para>
        /// The trace details for a trace defined in the Guardrail filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public GuardrailTrace GuardrailTrace
        {
            get { return this._guardrailTrace; }
            set { this._guardrailTrace = value; }
        }

        // Check to see if GuardrailTrace property is set
        internal bool IsSetGuardrailTrace()
        {
            return this._guardrailTrace != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationTrace. 
        /// <para>
        /// Details about the orchestration step, in which the agent determines the order in which
        /// actions are executed and which knowledge bases are retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public OrchestrationTrace OrchestrationTrace
        {
            get { return this._orchestrationTrace; }
            set { this._orchestrationTrace = value; }
        }

        // Check to see if OrchestrationTrace property is set
        internal bool IsSetOrchestrationTrace()
        {
            return this._orchestrationTrace != null;
        }

        /// <summary>
        /// Gets and sets the property PostProcessingTrace. 
        /// <para>
        /// Details about the post-processing step, in which the agent shapes the response..
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PostProcessingTrace PostProcessingTrace
        {
            get { return this._postProcessingTrace; }
            set { this._postProcessingTrace = value; }
        }

        // Check to see if PostProcessingTrace property is set
        internal bool IsSetPostProcessingTrace()
        {
            return this._postProcessingTrace != null;
        }

        /// <summary>
        /// Gets and sets the property PreProcessingTrace. 
        /// <para>
        /// Details about the pre-processing step, in which the agent contextualizes and categorizes
        /// user inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PreProcessingTrace PreProcessingTrace
        {
            get { return this._preProcessingTrace; }
            set { this._preProcessingTrace = value; }
        }

        // Check to see if PreProcessingTrace property is set
        internal bool IsSetPreProcessingTrace()
        {
            return this._preProcessingTrace != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingClassifierTrace. 
        /// <para>
        /// A routing classifier's trace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RoutingClassifierTrace RoutingClassifierTrace
        {
            get { return this._routingClassifierTrace; }
            set { this._routingClassifierTrace = value; }
        }

        // Check to see if RoutingClassifierTrace property is set
        internal bool IsSetRoutingClassifierTrace()
        {
            return this._routingClassifierTrace != null;
        }

    }
}