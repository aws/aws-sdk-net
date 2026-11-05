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
    /// The details on the use of the guardrail.
    /// </summary>
    public partial class GuardrailUsage
    {
        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicies. 
        /// <para>
        /// The number of automated reasoning policies that were processed during the guardrail
        /// evaluation.
        /// </para>
        /// </summary>
        public int? AutomatedReasoningPolicies { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedReasoningPolicies property is set.
        /// </summary>
        internal bool IsSetAutomatedReasoningPolicies() => this.AutomatedReasoningPolicies.HasValue;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicyUnits. 
        /// <para>
        /// The number of text units processed by the automated reasoning policy.
        /// </para>
        /// </summary>
        public int? AutomatedReasoningPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedReasoningPolicyUnits property is set.
        /// </summary>
        internal bool IsSetAutomatedReasoningPolicyUnits() => this.AutomatedReasoningPolicyUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ContentPolicyImageUnits. 
        /// <para>
        /// The content policy image units processed by the guardrail.
        /// </para>
        /// </summary>
        public int? ContentPolicyImageUnits { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicyImageUnits property is set.
        /// </summary>
        internal bool IsSetContentPolicyImageUnits() => this.ContentPolicyImageUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ContentPolicyUnits. 
        /// <para>
        /// The content policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ContentPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicyUnits property is set.
        /// </summary>
        internal bool IsSetContentPolicyUnits() => this.ContentPolicyUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyUnits. 
        /// <para>
        /// The contextual grounding policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ContextualGroundingPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the ContextualGroundingPolicyUnits property is set.
        /// </summary>
        internal bool IsSetContextualGroundingPolicyUnits() => this.ContextualGroundingPolicyUnits.HasValue;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyFreeUnits. 
        /// <para>
        /// The sensitive information policy free units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SensitiveInformationPolicyFreeUnits { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicyFreeUnits property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicyFreeUnits() => this.SensitiveInformationPolicyFreeUnits.HasValue;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyUnits. 
        /// <para>
        /// The sensitive information policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SensitiveInformationPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicyUnits property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicyUnits() => this.SensitiveInformationPolicyUnits.HasValue;

        /// <summary>
        /// Gets and sets the property TopicPolicyUnits. 
        /// <para>
        /// The topic policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TopicPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicyUnits property is set.
        /// </summary>
        internal bool IsSetTopicPolicyUnits() => this.TopicPolicyUnits.HasValue;

        /// <summary>
        /// Gets and sets the property WordPolicyUnits. 
        /// <para>
        /// The word policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? WordPolicyUnits { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicyUnits property is set.
        /// </summary>
        internal bool IsSetWordPolicyUnits() => this.WordPolicyUnits.HasValue;
    }
}
