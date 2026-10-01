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

using Amazon.EMRServerless.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobRuns Request Marshaller
    /// </summary>
    public partial class ListJobRunsRequestMarshaller : IMarshaller<IRequest, ListJobRunsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobRunsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListJobRunsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCreatedAtAfter())
            {
                request.Parameters.Add("createdAtAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedAtAfter));
            }

            if (publicRequest.IsSetCreatedAtBefore())
            {
                request.Parameters.Add("createdAtBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedAtBefore));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetMode())
            {
                request.Parameters.Add("mode", StringUtils.FromString(publicRequest.Mode));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetStates())
            {
                request.ParameterCollection.Add("states", publicRequest.States);
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            request.ResourcePath = "/applications/{applicationId}/jobruns";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListJobRunsRequestMarshaller _instance = new();

        internal static ListJobRunsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListJobRunsRequestMarshaller Instance => _instance;
    }
}
