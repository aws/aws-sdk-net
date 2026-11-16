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

using Amazon.ConnectScheduling.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectScheduling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTimeOff Request Marshaller
    /// </summary>
    public partial class GetTimeOffRequestMarshaller : IMarshaller<IRequest, GetTimeOffRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTimeOffRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTimeOffRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectScheduling");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-07-16";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetInstanceId())
            {
                throw new AmazonConnectSchedulingException("Request object does not have required field InstanceId set");
            }
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));

            if (!publicRequest.IsSetTimeOffId())
            {
                throw new AmazonConnectSchedulingException("Request object does not have required field TimeOffId set");
            }
            request.AddPathResource("{TimeOffId}", StringUtils.FromString(publicRequest.TimeOffId));

            if (!publicRequest.IsSetUserId())
            {
                throw new AmazonConnectSchedulingException("Request object does not have required field UserId set");
            }
            request.AddPathResource("{UserId}", StringUtils.FromString(publicRequest.UserId));

            request.ResourcePath = "/scheduling/instances/{InstanceId}/users/{UserId}/timeoffs/{TimeOffId}";

            return request;
        }

        private static readonly GetTimeOffRequestMarshaller _instance = new();

        internal static GetTimeOffRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTimeOffRequestMarshaller Instance => _instance;
    }
}
