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
    /// Describe Scheduled Actions Request Marshaller
    /// </summary>       
    public class DescribeScheduledActionsRequestMarshaller : IMarshaller<IRequest, DescribeScheduledActionsRequest>
    {
        public IRequest Marshall(DescribeScheduledActionsRequest describeScheduledActionsRequest)
        {
            IRequest request = new DefaultRequest(describeScheduledActionsRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribeScheduledActions");
            request.Parameters.Add("Version", "2011-01-01");
            if (describeScheduledActionsRequest != null && describeScheduledActionsRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(describeScheduledActionsRequest.AutoScalingGroupName));
            }
            if (describeScheduledActionsRequest != null)
            {
                List<string> scheduledActionNamesList = describeScheduledActionsRequest.ScheduledActionNames;

                int scheduledActionNamesListIndex = 1;
                foreach (string scheduledActionNamesListValue in scheduledActionNamesList)
                { 
                    request.Parameters.Add("ScheduledActionNames.member." + scheduledActionNamesListIndex, StringUtils.FromString(scheduledActionNamesListValue));
                    scheduledActionNamesListIndex++;
                }
            }
            if (describeScheduledActionsRequest != null && describeScheduledActionsRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(describeScheduledActionsRequest.StartTime));
            }
            if (describeScheduledActionsRequest != null && describeScheduledActionsRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(describeScheduledActionsRequest.EndTime));
            }
            if (describeScheduledActionsRequest != null && describeScheduledActionsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeScheduledActionsRequest.NextToken));
            }
            if (describeScheduledActionsRequest != null && describeScheduledActionsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeScheduledActionsRequest.MaxRecords));
            }

            return request;
        }
    }
}
