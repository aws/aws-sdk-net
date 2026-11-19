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
    /// CreateImage Request Marshaller
    /// </summary>
    public partial class CreateImageRequestMarshaller : IMarshaller<IRequest, CreateImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateImage");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetBlockDeviceMappings())
            {
                if (publicRequest.BlockDeviceMappings.Count == 0)
                {
                    request.Parameters.Add("BlockDeviceMapping", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BlockDeviceMappings)
                    {
                        if (item0.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".DeviceName", StringUtils.FromString(item0.DeviceName));
                        }
                        if (item0.IsSetEbs())
                        {
                            if (item0.Ebs.IsSetAvailabilityZone())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".AvailabilityZone", StringUtils.FromString(item0.Ebs.AvailabilityZone));
                            }
                            if (item0.Ebs.IsSetAvailabilityZoneId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".AvailabilityZoneId", StringUtils.FromString(item0.Ebs.AvailabilityZoneId));
                            }
                            if (item0.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item0.Ebs.DeleteOnTermination.Value));
                            }
                            if (item0.Ebs.IsSetEbsCardIndex())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".EbsCardIndex", StringUtils.FromInt(item0.Ebs.EbsCardIndex.Value));
                            }
                            if (item0.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item0.Ebs.Encrypted.Value));
                            }
                            if (item0.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Iops", StringUtils.FromInt(item0.Ebs.Iops.Value));
                            }
                            if (item0.Ebs.IsSetKmsKeyId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item0.Ebs.KmsKeyId));
                            }
                            if (item0.Ebs.IsSetOutpostArn())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".OutpostArn", StringUtils.FromString(item0.Ebs.OutpostArn));
                            }
                            if (item0.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item0.Ebs.SnapshotId));
                            }
                            if (item0.Ebs.IsSetThroughput())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Throughput", StringUtils.FromInt(item0.Ebs.Throughput.Value));
                            }
                            if (item0.Ebs.IsSetVolumeInitializationRate())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeInitializationRate", StringUtils.FromInt(item0.Ebs.VolumeInitializationRate.Value));
                            }
                            if (item0.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item0.Ebs.VolumeSize.Value));
                            }
                            if (item0.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeType", StringUtils.FromString(item0.Ebs.VolumeType));
                            }
                        }
                        if (item0.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".NoDevice", StringUtils.FromString(item0.NoDevice));
                        }
                        if (item0.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".VirtualName", StringUtils.FromString(item0.VirtualName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetBootModeOverride())
            {
                request.Parameters.Add("BootModeOverride", StringUtils.FromString(publicRequest.BootModeOverride));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
            }
            if (publicRequest.IsSetNoReboot())
            {
                request.Parameters.Add("NoReboot", StringUtils.FromBool(publicRequest.NoReboot.Value));
            }
            if (publicRequest.IsSetSnapshotLocation())
            {
                request.Parameters.Add("SnapshotLocation", StringUtils.FromString(publicRequest.SnapshotLocation));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateImageRequestMarshaller _instance = new();

        internal static CreateImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateImageRequestMarshaller Instance => _instance;
    }
}
