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

using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.EventStreams
{
    /// <summary>
    /// The event stream publisher is used to pull events from consumers of the SDK to be streamed into a service.
    /// </summary>
    public interface IEventStreamPublisher
    {
        /// <summary>
        /// Pull the next event to be streamed from the consumer of the SDK.
        /// </summary>
        /// <returns></returns>
        Task<IEventStreamMessage> NextEventAsync();
    }

    /// <summary>
    /// Base class for event stream publishers.
    /// </summary>
    public abstract class EventStreamPublisher : IEventStreamPublisher
    {
        const string HeaderContentType = ":content-type";
        const string HeaderEventType = ":event-type";
        const string HeaderMessageType = ":message-type";
        const string HeaderMessageTypeEvent = "event";

        /// <inheritdoc/>
        public abstract Task<IEventStreamMessage> NextEventAsync();

        /// <summary>
        /// Creates an IEventStreamMessage from the marshalled data of the event POCO.
        /// </summary>
        /// <param name="eventType">Used to set the event type header.</param>
        /// <param name="contentType">Used to set the event content type.</param>
        /// <param name="marshalledEventHeaders">The list of event headers that were marshalled from the event POCO.</param>
        /// <param name="eventPayload">The event payload represent the marshalled body of the event POCO.</param>
        /// <returns></returns>
        protected static IEventStreamMessage CreateEventStreamMessage(string eventType, string contentType, IList<EventStreamHeader> marshalledEventHeaders, byte[] eventPayload)
        {
            var eventHeaders = new List<IEventStreamHeader>();

            // Add the content type header
            var eventContentTypeHeader = new EventStreamHeader(HeaderContentType) { HeaderType = EventStreamHeaderType.String };
            eventContentTypeHeader.SetString(contentType);
            eventHeaders.Add(eventContentTypeHeader);

            // Add the event type header mapped to the modeled event type name.
            var eventTypeHeader = new EventStreamHeader(HeaderEventType) { HeaderType = EventStreamHeaderType.String };
            eventTypeHeader.SetString(eventType);
            eventHeaders.Add(eventTypeHeader);

            // Add the message type header which has a const value of "event"
            var eventMessageTypeHeader = new EventStreamHeader(HeaderMessageType) { HeaderType = EventStreamHeaderType.String };
            eventMessageTypeHeader.SetString(HeaderMessageTypeEvent);
            eventHeaders.Add(eventMessageTypeHeader);

            // Add additional headers that were marshalled from the user's type.
            if (marshalledEventHeaders != null)
            {
                eventHeaders.AddRange(marshalledEventHeaders);
            }

            var eventMessage = new EventStreamMessage(eventHeaders, eventPayload);
            return eventMessage;
        }

        /// <summary>
        /// Construct a JsonMarshallerContext that subclasses can use to run the marshaller for the event type
        /// that should be sent.
        /// </summary>
        /// <param name="stream">The stream that the marshaller will write to as it is marshalling the user's object into it's JSON representation.</param>
        /// <returns></returns>
        protected static JsonMarshallerContext CreateJsonMarshallerContext(Stream stream)
        {
            // The original request and service are not needed for event serialization so placeholder values are used.
            IRequest request = new DefaultRequest(new EventStreamRequest(), "eventstream");
            var writer = new Utf8JsonWriter(stream);
            return new JsonMarshallerContext(request, writer);
        }

        protected class EventStreamRequest : AmazonWebServiceRequest
        { }
    }
}
