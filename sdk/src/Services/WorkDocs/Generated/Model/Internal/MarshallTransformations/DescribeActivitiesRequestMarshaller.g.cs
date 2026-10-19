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

using Amazon.WorkDocs.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeActivities Request Marshaller
    /// </summary>
    public partial class DescribeActivitiesRequestMarshaller : IMarshaller<IRequest, DescribeActivitiesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeActivitiesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeActivitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetActivityTypes())
            {
                request.Parameters.Add("activityTypes", StringUtils.FromString(publicRequest.ActivityTypes));
            }

            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if (publicRequest.IsSetIncludeIndirectActivities())
            {
                request.Parameters.Add("includeIndirectActivities", StringUtils.FromBool(publicRequest.IncludeIndirectActivities.Value));
            }

            if (publicRequest.IsSetLimit())
            {
                request.Parameters.Add("limit", StringUtils.FromInt(publicRequest.Limit.Value));
            }

            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            }

            if (publicRequest.IsSetOrganizationId())
            {
                request.Parameters.Add("organizationId", StringUtils.FromString(publicRequest.OrganizationId));
            }

            if (publicRequest.IsSetResourceId())
            {
                request.Parameters.Add("resourceId", StringUtils.FromString(publicRequest.ResourceId));
            }

            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            }

            if (publicRequest.IsSetUserId())
            {
                request.Parameters.Add("userId", StringUtils.FromString(publicRequest.UserId));
            }

            if (publicRequest.IsSetAuthenticationToken())
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            request.ResourcePath = "/api/v1/activities";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeActivitiesRequestMarshaller _instance = new();

        internal static DescribeActivitiesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeActivitiesRequestMarshaller Instance => _instance;
    }
}
