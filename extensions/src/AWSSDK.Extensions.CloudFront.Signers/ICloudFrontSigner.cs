/*
 * Copyright Adappt Limited. All Rights Reserved.
 *
 * Contributed to the AWS SDK for .NET under the Apache License, Version 2.0
 * (the "License"). You may not use this file except in compliance with the
 * License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Security.Cryptography;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Signs a CloudFront policy document. Implement this to sign with a key the process does
    /// not hold in memory — most notably an <b>AWS KMS</b> asymmetric key (the private key
    /// never leaves KMS), or an HSM / external key service.
    /// <para>
    /// The <see cref="AmazonCloudFrontUrlSigner"/> and <see cref="AmazonCloudFrontCookieSigner"/>
    /// overloads that take an <see cref="ICloudFrontSigner"/> build the policy document and the
    /// url-safe encoding exactly as the private-key overloads do; only the signature computation
    /// is delegated here. This keeps the extension free of any hard dependency on KMS while still
    /// enabling it.
    /// </para>
    /// </summary>
    /// <remarks>
    /// The implementation is signature-algorithm agnostic — both key types CloudFront accepts work
    /// through the same seam, so callers choose per key:
    /// <list type="bullet">
    /// <item><description>
    /// <b>RSA</b> (2048-bit): sign with KMS <c>RSASSA_PKCS1_V1_5_SHA_256</c> and return
    /// <see cref="HashAlgorithmName.SHA256"/>. Use PKCS#1 v1.5 — <b>not</b> RSASSA-PSS: although KMS
    /// recommends PSS in general, CloudFront only verifies PKCS#1 v1.5 RSA signatures.
    /// </description></item>
    /// <item><description>
    /// <b>ECDSA</b> (NIST P-256 / <c>ECC_NIST_P256</c>): sign with KMS <c>ECDSA_SHA_256</c> and
    /// return <see cref="HashAlgorithmName.SHA256"/>. KMS returns the signature DER-encoded
    /// (ANSI X9.62 / RFC 3279), which is exactly the form CloudFront expects — no re-encoding.
    /// </description></item>
    /// </list>
    /// A CloudFront policy document is well under KMS's 4096-byte <c>Message</c> limit, so signing
    /// the policy bytes directly with <c>MessageType=RAW</c> is correct; there is no need to
    /// pre-hash and use <c>MessageType=DIGEST</c>.
    /// </remarks>
    /// <example>
    /// Sign CloudFront cookies with an AWS KMS RSA key (SHA-256), so the private key never leaves
    /// KMS. CloudFront supports SHA-256 signed URLs/cookies; KMS RSA signing is
    /// <c>RSASSA_PKCS1_V1_5_SHA_256</c>, which produces exactly the signature CloudFront verifies.
    /// <code>
    /// using Amazon.KeyManagementService;
    /// using Amazon.KeyManagementService.Model;
    ///
    /// // A DelegateCloudFrontSigner adapts any "sign these bytes" function into ICloudFrontSigner.
    /// var kms = new AmazonKeyManagementServiceClient();
    /// var signer = new DelegateCloudFrontSigner(
    ///     HashAlgorithmName.SHA256,
    ///     policyBytes =>
    ///     {
    ///         var response = kms.SignAsync(new SignRequest
    ///         {
    ///             KeyId = kmsKeyId,
    ///             Message = new MemoryStream(policyBytes),
    ///             MessageType = MessageType.RAW,
    ///             SigningAlgorithm = SigningAlgorithmSpec.RSASSA_PKCS1_V1_5_SHA_256
    ///         }).GetAwaiter().GetResult();
    ///         return response.Signature.ToArray();
    ///     });
    ///
    /// var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
    ///     resourceUrlOrPath, signer, cloudFrontKeyPairId, expiresOn, activeFrom, ipRange);
    /// </code>
    /// </example>
    public interface ICloudFrontSigner
    {
        /// <summary>
        /// Signs the UTF-8 bytes of the CloudFront policy document and returns the raw signature
        /// together with the hash algorithm used.
        /// </summary>
        /// <param name="policyBytes">The UTF-8 encoded CloudFront policy document to sign.</param>
        /// <returns>
        /// The raw signature bytes and the hash algorithm used. For RSA the signature must be
        /// PKCS#1 v1.5; for ECDSA (P-256) it must be a DER-encoded (RFC 3279) signature. The hash
        /// algorithm is emitted as CloudFront's <c>Hash-Algorithm</c> / <c>CloudFront-Hash-Algorithm</c>
        /// (only <see cref="HashAlgorithmName.SHA1"/> and <see cref="HashAlgorithmName.SHA256"/> are
        /// valid for CloudFront; SHA-1 is RSA-only).
        /// </returns>
        (byte[] Signature, HashAlgorithmName Algorithm) Sign(byte[] policyBytes);
    }

    /// <summary>
    /// An <see cref="ICloudFrontSigner"/> backed by a caller-supplied signing function. Use this
    /// to plug in AWS KMS, an HSM, or any external signer without a compile-time dependency from
    /// this extension on those libraries (see the <see cref="ICloudFrontSigner"/> example).
    /// </summary>
    public sealed class DelegateCloudFrontSigner : ICloudFrontSigner
    {
        private readonly HashAlgorithmName _algorithm;
        private readonly Func<byte[], byte[]> _sign;

        /// <summary>
        /// Creates a signer from a function that maps the policy bytes to a raw CloudFront signature.
        /// </summary>
        /// <param name="algorithm">
        /// The hash algorithm the function signs with — <see cref="HashAlgorithmName.SHA256"/>
        /// (recommended; required for ECDSA) or <see cref="HashAlgorithmName.SHA1"/> (RSA only).
        /// </param>
        /// <param name="sign">
        /// Signs the UTF-8 policy bytes and returns the raw signature (PKCS#1 v1.5 for RSA, or a
        /// DER-encoded RFC 3279 signature for ECDSA P-256).
        /// </param>
        public DelegateCloudFrontSigner(HashAlgorithmName algorithm, Func<byte[], byte[]> sign)
        {
            if (algorithm != HashAlgorithmName.SHA1 && algorithm != HashAlgorithmName.SHA256)
            {
                throw new ArgumentException(
                    $"Unsupported hash algorithm for CloudFront: {algorithm}. Use HashAlgorithmName.SHA1 (RSA only) or HashAlgorithmName.SHA256.",
                    nameof(algorithm));
            }
            _algorithm = algorithm;
            _sign = sign ?? throw new ArgumentNullException(nameof(sign));
        }

        /// <inheritdoc/>
        public (byte[] Signature, HashAlgorithmName Algorithm) Sign(byte[] policyBytes)
        {
            var signature = _sign(policyBytes)
                ?? throw new InvalidOperationException("The CloudFront signing delegate returned a null signature.");
            return (signature, _algorithm);
        }
    }
}
