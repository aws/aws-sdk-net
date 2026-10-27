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

using Amazon.MemoryDB.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeReservedNodes Request Marshaller
    /// </summary>
    public partial class DescribeReservedNodesRequestMarshaller : IMarshaller<IRequest, DescribeReservedNodesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeReservedNodesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeReservedNodesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.DescribeReservedNodes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
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
            if (publicRequest.IsSetDuration())
            {
                context.Writer.WritePropertyName("Duration");
                context.Writer.WriteStringValue(publicRequest.Duration);
            }
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.WriteStringValue(publicRequest.NodeType);
            }
            if (publicRequest.IsSetOfferingType())
            {
                context.Writer.WritePropertyName("OfferingType");
                context.Writer.WriteStringValue(publicRequest.OfferingType);
            }
            if (publicRequest.IsSetReservationId())
            {
                context.Writer.WritePropertyName("ReservationId");
                context.Writer.WriteStringValue(publicRequest.ReservationId);
            }
            if (publicRequest.IsSetReservedNodesOfferingId())
            {
                context.Writer.WritePropertyName("ReservedNodesOfferingId");
                context.Writer.WriteStringValue(publicRequest.ReservedNodesOfferingId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly DescribeReservedNodesRequestMarshaller _instance = new();

        internal static DescribeReservedNodesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeReservedNodesRequestMarshaller Instance => _instance;
    }
}
