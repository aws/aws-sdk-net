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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
using ThirdParty.RuntimeBackports;
#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMessage Request Marshaller
    /// </summary>       
    public class SendMessageRequestMarshaller : IMarshaller<IRequest, SendMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            string target = "AmazonSQS.SendMessage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDelaySeconds())
            {
                context.Writer.WritePropertyName("DelaySeconds");
                context.Writer.WriteNumberValue(publicRequest.DelaySeconds.Value);
            }

            if(publicRequest.IsSetMessageAttributes())
            {
                context.Writer.WritePropertyName("MessageAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMessageAttributesKvp in publicRequest.MessageAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestMessageAttributesKvp.Key);
                    var publicRequestMessageAttributesValue = publicRequestMessageAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = MessageAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessageAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMessageBody())
            {
                context.Writer.WritePropertyName("MessageBody");
                context.Writer.WriteStringValue(publicRequest.MessageBody);
            }

            if(publicRequest.IsSetMessageDeduplicationId())
            {
                context.Writer.WritePropertyName("MessageDeduplicationId");
                context.Writer.WriteStringValue(publicRequest.MessageDeduplicationId);
            }

            if(publicRequest.IsSetMessageGroupId())
            {
                context.Writer.WritePropertyName("MessageGroupId");
                context.Writer.WriteStringValue(publicRequest.MessageGroupId);
            }

            if(publicRequest.IsSetMessageSystemAttributes())
            {
                context.Writer.WritePropertyName("MessageSystemAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMessageSystemAttributesKvp in publicRequest.MessageSystemAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestMessageSystemAttributesKvp.Key);
                    var publicRequestMessageSystemAttributesValue = publicRequestMessageSystemAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = MessageSystemAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessageSystemAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQueueUrl())
            {
                context.Writer.WritePropertyName("QueueUrl");
                context.Writer.WriteStringValue(publicRequest.QueueUrl);
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
        private static SendMessageRequestMarshaller _instance = new SendMessageRequestMarshaller();        

        internal static SendMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}