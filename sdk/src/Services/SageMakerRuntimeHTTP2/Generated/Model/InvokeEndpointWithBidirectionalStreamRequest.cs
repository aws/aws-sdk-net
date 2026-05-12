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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
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
namespace Amazon.SageMakerRuntimeHTTP2.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeEndpointWithBidirectionalStream operation.
    /// Invokes a model endpoint with bidirectional streaming capabilities. This operation
    /// establishes a persistent connection that allows you to send multiple requests and
    /// receive streaming responses from the model in real-time.
    /// 
    ///  
    /// <para>
    /// Bidirectional streaming is useful for interactive applications such as chatbots, real-time
    /// translation, or any scenario where you need to maintain a conversation-like interaction
    /// with the model. The connection remains open, allowing you to send additional input
    /// and receive responses without establishing a new connection for each request.
    /// </para>
    ///  
    /// <para>
    /// For an overview of Amazon SageMaker AI, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon SageMaker AI strips all POST headers except those supported by the API. Amazon
    /// SageMaker AI might add additional headers. You should not rely on the behavior of
    /// headers outside those enumerated in the request syntax. 
    /// </para>
    ///  
    /// <para>
    /// Calls to <c>InvokeEndpointWithBidirectionalStream</c> are authenticated by using Amazon
    /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// The bidirectional stream maintains the connection until either the client closes it
    /// or the model indicates completion. Each request and response in the stream is sent
    /// as an event with optional headers for data type and completion state.
    /// </para>
    ///  <note> 
    /// <para>
    /// Endpoints are scoped to an individual account, and are not public. The URL does not
    /// contain the account ID, but Amazon SageMaker AI determines the account ID from the
    /// authentication token that is supplied by the caller.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InvokeEndpointWithBidirectionalStreamRequest : AmazonSageMakerRuntimeHTTP2Request
    {
        private string _endpointName;
        private string _modelInvocationPath;
        private string _modelQueryString;
        private string _targetVariant;

        /// <summary>
        /// Gets and sets the property BodyPublisher. 
        /// <para>
        /// The request payload stream.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IRequestStreamEventEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="RequestPayloadPart"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        [AWSProperty(Required=true)]
        public  Func<System.Threading.Tasks.Task<IRequestStreamEventEvent>> BodyPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInvocationPath. 
        /// <para>
        /// Model invocation path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string ModelInvocationPath
        {
            get { return this._modelInvocationPath; }
            set { this._modelInvocationPath = value; }
        }

        // Check to see if ModelInvocationPath property is set
        internal bool IsSetModelInvocationPath()
        {
            return this._modelInvocationPath != null;
        }

        /// <summary>
        /// Gets and sets the property ModelQueryString. 
        /// <para>
        /// Model query string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ModelQueryString
        {
            get { return this._modelQueryString; }
            set { this._modelQueryString = value; }
        }

        // Check to see if ModelQueryString property is set
        internal bool IsSetModelQueryString()
        {
            return this._modelQueryString != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVariant. 
        /// <para>
        /// Target variant for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string TargetVariant
        {
            get { return this._targetVariant; }
            set { this._targetVariant = value; }
        }

        // Check to see if TargetVariant property is set
        internal bool IsSetTargetVariant()
        {
            return this._targetVariant != null;
        }

    }
}