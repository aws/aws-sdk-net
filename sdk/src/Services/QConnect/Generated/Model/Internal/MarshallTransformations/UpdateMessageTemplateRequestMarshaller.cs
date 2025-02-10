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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
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
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMessageTemplate Request Marshaller
    /// </summary>       
    public class UpdateMessageTemplateRequestMarshaller : IMarshaller<IRequest, UpdateMessageTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMessageTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMessageTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonQConnectException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            if (!publicRequest.IsSetMessageTemplateId())
                throw new AmazonQConnectException("Request object does not have required field MessageTemplateId set");
            request.AddPathResource("{messageTemplateId}", StringUtils.FromString(publicRequest.MessageTemplateId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/messageTemplates/{messageTemplateId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("content");
                context.Writer.WriteStartObject();

                var marshaller = MessageTemplateContentProviderMarshaller.Instance;
                marshaller.Marshall(publicRequest.Content, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefaultAttributes())
            {
                context.Writer.WritePropertyName("defaultAttributes");
                context.Writer.WriteStartObject();

                var marshaller = MessageTemplateAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(publicRequest.Language);
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
        private static UpdateMessageTemplateRequestMarshaller _instance = new UpdateMessageTemplateRequestMarshaller();        

        internal static UpdateMessageTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMessageTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}