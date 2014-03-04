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
    /// Create Pipeline Request Marshaller
    /// </summary>       
    internal class CreatePipelineRequestMarshaller : IMarshaller<IRequest, CreatePipelineRequest> 
    {
        

        public IRequest Marshall(CreatePipelineRequest createPipelineRequest) 
        {

            IRequest request = new DefaultRequest(createPipelineRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.CreatePipeline";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "POST";
              
            string uriResourcePath = "2012-09-25/pipelines"; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createPipelineRequest != null && createPipelineRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(createPipelineRequest.Name);
                }
                if (createPipelineRequest != null && createPipelineRequest.IsSetInputBucket()) 
                {
                    writer.WritePropertyName("InputBucket");
                    writer.Write(createPipelineRequest.InputBucket);
                }
                if (createPipelineRequest != null && createPipelineRequest.IsSetOutputBucket()) 
                {
                    writer.WritePropertyName("OutputBucket");
                    writer.Write(createPipelineRequest.OutputBucket);
                }
                if (createPipelineRequest != null && createPipelineRequest.IsSetRole()) 
                {
                    writer.WritePropertyName("Role");
                    writer.Write(createPipelineRequest.Role);
                }

                if (createPipelineRequest != null) 
                {
                    Notifications notifications = createPipelineRequest.Notifications;
                    if (notifications != null)
                    {
                        writer.WritePropertyName("Notifications");
                        writer.WriteObjectStart();
                        if (notifications != null && notifications.IsSetProgressing()) 
                        {
                            writer.WritePropertyName("Progressing");
                            writer.Write(notifications.Progressing);
                        }
                        if (notifications != null && notifications.IsSetCompleted()) 
                        {
                            writer.WritePropertyName("Completed");
                            writer.Write(notifications.Completed);
                        }
                        if (notifications != null && notifications.IsSetWarning()) 
                        {
                            writer.WritePropertyName("Warning");
                            writer.Write(notifications.Warning);
                        }
                        if (notifications != null && notifications.IsSetError()) 
                        {
                            writer.WritePropertyName("Error");
                            writer.Write(notifications.Error);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createPipelineRequest != null) 
                {
                    PipelineOutputConfig contentConfig = createPipelineRequest.ContentConfig;
                    if (contentConfig != null)
                    {
                        writer.WritePropertyName("ContentConfig");
                        writer.WriteObjectStart();
                        if (contentConfig != null && contentConfig.IsSetBucket()) 
                        {
                            writer.WritePropertyName("Bucket");
                            writer.Write(contentConfig.Bucket);
                        }
                        if (contentConfig != null && contentConfig.IsSetStorageClass()) 
                        {
                            writer.WritePropertyName("StorageClass");
                            writer.Write(contentConfig.StorageClass);
                        }

                        if (contentConfig != null && contentConfig.Permissions != null && contentConfig.Permissions.Count > 0)
                        {
                            List<Permission> permissionsList = contentConfig.Permissions;
                            writer.WritePropertyName("Permissions");
                            writer.WriteArrayStart();

                            foreach (Permission permissionsListValue in permissionsList) 
                            {
                                writer.WriteObjectStart();
                                if (permissionsListValue != null && permissionsListValue.IsSetGranteeType()) 
                                {
                                    writer.WritePropertyName("GranteeType");
                                    writer.Write(permissionsListValue.GranteeType);
                                }
                                if (permissionsListValue != null && permissionsListValue.IsSetGrantee()) 
                                {
                                    writer.WritePropertyName("Grantee");
                                    writer.Write(permissionsListValue.Grantee);
                                }

                                if (permissionsListValue != null && permissionsListValue.Access != null && permissionsListValue.Access.Count > 0) 
                                {
                                    List<string> accessList = permissionsListValue.Access;
                                    writer.WritePropertyName("Access");
                                    writer.WriteArrayStart();

                                    foreach (string accessListValue in accessList) 
                                    { 
                                        writer.Write(StringUtils.FromString(accessListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createPipelineRequest != null) 
                {
                    PipelineOutputConfig thumbnailConfig = createPipelineRequest.ThumbnailConfig;
                    if (thumbnailConfig != null)
                    {
                        writer.WritePropertyName("ThumbnailConfig");
                        writer.WriteObjectStart();
                        if (thumbnailConfig != null && thumbnailConfig.IsSetBucket()) 
                        {
                            writer.WritePropertyName("Bucket");
                            writer.Write(thumbnailConfig.Bucket);
                        }
                        if (thumbnailConfig != null && thumbnailConfig.IsSetStorageClass()) 
                        {
                            writer.WritePropertyName("StorageClass");
                            writer.Write(thumbnailConfig.StorageClass);
                        }

                        if (thumbnailConfig != null && thumbnailConfig.Permissions != null && thumbnailConfig.Permissions.Count > 0)
                        {
                            List<Permission> permissionsList = thumbnailConfig.Permissions;
                            writer.WritePropertyName("Permissions");
                            writer.WriteArrayStart();

                            foreach (Permission permissionsListValue in permissionsList) 
                            {
                                writer.WriteObjectStart();
                                if (permissionsListValue != null && permissionsListValue.IsSetGranteeType()) 
                                {
                                    writer.WritePropertyName("GranteeType");
                                    writer.Write(permissionsListValue.GranteeType);
                                }
                                if (permissionsListValue != null && permissionsListValue.IsSetGrantee()) 
                                {
                                    writer.WritePropertyName("Grantee");
                                    writer.Write(permissionsListValue.Grantee);
                                }

                                if (permissionsListValue != null && permissionsListValue.Access != null && permissionsListValue.Access.Count > 0) 
                                {
                                    List<string> accessList = permissionsListValue.Access;
                                    writer.WritePropertyName("Access");
                                    writer.WriteArrayStart();

                                    foreach (string accessListValue in accessList) 
                                    { 
                                        writer.Write(StringUtils.FromString(accessListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
