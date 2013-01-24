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
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Net;

using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Default implementation of the IRequest interface.
    /// <para>
    /// This class is only intended for internal use inside the AWS client libraries.
    /// Callers shouldn't ever interact directly with objects of this class.
    /// </para>
    /// </summary>
    internal class DefaultRequest : IRequest
    {
        IDictionary<string, string> parameters = new Dictionary<string, string>();
        IDictionary<string, string> headers = new Dictionary<string, string>();
        Uri endpoint;
        string resourcePath;
        string serviceName;
        readonly AmazonWebServiceRequest originalRequest;
        byte[] content;
        Stream contentStream;
        string contentStreamHash;
        string httpMethod = "POST";
        bool useQueryString = false;

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
        /// Gets and sets the type of http request to make, whether it should be POST,GET or DELETE
        /// </summary>
        public string HttpMethod
        {
            get
            {
                return this.httpMethod;
            }
            set
            {
                this.httpMethod = value;
            }
        }

        /// <summary>
        /// Gets and sets a flag that indicates whether the request is sent as a query string instead of the request body.
        /// </summary>
        public bool UseQueryString
        {
            get
            {
                if (this.HttpMethod == "GET")
                    return true;
                return this.useQueryString;
            }
            set
            {
                this.useQueryString = value;
            }
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
        /// Gets and Sets the resource path added on to the endpoint.
        /// </summary>
        public string ResourcePath
        {
            get
            {
                return this.resourcePath;
            }
            set
            {
                this.resourcePath = value;
            }
        }

        /// <summary>
        /// Gets and Sets the content for this request.
        /// </summary>
        public byte[] Content
        {
            get
            {
                return this.content;
            }
            set
            {
                this.content = value;
            }
        }

        /// <summary>
        /// Gets and sets the content stream.
        /// </summary>
        public Stream ContentStream
        {
            get { return this.contentStream; }
            set { this.contentStream = value; }
        }

        public string ContentStreamHash
        {
            get
            {
                if (this.contentStream == null)
                    return null;

                if (this.contentStreamHash == null)
                {
                    long position = this.ContentStream.Position;

                    var hash = new SHA256CryptoServiceProvider();
                    byte[] payloadHashBytes = hash.ComputeHash(this.ContentStream);
                    this.contentStreamHash = AWSSDKUtils.ToHex(payloadHashBytes, true);

                    this.ContentStream.Seek(position, SeekOrigin.Begin);
                }

                return this.contentStreamHash;
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
