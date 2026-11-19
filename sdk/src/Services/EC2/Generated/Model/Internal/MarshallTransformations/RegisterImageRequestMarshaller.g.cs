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
    /// RegisterImage Request Marshaller
    /// </summary>
    public partial class RegisterImageRequestMarshaller : IMarshaller<IRequest, RegisterImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RegisterImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RegisterImage");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetArchitecture())
            {
                request.Parameters.Add("Architecture", StringUtils.FromString(publicRequest.Architecture));
            }
            if (publicRequest.IsSetBillingProducts())
            {
                if (publicRequest.BillingProducts.Count == 0)
                {
                    request.Parameters.Add("BillingProduct", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BillingProducts)
                    {
                        request.Parameters.Add("BillingProduct" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
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
            if (publicRequest.IsSetBootMode())
            {
                request.Parameters.Add("BootMode", StringUtils.FromString(publicRequest.BootMode));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEnaSupport())
            {
                request.Parameters.Add("EnaSupport", StringUtils.FromBool(publicRequest.EnaSupport.Value));
            }
            if (publicRequest.IsSetImageLocation())
            {
                request.Parameters.Add("ImageLocation", StringUtils.FromString(publicRequest.ImageLocation));
            }
            if (publicRequest.IsSetImdsSupport())
            {
                request.Parameters.Add("ImdsSupport", StringUtils.FromString(publicRequest.ImdsSupport));
            }
            if (publicRequest.IsSetKernelId())
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
            }
            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
            }
            if (publicRequest.IsSetRamdiskId())
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
            }
            if (publicRequest.IsSetRootDeviceName())
            {
                request.Parameters.Add("RootDeviceName", StringUtils.FromString(publicRequest.RootDeviceName));
            }
            if (publicRequest.IsSetSriovNetSupport())
            {
                request.Parameters.Add("SriovNetSupport", StringUtils.FromString(publicRequest.SriovNetSupport));
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
            if (publicRequest.IsSetTpmSupport())
            {
                request.Parameters.Add("TpmSupport", StringUtils.FromString(publicRequest.TpmSupport));
            }
            if (publicRequest.IsSetUefiData())
            {
                request.Parameters.Add("UefiData", StringUtils.FromString(publicRequest.UefiData));
            }
            if (publicRequest.IsSetVirtualizationType())
            {
                request.Parameters.Add("VirtualizationType", StringUtils.FromString(publicRequest.VirtualizationType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RegisterImageRequestMarshaller _instance = new();

        internal static RegisterImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RegisterImageRequestMarshaller Instance => _instance;
    }
}
