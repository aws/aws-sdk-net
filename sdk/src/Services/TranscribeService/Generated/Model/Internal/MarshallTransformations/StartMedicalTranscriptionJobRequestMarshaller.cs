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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContentIdentificationType())
            {
                context.Writer.WritePropertyName("ContentIdentificationType");
                context.Writer.WriteStringValue(publicRequest.ContentIdentificationType);
            }

            if(publicRequest.IsSetKMSEncryptionContext())
            {
                context.Writer.WritePropertyName("KMSEncryptionContext");
                context.Writer.WriteStartObject();
                foreach (var publicRequestKMSEncryptionContextKvp in publicRequest.KMSEncryptionContext)
                {
                    context.Writer.WritePropertyName(publicRequestKMSEncryptionContextKvp.Key);
                    var publicRequestKMSEncryptionContextValue = publicRequestKMSEncryptionContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestKMSEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.WriteStringValue(publicRequest.LanguageCode);
            }

            if(publicRequest.IsSetMedia())
            {
                context.Writer.WritePropertyName("Media");
                context.Writer.WriteStartObject();

                var marshaller = MediaMarshaller.Instance;
                marshaller.Marshall(publicRequest.Media, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMediaFormat())
            {
                context.Writer.WritePropertyName("MediaFormat");
                context.Writer.WriteStringValue(publicRequest.MediaFormat);
            }

            if(publicRequest.IsSetMediaSampleRateHertz())
            {
                context.Writer.WritePropertyName("MediaSampleRateHertz");
                context.Writer.WriteNumberValue(publicRequest.MediaSampleRateHertz.Value);
            }

            if(publicRequest.IsSetMedicalTranscriptionJobName())
            {
                context.Writer.WritePropertyName("MedicalTranscriptionJobName");
                context.Writer.WriteStringValue(publicRequest.MedicalTranscriptionJobName);
            }

            if(publicRequest.IsSetOutputBucketName())
            {
                context.Writer.WritePropertyName("OutputBucketName");
                context.Writer.WriteStringValue(publicRequest.OutputBucketName);
            }

            if(publicRequest.IsSetOutputEncryptionKMSKeyId())
            {
                context.Writer.WritePropertyName("OutputEncryptionKMSKeyId");
                context.Writer.WriteStringValue(publicRequest.OutputEncryptionKMSKeyId);
            }

            if(publicRequest.IsSetOutputKey())
            {
                context.Writer.WritePropertyName("OutputKey");
                context.Writer.WriteStringValue(publicRequest.OutputKey);
            }

            if(publicRequest.IsSetSettings())
            {
                context.Writer.WritePropertyName("Settings");
                context.Writer.WriteStartObject();

                var marshaller = MedicalTranscriptionSettingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSpecialty())
            {
                context.Writer.WritePropertyName("Specialty");
                context.Writer.WriteStringValue(publicRequest.Specialty);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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