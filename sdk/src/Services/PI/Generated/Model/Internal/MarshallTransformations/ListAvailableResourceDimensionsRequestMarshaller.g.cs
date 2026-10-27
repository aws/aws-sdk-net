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

using Amazon.PI.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAvailableResourceDimensions Request Marshaller
    /// </summary>
    public partial class ListAvailableResourceDimensionsRequestMarshaller : IMarshaller<IRequest, ListAvailableResourceDimensionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAvailableResourceDimensionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAvailableResourceDimensionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PI");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-02-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PerformanceInsightsv20180227/operation/ListAvailableResourceDimensions";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAuthorizedActions())
                {
                    context.Writer.WriteTextString("AuthorizedActions");
                    context.Writer.WriteStartArray(publicRequest.AuthorizedActions.Count);
                    foreach (var publicRequestAuthorizedActionsListValue in publicRequest.AuthorizedActions)
                    {
                        context.Writer.WriteTextString(publicRequestAuthorizedActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIdentifier())
                {
                    context.Writer.WriteTextString("Identifier");
                    context.Writer.WriteTextString(publicRequest.Identifier);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetMetrics())
                {
                    context.Writer.WriteTextString("Metrics");
                    context.Writer.WriteStartArray(publicRequest.Metrics.Count);
                    foreach (var publicRequestMetricsListValue in publicRequest.Metrics)
                    {
                        context.Writer.WriteTextString(publicRequestMetricsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetServiceType())
                {
                    context.Writer.WriteTextString("ServiceType");
                    context.Writer.WriteTextString(publicRequest.ServiceType);
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

        private static readonly ListAvailableResourceDimensionsRequestMarshaller _instance = new();

        internal static ListAvailableResourceDimensionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAvailableResourceDimensionsRequestMarshaller Instance => _instance;
    }
}
