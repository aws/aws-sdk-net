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

using Amazon.Repostspace.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Repostspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchRemoveRole Request Marshaller
    /// </summary>
    public partial class BatchRemoveRoleRequestMarshaller : IMarshaller<IRequest, BatchRemoveRoleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchRemoveRoleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchRemoveRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Repostspace");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-05-13";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetSpaceId())
            {
                throw new AmazonRepostspaceException("Request object does not have required field SpaceId set");
            }
            request.AddPathResource("{spaceId}", StringUtils.FromString(publicRequest.SpaceId));

            request.ResourcePath = "/spaces/{spaceId}/roles";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAccessorIds())
            {
                context.Writer.WritePropertyName("accessorIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAccessorIdsListValue in publicRequest.AccessorIds)
                {
                    context.Writer.WriteStringValue(publicRequestAccessorIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly BatchRemoveRoleRequestMarshaller _instance = new();

        internal static BatchRemoveRoleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchRemoveRoleRequestMarshaller Instance => _instance;
    }
}
