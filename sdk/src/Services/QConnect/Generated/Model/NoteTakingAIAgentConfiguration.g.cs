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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for AI Agents of type <c>NOTE_TAKING</c>.
    /// </summary>
    public partial class NoteTakingAIAgentConfiguration
    {
        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for language-specific case summarization generation (for example,
        /// en_US, es_ES).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property NoteTakingAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier used by the Note Taking AI Agent.
        /// </para>
        /// </summary>
        public string NoteTakingAIGuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the NoteTakingAIGuardrailId property is set.
        /// </summary>
        internal bool IsSetNoteTakingAIGuardrailId() => this.NoteTakingAIGuardrailId != null;

        /// <summary>
        /// Gets and sets the property NoteTakingAIPromptId. 
        /// <para>
        /// The AI Prompt identifier used by the Note Taking AI Agent.
        /// </para>
        /// </summary>
        public string NoteTakingAIPromptId { get; set; }

        /// <summary>
        /// Checks to see if the NoteTakingAIPromptId property is set.
        /// </summary>
        internal bool IsSetNoteTakingAIPromptId() => this.NoteTakingAIPromptId != null;
    }
}
