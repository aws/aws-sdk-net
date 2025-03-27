using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime.EventStreams
{
    /// <summary>
    /// Responses that support streaming request streams will implement this interface. The
    /// interface allows the SDK's pipeline to initialize the response object with context
    /// information for connecting it to the Http request stream.
    /// </summary>
    public interface IEventInputStreamResponse
    {
        /// <summary>
        /// Initialize the response object with the context information that allows
        /// the response object to write event objects to the request stream.
        /// </summary>
        /// <param name="context"></param>
        void InitializeEventInputStream(EventInputStreamContext context);
    }
}
