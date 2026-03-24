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

using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS SigV4 event signer used for signing events as they are being streamed to AWS service.
    /// </summary>
    public class AWS4EventSigner : IEventSigner
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(AWS4EventSigner));

        private const string Sha256Payload = "AWS4-HMAC-SHA256-PAYLOAD";
        private const string HeaderDate = ":date";
        private const string HeaderChunkSignature = ":chunk-signature";

        private readonly AWSCredentials _credentials;
        private readonly string _region;
        private readonly string _service;
        private readonly string _initialRequestSignature;
        private readonly int _instanceId;
        private static int _instanceCounter;

        private string _previousSignature;
        private int _eventCount;

        /// <summary>
        /// Constructe an isntance of the event signer.
        /// </summary>
        /// <param name="credentials">AWS Credentials used to sign the request.</param>
        /// <param name="region">The region to authenticate for.</param>
        /// <param name="service">The service to authenticate for.</param>
        /// <param name="requestSignature">The signature computed for the original request.</param>
        public AWS4EventSigner(AWSCredentials credentials, string region, string service, string requestSignature)
        {
            _credentials = credentials;
            _region = region;
            _service = service;
            _previousSignature = requestSignature;
            _initialRequestSignature = requestSignature;
            _instanceId = Interlocked.Increment(ref _instanceCounter);
            _eventCount = 0;

            _logger.DebugFormat(
                "AWS4EventSigner created: instanceId={0}, credentialType={1}, region={2}, service={3}, initialRequestSignature={4}",
                _instanceId,
                credentials?.GetType().Name ?? "null",
                region,
                service,
                requestSignature?.Substring(0, Math.Min(16, requestSignature?.Length ?? 0)) + "...");
        }

        /// <summary>
        /// Computes the AWS SigV4 signature using the signature of the previous signed event. In case of the first event the 
        /// inital request signature is used.
        /// 
        /// Once the signature is computed a new event message is created representing an envelope over the original
        /// event with the signature assigned as the header of the enevelope event message.
        /// </summary>
        /// <param name="eventBytes">The bytes of the event that must be signed.</param>
        /// <returns>The signed events that can be sent to the AWS service.</returns>
        public async Task<byte[]> SignEventAsync(byte[] eventBytes)
        {
            var currentEventNumber = Interlocked.Increment(ref _eventCount);
            var immutableCredentials = await _credentials.GetCredentialsAsync().ConfigureAwait(false);
            var secretKey = immutableCredentials.SecretKey;
            var accessKeyId = immutableCredentials.AccessKey;

            var timestamp = AWSSDKUtils.CorrectedUtcNow;

            // Log credential and timing details for every event signing
            var secretKeySuffix = secretKey != null && secretKey.Length >= 4
                ? secretKey.Substring(secretKey.Length - 4)
                : "null";
            _logger.DebugFormat(
                "AWS4EventSigner.SignEventAsync: instanceId={0}, eventNumber={1}, accessKeyId={2}, secretKeySuffix=...{3}, " +
                "hasToken={4}, timestamp={5}, previousSignature={6}, eventBytesLength={7}, credentialType={8}",
                _instanceId,
                currentEventNumber,
                accessKeyId,
                secretKeySuffix,
                immutableCredentials.UseToken,
                timestamp.ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat),
                _previousSignature?.Substring(0, Math.Min(16, _previousSignature?.Length ?? 0)) + "...",
                eventBytes?.Length ?? 0,
                _credentials?.GetType().Name ?? "null");

            var signedHeaders = new List<IEventStreamHeader>();

            var signedDateHeader = new EventStreamHeader(HeaderDate) { HeaderType = EventStreamHeaderType.String };
            signedDateHeader.SetTimestamp(timestamp);
            signedHeaders.Add(signedDateHeader);

            var dateHeaderBuffer = new byte[15];
            signedDateHeader.WriteToBuffer(dateHeaderBuffer, 0);

            var formattedDateStamp = timestamp.ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat);
            var dateHeaderHash = AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(dateHeaderBuffer), true);
            var payloadHash = AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(eventBytes), true);
            var scope = $"{timestamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat)}/{_region}/{_service}/aws4_request";

            var stringToSign = new StringBuilder();
            stringToSign.Append(Sha256Payload);
            stringToSign.Append("\n");
            stringToSign.Append(formattedDateStamp);
            stringToSign.Append("\n");
            stringToSign.Append(scope);
            stringToSign.Append("\n");
            stringToSign.Append(_previousSignature);
            stringToSign.Append("\n");
            stringToSign.Append(dateHeaderHash);
            stringToSign.Append("\n");
            stringToSign.Append(payloadHash);

            // Log the full string-to-sign components
            _logger.DebugFormat(
                "AWS4EventSigner.SignEventAsync StringToSign: instanceId={0}, eventNumber={1}, " +
                "formattedDateStamp={2}, scope={3}, previousSignature={4}, dateHeaderHash={5}, payloadHash={6}",
                _instanceId,
                currentEventNumber,
                formattedDateStamp,
                scope,
                _previousSignature,
                dateHeaderHash,
                payloadHash);

            var signingKey = AWS4Signer.ComposeSigningKey(secretKey, _region, timestamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat), _service);
            var signature = AWS4Signer.ComputeKeyedHash(AWS4Signer.SignerAlgorithm, signingKey, UTF8Encoding.UTF8.GetBytes(stringToSign.ToString()));

            var signedSignatureHeader = new EventStreamHeader(HeaderChunkSignature) { HeaderType = EventStreamHeaderType.String };
            signedSignatureHeader.SetByteBuf(signature);
            signedHeaders.Add(signedSignatureHeader);

            var signedMessage = new EventStreamMessage(signedHeaders, eventBytes);
            var signedMessageBytes = signedMessage.ToByteArray();

            var newSignature = AWSSDKUtils.ToHex(signature, true);

            _logger.DebugFormat(
                "AWS4EventSigner.SignEventAsync completed: instanceId={0}, eventNumber={1}, " +
                "previousSignature={2}, newSignature={3}, signingKeyHash={4}",
                _instanceId,
                currentEventNumber,
                _previousSignature?.Substring(0, Math.Min(16, _previousSignature?.Length ?? 0)) + "...",
                newSignature.Substring(0, Math.Min(16, newSignature.Length)) + "...",
                AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(signingKey), true).Substring(0, 16) + "...");

            _previousSignature = newSignature;

            return signedMessageBytes;
        }
    }
}
