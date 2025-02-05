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
    /// RetrieveAndGenerateStream Request Marshaller
    /// </summary>       
    public class RetrieveAndGenerateStreamRequestMarshaller : IMarshaller<IRequest, RetrieveAndGenerateStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RetrieveAndGenerateStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RetrieveAndGenerateStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/retrieveAndGenerateStream";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStartObject();

                var marshaller = RetrieveAndGenerateInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Input, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetrieveAndGenerateConfiguration())
            {
                context.Writer.WritePropertyName("retrieveAndGenerateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RetrieveAndGenerateConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetrieveAndGenerateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionConfiguration())
            {
                context.Writer.WritePropertyName("sessionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RetrieveAndGenerateSessionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SessionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionId())
            {
                context.Writer.WritePropertyName("sessionId");
                context.Writer.WriteStringValue(publicRequest.SessionId);
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
        private static RetrieveAndGenerateStreamRequestMarshaller _instance = new RetrieveAndGenerateStreamRequestMarshaller();        

        internal static RetrieveAndGenerateStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RetrieveAndGenerateStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}