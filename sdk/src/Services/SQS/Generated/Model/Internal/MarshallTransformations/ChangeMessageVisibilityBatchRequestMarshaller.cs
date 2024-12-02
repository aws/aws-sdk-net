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
#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChangeMessageVisibilityBatch Request Marshaller
    /// </summary>       
    public class ChangeMessageVisibilityBatchRequestMarshaller : IMarshaller<IRequest, ChangeMessageVisibilityBatchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChangeMessageVisibilityBatchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ChangeMessageVisibilityBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            string target = "AmazonSQS.ChangeMessageVisibilityBatch";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEntries())
            {
                context.Writer.WritePropertyName("Entries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntriesListValue in publicRequest.Entries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChangeMessageVisibilityBatchRequestEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQueueUrl())
            {
                context.Writer.WritePropertyName("QueueUrl");
                context.Writer.WriteStringValue(publicRequest.QueueUrl);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ChangeMessageVisibilityBatchRequestMarshaller _instance = new ChangeMessageVisibilityBatchRequestMarshaller();        

        internal static ChangeMessageVisibilityBatchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChangeMessageVisibilityBatchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}