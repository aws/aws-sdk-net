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

using Amazon.Kendra.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateQuerySuggestionsConfig Request Marshaller
    /// </summary>
    public partial class UpdateQuerySuggestionsConfigRequestMarshaller : IMarshaller<IRequest, UpdateQuerySuggestionsConfigRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQuerySuggestionsConfigRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateQuerySuggestionsConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.UpdateQuerySuggestionsConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";
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
            if (publicRequest.IsSetAttributeSuggestionsConfig())
            {
                context.Writer.WritePropertyName("AttributeSuggestionsConfig");
                context.Writer.WriteStartObject();

                var marshaller = AttributeSuggestionsUpdateConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AttributeSuggestionsConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIncludeQueriesWithoutUserInformation())
            {
                context.Writer.WritePropertyName("IncludeQueriesWithoutUserInformation");
                context.Writer.WriteBooleanValue(publicRequest.IncludeQueriesWithoutUserInformation.Value);
            }
            if (publicRequest.IsSetIndexId())
            {
                context.Writer.WritePropertyName("IndexId");
                context.Writer.WriteStringValue(publicRequest.IndexId);
            }
            if (publicRequest.IsSetMinimumNumberOfQueryingUsers())
            {
                context.Writer.WritePropertyName("MinimumNumberOfQueryingUsers");
                context.Writer.WriteNumberValue(publicRequest.MinimumNumberOfQueryingUsers.Value);
            }
            if (publicRequest.IsSetMinimumQueryCount())
            {
                context.Writer.WritePropertyName("MinimumQueryCount");
                context.Writer.WriteNumberValue(publicRequest.MinimumQueryCount.Value);
            }
            if (publicRequest.IsSetMode())
            {
                context.Writer.WritePropertyName("Mode");
                context.Writer.WriteStringValue(publicRequest.Mode);
            }
            if (publicRequest.IsSetQueryLogLookBackWindowInDays())
            {
                context.Writer.WritePropertyName("QueryLogLookBackWindowInDays");
                context.Writer.WriteNumberValue(publicRequest.QueryLogLookBackWindowInDays.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateQuerySuggestionsConfigRequestMarshaller _instance = new();

        internal static UpdateQuerySuggestionsConfigRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateQuerySuggestionsConfigRequestMarshaller Instance => _instance;
    }
}
