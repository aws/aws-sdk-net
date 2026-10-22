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

using Amazon.Resiliencehubv2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetUserJourney Request Marshaller
    /// </summary>
    public partial class GetUserJourneyRequestMarshaller : IMarshaller<IRequest, GetUserJourneyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetUserJourneyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetUserJourneyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Resiliencehubv2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-02-17";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.SystemArn))
            {
                throw new AmazonResiliencehubv2Exception("Request object does not have required field SystemArn set");
            }

            if (publicRequest.IsSetSystemArn())
            {
                request.Parameters.Add("systemArn", StringUtils.FromString(publicRequest.SystemArn));
            }

            if (string.IsNullOrEmpty(publicRequest.UserJourneyId))
            {
                throw new AmazonResiliencehubv2Exception("Request object does not have required field UserJourneyId set");
            }

            if (publicRequest.IsSetUserJourneyId())
            {
                request.Parameters.Add("userJourneyId", StringUtils.FromString(publicRequest.UserJourneyId));
            }

            request.ResourcePath = "/v2/get-user-journey";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetUserJourneyRequestMarshaller _instance = new();

        internal static GetUserJourneyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetUserJourneyRequestMarshaller Instance => _instance;
    }
}
