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
    /// ImportSnapshot Request Marshaller
    /// </summary>       
    public class ImportSnapshotRequestMarshaller : IMarshaller<IRequest, ImportSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ImportSnapshot");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientData())
                {
                    if(publicRequest.ClientData.IsSetComment())
                    {
                        request.Parameters.Add("ClientData" + "." + "Comment", StringUtils.FromString(publicRequest.ClientData.Comment));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ClientData.IsSetUploadEndUtc())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadEnd", StringUtils.FromDateTimeToISO8601(publicRequest.ClientData.UploadEndUtc));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ClientData.IsSetUploadSize())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadSize", StringUtils.FromDouble(publicRequest.ClientData.UploadSize));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.ClientData.IsSetUploadStartUtc())
                    {
                        request.Parameters.Add("ClientData" + "." + "UploadStart", StringUtils.FromDateTimeToISO8601(publicRequest.ClientData.UploadStartUtc));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDiskContainer())
                {
                    if(publicRequest.DiskContainer.IsSetDescription())
                    {
                        request.Parameters.Add("DiskContainer" + "." + "Description", StringUtils.FromString(publicRequest.DiskContainer.Description));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DiskContainer.IsSetFormat())
                    {
                        request.Parameters.Add("DiskContainer" + "." + "Format", StringUtils.FromString(publicRequest.DiskContainer.Format));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DiskContainer.IsSetUrl())
                    {
                        request.Parameters.Add("DiskContainer" + "." + "Url", StringUtils.FromString(publicRequest.DiskContainer.Url));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DiskContainer.IsSetUserBucket())
                    {
                        if(publicRequest.DiskContainer.UserBucket.IsSetS3Bucket())
                        {
                            request.Parameters.Add("DiskContainer" + "." + "UserBucket" + "." + "S3Bucket", StringUtils.FromString(publicRequest.DiskContainer.UserBucket.S3Bucket));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.DiskContainer.UserBucket.IsSetS3Key())
                        {
                            request.Parameters.Add("DiskContainer" + "." + "UserBucket" + "." + "S3Key", StringUtils.FromString(publicRequest.DiskContainer.UserBucket.S3Key));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEncrypted())
                {
                    request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRoleName())
                {
                    request.Parameters.Add("RoleName", StringUtils.FromString(publicRequest.RoleName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ImportSnapshotRequestMarshaller _instance = new ImportSnapshotRequestMarshaller();        

        internal static ImportSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}