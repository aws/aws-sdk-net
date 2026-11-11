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
    /// CreateFleet Request Marshaller
    /// </summary>
    public partial class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetContext())
            {
                request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetExcessCapacityTerminationPolicy())
            {
                request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
            }
            if (publicRequest.IsSetLaunchTemplateConfigs())
            {
                if (publicRequest.LaunchTemplateConfigs.Count == 0)
                {
                    request.Parameters.Add("LaunchTemplateConfigs", "");
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
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".LaunchTemplateSpecification" + ".LaunchTemplateId", StringUtils.FromString(item0.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if (item0.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".LaunchTemplateSpecification" + ".LaunchTemplateName", StringUtils.FromString(item0.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if (item0.LaunchTemplateSpecification.IsSetLaunchTemplateSpecificationUserData())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".LaunchTemplateSpecification" + ".LaunchTemplateSpecificationUserData", StringUtils.FromString(item0.LaunchTemplateSpecification.LaunchTemplateSpecificationUserData));
                            }
                            if (item0.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".LaunchTemplateSpecification" + ".Version", StringUtils.FromString(item0.LaunchTemplateSpecification.Version));
                            }
                        }
                        if (item0.IsSetOverrides())
                        {
                            if (item0.Overrides.Count == 0)
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Overrides)
                                {
                                    if (item1.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".AvailabilityZone", StringUtils.FromString(item1.AvailabilityZone));
                                    }
                                    if (item1.IsSetAvailabilityZoneId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".AvailabilityZoneId", StringUtils.FromString(item1.AvailabilityZoneId));
                                    }
                                    if (item1.IsSetBlockDeviceMappings())
                                    {
                                        if (item1.BlockDeviceMappings.Count == 0)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping", "");
                                        }
                                        else
                                        {
                                            int index2 = 1;
                                            foreach (var item2 in item1.BlockDeviceMappings)
                                            {
                                                if (item2.IsSetDeviceName())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".DeviceName", StringUtils.FromString(item2.DeviceName));
                                                }
                                                if (item2.IsSetEbs())
                                                {
                                                    if (item2.Ebs.IsSetDeleteOnTermination())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item2.Ebs.DeleteOnTermination.Value));
                                                    }
                                                    if (item2.Ebs.IsSetEncrypted())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item2.Ebs.Encrypted.Value));
                                                    }
                                                    if (item2.Ebs.IsSetIops())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Iops", StringUtils.FromInt(item2.Ebs.Iops.Value));
                                                    }
                                                    if (item2.Ebs.IsSetKmsKeyId())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item2.Ebs.KmsKeyId));
                                                    }
                                                    if (item2.Ebs.IsSetSnapshotId())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item2.Ebs.SnapshotId));
                                                    }
                                                    if (item2.Ebs.IsSetThroughput())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".Throughput", StringUtils.FromInt(item2.Ebs.Throughput.Value));
                                                    }
                                                    if (item2.Ebs.IsSetVolumeSize())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item2.Ebs.VolumeSize.Value));
                                                    }
                                                    if (item2.Ebs.IsSetVolumeType())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".Ebs" + ".VolumeType", StringUtils.FromString(item2.Ebs.VolumeType));
                                                    }
                                                }
                                                if (item2.IsSetNoDevice())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".NoDevice", StringUtils.FromString(item2.NoDevice));
                                                }
                                                if (item2.IsSetVirtualName())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".BlockDeviceMapping" + "." + index2 + ".VirtualName", StringUtils.FromString(item2.VirtualName));
                                                }
                                                index2++;
                                            }
                                        }
                                    }
                                    if (item1.IsSetIamInstanceProfile())
                                    {
                                        if (item1.IamInstanceProfile.IsSetArn())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".IamInstanceProfile" + ".Arn", StringUtils.FromString(item1.IamInstanceProfile.Arn));
                                        }
                                        if (item1.IamInstanceProfile.IsSetName())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".IamInstanceProfile" + ".Name", StringUtils.FromString(item1.IamInstanceProfile.Name));
                                        }
                                    }
                                    if (item1.IsSetImageId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".ImageId", StringUtils.FromString(item1.ImageId));
                                    }
                                    if (item1.IsSetInstanceRequirements())
                                    {
                                        if (item1.InstanceRequirements.IsSetAcceleratorCount())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.AcceleratorCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorCount.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorManufacturers())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturer", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorManufacturers)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorManufacturer" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorNames())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorNames.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorName", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorNames)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorName" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAcceleratorTypes())
                                        {
                                            if (item1.InstanceRequirements.AcceleratorTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AcceleratorTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AcceleratorType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetAllowedInstanceTypes())
                                        {
                                            if (item1.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.AllowedInstanceTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".AllowedInstanceType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetBareMetal())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(item1.InstanceRequirements.BareMetal));
                                        }
                                        if (item1.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                        {
                                            if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
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
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                                                    }
                                                    else
                                                    {
                                                        int index5 = 1;
                                                        foreach (var item5 in item1.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                        {
                                                            if (item5.IsSetInstanceFamily())
                                                            {
                                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + "." + index5 + ".InstanceFamily", StringUtils.FromString(item5.InstanceFamily));
                                                            }
                                                            index5++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetBurstablePerformance())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(item1.InstanceRequirements.BurstablePerformance));
                                        }
                                        if (item1.InstanceRequirements.IsSetCpuManufacturers())
                                        {
                                            if (item1.InstanceRequirements.CpuManufacturers.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturer", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.CpuManufacturers)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".CpuManufacturer" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetExcludedInstanceTypes())
                                        {
                                            if (item1.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.ExcludedInstanceTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".ExcludedInstanceType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetInstanceGenerations())
                                        {
                                            if (item1.InstanceRequirements.InstanceGenerations.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".InstanceGeneration", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.InstanceGenerations)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".InstanceGeneration" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetLocalStorage())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(item1.InstanceRequirements.LocalStorage));
                                        }
                                        if (item1.InstanceRequirements.IsSetLocalStorageTypes())
                                        {
                                            if (item1.InstanceRequirements.LocalStorageTypes.Count == 0)
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorageType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.InstanceRequirements.LocalStorageTypes)
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".LocalStorageType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(item1.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                        {
                                            if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetMemoryMiB())
                                        {
                                            if (item1.InstanceRequirements.MemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.MemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.MemoryMiB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                        {
                                            if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetNetworkInterfaceCount())
                                        {
                                            if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetRequireEncryptionInTransit())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(item1.InstanceRequirements.RequireEncryptionInTransit.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetRequireHibernateSupport())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(item1.InstanceRequirements.RequireHibernateSupport.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(item1.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                                        }
                                        if (item1.InstanceRequirements.IsSetTotalLocalStorageGB())
                                        {
                                            if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(item1.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                                            }
                                        }
                                        if (item1.InstanceRequirements.IsSetVCpuCount())
                                        {
                                            if (item1.InstanceRequirements.VCpuCount.IsSetMax())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Max.Value));
                                            }
                                            if (item1.InstanceRequirements.VCpuCount.IsSetMin())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(item1.InstanceRequirements.VCpuCount.Min.Value));
                                            }
                                        }
                                    }
                                    if (item1.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".InstanceType", StringUtils.FromString(item1.InstanceType));
                                    }
                                    if (item1.IsSetKeyName())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".KeyName", StringUtils.FromString(item1.KeyName));
                                    }
                                    if (item1.IsSetMaxPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".MaxPrice", StringUtils.FromString(item1.MaxPrice));
                                    }
                                    if (item1.IsSetMetadataOptions())
                                    {
                                        if (item1.MetadataOptions.IsSetHttpEndpoint())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".MetadataOptions" + ".HttpEndpoint", StringUtils.FromString(item1.MetadataOptions.HttpEndpoint));
                                        }
                                        if (item1.MetadataOptions.IsSetHttpPutResponseHopLimit())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".MetadataOptions" + ".HttpPutResponseHopLimit", StringUtils.FromInt(item1.MetadataOptions.HttpPutResponseHopLimit.Value));
                                        }
                                        if (item1.MetadataOptions.IsSetHttpTokens())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".MetadataOptions" + ".HttpTokens", StringUtils.FromString(item1.MetadataOptions.HttpTokens));
                                        }
                                    }
                                    if (item1.IsSetPlacement())
                                    {
                                        if (item1.Placement.IsSetAffinity())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".Affinity", StringUtils.FromString(item1.Placement.Affinity));
                                        }
                                        if (item1.Placement.IsSetAvailabilityZone())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".AvailabilityZone", StringUtils.FromString(item1.Placement.AvailabilityZone));
                                        }
                                        if (item1.Placement.IsSetAvailabilityZoneId())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".AvailabilityZoneId", StringUtils.FromString(item1.Placement.AvailabilityZoneId));
                                        }
                                        if (item1.Placement.IsSetGroupId())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".GroupId", StringUtils.FromString(item1.Placement.GroupId));
                                        }
                                        if (item1.Placement.IsSetGroupName())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".GroupName", StringUtils.FromString(item1.Placement.GroupName));
                                        }
                                        if (item1.Placement.IsSetHostId())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".HostId", StringUtils.FromString(item1.Placement.HostId));
                                        }
                                        if (item1.Placement.IsSetHostResourceGroupArn())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".HostResourceGroupArn", StringUtils.FromString(item1.Placement.HostResourceGroupArn));
                                        }
                                        if (item1.Placement.IsSetPartitionNumber())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".PartitionNumber", StringUtils.FromInt(item1.Placement.PartitionNumber.Value));
                                        }
                                        if (item1.Placement.IsSetSpreadDomain())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".SpreadDomain", StringUtils.FromString(item1.Placement.SpreadDomain));
                                        }
                                        if (item1.Placement.IsSetTenancy())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Placement" + ".Tenancy", StringUtils.FromString(item1.Placement.Tenancy));
                                        }
                                    }
                                    if (item1.IsSetPriority())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".Priority", StringUtils.FromDouble(item1.Priority.Value));
                                    }
                                    if (item1.IsSetSubnetId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                                    }
                                    if (item1.IsSetWeightedCapacity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + index0 + ".Overrides" + "." + index1 + ".WeightedCapacity", StringUtils.FromDouble(item1.WeightedCapacity.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOnDemandOptions())
            {
                if (publicRequest.OnDemandOptions.IsSetAllocationStrategy())
                {
                    request.Parameters.Add("OnDemandOptions" + ".AllocationStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.AllocationStrategy));
                }
                if (publicRequest.OnDemandOptions.IsSetCapacityReservationOptions())
                {
                    if (publicRequest.OnDemandOptions.CapacityReservationOptions.IsSetUsageStrategy())
                    {
                        request.Parameters.Add("OnDemandOptions" + ".CapacityReservationOptions" + ".UsageStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.CapacityReservationOptions.UsageStrategy));
                    }
                }
                if (publicRequest.OnDemandOptions.IsSetMaxTotalPrice())
                {
                    request.Parameters.Add("OnDemandOptions" + ".MaxTotalPrice", StringUtils.FromString(publicRequest.OnDemandOptions.MaxTotalPrice));
                }
                if (publicRequest.OnDemandOptions.IsSetMinTargetCapacity())
                {
                    request.Parameters.Add("OnDemandOptions" + ".MinTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandOptions.MinTargetCapacity.Value));
                }
                if (publicRequest.OnDemandOptions.IsSetSingleAvailabilityZone())
                {
                    request.Parameters.Add("OnDemandOptions" + ".SingleAvailabilityZone", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleAvailabilityZone.Value));
                }
                if (publicRequest.OnDemandOptions.IsSetSingleInstanceType())
                {
                    request.Parameters.Add("OnDemandOptions" + ".SingleInstanceType", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleInstanceType.Value));
                }
            }
            if (publicRequest.IsSetReplaceUnhealthyInstances())
            {
                request.Parameters.Add("ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.ReplaceUnhealthyInstances.Value));
            }
            if (publicRequest.IsSetReservedCapacityOptions())
            {
                if (publicRequest.ReservedCapacityOptions.IsSetAllocationStrategy())
                {
                    request.Parameters.Add("ReservedCapacityOptions" + ".AllocationStrategy", StringUtils.FromString(publicRequest.ReservedCapacityOptions.AllocationStrategy));
                }
                if (publicRequest.ReservedCapacityOptions.IsSetCapacityReservationTarget())
                {
                    if (publicRequest.ReservedCapacityOptions.CapacityReservationTarget.IsSetCapacityReservationIds())
                    {
                        if (publicRequest.ReservedCapacityOptions.CapacityReservationTarget.CapacityReservationIds.Count == 0)
                        {
                            request.Parameters.Add("ReservedCapacityOptions" + ".CapacityReservationTarget" + ".CapacityReservationId", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.ReservedCapacityOptions.CapacityReservationTarget.CapacityReservationIds)
                            {
                                request.Parameters.Add("ReservedCapacityOptions" + ".CapacityReservationTarget" + ".CapacityReservationId" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.ReservedCapacityOptions.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArns())
                    {
                        if (publicRequest.ReservedCapacityOptions.CapacityReservationTarget.CapacityReservationResourceGroupArns.Count == 0)
                        {
                            request.Parameters.Add("ReservedCapacityOptions" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArn", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.ReservedCapacityOptions.CapacityReservationTarget.CapacityReservationResourceGroupArns)
                            {
                                request.Parameters.Add("ReservedCapacityOptions" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArn" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                }
                if (publicRequest.ReservedCapacityOptions.IsSetReservationTypes())
                {
                    if (publicRequest.ReservedCapacityOptions.ReservationTypes.Count == 0)
                    {
                        request.Parameters.Add("ReservedCapacityOptions" + ".ReservationType", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.ReservedCapacityOptions.ReservationTypes)
                        {
                            request.Parameters.Add("ReservedCapacityOptions" + ".ReservationType" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.ReservedCapacityOptions.IsSetReservedCapacityFallbackOptions())
                {
                    if (publicRequest.ReservedCapacityOptions.ReservedCapacityFallbackOptions.IsSetMarketTypes())
                    {
                        if (publicRequest.ReservedCapacityOptions.ReservedCapacityFallbackOptions.MarketTypes.Count == 0)
                        {
                            request.Parameters.Add("ReservedCapacityOptions" + ".ReservedCapacityFallbackOptions" + ".MarketType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.ReservedCapacityOptions.ReservedCapacityFallbackOptions.MarketTypes)
                            {
                                request.Parameters.Add("ReservedCapacityOptions" + ".ReservedCapacityFallbackOptions" + ".MarketType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                }
            }
            if (publicRequest.IsSetSpotOptions())
            {
                if (publicRequest.SpotOptions.IsSetAllocationStrategy())
                {
                    request.Parameters.Add("SpotOptions" + ".AllocationStrategy", StringUtils.FromString(publicRequest.SpotOptions.AllocationStrategy));
                }
                if (publicRequest.SpotOptions.IsSetInstanceInterruptionBehavior())
                {
                    request.Parameters.Add("SpotOptions" + ".InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotOptions.InstanceInterruptionBehavior));
                }
                if (publicRequest.SpotOptions.IsSetInstancePoolsToUseCount())
                {
                    request.Parameters.Add("SpotOptions" + ".InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotOptions.InstancePoolsToUseCount.Value));
                }
                if (publicRequest.SpotOptions.IsSetMaintenanceStrategies())
                {
                    if (publicRequest.SpotOptions.MaintenanceStrategies.IsSetCapacityRebalance())
                    {
                        if (publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                        {
                            request.Parameters.Add("SpotOptions" + ".MaintenanceStrategies" + ".CapacityRebalance" + ".ReplacementStrategy", StringUtils.FromString(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                        }
                        if (publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                        {
                            request.Parameters.Add("SpotOptions" + ".MaintenanceStrategies" + ".CapacityRebalance" + ".TerminationDelay", StringUtils.FromInt(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.TerminationDelay.Value));
                        }
                    }
                }
                if (publicRequest.SpotOptions.IsSetMaxTotalPrice())
                {
                    request.Parameters.Add("SpotOptions" + ".MaxTotalPrice", StringUtils.FromString(publicRequest.SpotOptions.MaxTotalPrice));
                }
                if (publicRequest.SpotOptions.IsSetMinTargetCapacity())
                {
                    request.Parameters.Add("SpotOptions" + ".MinTargetCapacity", StringUtils.FromInt(publicRequest.SpotOptions.MinTargetCapacity.Value));
                }
                if (publicRequest.SpotOptions.IsSetSingleAvailabilityZone())
                {
                    request.Parameters.Add("SpotOptions" + ".SingleAvailabilityZone", StringUtils.FromBool(publicRequest.SpotOptions.SingleAvailabilityZone.Value));
                }
                if (publicRequest.SpotOptions.IsSetSingleInstanceType())
                {
                    request.Parameters.Add("SpotOptions" + ".SingleInstanceType", StringUtils.FromBool(publicRequest.SpotOptions.SingleInstanceType.Value));
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
            if (publicRequest.IsSetTargetCapacitySpecification())
            {
                if (publicRequest.TargetCapacitySpecification.IsSetDefaultTargetCapacityType())
                {
                    request.Parameters.Add("TargetCapacitySpecification" + ".DefaultTargetCapacityType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.DefaultTargetCapacityType));
                }
                if (publicRequest.TargetCapacitySpecification.IsSetOnDemandTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacitySpecification" + ".OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.OnDemandTargetCapacity.Value));
                }
                if (publicRequest.TargetCapacitySpecification.IsSetSpotTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacitySpecification" + ".SpotTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.SpotTargetCapacity.Value));
                }
                if (publicRequest.TargetCapacitySpecification.IsSetTargetCapacityUnitType())
                {
                    request.Parameters.Add("TargetCapacitySpecification" + ".TargetCapacityUnitType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.TargetCapacityUnitType));
                }
                if (publicRequest.TargetCapacitySpecification.IsSetTotalTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacitySpecification" + ".TotalTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.TotalTargetCapacity.Value));
                }
            }
            if (publicRequest.IsSetTerminateInstancesWithExpiration())
            {
                request.Parameters.Add("TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.TerminateInstancesWithExpiration.Value));
            }
            if (publicRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
            }
            if (publicRequest.IsSetValidFrom())
            {
                request.Parameters.Add("ValidFrom", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidFrom.Value));
            }
            if (publicRequest.IsSetValidUntil())
            {
                request.Parameters.Add("ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidUntil.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateFleetRequestMarshaller _instance = new();

        internal static CreateFleetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFleetRequestMarshaller Instance => _instance;
    }
}
