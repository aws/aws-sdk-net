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
    /// RequestSpotInstances Request Marshaller
    /// </summary>       
    public class RequestSpotInstancesRequestMarshaller : IMarshaller<IRequest, RequestSpotInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSpotInstancesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestSpotInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RequestSpotInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAvailabilityZoneGroup())
                {
                    request.Parameters.Add("AvailabilityZoneGroup", StringUtils.FromString(publicRequest.AvailabilityZoneGroup));
                }
                if(publicRequest.IsSetBlockDurationMinutes())
                {
                    request.Parameters.Add("BlockDurationMinutes", StringUtils.FromInt(publicRequest.BlockDurationMinutes));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetInstanceInterruptionBehavior())
                {
                    request.Parameters.Add("InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.InstanceInterruptionBehavior));
                }
                if(publicRequest.IsSetLaunchGroup())
                {
                    request.Parameters.Add("LaunchGroup", StringUtils.FromString(publicRequest.LaunchGroup));
                }
                if(publicRequest.IsSetLaunchSpecification())
                {
                    if(publicRequest.LaunchSpecification.IsSetAddressingType())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "AddressingType", StringUtils.FromString(publicRequest.LaunchSpecification.AddressingType));
                    }
                    if(publicRequest.LaunchSpecification.IsSetBlockDeviceMappings())
                    {
                        if (publicRequest.LaunchSpecification.BlockDeviceMappings.Count == 0)
                            request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping", "");
                        else
                        {
                             int publicRequestLaunchSpecificationlistValueIndex = 1;
                             foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.BlockDeviceMappings)
                             {
                                if(publicRequestLaunchSpecificationlistValue.IsSetDeviceName())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.DeviceName));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetEbs())
                                {
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.AvailabilityZone));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetAvailabilityZoneId())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.AvailabilityZoneId));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetDeleteOnTermination())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.Ebs.DeleteOnTermination));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetEncrypted())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.Ebs.Encrypted));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetIops())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.Iops));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetKmsKeyId())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.KmsKeyId));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetOutpostArn())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.OutpostArn));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetSnapshotId())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.SnapshotId));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetThroughput())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.Throughput));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetVolumeInitializationRate())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "VolumeInitializationRate", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.VolumeInitializationRate));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetVolumeSize())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.VolumeSize));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetVolumeType())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.VolumeType));
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetNoDevice())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.NoDevice));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetVirtualName())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.VirtualName));
                                }
                                 publicRequestLaunchSpecificationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetEbsOptimized())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "EbsOptimized", StringUtils.FromBool(publicRequest.LaunchSpecification.EbsOptimized));
                    }
                    if(publicRequest.LaunchSpecification.IsSetIamInstanceProfile())
                    {
                        if(publicRequest.LaunchSpecification.IamInstanceProfile.IsSetArn())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Arn));
                        }
                        if(publicRequest.LaunchSpecification.IamInstanceProfile.IsSetName())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Name));
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetImageId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "ImageId", StringUtils.FromString(publicRequest.LaunchSpecification.ImageId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetInstanceType())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "InstanceType", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceType));
                    }
                    if(publicRequest.LaunchSpecification.IsSetKernelId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "KernelId", StringUtils.FromString(publicRequest.LaunchSpecification.KernelId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetKeyName())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "KeyName", StringUtils.FromString(publicRequest.LaunchSpecification.KeyName));
                    }
                    if(publicRequest.LaunchSpecification.IsSetMonitoringEnabled())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "Monitoring.Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.MonitoringEnabled));
                    }
                    if(publicRequest.LaunchSpecification.IsSetNetworkInterfaces())
                    {
                        if (publicRequest.LaunchSpecification.NetworkInterfaces.Count == 0)
                            request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface", "");
                        else
                        {
                             int publicRequestLaunchSpecificationlistValueIndex = 1;
                             foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.NetworkInterfaces)
                             {
                                if(publicRequestLaunchSpecificationlistValue.IsSetAssociateCarrierIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.AssociateCarrierIpAddress));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetAssociatePublicIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.AssociatePublicIpAddress));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetConnectionTrackingSpecification())
                                {
                                    if(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.UdpStreamTimeout));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.ConnectionTrackingSpecification.UdpTimeout));
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.DeleteOnTermination));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Description));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetDeviceIndex())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.DeviceIndex));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetEnaQueueCount())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "EnaQueueCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.EnaQueueCount));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetEnaSrdSpecification())
                                {
                                    if(publicRequestLaunchSpecificationlistValue.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.EnaSrdSpecification.EnaSrdEnabled));
                                    }
                                    if(publicRequestLaunchSpecificationlistValue.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                    {
                                        if(publicRequestLaunchSpecificationlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                                        }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetGroups())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.Groups.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SecurityGroupId", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Groups)
                                         {
                                             request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SecurityGroupId" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue));
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetInterfaceType())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.InterfaceType));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv4PrefixCount())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ipv4PrefixCount));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv4Prefixes())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.Ipv4Prefixes.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv4Prefix", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Ipv4Prefixes)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIpv4Prefix())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.Ipv4Prefix));
                                            }
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv6AddressCount())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ipv6AddressCount));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv6Addresses())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.Ipv6Addresses.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Addresses", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Ipv6Addresses)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIpv6Address())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.Ipv6Address));
                                            }
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIsPrimaryIpv6())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestLaunchSpecificationlistValuelistValue.IsPrimaryIpv6));
                                            }
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv6PrefixCount())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ipv6PrefixCount));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetIpv6Prefixes())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.Ipv6Prefixes.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Prefix", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Ipv6Prefixes)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIpv6Prefix())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.Ipv6Prefix));
                                            }
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetNetworkCardIndex())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.NetworkCardIndex));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetNetworkInterfaceId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.NetworkInterfaceId));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetPrimaryIpv6())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrimaryIpv6", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.PrimaryIpv6));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.PrivateIpAddress));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddresses())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.PrivateIpAddresses.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddresses", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.PrivateIpAddresses)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrimary())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestLaunchSpecificationlistValuelistValue.Primary));
                                            }
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrivateIpAddress())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.PrivateIpAddress));
                                            }
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetSecondaryPrivateIpAddressCount())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.SecondaryPrivateIpAddressCount));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.SubnetId));
                                }
                                 publicRequestLaunchSpecificationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetPlacement())
                    {
                        if(publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZone));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetTenancy())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Tenancy));
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetRamdiskId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "RamdiskId", StringUtils.FromString(publicRequest.LaunchSpecification.RamdiskId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetSubnetId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "SubnetId", StringUtils.FromString(publicRequest.LaunchSpecification.SubnetId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetUserData())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "UserData", StringUtils.FromString(publicRequest.LaunchSpecification.UserData));
                    }
                }
                if(publicRequest.IsSetSpotPrice())
                {
                    request.Parameters.Add("SpotPrice", StringUtils.FromString(publicRequest.SpotPrice));
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
                    private static RequestSpotInstancesRequestMarshaller _instance = new RequestSpotInstancesRequestMarshaller();        

        internal static RequestSpotInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestSpotInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}