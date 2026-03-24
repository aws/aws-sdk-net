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
using Amazon.Runtime.Internal.Util;
using System.Threading;
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
        private readonly Logger _logger = Logger.GetLogger(typeof(EventSignerHttpRequestStreamPublisher));
        private readonly IEventStreamPublisher _eventPublisher;
        private readonly IEventSigner _eventSigner;
        private readonly int _instanceId;
        private readonly int _requestHashCode;
        private static int _instanceCounter;
        private int _eventCount;

        /// <summary>
        /// Create an instance of EventSignerHttpRequestStreamPublisher
        /// </summary>
        /// <param name="eventPublisher">The event publisher to pull events from.</param>
        /// <param name="eventSigner">The event signer used to sign the events.</param>
        /// <param name="requestHashCode">Hash code of the IRequest for correlation logging.</param>
        public EventSignerHttpRequestStreamPublisher(IEventStreamPublisher eventPublisher, IEventSigner eventSigner, int requestHashCode = 0)
        {
            _eventPublisher = eventPublisher;
            _eventSigner = eventSigner;
            _requestHashCode = requestHashCode;
            _instanceId = Interlocked.Increment(ref _instanceCounter);
            _eventCount = 0;

            _logger.DebugFormat(
                "EventSignerHttpRequestStreamPublisher created: instanceId={0}, requestHashCode={1}, signerType={2}, publisherType={3}",
                _instanceId,
                _requestHashCode,
                eventSigner?.GetType().Name ?? "null",
                eventPublisher?.GetType().Name ?? "null");
        }

        /// <inheritdoc/>
        public async Task<byte[]> NextBytesAsync()
        {
            var currentEvent = Interlocked.Increment(ref _eventCount);

            _logger.DebugFormat(
                "EventSignerHttpRequestStreamPublisher.NextBytesAsync starting: instanceId={0}, eventCount={1}",
                _instanceId, currentEvent);

            var evnt = await _eventPublisher.NextEventAsync().ConfigureAwait(false);
            if (evnt == null)
            {
                _logger.DebugFormat(
                    "EventSignerHttpRequestStreamPublisher.NextBytesAsync: instanceId={0}, eventCount={1}, " +
                    "publisher returned NULL (end-of-stream)",
                    _instanceId, currentEvent);
                return null;
            }

            var eventBytes = evnt.ToByteArray();
            _logger.DebugFormat(
                "EventSignerHttpRequestStreamPublisher.NextBytesAsync: instanceId={0}, eventCount={1}, " +
                "eventBytesLength={2}, signing event...",
                _instanceId, currentEvent, eventBytes?.Length ?? 0);

            var signedBytes = await _eventSigner.SignEventAsync(eventBytes).ConfigureAwait(false);

            _logger.DebugFormat(
                "EventSignerHttpRequestStreamPublisher.NextBytesAsync completed: instanceId={0}, eventCount={1}, " +
                "signedBytesLength={2}",
                _instanceId, currentEvent, signedBytes?.Length ?? 0);

            return signedBytes;
        }
    }
}
