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
    /// ImportInstance Request Marshaller
    /// </summary>
    public partial class ImportInstanceRequestMarshaller : IMarshaller<IRequest, ImportInstanceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportInstanceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ImportInstance");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDiskImages())
            {
                if (publicRequest.DiskImages.Count == 0)
                {
                    request.Parameters.Add("DiskImage", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DiskImages)
                    {
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("DiskImage" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetImage())
                        {
                            if (item0.Image.IsSetBytes())
                            {
                                request.Parameters.Add("DiskImage" + "." + index0 + ".Image" + ".Bytes", StringUtils.FromLong(item0.Image.Bytes.Value));
                            }
                            if (item0.Image.IsSetFormat())
                            {
                                request.Parameters.Add("DiskImage" + "." + index0 + ".Image" + ".Format", StringUtils.FromString(item0.Image.Format));
                            }
                            if (item0.Image.IsSetImportManifestUrl())
                            {
                                request.Parameters.Add("DiskImage" + "." + index0 + ".Image" + ".ImportManifestUrl", StringUtils.FromString(item0.Image.ImportManifestUrl));
                            }
                        }
                        if (item0.IsSetVolume())
                        {
                            if (item0.Volume.IsSetSize())
                            {
                                request.Parameters.Add("DiskImage" + "." + index0 + ".Volume" + ".Size", StringUtils.FromLong(item0.Volume.Size.Value));
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetLaunchSpecification())
            {
                if (publicRequest.LaunchSpecification.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("LaunchSpecification" + ".AdditionalInfo", StringUtils.FromString(publicRequest.LaunchSpecification.AdditionalInfo));
                }
                if (publicRequest.LaunchSpecification.IsSetArchitecture())
                {
                    request.Parameters.Add("LaunchSpecification" + ".Architecture", StringUtils.FromString(publicRequest.LaunchSpecification.Architecture));
                }
                if (publicRequest.LaunchSpecification.IsSetGroupIds())
                {
                    if (publicRequest.LaunchSpecification.GroupIds.Count == 0)
                    {
                        request.Parameters.Add("LaunchSpecification" + ".GroupId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchSpecification.GroupIds)
                        {
                            request.Parameters.Add("LaunchSpecification" + ".GroupId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetGroupNames())
                {
                    if (publicRequest.LaunchSpecification.GroupNames.Count == 0)
                    {
                        request.Parameters.Add("LaunchSpecification" + ".GroupName", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchSpecification.GroupNames)
                        {
                            request.Parameters.Add("LaunchSpecification" + ".GroupName" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("LaunchSpecification" + ".InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceInitiatedShutdownBehavior));
                }
                if (publicRequest.LaunchSpecification.IsSetInstanceType())
                {
                    request.Parameters.Add("LaunchSpecification" + ".InstanceType", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceType));
                }
                if (publicRequest.LaunchSpecification.IsSetMonitoring())
                {
                    request.Parameters.Add("LaunchSpecification" + ".Monitoring.Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.Monitoring.Value));
                }
                if (publicRequest.LaunchSpecification.IsSetPlacement())
                {
                    if (publicRequest.LaunchSpecification.Placement.IsSetAffinity())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".Affinity", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Affinity));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".AvailabilityZone", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZone));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZoneId())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".AvailabilityZoneId", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZoneId));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetGroupId())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".GroupId", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupId));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetHostId())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".HostId", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.HostId));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetHostResourceGroupArn())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".HostResourceGroupArn", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.HostResourceGroupArn));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetPartitionNumber())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".PartitionNumber", StringUtils.FromInt(publicRequest.LaunchSpecification.Placement.PartitionNumber.Value));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetSpreadDomain())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".SpreadDomain", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.SpreadDomain));
                    }
                    if (publicRequest.LaunchSpecification.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".Placement" + ".Tenancy", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Tenancy));
                    }
                }
                if (publicRequest.LaunchSpecification.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("LaunchSpecification" + ".PrivateIpAddress", StringUtils.FromString(publicRequest.LaunchSpecification.PrivateIpAddress));
                }
                if (publicRequest.LaunchSpecification.IsSetSubnetId())
                {
                    request.Parameters.Add("LaunchSpecification" + ".SubnetId", StringUtils.FromString(publicRequest.LaunchSpecification.SubnetId));
                }
                if (publicRequest.LaunchSpecification.IsSetUserData())
                {
                    if (publicRequest.LaunchSpecification.UserData.IsSetData())
                    {
                        request.Parameters.Add("LaunchSpecification" + ".UserData" + ".Data", StringUtils.FromString(publicRequest.LaunchSpecification.UserData.Data));
                    }
                }
            }
            if (publicRequest.IsSetPlatform())
            {
                request.Parameters.Add("Platform", StringUtils.FromString(publicRequest.Platform));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ImportInstanceRequestMarshaller _instance = new();

        internal static ImportInstanceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportInstanceRequestMarshaller Instance => _instance;
    }
}
