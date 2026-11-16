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
    /// GetDerivedToken Request Marshaller
    /// </summary>
    public partial class GetDerivedTokenRequestMarshaller : IMarshaller<IRequest, GetDerivedTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDerivedTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDerivedTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.GetDerivedToken";
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
            if (publicRequest.IsSetActorToken())
            {
                context.Writer.WritePropertyName("ActorToken");
                context.Writer.WriteStringValue(publicRequest.ActorToken);
            }
            if (publicRequest.IsSetActorTokenProviderName())
            {
                context.Writer.WritePropertyName("ActorTokenProviderName");
                context.Writer.WriteStringValue(publicRequest.ActorTokenProviderName);
            }
            if (publicRequest.IsSetActorTokenType())
            {
                context.Writer.WritePropertyName("ActorTokenType");
                context.Writer.WriteStringValue(publicRequest.ActorTokenType);
            }
            if (publicRequest.IsSetAudiences())
            {
                context.Writer.WritePropertyName("Audiences");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAudiencesListValue in publicRequest.Audiences)
                {
                    context.Writer.WriteStringValue(publicRequestAudiencesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
            }
            if (publicRequest.IsSetClientSecret())
            {
                context.Writer.WritePropertyName("ClientSecret");
                context.Writer.WriteStringValue(publicRequest.ClientSecret);
            }
            if (publicRequest.IsSetRequestedTokenType())
            {
                context.Writer.WritePropertyName("RequestedTokenType");
                context.Writer.WriteStringValue(publicRequest.RequestedTokenType);
            }
            if (publicRequest.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartArray();
                foreach (var publicRequestResourcesListValue in publicRequest.Resources)
                {
                    context.Writer.WriteStringValue(publicRequestResourcesListValue);
                }
                context.Writer.WriteEndArray();
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
            if (publicRequest.IsSetSubjectToken())
            {
                context.Writer.WritePropertyName("SubjectToken");
                context.Writer.WriteStringValue(publicRequest.SubjectToken);
            }
            if (publicRequest.IsSetSubjectTokenProviderName())
            {
                context.Writer.WritePropertyName("SubjectTokenProviderName");
                context.Writer.WriteStringValue(publicRequest.SubjectTokenProviderName);
            }
            if (publicRequest.IsSetSubjectTokenType())
            {
                context.Writer.WritePropertyName("SubjectTokenType");
                context.Writer.WriteStringValue(publicRequest.SubjectTokenType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetDerivedTokenRequestMarshaller _instance = new();

        internal static GetDerivedTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDerivedTokenRequestMarshaller Instance => _instance;
    }
}
