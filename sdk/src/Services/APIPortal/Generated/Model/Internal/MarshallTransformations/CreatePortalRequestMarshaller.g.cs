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

using Amazon.APIPortal.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.APIPortal.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePortal Request Marshaller
    /// </summary>
    public partial class CreatePortalRequestMarshaller : IMarshaller<IRequest, CreatePortalRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePortalRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreatePortalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIPortal");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/portals";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAuthorization())
            {
                context.Writer.WritePropertyName("authorization");
                context.Writer.WriteStartObject();

                var marshaller = AuthorizationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Authorization, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEndpointConfiguration())
            {
                context.Writer.WritePropertyName("endpointConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EndpointConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndpointConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIncludedProductArns())
            {
                context.Writer.WritePropertyName("includedProductArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestIncludedProductArnsListValue in publicRequest.IncludedProductArns)
                {
                    context.Writer.WriteStringValue(publicRequestIncludedProductArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLogoUri())
            {
                context.Writer.WritePropertyName("logoUri");
                context.Writer.WriteStringValue(publicRequest.LogoUri);
            }
            if (publicRequest.IsSetPortalContent())
            {
                context.Writer.WritePropertyName("portalContent");
                context.Writer.WriteStartObject();

                var marshaller = PortalContentMarshaller.Instance;
                marshaller.Marshall(publicRequest.PortalContent, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRumAppMonitorName())
            {
                context.Writer.WritePropertyName("rumAppMonitorName");
                context.Writer.WriteStringValue(publicRequest.RumAppMonitorName);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreatePortalRequestMarshaller _instance = new();

        internal static CreatePortalRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreatePortalRequestMarshaller Instance => _instance;
    }
}
