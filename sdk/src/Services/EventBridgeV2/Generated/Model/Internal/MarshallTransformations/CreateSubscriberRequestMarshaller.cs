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
    /// CreateSubscriber Request Marshaller
    /// </summary>       
    public class CreateSubscriberRequestMarshaller : IMarshaller<IRequest, CreateSubscriberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSubscriberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSubscriberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EventBridgeV2");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSEventsV2/operation/CreateSubscriber";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-15";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBatchConfiguration())
                {
                    context.Writer.WriteTextString("BatchConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = BatchConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BatchConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else if (!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEventBusArn())
                {
                    context.Writer.WriteTextString("EventBusArn");
                    context.Writer.WriteTextString(publicRequest.EventBusArn);
                }
                if (publicRequest.IsSetFilterConfiguration())
                {
                    context.Writer.WriteTextString("FilterConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = FilterConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FilterConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInvokeConfiguration())
                {
                    context.Writer.WriteTextString("InvokeConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = InvokeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InvokeConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetLogConfiguration())
                {
                    context.Writer.WriteTextString("LogConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LogConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetOnFailureConfiguration())
                {
                    context.Writer.WriteTextString("OnFailureConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OnFailureConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnFailureConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPointInTimeConfiguration())
                {
                    context.Writer.WriteTextString("PointInTimeConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PointInTimeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PointInTimeConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRetryPolicy())
                {
                    context.Writer.WriteTextString("RetryPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RetryPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetryPolicy, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStartingPosition())
                {
                    context.Writer.WriteTextString("StartingPosition");
                    context.Writer.WriteTextString(publicRequest.StartingPosition);
                }
                if (publicRequest.IsSetState())
                {
                    context.Writer.WriteTextString("State");
                    context.Writer.WriteTextString(publicRequest.State);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTransformer())
                {
                    context.Writer.WriteTextString("Transformer");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TransformerMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Transformer, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetType())
                {
                    context.Writer.WriteTextString("Type");
                    context.Writer.WriteTextString(publicRequest.Type);
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
        private static CreateSubscriberRequestMarshaller _instance = new CreateSubscriberRequestMarshaller();        

        internal static CreateSubscriberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSubscriberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}