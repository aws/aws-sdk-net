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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
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
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePaymentInstrument Request Marshaller
    /// </summary>       
    public class CreatePaymentInstrumentRequestMarshaller : IMarshaller<IRequest, CreatePaymentInstrumentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePaymentInstrumentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePaymentInstrumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/payments/createPaymentInstrument";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetPaymentConnectorId())
            {
                context.Writer.WritePropertyName("paymentConnectorId");
                context.Writer.WriteStringValue(publicRequest.PaymentConnectorId);
            }

            if(publicRequest.IsSetPaymentInstrumentDetails())
            {
                context.Writer.WritePropertyName("paymentInstrumentDetails");
                context.Writer.WriteStartObject();

                var marshaller = PaymentInstrumentDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PaymentInstrumentDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPaymentInstrumentType())
            {
                context.Writer.WritePropertyName("paymentInstrumentType");
                context.Writer.WriteStringValue(publicRequest.PaymentInstrumentType);
            }

            if(publicRequest.IsSetPaymentManagerArn())
            {
                context.Writer.WritePropertyName("paymentManagerArn");
                context.Writer.WriteStringValue(publicRequest.PaymentManagerArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetAgentName()) 
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Payments-Agent-Name"] = publicRequest.AgentName;
            }
        
            if (publicRequest.IsSetUserId()) 
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Payments-User-Id"] = publicRequest.UserId;
            }

            return request;
        }
        private static CreatePaymentInstrumentRequestMarshaller _instance = new CreatePaymentInstrumentRequestMarshaller();        

        internal static CreatePaymentInstrumentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePaymentInstrumentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}