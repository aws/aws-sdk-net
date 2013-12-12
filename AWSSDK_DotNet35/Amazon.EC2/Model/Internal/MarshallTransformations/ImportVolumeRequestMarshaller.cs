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
    /// Import Volume Request Marshaller
    /// </summary>       
    public class ImportVolumeRequestMarshaller : IMarshaller<IRequest, ImportVolumeRequest>
    {
        public IRequest Marshall(ImportVolumeRequest importVolumeRequest)
        {
            IRequest request = new DefaultRequest(importVolumeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ImportVolume");
            request.Parameters.Add("Version", "2013-10-15");
            if (importVolumeRequest != null && importVolumeRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(importVolumeRequest.AvailabilityZone));
            }
            if (importVolumeRequest != null)
            {
                DiskImageDetail image = importVolumeRequest.Image;
                if (image != null && image.IsSetFormat())
                {
                    request.Parameters.Add("Image.Format", StringUtils.FromString(image.Format));
                }
                if (image != null && image.IsSetBytes())
                {
                    request.Parameters.Add("Image.Bytes", StringUtils.FromLong(image.Bytes));
                }
                if (image != null && image.IsSetImportManifestUrl())
                {
                    request.Parameters.Add("Image.ImportManifestUrl", StringUtils.FromString(image.ImportManifestUrl));
                }
            }
            if (importVolumeRequest != null && importVolumeRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(importVolumeRequest.Description));
            }
            if (importVolumeRequest != null)
            {
                VolumeDetail volume = importVolumeRequest.Volume;
                if (volume != null && volume.IsSetSize())
                {
                    request.Parameters.Add("Volume.Size", StringUtils.FromLong(volume.Size));
                }
            }

            return request;
        }
    }
}
