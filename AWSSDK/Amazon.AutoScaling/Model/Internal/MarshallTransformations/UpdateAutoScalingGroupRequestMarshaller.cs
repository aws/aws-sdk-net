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
    /// Update Auto Scaling Group Request Marshaller
    /// </summary>       
    public class UpdateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, UpdateAutoScalingGroupRequest>
    {
        public IRequest Marshall(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest)
        {
            IRequest request = new DefaultRequest(updateAutoScalingGroupRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "UpdateAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(updateAutoScalingGroupRequest.AutoScalingGroupName));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetLaunchConfigurationName())
            {
                request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(updateAutoScalingGroupRequest.LaunchConfigurationName));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetMinSize())
            {
                request.Parameters.Add("MinSize", StringUtils.FromInt(updateAutoScalingGroupRequest.MinSize));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetMaxSize())
            {
                request.Parameters.Add("MaxSize", StringUtils.FromInt(updateAutoScalingGroupRequest.MaxSize));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetDesiredCapacity())
            {
                request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(updateAutoScalingGroupRequest.DesiredCapacity));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetDefaultCooldown())
            {
                request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(updateAutoScalingGroupRequest.DefaultCooldown));
            }
            if (updateAutoScalingGroupRequest != null)
            {
                List<string> availabilityZonesList = updateAutoScalingGroupRequest.AvailabilityZones;

                int availabilityZonesListIndex = 1;
                foreach (string availabilityZonesListValue in availabilityZonesList)
                { 
                    request.Parameters.Add("AvailabilityZones.member." + availabilityZonesListIndex, StringUtils.FromString(availabilityZonesListValue));
                    availabilityZonesListIndex++;
                }
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetHealthCheckType())
            {
                request.Parameters.Add("HealthCheckType", StringUtils.FromString(updateAutoScalingGroupRequest.HealthCheckType));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetHealthCheckGracePeriod())
            {
                request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(updateAutoScalingGroupRequest.HealthCheckGracePeriod));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetPlacementGroup())
            {
                request.Parameters.Add("PlacementGroup", StringUtils.FromString(updateAutoScalingGroupRequest.PlacementGroup));
            }
            if (updateAutoScalingGroupRequest != null && updateAutoScalingGroupRequest.IsSetVPCZoneIdentifier())
            {
                request.Parameters.Add("VPCZoneIdentifier", StringUtils.FromString(updateAutoScalingGroupRequest.VPCZoneIdentifier));
            }
            if (updateAutoScalingGroupRequest != null)
            {
                List<string> terminationPoliciesList = updateAutoScalingGroupRequest.TerminationPolicies;

                int terminationPoliciesListIndex = 1;
                foreach (string terminationPoliciesListValue in terminationPoliciesList)
                { 
                    request.Parameters.Add("TerminationPolicies.member." + terminationPoliciesListIndex, StringUtils.FromString(terminationPoliciesListValue));
                    terminationPoliciesListIndex++;
                }
            }

            return request;
        }
    }
}
