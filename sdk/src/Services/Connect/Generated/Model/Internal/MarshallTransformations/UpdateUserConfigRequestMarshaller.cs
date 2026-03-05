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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateUserConfig Request Marshaller
    /// </summary>       
    public class UpdateUserConfigRequestMarshaller : IMarshaller<IRequest, UpdateUserConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateUserConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateUserConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            if (!publicRequest.IsSetUserId())
                throw new AmazonConnectException("Request object does not have required field UserId set");
            request.AddPathResource("{UserId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/users/{InstanceId}/{UserId}/config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAfterContactWorkConfigs())
            {
                context.Writer.WritePropertyName("AfterContactWorkConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAfterContactWorkConfigsListValue in publicRequest.AfterContactWorkConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AfterContactWorkConfigPerChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequestAfterContactWorkConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAutoAcceptConfigs())
            {
                context.Writer.WritePropertyName("AutoAcceptConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAutoAcceptConfigsListValue in publicRequest.AutoAcceptConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutoAcceptConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestAutoAcceptConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPersistentConnectionConfigs())
            {
                context.Writer.WritePropertyName("PersistentConnectionConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPersistentConnectionConfigsListValue in publicRequest.PersistentConnectionConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PersistentConnectionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestPersistentConnectionConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPhoneNumberConfigs())
            {
                context.Writer.WritePropertyName("PhoneNumberConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPhoneNumberConfigsListValue in publicRequest.PhoneNumberConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PhoneNumberConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestPhoneNumberConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVoiceEnhancementConfigs())
            {
                context.Writer.WritePropertyName("VoiceEnhancementConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVoiceEnhancementConfigsListValue in publicRequest.VoiceEnhancementConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VoiceEnhancementConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestVoiceEnhancementConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static UpdateUserConfigRequestMarshaller _instance = new UpdateUserConfigRequestMarshaller();        

        internal static UpdateUserConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateUserConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}