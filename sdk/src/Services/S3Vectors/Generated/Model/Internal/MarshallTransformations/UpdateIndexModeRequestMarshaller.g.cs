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

using Amazon.S3Vectors.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Vectors.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIndexMode Request Marshaller
    /// </summary>
    public partial class UpdateIndexModeRequestMarshaller : IMarshaller<IRequest, UpdateIndexModeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIndexModeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateIndexModeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Vectors");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateIndexMode";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetIndexArn())
            {
                context.Writer.WritePropertyName("indexArn");
                context.Writer.WriteStringValue(publicRequest.IndexArn);
            }
            if (publicRequest.IsSetIndexMode())
            {
                context.Writer.WritePropertyName("indexMode");
                context.Writer.WriteStringValue(publicRequest.IndexMode);
            }
            if (publicRequest.IsSetIndexName())
            {
                context.Writer.WritePropertyName("indexName");
                context.Writer.WriteStringValue(publicRequest.IndexName);
            }
            if (publicRequest.IsSetVectorBucketName())
            {
                context.Writer.WritePropertyName("vectorBucketName");
                context.Writer.WriteStringValue(publicRequest.VectorBucketName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateIndexModeRequestMarshaller _instance = new();

        internal static UpdateIndexModeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateIndexModeRequestMarshaller Instance => _instance;
    }
}
