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
using System.Linq;
using System.Text;

namespace Amazon.Runtime
{
    public delegate void AmazonServiceCallback<TRequest, TResponse>(AmazonServiceResult<TRequest, TResponse> responseObject)
        where TRequest : AmazonWebServiceRequest
        where TResponse : AmazonWebServiceResponse;

    /// <summary>
    /// A result object passed back in the callback.
    /// </summary>
    /// <typeparam name="TRequest">A request object derived from AmazonWebServiceRequest</typeparam>
    /// <typeparam name="TResponse">A response object derived from AmazonWebServiceResponse</typeparam>
    public class AmazonServiceResult<TRequest, TResponse>
        where TRequest : AmazonWebServiceRequest
        where TResponse : AmazonWebServiceResponse
    {
        public TRequest Request { get; internal set; }
        public TResponse Response { get; internal set; }
        public Exception Exception { get; internal set; }
        public object state { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="request">A request object derived from AmazonWebServiceRequest</param>
        /// <param name="response">A response object derived from AmazonWebServiceResponse</param>
        /// <param name="exception">The exception that occured </param>
        /// <param name="state">A user defined state passed back from callback</param>
        public AmazonServiceResult(TRequest request, TResponse response, Exception exception, object state)
        {
            this.Request = request;
            this.Response = response;
            this.Exception = exception;
            this.state = state;
        }
    }

}
