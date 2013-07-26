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
    /// Describe Auto Scaling Instances Request Marshaller
    /// </summary>       
    public class DescribeAutoScalingInstancesRequestMarshaller : IMarshaller<IRequest, DescribeAutoScalingInstancesRequest>
    {
        public IRequest Marshall(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest)
        {
            IRequest request = new DefaultRequest(describeAutoScalingInstancesRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DescribeAutoScalingInstances");
            request.Parameters.Add("Version", "2011-01-01");
            if (describeAutoScalingInstancesRequest != null)
            {
                List<string> instanceIdsList = describeAutoScalingInstancesRequest.InstanceIds;

                int instanceIdsListIndex = 1;
                foreach (string instanceIdsListValue in instanceIdsList)
                { 
                    request.Parameters.Add("InstanceIds.member." + instanceIdsListIndex, StringUtils.FromString(instanceIdsListValue));
                    instanceIdsListIndex++;
                }
            }
            if (describeAutoScalingInstancesRequest != null && describeAutoScalingInstancesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeAutoScalingInstancesRequest.MaxRecords));
            }
            if (describeAutoScalingInstancesRequest != null && describeAutoScalingInstancesRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeAutoScalingInstancesRequest.NextToken));
            }

            return request;
        }
    }
}
