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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the InvokeEndpointAsync operation. After you deploy
    /// a model into production using Amazon SageMaker AI hosting services, your client applications
    /// use this API to get inferences from the model hosted at the specified endpoint in
    /// an asynchronous manner. <para> Inference requests sent to this API are enqueued for
    /// asynchronous processing. The processing of the inference request may or may not complete
    /// before you receive a response from this API. The response from this API will not contain
    /// the result of the inference request but contain information about where you can locate
    /// it. </para> <para> Amazon SageMaker AI strips all POST headers except those supported
    /// by the API. Amazon SageMaker AI might add additional headers. You should not rely
    /// on the behavior of headers outside those enumerated in the request syntax. </para>
    /// <para> Calls to <c>InvokeEndpointAsync</c> are authenticated by using Amazon Web Services
    /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
    /// </para>
    /// </summary>
    public partial class InvokeEndpointAsyncRequest : AmazonSageMakerRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type of the inference response from the model container.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Provides inline input data for the inference request, in the format specified in the
        /// <c>ContentType</c> request header. Use this parameter to send the request payload
        /// directly in the API call instead of uploading it to Amazon S3 and referencing it with
        /// <c>InputLocation</c>. The inline payload can be up to 128,000 bytes.
        /// </para>
        ///  
        /// <para>
        ///  <c>Body</c> and <c>InputLocation</c> are mutually exclusive. Provide exactly one
        /// of them.
        /// </para>
        ///  
        /// <para>
        /// For information about the format of the request body, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/cdf-inference.html">Common
        /// Data Formats-Inference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 128000)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request body.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// Provides additional information about a request for an inference submitted to a model
        /// hosted at an Amazon SageMaker AI endpoint. The information is an opaque value that
        /// is forwarded verbatim. You could use this value, for example, to provide an ID that
        /// you can use to track a request or to provide other metadata that a service endpoint
        /// was programmed to process. The value must consist of no more than 1024 visible US-ASCII
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
        /// Amazon SageMaker AI Python SDK. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string CustomAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that you specified when you created the endpoint using the
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property Filename. 
        /// <para>
        /// The filename for the inference response payload stored in Amazon S3. If not specified,
        /// Amazon SageMaker AI generates a filename based on the inference ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Filename { get; set; }

        /// <summary>
        /// Checks to see if the Filename property is set.
        /// </summary>
        internal bool IsSetFilename() => this.Filename != null;

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// The identifier for the inference request. Amazon SageMaker AI will generate an identifier
        /// for you if none is specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InferenceId { get; set; }

        /// <summary>
        /// Checks to see if the InferenceId property is set.
        /// </summary>
        internal bool IsSetInferenceId() => this.InferenceId != null;

        /// <summary>
        /// Gets and sets the property InputLocation. 
        /// <para>
        /// The Amazon S3 URI where the inference request payload is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InputLocation { get; set; }

        /// <summary>
        /// Checks to see if the InputLocation property is set.
        /// </summary>
        internal bool IsSetInputLocation() => this.InputLocation != null;

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// Maximum amount of time in seconds a request can be processed before it is marked as
        /// expired. The default is 15 minutes, or 900 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3600)]
        public int? InvocationTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetInvocationTimeoutSeconds() => this.InvocationTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RequestTTLSeconds. 
        /// <para>
        /// Maximum age in seconds a request can be in the queue before it is marked as expired.
        /// The default is 6 hours, or 21,600 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 21600)]
        public int? RequestTTLSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RequestTTLSeconds property is set.
        /// </summary>
        internal bool IsSetRequestTTLSeconds() => this.RequestTTLSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property S3OutputPathExtension. 
        /// <para>
        /// The path extension that is appended to the Amazon S3 output path where the inference
        /// response payload is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string S3OutputPathExtension { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputPathExtension property is set.
        /// </summary>
        internal bool IsSetS3OutputPathExtension() => this.S3OutputPathExtension != null;
    }
}
