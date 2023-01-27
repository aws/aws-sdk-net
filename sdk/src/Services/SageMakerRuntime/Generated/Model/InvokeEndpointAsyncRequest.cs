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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeEndpointAsync operation.
    /// After you deploy a model into production using Amazon SageMaker hosting services,
    /// your client applications use this API to get inferences from the model hosted at the
    /// specified endpoint in an asynchronous manner.
    /// 
    ///  
    /// <para>
    /// Inference requests sent to this API are enqueued for asynchronous processing. The
    /// processing of the inference request may or may not complete before you receive a response
    /// from this API. The response from this API will not contain the result of the inference
    /// request but contain information about where you can locate it.
    /// </para>
    ///  
    /// <para>
    /// Amazon SageMaker strips all <code>POST</code> headers except those supported by the
    /// API. Amazon SageMaker might add additional headers. You should not rely on the behavior
    /// of headers outside those enumerated in the request syntax.
    /// </para>
    ///  
    /// <para>
    /// Calls to <code>InvokeEndpointAsync</code> are authenticated by using Amazon Web Services
    /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
    /// </para>
    /// </summary>
    public partial class InvokeEndpointAsyncRequest : AmazonSageMakerRuntimeRequest
    {
        private string _accept;
        private string _contentType;
        private string _customAttributes;
        private string _endpointName;
        private string _inferenceId;
        private string _inputLocation;
        private int? _invocationTimeoutSeconds;
        private int? _requestTTLSeconds;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type of the inference in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request body.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// Provides additional information about a request for an inference submitted to a model
        /// hosted at an Amazon SageMaker endpoint. The information is an opaque value that is
        /// forwarded verbatim. You could use this value, for example, to provide an ID that you
        /// can use to track a request or to provide other metadata that a service endpoint was
        /// programmed to process. The value must consist of no more than 1024 visible US-ASCII
        /// characters as specified in <a href="https://datatracker.ietf.org/doc/html/rfc7230#section-3.2.6">Section
        /// 3.3.6. Field Value Components</a> of the Hypertext Transfer Protocol (HTTP/1.1). 
        /// </para>
        ///  
        /// <para>
        /// The code in your model is responsible for setting or updating any custom attributes
        /// in the response. If your code does not set this value in the response, an empty value
        /// is returned. For example, if a custom attribute represents the trace ID, your model
        /// can prepend the custom attribute with <code>Trace ID</code>: in your post-processing
        /// function. 
        /// </para>
        ///  
        /// <para>
        /// This feature is currently supported in the Amazon Web Services SDKs but not in the
        /// Amazon SageMaker Python SDK. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that you specified when you created the endpoint using the
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">
        /// <code>CreateEndpoint</code> </a> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// The identifier for the inference request. Amazon SageMaker will generate an identifier
        /// for you if none is specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string InferenceId
        {
            get { return this._inferenceId; }
            set { this._inferenceId = value; }
        }

        // Check to see if InferenceId property is set
        internal bool IsSetInferenceId()
        {
            return this._inferenceId != null;
        }

        /// <summary>
        /// Gets and sets the property InputLocation. 
        /// <para>
        /// The Amazon S3 URI where the inference request payload is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string InputLocation
        {
            get { return this._inputLocation; }
            set { this._inputLocation = value; }
        }

        // Check to see if InputLocation property is set
        internal bool IsSetInputLocation()
        {
            return this._inputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// Maximum amount of time in seconds a request can be processed before it is marked as
        /// expired.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int InvocationTimeoutSeconds
        {
            get { return this._invocationTimeoutSeconds.GetValueOrDefault(); }
            set { this._invocationTimeoutSeconds = value; }
        }

        // Check to see if InvocationTimeoutSeconds property is set
        internal bool IsSetInvocationTimeoutSeconds()
        {
            return this._invocationTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTTLSeconds. 
        /// <para>
        /// Maximum age in seconds a request can be in the queue before it is marked as expired.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=21600)]
        public int RequestTTLSeconds
        {
            get { return this._requestTTLSeconds.GetValueOrDefault(); }
            set { this._requestTTLSeconds = value; }
        }

        // Check to see if RequestTTLSeconds property is set
        internal bool IsSetRequestTTLSeconds()
        {
            return this._requestTTLSeconds.HasValue; 
        }

    }
}