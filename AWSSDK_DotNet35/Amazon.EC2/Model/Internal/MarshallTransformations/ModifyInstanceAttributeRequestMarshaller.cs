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
    /// Modify Instance Attribute Request Marshaller
    /// </summary>       
    public class ModifyInstanceAttributeRequestMarshaller : IMarshaller<IRequest, ModifyInstanceAttributeRequest>
    {
        public IRequest Marshall(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest)
        {
            IRequest request = new DefaultRequest(modifyInstanceAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifyInstanceAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(modifyInstanceAttributeRequest.InstanceId));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(modifyInstanceAttributeRequest.Attribute));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetValue())
            {
                request.Parameters.Add("Value", StringUtils.FromString(modifyInstanceAttributeRequest.Value));
            }

            if (modifyInstanceAttributeRequest != null)
            {
                List<InstanceBlockDeviceMappingSpecification> blockDeviceMappingsList = modifyInstanceAttributeRequest.BlockDeviceMappings;
                int blockDeviceMappingsListIndex = 1;
                foreach (InstanceBlockDeviceMappingSpecification blockDeviceMappingsListValue in blockDeviceMappingsList)
                {
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetDeviceName())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".DeviceName", StringUtils.FromString(blockDeviceMappingsListValue.DeviceName));
                    }
                    if (blockDeviceMappingsListValue != null)
                    {
                        EbsInstanceBlockDeviceSpecification ebs = blockDeviceMappingsListValue.Ebs;
                        if (ebs != null && ebs.IsSetVolumeId())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.VolumeId", StringUtils.FromString(ebs.VolumeId));
                        }
                        if (ebs != null && ebs.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".Ebs.DeleteOnTermination", StringUtils.FromBool(ebs.DeleteOnTermination));
                        }
                    }
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetVirtualName())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".VirtualName", StringUtils.FromString(blockDeviceMappingsListValue.VirtualName));
                    }
                    if (blockDeviceMappingsListValue != null && blockDeviceMappingsListValue.IsSetNoDevice())
                    {
                        request.Parameters.Add("BlockDeviceMapping." + blockDeviceMappingsListIndex + ".NoDevice", StringUtils.FromString(blockDeviceMappingsListValue.NoDevice));
                    }

                    blockDeviceMappingsListIndex++;
                }
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetSourceDestCheck())
            {
                request.Parameters.Add("SourceDestCheck.Value", StringUtils.FromBool(modifyInstanceAttributeRequest.SourceDestCheck));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetDisableApiTermination())
            {
                request.Parameters.Add("DisableApiTermination.Value", StringUtils.FromBool(modifyInstanceAttributeRequest.DisableApiTermination));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType.Value", StringUtils.FromString(modifyInstanceAttributeRequest.InstanceType));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetKernel())
            {
                request.Parameters.Add("Kernel.Value", StringUtils.FromString(modifyInstanceAttributeRequest.Kernel));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetRamdisk())
            {
                request.Parameters.Add("Ramdisk.Value", StringUtils.FromString(modifyInstanceAttributeRequest.Ramdisk));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetUserData())
            {
                request.Parameters.Add("UserData.Value", StringUtils.FromString(modifyInstanceAttributeRequest.UserData));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetInstanceInitiatedShutdownBehavior())
            {
                request.Parameters.Add("InstanceInitiatedShutdownBehavior.Value", StringUtils.FromString(modifyInstanceAttributeRequest.InstanceInitiatedShutdownBehavior));
            }
            if (modifyInstanceAttributeRequest != null)
            {
                List<string> groupsList = modifyInstanceAttributeRequest.Groups;

                int groupsListIndex = 1;
                foreach (string groupsListValue in groupsList)
                { 
                    request.Parameters.Add("GroupId." + groupsListIndex, StringUtils.FromString(groupsListValue));
                    groupsListIndex++;
                }
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized.Value", StringUtils.FromBool(modifyInstanceAttributeRequest.EbsOptimized));
            }
            if (modifyInstanceAttributeRequest != null && modifyInstanceAttributeRequest.IsSetSriovNetSupport())
            {
                request.Parameters.Add("SriovNetSupport.Value", StringUtils.FromString(modifyInstanceAttributeRequest.SriovNetSupport));
            }

            return request;
        }
    }
}
