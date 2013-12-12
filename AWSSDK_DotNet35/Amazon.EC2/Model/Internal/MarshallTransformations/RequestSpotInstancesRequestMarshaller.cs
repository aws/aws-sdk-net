/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Request Spot Instances Request Marshaller
    /// </summary>       
    public class RequestSpotInstancesRequestMarshaller : IMarshaller<IRequest, RequestSpotInstancesRequest>
    {
        public IRequest Marshall(RequestSpotInstancesRequest requestSpotInstancesRequest)
        {
            IRequest request = new DefaultRequest(requestSpotInstancesRequest, "AmazonEC2");
            request.Parameters.Add("Action", "RequestSpotInstances");
            request.Parameters.Add("Version", "2013-10-15");
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetSpotPrice())
            {
                request.Parameters.Add("SpotPrice", StringUtils.FromString(requestSpotInstancesRequest.SpotPrice));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(requestSpotInstancesRequest.InstanceCount));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(requestSpotInstancesRequest.Type));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetValidFrom())
            {
                request.Parameters.Add("ValidFrom", StringUtils.FromDateTime(requestSpotInstancesRequest.ValidFrom));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetValidUntil())
            {
                request.Parameters.Add("ValidUntil", StringUtils.FromDateTime(requestSpotInstancesRequest.ValidUntil));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetLaunchGroup())
            {
                request.Parameters.Add("LaunchGroup", StringUtils.FromString(requestSpotInstancesRequest.LaunchGroup));
            }
            if (requestSpotInstancesRequest != null && requestSpotInstancesRequest.IsSetAvailabilityZoneGroup())
            {
                request.Parameters.Add("AvailabilityZoneGroup", StringUtils.FromString(requestSpotInstancesRequest.AvailabilityZoneGroup));
            }
            if (requestSpotInstancesRequest != null)
            {
                LaunchSpecification launchSpecification = requestSpotInstancesRequest.LaunchSpecification;
                if (launchSpecification != null && launchSpecification.IsSetImageId())
                {
                    request.Parameters.Add("LaunchSpecification.ImageId", StringUtils.FromString(launchSpecification.ImageId));
                }
                if (launchSpecification != null && launchSpecification.IsSetKeyName())
                {
                    request.Parameters.Add("LaunchSpecification.KeyName", StringUtils.FromString(launchSpecification.KeyName));
                }

                if (launchSpecification != null)
                {
                    List<GroupIdentifier> allSecurityGroupsList = launchSpecification.AllSecurityGroups;
                    int allSecurityGroupsListIndex = 1;
                    foreach (GroupIdentifier allSecurityGroupsListValue in allSecurityGroupsList)
                    {
                        if (allSecurityGroupsListValue != null && allSecurityGroupsListValue.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchSpecification.GroupSet." + allSecurityGroupsListIndex + ".GroupName", StringUtils.FromString(allSecurityGroupsListValue.GroupName));
                        }
                        if (allSecurityGroupsListValue != null && allSecurityGroupsListValue.IsSetGroupId())
                        {
                            request.Parameters.Add("LaunchSpecification.GroupSet." + allSecurityGroupsListIndex + ".GroupId", StringUtils.FromString(allSecurityGroupsListValue.GroupId));
                        }

                        allSecurityGroupsListIndex++;
                    }
                }
                if (launchSpecification != null)
                {
                    List<string> securityGroupsList = launchSpecification.SecurityGroups;

                    int securityGroupsListIndex = 1;
                    foreach (string securityGroupsListValue in securityGroupsList)
                    { 
                        request.Parameters.Add("LaunchSpecification.SecurityGroup." + securityGroupsListIndex, StringUtils.FromString(securityGroupsListValue));
                        securityGroupsListIndex++;
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetUserData())
                {
                    request.Parameters.Add("LaunchSpecification.UserData", StringUtils.FromString(launchSpecification.UserData));
                }
                if (launchSpecification != null && launchSpecification.IsSetAddressingType())
                {
                    request.Parameters.Add("LaunchSpecification.AddressingType", StringUtils.FromString(launchSpecification.AddressingType));
                }
                if (launchSpecification != null && launchSpecification.IsSetInstanceType())
                {
                    request.Parameters.Add("LaunchSpecification.InstanceType", StringUtils.FromString(launchSpecification.InstanceType));
                }
                if (launchSpecification != null)
                {
                    SpotPlacement placement = launchSpecification.Placement;
                    if (placement != null && placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("LaunchSpecification.Placement.AvailabilityZone", StringUtils.FromString(placement.AvailabilityZone));
                    }
                    if (placement != null && placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchSpecification.Placement.GroupName", StringUtils.FromString(placement.GroupName));
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetKernelId())
                {
                    request.Parameters.Add("LaunchSpecification.KernelId", StringUtils.FromString(launchSpecification.KernelId));
                }
                if (launchSpecification != null && launchSpecification.IsSetRamdiskId())
                {
                    request.Parameters.Add("LaunchSpecification.RamdiskId", StringUtils.FromString(launchSpecification.RamdiskId));
                }

                if (launchSpecification != null)
                {
                    List<BlockDeviceMapping> blockDeviceMappingsList = launchSpecification.BlockDeviceMappings;
                    int blockDeviceMappingsListIndex = 1;
                    foreach (BlockDeviceMapping blockDeviceMappingsListValue in blockDeviceMappingsList)
                    {
                        if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetVirtualName())
                        {
                            request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".VirtualName", StringUtils.FromString(blockDeviceMappingsListValue.VirtualName));
                        }
                        if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetDeviceName())
                        {
                            request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".DeviceName", StringUtils.FromString(blockDeviceMappingsListValue.DeviceName));
                        }
                        if (blockDeviceMappingsListValue != null)
                        {
                            EbsBlockDevice ebs = blockDeviceMappingsListValue.Ebs;
                            if (ebs != null && ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.SnapshotId", StringUtils.FromString(ebs.SnapshotId));
                            }
                            if (ebs != null && ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.VolumeSize", StringUtils.FromInt(ebs.VolumeSize));
                            }
                            if (ebs != null && ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.DeleteOnTermination", StringUtils.FromBool(ebs.DeleteOnTermination));
                            }
                            if (ebs != null && ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.VolumeType", StringUtils.FromString(ebs.VolumeType));
                            }
                            if (ebs != null && ebs.IsSetIops())
                            {
                                request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.Iops", StringUtils.FromInt(ebs.Iops));
                            }
                        }
                        if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetNoDevice())
                        {
                            request.Parameters.Add("LaunchSpecification.BlockDeviceMapping." + blockDeviceMappingsListIndex + ".NoDevice", StringUtils.FromString(blockDeviceMappingsListValue.NoDevice));
                        }

                        blockDeviceMappingsListIndex++;
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetMonitoringEnabled())
                {
                    request.Parameters.Add("LaunchSpecification.Monitoring.Enabled", StringUtils.FromBool(launchSpecification.MonitoringEnabled));
                }
                if (launchSpecification != null && launchSpecification.IsSetSubnetId())
                {
                    request.Parameters.Add("LaunchSpecification.SubnetId", StringUtils.FromString(launchSpecification.SubnetId));
                }

                if (launchSpecification != null)
                {
                    List<InstanceNetworkInterfaceSpecification> networkInterfacesList = launchSpecification.NetworkInterfaces;
                    int networkInterfacesListIndex = 1;
                    foreach (InstanceNetworkInterfaceSpecification networkInterfacesListValue in networkInterfacesList)
                    {
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetNetworkInterfaceId())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".NetworkInterfaceId", StringUtils.FromString(networkInterfacesListValue.NetworkInterfaceId));
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDeviceIndex())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".DeviceIndex", StringUtils.FromInt(networkInterfacesListValue.DeviceIndex));
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetSubnetId())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".SubnetId", StringUtils.FromString(networkInterfacesListValue.SubnetId));
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDescription())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".Description", StringUtils.FromString(networkInterfacesListValue.Description));
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetPrivateIpAddress())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddress", StringUtils.FromString(networkInterfacesListValue.PrivateIpAddress));
                        }
                        if (networkInterfacesListValue != null)
                        {
                            List<string> groupsList = networkInterfacesListValue.Groups;

                            int groupsListIndex = 1;
                            foreach (string groupsListValue in groupsList)
                            { 
                                request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".SecurityGroupId." + groupsListIndex, StringUtils.FromString(groupsListValue));
                                groupsListIndex++;
                            }
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".DeleteOnTermination", StringUtils.FromBool(networkInterfacesListValue.DeleteOnTermination));
                        }

                        if (networkInterfacesListValue != null)
                        {
                            List<PrivateIpAddressSpecification> privateIpAddressesList = networkInterfacesListValue.PrivateIpAddresses;
                            int privateIpAddressesListIndex = 1;
                            foreach (PrivateIpAddressSpecification privateIpAddressesListValue in privateIpAddressesList)
                            {
                                if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrivateIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddresses." + privateIpAddressesListIndex + ".PrivateIpAddress", StringUtils.FromString(privateIpAddressesListValue.PrivateIpAddress));
                                }
                                if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrimary())
                                {
                                    request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddresses." + privateIpAddressesListIndex + ".Primary", StringUtils.FromBool(privateIpAddressesListValue.Primary));
                                }

                                privateIpAddressesListIndex++;
                            }
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetSecondaryPrivateIpAddressCount())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(networkInterfacesListValue.SecondaryPrivateIpAddressCount));
                        }
                        if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetAssociatePublicIpAddress())
                        {
                            request.Parameters.Add("LaunchSpecification.NetworkInterface." + networkInterfacesListIndex + ".AssociatePublicIpAddress", StringUtils.FromBool(networkInterfacesListValue.AssociatePublicIpAddress));
                        }

                        networkInterfacesListIndex++;
                    }
                }
                if (launchSpecification != null)
                {
                    IamInstanceProfileSpecification iamInstanceProfile = launchSpecification.IamInstanceProfile;
                    if (iamInstanceProfile != null && iamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("LaunchSpecification.IamInstanceProfile.Arn", StringUtils.FromString(iamInstanceProfile.Arn));
                    }
                    if (iamInstanceProfile != null && iamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("LaunchSpecification.IamInstanceProfile.Name", StringUtils.FromString(iamInstanceProfile.Name));
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetEbsOptimized())
                {
                    request.Parameters.Add("LaunchSpecification.EbsOptimized", StringUtils.FromBool(launchSpecification.EbsOptimized));
                }
            }

            return request;
        }
    }
}
