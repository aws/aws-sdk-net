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
    /// UpdatePipeline Request Marshaller
    /// </summary>       
    public class UpdatePipelineRequestMarshaller : IMarshaller<IRequest, UpdatePipelineRequest> 
    {
        public IRequest Marshall(UpdatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            string target = ".UpdatePipeline";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/2012-09-25/pipelines/{Id}";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.Id ?? string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetContentConfig())
                {
                    writer.WritePropertyName("ContentConfig");
                    writer.WriteObjectStart();
                    if(publicRequest.ContentConfig != null && publicRequest.ContentConfig.IsSetBucket())
                    {
                        writer.WritePropertyName("Bucket");
                        writer.Write(publicRequest.ContentConfig.Bucket);
                    }

                    if(publicRequest.ContentConfig != null && publicRequest.ContentConfig.IsSetPermissions() && publicRequest.ContentConfig.Permissions.Count > 0)
                    {
                        writer.WritePropertyName("Permissions");
                        writer.WriteArrayStart();
                        foreach(var publicRequestContentConfigPermissionsListValue in publicRequest.ContentConfig.Permissions)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestContentConfigPermissionsListValue != null && publicRequestContentConfigPermissionsListValue.IsSetAccess() && publicRequestContentConfigPermissionsListValue.Access.Count > 0)
                            {
                                writer.WritePropertyName("Access");
                                writer.WriteArrayStart();
                                foreach(var publicRequestContentConfigPermissionsListValueAccessListValue in publicRequestContentConfigPermissionsListValue.Access)
                                {
                                    writer.Write(publicRequestContentConfigPermissionsListValueAccessListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestContentConfigPermissionsListValue != null && publicRequestContentConfigPermissionsListValue.IsSetGrantee())
                            {
                                writer.WritePropertyName("Grantee");
                                writer.Write(publicRequestContentConfigPermissionsListValue.Grantee);
                            }

                            if(publicRequestContentConfigPermissionsListValue != null && publicRequestContentConfigPermissionsListValue.IsSetGranteeType())
                            {
                                writer.WritePropertyName("GranteeType");
                                writer.Write(publicRequestContentConfigPermissionsListValue.GranteeType);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.ContentConfig != null && publicRequest.ContentConfig.IsSetStorageClass())
                    {
                        writer.WritePropertyName("StorageClass");
                        writer.Write(publicRequest.ContentConfig.StorageClass);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetInputBucket())
                {
                    writer.WritePropertyName("InputBucket");
                    writer.Write(publicRequest.InputBucket);
                }

                if(publicRequest != null && publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest != null && publicRequest.IsSetNotifications())
                {
                    writer.WritePropertyName("Notifications");
                    writer.WriteObjectStart();
                    if(publicRequest.Notifications != null && publicRequest.Notifications.IsSetCompleted())
                    {
                        writer.WritePropertyName("Completed");
                        writer.Write(publicRequest.Notifications.Completed);
                    }

                    if(publicRequest.Notifications != null && publicRequest.Notifications.IsSetError())
                    {
                        writer.WritePropertyName("Error");
                        writer.Write(publicRequest.Notifications.Error);
                    }

                    if(publicRequest.Notifications != null && publicRequest.Notifications.IsSetProgressing())
                    {
                        writer.WritePropertyName("Progressing");
                        writer.Write(publicRequest.Notifications.Progressing);
                    }

                    if(publicRequest.Notifications != null && publicRequest.Notifications.IsSetWarning())
                    {
                        writer.WritePropertyName("Warning");
                        writer.Write(publicRequest.Notifications.Warning);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetRole())
                {
                    writer.WritePropertyName("Role");
                    writer.Write(publicRequest.Role);
                }

                if(publicRequest != null && publicRequest.IsSetThumbnailConfig())
                {
                    writer.WritePropertyName("ThumbnailConfig");
                    writer.WriteObjectStart();
                    if(publicRequest.ThumbnailConfig != null && publicRequest.ThumbnailConfig.IsSetBucket())
                    {
                        writer.WritePropertyName("Bucket");
                        writer.Write(publicRequest.ThumbnailConfig.Bucket);
                    }

                    if(publicRequest.ThumbnailConfig != null && publicRequest.ThumbnailConfig.IsSetPermissions() && publicRequest.ThumbnailConfig.Permissions.Count > 0)
                    {
                        writer.WritePropertyName("Permissions");
                        writer.WriteArrayStart();
                        foreach(var publicRequestThumbnailConfigPermissionsListValue in publicRequest.ThumbnailConfig.Permissions)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestThumbnailConfigPermissionsListValue != null && publicRequestThumbnailConfigPermissionsListValue.IsSetAccess() && publicRequestThumbnailConfigPermissionsListValue.Access.Count > 0)
                            {
                                writer.WritePropertyName("Access");
                                writer.WriteArrayStart();
                                foreach(var publicRequestThumbnailConfigPermissionsListValueAccessListValue in publicRequestThumbnailConfigPermissionsListValue.Access)
                                {
                                    writer.Write(publicRequestThumbnailConfigPermissionsListValueAccessListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestThumbnailConfigPermissionsListValue != null && publicRequestThumbnailConfigPermissionsListValue.IsSetGrantee())
                            {
                                writer.WritePropertyName("Grantee");
                                writer.Write(publicRequestThumbnailConfigPermissionsListValue.Grantee);
                            }

                            if(publicRequestThumbnailConfigPermissionsListValue != null && publicRequestThumbnailConfigPermissionsListValue.IsSetGranteeType())
                            {
                                writer.WritePropertyName("GranteeType");
                                writer.Write(publicRequestThumbnailConfigPermissionsListValue.GranteeType);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.ThumbnailConfig != null && publicRequest.ThumbnailConfig.IsSetStorageClass())
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