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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTransactions Request Marshaller
    /// </summary>       
    public class ListTransactionsRequestMarshaller : IMarshaller<IRequest, ListTransactionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTransactionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTransactionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchainQuery");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/list-transactions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddress())
                {
                    context.Writer.WritePropertyName("address");
                    context.Writer.Write(publicRequest.Address);
                }

                if(publicRequest.IsSetConfirmationStatusFilter())
                {
                    context.Writer.WritePropertyName("confirmationStatusFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfirmationStatusFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConfirmationStatusFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFromBlockchainInstant())
                {
                    context.Writer.WritePropertyName("fromBlockchainInstant");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlockchainInstantMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FromBlockchainInstant, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNetwork())
                {
                    context.Writer.WritePropertyName("network");
                    context.Writer.Write(publicRequest.Network);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSort())
                {
                    context.Writer.WritePropertyName("sort");
                    context.Writer.WriteObjectStart();

                    var marshaller = ListTransactionsSortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sort, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetToBlockchainInstant())
                {
                    context.Writer.WritePropertyName("toBlockchainInstant");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlockchainInstantMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ToBlockchainInstant, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListTransactionsRequestMarshaller _instance = new ListTransactionsRequestMarshaller();        

        internal static ListTransactionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTransactionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}