/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model.Transform
{
    /// <summary>
    /// Create Auto Scaling Group Request Marshaller
    /// </summary>       
    public class CreateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest<CreateAutoScalingGroupRequest>, CreateAutoScalingGroupRequest> 
    {

        public IRequest<CreateAutoScalingGroupRequest> Marshall(CreateAutoScalingGroupRequest createAutoScalingGroupRequest) 
        {
            IRequest<CreateAutoScalingGroupRequest> request = new DefaultRequest<CreateAutoScalingGroupRequest>(createAutoScalingGroupRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "CreateAutoScalingGroup");
            request.Parameters.Add("Version", "2010-08-01");
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetAutoScalingGroupName()) 
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(createAutoScalingGroupRequest.AutoScalingGroupName));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetLaunchConfigurationName()) 
            {
                request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(createAutoScalingGroupRequest.LaunchConfigurationName));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetMinSize()) 
            {
                request.Parameters.Add("MinSize", StringUtils.FromInt(createAutoScalingGroupRequest.MinSize));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetMaxSize()) 
            {
                request.Parameters.Add("MaxSize", StringUtils.FromInt(createAutoScalingGroupRequest.MaxSize));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetDesiredCapacity()) 
            {
                request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(createAutoScalingGroupRequest.DesiredCapacity));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetDefaultCooldown()) 
            {
                request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(createAutoScalingGroupRequest.DefaultCooldown));
            }
            if (createAutoScalingGroupRequest != null) 
            {
                List<string> availabilityZonesList = createAutoScalingGroupRequest.AvailabilityZones;
                int availabilityZonesListIndex = 1;
                foreach (string availabilityZonesListValue in availabilityZonesList) 
                { 
                    request.Parameters.Add("AvailabilityZones.member." + availabilityZonesListIndex, StringUtils.FromString(availabilityZonesListValue));
                    availabilityZonesListIndex++;
                }
            }
            if (createAutoScalingGroupRequest != null) 
            {
                List<string> loadBalancerNamesList = createAutoScalingGroupRequest.LoadBalancerNames;
                int loadBalancerNamesListIndex = 1;
                foreach (string loadBalancerNamesListValue in loadBalancerNamesList) 
                { 
                    request.Parameters.Add("LoadBalancerNames.member." + loadBalancerNamesListIndex, StringUtils.FromString(loadBalancerNamesListValue));
                    loadBalancerNamesListIndex++;
                }
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetHealthCheckType()) 
            {
                request.Parameters.Add("HealthCheckType", StringUtils.FromString(createAutoScalingGroupRequest.HealthCheckType));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetHealthCheckGracePeriod()) 
            {
                request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(createAutoScalingGroupRequest.HealthCheckGracePeriod));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetPlacementGroup()) 
            {
                request.Parameters.Add("PlacementGroup", StringUtils.FromString(createAutoScalingGroupRequest.PlacementGroup));
            }
            if (createAutoScalingGroupRequest != null && createAutoScalingGroupRequest.IsSetVPCZoneIdentifier()) 
            {
                request.Parameters.Add("VPCZoneIdentifier", StringUtils.FromString(createAutoScalingGroupRequest.VPCZoneIdentifier));
            }


            return request;
        }
    }
}
