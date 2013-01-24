/*
 * Copyright 2011-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        public AmazonWebServiceRequest Request { get; protected set; }
        [Obsolete("OriginalRequest property has been deprecated in favor of the Request property")]
        public AmazonWebServiceRequest OriginalRequest { get { return Request; } }

        #endregion

        #region Creator method

        internal static WebServiceRequestEventArgs Create(IRequest request)
        {
            WebServiceRequestEventArgs args = new WebServiceRequestEventArgs
            {
                Headers = request.Headers,
                Parameters = request.Parameters,
                ServiceName = request.ServiceName,
                Request = request.OriginalRequest,
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

    public class HeadersRequestEventArgs : RequestEventArgs
    {
        protected HeadersRequestEventArgs() { }
        public IDictionary<string, string> Headers { get; protected set; }

        internal static HeadersRequestEventArgs Create(IDictionary<string, string> headers)
        {
            HeadersRequestEventArgs args = new HeadersRequestEventArgs
            {
                Headers = headers
            };
            return args;
        }
    }

    public delegate void RequestEventHandler(object sender, RequestEventArgs args);
}
