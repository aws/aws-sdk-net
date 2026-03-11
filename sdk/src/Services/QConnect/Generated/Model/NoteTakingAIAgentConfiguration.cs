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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private string _locale;
        private string _noteTakingAIGuardrailId;
        private string _noteTakingAIPromptId;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale setting for language-specific case summarization generation (for example,
        /// en_US, es_ES).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property NoteTakingAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier used by the Note Taking AI Agent.
        /// </para>
        /// </summary>
        public string NoteTakingAIGuardrailId
        {
            get { return this._noteTakingAIGuardrailId; }
            set { this._noteTakingAIGuardrailId = value; }
        }

        // Check to see if NoteTakingAIGuardrailId property is set
        internal bool IsSetNoteTakingAIGuardrailId()
        {
            return this._noteTakingAIGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property NoteTakingAIPromptId. 
        /// <para>
        /// The AI Prompt identifier used by the Note Taking AI Agent.
        /// </para>
        /// </summary>
        public string NoteTakingAIPromptId
        {
            get { return this._noteTakingAIPromptId; }
            set { this._noteTakingAIPromptId = value; }
        }

        // Check to see if NoteTakingAIPromptId property is set
        internal bool IsSetNoteTakingAIPromptId()
        {
            return this._noteTakingAIPromptId != null;
        }

    }
}