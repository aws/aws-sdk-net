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

using Amazon.WellArchitected.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAgentRecommendationItems Request Marshaller
    /// </summary>
    public partial class ListAgentRecommendationItemsRequestMarshaller : IMarshaller<IRequest, ListAgentRecommendationItemsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAgentRecommendationItemsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAgentRecommendationItemsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetType())
            {
                request.Parameters.Add("type", StringUtils.FromString(publicRequest.Type));
            }

            if (!publicRequest.IsSetRecommendationArn())
            {
                throw new AmazonWellArchitectedException("Request object does not have required field RecommendationArn set");
            }
            request.AddPathResource("{recommendationArn}", StringUtils.FromString(publicRequest.RecommendationArn));

            request.ResourcePath = "/api/v1/agent-recommendations/{recommendationArn}/items";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListAgentRecommendationItemsRequestMarshaller _instance = new();

        internal static ListAgentRecommendationItemsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAgentRecommendationItemsRequestMarshaller Instance => _instance;
    }
}
