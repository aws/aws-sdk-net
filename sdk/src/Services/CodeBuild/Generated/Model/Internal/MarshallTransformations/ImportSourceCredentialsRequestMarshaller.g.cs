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

using Amazon.CodeBuild.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportSourceCredentials Request Marshaller
    /// </summary>
    public partial class ImportSourceCredentialsRequestMarshaller : IMarshaller<IRequest, ImportSourceCredentialsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportSourceCredentialsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportSourceCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.ImportSourceCredentials";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
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
            if (publicRequest.IsSetAuthType())
            {
                context.Writer.WritePropertyName("authType");
                context.Writer.WriteStringValue(publicRequest.AuthType);
            }
            if (publicRequest.IsSetServerType())
            {
                context.Writer.WritePropertyName("serverType");
                context.Writer.WriteStringValue(publicRequest.ServerType);
            }
            if (publicRequest.IsSetShouldOverwrite())
            {
                context.Writer.WritePropertyName("shouldOverwrite");
                context.Writer.WriteBooleanValue(publicRequest.ShouldOverwrite.Value);
            }
            if (publicRequest.IsSetToken())
            {
                context.Writer.WritePropertyName("token");
                context.Writer.WriteStringValue(publicRequest.Token);
            }
            if (publicRequest.IsSetUsername())
            {
                context.Writer.WritePropertyName("username");
                context.Writer.WriteStringValue(publicRequest.Username);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ImportSourceCredentialsRequestMarshaller _instance = new();

        internal static ImportSourceCredentialsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportSourceCredentialsRequestMarshaller Instance => _instance;
    }
}
