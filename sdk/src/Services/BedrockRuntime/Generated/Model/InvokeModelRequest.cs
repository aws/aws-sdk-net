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
    /// Container for the parameters to the InvokeModel operation.
    /// Invokes the specified Amazon Bedrock model to run inference using the prompt and inference
    /// parameters provided in the request body. You use model inference to generate text,
    /// images, and embeddings.
    /// 
    ///  
    /// <para>
    /// For example code, see <i>Invoke model code examples</i> in the <i>Amazon Bedrock User
    /// Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
    /// </para>
    /// </summary>
    public partial class InvokeModelRequest : AmazonBedrockRuntimeRequest
    {
        private string _accept;
        private MemoryStream _body;
        private string _contentType;
        private string _guardrailIdentifier;
        private string _guardrailVersion;
        private string _modelId;
        private Trace _trace;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type of the inference body in the response. The default value is
        /// <c>application/json</c>.
        /// </para>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return !string.IsNullOrEmpty(this._accept);
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The prompt and inference parameters in the format specified in the <c>contentType</c>
        /// in the header. You must provide the body in JSON format. To see the format and content
        /// of the request and response bodies for different models, refer to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/api-methods-run.html">Run
        /// inference</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=25000000)]
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request. You must specify <c>application/json</c>.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return !string.IsNullOrEmpty(this._contentType);
        }

        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The unique identifier of the guardrail that you want to use. If you don't provide
        /// a value, no guardrail is applied to the invocation.
        /// </para>
        ///  
        /// <para>
        /// An error will be thrown in the following situations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You don't provide a guardrail identifier but you specify the <c>amazon-bedrock-guardrailConfig</c>
        /// field in the request body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You enable the guardrail but the <c>contentType</c> isn't <c>application/json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You provide a guardrail identifier, but <c>guardrailVersion</c> isn't specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string GuardrailIdentifier
        {
            get { return this._guardrailIdentifier; }
            set { this._guardrailIdentifier = value; }
        }

        // Check to see if GuardrailIdentifier property is set
        internal bool IsSetGuardrailIdentifier()
        {
            return !string.IsNullOrEmpty(this._guardrailIdentifier);
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version number for the guardrail. The value can also be <c>DRAFT</c>.
        /// </para>
        /// </summary>
        public string GuardrailVersion
        {
            get { return this._guardrailVersion; }
            set { this._guardrailVersion = value; }
        }

        // Check to see if GuardrailVersion property is set
        internal bool IsSetGuardrailVersion()
        {
            return !string.IsNullOrEmpty(this._guardrailVersion);
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the model to invoke to run inference.
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
        ///  </li> <li> 
        /// <para>
        /// If you use an <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">imported
        /// model</a>, specify the ARN of the imported model. You can get the model ARN from a
        /// successful call to <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateModelImportJob.html">CreateModelImportJob</a>
        /// or from the Imported models page in the Amazon Bedrock console.
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
        /// Gets and sets the property Trace. 
        /// <para>
        /// Specifies whether to enable or disable the Bedrock trace. If enabled, you can see
        /// the full Bedrock trace.
        /// </para>
        /// </summary>
        public Trace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return !string.IsNullOrEmpty(this._trace);
        }

    }
}