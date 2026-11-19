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
using System.IO;
using System.Threading.Tasks;
using Amazon.Runtime.EventStreams;
using System.Collections.Generic;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.EventStreams;

#pragma warning disable CS0612,CS0618

namespace Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Marshals the service events for the event stream to the low level IEventStreamMessage.
    /// </summary>
    public partial class RequestEventStreamPublisherMarshaller : CborEventStreamPublisher
    {
        Func<Task<IRequestEventStreamEvent>> _publisher;
        byte[] _initialRequest;

        /// <summary>
        /// Creates instance of RequestEventStreamPublisherMarshaller
        /// </summary>
        /// <param name="publisher">The service event publisher provided by the consumer of the SDK.</param>
        public RequestEventStreamPublisherMarshaller(Func<Task<IRequestEventStreamEvent>> publisher)
        {
            _publisher = publisher;
        }

        internal RequestEventStreamPublisherMarshaller(Func<Task<IRequestEventStreamEvent>> publisher, byte[] initialRequest) : this(publisher)
        {
            _initialRequest = initialRequest;
        }

        /// <summary>
        /// Gets the next service event provided by the consumer of the SDK and converts it to a IEventStreamMessage.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Amazon.Runtime.AmazonClientException">If the type of the event is unknown.</exception>
        public override async Task<IEventStreamMessage> NextEventAsync()
        {
            if (_initialRequest != null)
            {
                var initialRequest = _initialRequest;
                _initialRequest = null;
                return CreateEventStreamMessage(eventType: "initial-request", contentType: "application/cbor", marshalledEventHeaders: null, eventPayload: initialRequest);
            }

            var evnt = await _publisher().ConfigureAwait(false);
            if (evnt == null)
            {
                return null;
            }

            byte[] eventPayload;
            string contentType;
            string eventType;
            IList<EventStreamHeader> eventHeaders;
            if (evnt is EndStreamEvent)
            {
                var writer = CborWriterPool.Rent();
                try
                {
                    var context = CreateCborMarshallerContext(writer);
                    EndStreamEventMarshaller.Instance.Marshall((EndStreamEvent)evnt, context);
                    eventHeaders = context.Request.EventHeaders;

                    eventType = "endStream";
                    contentType = null;
                    eventPayload = Array.Empty<byte>();
                }
                finally
                {
                    CborWriterPool.Return(writer);
                }
            }
            else if (evnt is SendMessageEvent)
            {
                var writer = CborWriterPool.Rent();
                try
                {
                    var context = CreateCborMarshallerContext(writer);
                    context.Writer.WriteStartMap(null);
                    SendMessageEventMarshaller.Instance.Marshall((SendMessageEvent)evnt, context);
                    eventHeaders = context.Request.EventHeaders;
                    context.Writer.WriteEndMap();

                    eventType = "sendMessage";
                    contentType = "application/cbor";
                    eventPayload = writer.Encode();
                }
                finally
                {
                    CborWriterPool.Return(writer);
                }
            }
            else
            {
                throw new Amazon.Runtime.AmazonClientException($"Type {evnt.GetType().FullName} is not a known event type for this streaming operation");
            }

            return CreateEventStreamMessage(eventType: eventType, contentType: contentType, marshalledEventHeaders: eventHeaders, eventPayload: eventPayload);
        }
    }
}
