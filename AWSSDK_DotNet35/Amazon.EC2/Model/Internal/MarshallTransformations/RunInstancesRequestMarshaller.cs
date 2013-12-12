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
    /// Run Instances Request Marshaller
    /// </summary>       
    public class RunInstancesRequestMarshaller : IMarshaller<IRequest, RunInstancesRequest>
    {
        public IRequest Marshall(RunInstancesRequest runInstancesRequest)
        {
            IRequest request = new DefaultRequest(runInstancesRequest, "AmazonEC2");
            request.Parameters.Add("Action", "RunInstances");
            request.Parameters.Add("Version", "2013-10-15");
            if (runInstancesRequest != null && runInstancesRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(runInstancesRequest.ImageId));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetMinCount())
            {
                request.Parameters.Add("MinCount", StringUtils.FromInt(runInstancesRequest.MinCount));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetMaxCount())
            {
                request.Parameters.Add("MaxCount", StringUtils.FromInt(runInstancesRequest.MaxCount));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetKeyName())
            {
                request.Parameters.Add("KeyName", StringUtils.FromString(runInstancesRequest.KeyName));
            }
            if (runInstancesRequest != null)
            {
                List<string> securityGroupsList = runInstancesRequest.SecurityGroups;

                int securityGroupsListIndex = 1;
                foreach (string securityGroupsListValue in securityGroupsList)
                { 
                    request.Parameters.Add("SecurityGroup." + securityGroupsListIndex, StringUtils.FromString(securityGroupsListValue));
                    securityGroupsListIndex++;
                }
            }
            if (runInstancesRequest != null)
            {
                List<string> securityGroupIdsList = runInstancesRequest.SecurityGroupIds;

                int securityGroupIdsListIndex = 1;
                foreach (string securityGroupIdsListValue in securityGroupIdsList)
                { 
                    request.Parameters.Add("SecurityGroupId." + securityGroupIdsListIndex, StringUtils.FromString(securityGroupIdsListValue));
                    securityGroupIdsListIndex++;
                }
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetUserData())
            {
                request.Parameters.Add("UserData", StringUtils.FromString(runInstancesRequest.UserData));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(runInstancesRequest.InstanceType));
            }
            if (runInstancesRequest != null)
            {
                Placement placement = runInstancesRequest.Placement;
                if (placement != null && placement.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("Placement.AvailabilityZone", StringUtils.FromString(placement.AvailabilityZone));
                }
                if (placement != null && placement.IsSetGroupName())
                {
                    request.Parameters.Add("Placement.GroupName", StringUtils.FromString(placement.GroupName));
                }
                if (placement != null && placement.IsSetTenancy())
                {
                    request.Parameters.Add("Placement.Tenancy", StringUtils.FromString(placement.Tenancy));
                }
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetKernelId())
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(runInstancesRequest.KernelId));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetRamdiskId())
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(runInstancesRequest.RamdiskId));
            }

            if (runInstancesRequest != null)
            {
                List<BlockDeviceMapping> blockDeviceMappingsList = runInstancesRequest.BlockDeviceMappings;
                int blockDeviceMappingsListIndex = 1;
                foreach (BlockDeviceMapping blockDeviceMappingsListValue in blockDeviceMappingsList)
                {
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetVirtualName())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".VirtualName", StringUtils.FromString(blockDeviceMappingsListValue.VirtualName));
                    }
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetDeviceName())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".DeviceName", StringUtils.FromString(blockDeviceMappingsListValue.DeviceName));
                    }
                    if (blockDeviceMappingsListValue != null)
                    {
                        EbsBlockDevice ebs = blockDeviceMappingsListValue.Ebs;
                        if (ebs != null && ebs.IsSetSnapshotId())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.SnapshotId", StringUtils.FromString(ebs.SnapshotId));
                        }
                        if (ebs != null && ebs.IsSetVolumeSize())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.VolumeSize", StringUtils.FromInt(ebs.VolumeSize));
                        }
                        if (ebs != null && ebs.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.DeleteOnTermination", StringUtils.FromBool(ebs.DeleteOnTermination));
                        }
                        if (ebs != null && ebs.IsSetVolumeType())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.VolumeType", StringUtils.FromString(ebs.VolumeType));
                        }
                        if (ebs != null && ebs.IsSetIops())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.Iops", StringUtils.FromInt(ebs.Iops));
                        }
                    }
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetNoDevice())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".NoDevice", StringUtils.FromString(blockDeviceMappingsListValue.NoDevice));
                    }

                    blockDeviceMappingsListIndex++;
                }
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetMonitoring())
            {
                request.Parameters.Add("Monitoring.Enabled", StringUtils.FromBool(runInstancesRequest.Monitoring));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(runInstancesRequest.SubnetId));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetDisableApiTermination())
            {
                request.Parameters.Add("DisableApiTermination", StringUtils.FromBool(runInstancesRequest.DisableApiTermination));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetInstanceInitiatedShutdownBehavior())
            {
                request.Parameters.Add("InstanceInitiatedShutdownBehavior", StringUtils.FromString(runInstancesRequest.InstanceInitiatedShutdownBehavior));
            }
            if (runInstancesRequest != null)
            {
                InstanceLicenseSpecification license = runInstancesRequest.License;
                if (license != null && license.IsSetPool())
                {
                    request.Parameters.Add("License.Pool", StringUtils.FromString(license.Pool));
                }
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(runInstancesRequest.PrivateIpAddress));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(runInstancesRequest.ClientToken));
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetAdditionalInfo())
            {
                request.Parameters.Add("AdditionalInfo", StringUtils.FromString(runInstancesRequest.AdditionalInfo));
            }

            if (runInstancesRequest != null)
            {
                List<InstanceNetworkInterfaceSpecification> networkInterfacesList = runInstancesRequest.NetworkInterfaces;
                int networkInterfacesListIndex = 1;
                foreach (InstanceNetworkInterfaceSpecification networkInterfacesListValue in networkInterfacesList)
                {
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetNetworkInterfaceId())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".NetworkInterfaceId", StringUtils.FromString(networkInterfacesListValue.NetworkInterfaceId));
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDeviceIndex())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".DeviceIndex", StringUtils.FromInt(networkInterfacesListValue.DeviceIndex));
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetSubnetId())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".SubnetId", StringUtils.FromString(networkInterfacesListValue.SubnetId));
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDescription())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".Description", StringUtils.FromString(networkInterfacesListValue.Description));
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetPrivateIpAddress())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddress", StringUtils.FromString(networkInterfacesListValue.PrivateIpAddress));
                    }
                    if (networkInterfacesListValue != null)
                    {
                        List<string> groupsList = networkInterfacesListValue.Groups;

                        int groupsListIndex = 1;
                        foreach (string groupsListValue in groupsList)
                        { 
                            request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".SecurityGroupId." + groupsListIndex, StringUtils.FromString(groupsListValue));
                            groupsListIndex++;
                        }
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetDeleteOnTermination())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".DeleteOnTermination", StringUtils.FromBool(networkInterfacesListValue.DeleteOnTermination));
                    }

                    if (networkInterfacesListValue != null)
                    {
                        List<PrivateIpAddressSpecification> privateIpAddressesList = networkInterfacesListValue.PrivateIpAddresses;
                        int privateIpAddressesListIndex = 1;
                        foreach (PrivateIpAddressSpecification privateIpAddressesListValue in privateIpAddressesList)
                        {
                            if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddresses." + privateIpAddressesListIndex + ".PrivateIpAddress", StringUtils.FromString(privateIpAddressesListValue.PrivateIpAddress));
                            }
                            if (privateIpAddressesListValue != null && privateIpAddressesListValue.IsSetPrimary())
                            {
                                request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".PrivateIpAddresses." + privateIpAddressesListIndex + ".Primary", StringUtils.FromBool(privateIpAddressesListValue.Primary));
                            }

                            privateIpAddressesListIndex++;
                        }
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetSecondaryPrivateIpAddressCount())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(networkInterfacesListValue.SecondaryPrivateIpAddressCount));
                    }
                    if (networkInterfacesListValue != null && networkInterfacesListValue.IsSetAssociatePublicIpAddress())
                    {
                        request.Parameters.Add("NetworkInterface." + networkInterfacesListIndex + ".AssociatePublicIpAddress", StringUtils.FromBool(networkInterfacesListValue.AssociatePublicIpAddress));
                    }

                    networkInterfacesListIndex++;
                }
            }
            if (runInstancesRequest != null)
            {
                IamInstanceProfileSpecification iamInstanceProfile = runInstancesRequest.IamInstanceProfile;
                if (iamInstanceProfile != null && iamInstanceProfile.IsSetArn())
                {
                    request.Parameters.Add("IamInstanceProfile.Arn", StringUtils.FromString(iamInstanceProfile.Arn));
                }
                if (iamInstanceProfile != null && iamInstanceProfile.IsSetName())
                {
                    request.Parameters.Add("IamInstanceProfile.Name", StringUtils.FromString(iamInstanceProfile.Name));
                }
            }
            if (runInstancesRequest != null && runInstancesRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized", StringUtils.FromBool(runInstancesRequest.EbsOptimized));
            }

            return request;
        }
    }
}
