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

using Amazon.SecurityHub.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAggregatorV2 Request Marshaller
    /// </summary>
    public partial class UpdateAggregatorV2RequestMarshaller : IMarshaller<IRequest, UpdateAggregatorV2Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAggregatorV2Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAggregatorV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetAggregatorV2Arn())
            {
                throw new AmazonSecurityHubException("Request object does not have required field AggregatorV2Arn set");
            }
            request.AddPathResource("{AggregatorV2Arn+}", StringUtils.FromString(publicRequest.AggregatorV2Arn.TrimStart('/')));

            request.ResourcePath = "/aggregatorv2/update/{AggregatorV2Arn+}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetLinkedRegions())
            {
                context.Writer.WritePropertyName("LinkedRegions");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLinkedRegionsListValue in publicRequest.LinkedRegions)
                {
                    context.Writer.WriteStringValue(publicRequestLinkedRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRegionLinkingMode())
            {
                context.Writer.WritePropertyName("RegionLinkingMode");
                context.Writer.WriteStringValue(publicRequest.RegionLinkingMode);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateAggregatorV2RequestMarshaller _instance = new();

        internal static UpdateAggregatorV2RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAggregatorV2RequestMarshaller Instance => _instance;
    }
}
