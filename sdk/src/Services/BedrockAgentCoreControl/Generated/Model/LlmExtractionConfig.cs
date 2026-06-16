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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Model-based metadata extraction configuration.
    /// </summary>
    public partial class LlmExtractionConfig
    {
        private string _definition;
        private string _llmExtractionInstruction;
        private Validation _validation;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Description of what this metadata field represents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1000)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property LlmExtractionInstruction. 
        /// <para>
        /// Instructions for extraction. Supports built-in operators like LATEST_VALUE or custom
        /// natural-language instructions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string LlmExtractionInstruction
        {
            get { return this._llmExtractionInstruction; }
            set { this._llmExtractionInstruction = value; }
        }

        // Check to see if LlmExtractionInstruction property is set
        internal bool IsSetLlmExtractionInstruction()
        {
            return this._llmExtractionInstruction != null;
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// Validation rules to constrain extracted values.
        /// </para>
        /// </summary>
        public Validation Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }

        // Check to see if Validation property is set
        internal bool IsSetValidation()
        {
            return this._validation != null;
        }

    }
}