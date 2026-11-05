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
    /// PutLifecycleHook Request Marshaller
    /// </summary>
    public partial class PutLifecycleHookRequestMarshaller : IMarshaller<IRequest, PutLifecycleHookRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutLifecycleHookRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutLifecycleHookRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PutLifecycleHook");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetDefaultResult())
            {
                request.Parameters.Add("DefaultResult", StringUtils.FromString(publicRequest.DefaultResult));
            }
            if (publicRequest.IsSetHeartbeatTimeout())
            {
                request.Parameters.Add("HeartbeatTimeout", StringUtils.FromInt(publicRequest.HeartbeatTimeout.Value));
            }
            if (publicRequest.IsSetLifecycleHookName())
            {
                request.Parameters.Add("LifecycleHookName", StringUtils.FromString(publicRequest.LifecycleHookName));
            }
            if (publicRequest.IsSetLifecycleTransition())
            {
                request.Parameters.Add("LifecycleTransition", StringUtils.FromString(publicRequest.LifecycleTransition));
            }
            if (publicRequest.IsSetNotificationMetadata())
            {
                request.Parameters.Add("NotificationMetadata", StringUtils.FromString(publicRequest.NotificationMetadata));
            }
            if (publicRequest.IsSetNotificationTargetARN())
            {
                request.Parameters.Add("NotificationTargetARN", StringUtils.FromString(publicRequest.NotificationTargetARN));
            }
            if (publicRequest.IsSetRoleARN())
            {
                request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PutLifecycleHookRequestMarshaller _instance = new();

        internal static PutLifecycleHookRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutLifecycleHookRequestMarshaller Instance => _instance;
    }
}
