using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Provides a write method for high level points of the SDK to be able to write to 
    /// the request stream after the initial request has been made.
    /// </summary>
    public interface IHttpRequestStreamWriter : IDisposable
    {
        /// <summary>
        /// Write bytes to the request stream after the initial request has been sent.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task WriteAsync(byte[] bytes, CancellationToken token = default(CancellationToken));
    }
}
