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
    /// Container for the parameters to the ConverseStream operation.
    /// Sends messages to the specified Amazon Bedrock model and returns the response in a
    /// stream. <c>ConverseStream</c> provides a consistent API that works with all Amazon
    /// Bedrock models that support messages. This allows you to write code once and use it
    /// with different models. Should a model have unique inference parameters, you can also
    /// pass those unique parameters to the model. 
    /// 
    ///  
    /// <para>
    /// To find out if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
    /// and check the <c>responseStreamingSupported</c> field in the response.
    /// </para>
    ///  <note> 
    /// <para>
    /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>ConverseStream</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Bedrock doesn't store any text, images, or documents that you provide as content.
    /// The data is only used to generate the response.
    /// </para>
    ///  
    /// <para>
    /// You can submit a prompt by including it in the <c>messages</c> field, specifying the
    /// <c>modelId</c> of a foundation model or inference profile to run inference on it,
    /// and including any other fields that are relevant to your use case.
    /// </para>
    ///  
    /// <para>
    /// You can also submit a prompt from Prompt management by specifying the ARN of the prompt
    /// version and including a map of variables to values in the <c>promptVariables</c> field.
    /// You can append more messages to the prompt by using the <c>messages</c> field. If
    /// you use a prompt from Prompt management, you can't include the following fields in
    /// the request: <c>additionalModelRequestFields</c>, <c>inferenceConfig</c>, <c>system</c>,
    /// or <c>toolConfig</c>. Instead, these fields must be defined through Prompt management.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-use.html">Use
    /// a prompt from Prompt management</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
    /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
    /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
    /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
    /// </para>
    ///  
    /// <para>
    /// For example code, see <i>Conversation streaming example</i> in the <i>Amazon Bedrock
    /// User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <c>bedrock:InvokeModelWithResponseStream</c>
    /// action.
    /// </para>
    ///  <important> 
    /// <para>
    /// To deny all inference access to resources that you specify in the modelId field, you
    /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
    /// actions. Doing this also denies access to the resource through the base inference
    /// actions (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModel.html">InvokeModel</a>
    /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_InvokeModelWithResponseStream.html">InvokeModelWithResponseStream</a>).
    /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
    /// access for inference on specific models</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// For troubleshooting some of the common errors you might encounter when using the <c>ConverseStream</c>
    /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
    /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
    /// </para>
    /// </summary>
    public partial class ConverseStreamRequest : AmazonBedrockRuntimeRequest
    {
        private Amazon.Runtime.Documents.Document _additionalModelRequestFields;
        private List<string> _additionalModelResponseFieldPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GuardrailStreamConfiguration _guardrailConfig;
        private InferenceConfiguration _inferenceConfig;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private string _modelId;
        private PerformanceConfiguration _performanceConfig;
        private Dictionary<string, PromptVariableValues> _promptVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, PromptVariableValues>() : null;
        private Dictionary<string, string> _requestMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<SystemContentBlock> _system = AWSConfigs.InitializeCollections ? new List<SystemContentBlock>() : null;
        private ToolConfiguration _toolConfig;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// Additional inference parameters that the model supports, beyond the base set of inference
        /// parameters that <c>Converse</c> and <c>ConverseStream</c> support in the <c>inferenceConfig</c>
        /// field. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Model
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
        /// and <c>ConverseStream</c> return the requested fields as a JSON Pointer object in
        /// the <c>additionalModelResponseFields</c> field. The following is example JSON for
        /// <c>additionalModelResponseFieldPaths</c>.
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
        ///  <c>Converse</c> and <c>ConverseStream</c> reject an empty JSON Pointer or incorrectly
        /// structured JSON Pointer with a <c>400</c> error code. if the JSON Pointer is valid,
        /// but the requested field is not in the model response, it is ignored by <c>Converse</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Configuration information for a guardrail that you want to use in the request. If
        /// you include <c>guardContent</c> blocks in the <c>content</c> field in the <c>messages</c>
        /// field, the guardrail operates only on those messages. If you include no <c>guardContent</c>
        /// blocks, the guardrail operates on all messages in the request body and in any included
        /// prompt resource.
        /// </para>
        /// </summary>
        public GuardrailStreamConfiguration GuardrailConfig
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
        /// Inference parameters to pass to the model. <c>Converse</c> and <c>ConverseStream</c>
        /// support a base set of inference parameters. If you need to pass additional parameters
        /// that the model supports, use the <c>additionalModelRequestFields</c> request field.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Specifies the model or throughput with which to run inference, or the prompt resource
        /// to use in inference. The value depends on the resource that you use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you use a base model, specify the model ID or its ARN. For a list of model IDs
        /// for base models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#model-ids-arns">Amazon
        /// Bedrock base model IDs (on-demand throughput)</a> in the Amazon Bedrock User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use an inference profile, specify the inference profile ID or its ARN. For
        /// a list of inference profile IDs, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference-support.html">Supported
        /// Regions and models for cross-region inference</a> in the Amazon Bedrock User Guide.
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
        ///  </li> <li> 
        /// <para>
        /// To include a prompt that was defined in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management.html">Prompt
        /// management</a>, specify the ARN of the prompt version to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Converse API doesn't support <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">imported
        /// models</a>.
        /// </para>
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
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// Model performance settings for the request.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig
        {
            get { return this._performanceConfig; }
            set { this._performanceConfig = value; }
        }

        // Check to see if PerformanceConfig property is set
        internal bool IsSetPerformanceConfig()
        {
            return this._performanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PromptVariables. 
        /// <para>
        /// Contains a map of variables in a prompt from Prompt management to objects containing
        /// the values to fill in for them when running model invocation. This field is ignored
        /// if you don't specify a prompt resource in the <c>modelId</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, PromptVariableValues> PromptVariables
        {
            get { return this._promptVariables; }
            set { this._promptVariables = value; }
        }

        // Check to see if PromptVariables property is set
        internal bool IsSetPromptVariables()
        {
            return this._promptVariables != null && (this._promptVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestMetadata. 
        /// <para>
        /// Key-value pairs that you can use to filter invocation logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=16)]
        public Dictionary<string, string> RequestMetadata
        {
            get { return this._requestMetadata; }
            set { this._requestMetadata = value; }
        }

        // Check to see if RequestMetadata property is set
        internal bool IsSetRequestMetadata()
        {
            return this._requestMetadata != null && (this._requestMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// A prompt that provides instructions or context to the model about the task it should
        /// perform, or the persona it should adopt during the conversation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// </para>
        ///  
        /// <para>
        /// For information about models that support streaming tool use, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/conversation-inference.html#conversation-inference-supported-models-features">Supported
        /// models and model features</a>.
        /// </para>
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