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
    /// Terminate Instance In Auto Scaling Group Request Marshaller
    /// </summary>       
    public class TerminateInstanceInAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, TerminateInstanceInAutoScalingGroupRequest>
    {
        public IRequest Marshall(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest)
        {
            IRequest request = new DefaultRequest(terminateInstanceInAutoScalingGroupRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "TerminateInstanceInAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");
            if (terminateInstanceInAutoScalingGroupRequest != null && terminateInstanceInAutoScalingGroupRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(terminateInstanceInAutoScalingGroupRequest.InstanceId));
            }
            if (terminateInstanceInAutoScalingGroupRequest != null && terminateInstanceInAutoScalingGroupRequest.IsSetShouldDecrementDesiredCapacity())
            {
                request.Parameters.Add("ShouldDecrementDesiredCapacity", StringUtils.FromBool(terminateInstanceInAutoScalingGroupRequest.ShouldDecrementDesiredCapacity));
            }

            return request;
        }
    }
}
