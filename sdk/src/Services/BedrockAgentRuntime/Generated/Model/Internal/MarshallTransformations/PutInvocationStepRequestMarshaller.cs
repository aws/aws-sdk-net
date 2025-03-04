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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
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
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutInvocationStep Request Marshaller
    /// </summary>       
    public class PutInvocationStepRequestMarshaller : IMarshaller<IRequest, PutInvocationStepRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutInvocationStepRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutInvocationStepRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSessionIdentifier())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field SessionIdentifier set");
            request.AddPathResource("{sessionIdentifier}", StringUtils.FromString(publicRequest.SessionIdentifier));
            request.ResourcePath = "/sessions/{sessionIdentifier}/invocationSteps/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetInvocationIdentifier())
            {
                context.Writer.WritePropertyName("invocationIdentifier");
                context.Writer.WriteStringValue(publicRequest.InvocationIdentifier);
            }

            if(publicRequest.IsSetInvocationStepId())
            {
                context.Writer.WritePropertyName("invocationStepId");
                context.Writer.WriteStringValue(publicRequest.InvocationStepId);
            }

            if(publicRequest.IsSetInvocationStepTime())
            {
                context.Writer.WritePropertyName("invocationStepTime");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.InvocationStepTime));
            }

            if(publicRequest.IsSetPayload())
            {
                context.Writer.WritePropertyName("payload");
                context.Writer.WriteStartObject();

                var marshaller = InvocationStepPayloadMarshaller.Instance;
                marshaller.Marshall(publicRequest.Payload, context);

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
        private static PutInvocationStepRequestMarshaller _instance = new PutInvocationStepRequestMarshaller();        

        internal static PutInvocationStepRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutInvocationStepRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}