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

using Amazon.LexModelsV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartBotResourceGeneration Request Marshaller
    /// </summary>
    public partial class StartBotResourceGenerationRequestMarshaller : IMarshaller<IRequest, StartBotResourceGenerationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBotResourceGenerationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartBotResourceGenerationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBotId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            }
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));

            if (!publicRequest.IsSetBotVersion())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotVersion set");
            }
            request.AddPathResource("{botVersion}", StringUtils.FromString(publicRequest.BotVersion));

            if (!publicRequest.IsSetLocaleId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field LocaleId set");
            }
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));

            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/startgeneration";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetGenerationInputPrompt())
            {
                context.Writer.WritePropertyName("generationInputPrompt");
                context.Writer.WriteStringValue(publicRequest.GenerationInputPrompt);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartBotResourceGenerationRequestMarshaller _instance = new();

        internal static StartBotResourceGenerationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartBotResourceGenerationRequestMarshaller Instance => _instance;
    }
}
