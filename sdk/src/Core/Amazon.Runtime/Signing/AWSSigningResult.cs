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

using System.Collections.Generic;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// The result of header-based signing with <see cref="AWSSigV4Signer.Sign"/> /
    /// <see cref="AWSSigV4Signer.SignAsync"/>.
    /// </summary>
    public class AWSSigningResult
    {
        internal AWSSigningResult(IDictionary<string, string> headers, string authorizationHeader)
        {
            Headers = headers;
            AuthorizationHeader = authorizationHeader;
        }

        /// <summary>
        /// The headers the caller must add to the outbound request: <c>Authorization</c>,
        /// <c>X-Amz-Date</c>, <c>X-Amz-Content-Sha256</c>, and <c>X-Amz-Security-Token</c>
        /// (when signing with session credentials).
        /// </summary>
        public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// The computed <c>Authorization</c> header value. Also present in <see cref="Headers"/>.
        /// </summary>
        public string AuthorizationHeader { get; }
    }
}
