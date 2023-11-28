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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// BasePromptConfiguration per Prompt Type.
    /// </summary>
    public partial class PromptConfiguration
    {
        private string _basePromptTemplate;
        private InferenceConfiguration _inferenceConfiguration;
        private CreationMode _parserMode;
        private CreationMode _promptCreationMode;
        private PromptState _promptState;
        private PromptType _promptType;

        /// <summary>
        /// Gets and sets the property BasePromptTemplate.
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string BasePromptTemplate
        {
            get { return this._basePromptTemplate; }
            set { this._basePromptTemplate = value; }
        }

        // Check to see if BasePromptTemplate property is set
        internal bool IsSetBasePromptTemplate()
        {
            return this._basePromptTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceConfiguration.
        /// </summary>
        public InferenceConfiguration InferenceConfiguration
        {
            get { return this._inferenceConfiguration; }
            set { this._inferenceConfiguration = value; }
        }

        // Check to see if InferenceConfiguration property is set
        internal bool IsSetInferenceConfiguration()
        {
            return this._inferenceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParserMode.
        /// </summary>
        public CreationMode ParserMode
        {
            get { return this._parserMode; }
            set { this._parserMode = value; }
        }

        // Check to see if ParserMode property is set
        internal bool IsSetParserMode()
        {
            return this._parserMode != null;
        }

        /// <summary>
        /// Gets and sets the property PromptCreationMode.
        /// </summary>
        public CreationMode PromptCreationMode
        {
            get { return this._promptCreationMode; }
            set { this._promptCreationMode = value; }
        }

        // Check to see if PromptCreationMode property is set
        internal bool IsSetPromptCreationMode()
        {
            return this._promptCreationMode != null;
        }

        /// <summary>
        /// Gets and sets the property PromptState.
        /// </summary>
        public PromptState PromptState
        {
            get { return this._promptState; }
            set { this._promptState = value; }
        }

        // Check to see if PromptState property is set
        internal bool IsSetPromptState()
        {
            return this._promptState != null;
        }

        /// <summary>
        /// Gets and sets the property PromptType.
        /// </summary>
        public PromptType PromptType
        {
            get { return this._promptType; }
            set { this._promptType = value; }
        }

        // Check to see if PromptType property is set
        internal bool IsSetPromptType()
        {
            return this._promptType != null;
        }

    }
}