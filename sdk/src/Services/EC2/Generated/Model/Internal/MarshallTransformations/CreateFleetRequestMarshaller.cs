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
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
                }
                if(publicRequest.IsSetLaunchTemplateConfigs())
                {
                    if (publicRequest.LaunchTemplateConfigs.Count == 0)
                        request.Parameters.Add("LaunchTemplateConfigs", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.LaunchTemplateConfigs)
                         {
                            if(publicRequestlistValue.IsSetLaunchTemplateSpecification())
                            {
                                if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                                }
                                if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                                }
                                if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
                                }
                            }
                            if(publicRequestlistValue.IsSetOverrides())
                            {
                                if (publicRequestlistValue.Overrides.Count == 0)
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Overrides)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetAvailabilityZone())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetBlockDeviceMappings())
                                        {
                                            if (publicRequestlistValuelistValue.BlockDeviceMappings.Count == 0)
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping", "");
                                            else
                                            {
                                                 int publicRequestlistValuelistValuelistValueIndex = 1;
                                                 foreach(var publicRequestlistValuelistValuelistValue in publicRequestlistValuelistValue.BlockDeviceMappings)
                                                 {
                                                    if(publicRequestlistValuelistValuelistValue.IsSetDeviceName())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValuelistValuelistValue.DeviceName));
                                                    }
                                                    if(publicRequestlistValuelistValuelistValue.IsSetEbs())
                                                    {
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetDeleteOnTermination())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValuelistValuelistValue.Ebs.DeleteOnTermination));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetEncrypted())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValuelistValuelistValue.Ebs.Encrypted));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetIops())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValuelistValuelistValue.Ebs.Iops));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetKmsKeyId())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestlistValuelistValuelistValue.Ebs.KmsKeyId));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetSnapshotId())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValuelistValuelistValue.Ebs.SnapshotId));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetThroughput())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestlistValuelistValuelistValue.Ebs.Throughput));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetVolumeSize())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValuelistValuelistValue.Ebs.VolumeSize));
                                                        }
                                                        if(publicRequestlistValuelistValuelistValue.Ebs.IsSetVolumeType())
                                                        {
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValuelistValuelistValue.Ebs.VolumeType));
                                                        }
                                                    }
                                                    if(publicRequestlistValuelistValuelistValue.IsSetNoDevice())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValuelistValuelistValue.NoDevice));
                                                    }
                                                    if(publicRequestlistValuelistValuelistValue.IsSetVirtualName())
                                                    {
                                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValuelistValuelistValue.VirtualName));
                                                    }
                                                     publicRequestlistValuelistValuelistValueIndex++;
                                                 }
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetImageId())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "ImageId", StringUtils.FromString(publicRequestlistValuelistValue.ImageId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetInstanceRequirements())
                                        {
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.AcceleratorNames.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorName", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorNames)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTypes.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorType", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceType", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AllowedInstanceTypes)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BareMetal));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                                {
                                                    if(publicRequestlistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                                    {
                                                        if (publicRequestlistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference", "");
                                                        else
                                                        {
                                                             int publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                                             foreach(var publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequestlistValuelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                             {
                                                                if(publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                                                {
                                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference" + "." + publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                                                }
                                                                 publicRequestlistValuelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                                             }
                                                        }
                                                    }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BurstablePerformance));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.CpuManufacturers.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturer", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.CpuManufacturers)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceType", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.InstanceGenerations.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGeneration", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.InstanceGenerations)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.LocalStorage));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                            {
                                                if (publicRequestlistValuelistValue.InstanceRequirements.LocalStorageTypes.Count == 0)
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageType", "");
                                                else
                                                {
                                                     int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                                     {
                                                         request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                                         publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestlistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                                }
                                            }
                                            if(publicRequestlistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                            {
                                                if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                                }
                                                if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                                }
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetInstanceType())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetMaxPrice())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "MaxPrice", StringUtils.FromString(publicRequestlistValuelistValue.MaxPrice));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetPlacement())
                                        {
                                            if(publicRequestlistValuelistValue.Placement.IsSetAffinity())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Affinity));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZone())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZone));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZoneId())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZoneId));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetGroupId())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupId));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetGroupName())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupName));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetHostId())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostId));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetHostResourceGroupArn())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostResourceGroupArn));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetPartitionNumber())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequestlistValuelistValue.Placement.PartitionNumber));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetSpreadDomain())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequestlistValuelistValue.Placement.SpreadDomain));
                                            }
                                            if(publicRequestlistValuelistValue.Placement.IsSetTenancy())
                                            {
                                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Tenancy));
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetPriority())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetSubnetId())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetOnDemandOptions())
                {
                    if(publicRequest.OnDemandOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.AllocationStrategy));
                    }
                    if(publicRequest.OnDemandOptions.IsSetCapacityReservationOptions())
                    {
                        if(publicRequest.OnDemandOptions.CapacityReservationOptions.IsSetUsageStrategy())
                        {
                            request.Parameters.Add("OnDemandOptions" + "." + "CapacityReservationOptions" + "." + "UsageStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.CapacityReservationOptions.UsageStrategy));
                        }
                    }
                    if(publicRequest.OnDemandOptions.IsSetMaxTotalPrice())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "MaxTotalPrice", StringUtils.FromString(publicRequest.OnDemandOptions.MaxTotalPrice));
                    }
                    if(publicRequest.OnDemandOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandOptions.MinTargetCapacity));
                    }
                    if(publicRequest.OnDemandOptions.IsSetSingleAvailabilityZone())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "SingleAvailabilityZone", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleAvailabilityZone));
                    }
                    if(publicRequest.OnDemandOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleInstanceType));
                    }
                }
                if(publicRequest.IsSetReplaceUnhealthyInstances())
                {
                    request.Parameters.Add("ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.ReplaceUnhealthyInstances));
                }
                if(publicRequest.IsSetSpotOptions())
                {
                    if(publicRequest.SpotOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.SpotOptions.AllocationStrategy));
                    }
                    if(publicRequest.SpotOptions.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotOptions.InstanceInterruptionBehavior));
                    }
                    if(publicRequest.SpotOptions.IsSetInstancePoolsToUseCount())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotOptions.InstancePoolsToUseCount));
                    }
                    if(publicRequest.SpotOptions.IsSetMaintenanceStrategies())
                    {
                        if(publicRequest.SpotOptions.MaintenanceStrategies.IsSetCapacityRebalance())
                        {
                            if(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                            {
                                request.Parameters.Add("SpotOptions" + "." + "MaintenanceStrategies" + "." + "CapacityRebalance" + "." + "ReplacementStrategy", StringUtils.FromString(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                            }
                            if(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                            {
                                request.Parameters.Add("SpotOptions" + "." + "MaintenanceStrategies" + "." + "CapacityRebalance" + "." + "TerminationDelay", StringUtils.FromInt(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.TerminationDelay));
                            }
                        }
                    }
                    if(publicRequest.SpotOptions.IsSetMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "MaxTotalPrice", StringUtils.FromString(publicRequest.SpotOptions.MaxTotalPrice));
                    }
                    if(publicRequest.SpotOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.SpotOptions.MinTargetCapacity));
                    }
                    if(publicRequest.SpotOptions.IsSetSingleAvailabilityZone())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "SingleAvailabilityZone", StringUtils.FromBool(publicRequest.SpotOptions.SingleAvailabilityZone));
                    }
                    if(publicRequest.SpotOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.SpotOptions.SingleInstanceType));
                    }
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTargetCapacitySpecification())
                {
                    if(publicRequest.TargetCapacitySpecification.IsSetDefaultTargetCapacityType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "DefaultTargetCapacityType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.DefaultTargetCapacityType));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.OnDemandTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetSpotTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "SpotTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.SpotTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetTargetCapacityUnitType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TargetCapacityUnitType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.TargetCapacityUnitType));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetTotalTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TotalTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.TotalTargetCapacity));
                    }
                }
                if(publicRequest.IsSetTerminateInstancesWithExpiration())
                {
                    request.Parameters.Add("TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.TerminateInstancesWithExpiration));
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
                if(publicRequest.IsSetValidFrom())
                {
                    request.Parameters.Add("ValidFrom", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidFrom));
                }
                if(publicRequest.IsSetValidUntil())
                {
                    request.Parameters.Add("ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidUntil));
                }
            }
            return request;
        }
                    private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}