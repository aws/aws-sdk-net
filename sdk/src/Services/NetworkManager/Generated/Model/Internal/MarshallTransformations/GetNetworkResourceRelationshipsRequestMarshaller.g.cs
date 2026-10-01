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

using Amazon.NetworkManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetNetworkResourceRelationships Request Marshaller
    /// </summary>
    public partial class GetNetworkResourceRelationshipsRequestMarshaller : IMarshaller<IRequest, GetNetworkResourceRelationshipsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetNetworkResourceRelationshipsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetNetworkResourceRelationshipsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAccountId())
            {
                request.Parameters.Add("accountId", StringUtils.FromString(publicRequest.AccountId));
            }

            if (publicRequest.IsSetAwsRegion())
            {
                request.Parameters.Add("awsRegion", StringUtils.FromString(publicRequest.AwsRegion));
            }

            if (publicRequest.IsSetCoreNetworkId())
            {
                request.Parameters.Add("coreNetworkId", StringUtils.FromString(publicRequest.CoreNetworkId));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetRegisteredGatewayArn())
            {
                request.Parameters.Add("registeredGatewayArn", StringUtils.FromString(publicRequest.RegisteredGatewayArn));
            }

            if (publicRequest.IsSetResourceArn())
            {
                request.Parameters.Add("resourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            }

            if (publicRequest.IsSetResourceType())
            {
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            }

            if (!publicRequest.IsSetGlobalNetworkId())
            {
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            }
            request.AddPathResource("{GlobalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));

            request.ResourcePath = "/global-networks/{GlobalNetworkId}/network-resource-relationships";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetNetworkResourceRelationshipsRequestMarshaller _instance = new();

        internal static GetNetworkResourceRelationshipsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetNetworkResourceRelationshipsRequestMarshaller Instance => _instance;
    }
}
