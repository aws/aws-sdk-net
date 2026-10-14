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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAgreementInvoiceLineItems Request Marshaller
    /// </summary>       
    public class ListAgreementInvoiceLineItemsRequestMarshaller : IMarshaller<IRequest, ListAgreementInvoiceLineItemsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAgreementInvoiceLineItemsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAgreementInvoiceLineItemsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceAgreement");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSMPCommerceService_v20200301/operation/ListAgreementInvoiceLineItems";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAfterIssuedTime())
                {
                    context.Writer.WriteTextString("afterIssuedTime");
                    context.Writer.WriteDateTime(publicRequest.AfterIssuedTime.Value);
                }
                if (publicRequest.IsSetAgreementId())
                {
                    context.Writer.WriteTextString("agreementId");
                    context.Writer.WriteTextString(publicRequest.AgreementId);
                }
                if (publicRequest.IsSetBeforeIssuedTime())
                {
                    context.Writer.WriteTextString("beforeIssuedTime");
                    context.Writer.WriteDateTime(publicRequest.BeforeIssuedTime.Value);
                }
                if (publicRequest.IsSetGroupBy())
                {
                    context.Writer.WriteTextString("groupBy");
                    context.Writer.WriteTextString(publicRequest.GroupBy);
                }
                if (publicRequest.IsSetInvoiceBillingPeriod())
                {
                    context.Writer.WriteTextString("invoiceBillingPeriod");
                    context.Writer.WriteStartMap(null);

                    var marshaller = InvoiceBillingPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InvoiceBillingPeriod, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInvoiceId())
                {
                    context.Writer.WriteTextString("invoiceId");
                    context.Writer.WriteTextString(publicRequest.InvoiceId);
                }
                if (publicRequest.IsSetInvoiceType())
                {
                    context.Writer.WriteTextString("invoiceType");
                    context.Writer.WriteTextString(publicRequest.InvoiceType);
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
        private static ListAgreementInvoiceLineItemsRequestMarshaller _instance = new ListAgreementInvoiceLineItemsRequestMarshaller();        

        internal static ListAgreementInvoiceLineItemsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAgreementInvoiceLineItemsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}