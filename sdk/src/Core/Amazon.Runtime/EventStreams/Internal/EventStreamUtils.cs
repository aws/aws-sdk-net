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

using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.Internal.Transform;
using System.IO;

namespace Amazon.Runtime.EventStreams.Utils
{
    /// <summary>
    /// This class is used to convert an <seealso cref="EventStreamMessage"/> to the appropriate
    /// <seealso cref="UnmarshallerContext"/>. The payload of the EventStreamMessage is read sent in
    /// as the stream to the unmarshaller and it is unmarshalled to the appropriate event class from there.
    /// </summary>
    public static class EventStreamUtils
    {
        /// <summary>
        /// Converts an <seealso cref="EventStreamMessage"/> to a <seealso cref="XmlUnmarshallerContext"/>.
        /// </summary>
        /// <param name="message">The event stream message.</param>
        /// <returns>The XmlUnmarshallerContext</returns>
        public static XmlUnmarshallerContext ConvertMessageToXmlContext(IEventStreamMessage message)
        {
            return new XmlUnmarshallerContext(new MemoryStream(message.Payload), false, ConvertMessageToResponseData(message));
        }

        /// <summary>
        /// Converts an <seealso cref="EventStreamMessage"/> to a <seealso cref="JsonUnmarshallerContext"/>
        /// </summary>
        /// <param name="message">The event stream message</param>
        /// <returns>The JsonUnmarshallerContext</returns>
        public static JsonUnmarshallerContext ConvertMessageToJsonContext(IEventStreamMessage message)
        {
            return new JsonUnmarshallerContext(new MemoryStream(message.Payload), false, ConvertMessageToResponseData(message));
        }

        /// <summary>
        /// Wraps the headers of an <seealso cref="EventStreamMessage"/> as <seealso cref="IWebResponseData"/>, so an
        /// unmarshaller context built over the message payload can read the event's headers.
        /// </summary>
        /// <param name="message">The event stream message</param>
        /// <returns>The response data exposing the message headers</returns>
        public static IWebResponseData ConvertMessageToResponseData(IEventStreamMessage message)
        {
#if NETFRAMEWORK
            return new HttpWebRequestResponseData(message.Headers);
#else
            return new HttpClientResponseData(message.Headers);
#endif
        }

        /// <summary>
        /// Converts an <seealso cref="EventStreamMessage"/> to a Stream
        /// </summary>
        /// <param name="message">The event stream message</param>
        /// <returns>The stream of <seealso cref="EventStreamMessage"/></returns>
        public static Stream ConvertMessageToStream(IEventStreamMessage message)
        {
            var stream = new MemoryStream(message.Payload);
            return stream;
        }
    }
}
