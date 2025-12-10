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
    /// The configuration for inference parameters when using AI Prompts.
    /// </summary>
    public partial class AIPromptInferenceConfiguration
    {
        private TextAIPromptInferenceConfiguration _textaiPromptInferenceConfiguration;

        /// <summary>
        /// Gets and sets the property TextAIPromptInferenceConfiguration. 
        /// <para>
        /// The inference configuration for text-based AI Prompts.
        /// </para>
        /// </summary>
        public TextAIPromptInferenceConfiguration TextAIPromptInferenceConfiguration
        {
            get { return this._textaiPromptInferenceConfiguration; }
            set { this._textaiPromptInferenceConfiguration = value; }
        }

        // Check to see if TextAIPromptInferenceConfiguration property is set
        internal bool IsSetTextAIPromptInferenceConfiguration()
        {
            return this._textaiPromptInferenceConfiguration != null;
        }

    }
}