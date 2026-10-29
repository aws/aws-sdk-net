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

using Amazon.CloudWatchLogs.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartLiveTail Request Marshaller
    /// </summary>
    public partial class StartLiveTailRequestMarshaller : IMarshaller<IRequest, StartLiveTailRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartLiveTailRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartLiveTailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.StartLiveTail";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
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
            if (publicRequest.IsSetLogEventFilterPattern())
            {
                context.Writer.WritePropertyName("logEventFilterPattern");
                context.Writer.WriteStringValue(publicRequest.LogEventFilterPattern);
            }
            if (publicRequest.IsSetLogGroupIdentifiers())
            {
                context.Writer.WritePropertyName("logGroupIdentifiers");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLogGroupIdentifiersListValue in publicRequest.LogGroupIdentifiers)
                {
                    context.Writer.WriteStringValue(publicRequestLogGroupIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLogStreamNamePrefixes())
            {
                context.Writer.WritePropertyName("logStreamNamePrefixes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLogStreamNamePrefixesListValue in publicRequest.LogStreamNamePrefixes)
                {
                    context.Writer.WriteStringValue(publicRequestLogStreamNamePrefixesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLogStreamNames())
            {
                context.Writer.WritePropertyName("logStreamNames");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLogStreamNamesListValue in publicRequest.LogStreamNames)
                {
                    context.Writer.WriteStringValue(publicRequestLogStreamNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"stream-";

            return request;
        }

        private static readonly StartLiveTailRequestMarshaller _instance = new();

        internal static StartLiveTailRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartLiveTailRequestMarshaller Instance => _instance;
    }
}
