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

using Amazon.ResilienceHub.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListApps Request Marshaller
    /// </summary>
    public partial class ListAppsRequestMarshaller : IMarshaller<IRequest, ListAppsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAppsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAppsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAppArn())
            {
                request.Parameters.Add("appArn", StringUtils.FromString(publicRequest.AppArn));
            }

            if (publicRequest.IsSetAwsApplicationArn())
            {
                request.Parameters.Add("awsApplicationArn", StringUtils.FromString(publicRequest.AwsApplicationArn));
            }

            if (publicRequest.IsSetFromLastAssessmentTime())
            {
                request.Parameters.Add("fromLastAssessmentTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.FromLastAssessmentTime));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("name", StringUtils.FromString(publicRequest.Name));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetReverseOrder())
            {
                request.Parameters.Add("reverseOrder", StringUtils.FromBool(publicRequest.ReverseOrder.Value));
            }

            if (publicRequest.IsSetToLastAssessmentTime())
            {
                request.Parameters.Add("toLastAssessmentTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ToLastAssessmentTime));
            }

            request.ResourcePath = "/list-apps";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListAppsRequestMarshaller _instance = new();

        internal static ListAppsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAppsRequestMarshaller Instance => _instance;
    }
}
