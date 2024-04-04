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
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLaunchSpecification())
                {
                    if(publicRequest.LaunchSpecification.IsSetBlockDeviceMappings())
                    {
                        int publicRequestLaunchSpecificationlistValueIndex = 1;
                        foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.BlockDeviceMappings)
                        {
                            if(publicRequestLaunchSpecificationlistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.DeviceName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetEbs())
                            {
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.Ebs.DeleteOnTermination));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.Ebs.Encrypted));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.Iops));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.SnapshotId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ebs.VolumeSize));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestLaunchSpecificationlistValue.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Ebs.VolumeType));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetNoDevice())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.NoDevice));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetVirtualName())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "BlockDeviceMapping" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.VirtualName));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestLaunchSpecificationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetEbsOptimized())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "EbsOptimized", StringUtils.FromBool(publicRequest.LaunchSpecification.EbsOptimized));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetIamInstanceProfile())
                    {
                        if(publicRequest.LaunchSpecification.IamInstanceProfile.IsSetArn())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Arn));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.LaunchSpecification.IamInstanceProfile.IsSetName())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.LaunchSpecification.IamInstanceProfile.Name));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetImageId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "ImageId", StringUtils.FromString(publicRequest.LaunchSpecification.ImageId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetInstanceType())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "InstanceType", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetKernelId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "KernelId", StringUtils.FromString(publicRequest.LaunchSpecification.KernelId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetKeyName())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "KeyName", StringUtils.FromString(publicRequest.LaunchSpecification.KeyName));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetMonitoring())
                    {
                        if(publicRequest.LaunchSpecification.Monitoring.IsSetEnabled())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Monitoring" + "." + "Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.Monitoring.Enabled));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetNetworkInterfaces())
                    {
                        int publicRequestLaunchSpecificationlistValueIndex = 1;
                        foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.NetworkInterfaces)
                        {
                            if(publicRequestLaunchSpecificationlistValue.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.AssociatePublicIpAddress));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestLaunchSpecificationlistValue.DeleteOnTermination));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetDescription())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.Description));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.DeviceIndex));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetGroups())
                            {
                                int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Groups)
                                {
                                    request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Group" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue));
                                    publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetIpv6AddressCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.Ipv6AddressCount));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetIpv6Addresses())
                            {
                                int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.Ipv6Addresses)
                                {
                                    if(publicRequestLaunchSpecificationlistValuelistValue.IsSetIpv6Address())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "Ipv6Address" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.Ipv6Address));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.NetworkInterfaceId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.PrivateIpAddress));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetPrivateIpAddressConfigs())
                            {
                                int publicRequestLaunchSpecificationlistValuelistValueIndex = 1;
                                foreach(var publicRequestLaunchSpecificationlistValuelistValue in publicRequestLaunchSpecificationlistValue.PrivateIpAddressConfigs)
                                {
                                    if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrimary())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddressConfig" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestLaunchSpecificationlistValuelistValue.Primary));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestLaunchSpecificationlistValuelistValue.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "PrivateIpAddressConfig" + "." + publicRequestLaunchSpecificationlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestLaunchSpecificationlistValuelistValue.PrivateIpAddress));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestLaunchSpecificationlistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetSecondaryPrivateIpAddressCount())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestLaunchSpecificationlistValue.SecondaryPrivateIpAddressCount));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestLaunchSpecificationlistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("LaunchSpecification" + "." + "NetworkInterface" + "." + publicRequestLaunchSpecificationlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestLaunchSpecificationlistValue.SubnetId));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestLaunchSpecificationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetPlacement())
                    {
                        if(publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZone));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetRamdiskId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "RamdiskId", StringUtils.FromString(publicRequest.LaunchSpecification.RamdiskId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetSecurityGroupIds())
                    {
                        int publicRequestLaunchSpecificationlistValueIndex = 1;
                        foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.SecurityGroupIds)
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "SecurityGroupId" + "." + publicRequestLaunchSpecificationlistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValue));
                            publicRequestLaunchSpecificationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetSubnetId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "SubnetId", StringUtils.FromString(publicRequest.LaunchSpecification.SubnetId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchSpecification.IsSetUserData())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "UserData", StringUtils.FromString(publicRequest.LaunchSpecification.UserData));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetScheduledInstanceId())
                {
                    request.Parameters.Add("ScheduledInstanceId", StringUtils.FromString(publicRequest.ScheduledInstanceId));
                }
#pragma warning restore CS0612,CS0618
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