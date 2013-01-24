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
    /// Describe Alarm History Request Marshaller
    /// </summary>       
    public class DescribeAlarmHistoryRequestMarshaller : IMarshaller<IRequest, DescribeAlarmHistoryRequest>
    {
        public IRequest Marshall(DescribeAlarmHistoryRequest describeAlarmHistoryRequest)
        {
            IRequest request = new DefaultRequest(describeAlarmHistoryRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "DescribeAlarmHistory");
            request.Parameters.Add("Version", "2010-08-01");
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetAlarmName())
            {
                request.Parameters.Add("AlarmName", StringUtils.FromString(describeAlarmHistoryRequest.AlarmName));
            }
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetHistoryItemType())
            {
                request.Parameters.Add("HistoryItemType", StringUtils.FromString(describeAlarmHistoryRequest.HistoryItemType));
            }
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetStartDate())
            {
                request.Parameters.Add("StartDate", StringUtils.FromDateTime(describeAlarmHistoryRequest.StartDate));
            }
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetEndDate())
            {
                request.Parameters.Add("EndDate", StringUtils.FromDateTime(describeAlarmHistoryRequest.EndDate));
            }
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeAlarmHistoryRequest.MaxRecords));
            }
            if (describeAlarmHistoryRequest != null && describeAlarmHistoryRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeAlarmHistoryRequest.NextToken));
            }

            return request;
        }
    }
}
