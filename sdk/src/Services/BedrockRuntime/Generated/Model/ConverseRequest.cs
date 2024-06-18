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
    /// Container for the parameters to the Converse operation.
    /// Sends messages to the specified Amazon Bedrock model. <c>Converse</c> provides a consistent
    /// interface that works with all models that support messages. This allows you to write
    /// code once and use it with different models. Should a model have unique inference parameters,
    /// you can also pass those unique parameters to the model.
    /// 
    ///  
    /// <para>
    /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
    /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
    /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
    /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
    /// </para>
    ///  
    /// <para>
    /// For example code, see <i>Converse API examples</i> in the <i>Amazon Bedrock User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <c>bedrock:InvokeModel</c> action. 
    /// </para>
    /// </summary>
    public partial class ConverseRequest : AmazonBedrockRuntimeRequest
    {
        private Amazon.Runtime.Documents.Document _additionalModelRequestFields;
        private List<string> _additionalModelResponseFieldPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GuardrailConfiguration _guardrailConfig;
        private InferenceConfiguration _inferenceConfig;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private string _modelId;
        private List<SystemContentBlock> _system = AWSConfigs.InitializeCollections ? new List<SystemContentBlock>() : null;
        private ToolConfiguration _toolConfig;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// Additional inference parameters that the model supports, beyond the base set of inference
        /// parameters that <c>Converse</c> supports in the <c>inferenceConfig</c> field. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Model
        /// parameters</a>.
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
        /// Gets and sets the property AdditionalModelResponseFieldPaths. 
        /// <para>
        /// Additional model parameters field paths to return in the response. <c>Converse</c>
        /// returns the requested fields as a JSON Pointer object in the <c>additionalModelResponseFields</c>
        /// field. The following is example JSON for <c>additionalModelResponseFieldPaths</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>[ "/stop_sequence" ]</c> 
        /// </para>
        ///  
        /// <para>
        /// For information about the JSON Pointer syntax, see the <a href="https://datatracker.ietf.org/doc/html/rfc6901">Internet
        /// Engineering Task Force (IETF)</a> documentation.
        /// </para>
        ///  
        /// <para>
        ///  <c>Converse</c> rejects an empty JSON Pointer or incorrectly structured JSON Pointer
        /// with a <c>400</c> error code. if the JSON Pointer is valid, but the requested field
        /// is not in the model response, it is ignored by <c>Converse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> AdditionalModelResponseFieldPaths
        {
            get { return this._additionalModelResponseFieldPaths; }
            set { this._additionalModelResponseFieldPaths = value; }
        }

        // Check to see if AdditionalModelResponseFieldPaths property is set
        internal bool IsSetAdditionalModelResponseFieldPaths()
        {
            return this._additionalModelResponseFieldPaths != null && (this._additionalModelResponseFieldPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailConfig. 
        /// <para>
        /// Configuration information for a guardrail that you want to use in the request. 
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfig
        {
            get { return this._guardrailConfig; }
            set { this._guardrailConfig = value; }
        }

        // Check to see if GuardrailConfig property is set
        internal bool IsSetGuardrailConfig()
        {
            return this._guardrailConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Inference parameters to pass to the model. <c>Converse</c> supports a base set of
        /// inference parameters. If you need to pass additional parameters that the model supports,
        /// use the <c>additionalModelRequestFields</c> request field.
        /// </para>
        /// </summary>
        public InferenceConfiguration InferenceConfig
        {
            get { return this._inferenceConfig; }
            set { this._inferenceConfig = value; }
        }

        // Check to see if InferenceConfig property is set
        internal bool IsSetInferenceConfig()
        {
            return this._inferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages that you want to send to the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier for the model that you want to call.
        /// </para>
        ///  
        /// <para>
        /// The <c>modelId</c> to provide depends on the type of model that you use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you use a base model, specify the model ID or its ARN. For a list of model IDs
        /// for base models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#model-ids-arns">Amazon
        /// Bedrock base model IDs (on-demand throughput)</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use a provisioned model, specify the ARN of the Provisioned Throughput. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-thru-use.html">Run
        /// inference using a Provisioned Throughput</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use a custom model, first purchase Provisioned Throughput for it. Then specify
        /// the ARN of the resulting provisioned model. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Use
        /// a custom model in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// A system prompt to pass to the model.
        /// </para>
        /// </summary>
        public List<SystemContentBlock> System
        {
            get { return this._system; }
            set { this._system = value; }
        }

        // Check to see if System property is set
        internal bool IsSetSystem()
        {
            return this._system != null && (this._system.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToolConfig. 
        /// <para>
        /// Configuration information for the tools that the model can use when generating a response.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only supported by Anthropic Claude 3, Cohere Command R, Cohere Command
        /// R+, and Mistral Large models.
        /// </para>
        ///  </note>
        /// </summary>
        public ToolConfiguration ToolConfig
        {
            get { return this._toolConfig; }
            set { this._toolConfig = value; }
        }

        // Check to see if ToolConfig property is set
        internal bool IsSetToolConfig()
        {
            return this._toolConfig != null;
        }

    }
}