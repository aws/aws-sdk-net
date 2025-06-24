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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestSpotFleet Request Marshaller
    /// </summary>       
    public class RequestSpotFleetRequestMarshaller : IMarshaller<IRequest, RequestSpotFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSpotFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestSpotFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RequestSpotFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetSpotFleetRequestConfig())
                {
                    if(publicRequest.SpotFleetRequestConfig.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.AllocationStrategy));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetClientToken())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ClientToken", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ClientToken));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetContext())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "Context", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Context));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetExcessCapacityTerminationPolicy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ExcessCapacityTerminationPolicy));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetFulfilledCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "FulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.FulfilledCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetIamFleetRole())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "IamFleetRole", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.IamFleetRole));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.InstanceInterruptionBehavior));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetInstancePoolsToUseCount())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.InstancePoolsToUseCount));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetLaunchSpecifications())
                    {
                        if (publicRequest.SpotFleetRequestConfig.LaunchSpecifications.Count == 0)
                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications", "");
                        else
                        {
                             int publicRequestSpotFleetRequestConfiglistValueIndex = 1;
                             foreach(var publicRequestSpotFleetRequestConfiglistValue in publicRequest.SpotFleetRequestConfig.LaunchSpecifications)
                             {
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetAddressingType())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "AddressingType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.AddressingType));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetBlockDeviceMappings())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.BlockDeviceMappings.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.BlockDeviceMappings)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeviceName())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.DeviceName));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEbs())
                                            {
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetAvailabilityZone())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.AvailabilityZone));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetAvailabilityZoneId())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.AvailabilityZoneId));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetDeleteOnTermination())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.DeleteOnTermination));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetEncrypted())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Encrypted));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetIops())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Iops));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetKmsKeyId())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.KmsKeyId));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetOutpostArn())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.OutpostArn));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetSnapshotId())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.SnapshotId));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetThroughput())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Throughput));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetVolumeInitializationRate())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "VolumeInitializationRate", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.VolumeInitializationRate));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetVolumeSize())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.VolumeSize));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetVolumeType())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.VolumeType));
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNoDevice())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.NoDevice));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetVirtualName())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.VirtualName));
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetEbsOptimized())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "EbsOptimized", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.EbsOptimized));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetIamInstanceProfile())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.IsSetArn())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.Arn));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.IsSetName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.Name));
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetImageId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "ImageId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.ImageId));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetInstanceRequirements())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorManufacturers)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorNames.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorNames)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTypes.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTypes)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AllowedInstanceTypes)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BareMetal));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "ReferenceSet", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "ReferenceSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                                     }
                                                }
                                            }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BurstablePerformance));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.CpuManufacturers.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.CpuManufacturers)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.ExcludedInstanceTypes)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.InstanceGenerations.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.InstanceGenerations)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.LocalStorage));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        if (publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.LocalStorageTypes.Count == 0)
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet", "");
                                        else
                                        {
                                             int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                             foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.LocalStorageTypes)
                                             {
                                                 request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                                 publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.RequireHibernateSupport));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.Max));
                                        }
                                        if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.Min));
                                        }
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceType));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetKernelId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "KernelId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.KernelId));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetKeyName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "KeyName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.KeyName));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetMonitoring())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.Monitoring.IsSetEnabled())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Monitoring" + "." + "Enabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.Monitoring.Enabled));
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetNetworkInterfaces())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.NetworkInterfaces.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.NetworkInterfaces)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAssociateCarrierIpAddress())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.AssociateCarrierIpAddress));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAssociatePublicIpAddress())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.AssociatePublicIpAddress));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetConnectionTrackingSpecification())
                                            {
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.UdpStreamTimeout));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.UdpTimeout));
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeleteOnTermination())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.DeleteOnTermination));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDescription())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Description));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeviceIndex())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.DeviceIndex));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEnaQueueCount())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "EnaQueueCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaQueueCount));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEnaSrdSpecification())
                                            {
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdEnabled));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                                                    }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroups())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.Groups.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecurityGroupId", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Groups)
                                                     {
                                                         request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecurityGroupId" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue));
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInterfaceType())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InterfaceType));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv4PrefixCount())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv4PrefixCount));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv4Prefixes())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv4Prefixes.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv4Prefix", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv4Prefixes)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv4Prefix())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv4Prefix));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6AddressCount())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6AddressCount));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6Addresses())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Addresses.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Addresses", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Addresses)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv6Address())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv6Address));
                                                        }
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIsPrimaryIpv6())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsPrimaryIpv6));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6PrefixCount())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6PrefixCount));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6Prefixes())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Prefixes.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Prefix", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Prefixes)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv6Prefix())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv6Prefix));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNetworkCardIndex())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.NetworkCardIndex));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNetworkInterfaceId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.NetworkInterfaceId));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrimaryIpv6())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrimaryIpv6", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.PrimaryIpv6));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddress())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddress));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddresses())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddresses.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddresses", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddresses)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrimary())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Primary));
                                                        }
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrivateIpAddress())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.PrivateIpAddress));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSecondaryPrivateIpAddressCount())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.SecondaryPrivateIpAddressCount));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSubnetId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SubnetId));
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetPlacement())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.AvailabilityZone));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetGroupName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.GroupName));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetTenancy())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.Tenancy));
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetRamdiskId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "RamdiskId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.RamdiskId));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetSecurityGroups())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.SecurityGroups.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "GroupSet", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.SecurityGroups)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroupId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "GroupSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "GroupId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.GroupId));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroupName())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "GroupSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "GroupName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.GroupName));
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetSpotPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.SpotPrice));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.SubnetId));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetTagSpecifications())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.TagSpecifications.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.TagSpecifications)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetResourceType())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.ResourceType));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetTags())
                                            {
                                                if (publicRequestSpotFleetRequestConfiglistValuelistValue.Tags.Count == 0)
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Tag", "");
                                                else
                                                {
                                                     int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                                     foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Tags)
                                                     {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetKey())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Key));
                                                        }
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetValue())
                                                        {
                                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Value));
                                                        }
                                                         publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                                     }
                                                }
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetUserData())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "UserData", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.UserData));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.WeightedCapacity));
                                }
                                 publicRequestSpotFleetRequestConfiglistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetLaunchTemplateConfigs())
                    {
                        if (publicRequest.SpotFleetRequestConfig.LaunchTemplateConfigs.Count == 0)
                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs", "");
                        else
                        {
                             int publicRequestSpotFleetRequestConfiglistValueIndex = 1;
                             foreach(var publicRequestSpotFleetRequestConfiglistValue in publicRequest.SpotFleetRequestConfig.LaunchTemplateConfigs)
                             {
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetLaunchTemplateSpecification())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.LaunchTemplateId));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.LaunchTemplateName));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.IsSetVersion())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.Version));
                                    }
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetOverrides())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.Overrides.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.Overrides)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAvailabilityZone())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.AvailabilityZone));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInstanceRequirements())
                                            {
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorNames.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorNames)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTypes.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AllowedInstanceTypes)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BareMetal));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                                    {
                                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                                        {
                                                            if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "ReferenceSet", "");
                                                            else
                                                            {
                                                                 int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                                                 foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                                 {
                                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                                                    {
                                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "ReferenceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                                                    }
                                                                     publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                                                 }
                                                            }
                                                        }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BurstablePerformance));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.CpuManufacturers.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.CpuManufacturers)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.InstanceGenerations.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.InstanceGenerations)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.LocalStorage));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                                {
                                                    if (publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.LocalStorageTypes.Count == 0)
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet", "");
                                                    else
                                                    {
                                                         int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                                         {
                                                             request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                             publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                                         }
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                                {
                                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                                    }
                                                }
                                                if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                                {
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                                    }
                                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                                    {
                                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                                    }
                                                }
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInstanceType())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceType));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPriority())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.Priority));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSpotPrice())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SpotPrice));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSubnetId())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SubnetId));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetWeightedCapacity())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.WeightedCapacity));
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                 publicRequestSpotFleetRequestConfiglistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetLoadBalancersConfig())
                    {
                        if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetClassicLoadBalancersConfig())
                        {
                            if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.IsSetClassicLoadBalancers())
                            {
                                if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.ClassicLoadBalancers.Count == 0)
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "ClassicLoadBalancersConfig" + "." + "ClassicLoadBalancers", "");
                                else
                                {
                                     int publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex = 1;
                                     foreach(var publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.ClassicLoadBalancers)
                                     {
                                        if(publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue.IsSetName())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "ClassicLoadBalancersConfig" + "." + "ClassicLoadBalancers" + "." + publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex + "." + "Name", StringUtils.FromString(publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue.Name));
                                        }
                                         publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex++;
                                     }
                                }
                            }
                        }
                        if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetTargetGroupsConfig())
                        {
                            if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.IsSetTargetGroups())
                            {
                                if (publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.TargetGroups.Count == 0)
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "TargetGroupsConfig" + "." + "TargetGroups", "");
                                else
                                {
                                     int publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex = 1;
                                     foreach(var publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.TargetGroups)
                                     {
                                        if(publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue.IsSetArn())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "TargetGroupsConfig" + "." + "TargetGroups" + "." + publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex + "." + "Arn", StringUtils.FromString(publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue.Arn));
                                        }
                                         publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex++;
                                     }
                                }
                            }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandAllocationStrategy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandAllocationStrategy));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandFulfilledCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandFulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.OnDemandFulfilledCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandMaxTotalPrice));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.OnDemandTargetCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetReplaceUnhealthyInstances())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.ReplaceUnhealthyInstances));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotMaintenanceStrategies())
                    {
                        if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.IsSetCapacityRebalance())
                        {
                            if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaintenanceStrategies" + "." + "CapacityRebalance" + "." + "ReplacementStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                            }
                            if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaintenanceStrategies" + "." + "CapacityRebalance" + "." + "TerminationDelay", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.TerminationDelay));
                            }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaxTotalPrice));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotPrice));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetTagSpecifications())
                    {
                        if (publicRequest.SpotFleetRequestConfig.TagSpecifications.Count == 0)
                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification", "");
                        else
                        {
                             int publicRequestSpotFleetRequestConfiglistValueIndex = 1;
                             foreach(var publicRequestSpotFleetRequestConfiglistValue in publicRequest.SpotFleetRequestConfig.TagSpecifications)
                             {
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetResourceType())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.ResourceType));
                                }
                                if(publicRequestSpotFleetRequestConfiglistValue.IsSetTags())
                                {
                                    if (publicRequestSpotFleetRequestConfiglistValue.Tags.Count == 0)
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Tag", "");
                                    else
                                    {
                                         int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                         foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.Tags)
                                         {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetKey())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Key));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetValue())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Value));
                                            }
                                             publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                         }
                                    }
                                }
                                 publicRequestSpotFleetRequestConfiglistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.TargetCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetTargetCapacityUnitType())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TargetCapacityUnitType", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.TargetCapacityUnitType));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetTerminateInstancesWithExpiration())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.TerminateInstancesWithExpiration));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetType())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "Type", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Type));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetValidFrom())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidFrom", Amazon.Runtime.Internal.Util.StringUtils.FromDateTimeToISO8601NoMs(publicRequest.SpotFleetRequestConfig.ValidFrom));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetValidUntil())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidUntil", Amazon.Runtime.Internal.Util.StringUtils.FromDateTimeToISO8601NoMs(publicRequest.SpotFleetRequestConfig.ValidUntil));
                    }
                }
            }
            return request;
        }
                    private static RequestSpotFleetRequestMarshaller _instance = new RequestSpotFleetRequestMarshaller();        

        internal static RequestSpotFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestSpotFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}