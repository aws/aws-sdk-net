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
    /// RunScheduledInstances Request Marshaller
    /// </summary>
    public partial class RunScheduledInstancesRequestMarshaller : IMarshaller<IRequest, RunScheduledInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunScheduledInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RunScheduledInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RunScheduledInstances");
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
            if (publicRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount.Value));
            }
            if (publicRequest.IsSetLaunchSpecification())
            {
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
                                if (item1.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item1.Ebs.DeleteOnTermination.Value));
                                }
                                if (item1.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item1.Ebs.Encrypted.Value));
                                }
                                if (item1.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".Iops", StringUtils.FromInt(item1.Ebs.Iops.Value));
                                }
                                if (item1.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".BlockDeviceMapping" + "." + index1 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item1.Ebs.SnapshotId));
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
                if (publicRequest.LaunchSpecification.IsSetMonitoring())
                {
                    if (publicRequest.LaunchSpecification.Monitoring.IsSetEnabled())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Monitoring" + ".Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.Monitoring.Enabled.Value));
                    }
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
                            if (item1.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".AssociatePublicIpAddress", StringUtils.FromBool(item1.AssociatePublicIpAddress.Value));
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
                            if (item1.IsSetGroups())
                            {
                                if (item1.Groups.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Group", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Groups)
                                    {
                                        request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Group" + "." + index2, StringUtils.FromString(item2));
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
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Address", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Ipv6Addresses)
                                    {
                                        if (item2.IsSetIpv6Address())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".Ipv6Address" + "." + index2 + ".Ipv6Address", StringUtils.FromString(item2.Ipv6Address));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".NetworkInterfaceId", StringUtils.FromString(item1.NetworkInterfaceId));
                            }
                            if (item1.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddress", StringUtils.FromString(item1.PrivateIpAddress));
                            }
                            if (item1.IsSetPrivateIpAddressConfigs())
                            {
                                if (item1.PrivateIpAddressConfigs.Count == 0)
                                {
                                    request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddressConfig", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.PrivateIpAddressConfigs)
                                    {
                                        if (item2.IsSetPrimary())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddressConfig" + "." + index2 + ".Primary", StringUtils.FromBool(item2.Primary.Value));
                                        }
                                        if (item2.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("LaunchSpecification" + ".NetworkInterface" + "." + index1 + ".PrivateIpAddressConfig" + "." + index2 + ".PrivateIpAddress", StringUtils.FromString(item2.PrivateIpAddress));
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
                    if (publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetRamdiskId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".RamdiskId", StringUtils.FromString(publicRequest.LaunchSpecification.RamdiskId));
                }
                if (publicRequest.LaunchSpecification.IsSetSecurityGroupIds())
                {
                    if (publicRequest.LaunchSpecification.SecurityGroupIds.Count == 0)
                    {
                        request.Parameters.Add("LaunchSpecification" + ".SecurityGroupId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchSpecification.SecurityGroupIds)
                        {
                            request.Parameters.Add("LaunchSpecification" + ".SecurityGroupId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
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
            if (publicRequest.IsSetScheduledInstanceId())
            {
                request.Parameters.Add("ScheduledInstanceId", StringUtils.FromString(publicRequest.ScheduledInstanceId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RunScheduledInstancesRequestMarshaller _instance = new();

        internal static RunScheduledInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RunScheduledInstancesRequestMarshaller Instance => _instance;
    }
}
