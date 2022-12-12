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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartLabelDetection Request Marshaller
    /// </summary>       
    public class StartLabelDetectionRequestMarshaller : IMarshaller<IRequest, StartLabelDetectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartLabelDetectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartLabelDetectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.StartLabelDetection";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                if(publicRequest.IsSetFeatures())
                {
                    context.Writer.WritePropertyName("Features");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFeaturesListValue in publicRequest.Features)
                    {
                            context.Writer.Write(publicRequestFeaturesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobTag())
                {
                    context.Writer.WritePropertyName("JobTag");
                    context.Writer.Write(publicRequest.JobTag);
                }

                if(publicRequest.IsSetMinConfidence())
                {
                    context.Writer.WritePropertyName("MinConfidence");
                    context.Writer.Write(publicRequest.MinConfidence);
                }

                if(publicRequest.IsSetNotificationChannel())
                {
                    context.Writer.WritePropertyName("NotificationChannel");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationChannel, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelDetectionSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVideo())
                {
                    context.Writer.WritePropertyName("Video");
                    context.Writer.WriteObjectStart();

                    var marshaller = VideoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Video, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartLabelDetectionRequestMarshaller _instance = new StartLabelDetectionRequestMarshaller();        

        internal static StartLabelDetectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartLabelDetectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}