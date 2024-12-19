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
    /// ReceiveMessage Request Marshaller
    /// </summary>       
    public class ReceiveMessageRequestMarshaller : IMarshaller<IRequest, ReceiveMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReceiveMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReceiveMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            string target = "AmazonSQS.ReceiveMessage";
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
            if(publicRequest.IsSetAttributeNames())
            {
                context.Writer.WritePropertyName("AttributeNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributeNamesListValue in publicRequest.AttributeNames)
                {
                        context.Writer.WriteStringValue(publicRequestAttributeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxNumberOfMessages())
            {
                context.Writer.WritePropertyName("MaxNumberOfMessages");
                context.Writer.WriteNumberValue(publicRequest.MaxNumberOfMessages.Value);
            }

            if(publicRequest.IsSetMessageAttributeNames())
            {
                context.Writer.WritePropertyName("MessageAttributeNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMessageAttributeNamesListValue in publicRequest.MessageAttributeNames)
                {
                        context.Writer.WriteStringValue(publicRequestMessageAttributeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMessageSystemAttributeNames())
            {
                context.Writer.WritePropertyName("MessageSystemAttributeNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMessageSystemAttributeNamesListValue in publicRequest.MessageSystemAttributeNames)
                {
                        context.Writer.WriteStringValue(publicRequestMessageSystemAttributeNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQueueUrl())
            {
                context.Writer.WritePropertyName("QueueUrl");
                context.Writer.WriteStringValue(publicRequest.QueueUrl);
            }

            if(publicRequest.IsSetReceiveRequestAttemptId())
            {
                context.Writer.WritePropertyName("ReceiveRequestAttemptId");
                context.Writer.WriteStringValue(publicRequest.ReceiveRequestAttemptId);
            }

            if(publicRequest.IsSetVisibilityTimeout())
            {
                context.Writer.WritePropertyName("VisibilityTimeout");
                context.Writer.WriteNumberValue(publicRequest.VisibilityTimeout.Value);
            }

            if(publicRequest.IsSetWaitTimeSeconds())
            {
                context.Writer.WritePropertyName("WaitTimeSeconds");
                context.Writer.WriteNumberValue(publicRequest.WaitTimeSeconds.Value);
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
        private static ReceiveMessageRequestMarshaller _instance = new ReceiveMessageRequestMarshaller();        

        internal static ReceiveMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReceiveMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}