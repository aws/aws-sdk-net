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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
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
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSpotFleetRequest)input);
        }
    
        public IRequest Marshall(RequestSpotFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RequestSpotFleet");
            request.Parameters.Add("Version", "2015-04-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetSpotFleetRequestConfig())
                {
                    if(publicRequest.SpotFleetRequestConfig.IsSetClientToken())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "ClientToken", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.ClientToken));
                    }
                    if(publicRequest.SpotFleetRequestConfig.IsSetIamFleetRole())
                    {
                        request.Parameters.Add("SpotFleetRequestConfig" + "." + "IamFleetRole", StringUtils.FromString(publicRequest.SpotFleetRequestConfig.IamFleetRole));
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
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetAllSecurityGroups())
                            {
                                int publicRequestSpotFleetRequestConfiglistValuelistValueIndex = 1;
                                foreach(var publicRequestSpotFleetRequestConfiglistValuelistValue in publicRequestSpotFleetRequestConfiglistValue.AllSecurityGroups)
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
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetMonitoringEnabled())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "Monitoring.Enabled", StringUtils.FromBool(publicRequestSpotFleetRequestConfiglistValue.MonitoringEnabled));
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
                                    request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SecurityGroup" + "." + publicRequestSpotFleetRequestConfiglistValuelistValueIndex, StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValuelistValue));
                                    publicRequestSpotFleetRequestConfiglistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.SubnetId));
                            }
                            if(publicRequestSpotFleetRequestConfiglistValue.IsSetUserData())
                            {
                                request.Parameters.Add("SpotFleetRequestConfig" + "." + "LaunchSpecifications" + "." + publicRequestSpotFleetRequestConfiglistValueIndex + "." + "UserData", StringUtils.FromString(publicRequestSpotFleetRequestConfiglistValue.UserData));
                            }
                            publicRequestSpotFleetRequestConfiglistValueIndex++;
                        }
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
    }
}