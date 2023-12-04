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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Amazon.Runtime.EventStreams.Internal
{
    /// <summary>
    /// The InitialResponse <seealso cref="EventStreamMessage"/> is not a modeled event by the service. It is just a message that is sent
    /// to signal the beginning of a stream of messages. The InitialResponseEvent may or may not contain 
    /// actual data in the payload, and some services may not even send an InitialResponse message. In the case that 
    /// the service does send an InitialResponse message, this class represents the event that the message is converted into.
    /// </summary>
    public class InitialResponseEvent : IEventStreamEvent
    {
        /// <summary>
        /// The constructor which takes in a message of type <see cref="IEventStreamMessage"/>
        /// </summary>
        /// <param name="message">The message of type IEventStreamMessage </param>
        public InitialResponseEvent(IEventStreamMessage message) 
        {
            Payload = new MemoryStream(message.Payload);
        }
        /// <summary>
        /// The payload of the message
        /// </summary>
        public MemoryStream Payload { get; set; }
    }
}
