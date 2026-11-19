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
    /// RequestSpotFleet Request Marshaller
    /// </summary>
    public partial class RequestSpotFleetRequestMarshaller : IMarshaller<IRequest, RequestSpotFleetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSpotFleetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RequestSpotFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RequestSpotFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetSpotFleetRequestConfig())
            {
                if (publicRequest.SpotFleetRequestConfig.IsSetAllocationStrategy())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".AllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.AllocationStrategy));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetClientToken())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".ClientToken", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ClientToken));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetContext())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".Context", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Context));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ExcessCapacityTerminationPolicy));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetFulfilledCapacity())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".FulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.FulfilledCapacity.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetIamFleetRole())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".IamFleetRole", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.IamFleetRole));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetInstanceInterruptionBehavior())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.InstanceInterruptionBehavior));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetInstancePoolsToUseCount())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.InstancePoolsToUseCount.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetLaunchSpecifications())
                {
                    if (publicRequest.SpotFleetRequestConfig.LaunchSpecifications.Count == 0)
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.SpotFleetRequestConfig.LaunchSpecifications)
                        {
                            if (item1.IsSetAddressingType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".AddressingType", StringUtils.FromString(item1.AddressingType));
                            }
                            if (item1.IsSetBlockDeviceMappings())
                            {
                                if (item1.BlockDeviceMappings.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.BlockDeviceMappings)
                                    {
                                        if (item2.IsSetDeviceName())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".DeviceName", StringUtils.FromString(item2.DeviceName));
                                        }
                                        if (item2.IsSetEbs())
                                        {
                                            if (item2.Ebs.IsSetAvailabilityZone())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".AvailabilityZone", StringUtils.FromString(item2.Ebs.AvailabilityZone));
                                            }
                                            if (item2.Ebs.IsSetAvailabilityZoneId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".AvailabilityZoneId", StringUtils.FromString(item2.Ebs.AvailabilityZoneId));
                                            }
                                            if (item2.Ebs.IsSetDeleteOnTermination())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item2.Ebs.DeleteOnTermination.Value));
                                            }
                                            if (item2.Ebs.IsSetEbsCardIndex())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".EbsCardIndex", StringUtils.FromInt(item2.Ebs.EbsCardIndex.Value));
                                            }
                                            if (item2.Ebs.IsSetEncrypted())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item2.Ebs.Encrypted.Value));
                                            }
                                            if (item2.Ebs.IsSetIops())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Iops", StringUtils.FromInt(item2.Ebs.Iops.Value));
                                            }
                                            if (item2.Ebs.IsSetKmsKeyId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item2.Ebs.KmsKeyId));
                                            }
                                            if (item2.Ebs.IsSetOutpostArn())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".OutpostArn", StringUtils.FromString(item2.Ebs.OutpostArn));
                                            }
                                            if (item2.Ebs.IsSetSnapshotId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item2.Ebs.SnapshotId));
                                            }
                                            if (item2.Ebs.IsSetThroughput())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Throughput", StringUtils.FromInt(item2.Ebs.Throughput.Value));
                                            }
                                            if (item2.Ebs.IsSetVolumeInitializationRate())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".VolumeInitializationRate", StringUtils.FromInt(item2.Ebs.VolumeInitializationRate.Value));
                                            }
                                            if (item2.Ebs.IsSetVolumeSize())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item2.Ebs.VolumeSize.Value));
                                            }
                                            if (item2.Ebs.IsSetVolumeType())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".VolumeType", StringUtils.FromString(item2.Ebs.VolumeType));
                                            }
                                        }
                                        if (item2.IsSetNoDevice())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".NoDevice", StringUtils.FromString(item2.NoDevice));
                                        }
                                        if (item2.IsSetVirtualName())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".VirtualName", StringUtils.FromString(item2.VirtualName));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetEbsOptimized())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".EbsOptimized", StringUtils.FromBool(item1.EbsOptimized.Value));
                            }
                            if (item1.IsSetIamInstanceProfile())
                            {
                                if (item1.IamInstanceProfile.IsSetArn())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".IamInstanceProfile" + ".Arn", StringUtils.FromString(item1.IamInstanceProfile.Arn));
                                }
                                if (item1.IamInstanceProfile.IsSetName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".IamInstanceProfile" + ".Name", StringUtils.FromString(item1.IamInstanceProfile.Name));
                                }
                            }
                            if (item1.IsSetImageId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".ImageId", StringUtils.FromString(item1.ImageId));
                            }
                            if (item1.IsSetInstanceRequirements())
                            {
                                if (item1.InstanceRequirements.IsSetAcceleratorCount())
                                {
                                    if (item1.InstanceRequirements.AcceleratorCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.AcceleratorCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetAcceleratorManufacturers())
                                {
                                    if (item1.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturerSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.AcceleratorManufacturers)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturerSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetAcceleratorNames())
                                {
                                    if (item1.InstanceRequirements.AcceleratorNames.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorNameSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.AcceleratorNames)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorNameSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                {
                                    if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetAcceleratorTypes())
                                {
                                    if (item1.InstanceRequirements.AcceleratorTypes.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTypeSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.AcceleratorTypes)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTypeSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetAllowedInstanceTypes())
                                {
                                    if (item1.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceTypeSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.AllowedInstanceTypes)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceTypeSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetBareMetal())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item1.InstanceRequirements.BareMetal));
                                }
                                if (item1.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                {
                                    if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
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
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item1.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                {
                                                    if (item5.IsSetInstanceFamily())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet" + "." + index5 + ".InstanceFamily", StringUtils.FromString(item5.InstanceFamily));
                                                    }
                                                    index5++;
                                                }
                                            }
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetBurstablePerformance())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item1.InstanceRequirements.BurstablePerformance));
                                }
                                if (item1.InstanceRequirements.IsSetCpuManufacturers())
                                {
                                    if (item1.InstanceRequirements.CpuManufacturers.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturerSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.CpuManufacturers)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturerSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetExcludedInstanceTypes())
                                {
                                    if (item1.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.ExcludedInstanceTypes)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetInstanceGenerations())
                                {
                                    if (item1.InstanceRequirements.InstanceGenerations.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".InstanceGenerationSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.InstanceGenerations)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".InstanceGenerationSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetLocalStorage())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item1.InstanceRequirements.LocalStorage));
                                }
                                if (item1.InstanceRequirements.IsSetLocalStorageTypes())
                                {
                                    if (item1.InstanceRequirements.LocalStorageTypes.Count == 0)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".LocalStorageTypeSet", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.InstanceRequirements.LocalStorageTypes)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".LocalStorageTypeSet" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item1.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                }
                                if (item1.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                {
                                    if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetMemoryMiB())
                                {
                                    if (item1.InstanceRequirements.MemoryMiB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.MemoryMiB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                {
                                    if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetNetworkInterfaceCount())
                                {
                                    if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                }
                                if (item1.InstanceRequirements.IsSetRequireEncryptionInTransit())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(item1.InstanceRequirements.RequireEncryptionInTransit.Value));
                                }
                                if (item1.InstanceRequirements.IsSetRequireHibernateSupport())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item1.InstanceRequirements.RequireHibernateSupport.Value));
                                }
                                if (item1.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                }
                                if (item1.InstanceRequirements.IsSetTotalLocalStorageGB())
                                {
                                    if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                    }
                                }
                                if (item1.InstanceRequirements.IsSetVCpuCount())
                                {
                                    if (item1.InstanceRequirements.VCpuCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Max.Value));
                                    }
                                    if (item1.InstanceRequirements.VCpuCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Min.Value));
                                    }
                                }
                            }
                            if (item1.IsSetInstanceType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".InstanceType", StringUtils.FromString(item1.InstanceType));
                            }
                            if (item1.IsSetKernelId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".KernelId", StringUtils.FromString(item1.KernelId));
                            }
                            if (item1.IsSetKeyName())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".KeyName", StringUtils.FromString(item1.KeyName));
                            }
                            if (item1.IsSetMonitoring())
                            {
                                if (item1.Monitoring.IsSetEnabled())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".Monitoring" + ".Enabled", StringUtils.FromBool(item1.Monitoring.Enabled.Value));
                                }
                            }
                            if (item1.IsSetNetworkInterfaces())
                            {
                                if (item1.NetworkInterfaces.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.NetworkInterfaces)
                                    {
                                        if (item2.IsSetAssociateCarrierIpAddress())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".AssociateCarrierIpAddress", StringUtils.FromBool(item2.AssociateCarrierIpAddress.Value));
                                        }
                                        if (item2.IsSetAssociatePublicIpAddress())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".AssociatePublicIpAddress", StringUtils.FromBool(item2.AssociatePublicIpAddress.Value));
                                        }
                                        if (item2.IsSetConnectionTrackingSpecification())
                                        {
                                            if (item2.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".ConnectionTrackingSpecification" + ".TcpEstablishedTimeout", StringUtils.FromInt(item2.ConnectionTrackingSpecification.TcpEstablishedTimeout.Value));
                                            }
                                            if (item2.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".ConnectionTrackingSpecification" + ".UdpStreamTimeout", StringUtils.FromInt(item2.ConnectionTrackingSpecification.UdpStreamTimeout.Value));
                                            }
                                            if (item2.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".ConnectionTrackingSpecification" + ".UdpTimeout", StringUtils.FromInt(item2.ConnectionTrackingSpecification.UdpTimeout.Value));
                                            }
                                        }
                                        if (item2.IsSetDeleteOnTermination())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".DeleteOnTermination", StringUtils.FromBool(item2.DeleteOnTermination.Value));
                                        }
                                        if (item2.IsSetDescription())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Description", StringUtils.FromString(item2.Description));
                                        }
                                        if (item2.IsSetDeviceIndex())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".DeviceIndex", StringUtils.FromInt(item2.DeviceIndex.Value));
                                        }
                                        if (item2.IsSetEnaQueueCount())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".EnaQueueCount", StringUtils.FromInt(item2.EnaQueueCount.Value));
                                        }
                                        if (item2.IsSetEnaSrdSpecification())
                                        {
                                            if (item2.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".EnaSrdSpecification" + ".EnaSrdEnabled", StringUtils.FromBool(item2.EnaSrdSpecification.EnaSrdEnabled.Value));
                                            }
                                            if (item2.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                            {
                                                if (item2.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".EnaSrdSpecification" + ".EnaSrdUdpSpecification" + ".EnaSrdUdpEnabled", StringUtils.FromBool(item2.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled.Value));
                                                }
                                            }
                                        }
                                        if (item2.IsSetGroups())
                                        {
                                            if (item2.Groups.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".SecurityGroupId", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Groups)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".SecurityGroupId" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item2.IsSetInterfaceType())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".InterfaceType", StringUtils.FromString(item2.InterfaceType));
                                        }
                                        if (item2.IsSetIpv4PrefixCount())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv4PrefixCount", StringUtils.FromInt(item2.Ipv4PrefixCount.Value));
                                        }
                                        if (item2.IsSetIpv4Prefixes())
                                        {
                                            if (item2.Ipv4Prefixes.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv4Prefix", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Ipv4Prefixes)
                                                {
                                                    if (item3.IsSetIpv4Prefix())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv4Prefix" + "." + index3 + ".Ipv4Prefix", StringUtils.FromString(item3.Ipv4Prefix));
                                                    }
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item2.IsSetIpv6AddressCount())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6AddressCount", StringUtils.FromInt(item2.Ipv6AddressCount.Value));
                                        }
                                        if (item2.IsSetIpv6Addresses())
                                        {
                                            if (item2.Ipv6Addresses.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6Addresses", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Ipv6Addresses)
                                                {
                                                    if (item3.IsSetIpv6Address())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6Addresses" + "." + index3 + ".Ipv6Address", StringUtils.FromString(item3.Ipv6Address));
                                                    }
                                                    if (item3.IsSetIsPrimaryIpv6())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6Addresses" + "." + index3 + ".IsPrimaryIpv6", StringUtils.FromBool(item3.IsPrimaryIpv6.Value));
                                                    }
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item2.IsSetIpv6PrefixCount())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6PrefixCount", StringUtils.FromInt(item2.Ipv6PrefixCount.Value));
                                        }
                                        if (item2.IsSetIpv6Prefixes())
                                        {
                                            if (item2.Ipv6Prefixes.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6Prefix", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Ipv6Prefixes)
                                                {
                                                    if (item3.IsSetIpv6Prefix())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".Ipv6Prefix" + "." + index3 + ".Ipv6Prefix", StringUtils.FromString(item3.Ipv6Prefix));
                                                    }
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item2.IsSetNetworkCardIndex())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".NetworkCardIndex", StringUtils.FromInt(item2.NetworkCardIndex.Value));
                                        }
                                        if (item2.IsSetNetworkInterfaceId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".NetworkInterfaceId", StringUtils.FromString(item2.NetworkInterfaceId));
                                        }
                                        if (item2.IsSetPrimaryIpv6())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".PrimaryIpv6", StringUtils.FromBool(item2.PrimaryIpv6.Value));
                                        }
                                        if (item2.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".PrivateIpAddress", StringUtils.FromString(item2.PrivateIpAddress));
                                        }
                                        if (item2.IsSetPrivateIpAddresses())
                                        {
                                            if (item2.PrivateIpAddresses.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".PrivateIpAddresses", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.PrivateIpAddresses)
                                                {
                                                    if (item3.IsSetPrimary())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".PrivateIpAddresses" + "." + index3 + ".Primary", StringUtils.FromBool(item3.Primary.Value));
                                                    }
                                                    if (item3.IsSetPrivateIpAddress())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".PrivateIpAddresses" + "." + index3 + ".PrivateIpAddress", StringUtils.FromString(item3.PrivateIpAddress));
                                                    }
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item2.IsSetSecondaryPrivateIpAddressCount())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(item2.SecondaryPrivateIpAddressCount.Value));
                                        }
                                        if (item2.IsSetSubnetId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".NetworkInterfaceSet" + "." + index2 + ".SubnetId", StringUtils.FromString(item2.SubnetId));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPlacement())
                            {
                                if (item1.Placement.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".Placement" + ".AvailabilityZone", StringUtils.FromString(item1.Placement.AvailabilityZone));
                                }
                                if (item1.Placement.IsSetAvailabilityZoneId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".Placement" + ".AvailabilityZoneId", StringUtils.FromString(item1.Placement.AvailabilityZoneId));
                                }
                                if (item1.Placement.IsSetGroupName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".Placement" + ".GroupName", StringUtils.FromString(item1.Placement.GroupName));
                                }
                                if (item1.Placement.IsSetTenancy())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".Placement" + ".Tenancy", StringUtils.FromString(item1.Placement.Tenancy));
                                }
                            }
                            if (item1.IsSetRamdiskId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".RamdiskId", StringUtils.FromString(item1.RamdiskId));
                            }
                            if (item1.IsSetSecurityGroups())
                            {
                                if (item1.SecurityGroups.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".GroupSet", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.SecurityGroups)
                                    {
                                        if (item2.IsSetGroupId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".GroupSet" + "." + index2 + ".GroupId", StringUtils.FromString(item2.GroupId));
                                        }
                                        if (item2.IsSetGroupName())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".GroupSet" + "." + index2 + ".GroupName", StringUtils.FromString(item2.GroupName));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetSpotPrice())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".SpotPrice", StringUtils.FromString(item1.SpotPrice));
                            }
                            if (item1.IsSetSubnetId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                            }
                            if (item1.IsSetTagSpecifications())
                            {
                                if (item1.TagSpecifications.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".TagSpecificationSet", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.TagSpecifications)
                                    {
                                        if (item2.IsSetResourceType())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".TagSpecificationSet" + "." + index2 + ".ResourceType", StringUtils.FromString(item2.ResourceType));
                                        }
                                        if (item2.IsSetTags())
                                        {
                                            if (item2.Tags.Count == 0)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".TagSpecificationSet" + "." + index2 + ".Tag", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Tags)
                                                {
                                                    if (item3.IsSetKey())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".TagSpecificationSet" + "." + index2 + ".Tag" + "." + index3 + ".Key", StringUtils.FromString(item3.Key));
                                                    }
                                                    if (item3.IsSetValue())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".TagSpecificationSet" + "." + index2 + ".Tag" + "." + index3 + ".Value", StringUtils.FromString(item3.Value));
                                                    }
                                                    index3++;
                                                }
                                            }
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetUserData())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".UserData", StringUtils.FromString(item1.UserData));
                            }
                            if (item1.IsSetWeightedCapacity())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchSpecifications" + "." + index1 + ".WeightedCapacity", StringUtils.FromDouble(item1.WeightedCapacity.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetLaunchTemplateConfigs())
                {
                    if (publicRequest.SpotFleetRequestConfig.LaunchTemplateConfigs.Count == 0)
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.SpotFleetRequestConfig.LaunchTemplateConfigs)
                        {
                            if (item1.IsSetLaunchTemplateSpecification())
                            {
                                if (item1.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(item1.LaunchTemplateSpecification.LaunchTemplateId));
                                }
                                if (item1.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(item1.LaunchTemplateSpecification.LaunchTemplateName));
                                }
                                if (item1.LaunchTemplateSpecification.IsSetVersion())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(item1.LaunchTemplateSpecification.Version));
                                }
                            }
                            if (item1.IsSetOverrides())
                            {
                                if (item1.Overrides.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Overrides)
                                    {
                                        if (item2.IsSetAvailabilityZone())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".AvailabilityZone", StringUtils.FromString(item2.AvailabilityZone));
                                        }
                                        if (item2.IsSetAvailabilityZoneId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".AvailabilityZoneId", StringUtils.FromString(item2.AvailabilityZoneId));
                                        }
                                        if (item2.IsSetInstanceRequirements())
                                        {
                                            if (item2.InstanceRequirements.IsSetAcceleratorCount())
                                            {
                                                if (item2.InstanceRequirements.AcceleratorCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorCount.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.AcceleratorCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorCount.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetAcceleratorManufacturers())
                                            {
                                                if (item2.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorManufacturerSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.AcceleratorManufacturers)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorManufacturerSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetAcceleratorNames())
                                            {
                                                if (item2.InstanceRequirements.AcceleratorNames.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorNameSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.AcceleratorNames)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorNameSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                            {
                                                if (item2.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetAcceleratorTypes())
                                            {
                                                if (item2.InstanceRequirements.AcceleratorTypes.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTypeSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.AcceleratorTypes)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AcceleratorTypeSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetAllowedInstanceTypes())
                                            {
                                                if (item2.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AllowedInstanceTypeSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.AllowedInstanceTypes)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".AllowedInstanceTypeSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetBareMetal())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item2.InstanceRequirements.BareMetal));
                                            }
                                            if (item2.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                            {
                                                if (item2.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
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
                                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet", "");
                                                        }
                                                        else
                                                        {
                                                            int index6 = 1;
                                                            foreach (var item6 in item2.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                            {
                                                                if (item6.IsSetInstanceFamily())
                                                                {
                                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".ReferenceSet" + "." + index6 + ".InstanceFamily", StringUtils.FromString(item6.InstanceFamily));
                                                                }
                                                                index6++;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetBurstablePerformance())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item2.InstanceRequirements.BurstablePerformance));
                                            }
                                            if (item2.InstanceRequirements.IsSetCpuManufacturers())
                                            {
                                                if (item2.InstanceRequirements.CpuManufacturers.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".CpuManufacturerSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.CpuManufacturers)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".CpuManufacturerSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetExcludedInstanceTypes())
                                            {
                                                if (item2.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.ExcludedInstanceTypes)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".ExcludedInstanceTypeSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetInstanceGenerations())
                                            {
                                                if (item2.InstanceRequirements.InstanceGenerations.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".InstanceGenerationSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.InstanceGenerations)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".InstanceGenerationSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetLocalStorage())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item2.InstanceRequirements.LocalStorage));
                                            }
                                            if (item2.InstanceRequirements.IsSetLocalStorageTypes())
                                            {
                                                if (item2.InstanceRequirements.LocalStorageTypes.Count == 0)
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".LocalStorageTypeSet", "");
                                                }
                                                else
                                                {
                                                    int index4 = 1;
                                                    foreach (var item4 in item2.InstanceRequirements.LocalStorageTypes)
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".LocalStorageTypeSet" + "." + index4, StringUtils.FromString(item4));
                                                        index4++;
                                                    }
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item2.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                            }
                                            if (item2.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                            {
                                                if (item2.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetMemoryMiB())
                                            {
                                                if (item2.InstanceRequirements.MemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.MemoryMiB.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.MemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.MemoryMiB.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                            {
                                                if (item2.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetNetworkInterfaceCount())
                                            {
                                                if (item2.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item2.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                            }
                                            if (item2.InstanceRequirements.IsSetRequireEncryptionInTransit())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(item2.InstanceRequirements.RequireEncryptionInTransit.Value));
                                            }
                                            if (item2.InstanceRequirements.IsSetRequireHibernateSupport())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item2.InstanceRequirements.RequireHibernateSupport.Value));
                                            }
                                            if (item2.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item2.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                            }
                                            if (item2.InstanceRequirements.IsSetTotalLocalStorageGB())
                                            {
                                                if (item2.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item2.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item2.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                                }
                                            }
                                            if (item2.InstanceRequirements.IsSetVCpuCount())
                                            {
                                                if (item2.InstanceRequirements.VCpuCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item2.InstanceRequirements.VCpuCount.Max.Value));
                                                }
                                                if (item2.InstanceRequirements.VCpuCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item2.InstanceRequirements.VCpuCount.Min.Value));
                                                }
                                            }
                                        }
                                        if (item2.IsSetInstanceType())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".InstanceType", StringUtils.FromString(item2.InstanceType));
                                        }
                                        if (item2.IsSetPriority())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".Priority", StringUtils.FromDouble(item2.Priority.Value));
                                        }
                                        if (item2.IsSetSpotPrice())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".SpotPrice", StringUtils.FromString(item2.SpotPrice));
                                        }
                                        if (item2.IsSetSubnetId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".SubnetId", StringUtils.FromString(item2.SubnetId));
                                        }
                                        if (item2.IsSetWeightedCapacity())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".LaunchTemplateConfigs" + "." + index1 + ".Overrides" + "." + index2 + ".WeightedCapacity", StringUtils.FromDouble(item2.WeightedCapacity.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetLoadBalancersConfig())
                {
                    if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetClassicLoadBalancersConfig())
                    {
                        if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.IsSetClassicLoadBalancers())
                        {
                            if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.ClassicLoadBalancers.Count == 0)
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LoadBalancersConfig" + ".ClassicLoadBalancersConfig" + ".ClassicLoadBalancers", "");
                            }
                            else
                            {
                                int index3 = 1;
                                foreach (var item3 in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.ClassicLoadBalancers)
                                {
                                    if (item3.IsSetName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LoadBalancersConfig" + ".ClassicLoadBalancersConfig" + ".ClassicLoadBalancers" + "." + index3 + ".Name", StringUtils.FromString(item3.Name));
                                    }
                                    index3++;
                                }
                            }
                        }
                    }
                    if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetTargetGroupsConfig())
                    {
                        if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.IsSetTargetGroups())
                        {
                            if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.TargetGroups.Count == 0)
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".LoadBalancersConfig" + ".TargetGroupsConfig" + ".TargetGroups", "");
                            }
                            else
                            {
                                int index3 = 1;
                                foreach (var item3 in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.TargetGroups)
                                {
                                    if (item3.IsSetArn())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + ".LoadBalancersConfig" + ".TargetGroupsConfig" + ".TargetGroups" + "." + index3 + ".Arn", StringUtils.FromString(item3.Arn));
                                    }
                                    index3++;
                                }
                            }
                        }
                    }
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetOnDemandAllocationStrategy())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandAllocationStrategy));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetOnDemandFulfilledCapacity())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".OnDemandFulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.OnDemandFulfilledCapacity.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetOnDemandMaxTotalPrice())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".OnDemandMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandMaxTotalPrice));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetOnDemandTargetCapacity())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.OnDemandTargetCapacity.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetReplaceUnhealthyInstances())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.ReplaceUnhealthyInstances.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetSpotMaintenanceStrategies())
                {
                    if (publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.IsSetCapacityRebalance())
                    {
                        if (publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                        {
                            request.Parameters.Add("SpotFleetRequestConfig" + ".SpotMaintenanceStrategies" + ".CapacityRebalance" + ".ReplacementStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                        }
                        if (publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                        {
                            request.Parameters.Add("SpotFleetRequestConfig" + ".SpotMaintenanceStrategies" + ".CapacityRebalance" + ".TerminationDelay", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.TerminationDelay.Value));
                        }
                    }
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetSpotMaxTotalPrice())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".SpotMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaxTotalPrice));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetSpotPrice())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".SpotPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotPrice));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetTagSpecifications())
                {
                    if (publicRequest.SpotFleetRequestConfig.TagSpecifications.Count == 0)
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + ".TagSpecification", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.SpotFleetRequestConfig.TagSpecifications)
                        {
                            if (item1.IsSetResourceType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + ".TagSpecification" + "." + index1 + ".ResourceType", StringUtils.FromString(item1.ResourceType));
                            }
                            if (item1.IsSetTags())
                            {
                                if (item1.Tags.Count == 0)
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + ".TagSpecification" + "." + index1 + ".Tag", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Tags)
                                    {
                                        if (item2.IsSetKey())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".TagSpecification" + "." + index1 + ".Tag" + "." + index2 + ".Key", StringUtils.FromString(item2.Key));
                                        }
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + ".TagSpecification" + "." + index1 + ".Tag" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetTargetCapacity())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".TargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.TargetCapacity.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetTargetCapacityUnitType())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".TargetCapacityUnitType", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.TargetCapacityUnitType));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetTerminateInstancesWithExpiration())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.TerminateInstancesWithExpiration.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetType())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".Type", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Type));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetValidFrom())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".ValidFrom", Amazon.Runtime.Internal.Util.StringUtils.FromDateTimeToISO8601NoMs(publicRequest.SpotFleetRequestConfig.ValidFrom.Value));
                }
                if (publicRequest.SpotFleetRequestConfig.IsSetValidUntil())
                {
                    request.Parameters.Add("SpotFleetRequestConfig" + ".ValidUntil", Amazon.Runtime.Internal.Util.StringUtils.FromDateTimeToISO8601NoMs(publicRequest.SpotFleetRequestConfig.ValidUntil.Value));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RequestSpotFleetRequestMarshaller _instance = new();

        internal static RequestSpotFleetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RequestSpotFleetRequestMarshaller Instance => _instance;
    }
}
