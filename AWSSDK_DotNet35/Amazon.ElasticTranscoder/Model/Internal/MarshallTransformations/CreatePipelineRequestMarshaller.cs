/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePipeline Request Marshaller
    /// </summary>       
    public class CreatePipelineRequestMarshaller : IMarshaller<IRequest, CreatePipelineRequest> 
    {
        public IRequest Marshall(CreatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/pipelines";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetContentConfig())
                {
                    writer.WritePropertyName("ContentConfig");
                    writer.WriteObjectStart();
                    if(publicRequest.ContentConfig.IsSetBucket())
                    {
                        writer.WritePropertyName("Bucket");
                        writer.Write(publicRequest.ContentConfig.Bucket);
                    }

                    if(publicRequest.ContentConfig.IsSetPermissions())
                    {
                        writer.WritePropertyName("Permissions");
                        writer.WriteArrayStart();
                        foreach(var publicRequestContentConfigPermissionsListValue in publicRequest.ContentConfig.Permissions)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestContentConfigPermissionsListValue.IsSetAccess())
                            {
                                writer.WritePropertyName("Access");
                                writer.WriteArrayStart();
                                foreach(var publicRequestContentConfigPermissionsListValueAccessListValue in publicRequestContentConfigPermissionsListValue.Access)
                                {
                                    writer.Write(publicRequestContentConfigPermissionsListValueAccessListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestContentConfigPermissionsListValue.IsSetGrantee())
                            {
                                writer.WritePropertyName("Grantee");
                                writer.Write(publicRequestContentConfigPermissionsListValue.Grantee);
                            }

                            if(publicRequestContentConfigPermissionsListValue.IsSetGranteeType())
                            {
                                writer.WritePropertyName("GranteeType");
                                writer.Write(publicRequestContentConfigPermissionsListValue.GranteeType);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.ContentConfig.IsSetStorageClass())
                    {
                        writer.WritePropertyName("StorageClass");
                        writer.Write(publicRequest.ContentConfig.StorageClass);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputBucket())
                {
                    writer.WritePropertyName("InputBucket");
                    writer.Write(publicRequest.InputBucket);
                }

                if(publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotifications())
                {
                    writer.WritePropertyName("Notifications");
                    writer.WriteObjectStart();
                    if(publicRequest.Notifications.IsSetCompleted())
                    {
                        writer.WritePropertyName("Completed");
                        writer.Write(publicRequest.Notifications.Completed);
                    }

                    if(publicRequest.Notifications.IsSetError())
                    {
                        writer.WritePropertyName("Error");
                        writer.Write(publicRequest.Notifications.Error);
                    }

                    if(publicRequest.Notifications.IsSetProgressing())
                    {
                        writer.WritePropertyName("Progressing");
                        writer.Write(publicRequest.Notifications.Progressing);
                    }

                    if(publicRequest.Notifications.IsSetWarning())
                    {
                        writer.WritePropertyName("Warning");
                        writer.Write(publicRequest.Notifications.Warning);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputBucket())
                {
                    writer.WritePropertyName("OutputBucket");
                    writer.Write(publicRequest.OutputBucket);
                }

                if(publicRequest.IsSetRole())
                {
                    writer.WritePropertyName("Role");
                    writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetThumbnailConfig())
                {
                    writer.WritePropertyName("ThumbnailConfig");
                    writer.WriteObjectStart();
                    if(publicRequest.ThumbnailConfig.IsSetBucket())
                    {
                        writer.WritePropertyName("Bucket");
                        writer.Write(publicRequest.ThumbnailConfig.Bucket);
                    }

                    if(publicRequest.ThumbnailConfig.IsSetPermissions())
                    {
                        writer.WritePropertyName("Permissions");
                        writer.WriteArrayStart();
                        foreach(var publicRequestThumbnailConfigPermissionsListValue in publicRequest.ThumbnailConfig.Permissions)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestThumbnailConfigPermissionsListValue.IsSetAccess())
                            {
                                writer.WritePropertyName("Access");
                                writer.WriteArrayStart();
                                foreach(var publicRequestThumbnailConfigPermissionsListValueAccessListValue in publicRequestThumbnailConfigPermissionsListValue.Access)
                                {
                                    writer.Write(publicRequestThumbnailConfigPermissionsListValueAccessListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestThumbnailConfigPermissionsListValue.IsSetGrantee())
                            {
                                writer.WritePropertyName("Grantee");
                                writer.Write(publicRequestThumbnailConfigPermissionsListValue.Grantee);
                            }

                            if(publicRequestThumbnailConfigPermissionsListValue.IsSetGranteeType())
                            {
                                writer.WritePropertyName("GranteeType");
                                writer.Write(publicRequestThumbnailConfigPermissionsListValue.GranteeType);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.ThumbnailConfig.IsSetStorageClass())
                    {
                        writer.WritePropertyName("StorageClass");
                        writer.Write(publicRequest.ThumbnailConfig.StorageClass);
                    }

                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}