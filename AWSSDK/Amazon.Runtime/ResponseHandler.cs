using System;
using System.Collections.Generic;
using System.Text;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
    public delegate void ResponseEventHandler(object sender, ResponseEventArgs args);

    public class ResponseEventArgs : EventArgs
    {
        #region Constructor

        protected ResponseEventArgs() { }

        #endregion
    }

    public class WebServiceResponseEventArgs : ResponseEventArgs
    {
        #region Constructor

        protected WebServiceResponseEventArgs() { }

        #endregion

        #region Properties

        public IDictionary<string, string> Headers { get; protected set; }
        public IDictionary<string, string> Parameters { get; protected set; }
        public string ServiceName { get; protected set; }
        public Uri Endpoint { get; protected set; }
        public AmazonWebServiceRequest Request { get; protected set; }
        public AmazonWebServiceResponse Response { get; protected set; }

        #endregion

        #region Creator method

        internal static WebServiceResponseEventArgs Create(AmazonWebServiceResponse response, IRequest request)
        {
            WebServiceResponseEventArgs args = new WebServiceResponseEventArgs
            {
                Headers = request.Headers,
                Parameters = request.Parameters,
                ServiceName = request.ServiceName,
                Request = request.OriginalRequest,
                Endpoint = request.Endpoint,
                Response = response
            };
            return args;
        }

        #endregion
    }
}
