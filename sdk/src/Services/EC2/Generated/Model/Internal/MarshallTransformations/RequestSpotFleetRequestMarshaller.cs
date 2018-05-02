/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                    if(publicRequest.SpotFleetRequestConfig.IsSetClientToken())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ClientToken", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ClientToken));
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
                    if(publicRequest.SpotFleetRequestConfig.IsSetLaunchSpecifications())
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
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.BlockDeviceMappings)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetDeviceName())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.DeviceName));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetEbs())
                                    {
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
                                        if(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.IsSetSnapshotId())
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "BlockDeviceMapping" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.Ebs.SnapshotId));
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
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.NetworkInterfaces)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAssociatePublicIpAddress())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValue.AssociatePublicIpAddress));
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
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetGroups())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Groups)
                                        {
                                            request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "SecurityGroupId" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue));
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6AddressCount())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6AddressCount));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetIpv6Addresses())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.Ipv6Addresses)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetIpv6Address())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "Ipv6AddressesSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Ipv6Address));
                                            }
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
                                        }
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetNetworkInterfaceId())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.NetworkInterfaceId));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddress));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetPrivateIpAddresses())
                                    {
                                        int publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex = 1;
                                        foreach(var publicRequestSpotFleetRequestConfiglistValuelistValuelistValue in publicRequestSpotFleetRequestConfiglistValuelistValue.PrivateIpAddresses)
                                        {
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrimary())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddressesSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.Primary));
                                            }
                                            if(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.IsSetPrivateIpAddress())
                                            {
                                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "NetworkInterfaceSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "PrivateIpAddressesSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValuelistValue.PrivateIpAddress));
                                            }
                                            publicRequestSpotFleetRequestConfiglistValuelistValuelistValueIndex++;
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
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.TagSpecifications)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetResourceType())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "TagSpecificationSet" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.ResourceType));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetTags())
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
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
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
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.Overrides)
                                {
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.AvailabilityZone));
                                    }
                                    if(publicRequestSpotFleetRequestConfiglistValuelistValue.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchTemplateConfigs" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Overrides" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue.InstanceType));
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
                            publicRequestSpotFleetRequestConfiglistValueIndex++;
                        }
                    }
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
                                    publicRequestSpotFleetRequestConfigLoadBalancersConfigClassicLoadBalancersConfiglistValueIndex++;
                                }
                            }
                        }
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
                                    publicRequestSpotFleetRequestConfigLoadBalancersConfigTargetGroupsConfiglistValueIndex++;
                                }
                            }
                        }
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandFulfilledCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandFulfilledCapacity", StringUtils.FromDouble(publicRequest.SpotFleetRequestConfig.OnDemandFulfilledCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.OnDemandTargetCapacity));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetReplaceUnhealthyInstances())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.SpotFleetRequestConfig.ReplaceUnhealthyInstances));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetSpotPrice())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "SpotPrice", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.SpotPrice));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetTargetCapacity())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "TargetCapacity", StringUtils.FromInt(publicRequest.SpotFleetRequestConfig.TargetCapacity));
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
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidFrom", Amazon.EC2.Internal.CustomMarshallTransformations.ConvertDateTimeISOWithoutMilliseconds(publicRequest.SpotFleetRequestConfig.ValidFrom));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetValidUntil())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ValidUntil", Amazon.EC2.Internal.CustomMarshallTransformations.ConvertDateTimeISOWithoutMilliseconds(publicRequest.SpotFleetRequestConfig.ValidUntil));
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