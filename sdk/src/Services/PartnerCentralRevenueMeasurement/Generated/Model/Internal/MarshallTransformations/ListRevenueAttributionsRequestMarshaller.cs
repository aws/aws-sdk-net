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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRevenueAttributions Request Marshaller
    /// </summary>       
    public class ListRevenueAttributionsRequestMarshaller : IMarshaller<IRequest, ListRevenueAttributionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRevenueAttributionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRevenueAttributionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralRevenueMeasurement");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PartnerCentralRevenueMeasurement/operation/ListRevenueAttributions";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

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
                if (publicRequest.IsSetCreatedAfter())
                {
                    context.Writer.WriteTextString("CreatedAfter");
                    context.Writer.WriteDateTime(publicRequest.CreatedAfter.Value);
                }
                if (publicRequest.IsSetCreatedBefore())
                {
                    context.Writer.WriteTextString("CreatedBefore");
                    context.Writer.WriteDateTime(publicRequest.CreatedBefore.Value);
                }
                if (publicRequest.IsSetIdentifiers())
                {
                    context.Writer.WriteTextString("Identifiers");
                    context.Writer.WriteStartArray(publicRequest.Identifiers.Count);
                    foreach(var publicRequestIdentifiersListValue in publicRequest.Identifiers)
                    {
                            context.Writer.WriteTextString(publicRequestIdentifiersListValue);
                    }
                    context.Writer.WriteEndArray();
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
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
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
        private static ListRevenueAttributionsRequestMarshaller _instance = new ListRevenueAttributionsRequestMarshaller();        

        internal static ListRevenueAttributionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRevenueAttributionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}