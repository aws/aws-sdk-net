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

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartRevenueAttributionAllocationsTask Request Marshaller
    /// </summary>
    public partial class StartRevenueAttributionAllocationsTaskRequestMarshaller : IMarshaller<IRequest, StartRevenueAttributionAllocationsTaskRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartRevenueAttributionAllocationsTaskRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartRevenueAttributionAllocationsTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralRevenueMeasurement");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PartnerCentralRevenueMeasurement/operation/StartRevenueAttributionAllocationsTask";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCatalog())
                {
                    context.Writer.WriteTextString("Catalog");
                    context.Writer.WriteTextString(publicRequest.Catalog);
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetRevenueAttributionIdentifier())
                {
                    context.Writer.WriteTextString("RevenueAttributionIdentifier");
                    context.Writer.WriteTextString(publicRequest.RevenueAttributionIdentifier);
                }
                if (publicRequest.IsSetRevenueAttributionRevision())
                {
                    context.Writer.WriteTextString("RevenueAttributionRevision");
                    context.Writer.WriteTextString(publicRequest.RevenueAttributionRevision);
                }
                if (publicRequest.IsSetRevenueShareAllocations())
                {
                    context.Writer.WriteTextString("RevenueShareAllocations");
                    context.Writer.WriteStartArray(publicRequest.RevenueShareAllocations.Count);
                    foreach (var publicRequestRevenueShareAllocationsListValue in publicRequest.RevenueShareAllocations)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = RevenueShareAllocationMarshaller.Instance;
                        marshaller.Marshall(publicRequestRevenueShareAllocationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly StartRevenueAttributionAllocationsTaskRequestMarshaller _instance = new();

        internal static StartRevenueAttributionAllocationsTaskRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartRevenueAttributionAllocationsTaskRequestMarshaller Instance => _instance;
    }
}
