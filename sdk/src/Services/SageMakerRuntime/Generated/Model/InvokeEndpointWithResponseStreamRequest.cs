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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeEndpointWithResponseStream operation.
    /// Invokes a model at the specified endpoint to return the inference response as a stream.
    /// The inference stream provides the response payload incrementally as a series of parts.
    /// Before you can get an inference stream, you must have access to a model that's deployed
    /// using Amazon SageMaker hosting services, and the container for that model must support
    /// inference streaming.
    /// 
    ///  
    /// <para>
    /// For more information that can help you use this API, see the following sections in
    /// the <i>Amazon SageMaker Developer Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For information about how to add streaming support to a model, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-code-how-containe-serves-requests">How
    /// Containers Serve Requests</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about how to process the streaming response, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/realtime-endpoints-test-endpoints.html">Invoke
    /// real-time endpoints</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Before you can use this operation, your IAM permissions must allow the <c>sagemaker:InvokeEndpoint</c>
    /// action. For more information about Amazon SageMaker actions for IAM policies, see
    /// <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonsagemaker.html">Actions,
    /// resources, and condition keys for Amazon SageMaker</a> in the <i>IAM Service Authorization
    /// Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
    /// SageMaker might add additional headers. You should not rely on the behavior of headers
    /// outside those enumerated in the request syntax. 
    /// </para>
    ///  
    /// <para>
    /// Calls to <c>InvokeEndpointWithResponseStream</c> are authenticated by using Amazon
    /// Web Services Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
    /// </para>
    /// </summary>
    public partial class InvokeEndpointWithResponseStreamRequest : AmazonSageMakerRuntimeRequest
    {
        private string _accept;
        private MemoryStream _body;
        private string _contentType;
        private string _customAttributes;
        private string _endpointName;
        private string _inferenceComponentName;
        private string _inferenceId;
        private string _sessionId;
        private string _targetContainerHostname;
        private string _targetVariant;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type of the inference response from the model container.
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
        /// Gets and sets the property Body. 
        /// <para>
        /// Provides input data, in the format specified in the <c>ContentType</c> request header.
        /// Amazon SageMaker passes all of the data in the body to the model. 
        /// </para>
        ///  
        /// <para>
        /// For information about the format of the request body, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/cdf-inference.html">Common
        /// Data Formats-Inference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=6291456)]
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
        /// can prepend the custom attribute with <c>Trace ID:</c> in your post-processing function.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This feature is currently supported in the Amazon Web Services SDKs but not in the
        /// Amazon SageMaker Python SDK. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
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
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API.
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
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// If the endpoint hosts one or more inference components, this parameter specifies the
        /// name of inference component to invoke for a streaming response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string InferenceComponentName
        {
            get { return this._inferenceComponentName; }
            set { this._inferenceComponentName = value; }
        }

        // Check to see if InferenceComponentName property is set
        internal bool IsSetInferenceComponentName()
        {
            return this._inferenceComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// An identifier that you assign to your request.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of a stateful session to handle your request.
        /// </para>
        ///  
        /// <para>
        /// You can't create a stateful session by using the <c>InvokeEndpointWithResponseStream</c>
        /// action. Instead, you can create one by using the <c> <a>InvokeEndpoint</a> </c> action.
        /// In your request, you specify <c>NEW_SESSION</c> for the <c>SessionId</c> request parameter.
        /// The response to that request provides the session ID for the <c>NewSessionId</c> response
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetContainerHostname. 
        /// <para>
        /// If the endpoint hosts multiple containers and is configured to use direct invocation,
        /// this parameter specifies the host name of the container to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string TargetContainerHostname
        {
            get { return this._targetContainerHostname; }
            set { this._targetContainerHostname = value; }
        }

        // Check to see if TargetContainerHostname property is set
        internal bool IsSetTargetContainerHostname()
        {
            return this._targetContainerHostname != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVariant. 
        /// <para>
        /// Specify the production variant to send the inference request to when invoking an endpoint
        /// that is running two or more variants. Note that this parameter overrides the default
        /// behavior for the endpoint, which is to distribute the invocation traffic based on
        /// the variant weights.
        /// </para>
        ///  
        /// <para>
        /// For information about how to use variant targeting to perform a/b testing, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-ab-testing.html">Test
        /// models in production</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
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