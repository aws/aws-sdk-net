using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.Runtime
{
    public interface IUnityHttpRequest
    {
        /// <summary>
        /// The content to be sent in the request body.
        /// </summary>
        byte[] RequestContent { get; }

        /// <summary>
        /// The headers to be sent for this request.
        /// </summary>
        Dictionary<string, string> Headers { get; }

        /// <summary>
        /// The callback to be invoked after BeginGetResponse completes.
        /// </summary>
        AsyncCallback Callback { get; }

        /// <summary>
        /// The IAsyncResult for the BeginGetResponse method.
        /// This stores the async state to be passed to the callback after this request
        /// is procesed by the UnityMainThreadDispatcher.
        /// </summary>
        IAsyncResult AsyncResult { get; }

        /// <summary>
        /// A wait handle that is used to implement the synchronous
        /// GetResponse method.
        /// </summary>
        ManualResetEvent WaitHandle { get; }

        /// <summary>
        /// A flag to indicate if this request is being invoked
        /// synchronously.
        /// </summary>
        bool IsSync { get; set; }

        /// <summary>
        /// Any exceptions resulting from this web request
        /// are set on this property.
        /// </summary>
        Exception Exception { get; set; }

        /// <summary>
        /// The WWW instance for this web request.
        /// </summary>
        IDisposable WwwRequest { get; set; }

        /// <summary>
        /// The response for this web request.
        /// </summary>
        IWebResponseData Response { get; set; }

        /// <summary>
        /// Track upload progress changes
        /// </summary>
        /// <param name="progress"></param>
        void OnUploadProgressChanged(float progress);
    }
}
