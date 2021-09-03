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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOrder Request Marshaller
    /// </summary>       
    public class CreateOrderRequestMarshaller : IMarshaller<IRequest, CreateOrderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOrderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOrderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/orders";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLineItems())
                {
                    context.Writer.WritePropertyName("LineItems");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLineItemsListValue in publicRequest.LineItems)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LineItemRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestLineItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutpostIdentifier())
                {
                    context.Writer.WritePropertyName("OutpostIdentifier");
                    context.Writer.Write(publicRequest.OutpostIdentifier);
                }

                if(publicRequest.IsSetPaymentOption())
                {
                    context.Writer.WritePropertyName("PaymentOption");
                    context.Writer.Write(publicRequest.PaymentOption);
                }

                if(publicRequest.IsSetPaymentTerm())
                {
                    context.Writer.WritePropertyName("PaymentTerm");
                    context.Writer.Write(publicRequest.PaymentTerm);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOrderRequestMarshaller _instance = new CreateOrderRequestMarshaller();        

        internal static CreateOrderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOrderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}