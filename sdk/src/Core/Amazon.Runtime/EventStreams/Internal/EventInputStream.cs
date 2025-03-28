using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.EventStreams.Internal
{
    public abstract class EventInputStream : IDisposable
    {
        const string HeaderContentType = ":content-type";
        const string HeaderEventType = ":event-type";
        const string HeaderMessageType = ":message-type";
        const string HeaderMessageTypeEvent = "event";
        const string HeaderDate = ":date";
        const string HeaderChunkSignature = ":chunk-signature";

        private readonly EventInputStreamContext _context;

        private readonly SemaphoreSlim _semaphore = new(1, 1);

        private string _previousSignature;

        public EventInputStream(EventInputStreamContext context)
        {
            _context = context;
            _previousSignature = _context.InitialSignature;
        }

        /// <summary>
        /// Signs the event and then writes the event to the service. This method uses a semaphore to ensure only 
        /// one event is written at a time. Events must be sent serially with the signature of the current event used
        /// as in signing the next event.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="contentType"></param>
        /// <param name="marshalledEventHeaders"></param>
        /// <param name="eventPayload"></param>
        /// <returns></returns>
        protected async Task WriteEvent(string eventType, string contentType, IList<EventStreamHeader> marshalledEventHeaders, byte[] eventPayload)
        {
            await _semaphore.WaitAsync().ConfigureAwait(false);
            try
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

                // Construct the user's event and grab the binary representation of the event.
                var eventMessage = new EventStreamMessage(eventHeaders, eventPayload);
                var eventBytes = eventMessage.ToByteArray();

                // Now that the user's event object has been created an envelope event must be created that contains the signature
                // for the user event.
                var signedHeaders = new List<IEventStreamHeader>();

                // Capture the date so we ensure the same date is used in both the header and what is passed to signing.
                var timestamp = AWSSDKUtils.CorrectedUtcNow;

                var signedDateHeader = new EventStreamHeader(HeaderDate) { HeaderType = EventStreamHeaderType.String };
                signedDateHeader.SetTimestamp(timestamp);
                signedHeaders.Add(signedDateHeader);

                // Extract the binary representation of the date event header which is used as the headers for computing the 
                // signature. The size of 15 bytes is the size of the binary date header.
                var dateHeaderBuffer = new byte[15];
                var written = signedDateHeader.WriteToBuffer(dateHeaderBuffer, 0);

                // Compute the signature and then add the signature to the envelope event as a header.
                var immutableCredentials = await _context.Credentials.GetCredentialsAsync().ConfigureAwait(false);
                var signature = ComputeSignature(dateHeaderBuffer, eventBytes, immutableCredentials.SecretKey, timestamp);
                var signedSignatureHeader = new EventStreamHeader(HeaderChunkSignature) { HeaderType = EventStreamHeaderType.String };
                signedSignatureHeader.SetByteBuf(signature);
                signedHeaders.Add(signedSignatureHeader);

                // Create the byte array representation of the event and send it to the service.
                var signedMessage = new EventStreamMessage(signedHeaders, eventBytes);
                var signedMessageBytes = signedMessage.ToByteArray();
                await _context.RequestStreamWriter.WriteAsync(signedMessageBytes).ConfigureAwait(false);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Compute the signature for an event.
        /// </summary>
        /// <param name="headers">The binary represenation of the headers being sent in the event.</param>
        /// <param name="eventBytes">The binary represnetation of the payload of the event.</param>
        /// <param name="secretKey">AWS Secret Key that should be used for signing the request.</param>
        /// <param name="dateStamp">The date used in defining the signing key and string to sign.</param>
        /// <returns></returns>
        private byte[] ComputeSignature(byte[] headers, byte[] eventBytes, string secretKey, DateTime dateStamp)
        {
            using (var hmac = new HMACSHA256(AWS4Signer.ComposeSigningKey(secretKey, _context.AuthenticationRegion, dateStamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat), _context.ClientConfig.AuthenticationServiceName)))
            {
                var formattedDateStamp = dateStamp.ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat);

                var stringToSign = new StringBuilder();
                stringToSign.Append("AWS4-HMAC-SHA256-PAYLOAD");
                stringToSign.Append("\n");
                stringToSign.Append(formattedDateStamp);
                stringToSign.Append("\n");
                stringToSign.Append($"{dateStamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat)}/{_context.AuthenticationRegion}/{_context.ClientConfig.AuthenticationServiceName}/aws4_request");
                stringToSign.Append("\n");
                stringToSign.Append(_previousSignature);
                stringToSign.Append("\n");
                stringToSign.Append(AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(headers), true));
                stringToSign.Append("\n");
                stringToSign.Append(AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(eventBytes), true));

                var signature = hmac.ComputeHash(UTF8Encoding.UTF8.GetBytes(stringToSign.ToString()));

                // Store the signature for the next event
                _previousSignature = AWSSDKUtils.ToHex(signature, true);

                return signature;
            }
        }

        private IRequest CreateMarshallingRequest()
        {
            return new DefaultRequest(this._context.OriginalRequest, _context.ClientConfig.AuthenticationServiceName);
        }

        /// <summary>
        /// Construct a JsonMarshallerContext that subclasses can use to run the marshaller for the event type
        /// that should be sent.
        /// </summary>
        /// <param name="stream">The stream that the marshaller will write to as it is marshalling the user's object into it's JSON representation.</param>
        /// <returns></returns>
        protected JsonMarshallerContext CreateJsonMarshallerContext(Stream stream)
        {
            IRequest request = CreateMarshallingRequest();
            var writer = new Utf8JsonWriter(stream);
            return new JsonMarshallerContext(request, writer);
        }

        private bool _disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.RequestStreamWriter.Dispose();
                    _semaphore.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
