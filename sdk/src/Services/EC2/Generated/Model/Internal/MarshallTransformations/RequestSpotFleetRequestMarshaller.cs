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
                if(publicRequest.IsSetSpotFleetRequestConfig())
                {
                    if(publicRequest.SpotFleetRequestConfig.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.AllocationStrategy));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetClientToken())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ClientToken", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ClientToken));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetContext())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "Context", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Context));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetExcessCapacityTerminationPolicy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ExcessCapacityTerminationPolicy));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetFulfilledCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "FulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.FulfilledCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetIamFleetRole())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "IamFleetRole", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.IamFleetRole));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.InstanceInterruptionBehavior));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetInstancePoolsToUseCount())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.InstancePoolsToUseCount));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetLaunchSpecifications())
                    {
                        int publicRequestSpotFleetRequestConfiglistValueIndex = 1;
                        foreach(var publicRequestSpotFleetRequestConfiglistValue in publicRequest.SpotFleetRequestConfig.LaunchSpecifications)
                        {
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetAddressingType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "AddressingType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.AddressingType));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetBlockDeviceMappings())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.BlockDeviceMappings)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeviceName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.DeviceName));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEbs())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetDeleteOnTermination())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.DeleteOnTermination));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetEncrypted())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Encrypted));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetIops())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Iops));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetKmsKeyId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.KmsKeyId));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetOutpostArn())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.OutpostArn));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetSnapshotId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.SnapshotId));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetThroughput())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.Throughput));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetVolumeSize())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.VolumeSize));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetVolumeType())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.VolumeType));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNoDevice())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.NoDevice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetVirtualName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.VirtualName));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetEbsOptimized())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "EbsOptimized", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.EbsOptimized));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetIamInstanceProfile())
                            {
                                if(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.IsSetArn())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.Arn));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.IsSetName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.IamInstanceProfile.Name));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetImageId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "ImageId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.ImageId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetInstanceRequirements())
                            {
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorCount())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorCount.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorManufacturers)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorNames())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorNames)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AcceleratorTypes)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.AllowedInstanceTypes)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBareMetal())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BareMetal));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetBurstablePerformance())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.BurstablePerformance));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetCpuManufacturers())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.CpuManufacturers)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.ExcludedInstanceTypes)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetInstanceGenerations())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.InstanceGenerations)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetLocalStorage())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.LocalStorage));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                {
                                    int publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex = 1;
                                    foreach(var publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.LocalStorageTypes)
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValue));
                                        publicRequestSpotFleetRequestConfiglistValueInstanceRequirementslistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetMemoryMiB())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.MemoryMiB.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.RequireHibernateSupport));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.IsSetVCpuCount())
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.Max));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValue.InstanceRequirements.VCpuCount.Min));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetInstanceType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.InstanceType));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetKernelId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "KernelId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.KernelId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetKeyName())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "KeyName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.KeyName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetMonitoring())
                            {
                                if(publicRequestSpotFleetRequestConfiglistValue.Monitoring.IsSetEnabled())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Monitoring" + "." + "Enabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.Monitoring.Enabled));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetNetworkInterfaces())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.NetworkInterfaces)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAssociateCarrierIpAddress())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.AssociateCarrierIpAddress));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAssociatePublicIpAddress())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.AssociatePublicIpAddress));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetConnectionTrackingSpecification())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.UdpStreamTimeout));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.ConnectionTrackingSpecification.UdpTimeout));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeleteOnTermination())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.DeleteOnTermination));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDescription())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Description));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeviceIndex())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.DeviceIndex));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEnaSrdSpecification())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdEnabled));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroups())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Groups)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecurityGroupId" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue));
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInterfaceType())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InterfaceType));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv4PrefixCount())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv4PrefixCount));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv4Prefixes())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv4Prefixes)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv4Prefix())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv4Prefix));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6AddressCount())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6AddressCount));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6Addresses())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Addresses)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv6Address())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv6Address));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIsPrimaryIpv6())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsPrimaryIpv6));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6PrefixCount())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6PrefixCount));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6Prefixes())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Prefixes)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv6Prefix())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv6Prefix));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNetworkCardIndex())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.NetworkCardIndex));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNetworkInterfaceId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.NetworkInterfaceId));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrimaryIpv6())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrimaryIpv6", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.PrimaryIpv6));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddress));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddresses())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddresses)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrimary())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Primary));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrivateIpAddress())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.PrivateIpAddress));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSecondaryPrivateIpAddressCount())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.SecondaryPrivateIpAddressCount));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSubnetId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SubnetId));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetPlacement())
                            {
                                if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.AvailabilityZone));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetGroupName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.GroupName));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.Placement.IsSetTenancy())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.Placement.Tenancy));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetRamdiskId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "RamdiskId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.RamdiskId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetSecurityGroups())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.SecurityGroups)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroupId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "GroupSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "GroupId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.GroupId));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroupName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "GroupSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "GroupName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.GroupName));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetSpotPrice())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.SpotPrice));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.SubnetId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetTagSpecifications())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.TagSpecifications)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetResourceType())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.ResourceType));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetTags())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Tags)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetKey())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Key));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetValue())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Value));
                                            }
#pragma warning restore CS0612,CS0618
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetUserData())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "UserData", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.UserData));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetWeightedCapacity())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValue.WeightedCapacity));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestSpotFleetRequestConfiglistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetLaunchTemplateConfigs())
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
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.LaunchTemplateName));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.IsSetVersion())
                                {
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.LaunchTemplateSpecification.Version));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetOverrides())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.Overrides)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.AvailabilityZone));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInstanceRequirements())
                                    {
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorNames)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.AllowedInstanceTypes)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BareMetal));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.BurstablePerformance));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.CpuManufacturers)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.InstanceGenerations)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.LocalStorage));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                        {
                                            int publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex = 1;
                                            foreach(var publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValue));
                                                publicRequestSpotFleetRequestConfiglistValuelistValueInstanceRequirementslistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceType));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPriority())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.Priority));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSpotPrice())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SpotPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetSubnetId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.SubnetId));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetWeightedCapacity())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestSpotFleetRequestConfiglistValuelistValue.WeightedCapacity));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestSpotFleetRequestConfiglistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetLoadBalancersConfig())
                    {
                        if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetClassicLoadBalancersConfig())
                        {
                            if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.IsSetClassicLoadBalancers())
                            {
                                int publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.ClassicLoadBalancersConfig.ClassicLoadBalancers)
                                {
                                    if(publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue.IsSetName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "ClassicLoadBalancersConfig" + "." + "ClassicLoadBalancers" + "." + publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex + "." + "Name", StringUtils.FromString(publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValue.Name));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.IsSetTargetGroupsConfig())
                        {
                            if(publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.IsSetTargetGroups())
                            {
                                int publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue in publicRequest.SpotFleetRequestConfig.LoadBalancersConfig.TargetGroupsConfig.TargetGroups)
                                {
                                    if(publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue.IsSetArn())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LoadBalancersConfig" + "." + "TargetGroupsConfig" + "." + "TargetGroups" + "." + publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex + "." + "Arn", StringUtils.FromString(publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValue.Arn));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandAllocationStrategy())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandAllocationStrategy));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandFulfilledCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandFulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.OnDemandFulfilledCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.OnDemandMaxTotalPrice));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.OnDemandTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetReplaceUnhealthyInstances())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.ReplaceUnhealthyInstances));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotMaintenanceStrategies())
                    {
                        if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.IsSetCapacityRebalance())
                        {
                            if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaintenanceStrategies" + "." + "CapacityRebalance" + "." + "ReplacementStrategy", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaintenanceStrategies" + "." + "CapacityRebalance" + "." + "TerminationDelay", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.SpotMaintenanceStrategies.CapacityRebalance.TerminationDelay));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotMaxTotalPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotMaxTotalPrice));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotPrice));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetTagSpecifications())
                    {
                        int publicRequestSpotFleetRequestConfiglistValueIndex = 1;
                        foreach(var publicRequestSpotFleetRequestConfiglistValue in publicRequest.SpotFleetRequestConfig.TagSpecifications)
                        {
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.ResourceType));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetTags())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.Tags)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetKey())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Key));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TagSpecification" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Tag" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestSpotFleetRequestConfiglistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.TargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetTargetCapacityUnitType())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TargetCapacityUnitType", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.TargetCapacityUnitType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetTerminateInstancesWithExpiration())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.TerminateInstancesWithExpiration));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetType())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "Type", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.Type));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetValidFromUtc())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidFrom", Amazon.EC2.Internal.CustomMarshallTransformations.ConvertDateTimeISOWithoutMillisecondsUtc(publicRequest.SpotFleetRequestConfig.ValidFromUtc));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotFleetRequestConfig.IsSetValidUntilUtc())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidUntil", Amazon.EC2.Internal.CustomMarshallTransformations.ConvertDateTimeISOWithoutMillisecondsUtc(publicRequest.SpotFleetRequestConfig.ValidUntilUtc));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
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