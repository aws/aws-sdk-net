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
    /// GetProfile Request Marshaller
    /// </summary>
    public partial class GetProfileRequestMarshaller : IMarshaller<IRequest, GetProfileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProfileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if (publicRequest.IsSetMaxDepth())
            {
                request.Parameters.Add("maxDepth", StringUtils.FromInt(publicRequest.MaxDepth.Value));
            }

            if (publicRequest.IsSetPeriod())
            {
                request.Parameters.Add("period", StringUtils.FromString(publicRequest.Period));
            }

            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            }

            if (publicRequest.IsSetAccept())
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }

            if (!publicRequest.IsSetProfilingGroupName())
            {
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            }
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));

            request.ResourcePath = "/profilingGroups/{profilingGroupName}/profile";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetProfileRequestMarshaller _instance = new();

        internal static GetProfileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetProfileRequestMarshaller Instance => _instance;
    }
}
