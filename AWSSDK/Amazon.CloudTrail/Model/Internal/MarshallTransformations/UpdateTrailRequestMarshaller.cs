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

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable 0618

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Trail Request Marshaller
    /// </summary>       
    internal class UpdateTrailRequestMarshaller : IMarshaller<IRequest, UpdateTrailRequest> 
    {
        

        public IRequest Marshall(UpdateTrailRequest updateTrailRequest) 
        {

            IRequest request = new DefaultRequest(updateTrailRequest, "AmazonCloudTrail");
            string target = "CloudTrail_20131101.UpdateTrail";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
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
                
                if (updateTrailRequest != null && updateTrailRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(updateTrailRequest.Name);
                }
                if (updateTrailRequest != null && updateTrailRequest.IsSetS3BucketName()) 
                {
                    writer.WritePropertyName("S3BucketName");
                    writer.Write(updateTrailRequest.S3BucketName);
                }
                if (updateTrailRequest != null && updateTrailRequest.IsSetS3KeyPrefix()) 
                {
                    writer.WritePropertyName("S3KeyPrefix");
                    writer.Write(updateTrailRequest.S3KeyPrefix);
                }
                if (updateTrailRequest != null && updateTrailRequest.IsSetSnsTopicName()) 
                {
                    writer.WritePropertyName("SnsTopicName");
                    writer.Write(updateTrailRequest.SnsTopicName);
                }
                if (updateTrailRequest != null && updateTrailRequest.IsSetIncludeGlobalServiceEvents()) 
                {
                    writer.WritePropertyName("IncludeGlobalServiceEvents");
                    writer.Write(updateTrailRequest.IncludeGlobalServiceEvents);
                }

                if (updateTrailRequest != null) 
                {
                    Trail trail = updateTrailRequest.Trail;
                    if (trail != null)
                    {
                        writer.WritePropertyName("trail");
                        writer.WriteObjectStart();
                        if (trail != null && trail.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(trail.Name);
                        }
                        if (trail != null && trail.IsSetS3BucketName()) 
                        {
                            writer.WritePropertyName("S3BucketName");
                            writer.Write(trail.S3BucketName);
                        }
                        if (trail != null && trail.IsSetS3KeyPrefix()) 
                        {
                            writer.WritePropertyName("S3KeyPrefix");
                            writer.Write(trail.S3KeyPrefix);
                        }
                        if (trail != null && trail.IsSetSnsTopicName()) 
                        {
                            writer.WritePropertyName("SnsTopicName");
                            writer.Write(trail.SnsTopicName);
                        }
                        if (trail != null && trail.IsSetIncludeGlobalServiceEvents()) 
                        {
                            writer.WritePropertyName("IncludeGlobalServiceEvents");
                            writer.Write(trail.IncludeGlobalServiceEvents);
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
