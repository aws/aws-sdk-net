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
    /// Put Scaling Policy Request Marshaller
    /// </summary>       
    public class PutScalingPolicyRequestMarshaller : IMarshaller<IRequest, PutScalingPolicyRequest>
    {
        public IRequest Marshall(PutScalingPolicyRequest putScalingPolicyRequest)
        {
            IRequest request = new DefaultRequest(putScalingPolicyRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "PutScalingPolicy");
            request.Parameters.Add("Version", "2011-01-01");
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(putScalingPolicyRequest.AutoScalingGroupName));
            }
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetPolicyName())
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(putScalingPolicyRequest.PolicyName));
            }
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetScalingAdjustment())
            {
                request.Parameters.Add("ScalingAdjustment", StringUtils.FromInt(putScalingPolicyRequest.ScalingAdjustment));
            }
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetAdjustmentType())
            {
                request.Parameters.Add("AdjustmentType", StringUtils.FromString(putScalingPolicyRequest.AdjustmentType));
            }
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetCooldown())
            {
                request.Parameters.Add("Cooldown", StringUtils.FromInt(putScalingPolicyRequest.Cooldown));
            }
            if (putScalingPolicyRequest != null && putScalingPolicyRequest.IsSetMinAdjustmentStep())
            {
                request.Parameters.Add("MinAdjustmentStep", StringUtils.FromInt(putScalingPolicyRequest.MinAdjustmentStep));
            }

            return request;
        }
    }
}
