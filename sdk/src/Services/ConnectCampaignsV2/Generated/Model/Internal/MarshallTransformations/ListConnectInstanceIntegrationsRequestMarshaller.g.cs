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

using Amazon.ConnectCampaignsV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListConnectInstanceIntegrations Request Marshaller
    /// </summary>
    public partial class ListConnectInstanceIntegrationsRequestMarshaller : IMarshaller<IRequest, ListConnectInstanceIntegrationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListConnectInstanceIntegrationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListConnectInstanceIntegrationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCampaignsV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-23";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetConnectInstanceId())
            {
                throw new AmazonConnectCampaignsV2Exception("Request object does not have required field ConnectInstanceId set");
            }
            request.AddPathResource("{connectInstanceId}", StringUtils.FromString(publicRequest.ConnectInstanceId));

            request.ResourcePath = "/v2/connect-instance/{connectInstanceId}/integrations";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListConnectInstanceIntegrationsRequestMarshaller _instance = new();

        internal static ListConnectInstanceIntegrationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListConnectInstanceIntegrationsRequestMarshaller Instance => _instance;
    }
}
