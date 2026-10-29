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

using Amazon.AppMesh.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGatewayRoute Request Marshaller
    /// </summary>
    public partial class CreateGatewayRouteRequestMarshaller : IMarshaller<IRequest, CreateGatewayRouteRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGatewayRouteRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateGatewayRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-25";
            request.HttpMethod = "PUT";

            if (publicRequest.IsSetMeshOwner())
            {
                request.Parameters.Add("meshOwner", StringUtils.FromString(publicRequest.MeshOwner));
            }

            if (!publicRequest.IsSetMeshName())
            {
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            }
            request.AddPathResource("{meshName}", StringUtils.FromString(publicRequest.MeshName));

            if (!publicRequest.IsSetVirtualGatewayName())
            {
                throw new AmazonAppMeshException("Request object does not have required field VirtualGatewayName set");
            }
            request.AddPathResource("{virtualGatewayName}", StringUtils.FromString(publicRequest.VirtualGatewayName));

            request.ResourcePath = "/v20190125/meshes/{meshName}/virtualGateway/{virtualGatewayName}/gatewayRoutes";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetGatewayRouteName())
            {
                context.Writer.WritePropertyName("gatewayRouteName");
                context.Writer.WriteStringValue(publicRequest.GatewayRouteName);
            }
            if (publicRequest.IsSetSpec())
            {
                context.Writer.WritePropertyName("spec");
                context.Writer.WriteStartObject();

                var marshaller = GatewayRouteSpecMarshaller.Instance;
                marshaller.Marshall(publicRequest.Spec, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagRefMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly CreateGatewayRouteRequestMarshaller _instance = new();

        internal static CreateGatewayRouteRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateGatewayRouteRequestMarshaller Instance => _instance;
    }
}
