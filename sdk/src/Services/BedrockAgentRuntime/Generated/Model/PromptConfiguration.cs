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
    /// Contains configurations to override a prompt template in one part of an agent sequence.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
    /// prompts</a>.
    /// </summary>
    public partial class PromptConfiguration
    {
        private Amazon.Runtime.Documents.Document _additionalModelRequestFields;
        private string _basePromptTemplate;
        private string _foundationModel;
        private InferenceConfiguration _inferenceConfiguration;
        private CreationMode _parserMode;
        private CreationMode _promptCreationMode;
        private PromptState _promptState;
        private PromptType _promptType;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// If the Converse or ConverseStream operations support the model, <c>additionalModelRequestFields</c>
        /// contains additional inference parameters, beyond the base set of inference parameters
        /// in the <c>inferenceConfiguration</c> field. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Inference request parameters and response fields for
        /// foundation models</i> in the Amazon Bedrock user guide.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelRequestFields
        {
            get { return this._additionalModelRequestFields; }
            set { this._additionalModelRequestFields = value; }
        }

        // Check to see if AdditionalModelRequestFields property is set
        internal bool IsSetAdditionalModelRequestFields()
        {
            return !this._additionalModelRequestFields.IsNull();
        }

        /// <summary>
        /// Gets and sets the property BasePromptTemplate. 
        /// <para>
        /// Defines the prompt template with which to replace the default prompt template. You
        /// can use placeholder variables in the base prompt template to customize the prompt.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-placeholders.html">Prompt
        /// template placeholder variables</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts-configure.html">Configure
        /// the prompt templates</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100000)]
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
        /// Gets and sets the property FoundationModel. 
        /// <para>
        ///  The foundation model to use. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FoundationModel
        {
            get { return this._foundationModel; }
            set { this._foundationModel = value; }
        }

        // Check to see if FoundationModel property is set
        internal bool IsSetFoundationModel()
        {
            return this._foundationModel != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceConfiguration. 
        /// <para>
        /// Contains inference parameters to use when the agent invokes a foundation model in
        /// the part of the agent sequence defined by the <c>promptType</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters for foundation models</a>.
        /// </para>
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
        /// <para>
        /// Specifies whether to override the default parser Lambda function when parsing the
        /// raw foundation model output in the part of the agent sequence defined by the <c>promptType</c>.
        /// If you set the field as <c>OVERRIDDEN</c>, the <c>overrideLambda</c> field in the
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
        /// must be specified with the ARN of a Lambda function.
        /// </para>
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
        /// <para>
        /// Specifies whether to override the default prompt template for this <c>promptType</c>.
        /// Set this value to <c>OVERRIDDEN</c> to use the prompt that you provide in the <c>basePromptTemplate</c>.
        /// If you leave it as <c>DEFAULT</c>, the agent uses a default prompt template.
        /// </para>
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
        /// <para>
        /// Specifies whether to allow the inline agent to carry out the step specified in the
        /// <c>promptType</c>. If you set this value to <c>DISABLED</c>, the agent skips that
        /// step. The default state for each <c>promptType</c> is as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRE_PROCESSING</c> – <c>ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ORCHESTRATION</c> – <c>ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KNOWLEDGE_BASE_RESPONSE_GENERATION</c> – <c>ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POST_PROCESSING</c> – <c>DISABLED</c> 
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        ///  The step in the agent sequence that this prompt configuration applies to. 
        /// </para>
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