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
    /// ProcessPayment Request Marshaller
    /// </summary>       
    public class ProcessPaymentRequestMarshaller : IMarshaller<IRequest, ProcessPaymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ProcessPaymentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ProcessPaymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/payments/processPayment";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
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
            if(publicRequest.IsSetPaymentInput())
            {
                context.Writer.WritePropertyName("paymentInput");
                context.Writer.WriteStartObject();

                var marshaller = PaymentInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.PaymentInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPaymentInstrumentId())
            {
                context.Writer.WritePropertyName("paymentInstrumentId");
                context.Writer.WriteStringValue(publicRequest.PaymentInstrumentId);
            }

            if(publicRequest.IsSetPaymentManagerArn())
            {
                context.Writer.WritePropertyName("paymentManagerArn");
                context.Writer.WriteStringValue(publicRequest.PaymentManagerArn);
            }

            if(publicRequest.IsSetPaymentSessionId())
            {
                context.Writer.WritePropertyName("paymentSessionId");
                context.Writer.WriteStringValue(publicRequest.PaymentSessionId);
            }

            if(publicRequest.IsSetPaymentType())
            {
                context.Writer.WritePropertyName("paymentType");
                context.Writer.WriteStringValue(publicRequest.PaymentType);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
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
        private static ProcessPaymentRequestMarshaller _instance = new ProcessPaymentRequestMarshaller();        

        internal static ProcessPaymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProcessPaymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}