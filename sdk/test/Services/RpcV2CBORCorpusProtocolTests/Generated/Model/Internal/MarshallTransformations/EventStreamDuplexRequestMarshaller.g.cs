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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.RpcV2CBORCorpusProtocolTests.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventStreamDuplex Request Marshaller
    /// </summary>
    public partial class EventStreamDuplexRequestMarshaller : IMarshaller<IRequest, EventStreamDuplexRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EventStreamDuplexRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(EventStreamDuplexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcV2CBORCorpusProtocolTests");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            byte[] initialRequest;
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetRequestId())
                {
                    context.Writer.WriteTextString("requestId");
                    context.Writer.WriteTextString(publicRequest.RequestId);
                }
                writer.WriteEndMap();
                initialRequest = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            request.EventStreamPublisher = new RequestEventStreamPublisherMarshaller(publicRequest.EventsPublisher, initialRequest);
            request.Headers["Accept"] = "application/vnd.amazon.eventstream";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-11-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/RpcV2CborCorpusTests/operation/EventStreamDuplex";

            return request;
        }

        private static readonly EventStreamDuplexRequestMarshaller _instance = new();

        internal static EventStreamDuplexRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EventStreamDuplexRequestMarshaller Instance => _instance;
    }
}
