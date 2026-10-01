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

using Amazon.ConnectWisdomService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectWisdomService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotifyRecommendationsReceived Request Marshaller
    /// </summary>
    public partial class NotifyRecommendationsReceivedRequestMarshaller : IMarshaller<IRequest, NotifyRecommendationsReceivedRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NotifyRecommendationsReceivedRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(NotifyRecommendationsReceivedRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssistantId())
            {
                throw new AmazonConnectWisdomServiceException("Request object does not have required field AssistantId set");
            }
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));

            if (!publicRequest.IsSetSessionId())
            {
                throw new AmazonConnectWisdomServiceException("Request object does not have required field SessionId set");
            }
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));

            request.ResourcePath = "/assistants/{assistantId}/sessions/{sessionId}/recommendations/notify";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetRecommendationIds())
            {
                context.Writer.WritePropertyName("recommendationIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRecommendationIdsListValue in publicRequest.RecommendationIds)
                {
                    context.Writer.WriteStringValue(publicRequestRecommendationIdsListValue);
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

        private static readonly NotifyRecommendationsReceivedRequestMarshaller _instance = new();

        internal static NotifyRecommendationsReceivedRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static NotifyRecommendationsReceivedRequestMarshaller Instance => _instance;
    }
}
