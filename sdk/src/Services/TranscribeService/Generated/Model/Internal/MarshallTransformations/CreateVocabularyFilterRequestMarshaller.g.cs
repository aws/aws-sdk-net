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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.TranscribeService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVocabularyFilter Request Marshaller
    /// </summary>
    public partial class CreateVocabularyFilterRequestMarshaller : IMarshaller<IRequest, CreateVocabularyFilterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVocabularyFilterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateVocabularyFilterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            string target = "Transcribe.CreateVocabularyFilter";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDataAccessRoleArn())
            {
                context.Writer.WritePropertyName("DataAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.DataAccessRoleArn);
            }
            if (publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.WriteStringValue(publicRequest.LanguageCode);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetVocabularyFilterFileUri())
            {
                context.Writer.WritePropertyName("VocabularyFilterFileUri");
                context.Writer.WriteStringValue(publicRequest.VocabularyFilterFileUri);
            }
            if (publicRequest.IsSetVocabularyFilterName())
            {
                context.Writer.WritePropertyName("VocabularyFilterName");
                context.Writer.WriteStringValue(publicRequest.VocabularyFilterName);
            }
            if (publicRequest.IsSetWords())
            {
                context.Writer.WritePropertyName("Words");
                context.Writer.WriteStartArray();
                foreach (var publicRequestWordsListValue in publicRequest.Words)
                {
                    context.Writer.WriteStringValue(publicRequestWordsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateVocabularyFilterRequestMarshaller _instance = new();

        internal static CreateVocabularyFilterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateVocabularyFilterRequestMarshaller Instance => _instance;
    }
}
