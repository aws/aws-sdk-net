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
    /// A behavior assessment of the guardrail policies used in a call to the Converse API.
    /// </summary>
    public partial class GuardrailAssessment
    {
        private GuardrailAutomatedReasoningPolicyAssessment _automatedReasoningPolicy;
        private GuardrailContentPolicyAssessment _contentPolicy;
        private GuardrailContextualGroundingPolicyAssessment _contextualGroundingPolicy;
        private GuardrailInvocationMetrics _invocationMetrics;
        private GuardrailSensitiveInformationPolicyAssessment _sensitiveInformationPolicy;
        private GuardrailTopicPolicyAssessment _topicPolicy;
        private GuardrailWordPolicyAssessment _wordPolicy;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicy. 
        /// <para>
        /// The automated reasoning policy assessment results, including logical validation findings
        /// for the input content.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicyAssessment AutomatedReasoningPolicy
        {
            get { return this._automatedReasoningPolicy; }
            set { this._automatedReasoningPolicy = value; }
        }

        // Check to see if AutomatedReasoningPolicy property is set
        internal bool IsSetAutomatedReasoningPolicy()
        {
            return this._automatedReasoningPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// The content policy.
        /// </para>
        /// </summary>
        public GuardrailContentPolicyAssessment ContentPolicy
        {
            get { return this._contentPolicy; }
            set { this._contentPolicy = value; }
        }

        // Check to see if ContentPolicy property is set
        internal bool IsSetContentPolicy()
        {
            return this._contentPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicy. 
        /// <para>
        /// The contextual grounding policy used for the guardrail assessment.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicyAssessment ContextualGroundingPolicy
        {
            get { return this._contextualGroundingPolicy; }
            set { this._contextualGroundingPolicy = value; }
        }

        // Check to see if ContextualGroundingPolicy property is set
        internal bool IsSetContextualGroundingPolicy()
        {
            return this._contextualGroundingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationMetrics. 
        /// <para>
        /// The invocation metrics for the guardrail assessment.
        /// </para>
        /// </summary>
        public GuardrailInvocationMetrics InvocationMetrics
        {
            get { return this._invocationMetrics; }
            set { this._invocationMetrics = value; }
        }

        // Check to see if InvocationMetrics property is set
        internal bool IsSetInvocationMetrics()
        {
            return this._invocationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// The sensitive information policy.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicyAssessment SensitiveInformationPolicy
        {
            get { return this._sensitiveInformationPolicy; }
            set { this._sensitiveInformationPolicy = value; }
        }

        // Check to see if SensitiveInformationPolicy property is set
        internal bool IsSetSensitiveInformationPolicy()
        {
            return this._sensitiveInformationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// The topic policy.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicyAssessment TopicPolicy
        {
            get { return this._topicPolicy; }
            set { this._topicPolicy = value; }
        }

        // Check to see if TopicPolicy property is set
        internal bool IsSetTopicPolicy()
        {
            return this._topicPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property WordPolicy. 
        /// <para>
        /// The word policy.
        /// </para>
        /// </summary>
        public GuardrailWordPolicyAssessment WordPolicy
        {
            get { return this._wordPolicy; }
            set { this._wordPolicy = value; }
        }

        // Check to see if WordPolicy property is set
        internal bool IsSetWordPolicy()
        {
            return this._wordPolicy != null;
        }

    }
}