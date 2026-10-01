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
    /// Assessment details of the content analyzed by Guardrails.
    /// </summary>
    public partial class GuardrailAssessment
    {
        /// <summary>
        /// Gets and sets the property ContentPolicy. 
        /// <para>
        /// Content policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailContentPolicyAssessment ContentPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentPolicy property is set.
        /// </summary>
        internal bool IsSetContentPolicy() => this.ContentPolicy != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformationPolicy. 
        /// <para>
        /// Sensitive Information policy details of Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailSensitiveInformationPolicyAssessment SensitiveInformationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformationPolicy property is set.
        /// </summary>
        internal bool IsSetSensitiveInformationPolicy() => this.SensitiveInformationPolicy != null;

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// Topic policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailTopicPolicyAssessment TopicPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TopicPolicy property is set.
        /// </summary>
        internal bool IsSetTopicPolicy() => this.TopicPolicy != null;

        /// <summary>
        /// Gets and sets the property WordPolicy. 
        /// <para>
        /// Word policy details of the Guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailWordPolicyAssessment WordPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WordPolicy property is set.
        /// </summary>
        internal bool IsSetWordPolicy() => this.WordPolicy != null;
    }
}
