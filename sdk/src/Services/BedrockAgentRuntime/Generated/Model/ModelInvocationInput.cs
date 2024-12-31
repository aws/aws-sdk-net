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
    /// The input for the pre-processing step.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The <c>type</c> matches the agent step.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>text</c> contains the prompt.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>inferenceConfiguration</c>, <c>parserMode</c>, and <c>overrideLambda</c> values
    /// are set in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
    /// object that was set when the agent was created or updated.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ModelInvocationInput
    {
        private string _foundationModel;
        private InferenceConfiguration _inferenceConfiguration;
        private string _overrideLambda;
        private CreationMode _parserMode;
        private CreationMode _promptCreationMode;
        private string _text;
        private string _traceId;
        private PromptType _type;

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        /// The identifier of a foundation model.
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
        /// Specifications about the inference parameters that were provided alongside the prompt.
        /// These are specified in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
        /// object that was set when the agent was created or updated. For more information, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
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
        /// Gets and sets the property OverrideLambda. 
        /// <para>
        /// The ARN of the Lambda function to use when parsing the raw foundation model output
        /// in parts of the agent sequence.
        /// </para>
        /// </summary>
        public string OverrideLambda
        {
            get { return this._overrideLambda; }
            set { this._overrideLambda = value; }
        }

        // Check to see if OverrideLambda property is set
        internal bool IsSetOverrideLambda()
        {
            return this._overrideLambda != null;
        }

        /// <summary>
        /// Gets and sets the property ParserMode. 
        /// <para>
        /// Specifies whether to override the default parser Lambda function when parsing the
        /// raw foundation model output in the part of the agent sequence defined by the <c>promptType</c>.
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
        /// Specifies whether the default prompt template was <c>OVERRIDDEN</c>. If it was, the
        /// <c>basePromptTemplate</c> that was set in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptOverrideConfiguration.html">PromptOverrideConfiguration</a>
        /// object when the agent was created or updated is used instead.
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
        /// Gets and sets the property Text. 
        /// <para>
        /// The text that prompted the agent at this step.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The unique identifier of the trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The step in the agent sequence.
        /// </para>
        /// </summary>
        public PromptType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}