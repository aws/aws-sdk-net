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
    /// TranscribeAudio Request Marshaller
    /// </summary>
    public partial class TranscribeAudioRequestMarshaller : IMarshaller<IRequest, TranscribeAudioRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TranscribeAudioRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(TranscribeAudioRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Transcribe/operation/TranscribeAudio";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetChannelIdentification())
                {
                    context.Writer.WriteTextString("ChannelIdentification");
                    context.Writer.WriteBoolean(publicRequest.ChannelIdentification.Value);
                }
                if (publicRequest.IsSetContentRedaction())
                {
                    context.Writer.WriteTextString("ContentRedaction");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContentRedactionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentRedaction, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLanguage())
                {
                    context.Writer.WriteTextString("Language");
                    context.Writer.WriteTextString(publicRequest.Language);
                }
                if (publicRequest.IsSetLanguageDetectionMode())
                {
                    context.Writer.WriteTextString("LanguageDetectionMode");
                    context.Writer.WriteTextString(publicRequest.LanguageDetectionMode);
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
                if (publicRequest.IsSetMaxSpeakerLabels())
                {
                    context.Writer.WriteTextString("MaxSpeakerLabels");
                    context.Writer.WriteInt32(publicRequest.MaxSpeakerLabels.Value);
                }
                if (publicRequest.IsSetMedia())
                {
                    context.Writer.WriteTextString("Media");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SyncMediaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Media, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOutputConfiguration())
                {
                    context.Writer.WriteTextString("OutputConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SyncOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetShowSpeakerLabels())
                {
                    context.Writer.WriteTextString("ShowSpeakerLabels");
                    context.Writer.WriteBoolean(publicRequest.ShowSpeakerLabels.Value);
                }
                if (publicRequest.IsSetVocabularyFilterSettings())
                {
                    context.Writer.WriteTextString("VocabularyFilterSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VocabularyFilterSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VocabularyFilterSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetVocabularySettings())
                {
                    context.Writer.WriteTextString("VocabularySettings");
                    context.Writer.WriteStartArray(publicRequest.VocabularySettings.Count);
                    foreach (var publicRequestVocabularySettingsListValue in publicRequest.VocabularySettings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = VocabularySettingsEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestVocabularySettingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly TranscribeAudioRequestMarshaller _instance = new();

        internal static TranscribeAudioRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TranscribeAudioRequestMarshaller Instance => _instance;
    }
}
