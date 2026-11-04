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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecordLifecycleActionHeartbeat Request Marshaller
    /// </summary>
    public partial class RecordLifecycleActionHeartbeatRequestMarshaller : IMarshaller<IRequest, RecordLifecycleActionHeartbeatRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RecordLifecycleActionHeartbeatRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RecordLifecycleActionHeartbeatRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RecordLifecycleActionHeartbeat");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetLifecycleActionToken())
            {
                request.Parameters.Add("LifecycleActionToken", StringUtils.FromString(publicRequest.LifecycleActionToken));
            }
            if (publicRequest.IsSetLifecycleHookName())
            {
                request.Parameters.Add("LifecycleHookName", StringUtils.FromString(publicRequest.LifecycleHookName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RecordLifecycleActionHeartbeatRequestMarshaller _instance = new();

        internal static RecordLifecycleActionHeartbeatRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecordLifecycleActionHeartbeatRequestMarshaller Instance => _instance;
    }
}
