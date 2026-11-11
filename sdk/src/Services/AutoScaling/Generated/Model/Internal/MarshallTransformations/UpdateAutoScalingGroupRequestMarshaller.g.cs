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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutoScalingGroup Request Marshaller
    /// </summary>
    public partial class UpdateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, UpdateAutoScalingGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutoScalingGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAutoScalingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UpdateAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetAvailabilityZoneDistribution())
            {
                if (publicRequest.AvailabilityZoneDistribution.IsSetCapacityDistributionStrategy())
                {
                    request.Parameters.Add("AvailabilityZoneDistribution" + ".CapacityDistributionStrategy", StringUtils.FromString(publicRequest.AvailabilityZoneDistribution.CapacityDistributionStrategy));
                }
            }
            if (publicRequest.IsSetAvailabilityZoneIds())
            {
                if (publicRequest.AvailabilityZoneIds.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZoneIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZoneIds)
                    {
                        request.Parameters.Add("AvailabilityZoneIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAvailabilityZoneImpairmentPolicy())
            {
                if (publicRequest.AvailabilityZoneImpairmentPolicy.IsSetImpairedZoneHealthCheckBehavior())
                {
                    request.Parameters.Add("AvailabilityZoneImpairmentPolicy" + ".ImpairedZoneHealthCheckBehavior", StringUtils.FromString(publicRequest.AvailabilityZoneImpairmentPolicy.ImpairedZoneHealthCheckBehavior));
                }
                if (publicRequest.AvailabilityZoneImpairmentPolicy.IsSetZonalShiftEnabled())
                {
                    request.Parameters.Add("AvailabilityZoneImpairmentPolicy" + ".ZonalShiftEnabled", StringUtils.FromBool(publicRequest.AvailabilityZoneImpairmentPolicy.ZonalShiftEnabled.Value));
                }
            }
            if (publicRequest.IsSetAvailabilityZones())
            {
                if (publicRequest.AvailabilityZones.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZones", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCapacityRebalance())
            {
                request.Parameters.Add("CapacityRebalance", StringUtils.FromBool(publicRequest.CapacityRebalance.Value));
            }
            if (publicRequest.IsSetCapacityReservationSpecification())
            {
                if (publicRequest.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                {
                    request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationPreference", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationPreference));
                }
                if (publicRequest.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                {
                    if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationIds())
                    {
                        if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationIds.Count == 0)
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationIds", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationIds)
                            {
                                request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationIds" + ".member" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArns())
                    {
                        if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArns.Count == 0)
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArns", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArns)
                            {
                                request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArns" + ".member" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                }
            }
            if (publicRequest.IsSetContext())
            {
                request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
            }
            if (publicRequest.IsSetDefaultCooldown())
            {
                request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(publicRequest.DefaultCooldown.Value));
            }
            if (publicRequest.IsSetDefaultInstanceWarmup())
            {
                request.Parameters.Add("DefaultInstanceWarmup", StringUtils.FromInt(publicRequest.DefaultInstanceWarmup.Value));
            }
            if (publicRequest.IsSetDeletionProtection())
            {
                request.Parameters.Add("DeletionProtection", StringUtils.FromString(publicRequest.DeletionProtection));
            }
            if (publicRequest.IsSetDesiredCapacity())
            {
                request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(publicRequest.DesiredCapacity.Value));
            }
            if (publicRequest.IsSetDesiredCapacityType())
            {
                request.Parameters.Add("DesiredCapacityType", StringUtils.FromString(publicRequest.DesiredCapacityType));
            }
            if (publicRequest.IsSetHealthCheckGracePeriod())
            {
                request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(publicRequest.HealthCheckGracePeriod.Value));
            }
            if (publicRequest.IsSetHealthCheckType())
            {
                request.Parameters.Add("HealthCheckType", StringUtils.FromString(publicRequest.HealthCheckType));
            }
            if (publicRequest.IsSetInstanceLifecyclePolicy())
            {
                if (publicRequest.InstanceLifecyclePolicy.IsSetRetentionTriggers())
                {
                    if (publicRequest.InstanceLifecyclePolicy.RetentionTriggers.IsSetTerminateHookAbandon())
                    {
                        request.Parameters.Add("InstanceLifecyclePolicy" + ".RetentionTriggers" + ".TerminateHookAbandon", StringUtils.FromString(publicRequest.InstanceLifecyclePolicy.RetentionTriggers.TerminateHookAbandon));
                    }
                }
            }
            if (publicRequest.IsSetInstanceMaintenancePolicy())
            {
                if (publicRequest.InstanceMaintenancePolicy.IsSetMaxHealthyPercentage())
                {
                    request.Parameters.Add("InstanceMaintenancePolicy" + ".MaxHealthyPercentage", StringUtils.FromInt(publicRequest.InstanceMaintenancePolicy.MaxHealthyPercentage.Value));
                }
                if (publicRequest.InstanceMaintenancePolicy.IsSetMinHealthyPercentage())
                {
                    request.Parameters.Add("InstanceMaintenancePolicy" + ".MinHealthyPercentage", StringUtils.FromInt(publicRequest.InstanceMaintenancePolicy.MinHealthyPercentage.Value));
                }
            }
            if (publicRequest.IsSetLaunchConfigurationName())
            {
                request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(publicRequest.LaunchConfigurationName));
            }
            if (publicRequest.IsSetLaunchTemplate())
            {
                if (publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                {
                    request.Parameters.Add("LaunchTemplate" + ".LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                }
                if (publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                {
                    request.Parameters.Add("LaunchTemplate" + ".LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                }
                if (publicRequest.LaunchTemplate.IsSetVersion())
                {
                    request.Parameters.Add("LaunchTemplate" + ".Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                }
            }
            if (publicRequest.IsSetMaxInstanceLifetime())
            {
                request.Parameters.Add("MaxInstanceLifetime", StringUtils.FromInt(publicRequest.MaxInstanceLifetime.Value));
            }
            if (publicRequest.IsSetMaxSize())
            {
                request.Parameters.Add("MaxSize", StringUtils.FromInt(publicRequest.MaxSize.Value));
            }
            if (publicRequest.IsSetMinSize())
            {
                request.Parameters.Add("MinSize", StringUtils.FromInt(publicRequest.MinSize.Value));
            }
            if (publicRequest.IsSetMixedInstancesPolicy())
            {
                if (publicRequest.MixedInstancesPolicy.IsSetInstancesDistribution())
                {
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetDistributionSegments())
                    {
                        if (publicRequest.MixedInstancesPolicy.InstancesDistribution.DistributionSegments.Count == 0)
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.MixedInstancesPolicy.InstancesDistribution.DistributionSegments)
                            {
                                if (item2.IsSetTargetCapacityTypes())
                                {
                                    if (item2.TargetCapacityTypes.Count == 0)
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments" + ".member" + "." + index2 + ".TargetCapacityTypes", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item2.TargetCapacityTypes)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments" + ".member" + "." + index2 + ".TargetCapacityTypes" + ".member" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandAllocationStrategy())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandAllocationStrategy));
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandBaseCapacity())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandBaseCapacity", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandBaseCapacity.Value));
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandPercentageAboveBaseCapacity())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandPercentageAboveBaseCapacity", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.OnDemandPercentageAboveBaseCapacity.Value));
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotAllocationStrategy())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotAllocationStrategy", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotAllocationStrategy));
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotInstancePools())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotInstancePools", StringUtils.FromInt(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotInstancePools.Value));
                    }
                    if (publicRequest.MixedInstancesPolicy.InstancesDistribution.IsSetSpotMaxPrice())
                    {
                        request.Parameters.Add("MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotMaxPrice", StringUtils.FromString(publicRequest.MixedInstancesPolicy.InstancesDistribution.SpotMaxPrice));
                    }
                }
                if (publicRequest.MixedInstancesPolicy.IsSetLaunchTemplate())
                {
                    if (publicRequest.MixedInstancesPolicy.LaunchTemplate.IsSetLaunchTemplateSpecification())
                    {
                        if (publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateId));
                        }
                        if (publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateName));
                        }
                        if (publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetVersion())
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(publicRequest.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.Version));
                        }
                    }
                    if (publicRequest.MixedInstancesPolicy.LaunchTemplate.IsSetOverrides())
                    {
                        if (publicRequest.MixedInstancesPolicy.LaunchTemplate.Overrides.Count == 0)
                        {
                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.MixedInstancesPolicy.LaunchTemplate.Overrides)
                            {
                                if (item2.IsSetImageId())
                                {
                                    request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".ImageId", StringUtils.FromString(item2.ImageId));
                                }
                                if (item2.IsSetInstanceRequirements())
                                {
                                    if (item2.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if (item2.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorCount.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorCount.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        if (item2.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorManufacturers", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.AcceleratorManufacturers)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorManufacturers" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        if (item2.InstanceRequirements.AcceleratorNames.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorNames", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.AcceleratorNames)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorNames" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if (item2.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        if (item2.InstanceRequirements.AcceleratorTypes.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTypes", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.AcceleratorTypes)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTypes" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetAllowedInstanceTypes())
                                    {
                                        if (item2.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AllowedInstanceTypes", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.AllowedInstanceTypes)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".AllowedInstanceTypes" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item2.InstanceRequirements.BareMetal));
                                    }
                                    if (item2.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if (item2.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                    {
                                        if (item2.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                        {
                                            if (item2.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                            {
                                                if (item2.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                {
                                                    request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                                                }
                                                else
                                                {
                                                    int index6 = 1;
                                                    foreach (var item6 in item2.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                    {
                                                        if (item6.IsSetInstanceFamily())
                                                        {
                                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + ".item" + "." + index6 + ".InstanceFamily", StringUtils.FromString(item6.InstanceFamily));
                                                        }
                                                        index6++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item2.InstanceRequirements.BurstablePerformance));
                                    }
                                    if (item2.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        if (item2.InstanceRequirements.CpuManufacturers.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".CpuManufacturers", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.CpuManufacturers)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".CpuManufacturers" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        if (item2.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".ExcludedInstanceTypes", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.ExcludedInstanceTypes)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".ExcludedInstanceTypes" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        if (item2.InstanceRequirements.InstanceGenerations.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".InstanceGenerations", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.InstanceGenerations)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".InstanceGenerations" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item2.InstanceRequirements.LocalStorage));
                                    }
                                    if (item2.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        if (item2.InstanceRequirements.LocalStorageTypes.Count == 0)
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".LocalStorageTypes", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item2.InstanceRequirements.LocalStorageTypes)
                                            {
                                                request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".LocalStorageTypes" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item2.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                    }
                                    if (item2.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if (item2.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if (item2.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.MemoryMiB.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.MemoryMiB.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                    {
                                        if (item2.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if (item2.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item2.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                    }
                                    if (item2.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item2.InstanceRequirements.RequireHibernateSupport.Value));
                                    }
                                    if (item2.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item2.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                    }
                                    if (item2.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if (item2.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                        }
                                    }
                                    if (item2.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if (item2.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.VCpuCount.Max.Value));
                                        }
                                        if (item2.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.VCpuCount.Min.Value));
                                        }
                                    }
                                }
                                if (item2.IsSetInstanceType())
                                {
                                    request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".InstanceType", StringUtils.FromString(item2.InstanceType));
                                }
                                if (item2.IsSetLaunchTemplateSpecification())
                                {
                                    if (item2.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(item2.LaunchTemplateSpecification.LaunchTemplateId));
                                    }
                                    if (item2.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(item2.LaunchTemplateSpecification.LaunchTemplateName));
                                    }
                                    if (item2.LaunchTemplateSpecification.IsSetVersion())
                                    {
                                        request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(item2.LaunchTemplateSpecification.Version));
                                    }
                                }
                                if (item2.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index2 + ".WeightedCapacity", StringUtils.FromString(item2.WeightedCapacity));
                                }
                                index2++;
                            }
                        }
                    }
                }
            }
            if (publicRequest.IsSetNewInstancesProtectedFromScaleIn())
            {
                request.Parameters.Add("NewInstancesProtectedFromScaleIn", StringUtils.FromBool(publicRequest.NewInstancesProtectedFromScaleIn.Value));
            }
            if (publicRequest.IsSetPlacementGroup())
            {
                request.Parameters.Add("PlacementGroup", StringUtils.FromString(publicRequest.PlacementGroup));
            }
            if (publicRequest.IsSetServiceLinkedRoleARN())
            {
                request.Parameters.Add("ServiceLinkedRoleARN", StringUtils.FromString(publicRequest.ServiceLinkedRoleARN));
            }
            if (publicRequest.IsSetSkipZonalShiftValidation())
            {
                request.Parameters.Add("SkipZonalShiftValidation", StringUtils.FromBool(publicRequest.SkipZonalShiftValidation.Value));
            }
            if (publicRequest.IsSetTerminationPolicies())
            {
                if (publicRequest.TerminationPolicies.Count == 0)
                {
                    request.Parameters.Add("TerminationPolicies", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TerminationPolicies)
                    {
                        request.Parameters.Add("TerminationPolicies" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetVPCZoneIdentifier())
            {
                request.Parameters.Add("VPCZoneIdentifier", StringUtils.FromString(publicRequest.VPCZoneIdentifier));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UpdateAutoScalingGroupRequestMarshaller _instance = new();

        internal static UpdateAutoScalingGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAutoScalingGroupRequestMarshaller Instance => _instance;
    }
}
