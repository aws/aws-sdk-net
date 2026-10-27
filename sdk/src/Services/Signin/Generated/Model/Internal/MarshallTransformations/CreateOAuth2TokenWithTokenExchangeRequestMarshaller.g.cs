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
    /// CreateOAuth2TokenWithTokenExchange Request Marshaller
    /// </summary>
    public partial class CreateOAuth2TokenWithTokenExchangeRequestMarshaller : IMarshaller<IRequest, CreateOAuth2TokenWithTokenExchangeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOAuth2TokenWithTokenExchangeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateOAuth2TokenWithTokenExchangeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-01";
            request.HttpMethod = "POST";

            request.AddSubResource("x-amz-oauth-token-method", "token-exchange");
            request.ResourcePath = "/v1/token";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetGrantType())
            {
                context.Writer.WritePropertyName("grant_type");
                context.Writer.WriteStringValue(publicRequest.GrantType);
            }
            if (publicRequest.IsSetResource())
            {
                context.Writer.WritePropertyName("resource");
                context.Writer.WriteStringValue(publicRequest.Resource);
            }
            if (publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStringValue(publicRequest.Scope);
            }
            if (publicRequest.IsSetSubjectToken())
            {
                context.Writer.WritePropertyName("subject_token");
                context.Writer.WriteStringValue(publicRequest.SubjectToken);
            }
            if (publicRequest.IsSetSubjectTokenType())
            {
                context.Writer.WritePropertyName("subject_token_type");
                context.Writer.WriteStringValue(publicRequest.SubjectTokenType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateOAuth2TokenWithTokenExchangeRequestMarshaller _instance = new();

        internal static CreateOAuth2TokenWithTokenExchangeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateOAuth2TokenWithTokenExchangeRequestMarshaller Instance => _instance;
    }
}
