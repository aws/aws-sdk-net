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
using Amazon.Util;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS SigV4 event signer used for signing events as they are being streamed to AWS service.
    /// </summary>
    public class AWS4EventSigner : IEventSigner
    {
        private const string Sha256Payload = "AWS4-HMAC-SHA256-PAYLOAD";
        private const string HeaderDate = ":date";
        private const string HeaderChunkSignature = ":chunk-signature";

        private readonly string _secretKey;
        private readonly string _region;
        private readonly string _service;

        private string _previousSignature;

        /// <summary>
        /// Constructe an isntance of the event signer.
        /// </summary>
        /// <param name="secretKey">The AWS secret key used to sign the initial request. All events must be signed with the same secret key.</param>
        /// <param name="region">The region to authenticate for.</param>
        /// <param name="service">The service to authenticate for.</param>
        /// <param name="requestSignature">The signature computed for the original request.</param>
        public AWS4EventSigner(string secretKey, string region, string service, string requestSignature)
        {
            _secretKey = secretKey;
            _region = region;
            _service = service;
            _previousSignature = requestSignature;
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
        public Task<byte[]> SignEventAsync(byte[] eventBytes)
        {
            var timestamp = AWSSDKUtils.CorrectedUtcNow;

            var signedHeaders = new List<IEventStreamHeader>();

            var signedDateHeader = new EventStreamHeader(HeaderDate) { HeaderType = EventStreamHeaderType.String };
            signedDateHeader.SetTimestamp(timestamp);
            signedHeaders.Add(signedDateHeader);

            var dateHeaderBuffer = new byte[15];
            signedDateHeader.WriteToBuffer(dateHeaderBuffer, 0);

            // To be as accurate as possible with the date used for signing, we will read the date header back from the buffer to
            // get the exact value that is being signed, instead of using the original timestamp which could be different from
            // the value in the header due to precision loss when converting to and from the timestamp format used in event stream headers.
            var ignoreNewOffSet = 0;
            var evnt = EventStreamHeader.FromBuffer(dateHeaderBuffer, 0, ref ignoreNewOffSet);
            var formattedDateStamp = evnt.AsTimestamp().ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat);

            var stringToSign = new StringBuilder();
            stringToSign.Append(Sha256Payload);
            stringToSign.Append("\n");
            stringToSign.Append(formattedDateStamp);
            stringToSign.Append("\n");
            stringToSign.Append($"{timestamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat)}/{_region}/{_service}/aws4_request");
            stringToSign.Append("\n");
            stringToSign.Append(_previousSignature);
            stringToSign.Append("\n");
            stringToSign.Append(AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(dateHeaderBuffer), true));
            stringToSign.Append("\n");
            stringToSign.Append(AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(eventBytes), true));

            var signature = AWS4Signer.ComputeKeyedHash(AWS4Signer.SignerAlgorithm, AWS4Signer.ComposeSigningKey(_secretKey, _region, timestamp.ToString(AWSSDKUtils.ISO8601BasicDateFormat), _service), UTF8Encoding.UTF8.GetBytes(stringToSign.ToString()));

            var signedSignatureHeader = new EventStreamHeader(HeaderChunkSignature) { HeaderType = EventStreamHeaderType.String };
            signedSignatureHeader.SetByteBuf(signature);
            signedHeaders.Add(signedSignatureHeader);

            var signedMessage = new EventStreamMessage(signedHeaders, eventBytes);
            var signedMessageBytes = signedMessage.ToByteArray();

            _previousSignature = AWSSDKUtils.ToHex(signature, true);

            return Task.FromResult(signedMessageBytes);
        }
    }
}
