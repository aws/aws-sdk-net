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
    /// BatchPutScheduledUpdateGroupAction Request Marshaller
    /// </summary>
    public partial class BatchPutScheduledUpdateGroupActionRequestMarshaller : IMarshaller<IRequest, BatchPutScheduledUpdateGroupActionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutScheduledUpdateGroupActionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchPutScheduledUpdateGroupActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "BatchPutScheduledUpdateGroupAction");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetScheduledUpdateGroupActions())
            {
                if (publicRequest.ScheduledUpdateGroupActions.Count == 0)
                {
                    request.Parameters.Add("ScheduledUpdateGroupActions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ScheduledUpdateGroupActions)
                    {
                        if (item0.IsSetDesiredCapacity())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".DesiredCapacity", StringUtils.FromInt(item0.DesiredCapacity.Value));
                        }
                        if (item0.IsSetEndTime())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(item0.EndTime.Value));
                        }
                        if (item0.IsSetMaxSize())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".MaxSize", StringUtils.FromInt(item0.MaxSize.Value));
                        }
                        if (item0.IsSetMinSize())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".MinSize", StringUtils.FromInt(item0.MinSize.Value));
                        }
                        if (item0.IsSetRecurrence())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".Recurrence", StringUtils.FromString(item0.Recurrence));
                        }
                        if (item0.IsSetScheduledActionName())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".ScheduledActionName", StringUtils.FromString(item0.ScheduledActionName));
                        }
                        if (item0.IsSetStartTime())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(item0.StartTime.Value));
                        }
                        if (item0.IsSetTimeZone())
                        {
                            request.Parameters.Add("ScheduledUpdateGroupActions" + ".member" + "." + index0 + ".TimeZone", StringUtils.FromString(item0.TimeZone));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly BatchPutScheduledUpdateGroupActionRequestMarshaller _instance = new();

        internal static BatchPutScheduledUpdateGroupActionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchPutScheduledUpdateGroupActionRequestMarshaller Instance => _instance;
    }
}
