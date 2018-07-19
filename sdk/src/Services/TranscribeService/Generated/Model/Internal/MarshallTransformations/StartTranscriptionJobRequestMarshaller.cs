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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTranscriptionJob Request Marshaller
    /// </summary>       
    public class StartTranscriptionJobRequestMarshaller : IMarshaller<IRequest, StartTranscriptionJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTranscriptionJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTranscriptionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            string target = "Transcribe.StartTranscriptionJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetMedia())
                {
                    context.Writer.WritePropertyName("Media");
                    context.Writer.WriteObjectStart();

                    var marshaller = MediaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Media, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMediaFormat())
                {
                    context.Writer.WritePropertyName("MediaFormat");
                    context.Writer.Write(publicRequest.MediaFormat);
                }

                if(publicRequest.IsSetMediaSampleRateHertz())
                {
                    context.Writer.WritePropertyName("MediaSampleRateHertz");
                    context.Writer.Write(publicRequest.MediaSampleRateHertz);
                }

                if(publicRequest.IsSetOutputBucketName())
                {
                    context.Writer.WritePropertyName("OutputBucketName");
                    context.Writer.Write(publicRequest.OutputBucketName);
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTranscriptionJobName())
                {
                    context.Writer.WritePropertyName("TranscriptionJobName");
                    context.Writer.Write(publicRequest.TranscriptionJobName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartTranscriptionJobRequestMarshaller _instance = new StartTranscriptionJobRequestMarshaller();        

        internal static StartTranscriptionJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTranscriptionJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}