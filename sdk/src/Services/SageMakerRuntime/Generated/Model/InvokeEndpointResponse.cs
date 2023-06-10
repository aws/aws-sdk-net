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
    /// This is the response object from the InvokeEndpoint operation.
    /// </summary>
    public partial class InvokeEndpointResponse : AmazonWebServiceResponse
    {
        private MemoryStream _body;
        private string _contentType;
        private string _customAttributes;
        private string _invokedProductionVariant;

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
        /// The MIME type of the inference returned in the response body.
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
        /// Provides additional information in the response about the inference returned by a
        /// model hosted at an Amazon SageMaker endpoint. The information is an opaque value that
        /// is forwarded verbatim. You could use this value, for example, to return an ID received
        /// in the <code>CustomAttributes</code> header of a request or other metadata that a
        /// service endpoint was programmed to produce. The value must consist of no more than
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
        /// can prepend the custom attribute with <code>Trace ID:</code> in your post-processing
        /// function.
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
        /// Gets and sets the property InvokedProductionVariant. 
        /// <para>
        /// Identifies the production variant that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string InvokedProductionVariant
        {
            get { return this._invokedProductionVariant; }
            set { this._invokedProductionVariant = value; }
        }

        // Check to see if InvokedProductionVariant property is set
        internal bool IsSetInvokedProductionVariant()
        {
            return this._invokedProductionVariant != null;
        }

    }
}