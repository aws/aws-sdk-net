/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.IO;
using Amazon.Runtime;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Response object for Transfer Utility open stream operations.
    /// Contains the stream and response metadata from open stream operations.
    /// </summary>
    public class TransferUtilityOpenStreamResponse : TransferUtilityGetObjectResponseBase, IDisposable
    {
        private bool disposed;
        private Stream responseStream;

        #region Dispose Pattern

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the TransferUtilityOpenStreamResponse and optionally disposes of the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to releases only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Remove Managed Resources
                    // I.O.W. remove resources that have to be explicitly
                    // "Dispose"d or Closed. For an S3 Response, these are:
                    // 1. The Response Stream for GET Object requests
                    // 2. The HttpResponse object for GET Object requests
                    if (responseStream != null)
                    {
                        responseStream.Dispose();
                    }
                }

                responseStream = null;
                disposed = true;
            }
        }

        #endregion

        /// <summary>
        /// Gets and sets the ResponseStream property.
        /// <para>
        /// An open stream read from to get the data from S3. In order to
        /// use this stream without leaking the underlying resource, please
        /// wrap access to the stream within a using block.
        /// </para>
        /// </summary>
        public Stream ResponseStream
        {
            get { return this.responseStream; }
            set { this.responseStream = value; }
        }

        // Check to see if ResponseStream property is set
        internal bool IsSetResponseStream()
        {
            return this.responseStream != null;
        }
    }
}
