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
    /// Describe Scaling Activities Request Marshaller
    /// </summary>       
    public class DescribeScalingActivitiesRequestMarshaller : IMarshaller<IRequest, DescribeScalingActivitiesRequest>
    {
        public IRequest Marshall(DescribeScalingActivitiesRequest describeScalingActivitiesRequest)
        {
            IRequest request = new DefaultRequest(describeScalingActivitiesRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribeScalingActivities");
            request.Parameters.Add("Version", "2011-01-01");
            if (describeScalingActivitiesRequest != null)
            {
                List<string> activityIdsList = describeScalingActivitiesRequest.ActivityIds;

                int activityIdsListIndex = 1;
                foreach (string activityIdsListValue in activityIdsList)
                { 
                    request.Parameters.Add("ActivityIds.member." + activityIdsListIndex, StringUtils.FromString(activityIdsListValue));
                    activityIdsListIndex++;
                }
            }
            if (describeScalingActivitiesRequest != null && describeScalingActivitiesRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(describeScalingActivitiesRequest.AutoScalingGroupName));
            }
            if (describeScalingActivitiesRequest != null && describeScalingActivitiesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeScalingActivitiesRequest.MaxRecords));
            }
            if (describeScalingActivitiesRequest != null && describeScalingActivitiesRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeScalingActivitiesRequest.NextToken));
            }

            return request;
        }
    }
}
