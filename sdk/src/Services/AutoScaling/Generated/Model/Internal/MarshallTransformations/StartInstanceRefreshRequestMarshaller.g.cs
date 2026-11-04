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
    /// StartInstanceRefresh Request Marshaller
    /// </summary>
    public partial class StartInstanceRefreshRequestMarshaller : IMarshaller<IRequest, StartInstanceRefreshRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartInstanceRefreshRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartInstanceRefreshRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "StartInstanceRefresh");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetDesiredConfiguration())
            {
                if (publicRequest.DesiredConfiguration.IsSetLaunchTemplate())
                {
                    if (publicRequest.DesiredConfiguration.LaunchTemplate.IsSetLaunchTemplateId())
                    {
                        request.Parameters.Add("DesiredConfiguration" + ".LaunchTemplate" + ".LaunchTemplateId", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.LaunchTemplateId));
                    }
                    if (publicRequest.DesiredConfiguration.LaunchTemplate.IsSetLaunchTemplateName())
                    {
                        request.Parameters.Add("DesiredConfiguration" + ".LaunchTemplate" + ".LaunchTemplateName", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.LaunchTemplateName));
                    }
                    if (publicRequest.DesiredConfiguration.LaunchTemplate.IsSetVersion())
                    {
                        request.Parameters.Add("DesiredConfiguration" + ".LaunchTemplate" + ".Version", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.Version));
                    }
                }
                if (publicRequest.DesiredConfiguration.IsSetMixedInstancesPolicy())
                {
                    if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.IsSetInstancesDistribution())
                    {
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetDistributionSegments())
                        {
                            if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.DistributionSegments.Count == 0)
                            {
                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments", "");
                            }
                            else
                            {
                                int index3 = 1;
                                foreach (var item3 in publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.DistributionSegments)
                                {
                                    if (item3.IsSetTargetCapacityTypes())
                                    {
                                        if (item3.TargetCapacityTypes.Count == 0)
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments" + ".member" + "." + index3 + ".TargetCapacityTypes", "");
                                        }
                                        else
                                        {
                                            int index4 = 1;
                                            foreach (var item4 in item3.TargetCapacityTypes)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".DistributionSegments" + ".member" + "." + index3 + ".TargetCapacityTypes" + ".member" + "." + index4, StringUtils.FromString(item4));
                                                index4++;
                                            }
                                        }
                                    }
                                    index3++;
                                }
                            }
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandAllocationStrategy())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandAllocationStrategy));
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandBaseCapacity())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandBaseCapacity", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandBaseCapacity.Value));
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandPercentageAboveBaseCapacity())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".OnDemandPercentageAboveBaseCapacity", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandPercentageAboveBaseCapacity.Value));
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotAllocationStrategy())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotAllocationStrategy", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotAllocationStrategy));
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotInstancePools())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotInstancePools", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotInstancePools.Value));
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotMaxPrice())
                        {
                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".InstancesDistribution" + ".SpotMaxPrice", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotMaxPrice));
                        }
                    }
                    if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.IsSetLaunchTemplate())
                    {
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.IsSetLaunchTemplateSpecification())
                        {
                            if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.Version));
                            }
                        }
                        if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.IsSetOverrides())
                        {
                            if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.Overrides.Count == 0)
                            {
                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides", "");
                            }
                            else
                            {
                                int index3 = 1;
                                foreach (var item3 in publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.Overrides)
                                {
                                    if (item3.IsSetImageId())
                                    {
                                        request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".ImageId", StringUtils.FromString(item3.ImageId));
                                    }
                                    if (item3.IsSetInstanceRequirements())
                                    {
                                        if (item3.InstanceRequirements.IsSetAcceleratorCount())
                                        {
                                            if (item3.InstanceRequirements.AcceleratorCount.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.AcceleratorCount.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.AcceleratorCount.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.AcceleratorCount.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetAcceleratorManufacturers())
                                        {
                                            if (item3.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorManufacturers", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.AcceleratorManufacturers)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorManufacturers" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetAcceleratorNames())
                                        {
                                            if (item3.InstanceRequirements.AcceleratorNames.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorNames", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.AcceleratorNames)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorNames" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                        {
                                            if (item3.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetAcceleratorTypes())
                                        {
                                            if (item3.InstanceRequirements.AcceleratorTypes.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorTypes", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.AcceleratorTypes)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AcceleratorTypes" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetAllowedInstanceTypes())
                                        {
                                            if (item3.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AllowedInstanceTypes", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.AllowedInstanceTypes)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".AllowedInstanceTypes" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetBareMetal())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item3.InstanceRequirements.BareMetal));
                                        }
                                        if (item3.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                        {
                                            if (item3.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                        {
                                            if (item3.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                            {
                                                if (item3.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                                {
                                                    if (item3.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                    {
                                                        request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                                                    }
                                                    else
                                                    {
                                                        int index7 = 1;
                                                        foreach (var item7 in item3.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                        {
                                                            if (item7.IsSetInstanceFamily())
                                                            {
                                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + ".item" + "." + index7 + ".InstanceFamily", StringUtils.FromString(item7.InstanceFamily));
                                                            }
                                                            index7++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetBurstablePerformance())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item3.InstanceRequirements.BurstablePerformance));
                                        }
                                        if (item3.InstanceRequirements.IsSetCpuManufacturers())
                                        {
                                            if (item3.InstanceRequirements.CpuManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".CpuManufacturers", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.CpuManufacturers)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".CpuManufacturers" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetExcludedInstanceTypes())
                                        {
                                            if (item3.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".ExcludedInstanceTypes", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.ExcludedInstanceTypes)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".ExcludedInstanceTypes" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetInstanceGenerations())
                                        {
                                            if (item3.InstanceRequirements.InstanceGenerations.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".InstanceGenerations", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.InstanceGenerations)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".InstanceGenerations" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetLocalStorage())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item3.InstanceRequirements.LocalStorage));
                                        }
                                        if (item3.InstanceRequirements.IsSetLocalStorageTypes())
                                        {
                                            if (item3.InstanceRequirements.LocalStorageTypes.Count == 0)
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".LocalStorageTypes", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item3.InstanceRequirements.LocalStorageTypes)
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".LocalStorageTypes" + ".member" + "." + index5, StringUtils.FromString(item5));
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item3.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                        }
                                        if (item3.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                        {
                                            if (item3.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item3.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item3.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetMemoryMiB())
                                        {
                                            if (item3.InstanceRequirements.MemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.MemoryMiB.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.MemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.MemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                        {
                                            if (item3.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item3.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item3.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetNetworkInterfaceCount())
                                        {
                                            if (item3.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item3.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item3.InstanceRequirements.IsSetRequireHibernateSupport())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item3.InstanceRequirements.RequireHibernateSupport.Value));
                                        }
                                        if (item3.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item3.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item3.InstanceRequirements.IsSetTotalLocalStorageGB())
                                        {
                                            if (item3.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item3.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item3.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                            }
                                        }
                                        if (item3.InstanceRequirements.IsSetVCpuCount())
                                        {
                                            if (item3.InstanceRequirements.VCpuCount.IsSetMax())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item3.InstanceRequirements.VCpuCount.Max.Value));
                                            }
                                            if (item3.InstanceRequirements.VCpuCount.IsSetMin())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item3.InstanceRequirements.VCpuCount.Min.Value));
                                            }
                                        }
                                    }
                                    if (item3.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".InstanceType", StringUtils.FromString(item3.InstanceType));
                                    }
                                    if (item3.IsSetLaunchTemplateSpecification())
                                    {
                                        if (item3.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(item3.LaunchTemplateSpecification.LaunchTemplateId));
                                        }
                                        if (item3.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(item3.LaunchTemplateSpecification.LaunchTemplateName));
                                        }
                                        if (item3.LaunchTemplateSpecification.IsSetVersion())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(item3.LaunchTemplateSpecification.Version));
                                        }
                                    }
                                    if (item3.IsSetWeightedCapacity())
                                    {
                                        request.Parameters.Add("DesiredConfiguration" + ".MixedInstancesPolicy" + ".LaunchTemplate" + ".Overrides" + ".member" + "." + index3 + ".WeightedCapacity", StringUtils.FromString(item3.WeightedCapacity));
                                    }
                                    index3++;
                                }
                            }
                        }
                    }
                }
            }
            if (publicRequest.IsSetPreferences())
            {
                if (publicRequest.Preferences.IsSetAlarmSpecification())
                {
                    if (publicRequest.Preferences.AlarmSpecification.IsSetAlarms())
                    {
                        if (publicRequest.Preferences.AlarmSpecification.Alarms.Count == 0)
                        {
                            request.Parameters.Add("Preferences" + ".AlarmSpecification" + ".Alarms", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.Preferences.AlarmSpecification.Alarms)
                            {
                                request.Parameters.Add("Preferences" + ".AlarmSpecification" + ".Alarms" + ".member" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                }
                if (publicRequest.Preferences.IsSetAutoRollback())
                {
                    request.Parameters.Add("Preferences" + ".AutoRollback", StringUtils.FromBool(publicRequest.Preferences.AutoRollback.Value));
                }
                if (publicRequest.Preferences.IsSetBakeTime())
                {
                    request.Parameters.Add("Preferences" + ".BakeTime", StringUtils.FromInt(publicRequest.Preferences.BakeTime.Value));
                }
                if (publicRequest.Preferences.IsSetCheckpointDelay())
                {
                    request.Parameters.Add("Preferences" + ".CheckpointDelay", StringUtils.FromInt(publicRequest.Preferences.CheckpointDelay.Value));
                }
                if (publicRequest.Preferences.IsSetCheckpointPercentages())
                {
                    if (publicRequest.Preferences.CheckpointPercentages.Count == 0)
                    {
                        request.Parameters.Add("Preferences" + ".CheckpointPercentages", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Preferences.CheckpointPercentages)
                        {
                            request.Parameters.Add("Preferences" + ".CheckpointPercentages" + ".member" + "." + index1, StringUtils.FromInt(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Preferences.IsSetInstanceWarmup())
                {
                    request.Parameters.Add("Preferences" + ".InstanceWarmup", StringUtils.FromInt(publicRequest.Preferences.InstanceWarmup.Value));
                }
                if (publicRequest.Preferences.IsSetMaxHealthyPercentage())
                {
                    request.Parameters.Add("Preferences" + ".MaxHealthyPercentage", StringUtils.FromInt(publicRequest.Preferences.MaxHealthyPercentage.Value));
                }
                if (publicRequest.Preferences.IsSetMinHealthyPercentage())
                {
                    request.Parameters.Add("Preferences" + ".MinHealthyPercentage", StringUtils.FromInt(publicRequest.Preferences.MinHealthyPercentage.Value));
                }
                if (publicRequest.Preferences.IsSetScaleInProtectedInstances())
                {
                    request.Parameters.Add("Preferences" + ".ScaleInProtectedInstances", StringUtils.FromString(publicRequest.Preferences.ScaleInProtectedInstances));
                }
                if (publicRequest.Preferences.IsSetSkipMatching())
                {
                    request.Parameters.Add("Preferences" + ".SkipMatching", StringUtils.FromBool(publicRequest.Preferences.SkipMatching.Value));
                }
                if (publicRequest.Preferences.IsSetStandbyInstances())
                {
                    request.Parameters.Add("Preferences" + ".StandbyInstances", StringUtils.FromString(publicRequest.Preferences.StandbyInstances));
                }
            }
            if (publicRequest.IsSetStrategy())
            {
                request.Parameters.Add("Strategy", StringUtils.FromString(publicRequest.Strategy));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly StartInstanceRefreshRequestMarshaller _instance = new();

        internal static StartInstanceRefreshRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartInstanceRefreshRequestMarshaller Instance => _instance;
    }
}
