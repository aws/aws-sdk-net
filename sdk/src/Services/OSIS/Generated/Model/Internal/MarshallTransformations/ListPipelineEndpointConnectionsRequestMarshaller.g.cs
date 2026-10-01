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

using Amazon.OSIS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.OSIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPipelineEndpointConnections Request Marshaller
    /// </summary>
    public partial class ListPipelineEndpointConnectionsRequestMarshaller : IMarshaller<IRequest, ListPipelineEndpointConnectionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPipelineEndpointConnectionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListPipelineEndpointConnectionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OSIS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-01-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            request.ResourcePath = "/2022-01-01/osis/listPipelineEndpointConnections";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListPipelineEndpointConnectionsRequestMarshaller _instance = new();

        internal static ListPipelineEndpointConnectionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListPipelineEndpointConnectionsRequestMarshaller Instance => _instance;
    }
}
