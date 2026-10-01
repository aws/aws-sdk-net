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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the OutputStreamWithInitialResponse operation.
    /// </summary>
    public partial class OutputStreamWithInitialResponseResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property InitialResponseMember.
        /// </summary>
        [AWSProperty(Required = true)]
        public string InitialResponseMember { get; set; }

        /// <summary>
        /// Checks to see if the InitialResponseMember property is set.
        /// </summary>
        internal bool IsSetInitialResponseMember() => this.InitialResponseMember != null;

        /// <summary>
        /// Gets and sets the property Stream.
        /// </summary>
        public EventStream Stream { get; set; }

        /// <summary>
        /// Checks to see if the Stream property is set.
        /// </summary>
        internal bool IsSetStream() => this.Stream != null;

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
                this.Stream?.Dispose();
                this.Stream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
