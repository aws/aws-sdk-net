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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using System.Threading.Tasks;

namespace Amazon.Runtime.EventStreams.Internal
{
    /// <summary>
    /// This class is used when a request is streaming events to a service. The IRequest will have EventStreamPublisher
    /// assigned to it. The class will read the events from the EventStreamPublisher and format the message
    /// for sending to the service. Formatting includes signing the event and converting the event message
    /// to a byte array.
    /// </summary>
    internal class EventSignerHttpRequestStreamPublisher : IHttpRequestStreamPublisher
    {
        private readonly IEventStreamPublisher _eventPublisher;
        private readonly IEventSigner _eventSigner;

        /// <summary>
        /// Create an instance of EventSignerHttpRequestStreamPublisher
        /// </summary>
        /// <param name="eventPublisher">The event publisher to pull events from.</param>
        /// <param name="eventSigner">The event signer used to sign the events.</param>
        public EventSignerHttpRequestStreamPublisher(IEventStreamPublisher eventPublisher, IEventSigner eventSigner)
        {
            _eventPublisher = eventPublisher;
            _eventSigner = eventSigner;
        }

        /// <inheritdoc/>
        public async Task<byte[]> NextBytesAsync()
        {
            var evnt = await _eventPublisher.NextEventAsync().ConfigureAwait(false);
            if (evnt == null)
            {
                return null;
            }

            var signedBytes = await _eventSigner.SignEventAsync(evnt.ToByteArray()).ConfigureAwait(false);
            return signedBytes;
        }
    }
}
