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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLaunchTemplateVersion Request Marshaller
    /// </summary>       
    public class CreateLaunchTemplateVersionRequestMarshaller : IMarshaller<IRequest, CreateLaunchTemplateVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchTemplateVersionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLaunchTemplateVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateLaunchTemplateVersion");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetLaunchTemplateData())
                {
                    if(publicRequest.LaunchTemplateData.IsSetBlockDeviceMappings())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.BlockDeviceMappings)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.DeviceName));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetEbs())
                            {
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValue.Ebs.DeleteOnTermination));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValue.Ebs.Encrypted));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ebs.Iops));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetKmsKeyId())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Ebs.KmsKeyId));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Ebs.SnapshotId));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetThroughput())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ebs.Throughput));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ebs.VolumeSize));
                                }
                                if(publicRequestLaunchTemplateDatalistValue.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Ebs.VolumeType));
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetNoDevice())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.NoDevice));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetVirtualName())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.VirtualName));
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetCapacityReservationSpecification())
                    {
                        if(publicRequest.LaunchTemplateData.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "CapacityReservationSpecification" + "." + "CapacityReservationPreference", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationPreference));
                        }
                        if(publicRequest.LaunchTemplateData.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                        {
                            if(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationId", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                            }
                            if(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                            }
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetCpuOptions())
                    {
                        if(publicRequest.LaunchTemplateData.CpuOptions.IsSetCoreCount())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "CpuOptions" + "." + "CoreCount", StringUtils.FromInt(publicRequest.LaunchTemplateData.CpuOptions.CoreCount));
                        }
                        if(publicRequest.LaunchTemplateData.CpuOptions.IsSetThreadsPerCore())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "CpuOptions" + "." + "ThreadsPerCore", StringUtils.FromInt(publicRequest.LaunchTemplateData.CpuOptions.ThreadsPerCore));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetCreditSpecification())
                    {
                        if(publicRequest.LaunchTemplateData.CreditSpecification.IsSetCpuCredits())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "CreditSpecification" + "." + "CpuCredits", StringUtils.FromString(publicRequest.LaunchTemplateData.CreditSpecification.CpuCredits));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetDisableApiStop())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "DisableApiStop", StringUtils.FromBool(publicRequest.LaunchTemplateData.DisableApiStop));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetDisableApiTermination())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "DisableApiTermination", StringUtils.FromBool(publicRequest.LaunchTemplateData.DisableApiTermination));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetEbsOptimized())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "EbsOptimized", StringUtils.FromBool(publicRequest.LaunchTemplateData.EbsOptimized));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetElasticGpuSpecifications())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.ElasticGpuSpecifications)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "ElasticGpuSpecification" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Type", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Type));
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetElasticInferenceAccelerators())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.ElasticInferenceAccelerators)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "ElasticInferenceAccelerator" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Count", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Count));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "ElasticInferenceAccelerator" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Type", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Type));
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetEnclaveOptions())
                    {
                        if(publicRequest.LaunchTemplateData.EnclaveOptions.IsSetEnabled())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "EnclaveOptions" + "." + "Enabled", StringUtils.FromBool(publicRequest.LaunchTemplateData.EnclaveOptions.Enabled));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetHibernationOptions())
                    {
                        if(publicRequest.LaunchTemplateData.HibernationOptions.IsSetConfigured())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "HibernationOptions" + "." + "Configured", StringUtils.FromBool(publicRequest.LaunchTemplateData.HibernationOptions.Configured));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetIamInstanceProfile())
                    {
                        if(publicRequest.LaunchTemplateData.IamInstanceProfile.IsSetArn())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.LaunchTemplateData.IamInstanceProfile.Arn));
                        }
                        if(publicRequest.LaunchTemplateData.IamInstanceProfile.IsSetName())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.LaunchTemplateData.IamInstanceProfile.Name));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetImageId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "ImageId", StringUtils.FromString(publicRequest.LaunchTemplateData.ImageId));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetInstanceInitiatedShutdownBehavior())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceInitiatedShutdownBehavior));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetInstanceMarketOptions())
                    {
                        if(publicRequest.LaunchTemplateData.InstanceMarketOptions.IsSetMarketType())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "MarketType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.MarketType));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceMarketOptions.IsSetSpotOptions())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetBlockDurationMinutes())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "BlockDurationMinutes", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.BlockDurationMinutes));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetInstanceInterruptionBehavior())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.InstanceInterruptionBehavior));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetMaxPrice())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "MaxPrice", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.MaxPrice));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetSpotInstanceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "SpotInstanceType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.SpotInstanceType));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetValidUntilUtc())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "ValidUntil", StringUtils.FromDateTimeToISO8601(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.ValidUntilUtc));
                            }
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetInstanceRequirements())
                    {
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorCount())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorManufacturers())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorManufacturers)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorNames())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorNames)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorTypes())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAllowedInstanceTypes())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.AllowedInstanceTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "AllowedInstanceType" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBareMetal())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.BareMetal));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBurstablePerformance())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.BurstablePerformance));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetCpuManufacturers())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.CpuManufacturers)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetExcludedInstanceTypes())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.ExcludedInstanceTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetInstanceGenerations())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.InstanceGenerations)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetLocalStorage())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.LocalStorage));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetLocalStorageTypes())
                        {
                            int publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex = 1;
                            foreach(var publicRequestLaunchTemplateDataInstanceRequirementslistValue in publicRequest.LaunchTemplateData.InstanceRequirements.LocalStorageTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDataInstanceRequirementslistValue));
                                publicRequestLaunchTemplateDataInstanceRequirementslistValueIndex++;
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetMemoryMiB())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetNetworkBandwidthGbps())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetNetworkInterfaceCount())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetRequireHibernateSupport())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequest.LaunchTemplateData.InstanceRequirements.RequireHibernateSupport));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetTotalLocalStorageGB())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.Min));
                            }
                        }
                        if(publicRequest.LaunchTemplateData.InstanceRequirements.IsSetVCpuCount())
                        {
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.IsSetMax())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.Max));
                            }
                            if(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.IsSetMin())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.Min));
                            }
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetInstanceType())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "InstanceType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceType));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetKernelId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "KernelId", StringUtils.FromString(publicRequest.LaunchTemplateData.KernelId));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetKeyName())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "KeyName", StringUtils.FromString(publicRequest.LaunchTemplateData.KeyName));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetLicenseSpecifications())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.LicenseSpecifications)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetLicenseConfigurationArn())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "LicenseSpecification" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "LicenseConfigurationArn", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.LicenseConfigurationArn));
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetMaintenanceOptions())
                    {
                        if(publicRequest.LaunchTemplateData.MaintenanceOptions.IsSetAutoRecovery())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MaintenanceOptions" + "." + "AutoRecovery", StringUtils.FromString(publicRequest.LaunchTemplateData.MaintenanceOptions.AutoRecovery));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetMetadataOptions())
                    {
                        if(publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpEndpoint())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MetadataOptions" + "." + "HttpEndpoint", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpEndpoint));
                        }
                        if(publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpProtocolIpv6())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MetadataOptions" + "." + "HttpProtocolIpv6", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpProtocolIpv6));
                        }
                        if(publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpPutResponseHopLimit())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MetadataOptions" + "." + "HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.LaunchTemplateData.MetadataOptions.HttpPutResponseHopLimit));
                        }
                        if(publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpTokens())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MetadataOptions" + "." + "HttpTokens", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpTokens));
                        }
                        if(publicRequest.LaunchTemplateData.MetadataOptions.IsSetInstanceMetadataTags())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "MetadataOptions" + "." + "InstanceMetadataTags", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.InstanceMetadataTags));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetMonitoring())
                    {
                        if(publicRequest.LaunchTemplateData.Monitoring.IsSetEnabled())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Monitoring" + "." + "Enabled", StringUtils.FromBool(publicRequest.LaunchTemplateData.Monitoring.Enabled));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetNetworkInterfaces())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.NetworkInterfaces)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetAssociateCarrierIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValue.AssociateCarrierIpAddress));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValue.AssociatePublicIpAddress));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValue.DeleteOnTermination));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetDescription())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Description", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.Description));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.DeviceIndex));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetGroups())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.Groups)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "SecurityGroupId" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue));
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetInterfaceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.InterfaceType));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv4PrefixCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ipv4PrefixCount));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv4Prefixes())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.Ipv4Prefixes)
                                {
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetIpv4Prefix())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.Ipv4Prefix));
                                    }
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv6AddressCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ipv6AddressCount));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv6Addresses())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.Ipv6Addresses)
                                {
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetIpv6Address())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.Ipv6Address));
                                    }
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv6PrefixCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.Ipv6PrefixCount));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetIpv6Prefixes())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.Ipv6Prefixes)
                                {
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetIpv6Prefix())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.Ipv6Prefix));
                                    }
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetNetworkCardIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.NetworkCardIndex));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.NetworkInterfaceId));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.PrivateIpAddress));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetPrivateIpAddresses())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.PrivateIpAddresses)
                                {
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetPrimary())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestLaunchTemplateDatalistValuelistValue.Primary));
                                    }
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.PrivateIpAddress));
                                    }
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetSecondaryPrivateIpAddressCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestLaunchTemplateDatalistValue.SecondaryPrivateIpAddressCount));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "NetworkInterface" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.SubnetId));
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetPlacement())
                    {
                        if(publicRequest.LaunchTemplateData.Placement.IsSetAffinity())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.Affinity));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.AvailabilityZone));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetGroupId())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "GroupId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.GroupId));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.GroupName));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetHostId())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.HostId));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetHostResourceGroupArn())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.HostResourceGroupArn));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetPartitionNumber())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequest.LaunchTemplateData.Placement.PartitionNumber));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetSpreadDomain())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.SpreadDomain));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetTenancy())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.Tenancy));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetPrivateDnsNameOptions())
                    {
                        if(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetEnableResourceNameDnsAAAARecord())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "PrivateDnsNameOptions" + "." + "EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.EnableResourceNameDnsAAAARecord));
                        }
                        if(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetEnableResourceNameDnsARecord())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "PrivateDnsNameOptions" + "." + "EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.EnableResourceNameDnsARecord));
                        }
                        if(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetHostnameType())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "PrivateDnsNameOptions" + "." + "HostnameType", StringUtils.FromString(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.HostnameType));
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetRamDiskId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "RamDiskId", StringUtils.FromString(publicRequest.LaunchTemplateData.RamDiskId));
                    }
                    if(publicRequest.LaunchTemplateData.IsSetSecurityGroupIds())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.SecurityGroupIds)
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "SecurityGroupId" + "." + publicRequestLaunchTemplateDatalistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDatalistValue));
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetSecurityGroups())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.SecurityGroups)
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "SecurityGroup" + "." + publicRequestLaunchTemplateDatalistValueIndex, StringUtils.FromString(publicRequestLaunchTemplateDatalistValue));
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetTagSpecifications())
                    {
                        int publicRequestLaunchTemplateDatalistValueIndex = 1;
                        foreach(var publicRequestLaunchTemplateDatalistValue in publicRequest.LaunchTemplateData.TagSpecifications)
                        {
                            if(publicRequestLaunchTemplateDatalistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "TagSpecification" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestLaunchTemplateDatalistValue.ResourceType));
                            }
                            if(publicRequestLaunchTemplateDatalistValue.IsSetTags())
                            {
                                int publicRequestLaunchTemplateDatalistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchTemplateDatalistValuelistValue in publicRequestLaunchTemplateDatalistValue.Tags)
                                {
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetKey())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "TagSpecification" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Tag" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.Key));
                                    }
                                    if(publicRequestLaunchTemplateDatalistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + "." + "TagSpecification" + "." + publicRequestLaunchTemplateDatalistValueIndex + "." + "Tag" + "." + publicRequestLaunchTemplateDatalistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestLaunchTemplateDatalistValuelistValue.Value));
                                    }
                                    publicRequestLaunchTemplateDatalistValuelistValueIndex++;
                                }
                            }
                            publicRequestLaunchTemplateDatalistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchTemplateData.IsSetUserData())
                    {
                        request.Parameters.Add("LaunchTemplateData" + "." + "UserData", StringUtils.FromString(publicRequest.LaunchTemplateData.UserData));
                    }
                }
                if(publicRequest.IsSetLaunchTemplateId())
                {
                    request.Parameters.Add("LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplateId));
                }
                if(publicRequest.IsSetLaunchTemplateName())
                {
                    request.Parameters.Add("LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplateName));
                }
                if(publicRequest.IsSetResolveAlias())
                {
                    request.Parameters.Add("ResolveAlias", StringUtils.FromBool(publicRequest.ResolveAlias));
                }
                if(publicRequest.IsSetSourceVersion())
                {
                    request.Parameters.Add("SourceVersion", StringUtils.FromString(publicRequest.SourceVersion));
                }
                if(publicRequest.IsSetVersionDescription())
                {
                    request.Parameters.Add("VersionDescription", StringUtils.FromString(publicRequest.VersionDescription));
                }
            }
            return request;
        }
                    private static CreateLaunchTemplateVersionRequestMarshaller _instance = new CreateLaunchTemplateVersionRequestMarshaller();        

        internal static CreateLaunchTemplateVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLaunchTemplateVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}