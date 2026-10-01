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
    /// This is the response object from the InvokeEndpointWithResponseStream operation.
    /// </summary>
    public partial class InvokeEndpointWithResponseStreamResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property Body.
        /// </summary>
        [AWSProperty(Required = true)]
        public ResponseStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

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

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                this.Body?.Dispose();
                this.Body = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
