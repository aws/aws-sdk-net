/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Transform
{
    /// <summary>
    /// Create Launch Configuration Request Marshaller
    /// </summary>       
    public class CreateLaunchConfigurationRequestMarshaller : IMarshaller<IRequest<CreateLaunchConfigurationRequest>, CreateLaunchConfigurationRequest> 
    {

        public IRequest<CreateLaunchConfigurationRequest> Marshall(CreateLaunchConfigurationRequest createLaunchConfigurationRequest) 
        {
            IRequest<CreateLaunchConfigurationRequest> request = new DefaultRequest<CreateLaunchConfigurationRequest>(createLaunchConfigurationRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "CreateLaunchConfiguration");
            request.Parameters.Add("Version", "2011-01-01");
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetLaunchConfigurationName()) 
            {
                request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(createLaunchConfigurationRequest.LaunchConfigurationName));
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetImageId()) 
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(createLaunchConfigurationRequest.ImageId));
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetKeyName()) 
            {
                request.Parameters.Add("KeyName", StringUtils.FromString(createLaunchConfigurationRequest.KeyName));
            }
            if (createLaunchConfigurationRequest != null) 
            {
                List<string> securityGroupsList = createLaunchConfigurationRequest.SecurityGroups;

                int securityGroupsListIndex = 1;
                foreach (string securityGroupsListValue in securityGroupsList) 
                { 
                    request.Parameters.Add("SecurityGroups.member." + securityGroupsListIndex, StringUtils.FromString(securityGroupsListValue));
                    securityGroupsListIndex++;
                }
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetUserData()) 
            {
                request.Parameters.Add("UserData", StringUtils.FromString(createLaunchConfigurationRequest.UserData));
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetInstanceType()) 
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(createLaunchConfigurationRequest.InstanceType));
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetKernelId()) 
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(createLaunchConfigurationRequest.KernelId));
            }
            if (createLaunchConfigurationRequest != null && createLaunchConfigurationRequest.IsSetRamdiskId()) 
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(createLaunchConfigurationRequest.RamdiskId));
            }

            if (createLaunchConfigurationRequest != null) 
            {
                List<BlockDeviceMapping> blockDeviceMappingsList = createLaunchConfigurationRequest.BlockDeviceMappings;
                int blockDeviceMappingsListIndex = 1;
                foreach (BlockDeviceMapping blockDeviceMappingsListValue in blockDeviceMappingsList) 
                { 
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetVirtualName()) 
                    {
                        request.Parameters.Add("BlockDeviceMappings.member." + blockDeviceMappingsListIndex + ".VirtualName", StringUtils.FromString(blockDeviceMappingsListValue.VirtualName));
                    }
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetDeviceName()) 
                    {
                        request.Parameters.Add("BlockDeviceMappings.member." + blockDeviceMappingsListIndex + ".DeviceName", StringUtils.FromString(blockDeviceMappingsListValue.DeviceName));
                    }
                    if (blockDeviceMappingsListValue != null) 
                    {
                        Ebs ebs = blockDeviceMappingsListValue.Ebs;
                        if (ebs != null && ebs.IsSetSnapshotId()) 
                        {
                            request.Parameters.Add("BlockDeviceMappings.member." + blockDeviceMappingsListIndex + ".Ebs.SnapshotId", StringUtils.FromString(ebs.SnapshotId));
                        }
                        if (ebs != null && ebs.IsSetVolumeSize()) 
                        {
                            request.Parameters.Add("BlockDeviceMappings.member." + blockDeviceMappingsListIndex + ".Ebs.VolumeSize", StringUtils.FromInt(ebs.VolumeSize));
                        }
                    }

                    blockDeviceMappingsListIndex++;
                }
            }
            if (createLaunchConfigurationRequest != null) 
            {
                InstanceMonitoring instanceMonitoring = createLaunchConfigurationRequest.InstanceMonitoring;
                if (instanceMonitoring != null && instanceMonitoring.IsSetEnabled()) 
                {
                    request.Parameters.Add("InstanceMonitoring.Enabled", StringUtils.FromBool(instanceMonitoring.Enabled));
                }
            }


            return request;
        }
    }
}
