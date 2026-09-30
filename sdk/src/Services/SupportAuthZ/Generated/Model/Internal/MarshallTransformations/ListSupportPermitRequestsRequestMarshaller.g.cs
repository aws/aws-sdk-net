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

using Amazon.SupportAuthZ.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SupportAuthZ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSupportPermitRequests Request Marshaller
    /// </summary>
    public partial class ListSupportPermitRequestsRequestMarshaller : IMarshaller<IRequest, ListSupportPermitRequestsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSupportPermitRequestsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListSupportPermitRequestsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupportAuthZ");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-06-30";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSupportCaseDisplayId())
            {
                request.Parameters.Add("supportCaseDisplayId", StringUtils.FromString(publicRequest.SupportCaseDisplayId));
            }

            request.ResourcePath = "/support-permit-requests";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListSupportPermitRequestsRequestMarshaller _instance = new();

        internal static ListSupportPermitRequestsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListSupportPermitRequestsRequestMarshaller Instance => _instance;
    }
}
