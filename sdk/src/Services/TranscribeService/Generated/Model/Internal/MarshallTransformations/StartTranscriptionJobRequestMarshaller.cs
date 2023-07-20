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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContentRedaction())
                {
                    context.Writer.WritePropertyName("ContentRedaction");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContentRedactionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentRedaction, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentifyLanguage())
                {
                    context.Writer.WritePropertyName("IdentifyLanguage");
                    context.Writer.Write(publicRequest.IdentifyLanguage);
                }

                if(publicRequest.IsSetIdentifyMultipleLanguages())
                {
                    context.Writer.WritePropertyName("IdentifyMultipleLanguages");
                    context.Writer.Write(publicRequest.IdentifyMultipleLanguages);
                }

                if(publicRequest.IsSetJobExecutionSettings())
                {
                    context.Writer.WritePropertyName("JobExecutionSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobExecutionSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobExecutionSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKMSEncryptionContext())
                {
                    context.Writer.WritePropertyName("KMSEncryptionContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestKMSEncryptionContextKvp in publicRequest.KMSEncryptionContext)
                    {
                        context.Writer.WritePropertyName(publicRequestKMSEncryptionContextKvp.Key);
                        var publicRequestKMSEncryptionContextValue = publicRequestKMSEncryptionContextKvp.Value;

                            context.Writer.Write(publicRequestKMSEncryptionContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetLanguageIdSettings())
                {
                    context.Writer.WritePropertyName("LanguageIdSettings");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestLanguageIdSettingsKvp in publicRequest.LanguageIdSettings)
                    {
                        context.Writer.WritePropertyName(publicRequestLanguageIdSettingsKvp.Key);
                        var publicRequestLanguageIdSettingsValue = publicRequestLanguageIdSettingsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = LanguageIdSettingsMarshaller.Instance;
                        marshaller.Marshall(publicRequestLanguageIdSettingsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLanguageOptions())
                {
                    context.Writer.WritePropertyName("LanguageOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLanguageOptionsListValue in publicRequest.LanguageOptions)
                    {
                            context.Writer.Write(publicRequestLanguageOptionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetModelSettings())
                {
                    context.Writer.WritePropertyName("ModelSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelSettings, context);

                    context.Writer.WriteObjectEnd();
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

                    var marshaller = SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubtitles())
                {
                    context.Writer.WritePropertyName("Subtitles");
                    context.Writer.WriteObjectStart();

                    var marshaller = SubtitlesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Subtitles, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetToxicityDetection())
                {
                    context.Writer.WritePropertyName("ToxicityDetection");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestToxicityDetectionListValue in publicRequest.ToxicityDetection)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ToxicityDetectionSettingsMarshaller.Instance;
                        marshaller.Marshall(publicRequestToxicityDetectionListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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