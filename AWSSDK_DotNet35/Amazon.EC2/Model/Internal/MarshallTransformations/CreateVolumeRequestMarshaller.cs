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
    /// Create Volume Request Marshaller
    /// </summary>       
    public class CreateVolumeRequestMarshaller : IMarshaller<IRequest, CreateVolumeRequest>
    {
        public IRequest Marshall(CreateVolumeRequest createVolumeRequest)
        {
            IRequest request = new DefaultRequest(createVolumeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateVolume");
            request.Parameters.Add("Version", "2013-10-15");
            if (createVolumeRequest != null && createVolumeRequest.IsSetSize())
            {
                request.Parameters.Add("Size", StringUtils.FromInt(createVolumeRequest.Size));
            }
            if (createVolumeRequest != null && createVolumeRequest.IsSetSnapshotId())
            {
                request.Parameters.Add("SnapshotId", StringUtils.FromString(createVolumeRequest.SnapshotId));
            }
            if (createVolumeRequest != null && createVolumeRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(createVolumeRequest.AvailabilityZone));
            }
            if (createVolumeRequest != null && createVolumeRequest.IsSetVolumeType())
            {
                request.Parameters.Add("VolumeType", StringUtils.FromString(createVolumeRequest.VolumeType));
            }
            if (createVolumeRequest != null && createVolumeRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(createVolumeRequest.Iops));
            }

            return request;
        }
    }
}
