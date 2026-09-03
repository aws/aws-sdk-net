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

using Amazon.MediaConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBridgeSource Request Marshaller
    /// </summary>
    public partial class UpdateBridgeSourceRequestMarshaller : IMarshaller<IRequest, UpdateBridgeSourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBridgeSourceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateBridgeSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBridgeArn())
            {
                throw new AmazonMediaConnectException("Request object does not have required field BridgeArn set");
            }
            request.AddPathResource("{BridgeArn}", StringUtils.FromString(publicRequest.BridgeArn));

            if (!publicRequest.IsSetSourceName())
            {
                throw new AmazonMediaConnectException("Request object does not have required field SourceName set");
            }
            request.AddPathResource("{SourceName}", StringUtils.FromString(publicRequest.SourceName));

            request.ResourcePath = "/v1/bridges/{BridgeArn}/sources/{SourceName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFlowSource())
            {
                context.Writer.WritePropertyName("flowSource");
                context.Writer.WriteStartObject();

                var marshaller = UpdateBridgeFlowSourceRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.FlowSource, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetNetworkSource())
            {
                context.Writer.WritePropertyName("networkSource");
                context.Writer.WriteStartObject();

                var marshaller = UpdateBridgeNetworkSourceRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkSource, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateBridgeSourceRequestMarshaller _instance = new();

        internal static UpdateBridgeSourceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateBridgeSourceRequestMarshaller Instance => _instance;
    }
}
