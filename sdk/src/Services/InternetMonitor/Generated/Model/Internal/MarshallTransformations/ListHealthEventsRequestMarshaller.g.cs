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

using Amazon.InternetMonitor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListHealthEvents Request Marshaller
    /// </summary>
    public partial class ListHealthEventsRequestMarshaller : IMarshaller<IRequest, ListHealthEventsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHealthEventsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListHealthEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.InternetMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-03";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if (publicRequest.IsSetEventStatus())
            {
                request.Parameters.Add("EventStatus", StringUtils.FromString(publicRequest.EventStatus));
            }

            if (publicRequest.IsSetLinkedAccountId())
            {
                request.Parameters.Add("LinkedAccountId", StringUtils.FromString(publicRequest.LinkedAccountId));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            }

            if (!publicRequest.IsSetMonitorName())
            {
                throw new AmazonInternetMonitorException("Request object does not have required field MonitorName set");
            }
            request.AddPathResource("{MonitorName}", StringUtils.FromString(publicRequest.MonitorName));

            request.ResourcePath = "/v20210603/Monitors/{MonitorName}/HealthEvents";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListHealthEventsRequestMarshaller _instance = new();

        internal static ListHealthEventsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListHealthEventsRequestMarshaller Instance => _instance;
    }
}
