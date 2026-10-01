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

using Amazon.CodeGuruProfiler.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFindingsReports Request Marshaller
    /// </summary>
    public partial class ListFindingsReportsRequestMarshaller : IMarshaller<IRequest, ListFindingsReportsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFindingsReportsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListFindingsReportsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetDailyReportsOnly())
            {
                request.Parameters.Add("dailyReportsOnly", StringUtils.FromBool(publicRequest.DailyReportsOnly.Value));
            }

            if (publicRequest.EndTime == null)
            {
                throw new AmazonCodeGuruProfilerException("Request object does not have required field EndTime set");
            }

            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.StartTime == null)
            {
                throw new AmazonCodeGuruProfilerException("Request object does not have required field StartTime set");
            }

            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            }

            if (!publicRequest.IsSetProfilingGroupName())
            {
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            }
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));

            request.ResourcePath = "/internal/profilingGroups/{profilingGroupName}/findingsReports";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListFindingsReportsRequestMarshaller _instance = new();

        internal static ListFindingsReportsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListFindingsReportsRequestMarshaller Instance => _instance;
    }
}
