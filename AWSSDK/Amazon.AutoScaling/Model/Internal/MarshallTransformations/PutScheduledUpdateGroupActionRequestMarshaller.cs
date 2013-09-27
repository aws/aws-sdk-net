/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Scheduled Update Group Action Request Marshaller
    /// </summary>       
    public class PutScheduledUpdateGroupActionRequestMarshaller : IMarshaller<IRequest, PutScheduledUpdateGroupActionRequest>
    {
        public IRequest Marshall(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest)
        {
            IRequest request = new DefaultRequest(putScheduledUpdateGroupActionRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "PutScheduledUpdateGroupAction");
            request.Parameters.Add("Version", "2011-01-01");
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(putScheduledUpdateGroupActionRequest.AutoScalingGroupName));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetScheduledActionName())
            {
                request.Parameters.Add("ScheduledActionName", StringUtils.FromString(putScheduledUpdateGroupActionRequest.ScheduledActionName));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetTime())
            {
                request.Parameters.Add("Time", StringUtils.FromDateTime(putScheduledUpdateGroupActionRequest.Time));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(putScheduledUpdateGroupActionRequest.StartTime));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(putScheduledUpdateGroupActionRequest.EndTime));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetRecurrence())
            {
                request.Parameters.Add("Recurrence", StringUtils.FromString(putScheduledUpdateGroupActionRequest.Recurrence));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetMinSize())
            {
                request.Parameters.Add("MinSize", StringUtils.FromInt(putScheduledUpdateGroupActionRequest.MinSize));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetMaxSize())
            {
                request.Parameters.Add("MaxSize", StringUtils.FromInt(putScheduledUpdateGroupActionRequest.MaxSize));
            }
            if (putScheduledUpdateGroupActionRequest != null && putScheduledUpdateGroupActionRequest.IsSetDesiredCapacity())
            {
                request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(putScheduledUpdateGroupActionRequest.DesiredCapacity));
            }

            return request;
        }
    }
}
