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
    /// ImportImage Request Marshaller
    /// </summary>
    public partial class ImportImageRequestMarshaller : IMarshaller<IRequest, ImportImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ImportImage");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetArchitecture())
            {
                request.Parameters.Add("Architecture", StringUtils.FromString(publicRequest.Architecture));
            }
            if (publicRequest.IsSetBootMode())
            {
                request.Parameters.Add("BootMode", StringUtils.FromString(publicRequest.BootMode));
            }
            if (publicRequest.IsSetClientData())
            {
                if (publicRequest.ClientData.IsSetComment())
                {
                    request.Parameters.Add("ClientData" + ".Comment", StringUtils.FromString(publicRequest.ClientData.Comment));
                }
                if (publicRequest.ClientData.IsSetUploadEnd())
                {
                    request.Parameters.Add("ClientData" + ".UploadEnd", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ClientData.UploadEnd.Value));
                }
                if (publicRequest.ClientData.IsSetUploadSize())
                {
                    request.Parameters.Add("ClientData" + ".UploadSize", StringUtils.FromDouble(publicRequest.ClientData.UploadSize.Value));
                }
                if (publicRequest.ClientData.IsSetUploadStart())
                {
                    request.Parameters.Add("ClientData" + ".UploadStart", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ClientData.UploadStart.Value));
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDiskContainers())
            {
                if (publicRequest.DiskContainers.Count == 0)
                {
                    request.Parameters.Add("DiskContainer", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DiskContainers)
                    {
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("DiskContainer" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetDeviceName())
                        {
                            request.Parameters.Add("DiskContainer" + "." + index0 + ".DeviceName", StringUtils.FromString(item0.DeviceName));
                        }
                        if (item0.IsSetFormat())
                        {
                            request.Parameters.Add("DiskContainer" + "." + index0 + ".Format", StringUtils.FromString(item0.Format));
                        }
                        if (item0.IsSetSnapshotId())
                        {
                            request.Parameters.Add("DiskContainer" + "." + index0 + ".SnapshotId", StringUtils.FromString(item0.SnapshotId));
                        }
                        if (item0.IsSetUrl())
                        {
                            request.Parameters.Add("DiskContainer" + "." + index0 + ".Url", StringUtils.FromString(item0.Url));
                        }
                        if (item0.IsSetUserBucket())
                        {
                            if (item0.UserBucket.IsSetS3Bucket())
                            {
                                request.Parameters.Add("DiskContainer" + "." + index0 + ".UserBucket" + ".S3Bucket", StringUtils.FromString(item0.UserBucket.S3Bucket));
                            }
                            if (item0.UserBucket.IsSetS3Key())
                            {
                                request.Parameters.Add("DiskContainer" + "." + index0 + ".UserBucket" + ".S3Key", StringUtils.FromString(item0.UserBucket.S3Key));
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
            if (publicRequest.IsSetEncrypted())
            {
                request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted.Value));
            }
            if (publicRequest.IsSetHypervisor())
            {
                request.Parameters.Add("Hypervisor", StringUtils.FromString(publicRequest.Hypervisor));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetLicenseSpecifications())
            {
                if (publicRequest.LicenseSpecifications.Count == 0)
                {
                    request.Parameters.Add("LicenseSpecifications", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LicenseSpecifications)
                    {
                        if (item0.IsSetLicenseConfigurationArn())
                        {
                            request.Parameters.Add("LicenseSpecifications" + "." + index0 + ".LicenseConfigurationArn", StringUtils.FromString(item0.LicenseConfigurationArn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetLicenseType())
            {
                request.Parameters.Add("LicenseType", StringUtils.FromString(publicRequest.LicenseType));
            }
            if (publicRequest.IsSetPlatform())
            {
                request.Parameters.Add("Platform", StringUtils.FromString(publicRequest.Platform));
            }
            if (publicRequest.IsSetRoleName())
            {
                request.Parameters.Add("RoleName", StringUtils.FromString(publicRequest.RoleName));
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
            if (publicRequest.IsSetUsageOperation())
            {
                request.Parameters.Add("UsageOperation", StringUtils.FromString(publicRequest.UsageOperation));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ImportImageRequestMarshaller _instance = new();

        internal static ImportImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportImageRequestMarshaller Instance => _instance;
    }
}
