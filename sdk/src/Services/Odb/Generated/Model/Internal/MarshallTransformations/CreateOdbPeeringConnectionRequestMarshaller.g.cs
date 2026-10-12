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

using Amazon.Odb.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOdbPeeringConnection Request Marshaller
    /// </summary>
    public partial class CreateOdbPeeringConnectionRequestMarshaller : IMarshaller<IRequest, CreateOdbPeeringConnectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOdbPeeringConnectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateOdbPeeringConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateOdbPeeringConnection";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
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
            if (publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }
            if (publicRequest.IsSetOdbNetworkId())
            {
                context.Writer.WritePropertyName("odbNetworkId");
                context.Writer.WriteStringValue(publicRequest.OdbNetworkId);
            }
            if (publicRequest.IsSetPeerNetworkCidrsToBeAdded())
            {
                context.Writer.WritePropertyName("peerNetworkCidrsToBeAdded");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPeerNetworkCidrsToBeAddedListValue in publicRequest.PeerNetworkCidrsToBeAdded)
                {
                    context.Writer.WriteStringValue(publicRequestPeerNetworkCidrsToBeAddedListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetPeerNetworkId())
            {
                context.Writer.WritePropertyName("peerNetworkId");
                context.Writer.WriteStringValue(publicRequest.PeerNetworkId);
            }
            if (publicRequest.IsSetPeerNetworkRouteTableIds())
            {
                context.Writer.WritePropertyName("peerNetworkRouteTableIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPeerNetworkRouteTableIdsListValue in publicRequest.PeerNetworkRouteTableIds)
                {
                    context.Writer.WriteStringValue(publicRequestPeerNetworkRouteTableIdsListValue);
                }
                context.Writer.WriteEndArray();
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

        private static readonly CreateOdbPeeringConnectionRequestMarshaller _instance = new();

        internal static CreateOdbPeeringConnectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateOdbPeeringConnectionRequestMarshaller Instance => _instance;
    }
}
