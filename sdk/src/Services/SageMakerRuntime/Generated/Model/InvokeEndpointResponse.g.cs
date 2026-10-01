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
    /// This is the response object from the InvokeEndpoint operation.
    /// </summary>
    public partial class InvokeEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Includes the inference provided by the model. 
        /// </para>
        ///  
        /// <para>
        /// For information about the format of the response body, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/cdf-inference.html">Common
        /// Data Formats-Inference</a>.
        /// </para>
        ///  
        /// <para>
        /// If the explainer is activated, the body includes the explanations provided by the
        /// model. For more information, see the <b>Response section</b> under <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">Invoke
        /// the Endpoint</a> in the Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 6291456)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ClosedSessionId. 
        /// <para>
        /// If you closed a stateful session with your request, the ID of that session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClosedSessionId { get; set; }

        /// <summary>
        /// Checks to see if the ClosedSessionId property is set.
        /// </summary>
        internal bool IsSetClosedSessionId() => this.ClosedSessionId != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the inference returned from the model container.
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
        /// Provides additional information in the response about the inference returned by a
        /// model hosted at an Amazon SageMaker AI endpoint. The information is an opaque value
        /// that is forwarded verbatim. You could use this value, for example, to return an ID
        /// received in the <c>CustomAttributes</c> header of a request or other metadata that
        /// a service endpoint was programmed to produce. The value must consist of no more than
        /// 1024 visible US-ASCII characters as specified in <a href="https://tools.ietf.org/html/rfc7230#section-3.2.6">Section
        /// 3.3.6. Field Value Components</a> of the Hypertext Transfer Protocol (HTTP/1.1). If
        /// the customer wants the custom attribute returned, the model must set the custom attribute
        /// to be included on the way back. 
        /// </para>
        ///  
        /// <para>
        /// The code in your model is responsible for setting or updating any custom attributes
        /// in the response. If your code does not set this value in the response, an empty value
        /// is returned. For example, if a custom attribute represents the trace ID, your model
        /// can prepend the custom attribute with <c>Trace ID:</c> in your post-processing function.
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
        /// Gets and sets the property InvokedProductionVariant. 
        /// <para>
        /// Identifies the production variant that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InvokedProductionVariant { get; set; }

        /// <summary>
        /// Checks to see if the InvokedProductionVariant property is set.
        /// </summary>
        internal bool IsSetInvokedProductionVariant() => this.InvokedProductionVariant != null;

        /// <summary>
        /// Gets and sets the property NewSessionId. 
        /// <para>
        /// If you created a stateful session with your request, the ID and expiration time that
        /// the model assigns to that session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NewSessionId { get; set; }

        /// <summary>
        /// Checks to see if the NewSessionId property is set.
        /// </summary>
        internal bool IsSetNewSessionId() => this.NewSessionId != null;
    }
}
