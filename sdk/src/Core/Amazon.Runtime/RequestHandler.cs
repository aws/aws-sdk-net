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
using System;
using System.Collections.Generic;
using System.Text;
using Amazon.Runtime.Internal;
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
        public ParameterCollection ParameterCollection { get; protected set; }
        public string ServiceName { get; protected set; }
        public Uri Endpoint { get; protected set; }
        public AmazonWebServiceRequest Request { get; protected set; }

        #endregion

        #region Creator method

        internal static WebServiceRequestEventArgs Create(IRequest request)
        {
            WebServiceRequestEventArgs args = new WebServiceRequestEventArgs
            {
                Headers = request.Headers,
                ParameterCollection = request.ParameterCollection,
                ServiceName = request.ServiceName,
                Endpoint = request.Endpoint,
                Request = request.OriginalRequest
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

    public delegate void RequestEventHandler(object sender, RequestEventArgs e);
}
