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

using Amazon.Wickr.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchResetDevicesForUser Request Marshaller
    /// </summary>
    public partial class BatchResetDevicesForUserRequestMarshaller : IMarshaller<IRequest, BatchResetDevicesForUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchResetDevicesForUserRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchResetDevicesForUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Wickr");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-01";
            request.HttpMethod = "PATCH";

            if (publicRequest.IsSetClientToken())
            {
                request.Headers["X-Client-Token"] = publicRequest.ClientToken;
            }

            if (!publicRequest.IsSetNetworkId())
            {
                throw new AmazonWickrException("Request object does not have required field NetworkId set");
            }
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));

            if (!publicRequest.IsSetUserId())
            {
                throw new AmazonWickrException("Request object does not have required field UserId set");
            }
            request.AddPathResource("{userId}", StringUtils.FromString(publicRequest.UserId));

            request.ResourcePath = "/networks/{networkId}/users/{userId}/devices";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAppIds())
            {
                context.Writer.WritePropertyName("appIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAppIdsListValue in publicRequest.AppIds)
                {
                    context.Writer.WriteStringValue(publicRequestAppIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly BatchResetDevicesForUserRequestMarshaller _instance = new();

        internal static BatchResetDevicesForUserRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchResetDevicesForUserRequestMarshaller Instance => _instance;
    }
}
