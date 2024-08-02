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
    /// Assessment details of the content analyzed by Guardrails.
    /// </summary>
    public partial class GuardrailAssessment
    {
        private GuardrailContentPolicyAssessment _contentPolicy;
        private GuardrailSensitiveInformationPolicyAssessment _sensitiveInformationPolicy;
        private GuardrailTopicPolicyAssessment _topicPolicy;
        private GuardrailWordPolicyAssessment _wordPolicy;

        /// <summary>
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// Content policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// Sensitive Information policy details of Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Topic policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Word policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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