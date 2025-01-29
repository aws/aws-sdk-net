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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
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
namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSipMediaApplicationCall Request Marshaller
    /// </summary>       
    public class UpdateSipMediaApplicationCallRequestMarshaller : IMarshaller<IRequest, UpdateSipMediaApplicationCallRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSipMediaApplicationCallRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSipMediaApplicationCallRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSipMediaApplicationId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field SipMediaApplicationId set");
            request.AddPathResource("{sipMediaApplicationId}", StringUtils.FromString(publicRequest.SipMediaApplicationId));
            if (!publicRequest.IsSetTransactionId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field TransactionId set");
            request.AddPathResource("{transactionId}", StringUtils.FromString(publicRequest.TransactionId));
            request.ResourcePath = "/sip-media-applications/{sipMediaApplicationId}/calls/{transactionId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArguments())
            {
                context.Writer.WritePropertyName("Arguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestArgumentsKvp in publicRequest.Arguments)
                {
                    context.Writer.WritePropertyName(publicRequestArgumentsKvp.Key);
                    var publicRequestArgumentsValue = publicRequestArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestArgumentsValue);
                }
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
        private static UpdateSipMediaApplicationCallRequestMarshaller _instance = new UpdateSipMediaApplicationCallRequestMarshaller();        

        internal static UpdateSipMediaApplicationCallRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSipMediaApplicationCallRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}