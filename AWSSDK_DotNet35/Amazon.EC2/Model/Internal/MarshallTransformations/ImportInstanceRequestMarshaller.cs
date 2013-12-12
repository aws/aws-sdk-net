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
    /// Import Instance Request Marshaller
    /// </summary>       
    public class ImportInstanceRequestMarshaller : IMarshaller<IRequest, ImportInstanceRequest>
    {
        public IRequest Marshall(ImportInstanceRequest importInstanceRequest)
        {
            IRequest request = new DefaultRequest(importInstanceRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ImportInstance");
            request.Parameters.Add("Version", "2013-10-15");
            if (importInstanceRequest != null && importInstanceRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(importInstanceRequest.Description));
            }
            if (importInstanceRequest != null)
            {
                ImportInstanceLaunchSpecification launchSpecification = importInstanceRequest.LaunchSpecification;
                if (launchSpecification != null && launchSpecification.IsSetArchitecture())
                {
                    request.Parameters.Add("LaunchSpecification.Architecture", StringUtils.FromString(launchSpecification.Architecture));
                }
                if (launchSpecification != null)
                {
                    List<string> groupNamesList = launchSpecification.GroupNames;

                    int groupNamesListIndex = 1;
                    foreach (string groupNamesListValue in groupNamesList)
                    { 
                        request.Parameters.Add("LaunchSpecification.GroupName." + groupNamesListIndex, StringUtils.FromString(groupNamesListValue));
                        groupNamesListIndex++;
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("LaunchSpecification.AdditionalInfo", StringUtils.FromString(launchSpecification.AdditionalInfo));
                }
                if (launchSpecification != null && launchSpecification.IsSetUserData())
                {
                    request.Parameters.Add("LaunchSpecification.UserData", StringUtils.FromString(launchSpecification.UserData));
                }
                if (launchSpecification != null && launchSpecification.IsSetInstanceType())
                {
                    request.Parameters.Add("LaunchSpecification.InstanceType", StringUtils.FromString(launchSpecification.InstanceType));
                }
                if (launchSpecification != null)
                {
                    Placement placement = launchSpecification.Placement;
                    if (placement != null && placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("LaunchSpecification.Placement.AvailabilityZone", StringUtils.FromString(placement.AvailabilityZone));
                    }
                    if (placement != null && placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchSpecification.Placement.GroupName", StringUtils.FromString(placement.GroupName));
                    }
                    if (placement != null && placement.IsSetTenancy())
                    {
                        request.Parameters.Add("LaunchSpecification.Placement.Tenancy", StringUtils.FromString(placement.Tenancy));
                    }
                }
                if (launchSpecification != null && launchSpecification.IsSetMonitoring())
                {
                    request.Parameters.Add("LaunchSpecification.Monitoring", StringUtils.FromBool(launchSpecification.Monitoring));
                }
                if (launchSpecification != null && launchSpecification.IsSetSubnetId())
                {
                    request.Parameters.Add("LaunchSpecification.SubnetId", StringUtils.FromString(launchSpecification.SubnetId));
                }
                if (launchSpecification != null && launchSpecification.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("LaunchSpecification.InstanceInitiatedShutdownBehavior", StringUtils.FromString(launchSpecification.InstanceInitiatedShutdownBehavior));
                }
                if (launchSpecification != null && launchSpecification.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("LaunchSpecification.PrivateIpAddress", StringUtils.FromString(launchSpecification.PrivateIpAddress));
                }
            }

            if (importInstanceRequest != null)
            {
                List<DiskImage> diskImagesList = importInstanceRequest.DiskImages;
                int diskImagesListIndex = 1;
                foreach (DiskImage diskImagesListValue in diskImagesList)
                {
                    if (diskImagesListValue != null)
                    {
                        DiskImageDetail image = diskImagesListValue.Image;
                        if (image != null && image.IsSetFormat())
                        {
                            request.Parameters.Add("DiskImage." + diskImagesListIndex + ".Image.Format", StringUtils.FromString(image.Format));
                        }
                        if (image != null && image.IsSetBytes())
                        {
                            request.Parameters.Add("DiskImage." + diskImagesListIndex + ".Image.Bytes", StringUtils.FromLong(image.Bytes));
                        }
                        if (image != null && image.IsSetImportManifestUrl())
                        {
                            request.Parameters.Add("DiskImage." + diskImagesListIndex + ".Image.ImportManifestUrl", StringUtils.FromString(image.ImportManifestUrl));
                        }
                    }
                    if (diskImagesListValue != null && diskImagesListValue.IsSetDescription())
                    {
                        request.Parameters.Add("DiskImage." + diskImagesListIndex + ".Description", StringUtils.FromString(diskImagesListValue.Description));
                    }
                    if (diskImagesListValue != null)
                    {
                        VolumeDetail volume = diskImagesListValue.Volume;
                        if (volume != null && volume.IsSetSize())
                        {
                            request.Parameters.Add("DiskImage." + diskImagesListIndex + ".Volume.Size", StringUtils.FromLong(volume.Size));
                        }
                    }

                    diskImagesListIndex++;
                }
            }
            if (importInstanceRequest != null && importInstanceRequest.IsSetPlatform())
            {
                request.Parameters.Add("Platform", StringUtils.FromString(importInstanceRequest.Platform));
            }

            return request;
        }
    }
}
