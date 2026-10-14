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
    /// GetResourceDashboard Request Marshaller
    /// </summary>
    public partial class GetResourceDashboardRequestMarshaller : IMarshaller<IRequest, GetResourceDashboardRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceDashboardRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetResourceDashboardRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAccessSystemProfileLogs())
            {
                request.Parameters.Add("accessSystemProfileLogs", StringUtils.FromBool(publicRequest.AccessSystemProfileLogs.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.ResourceId))
            {
                throw new AmazonEMRServerlessException("Request object does not have required field ResourceId set");
            }

            if (publicRequest.IsSetResourceId())
            {
                request.Parameters.Add("resourceId", StringUtils.FromString(publicRequest.ResourceId));
            }

            if (string.IsNullOrEmpty(publicRequest.ResourceType))
            {
                throw new AmazonEMRServerlessException("Request object does not have required field ResourceType set");
            }

            if (publicRequest.IsSetResourceType())
            {
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            request.ResourcePath = "/applications/{applicationId}/dashboard";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetResourceDashboardRequestMarshaller _instance = new();

        internal static GetResourceDashboardRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetResourceDashboardRequestMarshaller Instance => _instance;
    }
}
