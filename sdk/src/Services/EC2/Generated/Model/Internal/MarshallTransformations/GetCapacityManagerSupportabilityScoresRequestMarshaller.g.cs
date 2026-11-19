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
    /// GetCapacityManagerSupportabilityScores Request Marshaller
    /// </summary>
    public partial class GetCapacityManagerSupportabilityScoresRequestMarshaller : IMarshaller<IRequest, GetCapacityManagerSupportabilityScoresRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCapacityManagerSupportabilityScoresRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCapacityManagerSupportabilityScoresRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetCapacityManagerSupportabilityScores");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCapacityAmount())
            {
                request.Parameters.Add("CapacityAmount", StringUtils.FromInt(publicRequest.CapacityAmount.Value));
            }
            if (publicRequest.IsSetCapacityAvailabilityZoneIds())
            {
                if (publicRequest.CapacityAvailabilityZoneIds.Count == 0)
                {
                    request.Parameters.Add("CapacityAvailabilityZoneId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.CapacityAvailabilityZoneIds)
                    {
                        request.Parameters.Add("CapacityAvailabilityZoneId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCapacityUnit())
            {
                request.Parameters.Add("CapacityUnit", StringUtils.FromString(publicRequest.CapacityUnit));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceRequirementsWithMetadata())
            {
                if (publicRequest.InstanceRequirementsWithMetadata.IsSetArchitectureTypes())
                {
                    if (publicRequest.InstanceRequirementsWithMetadata.ArchitectureTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".ArchitectureType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirementsWithMetadata.ArchitectureTypes)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".ArchitectureType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceRequirementsWithMetadata.IsSetInstanceRequirements())
                {
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorCount())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorManufacturers())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorManufacturer", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorManufacturers)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorManufacturer" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorNames())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorNames.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorName", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorNames)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorName" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTypes.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTypes)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AcceleratorType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAllowedInstanceTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AllowedInstanceType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AllowedInstanceTypes)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".AllowedInstanceType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBareMetal())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BareMetal));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBaselinePerformanceFactors())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                            {
                                if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                {
                                    request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                                }
                                else
                                {
                                    int index4 = 1;
                                    foreach (var item4 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                    {
                                        if (item4.IsSetInstanceFamily())
                                        {
                                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + "." + index4 + ".InstanceFamily", StringUtils.FromString(item4.InstanceFamily));
                                        }
                                        index4++;
                                    }
                                }
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBurstablePerformance())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BurstablePerformance));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetCpuManufacturers())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.CpuManufacturers.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".CpuManufacturer", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.CpuManufacturers)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".CpuManufacturer" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetExcludedInstanceTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".ExcludedInstanceType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.ExcludedInstanceTypes)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".ExcludedInstanceType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetInstanceGenerations())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.InstanceGenerations.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".InstanceGeneration", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.InstanceGenerations)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".InstanceGeneration" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetLocalStorage())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorage));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetLocalStorageTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorageTypes.Count == 0)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".LocalStorageType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorageTypes)
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".LocalStorageType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMemoryMiB())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetNetworkBandwidthGbps())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetNetworkInterfaceCount())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetRequireEncryptionInTransit())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.RequireEncryptionInTransit.Value));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetRequireHibernateSupport())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.RequireHibernateSupport.Value));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetTotalLocalStorageGB())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                        }
                    }
                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetVCpuCount())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.Max.Value));
                        }
                        if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.Min.Value));
                        }
                    }
                }
                if (publicRequest.InstanceRequirementsWithMetadata.IsSetVirtualizationTypes())
                {
                    if (publicRequest.InstanceRequirementsWithMetadata.VirtualizationTypes.Count == 0)
                    {
                        request.Parameters.Add("InstanceRequirementsWithMetadata" + ".VirtualizationType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceRequirementsWithMetadata.VirtualizationTypes)
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + ".VirtualizationType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetInstanceTypes())
            {
                if (publicRequest.InstanceTypes.Count == 0)
                {
                    request.Parameters.Add("InstanceType", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.InstanceTypes)
                    {
                        request.Parameters.Add("InstanceType" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMarketType())
            {
                request.Parameters.Add("MarketType", StringUtils.FromString(publicRequest.MarketType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetCapacityManagerSupportabilityScoresRequestMarshaller _instance = new();

        internal static GetCapacityManagerSupportabilityScoresRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCapacityManagerSupportabilityScoresRequestMarshaller Instance => _instance;
    }
}
