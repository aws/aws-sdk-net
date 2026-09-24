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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRawEvents Request Marshaller
    /// </summary>       
    public class PutRawEventsRequestMarshaller : IMarshaller<IRequest, PutRawEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRawEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRawEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EventBridgeV2");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSEventsV2/operation/PutRawEvents";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-15";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDeduplicationConfiguration())
                {
                    context.Writer.WriteTextString("DeduplicationConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DeduplicationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeduplicationConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEntries())
                {
                    context.Writer.WriteTextString("Entries");
                    context.Writer.WriteStartArray(publicRequest.Entries.Count);
                    foreach(var publicRequestEntriesListValue in publicRequest.Entries)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = PutRawEventsRequestEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestEntriesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEventBusArn())
                {
                    context.Writer.WriteTextString("EventBusArn");
                    context.Writer.WriteTextString(publicRequest.EventBusArn);
                }
                if (publicRequest.IsSetSchemaRegistryConfiguration())
                {
                    context.Writer.WriteTextString("SchemaRegistryConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SchemaRegistryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchemaRegistryConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static PutRawEventsRequestMarshaller _instance = new PutRawEventsRequestMarshaller();        

        internal static PutRawEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRawEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}