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
using System.IO;
using System.Security.Cryptography;
using Amazon.CloudFront;
using Xunit;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests the <see cref="ICloudFrontSigner"/> delegation seam (used to sign with AWS KMS or
    /// another external key). The key invariant: signing through an <see cref="ICloudFrontSigner"/>
    /// must produce byte-for-byte the same policy/signature/cookies as the in-process private-key
    /// overloads — only the signature computation is delegated.
    /// </summary>
    public class SignerDelegationTest
    {
        private static string ReadPrivateKeyPem()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "EmbeddedResource", "sample.rsa.private.key.txt");
            return File.ReadAllText(path);
        }

        // RSA.ImportFromPem is .NET 5+; these equivalence tests build an RSA key from the PEM to
        // stand in for an external signer (e.g. KMS), so they compile only where that API exists.
        // The argument-validation tests below need no key and run on all target frameworks.
#if NET5_0_OR_GREATER
        // A DelegateCloudFrontSigner backed by the same RSA key stands in for an external signer
        // (e.g. KMS RSASSA_PKCS1_V1_5_SHA_256). It must produce identical output to the raw-key path.
        [Fact]
        [Trait("Category", "CloudFront")]
        public void CustomCookies_ViaSigner_MatchPrivateKeyOverload()
        {
            var pem = ReadPrivateKeyPem();
            using var rsa = RSA.Create();
            rsa.ImportFromPem(pem);

            const string keyPairId = "DelegateKeyPairId";
            const string resource = "https://awesome.dot.com/private/*";
            var expiresOn = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            var activeFrom = new DateTime(2023, 12, 1, 12, 0, 0, DateTimeKind.Utc);

            var viaKey = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                resource, new StringReader(pem), keyPairId, expiresOn, activeFrom, null, HashAlgorithmName.SHA256);

            var signer = new DelegateCloudFrontSigner(
                HashAlgorithmName.SHA256,
                policyBytes => rsa.SignData(policyBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
            var viaSigner = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                resource, signer, keyPairId, expiresOn, activeFrom, null);

            Assert.Equal(viaKey.Policy.Value, viaSigner.Policy.Value);
            Assert.Equal(viaKey.Signature.Value, viaSigner.Signature.Value);
            Assert.Equal(viaKey.KeyPairId.Value, viaSigner.KeyPairId.Value);
            Assert.Equal("SHA256", viaSigner.HashAlgorithm.Value);
            Assert.Equal(viaKey.HashAlgorithm.Value, viaSigner.HashAlgorithm.Value);
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void CustomUrl_ViaSigner_MatchesPrivateKeyOverload()
        {
            var pem = ReadPrivateKeyPem();
            using var rsa = RSA.Create();
            rsa.ImportFromPem(pem);

            const string keyPairId = "DelegateKeyPairId";
            const string url = "https://awesome.dot.com/private/file.txt";
            var expiresOn = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            var activeFrom = new DateTime(2023, 12, 1, 12, 0, 0, DateTimeKind.Utc);

            var viaKey = AmazonCloudFrontUrlSigner.GetCustomSignedURL(
                url, new StringReader(pem), keyPairId, expiresOn, activeFrom, null, HashAlgorithmName.SHA256);

            var signer = new DelegateCloudFrontSigner(
                HashAlgorithmName.SHA256,
                policyBytes => rsa.SignData(policyBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
            var viaSigner = AmazonCloudFrontUrlSigner.GetCustomSignedURL(
                url, signer, keyPairId, expiresOn, activeFrom, null);

            Assert.Equal(viaKey, viaSigner);
        }

        // ECDSA is non-deterministic, so two signings won't match byte-for-byte; instead prove the
        // seam passes an ECDSA (P-256, DER) signature through untouched by verifying the emitted
        // cookie signature with the public key. This mirrors how a KMS ECDSA_SHA_256 signature
        // (also DER-encoded) would flow through DelegateCloudFrontSigner unchanged.
        [Fact]
        [Trait("Category", "CloudFront")]
        public void CustomCookies_ViaEcdsaSigner_ProduceVerifiableSignature()
        {
            using var ecdsa = ECDsa.Create(ECCurve.NamedCurves.nistP256);

            const string keyPairId = "EcdsaKeyPairId";
            const string resource = "https://awesome.dot.com/private/*";
            var expiresOn = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            var activeFrom = new DateTime(2023, 12, 1, 12, 0, 0, DateTimeKind.Utc);

            var signer = new DelegateCloudFrontSigner(
                HashAlgorithmName.SHA256,
                policyBytes => ecdsa.SignData(policyBytes, HashAlgorithmName.SHA256, DSASignatureFormat.Rfc3279DerSequence));
            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                resource, signer, keyPairId, expiresOn, activeFrom, null);

            Assert.Equal("SHA256", cookies.HashAlgorithm.Value);

            // Reverse CloudFront's url-safe base64 (- _ ~  ->  + = /) and verify against the policy.
            var policyBytes = System.Text.Encoding.UTF8.GetBytes(
                UrlSafeToBase64Decode(cookies.Policy.Value));
            var signatureBytes = Convert.FromBase64String(
                cookies.Signature.Value.Replace('-', '+').Replace('_', '=').Replace('~', '/'));

            Assert.True(ecdsa.VerifyData(
                policyBytes, signatureBytes, HashAlgorithmName.SHA256, DSASignatureFormat.Rfc3279DerSequence));
        }

        private static string UrlSafeToBase64Decode(string urlSafe)
        {
            var b64 = urlSafe.Replace('-', '+').Replace('_', '=').Replace('~', '/');
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(b64));
        }
#endif

        [Fact]
        [Trait("Category", "CloudFront")]
        public void DelegateSigner_RejectsUnsupportedAlgorithm()
        {
            Assert.Throws<ArgumentException>(() =>
                new DelegateCloudFrontSigner(HashAlgorithmName.SHA512, _ => Array.Empty<byte>()));
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void DelegateSigner_RejectsNullDelegate()
        {
            Assert.Throws<ArgumentNullException>(() =>
                new DelegateCloudFrontSigner(HashAlgorithmName.SHA256, null));
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void SignerOverloads_RejectNullSigner()
        {
            var expiresOn = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            Assert.Throws<ArgumentNullException>(() =>
                AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                    "https://awesome.dot.com/private/*", (ICloudFrontSigner)null, "kp", expiresOn, DateTime.MinValue, null));
        }
    }
}
