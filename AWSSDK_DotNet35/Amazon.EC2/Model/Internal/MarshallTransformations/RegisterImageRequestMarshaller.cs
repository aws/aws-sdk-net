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
    /// Register Image Request Marshaller
    /// </summary>       
    public class RegisterImageRequestMarshaller : IMarshaller<IRequest, RegisterImageRequest>
    {
        public IRequest Marshall(RegisterImageRequest registerImageRequest)
        {
            IRequest request = new DefaultRequest(registerImageRequest, "AmazonEC2");
            request.Parameters.Add("Action", "RegisterImage");
            request.Parameters.Add("Version", "2013-10-15");
            if (registerImageRequest != null && registerImageRequest.IsSetImageLocation())
            {
                request.Parameters.Add("ImageLocation", StringUtils.FromString(registerImageRequest.ImageLocation));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(registerImageRequest.Name));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(registerImageRequest.Description));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetArchitecture())
            {
                request.Parameters.Add("Architecture", StringUtils.FromString(registerImageRequest.Architecture));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetKernelId())
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(registerImageRequest.KernelId));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetRamdiskId())
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(registerImageRequest.RamdiskId));
            }
            if (registerImageRequest != null && registerImageRequest.IsSetRootDeviceName())
            {
                request.Parameters.Add("RootDeviceName", StringUtils.FromString(registerImageRequest.RootDeviceName));
            }

            if (registerImageRequest != null)
            {
                List<BlockDeviceMapping> blockDeviceMappingsList = registerImageRequest.BlockDeviceMappings;
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

            return request;
        }
    }
}
