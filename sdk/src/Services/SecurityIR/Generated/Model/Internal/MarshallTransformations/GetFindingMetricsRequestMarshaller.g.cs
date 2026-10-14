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

using Amazon.SecurityIR.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityIR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFindingMetrics Request Marshaller
    /// </summary>
    public partial class GetFindingMetricsRequestMarshaller : IMarshaller<IRequest, GetFindingMetricsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFindingMetricsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetFindingMetricsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityIR");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (publicRequest.EndDate == null)
            {
                throw new AmazonSecurityIRException("Request object does not have required field EndDate set");
            }

            if (publicRequest.IsSetEndDate())
            {
                request.Parameters.Add("endDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
            }

            if (publicRequest.StartDate == null)
            {
                throw new AmazonSecurityIRException("Request object does not have required field StartDate set");
            }

            if (publicRequest.IsSetStartDate())
            {
                request.Parameters.Add("startDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDate));
            }

            if (!publicRequest.IsSetMembershipId())
            {
                throw new AmazonSecurityIRException("Request object does not have required field MembershipId set");
            }
            request.AddPathResource("{membershipId}", StringUtils.FromString(publicRequest.MembershipId));

            request.ResourcePath = "/v1/membership/{membershipId}/finding-metrics";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetFindingMetricsRequestMarshaller _instance = new();

        internal static GetFindingMetricsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetFindingMetricsRequestMarshaller Instance => _instance;
    }
}
