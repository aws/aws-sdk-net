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

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// The signing configuration for <see cref="AWSSigV4Signer"/>: who is signing,
    /// for which region, and for which service.
    /// </summary>
    public class AWSSigV4Parameters
    {
        /// <summary>
        /// The credentials to sign with. Any <see cref="AWSCredentials"/> is accepted; the signer
        /// resolves them via <see cref="AWSCredentials.GetCredentials"/> (sync path) or
        /// <see cref="AWSCredentials.GetCredentialsAsync"/> (async path). A session token, if present,
        /// is signed automatically (as the X-Amz-Security-Token header for header signing, or as a
        /// query parameter for presigning).
        /// </summary>
        public AWSCredentials Credentials { get; set; }

        /// <summary>
        /// The signing region, e.g. <see cref="RegionEndpoint.USEast1"/>.
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// The signing service name, e.g. "execute-api" or "sts".
        /// <para>
        /// For an AWS service, this value can be looked up via the <c>AuthenticationServiceName</c>
        /// property on the service client's config object (e.g. <c>new AmazonS3Config().AuthenticationServiceName</c>).
        /// </para>
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Whether to sign the request payload. Defaults to <c>true</c>.
        /// <para>
        /// When <c>false</c>, the body is signed as UNSIGNED-PAYLOAD and the request must be sent over
        /// HTTPS. This is the outer gate for body signing: when <c>false</c>, any supplied
        /// "x-amz-content-sha256" header is rejected as contradictory.
        /// </para>
        /// <para>
        /// When <c>true</c>: a supplied "x-amz-content-sha256" header is used verbatim (the body is not
        /// read); otherwise the body (<see cref="AWSSigningRequest.Content"/> or a seekable
        /// <see cref="AWSSigningRequest.ContentStream"/>) is hashed. A non-seekable stream with no
        /// supplied hash is rejected.
        /// </para>
        /// </summary>
        public bool SignPayload { get; set; } = true;

        /// <summary>
        /// A fixed signing time. When null (the default), the signer uses the clock-skew-corrected
        /// UTC now for the request endpoint. Supply a value for deterministic/offline signing,
        /// test-vector reproduction, or batch-presigning with a known validity window.
        /// </summary>
        public DateTime? SignedAt { get; set; }
    }
}
