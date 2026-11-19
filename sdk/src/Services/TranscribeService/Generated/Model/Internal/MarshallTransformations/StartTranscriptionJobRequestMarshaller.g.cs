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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTranscriptionJob Request Marshaller
    /// </summary>
    public partial class StartTranscriptionJobRequestMarshaller : IMarshaller<IRequest, StartTranscriptionJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTranscriptionJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartTranscriptionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Transcribe/operation/StartTranscriptionJob";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetContentRedaction())
                {
                    context.Writer.WriteTextString("ContentRedaction");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContentRedactionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentRedaction, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetIdentifyLanguage())
                {
                    context.Writer.WriteTextString("IdentifyLanguage");
                    context.Writer.WriteBoolean(publicRequest.IdentifyLanguage.Value);
                }
                if (publicRequest.IsSetIdentifyMultipleLanguages())
                {
                    context.Writer.WriteTextString("IdentifyMultipleLanguages");
                    context.Writer.WriteBoolean(publicRequest.IdentifyMultipleLanguages.Value);
                }
                if (publicRequest.IsSetJobExecutionSettings())
                {
                    context.Writer.WriteTextString("JobExecutionSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = JobExecutionSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobExecutionSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetKMSEncryptionContext())
                {
                    context.Writer.WriteTextString("KMSEncryptionContext");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestKMSEncryptionContextKvp in publicRequest.KMSEncryptionContext)
                    {
                        context.Writer.WriteTextString(publicRequestKMSEncryptionContextKvp.Key);
                        var publicRequestKMSEncryptionContextValue = publicRequestKMSEncryptionContextKvp.Value;
                        context.Writer.WriteTextString(publicRequestKMSEncryptionContextValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WriteTextString("LanguageCode");
                    context.Writer.WriteTextString(publicRequest.LanguageCode);
                }
                if (publicRequest.IsSetLanguageIdSettings())
                {
                    context.Writer.WriteTextString("LanguageIdSettings");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestLanguageIdSettingsKvp in publicRequest.LanguageIdSettings)
                    {
                        context.Writer.WriteTextString(publicRequestLanguageIdSettingsKvp.Key);
                        var publicRequestLanguageIdSettingsValue = publicRequestLanguageIdSettingsKvp.Value;
                        context.Writer.WriteStartMap(null);

                        var marshaller = LanguageIdSettingsMarshaller.Instance;
                        marshaller.Marshall(publicRequestLanguageIdSettingsValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLanguageOptions())
                {
                    context.Writer.WriteTextString("LanguageOptions");
                    context.Writer.WriteStartArray(publicRequest.LanguageOptions.Count);
                    foreach (var publicRequestLanguageOptionsListValue in publicRequest.LanguageOptions)
                    {
                        context.Writer.WriteTextString(publicRequestLanguageOptionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetMedia())
                {
                    context.Writer.WriteTextString("Media");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MediaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Media, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMediaFormat())
                {
                    context.Writer.WriteTextString("MediaFormat");
                    context.Writer.WriteTextString(publicRequest.MediaFormat);
                }
                if (publicRequest.IsSetMediaSampleRateHertz())
                {
                    context.Writer.WriteTextString("MediaSampleRateHertz");
                    context.Writer.WriteInt32(publicRequest.MediaSampleRateHertz.Value);
                }
                if (publicRequest.IsSetModelSettings())
                {
                    context.Writer.WriteTextString("ModelSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ModelSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOutputBucketName())
                {
                    context.Writer.WriteTextString("OutputBucketName");
                    context.Writer.WriteTextString(publicRequest.OutputBucketName);
                }
                if (publicRequest.IsSetOutputEncryptionKMSKeyId())
                {
                    context.Writer.WriteTextString("OutputEncryptionKMSKeyId");
                    context.Writer.WriteTextString(publicRequest.OutputEncryptionKMSKeyId);
                }
                if (publicRequest.IsSetOutputKey())
                {
                    context.Writer.WriteTextString("OutputKey");
                    context.Writer.WriteTextString(publicRequest.OutputKey);
                }
                if (publicRequest.IsSetSettings())
                {
                    context.Writer.WriteTextString("Settings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSubtitles())
                {
                    context.Writer.WriteTextString("Subtitles");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SubtitlesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Subtitles, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetToxicityDetection())
                {
                    context.Writer.WriteTextString("ToxicityDetection");
                    context.Writer.WriteStartArray(publicRequest.ToxicityDetection.Count);
                    foreach (var publicRequestToxicityDetectionListValue in publicRequest.ToxicityDetection)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ToxicityDetectionSettingsMarshaller.Instance;
                        marshaller.Marshall(publicRequestToxicityDetectionListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTranscriptionJobName())
                {
                    context.Writer.WriteTextString("TranscriptionJobName");
                    context.Writer.WriteTextString(publicRequest.TranscriptionJobName);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly StartTranscriptionJobRequestMarshaller _instance = new();

        internal static StartTranscriptionJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartTranscriptionJobRequestMarshaller Instance => _instance;
    }
}
