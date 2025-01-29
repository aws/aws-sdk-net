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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AugmentedAIRuntime.Model;
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
namespace Amazon.AugmentedAIRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartHumanLoop Request Marshaller
    /// </summary>       
    public class StartHumanLoopRequestMarshaller : IMarshaller<IRequest, StartHumanLoopRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartHumanLoopRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartHumanLoopRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AugmentedAIRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-07";
            request.HttpMethod = "POST";

            request.ResourcePath = "/human-loops";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDataAttributes())
            {
                context.Writer.WritePropertyName("DataAttributes");
                context.Writer.WriteStartObject();

                var marshaller = HumanLoopDataAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFlowDefinitionArn())
            {
                context.Writer.WritePropertyName("FlowDefinitionArn");
                context.Writer.WriteStringValue(publicRequest.FlowDefinitionArn);
            }

            if(publicRequest.IsSetHumanLoopInput())
            {
                context.Writer.WritePropertyName("HumanLoopInput");
                context.Writer.WriteStartObject();

                var marshaller = HumanLoopInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.HumanLoopInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHumanLoopName())
            {
                context.Writer.WritePropertyName("HumanLoopName");
                context.Writer.WriteStringValue(publicRequest.HumanLoopName);
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
        private static StartHumanLoopRequestMarshaller _instance = new StartHumanLoopRequestMarshaller();        

        internal static StartHumanLoopRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartHumanLoopRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}