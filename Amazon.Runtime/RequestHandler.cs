using System;
using System.Collections.Generic;
using System.Text;
using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.S3;
using System.Net;
using System.Collections.Specialized;

namespace Amazon.Runtime
{
    public class RequestEventArgs : EventArgs
    {
        #region Constructor

        protected RequestEventArgs() { }
        
        #endregion
    }

    public class WebServiceRequestEventArgs : RequestEventArgs
    {
        #region Constructor

        protected WebServiceRequestEventArgs() { }

        #endregion

        #region Properties

        public IDictionary<string, string> Headers { get; protected set; }
        public IDictionary<string, string> Parameters { get; protected set; }
        public string ServiceName { get; protected set; }
        public Uri Endpoint { get; protected set; }
        public AmazonWebServiceRequest OriginalRequest { get; protected set; }

        #endregion

        #region Creator method

        internal static WebServiceRequestEventArgs Create<X>(IRequest<X> request)
        {
            WebServiceRequestEventArgs args = new WebServiceRequestEventArgs
            {
                Headers = request.Headers,
                Parameters = request.Parameters,
                ServiceName = request.ServiceName,
                OriginalRequest = request.OriginalRequest,
                Endpoint = request.Endpoint
            };
            return args;
        }

        #endregion
    }

    public class S3RequestEventArgs : RequestEventArgs
    {
        #region Constructor

        protected S3RequestEventArgs() { }

        #endregion

        #region Properties

        public S3Request OriginalRequest { get; protected set; }
        public WebHeaderCollection Headers { get; protected set; }
        public string ServiceURL { get; protected set; }

        #endregion

        #region Creator method

        internal static S3RequestEventArgs Create(S3Request request, AmazonS3Config config)
        {
            S3RequestEventArgs args = new S3RequestEventArgs
            {
                OriginalRequest = request,
                Headers = request.Headers,
                ServiceURL = config.ServiceURL
            };
            return args;
        }

        #endregion
    }

    public delegate void RequestEventHandler(object sender, RequestEventArgs args);
}
