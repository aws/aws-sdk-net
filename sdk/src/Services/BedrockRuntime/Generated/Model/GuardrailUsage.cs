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
    /// The details on the use of the guardrail.
    /// </summary>
    public partial class GuardrailUsage
    {
        private int? _automatedReasoningPolicies;
        private int? _automatedReasoningPolicyUnits;
        private int? _contentPolicyImageUnits;
        private int? _contentPolicyUnits;
        private int? _contextualGroundingPolicyUnits;
        private int? _sensitiveInformationPolicyFreeUnits;
        private int? _sensitiveInformationPolicyUnits;
        private int? _topicPolicyUnits;
        private int? _wordPolicyUnits;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicies. 
        /// <para>
        /// The number of automated reasoning policies that were processed during the guardrail
        /// evaluation.
        /// </para>
        /// </summary>
        public int? AutomatedReasoningPolicies
        {
            get { return this._automatedReasoningPolicies; }
            set { this._automatedReasoningPolicies = value; }
        }

        // Check to see if AutomatedReasoningPolicies property is set
        internal bool IsSetAutomatedReasoningPolicies()
        {
            return this._automatedReasoningPolicies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicyUnits. 
        /// <para>
        /// The number of text units processed by the automated reasoning policy.
        /// </para>
        /// </summary>
        public int? AutomatedReasoningPolicyUnits
        {
            get { return this._automatedReasoningPolicyUnits; }
            set { this._automatedReasoningPolicyUnits = value; }
        }

        // Check to see if AutomatedReasoningPolicyUnits property is set
        internal bool IsSetAutomatedReasoningPolicyUnits()
        {
            return this._automatedReasoningPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentPolicyImageUnits. 
        /// <para>
        /// The content policy image units processed by the guardrail.
        /// </para>
        /// </summary>
        public int? ContentPolicyImageUnits
        {
            get { return this._contentPolicyImageUnits; }
            set { this._contentPolicyImageUnits = value; }
        }

        // Check to see if ContentPolicyImageUnits property is set
        internal bool IsSetContentPolicyImageUnits()
        {
            return this._contentPolicyImageUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentPolicyUnits. 
        /// <para>
        /// The content policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ContentPolicyUnits
        {
            get { return this._contentPolicyUnits; }
            set { this._contentPolicyUnits = value; }
        }

        // Check to see if ContentPolicyUnits property is set
        internal bool IsSetContentPolicyUnits()
        {
            return this._contentPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContextualGroundingPolicyUnits. 
        /// <para>
        /// The contextual grounding policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ContextualGroundingPolicyUnits
        {
            get { return this._contextualGroundingPolicyUnits; }
            set { this._contextualGroundingPolicyUnits = value; }
        }

        // Check to see if ContextualGroundingPolicyUnits property is set
        internal bool IsSetContextualGroundingPolicyUnits()
        {
            return this._contextualGroundingPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyFreeUnits. 
        /// <para>
        /// The sensitive information policy free units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SensitiveInformationPolicyFreeUnits
        {
            get { return this._sensitiveInformationPolicyFreeUnits; }
            set { this._sensitiveInformationPolicyFreeUnits = value; }
        }

        // Check to see if SensitiveInformationPolicyFreeUnits property is set
        internal bool IsSetSensitiveInformationPolicyFreeUnits()
        {
            return this._sensitiveInformationPolicyFreeUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicyUnits. 
        /// <para>
        /// The sensitive information policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SensitiveInformationPolicyUnits
        {
            get { return this._sensitiveInformationPolicyUnits; }
            set { this._sensitiveInformationPolicyUnits = value; }
        }

        // Check to see if SensitiveInformationPolicyUnits property is set
        internal bool IsSetSensitiveInformationPolicyUnits()
        {
            return this._sensitiveInformationPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicPolicyUnits. 
        /// <para>
        /// The topic policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TopicPolicyUnits
        {
            get { return this._topicPolicyUnits; }
            set { this._topicPolicyUnits = value; }
        }

        // Check to see if TopicPolicyUnits property is set
        internal bool IsSetTopicPolicyUnits()
        {
            return this._topicPolicyUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WordPolicyUnits. 
        /// <para>
        /// The word policy units processed by the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? WordPolicyUnits
        {
            get { return this._wordPolicyUnits; }
            set { this._wordPolicyUnits = value; }
        }

        // Check to see if WordPolicyUnits property is set
        internal bool IsSetWordPolicyUnits()
        {
            return this._wordPolicyUnits.HasValue; 
        }

    }
}