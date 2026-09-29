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

using Amazon.Lex.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSession Request Marshaller
    /// </summary>
    public partial class PutSessionRequestMarshaller : IMarshaller<IRequest, PutSessionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSessionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lex");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccept())
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }

            if (!publicRequest.IsSetBotAlias())
            {
                throw new AmazonLexException("Request object does not have required field BotAlias set");
            }
            request.AddPathResource("{botAlias}", StringUtils.FromString(publicRequest.BotAlias));

            if (!publicRequest.IsSetBotName())
            {
                throw new AmazonLexException("Request object does not have required field BotName set");
            }
            request.AddPathResource("{botName}", StringUtils.FromString(publicRequest.BotName));

            if (!publicRequest.IsSetUserId())
            {
                throw new AmazonLexException("Request object does not have required field UserId set");
            }
            request.AddPathResource("{userId}", StringUtils.FromString(publicRequest.UserId));

            request.ResourcePath = "/bot/{botName}/alias/{botAlias}/user/{userId}/session";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetActiveContexts())
            {
                context.Writer.WritePropertyName("activeContexts");
                context.Writer.WriteStartArray();
                foreach (var publicRequestActiveContextsListValue in publicRequest.ActiveContexts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActiveContextMarshaller.Instance;
                    marshaller.Marshall(publicRequestActiveContextsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDialogAction())
            {
                context.Writer.WritePropertyName("dialogAction");
                context.Writer.WriteStartObject();

                var marshaller = DialogActionMarshaller.Instance;
                marshaller.Marshall(publicRequest.DialogAction, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRecentIntentSummaryView())
            {
                context.Writer.WritePropertyName("recentIntentSummaryView");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRecentIntentSummaryViewListValue in publicRequest.RecentIntentSummaryView)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntentSummaryMarshaller.Instance;
                    marshaller.Marshall(publicRequestRecentIntentSummaryViewListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSessionAttributes())
            {
                context.Writer.WritePropertyName("sessionAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSessionAttributesKvp in publicRequest.SessionAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestSessionAttributesKvp.Key);
                    var publicRequestSessionAttributesValue = publicRequestSessionAttributesKvp.Value;
                    context.Writer.WriteStringValue(publicRequestSessionAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutSessionRequestMarshaller _instance = new();

        internal static PutSessionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutSessionRequestMarshaller Instance => _instance;
    }
}
