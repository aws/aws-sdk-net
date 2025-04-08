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
    /// Container for the parameters to the InvokeModelWithBidirectionalStream operation.
    /// Invoke the specified Amazon Bedrock model to run inference using the bidirectional
    /// stream. The response is returned in a stream that remains open for 8 minutes. A single
    /// session can contain multiple prompts and responses from the model. The prompts to
    /// the model are provided as audio files and the model's responses are spoken back to
    /// the user and transcribed.
    /// 
    ///  
    /// <para>
    /// It is possible for users to interrupt the model's response with a new prompt, which
    /// will halt the response speech. The model will retain contextual awareness of the conversation
    /// while pivoting to respond to the new prompt.
    /// </para>
    /// </summary>
    public partial class InvokeModelWithBidirectionalStreamRequest : AmazonBedrockRuntimeRequest
    {
        private string _modelId;

        /// <summary>
        /// Gets and sets the property BodyPublisher. 
        /// <para>
        /// The prompt and inference parameters in the format specified in the <c>BidirectionalInputPayloadPart</c>
        /// in the header. You must provide the body in JSON format. To see the format and content
        /// of the request and response bodies for different models, refer to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/api-methods-run.html">Run
        /// inference</a> in the Bedrock User Guide.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IInvokeModelWithBidirectionalStreamInputEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="BidirectionalInputPayloadPart"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        [AWSProperty(Required=true)]
        public  Func<System.Threading.Tasks.Task<IInvokeModelWithBidirectionalStreamInputEvent>> BodyPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID or ARN of the model ID to use. Currently, only <c>amazon.nova-sonic-v1:0</c>
        /// is supported.
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

    }
}