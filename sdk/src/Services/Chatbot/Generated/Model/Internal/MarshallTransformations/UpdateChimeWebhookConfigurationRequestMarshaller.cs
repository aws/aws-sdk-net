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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chatbot.Model;
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
namespace Amazon.Chatbot.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChimeWebhookConfiguration Request Marshaller
    /// </summary>       
    public class UpdateChimeWebhookConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateChimeWebhookConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateChimeWebhookConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateChimeWebhookConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-chime-webhook-configuration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChatConfigurationArn())
            {
                context.Writer.WritePropertyName("ChatConfigurationArn");
                context.Writer.WriteStringValue(publicRequest.ChatConfigurationArn);
            }

            if(publicRequest.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamRoleArn);
            }

            if(publicRequest.IsSetLoggingLevel())
            {
                context.Writer.WritePropertyName("LoggingLevel");
                context.Writer.WriteStringValue(publicRequest.LoggingLevel);
            }

            if(publicRequest.IsSetSnsTopicArns())
            {
                context.Writer.WritePropertyName("SnsTopicArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSnsTopicArnsListValue in publicRequest.SnsTopicArns)
                {
                        context.Writer.WriteStringValue(publicRequestSnsTopicArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWebhookDescription())
            {
                context.Writer.WritePropertyName("WebhookDescription");
                context.Writer.WriteStringValue(publicRequest.WebhookDescription);
            }

            if(publicRequest.IsSetWebhookUrl())
            {
                context.Writer.WritePropertyName("WebhookUrl");
                context.Writer.WriteStringValue(publicRequest.WebhookUrl);
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
        private static UpdateChimeWebhookConfigurationRequestMarshaller _instance = new UpdateChimeWebhookConfigurationRequestMarshaller();        

        internal static UpdateChimeWebhookConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateChimeWebhookConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}