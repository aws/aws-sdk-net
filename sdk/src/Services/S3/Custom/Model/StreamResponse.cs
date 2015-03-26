/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for responses that return a stream.
    /// </summary>
    public abstract class StreamResponse : AmazonWebServiceResponse, IDisposable
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
            if (!this.disposed)
            {
                GC.SuppressFinalize(this);
            }
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Remove Unmanaged Resources
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
        /// An open stream read from to get the data from S3. In order to
        /// use this stream without leaking the underlying resource, please
        /// wrap access to the stream within a using block.
        /// </summary>
        public Stream ResponseStream
        {
            get { return this.responseStream; }
            set { this.responseStream = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetResponseStream()
        {
            return this.responseStream != null;
        }
    }
}
