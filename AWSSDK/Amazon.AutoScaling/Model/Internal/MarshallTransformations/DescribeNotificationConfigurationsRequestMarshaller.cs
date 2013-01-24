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
    /// Describe Notification Configurations Request Marshaller
    /// </summary>       
    public class DescribeNotificationConfigurationsRequestMarshaller : IMarshaller<IRequest, DescribeNotificationConfigurationsRequest>
    {
        public IRequest Marshall(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest)
        {
            IRequest request = new DefaultRequest(describeNotificationConfigurationsRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribeNotificationConfigurations");
            request.Parameters.Add("Version", "2011-01-01");
            if (describeNotificationConfigurationsRequest != null)
            {
                List<string> autoScalingGroupNamesList = describeNotificationConfigurationsRequest.AutoScalingGroupNames;

                int autoScalingGroupNamesListIndex = 1;
                foreach (string autoScalingGroupNamesListValue in autoScalingGroupNamesList)
                { 
                    request.Parameters.Add("AutoScalingGroupNames.member." + autoScalingGroupNamesListIndex, StringUtils.FromString(autoScalingGroupNamesListValue));
                    autoScalingGroupNamesListIndex++;
                }
            }
            if (describeNotificationConfigurationsRequest != null && describeNotificationConfigurationsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeNotificationConfigurationsRequest.NextToken));
            }
            if (describeNotificationConfigurationsRequest != null && describeNotificationConfigurationsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeNotificationConfigurationsRequest.MaxRecords));
            }

            return request;
        }
    }
}
