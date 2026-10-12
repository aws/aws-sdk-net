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
    /// AdminLinkProviderForUser Request Marshaller
    /// </summary>
    public partial class AdminLinkProviderForUserRequestMarshaller : IMarshaller<IRequest, AdminLinkProviderForUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AdminLinkProviderForUserRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AdminLinkProviderForUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.AdminLinkProviderForUser";
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
            if (publicRequest.IsSetDestinationUser())
            {
                context.Writer.WritePropertyName("DestinationUser");
                context.Writer.WriteStartObject();

                var marshaller = ProviderUserIdentifierTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationUser, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSourceUser())
            {
                context.Writer.WritePropertyName("SourceUser");
                context.Writer.WriteStartObject();

                var marshaller = ProviderUserIdentifierTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceUser, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetUserPoolId())
            {
                context.Writer.WritePropertyName("UserPoolId");
                context.Writer.WriteStringValue(publicRequest.UserPoolId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly AdminLinkProviderForUserRequestMarshaller _instance = new();

        internal static AdminLinkProviderForUserRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AdminLinkProviderForUserRequestMarshaller Instance => _instance;
    }
}
