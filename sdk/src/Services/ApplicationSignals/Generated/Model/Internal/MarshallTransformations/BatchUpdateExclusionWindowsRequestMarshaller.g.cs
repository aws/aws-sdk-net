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

using Amazon.ApplicationSignals.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateExclusionWindows Request Marshaller
    /// </summary>
    public partial class BatchUpdateExclusionWindowsRequestMarshaller : IMarshaller<IRequest, BatchUpdateExclusionWindowsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateExclusionWindowsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchUpdateExclusionWindowsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/exclusion-windows";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAddExclusionWindows())
            {
                context.Writer.WritePropertyName("AddExclusionWindows");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAddExclusionWindowsListValue in publicRequest.AddExclusionWindows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExclusionWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequestAddExclusionWindowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRemoveExclusionWindows())
            {
                context.Writer.WritePropertyName("RemoveExclusionWindows");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRemoveExclusionWindowsListValue in publicRequest.RemoveExclusionWindows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExclusionWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequestRemoveExclusionWindowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSloIds())
            {
                context.Writer.WritePropertyName("SloIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSloIdsListValue in publicRequest.SloIds)
                {
                    context.Writer.WriteStringValue(publicRequestSloIdsListValue);
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

        private static readonly BatchUpdateExclusionWindowsRequestMarshaller _instance = new();

        internal static BatchUpdateExclusionWindowsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchUpdateExclusionWindowsRequestMarshaller Instance => _instance;
    }
}
