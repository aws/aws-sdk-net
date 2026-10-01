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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.S3Outposts.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSharedEndpoints Request Marshaller
    /// </summary>
    public partial class ListSharedEndpointsRequestMarshaller : IMarshaller<IRequest, ListSharedEndpointsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSharedEndpointsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListSharedEndpointsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Outposts");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (string.IsNullOrEmpty(publicRequest.OutpostId))
            {
                throw new AmazonS3OutpostsException("Request object does not have required field OutpostId set");
            }

            if (publicRequest.IsSetOutpostId())
            {
                request.Parameters.Add("outpostId", StringUtils.FromString(publicRequest.OutpostId));
            }

            request.ResourcePath = "/S3Outposts/ListSharedEndpoints";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListSharedEndpointsRequestMarshaller _instance = new();

        internal static ListSharedEndpointsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListSharedEndpointsRequestMarshaller Instance => _instance;
    }
}
