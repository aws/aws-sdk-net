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
#pragma warning disable CA1001 // TODO: Handle disposing for event stream
    public abstract class EventInputStream
#pragma warning restore CA1001
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

        protected async Task WriteEvent(string eventType, string contentType, IList<EventStreamHeader> headers, byte[] binaryPayload)
        {
            await _semaphore.WaitAsync().ConfigureAwait(false);
            try
            {
                var immutableCredentials = await _context.Credentials.GetCredentialsAsync().ConfigureAwait(false);

                var timestamp = AWSSDKUtils.CorrectedUtcNow;

                var eventHeaders = new List<IEventStreamHeader>();

                var eventContentTypeHeader = new EventStreamHeader(HeaderContentType) { HeaderType = EventStreamHeaderType.String };
                eventContentTypeHeader.SetString(contentType);
                eventHeaders.Add(eventContentTypeHeader);

                var eventTypeHeader = new EventStreamHeader(HeaderEventType) { HeaderType = EventStreamHeaderType.String };
                eventTypeHeader.SetString(eventType);
                eventHeaders.Add(eventTypeHeader);

                var eventMessageTypeHeader = new EventStreamHeader(HeaderMessageType) { HeaderType = EventStreamHeaderType.String };
                eventMessageTypeHeader.SetString(HeaderMessageTypeEvent);
                eventHeaders.Add(eventMessageTypeHeader);

                if (headers != null)
                {
                    eventHeaders.AddRange(headers);
                }

                var eventMessage = new EventStreamMessage(eventHeaders, binaryPayload);
                var eventBytes = eventMessage.ToByteArray();

                var signedHeaders = new List<IEventStreamHeader>();

                var signedDateHeader = new EventStreamHeader(HeaderDate) { HeaderType = EventStreamHeaderType.String };
                signedDateHeader.SetTimestamp(timestamp);
                signedHeaders.Add(signedDateHeader);

                var dateHeaderBuffer = new byte[15];
                var written = signedDateHeader.WriteToBuffer(dateHeaderBuffer, 0);

                var signature = SignEvent(dateHeaderBuffer, eventBytes, immutableCredentials.SecretKey, timestamp);
                var signedSignatureHeader = new EventStreamHeader(HeaderChunkSignature) { HeaderType = EventStreamHeaderType.String };
                signedSignatureHeader.SetByteBuf(signature);
                signedHeaders.Add(signedSignatureHeader);

                var signedMessage = new EventStreamMessage(signedHeaders, eventBytes);
                await _context.RequestStreamWriter.WriteAsync(signedMessage.ToByteArray()).ConfigureAwait(false);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private byte[] SignEvent(byte[] headers, byte[] eventBytes, string secretKey, DateTime dateStamp)
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

        protected JsonMarshallerContext CreateJsonMarshallerContext(Stream stream)
        {
            IRequest request = CreateMarshallingRequest();
            var writer = new Utf8JsonWriter(stream);
            return new JsonMarshallerContext(request, writer);
        }
    }
}
