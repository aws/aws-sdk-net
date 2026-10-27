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

using Amazon.QApps.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportDocument Request Marshaller
    /// </summary>
    public partial class ImportDocumentRequestMarshaller : IMarshaller<IRequest, ImportDocumentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportDocumentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportDocumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QApps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetInstanceId())
            {
                request.Headers["instance-id"] = publicRequest.InstanceId;
            }

            request.ResourcePath = "/apps.importDocument";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAppId())
            {
                context.Writer.WritePropertyName("appId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }
            if (publicRequest.IsSetCardId())
            {
                context.Writer.WritePropertyName("cardId");
                context.Writer.WriteStringValue(publicRequest.CardId);
            }
            if (publicRequest.IsSetFileContentsBase64())
            {
                context.Writer.WritePropertyName("fileContentsBase64");
                context.Writer.WriteStringValue(publicRequest.FileContentsBase64);
            }
            if (publicRequest.IsSetFileName())
            {
                context.Writer.WritePropertyName("fileName");
                context.Writer.WriteStringValue(publicRequest.FileName);
            }
            if (publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStringValue(publicRequest.Scope);
            }
            if (publicRequest.IsSetSessionId())
            {
                context.Writer.WritePropertyName("sessionId");
                context.Writer.WriteStringValue(publicRequest.SessionId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ImportDocumentRequestMarshaller _instance = new();

        internal static ImportDocumentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportDocumentRequestMarshaller Instance => _instance;
    }
}
