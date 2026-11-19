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
    /// UpdateVocabulary Request Marshaller
    /// </summary>
    public partial class UpdateVocabularyRequestMarshaller : IMarshaller<IRequest, UpdateVocabularyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVocabularyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateVocabularyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Transcribe/operation/UpdateVocabulary";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WriteTextString("DataAccessRoleArn");
                    context.Writer.WriteTextString(publicRequest.DataAccessRoleArn);
                }
                if (publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WriteTextString("EncryptionConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WriteTextString("LanguageCode");
                    context.Writer.WriteTextString(publicRequest.LanguageCode);
                }
                if (publicRequest.IsSetPhrases())
                {
                    context.Writer.WriteTextString("Phrases");
                    context.Writer.WriteStartArray(publicRequest.Phrases.Count);
                    foreach (var publicRequestPhrasesListValue in publicRequest.Phrases)
                    {
                        context.Writer.WriteTextString(publicRequestPhrasesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetVocabularyFileUri())
                {
                    context.Writer.WriteTextString("VocabularyFileUri");
                    context.Writer.WriteTextString(publicRequest.VocabularyFileUri);
                }
                if (publicRequest.IsSetVocabularyName())
                {
                    context.Writer.WriteTextString("VocabularyName");
                    context.Writer.WriteTextString(publicRequest.VocabularyName);
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

        private static readonly UpdateVocabularyRequestMarshaller _instance = new();

        internal static UpdateVocabularyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateVocabularyRequestMarshaller Instance => _instance;
    }
}
