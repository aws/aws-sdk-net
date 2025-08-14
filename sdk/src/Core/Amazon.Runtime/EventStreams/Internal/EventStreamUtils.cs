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
            var stream = new MemoryStream(message.Payload);
            return new XmlUnmarshallerContext(stream, false, null);
        }

        /// <summary>
        /// Converts an <seealso cref="EventStreamMessage"/> to a <seealso cref="JsonUnmarshallerContext"/>
        /// </summary>
        /// <param name="message">The event stream message</param>
        /// <returns>The JsonUnmarshallerContext</returns>
        public static JsonUnmarshallerContext ConvertMessageToJsonContext(IEventStreamMessage message)
        {
            var stream = new MemoryStream(message.Payload);
            return new JsonUnmarshallerContext(stream, false, null);
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
