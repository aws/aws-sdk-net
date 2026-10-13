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
    /// BatchDeleteFeaturedResultsSet Request Marshaller
    /// </summary>
    public partial class BatchDeleteFeaturedResultsSetRequestMarshaller : IMarshaller<IRequest, BatchDeleteFeaturedResultsSetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDeleteFeaturedResultsSetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchDeleteFeaturedResultsSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.BatchDeleteFeaturedResultsSet";
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
            if (publicRequest.IsSetFeaturedResultsSetIds())
            {
                context.Writer.WritePropertyName("FeaturedResultsSetIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestFeaturedResultsSetIdsListValue in publicRequest.FeaturedResultsSetIds)
                {
                    context.Writer.WriteStringValue(publicRequestFeaturedResultsSetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetIndexId())
            {
                context.Writer.WritePropertyName("IndexId");
                context.Writer.WriteStringValue(publicRequest.IndexId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly BatchDeleteFeaturedResultsSetRequestMarshaller _instance = new();

        internal static BatchDeleteFeaturedResultsSetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchDeleteFeaturedResultsSetRequestMarshaller Instance => _instance;
    }
}
