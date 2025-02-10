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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexRuntimeV2.Model;
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
namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSession Request Marshaller
    /// </summary>       
    public class PutSessionRequestMarshaller : IMarshaller<IRequest, PutSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexRuntimeV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBotAliasId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotAliasId set");
            request.AddPathResource("{botAliasId}", StringUtils.FromString(publicRequest.BotAliasId));
            if (!publicRequest.IsSetBotId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field BotId set");
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));
            if (!publicRequest.IsSetLocaleId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field LocaleId set");
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonLexRuntimeV2Exception("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/bots/{botId}/botAliases/{botAliasId}/botLocales/{localeId}/sessions/{sessionId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetMessages())
            {
                context.Writer.WritePropertyName("messages");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMessagesListValue in publicRequest.Messages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRequestAttributes())
            {
                context.Writer.WritePropertyName("requestAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestAttributesKvp in publicRequest.RequestAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestRequestAttributesKvp.Key);
                    var publicRequestRequestAttributesValue = publicRequestRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionStateValue())
            {
                context.Writer.WritePropertyName("sessionState");
                context.Writer.WriteStartObject();

                var marshaller = SessionStateMarshaller.Instance;
                marshaller.Marshall(publicRequest.SessionStateValue, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetResponseContentType()) 
            {
                request.Headers["ResponseContentType"] = publicRequest.ResponseContentType;
            }

            return request;
        }
        private static PutSessionRequestMarshaller _instance = new PutSessionRequestMarshaller();        

        internal static PutSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}