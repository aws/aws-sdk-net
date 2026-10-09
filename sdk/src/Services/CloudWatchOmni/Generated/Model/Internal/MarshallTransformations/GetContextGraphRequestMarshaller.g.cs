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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetContextGraph Request Marshaller
    /// </summary>
    public partial class GetContextGraphRequestMarshaller : IMarshaller<IRequest, GetContextGraphRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetContextGraphRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetContextGraphRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchOmni");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CloudWatchOmniFrontend/operation/GetContextGraph";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDepth())
                {
                    context.Writer.WriteTextString("depth");
                    context.Writer.WriteInt32(publicRequest.Depth.Value);
                }
                if (publicRequest.IsSetEdgeFilters())
                {
                    context.Writer.WriteTextString("edgeFilters");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EdgeFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EdgeFilters, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEndTime())
                {
                    context.Writer.WriteTextString("endTime");
                    context.Writer.WriteDateTime(publicRequest.EndTime.Value);
                }
                if (publicRequest.IsSetIncludeMetadata())
                {
                    context.Writer.WriteTextString("includeMetadata");
                    context.Writer.WriteBoolean(publicRequest.IncludeMetadata.Value);
                }
                if (publicRequest.IsSetMaxEdgesPerNode())
                {
                    context.Writer.WriteTextString("maxEdgesPerNode");
                    context.Writer.WriteInt32(publicRequest.MaxEdgesPerNode.Value);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("maxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("nextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetNodeFilters())
                {
                    context.Writer.WriteTextString("nodeFilters");
                    context.Writer.WriteStartMap(null);

                    var marshaller = NodeFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NodeFilters, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStartTime())
                {
                    context.Writer.WriteTextString("startTime");
                    context.Writer.WriteDateTime(publicRequest.StartTime.Value);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly GetContextGraphRequestMarshaller _instance = new();

        internal static GetContextGraphRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetContextGraphRequestMarshaller Instance => _instance;
    }
}
