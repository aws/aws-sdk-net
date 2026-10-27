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

using Amazon.WorkDocs.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDocument Request Marshaller
    /// </summary>
    public partial class UpdateDocumentRequestMarshaller : IMarshaller<IRequest, UpdateDocumentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDocumentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDocumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "PATCH";

            if (publicRequest.IsSetAuthenticationToken())
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            if (!publicRequest.IsSetDocumentId())
            {
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            }
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));

            request.ResourcePath = "/api/v1/documents/{DocumentId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetParentFolderId())
            {
                context.Writer.WritePropertyName("ParentFolderId");
                context.Writer.WriteStringValue(publicRequest.ParentFolderId);
            }
            if (publicRequest.IsSetResourceState())
            {
                context.Writer.WritePropertyName("ResourceState");
                context.Writer.WriteStringValue(publicRequest.ResourceState);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateDocumentRequestMarshaller _instance = new();

        internal static UpdateDocumentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDocumentRequestMarshaller Instance => _instance;
    }
}
