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
    /// A behavior assessment of the guardrail policies used in a call to the Converse API.
    /// </summary>
    public partial class GuardrailAssessment
    {
        /// <summary>
        /// Gets and sets the property AppliedGuardrailDetails.
        /// </summary>
        public AppliedGuardrailDetails AppliedGuardrailDetails { get; set; }

        /// <summary>
        /// Checks to see if the AppliedGuardrailDetails property is set.
        /// </summary>
        internal bool IsSetAppliedGuardrailDetails() => this.AppliedGuardrailDetails != null;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicy. 
        /// <para>
        /// The automated reasoning policy assessment results, including logical validation findings
        /// for the input content.
        /// </para>
        /// </summary>
        public GuardrailAutomatedReasoningPolicyAssessment AutomatedReasoningPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedReasoningPolicy property is set.
        /// </summary>
        internal bool IsSetAutomatedReasoningPolicy() => this.AutomatedReasoningPolicy != null;

        /// <summary>
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// The content policy.
        /// </para>
        /// </summary>
        public GuardrailContentPolicyAssessment ContentPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicy property is set.
        /// </summary>
        internal bool IsSetContentPolicy() => this.ContentPolicy != null;

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicy. 
        /// <para>
        /// The contextual grounding policy used for the guardrail assessment.
        /// </para>
        /// </summary>
        public GuardrailContextualGroundingPolicyAssessment ContextualGroundingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContextualGroundingPolicy property is set.
        /// </summary>
        internal bool IsSetContextualGroundingPolicy() => this.ContextualGroundingPolicy != null;

        /// <summary>
        /// Gets and sets the property InvocationMetrics. 
        /// <para>
        /// The invocation metrics for the guardrail assessment.
        /// </para>
        /// </summary>
        public GuardrailInvocationMetrics InvocationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the InvocationMetrics property is set.
        /// </summary>
        internal bool IsSetInvocationMetrics() => this.InvocationMetrics != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// The sensitive information policy.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicyAssessment SensitiveInformationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicy property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicy() => this.SensitiveInformationPolicy != null;

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// The topic policy.
        /// </para>
        /// </summary>
        public GuardrailTopicPolicyAssessment TopicPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicy property is set.
        /// </summary>
        internal bool IsSetTopicPolicy() => this.TopicPolicy != null;

        /// <summary>
        /// Gets and sets the property WordPolicy. 
        /// <para>
        /// The word policy.
        /// </para>
        /// </summary>
        public GuardrailWordPolicyAssessment WordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicy property is set.
        /// </summary>
        internal bool IsSetWordPolicy() => this.WordPolicy != null;
    }
}
