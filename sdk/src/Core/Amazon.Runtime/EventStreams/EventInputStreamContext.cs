using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Amazon.Runtime.EventStreams
{
    /// <summary>
    /// Context object collected by the SDK's pipeline used
    /// for by the response object to allow writing events to the
    /// request stream.
    /// </summary>
    public class EventInputStreamContext
    {
        /// <summary>
        /// The AWS credentials used for making the initial request.
        /// </summary>
        public AWSCredentials Credentials { get; set; }

        /// <summary>
        /// The original service request object to make the request.
        /// </summary>
        public AmazonWebServiceRequest OriginalRequest { get; set; }

        /// <summary>
        /// The service client config for the service client that made the request.
        /// </summary>
        public IClientConfig ClientConfig { get; set; }

        /// <summary>
        /// The IHttpRequestStreamWriter initialized by the underlying HttpHandler that 
        /// provides access to writing bytes to the request stream.
        /// </summary>
        public IHttpRequestStreamWriter RequestStreamWriter { get; set; }

        /// <summary>
        /// The signature computed for the initial request. This is used for signing the first event sent.
        /// </summary>
        public string InitialSignature { get; set; }

        /// <summary>
        /// The region to sign the event with.
        /// </summary>
        public string AuthenticationRegion { get; set; }
    }
}
