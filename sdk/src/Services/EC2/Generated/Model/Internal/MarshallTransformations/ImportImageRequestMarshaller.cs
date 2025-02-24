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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportImage Request Marshaller
    /// </summary>       
    public class ImportImageRequestMarshaller : IMarshaller<IRequest, ImportImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportImageRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ImportImage");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetArchitecture())
                {
                    request.Parameters.Add("Architecture", StringUtils.FromString(publicRequest.Architecture));
                }
                if(publicRequest.IsSetBootMode())
                {
                    request.Parameters.Add("BootMode", StringUtils.FromString(publicRequest.BootMode));
                }
                if(publicRequest.IsSetClientData())
                {
                    if(publicRequest.ClientData.IsSetComment())
                    {
                        request.Parameters.Add("ClientData" + "." + "Comment", StringUtils.FromString(publicRequest.ClientData.Comment));
                    }
                    if(publicRequest.ClientData.IsSetUploadEnd())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadEnd", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ClientData.UploadEnd));
                    }
                    if(publicRequest.ClientData.IsSetUploadSize())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadSize", StringUtils.FromDouble(publicRequest.ClientData.UploadSize));
                    }
                    if(publicRequest.ClientData.IsSetUploadStart())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadStart", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ClientData.UploadStart));
                    }
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDiskContainers())
                {
                    if (publicRequest.DiskContainers.Count == 0)
                        request.Parameters.Add("DiskContainer", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.DiskContainers)
                         {
                            if(publicRequestlistValue.IsSetDescription())
                            {
                                request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                            }
                            if(publicRequestlistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                            }
                            if(publicRequestlistValue.IsSetFormat())
                            {
                                request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "Format", StringUtils.FromString(publicRequestlistValue.Format));
                            }
                            if(publicRequestlistValue.IsSetSnapshotId())
                            {
                                request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.SnapshotId));
                            }
                            if(publicRequestlistValue.IsSetUrl())
                            {
                                request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "Url", StringUtils.FromString(publicRequestlistValue.Url));
                            }
                            if(publicRequestlistValue.IsSetUserBucket())
                            {
                                if(publicRequestlistValue.UserBucket.IsSetS3Bucket())
                                {
                                    request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "UserBucket" + "." + "S3Bucket", StringUtils.FromString(publicRequestlistValue.UserBucket.S3Bucket));
                                }
                                if(publicRequestlistValue.UserBucket.IsSetS3Key())
                                {
                                    request.Parameters.Add("DiskContainer" + "." + publicRequestlistValueIndex + "." + "UserBucket" + "." + "S3Key", StringUtils.FromString(publicRequestlistValue.UserBucket.S3Key));
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEncrypted())
                {
                    request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted));
                }
                if(publicRequest.IsSetHypervisor())
                {
                    request.Parameters.Add("Hypervisor", StringUtils.FromString(publicRequest.Hypervisor));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetLicenseSpecifications())
                {
                    if (publicRequest.LicenseSpecifications.Count == 0)
                        request.Parameters.Add("LicenseSpecifications", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.LicenseSpecifications)
                         {
                            if(publicRequestlistValue.IsSetLicenseConfigurationArn())
                            {
                                request.Parameters.Add("LicenseSpecifications" + "." + publicRequestlistValueIndex + "." + "LicenseConfigurationArn", StringUtils.FromString(publicRequestlistValue.LicenseConfigurationArn));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetLicenseType())
                {
                    request.Parameters.Add("LicenseType", StringUtils.FromString(publicRequest.LicenseType));
                }
                if(publicRequest.IsSetPlatform())
                {
                    request.Parameters.Add("Platform", StringUtils.FromString(publicRequest.Platform));
                }
                if(publicRequest.IsSetRoleName())
                {
                    request.Parameters.Add("RoleName", StringUtils.FromString(publicRequest.RoleName));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUsageOperation())
                {
                    request.Parameters.Add("UsageOperation", StringUtils.FromString(publicRequest.UsageOperation));
                }
            }
            return request;
        }
                    private static ImportImageRequestMarshaller _instance = new ImportImageRequestMarshaller();        

        internal static ImportImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}