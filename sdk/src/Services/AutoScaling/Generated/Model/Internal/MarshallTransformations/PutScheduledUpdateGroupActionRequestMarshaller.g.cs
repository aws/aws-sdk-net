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
    /// PutScheduledUpdateGroupAction Request Marshaller
    /// </summary>
    public partial class PutScheduledUpdateGroupActionRequestMarshaller : IMarshaller<IRequest, PutScheduledUpdateGroupActionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutScheduledUpdateGroupActionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutScheduledUpdateGroupActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PutScheduledUpdateGroupAction");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetDesiredCapacity())
            {
                request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(publicRequest.DesiredCapacity.Value));
            }
            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime.Value));
            }
            if (publicRequest.IsSetMaxSize())
            {
                request.Parameters.Add("MaxSize", StringUtils.FromInt(publicRequest.MaxSize.Value));
            }
            if (publicRequest.IsSetMinSize())
            {
                request.Parameters.Add("MinSize", StringUtils.FromInt(publicRequest.MinSize.Value));
            }
            if (publicRequest.IsSetRecurrence())
            {
                request.Parameters.Add("Recurrence", StringUtils.FromString(publicRequest.Recurrence));
            }
            if (publicRequest.IsSetScheduledActionName())
            {
                request.Parameters.Add("ScheduledActionName", StringUtils.FromString(publicRequest.ScheduledActionName));
            }
            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime.Value));
            }
            if (publicRequest.IsSetTime())
            {
                request.Parameters.Add("Time", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Time.Value));
            }
            if (publicRequest.IsSetTimeZone())
            {
                request.Parameters.Add("TimeZone", StringUtils.FromString(publicRequest.TimeZone));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PutScheduledUpdateGroupActionRequestMarshaller _instance = new();

        internal static PutScheduledUpdateGroupActionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutScheduledUpdateGroupActionRequestMarshaller Instance => _instance;
    }
}
