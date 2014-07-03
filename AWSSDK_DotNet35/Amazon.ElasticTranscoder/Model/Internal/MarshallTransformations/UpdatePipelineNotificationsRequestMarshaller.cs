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
    /// UpdatePipelineNotifications Request Marshaller
    /// </summary>       
    public class UpdatePipelineNotificationsRequestMarshaller : IMarshaller<IRequest, UpdatePipelineNotificationsRequest> 
    {
        public IRequest Marshall(UpdatePipelineNotificationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2012-09-25/pipelines/{Id}/notifications";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.IsSetId() ? StringUtils.FromString(publicRequest.Id) : string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}