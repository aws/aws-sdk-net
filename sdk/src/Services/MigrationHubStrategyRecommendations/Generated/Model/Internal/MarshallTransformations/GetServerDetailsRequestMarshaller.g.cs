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

using Amazon.MigrationHubStrategyRecommendations.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetServerDetails Request Marshaller
    /// </summary>
    public partial class GetServerDetailsRequestMarshaller : IMarshaller<IRequest, GetServerDetailsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetServerDetailsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetServerDetailsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubStrategyRecommendations");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-19";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetServerId())
            {
                throw new AmazonMigrationHubStrategyRecommendationsException("Request object does not have required field ServerId set");
            }
            request.AddPathResource("{serverId}", StringUtils.FromString(publicRequest.ServerId));

            request.ResourcePath = "/get-server-details/{serverId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetServerDetailsRequestMarshaller _instance = new();

        internal static GetServerDetailsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetServerDetailsRequestMarshaller Instance => _instance;
    }
}
