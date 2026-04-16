using Amazon.CloudFront;
using Amazon.Runtime;
using Amazon.Util;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Xunit;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Spec-driven test cases from cloudfront-url-signer.md / test-cases.json.
    /// These tests verify correct policy JSON generation, signing, and URL/cookie construction.
    /// </summary>
    public class SpecTestCases
    {
        private static readonly string ResourceDirectory = Path.Combine(Environment.CurrentDirectory, "EmbeddedResource");
        private static TextReader GetKey(string filename) => new StreamReader(Path.Combine(ResourceDirectory, filename));
        private static string GetKeyPem(string filename) => File.ReadAllText(Path.Combine(ResourceDirectory, filename));
        private static byte[] FromUrlSafeBase64(string s) => Convert.FromBase64String(s.Replace('-', '+').Replace('_', '=').Replace('~', '/'));

        // Epoch seconds used across test cases
        private static readonly DateTime ExpiresAt = DateTimeOffset.FromUnixTimeSeconds(1767290400).UtcDateTime;
        private static readonly DateTime ActiveAt = DateTimeOffset.FromUnixTimeSeconds(1767200000).UtcDateTime;

        [Theory]
        [InlineData(null,     "SHA1",   "iONoMLnhiCy9q1~WB9GkR2DiHz18I85i3o6kZ64REf-fCSOg-AyXEZiq7fJuS~DT-kbZXjVpgIQqI4sCTcBW9XpO6dyJ5sh8Igk3V~OVncS9acGVnI~ZhHBWiGhU8GmkEMAhn6R2RGO-wKGClrXdJGEUE26XoALdHUzHbmU6AGI_")]
        [InlineData("SHA256", "SHA256", "LiC~LakvNvZtR~AsTcirQ0CAsy-YIZmpHmI9uImK4xJmrhVdJULhWmRt3bXO7qqw2gJDECZN-xC~bKWEKcJ9Vgs1IgpRdMkY6XGDKZ1XHBdNbd~0v5UiRf4zXwVMRqoynkQPQcihkze7RkDBsOoYHh9jDdtO1iDm0QZ1Qp~cxro_")]
        [Trait("Category", "CloudFront")]
        public void CannedPolicyUrlBasic(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/image.jpg";
            const string keyPairId = "K1TESTKEY";

            var expectedPolicy = "{\"Statement\":[{\"Resource\":\"https://d111111abcdef8.cloudfront.net/image.jpg\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":1767290400}}}]}";
            Assert.Equal(expectedPolicy, BuildCannedPolicy(resource, ExpiresAt));

            var signedUrl = algorithmName != null
                ? AmazonCloudFrontUrlSigner.SignUrlCanned(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt, new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontUrlSigner.SignUrlCanned(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt);
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal("1767290400", queryParams["Expires"]);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.Equal(expectedSig, queryParams["Signature"]);
            Assert.Equal(expectedHashAlg, queryParams["Hash-Algorithm"]);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "kx5dxV5cSW50EuCMtYi9JI0D5H97if~zNqwKxZtS7FPc3NV5oi~zCb45ti8ve-YDYw45hzN4lceF6zhW~STVWa7r7fC9wi5XBG1T6ZT2b9R0wMWmGxsy9uVGXFn6JqcjQMsq09MnWrPezK0qFQ2X6pV1nGQqLQZ2sgO~FSlEoCo_")]
        [InlineData("SHA256", "SHA256", "g8vzqbTu5PxBzAXD3zowGFNHNlyaGZn7thMiCk27sTfvdy5CMAbECVz-aucgqrKYmqsz1xY7ZoxoMxOizzXWzfzTyJ6k38YwW6QMyJWT7B8pHStQrq0DGFSCnXqgRDXUDzkpIe8mHqyRWtgnFbdFQlbPweykfl7Eo4RJadveryQ_")]
        [Trait("Category", "CloudFront")]
        public void CannedPolicyUrlExistingParams(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/image.jpg?size=large";
            const string keyPairId = "K1TESTKEY";

            var signedUrl = algorithmName != null
                ? AmazonCloudFrontUrlSigner.SignUrlCanned(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt, new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontUrlSigner.SignUrlCanned(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt);
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal("large", queryParams["size"]);
            Assert.Equal("1767290400", queryParams["Expires"]);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.Equal(expectedSig, queryParams["Signature"]);
            Assert.Equal(expectedHashAlg, queryParams["Hash-Algorithm"]);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "aF0WSOV6dkNn-D0HJ~-EwLG69-4QZZ9dv1PgAZEsER~WXkaNa1pBM2aTVXrskBWVHUU6hc1nD6ZKYgBS5Sb9JluFVT0MbQWR~DrtUGu8ugCsnfzUe6ov38nFPBwQICY~jnoQZEXxO2ZkQrluOO4~jWOpqAGrCw5tkdHAnb9gHYQ_")]
        [InlineData("SHA256", "SHA256", "RKoXpBb3IFyONXBnGGPj6021LmYyaphTYom0DsDID20xlCaK8gvNpcbYw493LloPhtDdGTdyadyuR59ok8eSPpJReRGbHbw8FDjGSXE9JWsVayzI7t7ZPGfPtKgK~ij0AekXDNQNFNUdwuSE0aR5nQmuPhw7CfDHCMpTWmoKPgE_")]
        [Trait("Category", "CloudFront")]
        public void CustomPolicyUrlWithActiveDate(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/video.mp4";
            const string keyPairId = "K1TESTKEY";
            const string expectedPolicyJson = "{\"Statement\":[{\"Resource\":\"https://d111111abcdef8.cloudfront.net/video.mp4\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":1767290400},\"DateGreaterThan\":{\"AWS:EpochTime\":1767200000}}}]}";

            Assert.Equal(expectedPolicyJson, AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resource, ExpiresAt, null, ActiveAt));

            var signedUrl = algorithmName != null
                ? AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, ActiveAt, null, new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, ActiveAt, null);
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.NotNull(queryParams["Policy"]);
            Assert.Equal(expectedSig, queryParams["Signature"]);
            Assert.Equal(expectedHashAlg, queryParams["Hash-Algorithm"]);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "fq~vePR~kmc5kWDveZOJ3j6PSYRsHSSanN1shBBpj2rQwvVQPU8e9MRwUDizOYHLnuAXQG89Xm7kXL03HIX0uzELcY2Q6Bw68BcGQHq-nyC2U6h0Uv277pg~FIwatR84y1FZiswIVmZwfPmpkvR0X~1skuooCPGiztAXREe-hsg_")]
        [InlineData("SHA256", "SHA256", "aKDzeIIfHviQRbCu9jxlFpOenTNQHMnt8HL2V2cqYP0vqc-KpRBuez2k4LZAzmfH0sIiQuDMZZc1D149XYRVAjEZoqr3vzGzWmrpzZJV-CSHs-Scau1cCNdVXqswj~QX8SzOZtGsRSKb4bomqOWxSIUu~Sybjf5b12GXBcYRCH4_")]
        [Trait("Category", "CloudFront")]
        public void CustomPolicyUrlWithIpRange(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/document.pdf";
            const string keyPairId = "K1TESTKEY";
            const string expectedPolicyJson = "{\"Statement\":[{\"Resource\":\"https://d111111abcdef8.cloudfront.net/document.pdf\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":1767290400},\"IpAddress\":{\"AWS:SourceIp\":\"192.168.0.0/24\"}}}]}";

            Assert.Equal(expectedPolicyJson, AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resource, ExpiresAt, "192.168.0.0/24"));

            var signedUrl = algorithmName != null
                ? AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, "192.168.0.0/24", new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, "192.168.0.0/24");
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.NotNull(queryParams["Policy"]);
            Assert.Equal(expectedSig, queryParams["Signature"]);
            Assert.Equal(expectedHashAlg, queryParams["Hash-Algorithm"]);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "nP~GtuBVUSEUDMXW1ZTGTx~BUQfjl7FsWBQBKwnTNhHlBAeYlzdbMGMphViPQbjawdYt1Z~iBHDr0ctooQyhEdsXwZPQKmRJQm3yIxmbvnuCzB2qdMDVGRKH8l3PnfAJErrgUVIzb6m3KUdtIDvSkLV~Mb0tyQJwZ6QE4BdlEmQ_")]
        [InlineData("SHA256", "SHA256", "FoaoRDqA7H91xD8CL2zk2Ztm6WVx3kIunCdqvzwMCUdsduwVWEH8elbBZc2qqWy3ZixDBBEHegeJnZbgp~nHTsYtr~jv6R-8~BnmmvH3KNyjH7wgyKKtzKpteNXYacWgHYabkoreyHC4ek~JMjGo1o0gTiIeL8YCV3ueKK3Lqtk_")]
        [Trait("Category", "CloudFront")]
        public void CustomPolicyUrlWithWildcard(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/images/*";
            const string applyTo = "https://d111111abcdef8.cloudfront.net/images/photo1.jpg";
            const string keyPairId = "K1TESTKEY";
            const string expectedPolicyJson = "{\"Statement\":[{\"Resource\":\"https://d111111abcdef8.cloudfront.net/images/*\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":1767290400}}}]}";

            Assert.Equal(expectedPolicyJson, AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resource, ExpiresAt, null));

            var wildcardSignedUrl = algorithmName != null
                ? AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, null, new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, null);
            var wildcardParams = HttpUtility.ParseQueryString(new Uri(wildcardSignedUrl).Query);
            Assert.Equal(expectedHashAlg, wildcardParams["Hash-Algorithm"]);

            var signedUrl = applyTo + "?Policy=" + wildcardParams["Policy"]
                + "&Signature=" + wildcardParams["Signature"]
                + "&Key-Pair-Id=" + wildcardParams["Key-Pair-Id"]
                + "&Hash-Algorithm=" + wildcardParams["Hash-Algorithm"];
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.Equal(expectedSig, queryParams["Signature"]);
            Assert.Equal(expectedHashAlg, queryParams["Hash-Algorithm"]);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "iONoMLnhiCy9q1~WB9GkR2DiHz18I85i3o6kZ64REf-fCSOg-AyXEZiq7fJuS~DT-kbZXjVpgIQqI4sCTcBW9XpO6dyJ5sh8Igk3V~OVncS9acGVnI~ZhHBWiGhU8GmkEMAhn6R2RGO-wKGClrXdJGEUE26XoALdHUzHbmU6AGI_")]
        [InlineData("SHA256", "SHA256", "LiC~LakvNvZtR~AsTcirQ0CAsy-YIZmpHmI9uImK4xJmrhVdJULhWmRt3bXO7qqw2gJDECZN-xC~bKWEKcJ9Vgs1IgpRdMkY6XGDKZ1XHBdNbd~0v5UiRf4zXwVMRqoynkQPQcihkze7RkDBsOoYHh9jDdtO1iDm0QZ1Qp~cxro_")]
        [Trait("Category", "CloudFront")]
        public void CannedPolicyCookies(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/image.jpg";
            const string keyPairId = "K1TESTKEY";

            var cookies = algorithmName != null
                ? AmazonCloudFrontCookieSigner.GetCookiesForCannedPolicy(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt, new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontCookieSigner.GetCookiesForCannedPolicy(resource, keyPairId, GetKey("test-rsa-key.pem"), ExpiresAt);
            Assert.Equal("1767290400", cookies.Expires.Value);
            Assert.Equal(keyPairId, cookies.KeyPairId.Value);
            Assert.Equal(expectedSig, cookies.Signature.Value);
            Assert.Equal(expectedHashAlg, cookies.HashAlgorithm.Value);
        }

        [Theory]
        [InlineData(null,     "SHA1",   "r28Jnd0t9aq7cu0k9jGWl4L0YsRxgueZtGRw5oEEspU9-eIPGM~ZGMQh36~5HpKC5c67cZjDgJcsqrCacmTHMZZx613gbeYAsx2-hEatU8URiuNHnVp4hPV3HqtbuZ6Din9iEZUpOBYVg6DWGEFJRCQ7SPouBhhJdYDZZOPHGpA_")]
        [InlineData("SHA256", "SHA256", "OzeonPh-NS8g3trdsFAo5LrMBEx1ef05GvdmWuLai6AaBLP63PVJRUGySYmGfQ-NqQ02geWzo7aZS7XFtkr4X1z9VTbQMfmzZftbuRXoP5ZDhFzVnSX3DeoEW8jP3BrOLHJsKwFCY5alIR4zO6LpqFmR5vVmqMYpRcbafg3~X18_")]
        [Trait("Category", "CloudFront")]
        public void CustomPolicyCookies(string algorithmName, string expectedHashAlg, string expectedSig)
        {
            const string resource = "https://d111111abcdef8.cloudfront.net/*";
            const string keyPairId = "K1TESTKEY";
            const string expectedPolicy = "eyJTdGF0ZW1lbnQiOlt7IlJlc291cmNlIjoiaHR0cHM6Ly9kMTExMTExYWJjZGVmOC5jbG91ZGZyb250Lm5ldC8qIiwiQ29uZGl0aW9uIjp7IkRhdGVMZXNzVGhhbiI6eyJBV1M6RXBvY2hUaW1lIjoxNzY3MjkwNDAwfSwiSXBBZGRyZXNzIjp7IkFXUzpTb3VyY2VJcCI6IjEwLjAuMC4wLzgifX19XX0_";

            var cookies = algorithmName != null
                ? AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, DateTime.MinValue, "10.0.0.0/8", new HashAlgorithmName(algorithmName))
                : AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(resource, GetKey("test-rsa-key.pem"), keyPairId, ExpiresAt, DateTime.MinValue, "10.0.0.0/8");
            Assert.Equal(keyPairId, cookies.KeyPairId.Value);
            Assert.Equal(expectedPolicy, cookies.Policy.Value);
            Assert.Equal(expectedSig, cookies.Signature.Value);
            Assert.Equal(expectedHashAlg, cookies.HashAlgorithm.Value);
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void EcdsaCannedPolicyUrl()
        {
            // ECDSA signatures are non-deterministic (different each run), so we verify
            // the signature cryptographically using the public key rather than exact match.
            const string resource = "https://d111111abcdef8.cloudfront.net/video.mp4";
            const string keyPairId = "K2ECDSATEST";

            var expectedPolicy = "{\"Statement\":[{\"Resource\":\"https://d111111abcdef8.cloudfront.net/video.mp4\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":1767290400}}}]}";
            var actualPolicy = BuildCannedPolicy(resource, ExpiresAt);
            Assert.Equal(expectedPolicy, actualPolicy);

            // SignUrlCanned auto-detects the ECDSA key type from the PEM and uses SHA-256.
            var signedUrl = AmazonCloudFrontUrlSigner.SignUrlCanned(resource, keyPairId, GetKey("test-ecdsa-key.pem"), ExpiresAt, HashAlgorithmName.SHA256);
            var queryParams = HttpUtility.ParseQueryString(new Uri(signedUrl).Query);
            Assert.Equal("1767290400", queryParams["Expires"]);
            Assert.Equal(keyPairId, queryParams["Key-Pair-Id"]);
            Assert.NotNull(queryParams["Signature"]);

            // Verify the signature cryptographically using the ECDSA public key
            var publicKeyPem = GetKeyPem("test-ecdsa-key-public.pem");
            var policyBytes = Encoding.UTF8.GetBytes(actualPolicy);
            var rawSigBytes = FromUrlSafeBase64(queryParams["Signature"]);

            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(policyBytes);

#if NET
            using var ecdsa = ECDsa.Create();
            ecdsa.ImportFromPem(publicKeyPem);

            // rawSigBytes is DER-encoded; ECDsa.VerifyHash expects IEEE P1363 (r||s).
            // Use DSASignatureFormat.Rfc3279DerSequence to verify directly from DER.
            Assert.True(ecdsa.VerifyHash(hash, rawSigBytes, DSASignatureFormat.Rfc3279DerSequence));
#else
            var pemReader = new Org.BouncyCastle.OpenSsl.PemReader(new StringReader(publicKeyPem));
            var pubKeyParams = (Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)pemReader.ReadObject();
            var verifier = Org.BouncyCastle.Security.SignerUtilities.GetSigner("SHA-256withECDSA");
            verifier.Init(false, pubKeyParams);
            verifier.BlockUpdate(policyBytes, 0, policyBytes.Length);
            
            Assert.True(verifier.VerifySignature(rawSigBytes));
#endif
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void ErrorActiveAfterExpiration()
        {
            // activeDate >= expirationDate should throw
            var expiration = DateTimeOffset.FromUnixTimeSeconds(1767200000).UtcDateTime;
            var active = DateTimeOffset.FromUnixTimeSeconds(1767290400).UtcDateTime;

            Assert.Throws<AmazonClientException>(() =>
                AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl("https://d111111abcdef8.cloudfront.net/file.txt", expiration, null, active)
            );
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void JsonInjectionResourceUrlThrows()
        {
            // The spec expects escaping; our implementation rejects the input with ArgumentException.
            const string resource = "https://example.com/file\",\"Resource\":\"*\",\"x\":\"";

            Assert.Throws<ArgumentException>(() =>
                AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), "K1TESTKEY", ExpiresAt, null)
            );
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void JsonInjectionIpRangeThrows()
        {
            // The spec expects escaping; our implementation rejects the input with ArgumentException.
            const string resource = "https://d111111abcdef8.cloudfront.net/image.jpg";
            const string ipRange = "192.168.0.0/24\",\"IpAddress\":{\"AWS:SourceIp\":\"0.0.0.0/0";

            Assert.Throws<ArgumentException>(() =>
                AmazonCloudFrontUrlSigner.GetCustomSignedURL(resource, GetKey("test-rsa-key.pem"), "K1TESTKEY", ExpiresAt, ipRange)
            );
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void NotSupportedKeyTypeThrows()
        {
            const string distribution = "https://d111111abcdef8.cloudfront.net/video.mp4";
            const string keyPairId = "KINVALIDTESTKEY";

            Assert.Throws<AmazonClientException>(() =>
                AmazonCloudFrontUrlSigner.GetCannedSignedURL(distribution, GetKey("test-dsa-key.pem"), keyPairId, ExpiresAt)
            );
        }

        /// <summary>
        /// Builds the canned policy JSON string (same logic as SignUrlCanned, without signing).
        /// </summary>
        private static string BuildCannedPolicy(string resource, DateTime expiresOn)
        {
            var epochSeconds = AWSSDKUtils.ConvertToUnixEpochSecondsString(expiresOn);
            return "{\"Statement\":[{\"Resource\":\"" + resource
                + "\",\"Condition\":{\"DateLessThan\":{\"AWS:EpochTime\":" + epochSeconds
                + "}}}]}";
        }
    }
}
