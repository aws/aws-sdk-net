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
    /// RunScheduledInstances Request Marshaller
    /// </summary>       
    public class RunScheduledInstancesRequestMarshaller : IMarshaller<IRequest, RunScheduledInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunScheduledInstancesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RunScheduledInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RunScheduledInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetLaunchSpecification())
                {
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
                                    if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetSnapshotId())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.SnapshotId));
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
                    if(publicRequest.LaunchSpecification.IsSetMonitoring())
                    {
                        if(publicRequest.LaunchSpecification.Monitoring.IsSetEnabled())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Monitoring" + "." + "Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.Monitoring.Enabled));
                        }
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
                                if(publicRequestLaunchSpecificationlistValue.IsSetAssociatePublicIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.AssociatePublicIpAddress));
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
                                if(publicRequestLaunchSpecificationlistValue.IsSetGroups())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.Groups.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Group", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Groups)
                                         {
                                             request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Group" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue));
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
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Address", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Ipv6Addresses)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIpv6Address())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Address" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.Ipv6Address));
                                            }
                                             publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetNetworkInterfaceId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.NetworkInterfaceId));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddress())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.PrivateIpAddress));
                                }
                                if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddressConfigs())
                                {
                                    if (publicRequestLaunchSpecificationlistValue.PrivateIpAddressConfigs.Count == 0)
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddressConfig", "");
                                    else
                                    {
                                         int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                         foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.PrivateIpAddressConfigs)
                                         {
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrimary())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddressConfig" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestLaunchSpecificationlistValuelistValue.Primary));
                                            }
                                            if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrivateIpAddress())
                                            {
                                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddressConfig" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.PrivateIpAddress));
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
                    }
                    if(publicRequest.LaunchSpecification.IsSetRamdiskId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "RamdiskId", StringUtils.FromString(publicRequest.LaunchSpecification.RamdiskId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetSecurityGroupIds())
                    {
                        if (publicRequest.LaunchSpecification.SecurityGroupIds.Count == 0)
                            request.Parameters.Add("LaunchSpecification" + "." + "SecurityGroupId", "");
                        else
                        {
                             int publicRequestLaunchSpecificationlistValueIndex = 1;
                             foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.SecurityGroupIds)
                             {
                                 request.Parameters.Add("LaunchSpecification" + "." + "SecurityGroupId" + "." + publicRequestLaunchSpecificationlistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValue));
                                 publicRequestLaunchSpecificationlistValueIndex++;
                             }
                        }
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
                if(publicRequest.IsSetScheduledInstanceId())
                {
                    request.Parameters.Add("ScheduledInstanceId", StringUtils.FromString(publicRequest.ScheduledInstanceId));
                }
            }
            return request;
        }
                    private static RunScheduledInstancesRequestMarshaller _instance = new RunScheduledInstancesRequestMarshaller();        

        internal static RunScheduledInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunScheduledInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}