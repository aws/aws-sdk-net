/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Default implementation of the IRequest interface.
    /// <para>
    /// This class is only intended for internal use inside the AWS client libraries.
    /// Callers shouldn't ever interact directly with objects of this class.
    /// </para>
    /// </summary>
    internal class DefaultRequest<T> : IRequest<T>
    {
        IDictionary<string, string> parameters = new Dictionary<string, string>();
        IDictionary<string, string> headers = new Dictionary<string, string>();
        Uri endpoint;
        string serviceName;
        readonly AmazonWebServiceRequest originalRequest;

        /// <summary>
        /// Constructs a new DefaultRequest with the specified service name and the
        /// original, user facing request object.
        /// </summary>
        /// <param name="originalRequest">The orignal request that is being wrapped</param>
        /// <param name="serviceName">The service name</param>
        public DefaultRequest(AmazonWebServiceRequest originalRequest, String serviceName)
        {
            this.serviceName = serviceName;
            this.originalRequest = originalRequest;
        }

        /// <summary>
        /// Returns the original, user facing request object which this internal
        /// request object is representing.
        /// </summary>
        public AmazonWebServiceRequest OriginalRequest
        {
            get
            {
                return originalRequest;
            }
        }

        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        public IDictionary<string, string> Headers
        {
            get
            {
                return this.headers;
            }
        }


        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                return this.parameters;
            }
        }

        /// <summary>
        /// Gets and Sets the endpoint for this request.
        /// </summary>
        public Uri Endpoint
        {
            get
            {
                return this.endpoint;
            }
            set
            {
                this.endpoint = value;
            }
        }


        /// <summary>
        /// The name of the service to which this request is being sent.
        /// </summary>
        public string ServiceName
        {
            get
            {
                return this.serviceName;
            }
        }
    }
}
