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

using Amazon.SimpleEmailV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRecommendations Request Marshaller
    /// </summary>
    public partial class ListRecommendationsRequestMarshaller : IMarshaller<IRequest, ListRecommendationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/email/vdm/recommendations";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFilterKvp in publicRequest.Filter)
                {
                    context.Writer.WritePropertyName(publicRequestFilterKvp.Key);
                    var publicRequestFilterValue = publicRequestFilterKvp.Value;
                    context.Writer.WriteStringValue(publicRequestFilterValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetPageSize())
            {
                context.Writer.WritePropertyName("PageSize");
                context.Writer.WriteNumberValue(publicRequest.PageSize.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListRecommendationsRequestMarshaller _instance = new();

        internal static ListRecommendationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListRecommendationsRequestMarshaller Instance => _instance;
    }
}
