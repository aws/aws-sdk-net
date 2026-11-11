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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifySpotFleetRequest Request Marshaller
    /// </summary>
    public partial class ModifySpotFleetRequestRequestMarshaller : IMarshaller<IRequest, ModifySpotFleetRequestRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySpotFleetRequestRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifySpotFleetRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifySpotFleetRequest");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetContext())
            {
                request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
            }
            if (publicRequest.IsSetExcessCapacityTerminationPolicy())
            {
                request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
            }
            if (publicRequest.IsSetLaunchTemplateConfigs())
            {
                if (publicRequest.LaunchTemplateConfigs.Count == 0)
                {
                    request.Parameters.Add("LaunchTemplateConfig", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LaunchTemplateConfigs)
                    {
                        if (item0.IsSetLaunchTemplateSpecification())
                        {
                            if (item0.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(item0.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if (item0.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(item0.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if (item0.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(item0.LaunchTemplateSpecification.Version));
                            }
                        }
                        if (item0.IsSetOverrides())
                        {
                            if (item0.Overrides.Count == 0)
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Overrides)
                                {
                                    if (item1.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".AvailabilityZone", StringUtils.FromString(item1.AvailabilityZone));
                                    }
                                    if (item1.IsSetAvailabilityZoneId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".AvailabilityZoneId", StringUtils.FromString(item1.AvailabilityZoneId));
                                    }
                                    if (item1.IsSetInstanceRequirements())
                                    {
                                        if (item1.InstanceRequirements.IsSetAcceleratorCount())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.AcceleratorCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorManufacturers())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturerSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorManufacturers)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturerSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorNames())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorNames.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorNameSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorNames)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorNameSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorTypes())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTypeSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTypeSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAllowedInstanceTypes())
                                        {
                                            if (item1.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceTypeSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AllowedInstanceTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceTypeSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetBareMetal())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item1.InstanceRequirements.BareMetal));
                                        }
                                        if (item1.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                        {
                                            if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                        {
                                            if (item1.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                            {
                                                if (item1.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                                {
                                                    if (item1.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet", "");
                                                    }
                                                    else
                                                    {
                                                        int index5 = 1;
                                                        foreach (var item5 in item1.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                        {
                                                            if (item5.IsSetInstanceFamily())
                                                            {
                                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet" + "." + index5 + ".InstanceFamily", StringUtils.FromString(item5.InstanceFamily));
                                                            }
                                                            index5++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetBurstablePerformance())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item1.InstanceRequirements.BurstablePerformance));
                                        }
                                        if (item1.InstanceRequirements.IsSetCpuManufacturers())
                                        {
                                            if (item1.InstanceRequirements.CpuManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturerSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.CpuManufacturers)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturerSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetExcludedInstanceTypes())
                                        {
                                            if (item1.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.ExcludedInstanceTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetInstanceGenerations())
                                        {
                                            if (item1.InstanceRequirements.InstanceGenerations.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".InstanceGenerationSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.InstanceGenerations)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".InstanceGenerationSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetLocalStorage())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item1.InstanceRequirements.LocalStorage));
                                        }
                                        if (item1.InstanceRequirements.IsSetLocalStorageTypes())
                                        {
                                            if (item1.InstanceRequirements.LocalStorageTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorageTypeSet", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.LocalStorageTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorageTypeSet" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item1.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                        {
                                            if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetMemoryMiB())
                                        {
                                            if (item1.InstanceRequirements.MemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.MemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                        {
                                            if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetNetworkInterfaceCount())
                                        {
                                            if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetRequireEncryptionInTransit())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(item1.InstanceRequirements.RequireEncryptionInTransit.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetRequireHibernateSupport())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item1.InstanceRequirements.RequireHibernateSupport.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetTotalLocalStorageGB())
                                        {
                                            if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetVCpuCount())
                                        {
                                            if (item1.InstanceRequirements.VCpuCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.VCpuCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Min.Value));
                                            }
                                        }
                                    }
                                    if (item1.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceType", StringUtils.FromString(item1.InstanceType));
                                    }
                                    if (item1.IsSetPriority())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".Priority", StringUtils.FromDouble(item1.Priority.Value));
                                    }
                                    if (item1.IsSetSpotPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".SpotPrice", StringUtils.FromString(item1.SpotPrice));
                                    }
                                    if (item1.IsSetSubnetId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                                    }
                                    if (item1.IsSetWeightedCapacity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + index0 + ".Overrides" + "." + index1 + ".WeightedCapacity", StringUtils.FromDouble(item1.WeightedCapacity.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOnDemandTargetCapacity())
            {
                request.Parameters.Add("OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandTargetCapacity.Value));
            }
            if (publicRequest.IsSetSpotFleetRequestId())
            {
                request.Parameters.Add("SpotFleetRequestId", StringUtils.FromString(publicRequest.SpotFleetRequestId));
            }
            if (publicRequest.IsSetTargetCapacity())
            {
                request.Parameters.Add("TargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacity.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifySpotFleetRequestRequestMarshaller _instance = new();

        internal static ModifySpotFleetRequestRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifySpotFleetRequestRequestMarshaller Instance => _instance;
    }
}
