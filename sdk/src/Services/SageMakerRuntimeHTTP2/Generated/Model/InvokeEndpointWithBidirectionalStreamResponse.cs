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
    /// This is the response object from the InvokeEndpointWithBidirectionalStream operation.
    /// </summary>
    public partial class InvokeEndpointWithBidirectionalStreamResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        private ResponseStreamEvent _body;
        private string _invokedProductionVariant;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The response payload stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseStreamEvent Body
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
        /// Gets and sets the property InvokedProductionVariant. 
        /// <para>
        /// The invoked production variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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

#pragma warning disable CA1033

        Amazon.Runtime.EventStreams.EventInputStreamContext _eventInputStreamContext;
        void Amazon.Runtime.EventStreams.IEventInputStreamContextOwner.SetEventInputStreamContext(Amazon.Runtime.EventStreams.EventInputStreamContext eventInputStreamContext)
        {
            this._eventInputStreamContext = eventInputStreamContext;
        }
#pragma warning restore CA1033
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
                return;

            if (disposing)
            {
                this._eventInputStreamContext?.Dispose();
                this._eventInputStreamContext = null;
                this._body?.Dispose();
                this._body = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}