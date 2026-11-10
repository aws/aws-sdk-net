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
    /// CreateLaunchTemplateVersion Request Marshaller
    /// </summary>
    public partial class CreateLaunchTemplateVersionRequestMarshaller : IMarshaller<IRequest, CreateLaunchTemplateVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchTemplateVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLaunchTemplateVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateLaunchTemplateVersion");
            request.Parameters.Add("Version", "2016-11-15");

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
            if (publicRequest.IsSetLaunchTemplateData())
            {
                if (publicRequest.LaunchTemplateData.IsSetBlockDeviceMappings())
                {
                    if (publicRequest.LaunchTemplateData.BlockDeviceMappings.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.BlockDeviceMappings)
                        {
                            if (item1.IsSetDeviceName())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".DeviceName", StringUtils.FromString(item1.DeviceName));
                            }
                            if (item1.IsSetEbs())
                            {
                                if (item1.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item1.Ebs.DeleteOnTermination.Value));
                                }
                                if (item1.Ebs.IsSetEbsCardIndex())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".EbsCardIndex", StringUtils.FromInt(item1.Ebs.EbsCardIndex.Value));
                                }
                                if (item1.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item1.Ebs.Encrypted.Value));
                                }
                                if (item1.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Iops", StringUtils.FromInt(item1.Ebs.Iops.Value));
                                }
                                if (item1.Ebs.IsSetKmsKeyId())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item1.Ebs.KmsKeyId));
                                }
                                if (item1.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item1.Ebs.SnapshotId));
                                }
                                if (item1.Ebs.IsSetThroughput())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Throughput", StringUtils.FromInt(item1.Ebs.Throughput.Value));
                                }
                                if (item1.Ebs.IsSetVolumeInitializationRate())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeInitializationRate", StringUtils.FromInt(item1.Ebs.VolumeInitializationRate.Value));
                                }
                                if (item1.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item1.Ebs.VolumeSize.Value));
                                }
                                if (item1.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeType", StringUtils.FromString(item1.Ebs.VolumeType));
                                }
                            }
                            if (item1.IsSetNoDevice())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".NoDevice", StringUtils.FromString(item1.NoDevice));
                            }
                            if (item1.IsSetVirtualName())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".BlockDeviceMapping" + "." + index1 + ".VirtualName", StringUtils.FromString(item1.VirtualName));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetCapacityReservationSpecification())
                {
                    if (publicRequest.LaunchTemplateData.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CapacityReservationSpecification" + ".CapacityReservationPreference", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationPreference));
                    }
                    if (publicRequest.LaunchTemplateData.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                    {
                        if (publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationId", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                        }
                        if (publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.LaunchTemplateData.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetCpuOptions())
                {
                    if (publicRequest.LaunchTemplateData.CpuOptions.IsSetAmdSevSnp())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CpuOptions" + ".AmdSevSnp", StringUtils.FromString(publicRequest.LaunchTemplateData.CpuOptions.AmdSevSnp));
                    }
                    if (publicRequest.LaunchTemplateData.CpuOptions.IsSetCoreCount())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CpuOptions" + ".CoreCount", StringUtils.FromInt(publicRequest.LaunchTemplateData.CpuOptions.CoreCount.Value));
                    }
                    if (publicRequest.LaunchTemplateData.CpuOptions.IsSetNestedVirtualization())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CpuOptions" + ".NestedVirtualization", StringUtils.FromString(publicRequest.LaunchTemplateData.CpuOptions.NestedVirtualization));
                    }
                    if (publicRequest.LaunchTemplateData.CpuOptions.IsSetThreadsPerCore())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CpuOptions" + ".ThreadsPerCore", StringUtils.FromInt(publicRequest.LaunchTemplateData.CpuOptions.ThreadsPerCore.Value));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetCreditSpecification())
                {
                    if (publicRequest.LaunchTemplateData.CreditSpecification.IsSetCpuCredits())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".CreditSpecification" + ".CpuCredits", StringUtils.FromString(publicRequest.LaunchTemplateData.CreditSpecification.CpuCredits));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetDisableApiStop())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".DisableApiStop", StringUtils.FromBool(publicRequest.LaunchTemplateData.DisableApiStop.Value));
                }
                if (publicRequest.LaunchTemplateData.IsSetDisableApiTermination())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".DisableApiTermination", StringUtils.FromBool(publicRequest.LaunchTemplateData.DisableApiTermination.Value));
                }
                if (publicRequest.LaunchTemplateData.IsSetEbsOptimized())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".EbsOptimized", StringUtils.FromBool(publicRequest.LaunchTemplateData.EbsOptimized.Value));
                }
                if (publicRequest.LaunchTemplateData.IsSetElasticGpuSpecifications())
                {
                    if (publicRequest.LaunchTemplateData.ElasticGpuSpecifications.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".ElasticGpuSpecification", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.ElasticGpuSpecifications)
                        {
                            if (item1.IsSetType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".ElasticGpuSpecification" + "." + index1 + ".Type", StringUtils.FromString(item1.Type));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetElasticInferenceAccelerators())
                {
                    if (publicRequest.LaunchTemplateData.ElasticInferenceAccelerators.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".ElasticInferenceAccelerator", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.ElasticInferenceAccelerators)
                        {
                            if (item1.IsSetCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".ElasticInferenceAccelerator" + "." + index1 + ".Count", StringUtils.FromInt(item1.Count.Value));
                            }
                            if (item1.IsSetType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".ElasticInferenceAccelerator" + "." + index1 + ".Type", StringUtils.FromString(item1.Type));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetEnclaveOptions())
                {
                    if (publicRequest.LaunchTemplateData.EnclaveOptions.IsSetEnabled())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".EnclaveOptions" + ".Enabled", StringUtils.FromBool(publicRequest.LaunchTemplateData.EnclaveOptions.Enabled.Value));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetHibernationOptions())
                {
                    if (publicRequest.LaunchTemplateData.HibernationOptions.IsSetConfigured())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".HibernationOptions" + ".Configured", StringUtils.FromBool(publicRequest.LaunchTemplateData.HibernationOptions.Configured.Value));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetIamInstanceProfile())
                {
                    if (publicRequest.LaunchTemplateData.IamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".IamInstanceProfile" + ".Arn", StringUtils.FromString(publicRequest.LaunchTemplateData.IamInstanceProfile.Arn));
                    }
                    if (publicRequest.LaunchTemplateData.IamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".IamInstanceProfile" + ".Name", StringUtils.FromString(publicRequest.LaunchTemplateData.IamInstanceProfile.Name));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetImageId())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".ImageId", StringUtils.FromString(publicRequest.LaunchTemplateData.ImageId));
                }
                if (publicRequest.LaunchTemplateData.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceInitiatedShutdownBehavior));
                }
                if (publicRequest.LaunchTemplateData.IsSetInstanceMarketOptions())
                {
                    if (publicRequest.LaunchTemplateData.InstanceMarketOptions.IsSetMarketType())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".MarketType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.MarketType));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceMarketOptions.IsSetSpotOptions())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetBlockDurationMinutes())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".SpotOptions" + ".BlockDurationMinutes", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.BlockDurationMinutes.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetInstanceInterruptionBehavior())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".SpotOptions" + ".InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.InstanceInterruptionBehavior));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetMaxPrice())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".SpotOptions" + ".MaxPrice", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.MaxPrice));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetSpotInstanceType())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".SpotOptions" + ".SpotInstanceType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.SpotInstanceType));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetValidUntil())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceMarketOptions" + ".SpotOptions" + ".ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.ValidUntil.Value));
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetInstanceRequirements())
                {
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorCount())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorCount" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorCount" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorCount.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorManufacturers())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorManufacturer", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorManufacturers)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorManufacturer" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorNames())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorNames.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorName", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorNames)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorName" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorTotalMemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTotalMemoryMiB.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAcceleratorTypes())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTypes.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.AcceleratorTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AcceleratorType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetAllowedInstanceTypes())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AllowedInstanceType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.AllowedInstanceTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".AllowedInstanceType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBareMetal())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BareMetal", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.BareMetal));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BaselineEbsBandwidthMbps" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.BaselineEbsBandwidthMbps.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBaselinePerformanceFactors())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                        {
                            if (publicRequest.LaunchTemplateData.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                            {
                                if (publicRequest.LaunchTemplateData.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference", "");
                                }
                                else
                                {
                                    int index4 = 1;
                                    foreach (var item4 in publicRequest.LaunchTemplateData.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                    {
                                        if (item4.IsSetInstanceFamily())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BaselinePerformanceFactors" + ".Cpu" + ".Reference" + "." + index4 + ".InstanceFamily", StringUtils.FromString(item4.InstanceFamily));
                                        }
                                        index4++;
                                    }
                                }
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetBurstablePerformance())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".BurstablePerformance", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.BurstablePerformance));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetCpuManufacturers())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.CpuManufacturers.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".CpuManufacturer", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.CpuManufacturers)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".CpuManufacturer" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetExcludedInstanceTypes())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".ExcludedInstanceType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.ExcludedInstanceTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".ExcludedInstanceType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetInstanceGenerations())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.InstanceGenerations.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".InstanceGeneration", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.InstanceGenerations)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".InstanceGeneration" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetLocalStorage())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".LocalStorage", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceRequirements.LocalStorage));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetLocalStorageTypes())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.LocalStorageTypes.Count == 0)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".LocalStorageType", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.LaunchTemplateData.InstanceRequirements.LocalStorageTypes)
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".LocalStorageType" + "." + index2, StringUtils.FromString(item2));
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".MemoryGiBPerVCpu" + ".Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryGiBPerVCpu.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetMemoryMiB())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".MemoryMiB" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".MemoryMiB" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.MemoryMiB.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetNetworkBandwidthGbps())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".NetworkBandwidthGbps" + ".Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkBandwidthGbps.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetNetworkInterfaceCount())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".NetworkInterfaceCount" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.NetworkInterfaceCount.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice.Value));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetRequireEncryptionInTransit())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".RequireEncryptionInTransit", StringUtils.FromBool(publicRequest.LaunchTemplateData.InstanceRequirements.RequireEncryptionInTransit.Value));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetRequireHibernateSupport())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".RequireHibernateSupport", StringUtils.FromBool(publicRequest.LaunchTemplateData.InstanceRequirements.RequireHibernateSupport.Value));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice.Value));
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetTotalLocalStorageGB())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Max", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".TotalLocalStorageGB" + ".Min", StringUtils.FromDouble(publicRequest.LaunchTemplateData.InstanceRequirements.TotalLocalStorageGB.Min.Value));
                        }
                    }
                    if (publicRequest.LaunchTemplateData.InstanceRequirements.IsSetVCpuCount())
                    {
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.IsSetMax())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".VCpuCount" + ".Max", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.Max.Value));
                        }
                        if (publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.IsSetMin())
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".InstanceRequirements" + ".VCpuCount" + ".Min", StringUtils.FromInt(publicRequest.LaunchTemplateData.InstanceRequirements.VCpuCount.Min.Value));
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetInstanceType())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".InstanceType", StringUtils.FromString(publicRequest.LaunchTemplateData.InstanceType));
                }
                if (publicRequest.LaunchTemplateData.IsSetKernelId())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".KernelId", StringUtils.FromString(publicRequest.LaunchTemplateData.KernelId));
                }
                if (publicRequest.LaunchTemplateData.IsSetKeyName())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".KeyName", StringUtils.FromString(publicRequest.LaunchTemplateData.KeyName));
                }
                if (publicRequest.LaunchTemplateData.IsSetLicenseSpecifications())
                {
                    if (publicRequest.LaunchTemplateData.LicenseSpecifications.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".LicenseSpecification", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.LicenseSpecifications)
                        {
                            if (item1.IsSetLicenseConfigurationArn())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".LicenseSpecification" + "." + index1 + ".LicenseConfigurationArn", StringUtils.FromString(item1.LicenseConfigurationArn));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetMaintenanceOptions())
                {
                    if (publicRequest.LaunchTemplateData.MaintenanceOptions.IsSetAutoRecovery())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MaintenanceOptions" + ".AutoRecovery", StringUtils.FromString(publicRequest.LaunchTemplateData.MaintenanceOptions.AutoRecovery));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetMetadataOptions())
                {
                    if (publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpEndpoint())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MetadataOptions" + ".HttpEndpoint", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpEndpoint));
                    }
                    if (publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpProtocolIpv6())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MetadataOptions" + ".HttpProtocolIpv6", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpProtocolIpv6));
                    }
                    if (publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpPutResponseHopLimit())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MetadataOptions" + ".HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.LaunchTemplateData.MetadataOptions.HttpPutResponseHopLimit.Value));
                    }
                    if (publicRequest.LaunchTemplateData.MetadataOptions.IsSetHttpTokens())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MetadataOptions" + ".HttpTokens", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.HttpTokens));
                    }
                    if (publicRequest.LaunchTemplateData.MetadataOptions.IsSetInstanceMetadataTags())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".MetadataOptions" + ".InstanceMetadataTags", StringUtils.FromString(publicRequest.LaunchTemplateData.MetadataOptions.InstanceMetadataTags));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetMonitoring())
                {
                    if (publicRequest.LaunchTemplateData.Monitoring.IsSetEnabled())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Monitoring" + ".Enabled", StringUtils.FromBool(publicRequest.LaunchTemplateData.Monitoring.Enabled.Value));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetNetworkInterfaces())
                {
                    if (publicRequest.LaunchTemplateData.NetworkInterfaces.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.NetworkInterfaces)
                        {
                            if (item1.IsSetAssociateCarrierIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".AssociateCarrierIpAddress", StringUtils.FromBool(item1.AssociateCarrierIpAddress.Value));
                            }
                            if (item1.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".AssociatePublicIpAddress", StringUtils.FromBool(item1.AssociatePublicIpAddress.Value));
                            }
                            if (item1.IsSetConnectionTrackingSpecification())
                            {
                                if (item1.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".TcpEstablishedTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.TcpEstablishedTimeout.Value));
                                }
                                if (item1.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".UdpStreamTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.UdpStreamTimeout.Value));
                                }
                                if (item1.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".UdpTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.UdpTimeout.Value));
                                }
                            }
                            if (item1.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".DeleteOnTermination", StringUtils.FromBool(item1.DeleteOnTermination.Value));
                            }
                            if (item1.IsSetDescription())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                            }
                            if (item1.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".DeviceIndex", StringUtils.FromInt(item1.DeviceIndex.Value));
                            }
                            if (item1.IsSetEnaQueueCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".EnaQueueCount", StringUtils.FromInt(item1.EnaQueueCount.Value));
                            }
                            if (item1.IsSetEnaSrdSpecification())
                            {
                                if (item1.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".EnaSrdSpecification" + ".EnaSrdEnabled", StringUtils.FromBool(item1.EnaSrdSpecification.EnaSrdEnabled.Value));
                                }
                                if (item1.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                {
                                    if (item1.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".EnaSrdSpecification" + ".EnaSrdUdpSpecification" + ".EnaSrdUdpEnabled", StringUtils.FromBool(item1.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled.Value));
                                    }
                                }
                            }
                            if (item1.IsSetGroups())
                            {
                                if (item1.Groups.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".SecurityGroupId", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Groups)
                                    {
                                        request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".SecurityGroupId" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetInterfaceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".InterfaceType", StringUtils.FromString(item1.InterfaceType));
                            }
                            if (item1.IsSetIpv4PrefixCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv4PrefixCount", StringUtils.FromInt(item1.Ipv4PrefixCount.Value));
                            }
                            if (item1.IsSetIpv4Prefixes())
                            {
                                if (item1.Ipv4Prefixes.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv4Prefix", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv4Prefixes)
                                    {
                                        if (item2.IsSetIpv4Prefix())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv4Prefix" + "." + index2 + ".Ipv4Prefix", StringUtils.FromString(item2.Ipv4Prefix));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetIpv6AddressCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6AddressCount", StringUtils.FromInt(item1.Ipv6AddressCount.Value));
                            }
                            if (item1.IsSetIpv6Addresses())
                            {
                                if (item1.Ipv6Addresses.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6Addresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv6Addresses)
                                    {
                                        if (item2.IsSetIpv6Address())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6Addresses" + "." + index2 + ".Ipv6Address", StringUtils.FromString(item2.Ipv6Address));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetIpv6PrefixCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6PrefixCount", StringUtils.FromInt(item1.Ipv6PrefixCount.Value));
                            }
                            if (item1.IsSetIpv6Prefixes())
                            {
                                if (item1.Ipv6Prefixes.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6Prefix", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv6Prefixes)
                                    {
                                        if (item2.IsSetIpv6Prefix())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".Ipv6Prefix" + "." + index2 + ".Ipv6Prefix", StringUtils.FromString(item2.Ipv6Prefix));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetNetworkCardIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".NetworkCardIndex", StringUtils.FromInt(item1.NetworkCardIndex.Value));
                            }
                            if (item1.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".NetworkInterfaceId", StringUtils.FromString(item1.NetworkInterfaceId));
                            }
                            if (item1.IsSetPrimaryIpv6())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".PrimaryIpv6", StringUtils.FromBool(item1.PrimaryIpv6.Value));
                            }
                            if (item1.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddress", StringUtils.FromString(item1.PrivateIpAddress));
                            }
                            if (item1.IsSetPrivateIpAddresses())
                            {
                                if (item1.PrivateIpAddresses.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.PrivateIpAddresses)
                                    {
                                        if (item2.IsSetPrimary())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses" + "." + index2 + ".Primary", StringUtils.FromBool(item2.Primary.Value));
                                        }
                                        if (item2.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses" + "." + index2 + ".PrivateIpAddress", StringUtils.FromString(item2.PrivateIpAddress));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetSecondaryPrivateIpAddressCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(item1.SecondaryPrivateIpAddressCount.Value));
                            }
                            if (item1.IsSetSubnetId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".NetworkInterface" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetNetworkPerformanceOptions())
                {
                    if (publicRequest.LaunchTemplateData.NetworkPerformanceOptions.IsSetBandwidthWeighting())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".NetworkPerformanceOptions" + ".BandwidthWeighting", StringUtils.FromString(publicRequest.LaunchTemplateData.NetworkPerformanceOptions.BandwidthWeighting));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetOperator())
                {
                    if (publicRequest.LaunchTemplateData.Operator.IsSetPrincipal())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Operator" + ".Principal", StringUtils.FromString(publicRequest.LaunchTemplateData.Operator.Principal));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetPlacement())
                {
                    if (publicRequest.LaunchTemplateData.Placement.IsSetAffinity())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".Affinity", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.Affinity));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".AvailabilityZone", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.AvailabilityZone));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetAvailabilityZoneId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".AvailabilityZoneId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.AvailabilityZoneId));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetGroupId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".GroupId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.GroupId));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".GroupName", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.GroupName));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetHostId())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".HostId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.HostId));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetHostResourceGroupArn())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".HostResourceGroupArn", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.HostResourceGroupArn));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetPartitionNumber())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".PartitionNumber", StringUtils.FromInt(publicRequest.LaunchTemplateData.Placement.PartitionNumber.Value));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetSpreadDomain())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".SpreadDomain", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.SpreadDomain));
                    }
                    if (publicRequest.LaunchTemplateData.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".Placement" + ".Tenancy", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.Tenancy));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetPrivateDnsNameOptions())
                {
                    if (publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetEnableResourceNameDnsAAAARecord())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".PrivateDnsNameOptions" + ".EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.EnableResourceNameDnsAAAARecord.Value));
                    }
                    if (publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetEnableResourceNameDnsARecord())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".PrivateDnsNameOptions" + ".EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.EnableResourceNameDnsARecord.Value));
                    }
                    if (publicRequest.LaunchTemplateData.PrivateDnsNameOptions.IsSetHostnameType())
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".PrivateDnsNameOptions" + ".HostnameType", StringUtils.FromString(publicRequest.LaunchTemplateData.PrivateDnsNameOptions.HostnameType));
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetRamDiskId())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".RamDiskId", StringUtils.FromString(publicRequest.LaunchTemplateData.RamDiskId));
                }
                if (publicRequest.LaunchTemplateData.IsSetSecondaryInterfaces())
                {
                    if (publicRequest.LaunchTemplateData.SecondaryInterfaces.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.SecondaryInterfaces)
                        {
                            if (item1.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".DeleteOnTermination", StringUtils.FromBool(item1.DeleteOnTermination.Value));
                            }
                            if (item1.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".DeviceIndex", StringUtils.FromInt(item1.DeviceIndex.Value));
                            }
                            if (item1.IsSetInterfaceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".InterfaceType", StringUtils.FromString(item1.InterfaceType));
                            }
                            if (item1.IsSetNetworkCardIndex())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".NetworkCardIndex", StringUtils.FromInt(item1.NetworkCardIndex.Value));
                            }
                            if (item1.IsSetPrivateIpAddressCount())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".PrivateIpAddressCount", StringUtils.FromInt(item1.PrivateIpAddressCount.Value));
                            }
                            if (item1.IsSetPrivateIpAddresses())
                            {
                                if (item1.PrivateIpAddresses.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".PrivateIpAddress", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.PrivateIpAddresses)
                                    {
                                        if (item2.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".PrivateIpAddress" + "." + index2 + ".PrivateIpAddress", StringUtils.FromString(item2.PrivateIpAddress));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetSecondarySubnetId())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".SecondaryInterface" + "." + index1 + ".SecondarySubnetId", StringUtils.FromString(item1.SecondarySubnetId));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetSecurityGroupIds())
                {
                    if (publicRequest.LaunchTemplateData.SecurityGroupIds.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".SecurityGroupId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.SecurityGroupIds)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".SecurityGroupId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetSecurityGroups())
                {
                    if (publicRequest.LaunchTemplateData.SecurityGroups.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".SecurityGroup", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.SecurityGroups)
                        {
                            request.Parameters.Add("LaunchTemplateData" + ".SecurityGroup" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetTagSpecifications())
                {
                    if (publicRequest.LaunchTemplateData.TagSpecifications.Count == 0)
                    {
                        request.Parameters.Add("LaunchTemplateData" + ".TagSpecification", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchTemplateData.TagSpecifications)
                        {
                            if (item1.IsSetResourceType())
                            {
                                request.Parameters.Add("LaunchTemplateData" + ".TagSpecification" + "." + index1 + ".ResourceType", StringUtils.FromString(item1.ResourceType));
                            }
                            if (item1.IsSetTags())
                            {
                                if (item1.Tags.Count == 0)
                                {
                                    request.Parameters.Add("LaunchTemplateData" + ".TagSpecification" + "." + index1 + ".Tag", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Tags)
                                    {
                                        if (item2.IsSetKey())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".TagSpecification" + "." + index1 + ".Tag" + "." + index2 + ".Key", StringUtils.FromString(item2.Key));
                                        }
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("LaunchTemplateData" + ".TagSpecification" + "." + index1 + ".Tag" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchTemplateData.IsSetUserData())
                {
                    request.Parameters.Add("LaunchTemplateData" + ".UserData", StringUtils.FromString(publicRequest.LaunchTemplateData.UserData));
                }
            }
            if (publicRequest.IsSetLaunchTemplateId())
            {
                request.Parameters.Add("LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplateId));
            }
            if (publicRequest.IsSetLaunchTemplateName())
            {
                request.Parameters.Add("LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplateName));
            }
            if (publicRequest.IsSetResolveAlias())
            {
                request.Parameters.Add("ResolveAlias", StringUtils.FromBool(publicRequest.ResolveAlias.Value));
            }
            if (publicRequest.IsSetSourceVersion())
            {
                request.Parameters.Add("SourceVersion", StringUtils.FromString(publicRequest.SourceVersion));
            }
            if (publicRequest.IsSetVersionDescription())
            {
                request.Parameters.Add("VersionDescription", StringUtils.FromString(publicRequest.VersionDescription));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateLaunchTemplateVersionRequestMarshaller _instance = new();

        internal static CreateLaunchTemplateVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLaunchTemplateVersionRequestMarshaller Instance => _instance;
    }
}
