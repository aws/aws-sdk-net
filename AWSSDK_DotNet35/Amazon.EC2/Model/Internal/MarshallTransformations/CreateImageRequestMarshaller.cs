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
    /// Create Image Request Marshaller
    /// </summary>       
    public class CreateImageRequestMarshaller : IMarshaller<IRequest, CreateImageRequest>
    {
        public IRequest Marshall(CreateImageRequest createImageRequest)
        {
            IRequest request = new DefaultRequest(createImageRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateImage");
            request.Parameters.Add("Version", "2013-10-15");
            if (createImageRequest != null && createImageRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(createImageRequest.InstanceId));
            }
            if (createImageRequest != null && createImageRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(createImageRequest.Name));
            }
            if (createImageRequest != null && createImageRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createImageRequest.Description));
            }
            if (createImageRequest != null && createImageRequest.IsSetNoReboot())
            {
                request.Parameters.Add("NoReboot", StringUtils.FromBool(createImageRequest.NoReboot));
            }

            if (createImageRequest != null)
            {
                List<BlockDeviceMapping> blockDeviceMappingsList = createImageRequest.BlockDeviceMappings;
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
