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
                    if(publicRequest.LaunchTemplateData.IsSetCreditSpecification())
                    {
                        if(publicRequest.LaunchTemplateData.CreditSpecification.IsSetCpuCredits())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "CreditSpecification" + "." + "CpuCredits", StringUtils.FromString(publicRequest.LaunchTemplateData.CreditSpecification.CpuCredits));
                        }
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
                            if(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.IsSetValidUntil())
                            {
                                request.Parameters.Add("LaunchTemplateData" + "." + "InstanceMarketOptions" + "." + "SpotOptions" + "." + "ValidUntil", StringUtils.FromDateTime(publicRequest.LaunchTemplateData.InstanceMarketOptions.SpotOptions.ValidUntil));
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
                        if(publicRequest.LaunchTemplateData.Placement.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.GroupName));
                        }
                        if(publicRequest.LaunchTemplateData.Placement.IsSetHostId())
                        {
                            request.Parameters.Add("LaunchTemplateData" + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequest.LaunchTemplateData.Placement.HostId));
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