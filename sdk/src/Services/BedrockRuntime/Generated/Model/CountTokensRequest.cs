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
    /// Container for the parameters to the CountTokens operation.
    /// Returns the token count for a given inference request. This operation helps you estimate
    /// token usage before sending requests to foundation models by returning the token count
    /// that would be used if the same input were sent to the model in an inference request.
    /// 
    ///  
    /// <para>
    /// Token counting is model-specific because different models use different tokenization
    /// strategies. The token count returned by this operation will match the token count
    /// that would be charged if the same input were sent to the model in an <c>InvokeModel</c>
    /// or <c>Converse</c> request.
    /// </para>
    ///  
    /// <para>
    /// You can use this operation to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Estimate costs before sending inference requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optimize prompts to fit within token limits.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Plan for token usage in your applications.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation accepts the same input formats as <c>InvokeModel</c> and <c>Converse</c>,
    /// allowing you to count tokens for both raw text inputs and structured conversation
    /// formats.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>CountTokens</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/API/API_runtime_InvokeModel.html">InvokeModel</a>
    /// - Sends inference requests to foundation models
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/API/API_runtime_Converse.html">Converse</a>
    /// - Sends conversation-based inference requests to foundation models
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CountTokensRequest : AmazonBedrockRuntimeRequest
    {
        private CountTokensInput _input;
        private string _modelId;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input for which to count tokens. The structure of this parameter depends on whether
        /// you're counting tokens for an <c>InvokeModel</c> or <c>Converse</c> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>InvokeModel</c> requests, provide the request body in the <c>invokeModel</c>
        /// field
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>Converse</c> requests, provide the messages and system content in the <c>converse</c>
        /// field
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The input format must be compatible with the model specified in the <c>modelId</c>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CountTokensInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier or ARN of the foundation model to use for token counting. Each
        /// model processes tokens differently, so the token count is specific to the model you
        /// specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}