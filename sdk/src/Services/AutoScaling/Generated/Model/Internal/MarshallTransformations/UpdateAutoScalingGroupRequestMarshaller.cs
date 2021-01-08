/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutoScalingGroup Request Marshaller
    /// </summary>       
    public class UpdateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, UpdateAutoScalingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutoScalingGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAutoScalingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "UpdateAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetAvailabilityZones())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetCapacityRebalance())
                {
                    request.Parameters.Add("CapacityRebalance", StringUtils.FromBool(publicRequest.CapacityRebalance));
                }
                if(publicRequest.IsSetDefaultCooldown())
                {
                    request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(publicRequest.DefaultCooldown));
                }
                if(publicRequest.IsSetDesiredCapacity())
                {
                    request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(publicRequest.DesiredCapacity));
                }
                if(publicRequest.IsSetHealthCheckGracePeriod())
                {
                    request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(publicRequest.HealthCheckGracePeriod));
                }
                if(publicRequest.IsSetHealthCheckType())
                {
                    request.Parameters.Add("HealthCheckType", StringUtils.FromString(publicRequest.HealthCheckType));
                }
                if(publicRequest.IsSetLaunchConfigurationName())
                {
                    request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(publicRequest.LaunchConfigurationName));
                }
                if(publicRequest.IsSetLaunchTemplate())
                {
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                    }
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                    }
                    if(publicRequest.LaunchTemplate.IsSetVersion())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                    }
                }
                if(publicRequest.IsSetMaxInstanceLifetime())
                {
                    request.Parameters.Add("MaxInstanceLifetime", StringUtils.FromInt(publicRequest.MaxInstanceLifetime));
                }
                if(publicRequest.IsSetMaxSize())
                {
                    request.Parameters.Add("MaxSize", StringUtils.FromInt(publicRequest.MaxSize));
                }
                if(publicRequest.IsSetMinSize())
                {
                    request.Parameters.Add("MinSize", StringUtils.FromInt(publicRequest.MinSize));
                }
                if(publicRequest.IsSetMixedInstancesPolicy())
                {
                    if(publicRequest.MixedInstancesPolicy.IsSetInstancesDistribution())
                    {
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandAllocationStrategy())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandAllocationStrategy));
                        }
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandBaseCapacity())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandBaseCapacity", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandBaseCapacity));
                        }
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandPercentageAboveBaseCapacity())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandPercentageAboveBaseCapacity", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandPercentageAboveBaseCapacity));
                        }
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotAllocationStrategy())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotAllocationStrategy", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotAllocationStrategy));
                        }
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotInstancePools())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotInstancePools", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotInstancePools));
                        }
                        if(publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotMaxPrice())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotMaxPrice", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotMaxPrice));
                        }
                    }
                    if(publicRequest.MixedInstancesPolicy.IsSetLaunchTemplate())
                    {
                        if(publicRequest.MixedInstancesPolicy.LaunchTemplate.IsSetLaunchTemplateSpecification())
                        {
                            if(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.Version));
                            }
                        }
                        if(publicRequest.MixedInstancesPolicy.LaunchTemplate.IsSetOverrides())
                        {
                            int publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex = 1;
                            foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValue in publicRequest.MixedInstancesPolicy.LaunchTemplate.Overrides)
                            {
                                if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceType));
                                }
                                if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.IsSetLaunchTemplateSpecification())
                                {
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.LaunchTemplateId));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.LaunchTemplateName));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetVersion())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.Version));
                                    }
                                }
                                if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "WeightedCapacity", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.WeightedCapacity));
                                }
                                publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex++;
                            }
                        }
                    }
                }
                if(publicRequest.IsSetNewInstancesProtectedFromScaleIn())
                {
                    request.Parameters.Add("NewInstancesProtectedFromScaleIn", StringUtils.FromBool(publicRequest.NewInstancesProtectedFromScaleIn));
                }
                if(publicRequest.IsSetPlacementGroup())
                {
                    request.Parameters.Add("PlacementGroup", StringUtils.FromString(publicRequest.PlacementGroup));
                }
                if(publicRequest.IsSetServiceLinkedRoleARN())
                {
                    request.Parameters.Add("ServiceLinkedRoleARN", StringUtils.FromString(publicRequest.ServiceLinkedRoleARN));
                }
                if(publicRequest.IsSetTerminationPolicies())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TerminationPolicies)
                    {
                        request.Parameters.Add("TerminationPolicies" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetVPCZoneIdentifier())
                {
                    request.Parameters.Add("VPCZoneIdentifier", StringUtils.FromString(publicRequest.VPCZoneIdentifier));
                }
            }
            return request;
        }
                    private static UpdateAutoScalingGroupRequestMarshaller _instance = new UpdateAutoScalingGroupRequestMarshaller();        

        internal static UpdateAutoScalingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAutoScalingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}