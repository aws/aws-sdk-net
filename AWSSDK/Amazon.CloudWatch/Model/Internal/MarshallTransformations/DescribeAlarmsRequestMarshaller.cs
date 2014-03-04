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
    /// Describe Alarms Request Marshaller
    /// </summary>       
    public class DescribeAlarmsRequestMarshaller : IMarshaller<IRequest, DescribeAlarmsRequest>
    {
        public IRequest Marshall(DescribeAlarmsRequest describeAlarmsRequest)
        {
            IRequest request = new DefaultRequest(describeAlarmsRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "DescribeAlarms");
            request.Parameters.Add("Version", "2010-08-01");
            if (describeAlarmsRequest != null)
            {
                List<string> alarmNamesList = describeAlarmsRequest.AlarmNames;

                int alarmNamesListIndex = 1;
                foreach (string alarmNamesListValue in alarmNamesList)
                { 
                    request.Parameters.Add("AlarmNames.member." + alarmNamesListIndex, StringUtils.FromString(alarmNamesListValue));
                    alarmNamesListIndex++;
                }
            }
            if (describeAlarmsRequest != null && describeAlarmsRequest.IsSetAlarmNamePrefix())
            {
                request.Parameters.Add("AlarmNamePrefix", StringUtils.FromString(describeAlarmsRequest.AlarmNamePrefix));
            }
            if (describeAlarmsRequest != null && describeAlarmsRequest.IsSetStateValue())
            {
                request.Parameters.Add("StateValue", StringUtils.FromString(describeAlarmsRequest.StateValue));
            }
            if (describeAlarmsRequest != null && describeAlarmsRequest.IsSetActionPrefix())
            {
                request.Parameters.Add("ActionPrefix", StringUtils.FromString(describeAlarmsRequest.ActionPrefix));
            }
            if (describeAlarmsRequest != null && describeAlarmsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeAlarmsRequest.MaxRecords));
            }
            if (describeAlarmsRequest != null && describeAlarmsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeAlarmsRequest.NextToken));
            }

            return request;
        }
    }
}
