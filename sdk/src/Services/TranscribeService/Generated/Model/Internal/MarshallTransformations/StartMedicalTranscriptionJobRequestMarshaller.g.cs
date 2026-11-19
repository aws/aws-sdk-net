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
    /// StartMedicalTranscriptionJob Request Marshaller
    /// </summary>
    public partial class StartMedicalTranscriptionJobRequestMarshaller : IMarshaller<IRequest, StartMedicalTranscriptionJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartMedicalTranscriptionJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartMedicalTranscriptionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Transcribe/operation/StartMedicalTranscriptionJob";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetContentIdentificationType())
                {
                    context.Writer.WriteTextString("ContentIdentificationType");
                    context.Writer.WriteTextString(publicRequest.ContentIdentificationType);
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
                if (publicRequest.IsSetMedicalTranscriptionJobName())
                {
                    context.Writer.WriteTextString("MedicalTranscriptionJobName");
                    context.Writer.WriteTextString(publicRequest.MedicalTranscriptionJobName);
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

                    var marshaller = MedicalTranscriptionSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSpecialty())
                {
                    context.Writer.WriteTextString("Specialty");
                    context.Writer.WriteTextString(publicRequest.Specialty);
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
                if (publicRequest.IsSetType())
                {
                    context.Writer.WriteTextString("Type");
                    context.Writer.WriteTextString(publicRequest.Type);
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

        private static readonly StartMedicalTranscriptionJobRequestMarshaller _instance = new();

        internal static StartMedicalTranscriptionJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartMedicalTranscriptionJobRequestMarshaller Instance => _instance;
    }
}
