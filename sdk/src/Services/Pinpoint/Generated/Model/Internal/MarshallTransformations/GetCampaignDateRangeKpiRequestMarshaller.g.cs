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
    /// GetCampaignDateRangeKpi Request Marshaller
    /// </summary>
    public partial class GetCampaignDateRangeKpiRequestMarshaller : IMarshaller<IRequest, GetCampaignDateRangeKpiRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCampaignDateRangeKpiRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCampaignDateRangeKpiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("end-time", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetPageSize())
            {
                request.Parameters.Add("page-size", StringUtils.FromString(publicRequest.PageSize));
            }

            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("start-time", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
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

            if (!publicRequest.IsSetKpiName())
            {
                throw new AmazonPinpointException("Request object does not have required field KpiName set");
            }
            request.AddPathResource("{KpiName}", StringUtils.FromString(publicRequest.KpiName));

            request.ResourcePath = "/v1/apps/{ApplicationId}/campaigns/{CampaignId}/kpis/daterange/{KpiName}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetCampaignDateRangeKpiRequestMarshaller _instance = new();

        internal static GetCampaignDateRangeKpiRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCampaignDateRangeKpiRequestMarshaller Instance => _instance;
    }
}
