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
    /// CreateCapacityReservationFleet Request Marshaller
    /// </summary>
    public partial class CreateCapacityReservationFleetRequestMarshaller : IMarshaller<IRequest, CreateCapacityReservationFleetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCapacityReservationFleetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCapacityReservationFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateCapacityReservationFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAllocationStrategy())
            {
                request.Parameters.Add("AllocationStrategy", StringUtils.FromString(publicRequest.AllocationStrategy));
            }
            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetAvailabilityZoneId())
            {
                request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEndDate())
            {
                request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate.Value));
            }
            if (publicRequest.IsSetInstanceMatchCriteria())
            {
                request.Parameters.Add("InstanceMatchCriteria", StringUtils.FromString(publicRequest.InstanceMatchCriteria));
            }
            if (publicRequest.IsSetInstanceRequirements())
            {
                if (publicRequest.InstanceRequirements.IsSetAcceleratorCount())
                {
                    if (publicRequest.InstanceRequirements.AcceleratorCount.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorCount.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.AcceleratorCount.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorCount.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetAcceleratorManufacturers())
                {
                    if (publicRequest.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorManufacturer", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.AcceleratorManufacturers)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".AcceleratorManufacturer" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetAcceleratorNames())
                {
                    if (publicRequest.InstanceRequirements.AcceleratorNames.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorName", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.AcceleratorNames)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".AcceleratorName" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                {
                    if (publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetAcceleratorTypes())
                {
                    if (publicRequest.InstanceRequirements.AcceleratorTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AcceleratorType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.AcceleratorTypes)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".AcceleratorType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetAllowedInstanceTypes())
                {
                    if (publicRequest.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".AllowedInstanceType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.AllowedInstanceTypes)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".AllowedInstanceType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetBareMetal())
                {
                    request.Parameters.Add("InstanceRequirements" + ".BareMetal", StringUtils.FromString(publicRequest.InstanceRequirements.BareMetal));
                }
                if (publicRequest.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                {
                    if (publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetBaselinePerformanceFactors())
                {
                    if (publicRequest.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                    {
                        if (publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                        {
                            if (publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                            {
                                request.Parameters.Add("InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                            }
                            else
                            {
                                int index3 = 1;
                                foreach (var item3 in publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                {
                                    if (item3.IsSetInstanceFamily())
                                    {
                                        request.Parameters.Add("InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + "." + index3 + ".InstanceFamily", StringUtils.FromString(item3.InstanceFamily));
                                    }
                                    index3++;
                                }
                            }
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetBurstablePerformance())
                {
                    request.Parameters.Add("InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(publicRequest.InstanceRequirements.BurstablePerformance));
                }
                if (publicRequest.InstanceRequirements.IsSetCpuManufacturers())
                {
                    if (publicRequest.InstanceRequirements.CpuManufacturers.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".CpuManufacturer", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.CpuManufacturers)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".CpuManufacturer" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetExcludedInstanceTypes())
                {
                    if (publicRequest.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".ExcludedInstanceType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.ExcludedInstanceTypes)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".ExcludedInstanceType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetInstanceGenerations())
                {
                    if (publicRequest.InstanceRequirements.InstanceGenerations.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".InstanceGeneration", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.InstanceGenerations)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".InstanceGeneration" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetLocalStorage())
                {
                    request.Parameters.Add("InstanceRequirements" + ".LocalStorage", StringUtils.FromString(publicRequest.InstanceRequirements.LocalStorage));
                }
                if (publicRequest.InstanceRequirements.IsSetLocalStorageTypes())
                {
                    if (publicRequest.InstanceRequirements.LocalStorageTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirements" + ".LocalStorageType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirements.LocalStorageTypes)
                        {
                            request.Parameters.Add("InstanceRequirements" + ".LocalStorageType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                {
                    request.Parameters.Add("InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                }
                if (publicRequest.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                {
                    if (publicRequest.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetMemoryMiB())
                {
                    if (publicRequest.InstanceRequirements.MemoryMiB.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.MemoryMiB.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.MemoryMiB.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.MemoryMiB.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetNetworkBandwidthGbps())
                {
                    if (publicRequest.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetNetworkInterfaceCount())
                {
                    if (publicRequest.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                {
                    request.Parameters.Add("InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                }
                if (publicRequest.InstanceRequirements.IsSetRequireEncryptionInTransit())
                {
                    request.Parameters.Add("InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(publicRequest.InstanceRequirements.RequireEncryptionInTransit.Value));
                }
                if (publicRequest.InstanceRequirements.IsSetRequireHibernateSupport())
                {
                    request.Parameters.Add("InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(publicRequest.InstanceRequirements.RequireHibernateSupport.Value));
                }
                if (publicRequest.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                {
                    request.Parameters.Add("InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                }
                if (publicRequest.InstanceRequirements.IsSetTotalLocalStorageGB())
                {
                    if (publicRequest.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                    }
                }
                if (publicRequest.InstanceRequirements.IsSetVCpuCount())
                {
                    if (publicRequest.InstanceRequirements.VCpuCount.IsSetMax())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirements.VCpuCount.Max.Value));
                    }
                    if (publicRequest.InstanceRequirements.VCpuCount.IsSetMin())
                    {
                        request.Parameters.Add("InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirements.VCpuCount.Min.Value));
                    }
                }
            }
            if (publicRequest.IsSetInstanceTypeSpecifications())
            {
                if (publicRequest.InstanceTypeSpecifications.Count == 0)
                {
                    request.Parameters.Add("InstanceTypeSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.InstanceTypeSpecifications)
                    {
                        if (item0.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".AvailabilityZone", StringUtils.FromString(item0.AvailabilityZone));
                        }
                        if (item0.IsSetAvailabilityZoneId())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".AvailabilityZoneId", StringUtils.FromString(item0.AvailabilityZoneId));
                        }
                        if (item0.IsSetEbsOptimized())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".EbsOptimized", StringUtils.FromBool(item0.EbsOptimized.Value));
                        }
                        if (item0.IsSetInstancePlatform())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".InstancePlatform", StringUtils.FromString(item0.InstancePlatform));
                        }
                        if (item0.IsSetInstanceType())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".InstanceType", StringUtils.FromString(item0.InstanceType));
                        }
                        if (item0.IsSetPriority())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".Priority", StringUtils.FromInt(item0.Priority.Value));
                        }
                        if (item0.IsSetWeight())
                        {
                            request.Parameters.Add("InstanceTypeSpecification" + "." + index0 + ".Weight", StringUtils.FromDouble(item0.Weight.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTenancy())
            {
                request.Parameters.Add("Tenancy", StringUtils.FromString(publicRequest.Tenancy));
            }
            if (publicRequest.IsSetTotalTargetCapacity())
            {
                request.Parameters.Add("TotalTargetCapacity", StringUtils.FromInt(publicRequest.TotalTargetCapacity.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateCapacityReservationFleetRequestMarshaller _instance = new();

        internal static CreateCapacityReservationFleetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCapacityReservationFleetRequestMarshaller Instance => _instance;
    }
}
