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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// RunInstances Request Marshaller
    /// </summary>       
    public class RunInstancesRequestMarshaller : IMarshaller<IRequest, RunInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunInstancesRequest)input);
        }
    
        public IRequest Marshall(RunInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RunInstances");
            request.Parameters.Add("Version", "2014-10-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
                }
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                    {
                        if(publicRequestlistValue.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                        }
                        if(publicRequestlistValue.IsSetEbs())
                        {
                            if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                            }
                            if(publicRequestlistValue.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValue.Ebs.Encrypted));
                            }
                            if(publicRequestlistValue.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValue.Ebs.Iops));
                            }
                            if(publicRequestlistValue.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.Ebs.SnapshotId));
                            }
                            if(publicRequestlistValue.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeSize));
                            }
                            if(publicRequestlistValue.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeType));
                            }
                        }
                        if(publicRequestlistValue.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValue.NoDevice));
                        }
                        if(publicRequestlistValue.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDisableApiTermination())
                {
                    request.Parameters.Add("DisableApiTermination", StringUtils.FromBool(publicRequest.DisableApiTermination));
                }
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
                if(publicRequest.IsSetIamInstanceProfile())
                {
                    if(publicRequest.IamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.IamInstanceProfile.Arn));
                    }
                    if(publicRequest.IamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.IamInstanceProfile.Name));
                    }
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetKernelId())
                {
                    request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
                }
                if(publicRequest.IsSetKeyName())
                {
                    request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
                }
                if(publicRequest.IsSetMaxCount())
                {
                    request.Parameters.Add("MaxCount", StringUtils.FromInt(publicRequest.MaxCount));
                }
                if(publicRequest.IsSetMinCount())
                {
                    request.Parameters.Add("MinCount", StringUtils.FromInt(publicRequest.MinCount));
                }
                if(publicRequest.IsSetMonitoring())
                {
                    request.Parameters.Add("Monitoring.Enabled", StringUtils.FromBool(publicRequest.Monitoring));
                }
                if(publicRequest.IsSetNetworkInterfaces())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.NetworkInterfaces)
                    {
                        if(publicRequestlistValue.IsSetAssociatePublicIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestlistValue.AssociatePublicIpAddress));
                        }
                        if(publicRequestlistValue.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.DeleteOnTermination));
                        }
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
                        if(publicRequestlistValue.IsSetDeviceIndex())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestlistValue.DeviceIndex));
                        }
                        if(publicRequestlistValue.IsSetGroups())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Groups)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecurityGroupId" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetNetworkInterfaceId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestlistValue.NetworkInterfaceId));
                        }
                        if(publicRequestlistValue.IsSetPrivateIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValue.PrivateIpAddress));
                        }
                        if(publicRequestlistValue.IsSetPrivateIpAddresses())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PrivateIpAddresses)
                            {
                                if(publicRequestlistValuelistValue.IsSetPrimary())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddressesSet" + "." + publicRequestlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestlistValuelistValue.Primary));
                                }
                                if(publicRequestlistValuelistValue.IsSetPrivateIpAddress())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddressesSet" + "." + publicRequestlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValuelistValue.PrivateIpAddress));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetSecondaryPrivateIpAddressCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestlistValue.SecondaryPrivateIpAddressCount));
                        }
                        if(publicRequestlistValue.IsSetSubnetId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetPlacement())
                {
                    if(publicRequest.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.Placement.AvailabilityZone));
                    }
                    if(publicRequest.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.Placement.GroupName));
                    }
                    if(publicRequest.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.Placement.Tenancy));
                    }
                }
                if(publicRequest.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
                }
                if(publicRequest.IsSetRamdiskId())
                {
                    request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetSecurityGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroup" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetSubnetId())
                {
                    request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
                }
                if(publicRequest.IsSetUserData())
                {
                    request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
                }
            }
            return request;
        }
    }
}