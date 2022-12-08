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
    /// CreateAutoScalingGroup Request Marshaller
    /// </summary>       
    public class CreateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, CreateAutoScalingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoScalingGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutoScalingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "CreateAutoScalingGroup");
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
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
                }
                if(publicRequest.IsSetDefaultCooldown())
                {
                    request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(publicRequest.DefaultCooldown));
                }
                if(publicRequest.IsSetDefaultInstanceWarmup())
                {
                    request.Parameters.Add("DefaultInstanceWarmup", StringUtils.FromInt(publicRequest.DefaultInstanceWarmup));
                }
                if(publicRequest.IsSetDesiredCapacity())
                {
                    request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(publicRequest.DesiredCapacity));
                }
                if(publicRequest.IsSetDesiredCapacityType())
                {
                    request.Parameters.Add("DesiredCapacityType", StringUtils.FromString(publicRequest.DesiredCapacityType));
                }
                if(publicRequest.IsSetHealthCheckGracePeriod())
                {
                    request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(publicRequest.HealthCheckGracePeriod));
                }
                if(publicRequest.IsSetHealthCheckType())
                {
                    request.Parameters.Add("HealthCheckType", StringUtils.FromString(publicRequest.HealthCheckType));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
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
                if(publicRequest.IsSetLifecycleHookSpecificationList())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LifecycleHookSpecificationList)
                    {
                        if(publicRequestlistValue.IsSetDefaultResult())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DefaultResult", StringUtils.FromString(publicRequestlistValue.DefaultResult));
                        }
                        if(publicRequestlistValue.IsSetHeartbeatTimeout())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HeartbeatTimeout", StringUtils.FromInt(publicRequestlistValue.HeartbeatTimeout));
                        }
                        if(publicRequestlistValue.IsSetLifecycleHookName())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LifecycleHookName", StringUtils.FromString(publicRequestlistValue.LifecycleHookName));
                        }
                        if(publicRequestlistValue.IsSetLifecycleTransition())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LifecycleTransition", StringUtils.FromString(publicRequestlistValue.LifecycleTransition));
                        }
                        if(publicRequestlistValue.IsSetNotificationMetadata())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "NotificationMetadata", StringUtils.FromString(publicRequestlistValue.NotificationMetadata));
                        }
                        if(publicRequestlistValue.IsSetNotificationTargetARN())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "NotificationTargetARN", StringUtils.FromString(publicRequestlistValue.NotificationTargetARN));
                        }
                        if(publicRequestlistValue.IsSetRoleARN())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RoleARN", StringUtils.FromString(publicRequestlistValue.RoleARN));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetLoadBalancerNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LoadBalancerNames)
                    {
                        request.Parameters.Add("LoadBalancerNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                                if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.IsSetInstanceRequirements())
                                {
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorManufacturers)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturers" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorNames)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNames" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTypes)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypes" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AllowedInstanceTypes)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypes" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BareMetal));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BurstablePerformance));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.CpuManufacturers)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturers" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypes" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.InstanceGenerations)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerations" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.LocalStorage));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        int publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.LocalStorageTypes)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypes" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                            publicRequestMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.RequireHibernateSupport));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                        }
                                    }
                                    if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.Max));
                                        }
                                        if(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.Min));
                                        }
                                    }
                                }
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
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetPropagateAtLaunch())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PropagateAtLaunch", StringUtils.FromBool(publicRequestlistValue.PropagateAtLaunch));
                        }
                        if(publicRequestlistValue.IsSetResourceId())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceId", StringUtils.FromString(publicRequestlistValue.ResourceId));
                        }
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetGroupARNs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TargetGroupARNs)
                    {
                        request.Parameters.Add("TargetGroupARNs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
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
                if(publicRequest.IsSetTrafficSources())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TrafficSources)
                    {
                        if(publicRequestlistValue.IsSetIdentifier())
                        {
                            request.Parameters.Add("TrafficSources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Identifier", StringUtils.FromString(publicRequestlistValue.Identifier));
                        }
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
                    private static CreateAutoScalingGroupRequestMarshaller _instance = new CreateAutoScalingGroupRequestMarshaller();        

        internal static CreateAutoScalingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutoScalingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}