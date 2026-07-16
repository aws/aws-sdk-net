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

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// A neutral description of the HTTP request to sign with <see cref="AWSSigV4Signer"/>.
    /// This is not tied to any particular HTTP client type.
    /// </summary>
    public class AWSSigningRequest
    {
        /// <summary>
        /// The HTTP method, e.g. "GET" or "POST".
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// The full request URI, including any query string.
        /// </summary>
        public Uri RequestUri { get; set; }

        /// <summary>
        /// Caller-supplied headers to include in the signature. To sign a precomputed body hash
        /// without the signer reading the body, set an "x-amz-content-sha256" entry here (see the
        /// remarks on <see cref="AWSSigningParameters.SignPayload"/>).
        /// </summary>
        /// <remarks>
        /// One value per header name. If a header carries multiple values, supply them here as a
        /// single comma-delimited string with the leading and trailing whitespace of each value
        /// trimmed (for example "value1,value2"), in the same order and form they are sent on the
        /// wire. This is the value SigV4 canonicalization signs; an untrimmed or differently-joined
        /// value produces a signature the service will reject.
        /// </remarks>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// The optional request body as a byte array. Mutually exclusive with <see cref="ContentStream"/>.
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// The optional request body as a stream. Mutually exclusive with <see cref="Content"/>.
        /// When payload signing is enabled and no precomputed hash is supplied, the stream must be
        /// seekable so its hash can be computed and the stream rewound.
        /// </summary>
        public Stream ContentStream { get; set; }
    }
}
