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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the InvokeWithResponseStream operation.
    /// </summary>
    public partial class InvokeWithResponseStreamResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property EventStream. 
        /// <para>
        /// The stream of response payloads.
        /// </para>
        /// </summary>
        public InvokeWithResponseStreamResponseEvent EventStream { get; set; }

        /// <summary>
        /// Checks to see if the EventStream property is set.
        /// </summary>
        internal bool IsSetEventStream() => this.EventStream != null;

        /// <summary>
        /// Gets and sets the property ExecutedVersion. 
        /// <para>
        /// The version of the function that executed. When you invoke a function with an alias,
        /// this indicates which version the alias resolved to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExecutedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExecutedVersion property is set.
        /// </summary>
        internal bool IsSetExecutedVersion() => this.ExecutedVersion != null;

        /// <summary>
        /// Gets and sets the property ResponseStreamContentType. 
        /// <para>
        /// The type of data the stream is returning.
        /// </para>
        /// </summary>
        public string ResponseStreamContentType { get; set; }

        /// <summary>
        /// Checks to see if the ResponseStreamContentType property is set.
        /// </summary>
        internal bool IsSetResponseStreamContentType() => this.ResponseStreamContentType != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// For a successful request, the HTTP status code is in the 200 range. For the <c>RequestResponse</c>
        /// invocation type, this status code is 200. For the <c>DryRun</c> invocation type, this
        /// status code is 204.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

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
                this.EventStream?.Dispose();
                this.EventStream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
