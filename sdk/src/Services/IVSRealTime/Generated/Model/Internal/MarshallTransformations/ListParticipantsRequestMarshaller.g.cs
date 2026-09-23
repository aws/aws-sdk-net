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

using Amazon.IVSRealTime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IVSRealTime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListParticipants Request Marshaller
    /// </summary>
    public partial class ListParticipantsRequestMarshaller : IMarshaller<IRequest, ListParticipantsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListParticipantsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListParticipantsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IVSRealTime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ListParticipants";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFilterByPublished())
            {
                context.Writer.WritePropertyName("filterByPublished");
                context.Writer.WriteBooleanValue(publicRequest.FilterByPublished.Value);
            }
            if (publicRequest.IsSetFilterByRecordingState())
            {
                context.Writer.WritePropertyName("filterByRecordingState");
                context.Writer.WriteStringValue(publicRequest.FilterByRecordingState);
            }
            if (publicRequest.IsSetFilterByState())
            {
                context.Writer.WritePropertyName("filterByState");
                context.Writer.WriteStringValue(publicRequest.FilterByState);
            }
            if (publicRequest.IsSetFilterByUserId())
            {
                context.Writer.WritePropertyName("filterByUserId");
                context.Writer.WriteStringValue(publicRequest.FilterByUserId);
            }
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetSessionId())
            {
                context.Writer.WritePropertyName("sessionId");
                context.Writer.WriteStringValue(publicRequest.SessionId);
            }
            if (publicRequest.IsSetStageArn())
            {
                context.Writer.WritePropertyName("stageArn");
                context.Writer.WriteStringValue(publicRequest.StageArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListParticipantsRequestMarshaller _instance = new();

        internal static ListParticipantsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListParticipantsRequestMarshaller Instance => _instance;
    }
}
