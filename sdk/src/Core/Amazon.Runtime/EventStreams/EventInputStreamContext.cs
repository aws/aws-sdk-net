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

using Amazon.Runtime.Internal;
using System;

namespace Amazon.Runtime.EventStreams
{
    /// <summary>
    /// Context object collected by the SDK's pipeline used
    /// for by the response object to allow writing events to the
    /// request stream.
    /// </summary>
    public class EventInputStreamContext : IDisposable
    {
        private bool _disposedValue;

        /// <summary>
        /// The IHttpRequestStreamHandle that the can be used to dispose of the initiating HTTP request once streaming is complete.
        /// </summary>
        public IHttpRequestStreamHandle RequestStreamHandle { get; set; }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    RequestStreamHandle?.Dispose();
                    RequestStreamHandle = null;
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
