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

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
    public class UpdatePipelineRequestMarshaller : IMarshaller<IRequest, UpdatePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePipelineRequest)input);
        }

        public IRequest Marshall(UpdatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/2012-09-25/pipelines/{Id}";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.IsSetId() ? StringUtils.FromString(publicRequest.Id) : string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAwsKmsKeyArn())
                {
                    context.Writer.WritePropertyName("AwsKmsKeyArn");
                    context.Writer.Write(publicRequest.AwsKmsKeyArn);
                }

                if(publicRequest.IsSetContentConfig())
                {
                    context.Writer.WritePropertyName("ContentConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipelineOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputBucket())
                {
                    context.Writer.WritePropertyName("InputBucket");
                    context.Writer.Write(publicRequest.InputBucket);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotifications())
                {
                    context.Writer.WritePropertyName("Notifications");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Notifications, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetThumbnailConfig())
                {
                    context.Writer.WritePropertyName("ThumbnailConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipelineOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ThumbnailConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}