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
    /// ListMarketplaceRevenueShareAllocations Request Marshaller
    /// </summary>
    public partial class ListMarketplaceRevenueShareAllocationsRequestMarshaller : IMarshaller<IRequest, ListMarketplaceRevenueShareAllocationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListMarketplaceRevenueShareAllocationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListMarketplaceRevenueShareAllocationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralRevenueMeasurement");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PartnerCentralRevenueMeasurement/operation/ListMarketplaceRevenueShareAllocations";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAfterEffectiveFrom())
                {
                    context.Writer.WriteTextString("AfterEffectiveFrom");
                    context.Writer.WriteTextString(publicRequest.AfterEffectiveFrom);
                }
                if (publicRequest.IsSetBeforeEffectiveFrom())
                {
                    context.Writer.WriteTextString("BeforeEffectiveFrom");
                    context.Writer.WriteTextString(publicRequest.BeforeEffectiveFrom);
                }
                if (publicRequest.IsSetCatalog())
                {
                    context.Writer.WriteTextString("Catalog");
                    context.Writer.WriteTextString(publicRequest.Catalog);
                }
                if (publicRequest.IsSetMarketplaceRevenueShareRevision())
                {
                    context.Writer.WriteTextString("MarketplaceRevenueShareRevision");
                    context.Writer.WriteTextString(publicRequest.MarketplaceRevenueShareRevision);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetProductId())
                {
                    context.Writer.WriteTextString("ProductId");
                    context.Writer.WriteTextString(publicRequest.ProductId);
                }
                if (publicRequest.IsSetSortBy())
                {
                    context.Writer.WriteTextString("SortBy");
                    context.Writer.WriteTextString(publicRequest.SortBy);
                }
                if (publicRequest.IsSetSortOrder())
                {
                    context.Writer.WriteTextString("SortOrder");
                    context.Writer.WriteTextString(publicRequest.SortOrder);
                }
                if (publicRequest.IsSetStatus())
                {
                    context.Writer.WriteTextString("Status");
                    context.Writer.WriteTextString(publicRequest.Status);
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

        private static readonly ListMarketplaceRevenueShareAllocationsRequestMarshaller _instance = new();

        internal static ListMarketplaceRevenueShareAllocationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListMarketplaceRevenueShareAllocationsRequestMarshaller Instance => _instance;
    }
}
