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

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// The result of presigned-URL signing with <see cref="AWSSigV4Signer.Presign"/> /
    /// <see cref="AWSSigV4Signer.PresignAsync"/>.
    /// </summary>
    public class PresignResult
    {
        internal PresignResult(Uri uri, IDictionary<string, string> signedHeaders)
        {
            Uri = uri;
            SignedHeaders = signedHeaders;
        }

        /// <summary>
        /// The presigned URL.
        /// </summary>
        public Uri Uri { get; }

        /// <summary>
        /// The headers that were included in the signature and therefore MUST be sent by whoever
        /// consumes the URL. <c>host</c> is implicit and omitted; anything extra that was signed
        /// (e.g. <c>x-k8s-aws-id</c>) appears here. If a signed header beyond <c>host</c> is not
        /// resent, the service rejects the signature.
        /// </summary>
        public IDictionary<string, string> SignedHeaders { get; }
    }
}
