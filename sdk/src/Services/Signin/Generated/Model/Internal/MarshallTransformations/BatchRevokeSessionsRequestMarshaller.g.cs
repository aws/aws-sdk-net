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

using Amazon.Signin.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Signin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchRevokeSessions Request Marshaller
    /// </summary>
    public partial class BatchRevokeSessionsRequestMarshaller : IMarshaller<IRequest, BatchRevokeSessionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchRevokeSessionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchRevokeSessionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/batch-revoke-sessions";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetPrincipalArn())
            {
                context.Writer.WritePropertyName("principalArn");
                context.Writer.WriteStringValue(publicRequest.PrincipalArn);
            }
            if (publicRequest.IsSetReason())
            {
                context.Writer.WritePropertyName("reason");
                context.Writer.WriteStringValue(publicRequest.Reason);
            }
            if (publicRequest.IsSetSessionArns())
            {
                context.Writer.WritePropertyName("sessionArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSessionArnsListValue in publicRequest.SessionArns)
                {
                    context.Writer.WriteStringValue(publicRequestSessionArnsListValue);
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

        private static readonly BatchRevokeSessionsRequestMarshaller _instance = new();

        internal static BatchRevokeSessionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchRevokeSessionsRequestMarshaller Instance => _instance;
    }
}
