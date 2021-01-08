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
    /// StartMedicalTranscriptionJob Request Marshaller
    /// </summary>       
    public class StartMedicalTranscriptionJobRequestMarshaller : IMarshaller<IRequest, StartMedicalTranscriptionJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartMedicalTranscriptionJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartMedicalTranscriptionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            string target = "Transcribe.StartMedicalTranscriptionJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
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

                if(publicRequest.IsSetMedicalTranscriptionJobName())
                {
                    context.Writer.WritePropertyName("MedicalTranscriptionJobName");
                    context.Writer.Write(publicRequest.MedicalTranscriptionJobName);
                }

                if(publicRequest.IsSetOutputBucketName())
                {
                    context.Writer.WritePropertyName("OutputBucketName");
                    context.Writer.Write(publicRequest.OutputBucketName);
                }

                if(publicRequest.IsSetOutputEncryptionKMSKeyId())
                {
                    context.Writer.WritePropertyName("OutputEncryptionKMSKeyId");
                    context.Writer.Write(publicRequest.OutputEncryptionKMSKeyId);
                }

                if(publicRequest.IsSetOutputKey())
                {
                    context.Writer.WritePropertyName("OutputKey");
                    context.Writer.Write(publicRequest.OutputKey);
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = MedicalTranscriptionSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSpecialty())
                {
                    context.Writer.WritePropertyName("Specialty");
                    context.Writer.Write(publicRequest.Specialty);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartMedicalTranscriptionJobRequestMarshaller _instance = new StartMedicalTranscriptionJobRequestMarshaller();        

        internal static StartMedicalTranscriptionJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartMedicalTranscriptionJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}