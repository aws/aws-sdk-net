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

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Set Alarm State Request Marshaller
    /// </summary>       
    public class SetAlarmStateRequestMarshaller : IMarshaller<IRequest, SetAlarmStateRequest>
    {
        public IRequest Marshall(SetAlarmStateRequest setAlarmStateRequest)
        {
            IRequest request = new DefaultRequest(setAlarmStateRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "SetAlarmState");
            request.Parameters.Add("Version", "2010-08-01");
            if (setAlarmStateRequest != null && setAlarmStateRequest.IsSetAlarmName())
            {
                request.Parameters.Add("AlarmName", StringUtils.FromString(setAlarmStateRequest.AlarmName));
            }
            if (setAlarmStateRequest != null && setAlarmStateRequest.IsSetStateValue())
            {
                request.Parameters.Add("StateValue", StringUtils.FromString(setAlarmStateRequest.StateValue));
            }
            if (setAlarmStateRequest != null && setAlarmStateRequest.IsSetStateReason())
            {
                request.Parameters.Add("StateReason", StringUtils.FromString(setAlarmStateRequest.StateReason));
            }
            if (setAlarmStateRequest != null && setAlarmStateRequest.IsSetStateReasonData())
            {
                request.Parameters.Add("StateReasonData", StringUtils.FromString(setAlarmStateRequest.StateReasonData));
            }

            return request;
        }
    }
}
