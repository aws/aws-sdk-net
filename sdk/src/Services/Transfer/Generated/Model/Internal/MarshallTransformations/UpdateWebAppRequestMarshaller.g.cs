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

using Amazon.Transfer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWebApp Request Marshaller
    /// </summary>
    public partial class UpdateWebAppRequestMarshaller : IMarshaller<IRequest, UpdateWebAppRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWebAppRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateWebAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateWebApp";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
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
            if (publicRequest.IsSetAccessEndpoint())
            {
                context.Writer.WritePropertyName("AccessEndpoint");
                context.Writer.WriteStringValue(publicRequest.AccessEndpoint);
            }
            if (publicRequest.IsSetEndpointDetails())
            {
                context.Writer.WritePropertyName("EndpointDetails");
                context.Writer.WriteStartObject();

                var marshaller = UpdateWebAppEndpointDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndpointDetails, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIdentityProviderDetails())
            {
                context.Writer.WritePropertyName("IdentityProviderDetails");
                context.Writer.WriteStartObject();

                var marshaller = UpdateWebAppIdentityProviderDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityProviderDetails, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetWebAppId())
            {
                context.Writer.WritePropertyName("WebAppId");
                context.Writer.WriteStringValue(publicRequest.WebAppId);
            }
            if (publicRequest.IsSetWebAppUnits())
            {
                context.Writer.WritePropertyName("WebAppUnits");
                context.Writer.WriteStartObject();

                var marshaller = WebAppUnitsMarshaller.Instance;
                marshaller.Marshall(publicRequest.WebAppUnits, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateWebAppRequestMarshaller _instance = new();

        internal static UpdateWebAppRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateWebAppRequestMarshaller Instance => _instance;
    }
}
