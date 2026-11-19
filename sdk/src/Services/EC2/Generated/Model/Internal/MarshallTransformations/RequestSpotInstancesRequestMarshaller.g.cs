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
    /// RequestSpotInstances Request Marshaller
    /// </summary>
    public partial class RequestSpotInstancesRequestMarshaller : IMarshaller<IRequest, RequestSpotInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSpotInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RequestSpotInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RequestSpotInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAvailabilityZoneGroup())
            {
                request.Parameters.Add("AvailabilityZoneGroup", StringUtils.FromString(publicRequest.AvailabilityZoneGroup));
            }
            if (publicRequest.IsSetBlockDurationMinutes())
            {
                request.Parameters.Add("BlockDurationMinutes", StringUtils.FromInt(publicRequest.BlockDurationMinutes.Value));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetInstanceInterruptionBehavior())
            {
                request.Parameters.Add("InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.InstanceInterruptionBehavior));
            }
            if (publicRequest.IsSetLaunchGroup())
            {
                request.Parameters.Add("LaunchGroup", StringUtils.FromString(publicRequest.LaunchGroup));
            }
            if (publicRequest.IsSetLaunchSpecification())
            {
                if (publicRequest.LaunchSpecification.IsSetAddressingType())
                {
                    request.Parameters.Add("LaunchSpecification" + ".AddressingType", StringUtils.FromString(publicRequest.LaunchSpecification.AddressingType));
                }
                if (publicRequest.LaunchSpecification.IsSetBlockDeviceMappings())
                {
                    if (publicRequest.LaunchSpecification.BlockDeviceMappings.Count == 0)
                    {
                        request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchSpecification.BlockDeviceMappings)
                        {
                            if (item1.IsSetDeviceName())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".DeviceName", StringUtils.FromString(item1.DeviceName));
                            }
                            if (item1.IsSetEbs())
                            {
                                if (item1.Ebs.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".AvailabilityZone", StringUtils.FromString(item1.Ebs.AvailabilityZone));
                                }
                                if (item1.Ebs.IsSetAvailabilityZoneId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".AvailabilityZoneId", StringUtils.FromString(item1.Ebs.AvailabilityZoneId));
                                }
                                if (item1.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item1.Ebs.DeleteOnTermination.Value));
                                }
                                if (item1.Ebs.IsSetEbsCardIndex())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".EbsCardIndex", StringUtils.FromInt(item1.Ebs.EbsCardIndex.Value));
                                }
                                if (item1.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item1.Ebs.Encrypted.Value));
                                }
                                if (item1.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Iops", StringUtils.FromInt(item1.Ebs.Iops.Value));
                                }
                                if (item1.Ebs.IsSetKmsKeyId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item1.Ebs.KmsKeyId));
                                }
                                if (item1.Ebs.IsSetOutpostArn())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".OutpostArn", StringUtils.FromString(item1.Ebs.OutpostArn));
                                }
                                if (item1.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item1.Ebs.SnapshotId));
                                }
                                if (item1.Ebs.IsSetThroughput())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Throughput", StringUtils.FromInt(item1.Ebs.Throughput.Value));
                                }
                                if (item1.Ebs.IsSetVolumeInitializationRate())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeInitializationRate", StringUtils.FromInt(item1.Ebs.VolumeInitializationRate.Value));
                                }
                                if (item1.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item1.Ebs.VolumeSize.Value));
                                }
                                if (item1.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".VolumeType", StringUtils.FromString(item1.Ebs.VolumeType));
                                }
                            }
                            if (item1.IsSetNoDevice())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".NoDevice", StringUtils.FromString(item1.NoDevice));
                            }
                            if (item1.IsSetVirtualName())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".VirtualName", StringUtils.FromString(item1.VirtualName));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetEbsOptimized())
                {
                    request.Parameters.Add("LaunchSpecification" + ".EbsOptimized", StringUtils.FromBool(publicRequest.LaunchSpecification.EbsOptimized.Value));
                }
                if (publicRequest.LaunchSpecification.IsSetIamInstanceProfile())
                {
                    if (publicRequest.LaunchSpecification.IamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".IamInstanceProfile" + ".Arn", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Arn));
                    }
                    if (publicRequest.LaunchSpecification.IamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".IamInstanceProfile" + ".Name", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Name));
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetImageId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".ImageId", StringUtils.FromString(publicRequest.LaunchSpecification.ImageId));
                }
                if (publicRequest.LaunchSpecification.IsSetInstanceType())
                {
                    request.Parameters.Add("LaunchSpecification" + ".InstanceType", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceType));
                }
                if (publicRequest.LaunchSpecification.IsSetKernelId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".KernelId", StringUtils.FromString(publicRequest.LaunchSpecification.KernelId));
                }
                if (publicRequest.LaunchSpecification.IsSetKeyName())
                {
                    request.Parameters.Add("LaunchSpecification" + ".KeyName", StringUtils.FromString(publicRequest.LaunchSpecification.KeyName));
                }
                if (publicRequest.LaunchSpecification.IsSetMonitoringEnabled())
                {
                    request.Parameters.Add("LaunchSpecification" + ".Monitoring.Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.MonitoringEnabled.Value));
                }
                if (publicRequest.LaunchSpecification.IsSetNetworkInterfaces())
                {
                    if (publicRequest.LaunchSpecification.NetworkInterfaces.Count == 0)
                    {
                        request.Parameters.Add("LaunchSpecification" + ".NetworkInterface", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchSpecification.NetworkInterfaces)
                        {
                            if (item1.IsSetAssociateCarrierIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".AssociateCarrierIpAddress", StringUtils.FromBool(item1.AssociateCarrierIpAddress.Value));
                            }
                            if (item1.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".AssociatePublicIpAddress", StringUtils.FromBool(item1.AssociatePublicIpAddress.Value));
                            }
                            if (item1.IsSetConnectionTrackingSpecification())
                            {
                                if (item1.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".TcpEstablishedTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.TcpEstablishedTimeout.Value));
                                }
                                if (item1.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".UdpStreamTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.UdpStreamTimeout.Value));
                                }
                                if (item1.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".ConnectionTrackingSpecification" + ".UdpTimeout", StringUtils.FromInt(item1.ConnectionTrackingSpecification.UdpTimeout.Value));
                                }
                            }
                            if (item1.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".DeleteOnTermination", StringUtils.FromBool(item1.DeleteOnTermination.Value));
                            }
                            if (item1.IsSetDescription())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                            }
                            if (item1.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".DeviceIndex", StringUtils.FromInt(item1.DeviceIndex.Value));
                            }
                            if (item1.IsSetEnaQueueCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".EnaQueueCount", StringUtils.FromInt(item1.EnaQueueCount.Value));
                            }
                            if (item1.IsSetEnaSrdSpecification())
                            {
                                if (item1.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".EnaSrdSpecification" + ".EnaSrdEnabled", StringUtils.FromBool(item1.EnaSrdSpecification.EnaSrdEnabled.Value));
                                }
                                if (item1.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                {
                                    if (item1.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".EnaSrdSpecification" + ".EnaSrdUdpSpecification" + ".EnaSrdUdpEnabled", StringUtils.FromBool(item1.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled.Value));
                                    }
                                }
                            }
                            if (item1.IsSetGroups())
                            {
                                if (item1.Groups.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".SecurityGroupId", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Groups)
                                    {
                                        request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".SecurityGroupId" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetInterfaceType())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".InterfaceType", StringUtils.FromString(item1.InterfaceType));
                            }
                            if (item1.IsSetIpv4PrefixCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv4PrefixCount", StringUtils.FromInt(item1.Ipv4PrefixCount.Value));
                            }
                            if (item1.IsSetIpv4Prefixes())
                            {
                                if (item1.Ipv4Prefixes.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv4Prefix", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv4Prefixes)
                                    {
                                        if (item2.IsSetIpv4Prefix())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv4Prefix" + "." + index2 + ".Ipv4Prefix", StringUtils.FromString(item2.Ipv4Prefix));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetIpv6AddressCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6AddressCount", StringUtils.FromInt(item1.Ipv6AddressCount.Value));
                            }
                            if (item1.IsSetIpv6Addresses())
                            {
                                if (item1.Ipv6Addresses.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Addresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv6Addresses)
                                    {
                                        if (item2.IsSetIpv6Address())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Addresses" + "." + index2 + ".Ipv6Address", StringUtils.FromString(item2.Ipv6Address));
                                        }
                                        if (item2.IsSetIsPrimaryIpv6())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Addresses" + "." + index2 + ".IsPrimaryIpv6", StringUtils.FromBool(item2.IsPrimaryIpv6.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetIpv6PrefixCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6PrefixCount", StringUtils.FromInt(item1.Ipv6PrefixCount.Value));
                            }
                            if (item1.IsSetIpv6Prefixes())
                            {
                                if (item1.Ipv6Prefixes.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Prefix", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv6Prefixes)
                                    {
                                        if (item2.IsSetIpv6Prefix())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Prefix" + "." + index2 + ".Ipv6Prefix", StringUtils.FromString(item2.Ipv6Prefix));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetNetworkCardIndex())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".NetworkCardIndex", StringUtils.FromInt(item1.NetworkCardIndex.Value));
                            }
                            if (item1.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".NetworkInterfaceId", StringUtils.FromString(item1.NetworkInterfaceId));
                            }
                            if (item1.IsSetPrimaryIpv6())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrimaryIpv6", StringUtils.FromBool(item1.PrimaryIpv6.Value));
                            }
                            if (item1.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddress", StringUtils.FromString(item1.PrivateIpAddress));
                            }
                            if (item1.IsSetPrivateIpAddresses())
                            {
                                if (item1.PrivateIpAddresses.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.PrivateIpAddresses)
                                    {
                                        if (item2.IsSetPrimary())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses" + "." + index2 + ".Primary", StringUtils.FromBool(item2.Primary.Value));
                                        }
                                        if (item2.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddresses" + "." + index2 + ".PrivateIpAddress", StringUtils.FromString(item2.PrivateIpAddress));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetSecondaryPrivateIpAddressCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(item1.SecondaryPrivateIpAddressCount.Value));
                            }
                            if (item1.IsSetSubnetId())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetPlacement())
                {
                    if (publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".AvailabilityZone", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZone));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZoneId())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".AvailabilityZoneId", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZoneId));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".Tenancy", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Tenancy));
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetRamdiskId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".RamdiskId", StringUtils.FromString(publicRequest.LaunchSpecification.RamdiskId));
                }
                if (publicRequest.LaunchSpecification.IsSetSubnetId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".SubnetId", StringUtils.FromString(publicRequest.LaunchSpecification.SubnetId));
                }
                if (publicRequest.LaunchSpecification.IsSetUserData())
                {
                    request.Parameters.Add("LaunchSpecification" + ".UserData", StringUtils.FromString(publicRequest.LaunchSpecification.UserData));
                }
            }
            if (publicRequest.IsSetSpotPrice())
            {
                request.Parameters.Add("SpotPrice", StringUtils.FromString(publicRequest.SpotPrice));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
            }
            if (publicRequest.IsSetValidFrom())
            {
                request.Parameters.Add("ValidFrom", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidFrom.Value));
            }
            if (publicRequest.IsSetValidUntil())
            {
                request.Parameters.Add("ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidUntil.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RequestSpotInstancesRequestMarshaller _instance = new();

        internal static RequestSpotInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RequestSpotInstancesRequestMarshaller Instance => _instance;
    }
}
