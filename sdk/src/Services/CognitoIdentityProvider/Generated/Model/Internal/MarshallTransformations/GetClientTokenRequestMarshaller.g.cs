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

using Amazon.CognitoIdentityProvider.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetClientToken Request Marshaller
    /// </summary>
    public partial class GetClientTokenRequestMarshaller : IMarshaller<IRequest, GetClientTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetClientTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetClientTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.GetClientToken";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-18";
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
            if (publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
            }
            if (publicRequest.IsSetClientMetadata())
            {
                context.Writer.WritePropertyName("ClientMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestClientMetadataKvp in publicRequest.ClientMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestClientMetadataKvp.Key);
                    var publicRequestClientMetadataValue = publicRequestClientMetadataKvp.Value;
                    context.Writer.WriteStringValue(publicRequestClientMetadataValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetScopes())
            {
                context.Writer.WritePropertyName("Scopes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestScopesListValue in publicRequest.Scopes)
                {
                    context.Writer.WriteStringValue(publicRequestScopesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSecret())
            {
                context.Writer.WritePropertyName("Secret");
                context.Writer.WriteStringValue(publicRequest.Secret);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetClientTokenRequestMarshaller _instance = new();

        internal static GetClientTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetClientTokenRequestMarshaller Instance => _instance;
    }
}
