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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchainQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFilteredTransactionEvents Request Marshaller
    /// </summary>       
    public class ListFilteredTransactionEventsRequestMarshaller : IMarshaller<IRequest, ListFilteredTransactionEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFilteredTransactionEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListFilteredTransactionEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchainQuery");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/list-filtered-transaction-events";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAddressIdentifierFilter())
            {
                context.Writer.WritePropertyName("addressIdentifierFilter");
                context.Writer.WriteStartObject();

                var marshaller = AddressIdentifierFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.AddressIdentifierFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConfirmationStatusFilter())
            {
                context.Writer.WritePropertyName("confirmationStatusFilter");
                context.Writer.WriteStartObject();

                var marshaller = ConfirmationStatusFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConfirmationStatusFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNetwork())
            {
                context.Writer.WritePropertyName("network");
                context.Writer.WriteStringValue(publicRequest.Network);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("sort");
                context.Writer.WriteStartObject();

                var marshaller = ListFilteredTransactionEventsSortMarshaller.Instance;
                marshaller.Marshall(publicRequest.Sort, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimeFilter())
            {
                context.Writer.WritePropertyName("timeFilter");
                context.Writer.WriteStartObject();

                var marshaller = TimeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVoutFilter())
            {
                context.Writer.WritePropertyName("voutFilter");
                context.Writer.WriteStartObject();

                var marshaller = VoutFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.VoutFilter, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ListFilteredTransactionEventsRequestMarshaller _instance = new ListFilteredTransactionEventsRequestMarshaller();        

        internal static ListFilteredTransactionEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListFilteredTransactionEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}