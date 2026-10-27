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

using Amazon.Pinpoint.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCampaignVersions Request Marshaller
    /// </summary>
    public partial class GetCampaignVersionsRequestMarshaller : IMarshaller<IRequest, GetCampaignVersionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCampaignVersionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCampaignVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetPageSize())
            {
                request.Parameters.Add("page-size", StringUtils.FromString(publicRequest.PageSize));
            }

            if (publicRequest.IsSetToken())
            {
                request.Parameters.Add("token", StringUtils.FromString(publicRequest.Token));
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonPinpointException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetCampaignId())
            {
                throw new AmazonPinpointException("Request object does not have required field CampaignId set");
            }
            request.AddPathResource("{CampaignId}", StringUtils.FromString(publicRequest.CampaignId));

            request.ResourcePath = "/v1/apps/{ApplicationId}/campaigns/{CampaignId}/versions";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetCampaignVersionsRequestMarshaller _instance = new();

        internal static GetCampaignVersionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCampaignVersionsRequestMarshaller Instance => _instance;
    }
}
