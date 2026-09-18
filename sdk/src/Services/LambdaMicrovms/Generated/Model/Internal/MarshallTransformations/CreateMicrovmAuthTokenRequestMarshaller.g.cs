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

using Amazon.LambdaMicrovms.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMicrovmAuthToken Request Marshaller
    /// </summary>
    public partial class CreateMicrovmAuthTokenRequestMarshaller : IMarshaller<IRequest, CreateMicrovmAuthTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMicrovmAuthTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateMicrovmAuthTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LambdaMicrovms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-09";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMicrovmIdentifier())
            {
                throw new AmazonLambdaMicrovmsException("Request object does not have required field MicrovmIdentifier set");
            }
            request.AddPathResource("{microvmIdentifier}", StringUtils.FromString(publicRequest.MicrovmIdentifier));

            request.ResourcePath = "/2025-09-09/microvms/{microvmIdentifier}/auth-token";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllowedPorts())
            {
                context.Writer.WritePropertyName("allowedPorts");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllowedPortsListValue in publicRequest.AllowedPorts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PortSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestAllowedPortsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetExpirationInMinutes())
            {
                context.Writer.WritePropertyName("expirationInMinutes");
                context.Writer.WriteNumberValue(publicRequest.ExpirationInMinutes.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateMicrovmAuthTokenRequestMarshaller _instance = new();

        internal static CreateMicrovmAuthTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateMicrovmAuthTokenRequestMarshaller Instance => _instance;
    }
}
